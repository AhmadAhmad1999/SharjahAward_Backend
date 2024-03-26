using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditOnAcheivment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arbitration_Arbitrator_ArbitratorId",
                table: "Arbitration");

            migrationBuilder.DropForeignKey(
                name: "FK_Arbitrator_Users_CreatedById",
                table: "Arbitrator");

            migrationBuilder.DropForeignKey(
                name: "FK_Arbitrator_Users_UpdatedById",
                table: "Arbitrator");

            migrationBuilder.DropForeignKey(
                name: "FK_ArbitratorClass_Arbitrator_ArbitratorClassId",
                table: "ArbitratorClass");

            migrationBuilder.DropForeignKey(
                name: "FK_ArbitratorInterview_Arbitrator_ArbitratorId",
                table: "ArbitratorInterview");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryArbitrator_Arbitrator_ArbitratorId",
                table: "CategoryArbitrator");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Arbitrator",
                table: "Arbitrator");

            migrationBuilder.DropIndex(
                name: "IX_Arbitrator_CreatedById",
                table: "Arbitrator");

            migrationBuilder.DropIndex(
                name: "IX_Arbitrator_UpdatedById",
                table: "Arbitrator");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e73d"));

            migrationBuilder.DropColumn(
                name: "EditeOnDistinctionField",
                table: "Achievements");

            migrationBuilder.DropColumn(
                name: "EditeOnProjects",
                table: "Achievements");

            migrationBuilder.DropColumn(
                name: "EditeOnSkillsAndExperiences",
                table: "Achievements");

            migrationBuilder.DropColumn(
                name: "EditeOnSocialMedia",
                table: "Achievements");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Arbitrator");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Arbitrator");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "Arbitrator");

            migrationBuilder.RenameTable(
                name: "Arbitrator",
                newName: "Arbitrators");

            migrationBuilder.AddColumn<Guid>(
                name: "RecordIdAsGuid",
                table: "DynamicAttributeValues",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Arbitrators",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "Arbitrators",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Arbitrators",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Arbitrators",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Arbitrators",
                table: "Arbitrators",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 355, DateTimeKind.Utc).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e7f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(2414), new DateTime(2024, 4, 15, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(2423), new DateTime(2024, 4, 10, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(2539), 2 });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(1552), new DateTime(2024, 4, 10, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(1659), new DateTime(2024, 4, 5, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(1669), 0 });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 26, 13, 26, 30, 358, DateTimeKind.Utc).AddTicks(9834), new DateTime(2024, 4, 5, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(1383), new DateTime(2024, 3, 31, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(1521), 1 });

            migrationBuilder.InsertData(
                table: "Agendas",
                columns: new[] { "Id", "ArabicTitle", "CreatedAt", "CreatedBy", "CurrentDate", "CycleId", "DateType", "DeletedAt", "EndDate", "EnglishTitle", "Icon", "LastModifiedAt", "LastModifiedBy", "StartDate", "Status", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e5f"), "اختبار عنوان جدول أعمال 5", new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(2709), null, null, new Guid("784454bd-2d6c-49ae-9e8a-1932bd15aac1"), 2, null, new DateTime(2024, 4, 25, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(2714), "Test Agenda Titile 5", "https://backend.stg.award-shj.ae/UploadedFiles/cancel (1).png", null, null, new DateTime(2024, 4, 20, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(2718), 2, false },
                    { new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e6f"), "اختبار عنوان جدول أعمال 4", new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(2674), null, null, new Guid("784454bd-2d6c-49ae-9e8a-1932bd15aac1"), 2, null, new DateTime(2024, 4, 20, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(2681), "Test Agenda Titile 4", "https://backend.stg.award-shj.ae/UploadedFiles/cancel (1).png", null, null, new DateTime(2024, 4, 15, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(2691), 2, false }
                });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(475));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(481));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(499));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(695));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(295));

            migrationBuilder.InsertData(
                table: "AttributeTableNames",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "LastModifiedAt", "LastModifiedBy", "Name", "isDeleted" },
                values: new object[,]
                {
                    { 2, new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(302), null, null, null, null, "Coordinator", false },
                    { 3, new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(311), null, null, null, null, "Arbitrator", false }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(8754), new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(8760), new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(8765), new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(8768), new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(8696), new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(8709), new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(8719), new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(8724), new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(8732) });

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(9935));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(9023));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: new Guid("784454bd-2d6c-49ae-9e8a-1932bd15aac1"),
                column: "Status",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(7656));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(7662));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(7185));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsRequired", "IsUnique" },
                values: new object[] { new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(7380), true, true });

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IsRequired", "IsUnique" },
                values: new object[] { new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(7397), true, true });

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(7406));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(7415));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(3039), new DateTime(2024, 3, 26, 15, 26, 30, 360, DateTimeKind.Local).AddTicks(3056) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(3201), new DateTime(2024, 3, 26, 15, 26, 30, 360, DateTimeKind.Local).AddTicks(3208) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(3224), new DateTime(2024, 3, 26, 15, 26, 30, 360, DateTimeKind.Local).AddTicks(3231) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(3247), new DateTime(2024, 3, 26, 15, 26, 30, 360, DateTimeKind.Local).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(2445));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(2853));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(2837));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 26, 13, 26, 30, 355, DateTimeKind.Utc).AddTicks(6038), new DateTime(2024, 3, 31, 13, 26, 30, 355, DateTimeKind.Utc).AddTicks(6074), new DateTime(2024, 3, 28, 13, 26, 30, 355, DateTimeKind.Utc).AddTicks(6090), new DateTime(2024, 3, 29, 13, 26, 30, 355, DateTimeKind.Utc).AddTicks(6092) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 26, 13, 26, 30, 355, DateTimeKind.Utc).AddTicks(6098), new DateTime(2024, 4, 3, 13, 26, 30, 355, DateTimeKind.Utc).AddTicks(6107), new DateTime(2024, 3, 31, 13, 26, 30, 355, DateTimeKind.Utc).AddTicks(6111), new DateTime(2024, 4, 1, 13, 26, 30, 355, DateTimeKind.Utc).AddTicks(6113) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(9369));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(9346));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 355, DateTimeKind.Utc).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 355, DateTimeKind.Utc).AddTicks(9958));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(149));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 356, DateTimeKind.Utc).AddTicks(138));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "DateOfWorkShop", "Time" },
                values: new object[] { new DateTime(2024, 3, 26, 13, 26, 30, 355, DateTimeKind.Utc).AddTicks(8680), new DateTime(2024, 4, 5, 13, 26, 30, 355, DateTimeKind.Utc).AddTicks(8696), "13:26:30.3559038" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                columns: new[] { "CreatedAt", "DateOfWorkShop", "Time" },
                values: new object[] { new DateTime(2024, 3, 26, 13, 26, 30, 355, DateTimeKind.Utc).AddTicks(9094), new DateTime(2024, 4, 15, 13, 26, 30, 355, DateTimeKind.Utc).AddTicks(9105), "13:26:30.3559117" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(3456));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(3497));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(8084));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 355, DateTimeKind.Utc).AddTicks(9727));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 355, DateTimeKind.Utc).AddTicks(9736));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 355, DateTimeKind.Utc).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 355, DateTimeKind.Utc).AddTicks(9494));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(6849));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(5264));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(5278));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(5445));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(5906));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(3712));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 359, DateTimeKind.Utc).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(183));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(211));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(228));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(242));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(5003));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 13, 26, 30, 360, DateTimeKind.Utc).AddTicks(4914));

            migrationBuilder.AddForeignKey(
                name: "FK_Arbitration_Arbitrators_ArbitratorId",
                table: "Arbitration",
                column: "ArbitratorId",
                principalTable: "Arbitrators",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArbitratorClass_Arbitrators_ArbitratorClassId",
                table: "ArbitratorClass",
                column: "ArbitratorClassId",
                principalTable: "Arbitrators",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArbitratorInterview_Arbitrators_ArbitratorId",
                table: "ArbitratorInterview",
                column: "ArbitratorId",
                principalTable: "Arbitrators",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryArbitrator_Arbitrators_ArbitratorId",
                table: "CategoryArbitrator",
                column: "ArbitratorId",
                principalTable: "Arbitrators",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arbitration_Arbitrators_ArbitratorId",
                table: "Arbitration");

            migrationBuilder.DropForeignKey(
                name: "FK_ArbitratorClass_Arbitrators_ArbitratorClassId",
                table: "ArbitratorClass");

            migrationBuilder.DropForeignKey(
                name: "FK_ArbitratorInterview_Arbitrators_ArbitratorId",
                table: "ArbitratorInterview");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryArbitrator_Arbitrators_ArbitratorId",
                table: "CategoryArbitrator");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Arbitrators",
                table: "Arbitrators");

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e5f"));

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e6f"));

            migrationBuilder.DeleteData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "RecordIdAsGuid",
                table: "DynamicAttributeValues");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Arbitrators");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "Arbitrators");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Arbitrators");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Arbitrators");

            migrationBuilder.RenameTable(
                name: "Arbitrators",
                newName: "Arbitrator");

            migrationBuilder.AddColumn<bool>(
                name: "EditeOnDistinctionField",
                table: "Achievements",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EditeOnProjects",
                table: "Achievements",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EditeOnSkillsAndExperiences",
                table: "Achievements",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EditeOnSocialMedia",
                table: "Achievements",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedById",
                table: "Arbitrator",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Arbitrator",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedById",
                table: "Arbitrator",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Arbitrator",
                table: "Arbitrator",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(7615));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e7f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7339), new DateTime(2024, 4, 15, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7342), new DateTime(2024, 4, 10, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7344), 1 });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7325), new DateTime(2024, 4, 10, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7329), new DateTime(2024, 4, 5, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7330), 2 });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate", "Status" },
                values: new object[] { new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7293), new DateTime(2024, 4, 5, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7302), new DateTime(2024, 3, 31, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7317), 0 });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(8416));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7760), new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7763), new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7765), new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7768), new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7770) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7722), new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7730), new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7735), new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7738), new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7747) });

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 656, DateTimeKind.Utc).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 656, DateTimeKind.Utc).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 656, DateTimeKind.Utc).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 656, DateTimeKind.Utc).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 656, DateTimeKind.Utc).AddTicks(3109));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 656, DateTimeKind.Utc).AddTicks(3132));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 656, DateTimeKind.Utc).AddTicks(3123));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: new Guid("784454bd-2d6c-49ae-9e8a-1932bd15aac1"),
                column: "Status",
                value: 2);

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 658, DateTimeKind.Utc).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 658, DateTimeKind.Utc).AddTicks(509));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 658, DateTimeKind.Utc).AddTicks(512));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 658, DateTimeKind.Utc).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 658, DateTimeKind.Utc).AddTicks(519));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 658, DateTimeKind.Utc).AddTicks(249));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsRequired", "IsUnique" },
                values: new object[] { new DateTime(2024, 3, 26, 8, 58, 5, 658, DateTimeKind.Utc).AddTicks(358), false, false });

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IsRequired", "IsUnique" },
                values: new object[] { new DateTime(2024, 3, 26, 8, 58, 5, 658, DateTimeKind.Utc).AddTicks(368), false, false });

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 658, DateTimeKind.Utc).AddTicks(372));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 658, DateTimeKind.Utc).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 658, DateTimeKind.Utc).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 658, DateTimeKind.Utc).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 658, DateTimeKind.Utc).AddTicks(393));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 658, DateTimeKind.Utc).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(8661), new DateTime(2024, 3, 26, 10, 58, 5, 657, DateTimeKind.Local).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(8790), new DateTime(2024, 3, 26, 10, 58, 5, 657, DateTimeKind.Local).AddTicks(8795) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(8803), new DateTime(2024, 3, 26, 10, 58, 5, 657, DateTimeKind.Local).AddTicks(8808) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(8815), new DateTime(2024, 3, 26, 10, 58, 5, 657, DateTimeKind.Local).AddTicks(8818) });

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(8425));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(8553));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(4821), new DateTime(2024, 3, 31, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(4854), new DateTime(2024, 3, 28, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(4865), new DateTime(2024, 3, 29, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(4867) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(4870), new DateTime(2024, 4, 3, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(4877), new DateTime(2024, 3, 31, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(4879), new DateTime(2024, 4, 1, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(4880) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(7911));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(7915));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "DateOfWorkShop", "Time" },
                values: new object[] { new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(7155), new DateTime(2024, 4, 5, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(7166), "08:58:05.6557441" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                columns: new[] { "CreatedAt", "DateOfWorkShop", "Time" },
                values: new object[] { new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(7485), new DateTime(2024, 4, 15, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(7491), "08:58:05.6557495" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 655, DateTimeKind.Utc).AddTicks(7723));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 658, DateTimeKind.Utc).AddTicks(144));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(9935));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(9942));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 658, DateTimeKind.Utc).AddTicks(27));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 658, DateTimeKind.Utc).AddTicks(33));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(9058));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(9074));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7935));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(9783));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(9775));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(9767));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(9747));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(9737));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ArabicName", "ConfirmationCodeForResetPassword", "ConfirmationCodeForSignUp", "CreatedAt", "CreatedBy", "DeletedAt", "Email", "EnglishName", "Gender", "ImageURL", "LastModifiedAt", "LastModifiedBy", "Password", "PhoneNumber", "RoleId", "TrainingWorkshopId", "isDeleted", "isValidAccount" },
                values: new object[] { new Guid("81a2c75e-c71c-4213-a372-7626db57e73d"), "تامر 2", null, null, new DateTime(2024, 3, 26, 8, 58, 5, 657, DateTimeKind.Utc).AddTicks(9792), null, null, "ta.mer@gmail.com", "Tamer 2", 0, null, null, null, "vO2sa5VimvnqRAqRbqHARyr9kG2rrXN6brfIXLU4ikM=", "0993521579", new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"), null, false, true });

            migrationBuilder.CreateIndex(
                name: "IX_Arbitrator_CreatedById",
                table: "Arbitrator",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Arbitrator_UpdatedById",
                table: "Arbitrator",
                column: "UpdatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Arbitration_Arbitrator_ArbitratorId",
                table: "Arbitration",
                column: "ArbitratorId",
                principalTable: "Arbitrator",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Arbitrator_Users_CreatedById",
                table: "Arbitrator",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Arbitrator_Users_UpdatedById",
                table: "Arbitrator",
                column: "UpdatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ArbitratorClass_Arbitrator_ArbitratorClassId",
                table: "ArbitratorClass",
                column: "ArbitratorClassId",
                principalTable: "Arbitrator",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArbitratorInterview_Arbitrator_ArbitratorId",
                table: "ArbitratorInterview",
                column: "ArbitratorId",
                principalTable: "Arbitrator",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryArbitrator_Arbitrator_ArbitratorId",
                table: "CategoryArbitrator",
                column: "ArbitratorId",
                principalTable: "Arbitrator",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
