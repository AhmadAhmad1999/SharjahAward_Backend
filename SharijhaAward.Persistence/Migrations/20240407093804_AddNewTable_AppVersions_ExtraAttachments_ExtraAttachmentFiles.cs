using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddNewTable_AppVersions_ExtraAttachments_ExtraAttachmentFiles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppVersions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VersionNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GooglePlayLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppleLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VersionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isRequired = table.Column<bool>(type: "bit", nullable: false),
                    UpdatesOnVersion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppVersions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExtraAttachments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequiredAttachmentNumber = table.Column<int>(type: "int", nullable: false),
                    AttachmentType = table.Column<int>(type: "int", nullable: false),
                    SizeOfAttachmentInKB = table.Column<int>(type: "int", nullable: false),
                    ProvidedFormId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtraAttachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExtraAttachments_ProvidedForms_ProvidedFormId",
                        column: x => x.ProvidedFormId,
                        principalTable: "ProvidedForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExtraAttachmentsProvidedForms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExtraAttachmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtraAttachmentsProvidedForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExtraAttachmentsProvidedForms_ExtraAttachments_ExtraAttachmentId",
                        column: x => x.ExtraAttachmentId,
                        principalTable: "ExtraAttachments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e5f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(6484), new DateTime(2024, 5, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(6487), new DateTime(2024, 5, 2, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(6488) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e6f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(6474), new DateTime(2024, 5, 2, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(6477), new DateTime(2024, 4, 27, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(6479) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e7f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(6445), new DateTime(2024, 4, 27, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(6449), new DateTime(2024, 4, 22, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(6450) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(6436), new DateTime(2024, 4, 22, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(6438), new DateTime(2024, 4, 17, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(6440) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(6411), new DateTime(2024, 4, 17, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(6421), new DateTime(2024, 4, 12, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7921));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7925));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7931));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7934));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(8054));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7828));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 985, DateTimeKind.Utc).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 985, DateTimeKind.Utc).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 985, DateTimeKind.Utc).AddTicks(4503));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 985, DateTimeKind.Utc).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 985, DateTimeKind.Utc).AddTicks(4345));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 985, DateTimeKind.Utc).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 985, DateTimeKind.Utc).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(9383));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(9389));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(9392));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(9241));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(9261));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(9275));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7629), new DateTime(2024, 4, 7, 11, 37, 59, 986, DateTimeKind.Local).AddTicks(7637) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7740), new DateTime(2024, 4, 7, 11, 37, 59, 986, DateTimeKind.Local).AddTicks(7744) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7771), new DateTime(2024, 4, 7, 11, 37, 59, 986, DateTimeKind.Local).AddTicks(7775) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7784), new DateTime(2024, 4, 7, 11, 37, 59, 986, DateTimeKind.Local).AddTicks(7787) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e80d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e81d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e82d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e83d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e84d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e85d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7444));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7536));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(5495), new DateTime(2024, 4, 12, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(5527), new DateTime(2024, 4, 9, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(5540), new DateTime(2024, 4, 10, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(5542) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(5545), new DateTime(2024, 4, 15, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(5549), new DateTime(2024, 4, 12, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(5551), new DateTime(2024, 4, 13, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(5552) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7653));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7658));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7040), new DateTime(2024, 4, 17, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7048) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7310), new DateTime(2024, 4, 27, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7317) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7885));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7907));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(6616));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(6608));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7582));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7487));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7495));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7991));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8008));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8016));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7015));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8559));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8531));

            migrationBuilder.CreateIndex(
                name: "IX_ExtraAttachments_ProvidedFormId",
                table: "ExtraAttachments",
                column: "ProvidedFormId");

            migrationBuilder.CreateIndex(
                name: "IX_ExtraAttachmentsProvidedForms_ExtraAttachmentId",
                table: "ExtraAttachmentsProvidedForms",
                column: "ExtraAttachmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppVersions");

            migrationBuilder.DropTable(
                name: "ExtraAttachmentsProvidedForms");

            migrationBuilder.DropTable(
                name: "ExtraAttachments");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(4271));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e5f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(237), new DateTime(2024, 5, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(241), new DateTime(2024, 5, 2, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(243) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e6f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(226), new DateTime(2024, 5, 2, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(229), new DateTime(2024, 4, 27, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(231) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e7f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(213), new DateTime(2024, 4, 27, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(217), new DateTime(2024, 4, 22, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(219) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(201), new DateTime(2024, 4, 22, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(204), new DateTime(2024, 4, 17, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(206) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(177), new DateTime(2024, 4, 17, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(184), new DateTime(2024, 4, 12, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(193) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(5169));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(5176));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(5181));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(5186));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(5321));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(5327));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(5332));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(5337));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(5342));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(5359));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(4993));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(4999));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(1124));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 449, DateTimeKind.Utc).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 449, DateTimeKind.Utc).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 449, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 449, DateTimeKind.Utc).AddTicks(4638));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 449, DateTimeKind.Utc).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 449, DateTimeKind.Utc).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 449, DateTimeKind.Utc).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3805));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3816));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3668));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3685));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(1664), new DateTime(2024, 4, 7, 10, 1, 7, 451, DateTimeKind.Local).AddTicks(1673) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(1781), new DateTime(2024, 4, 7, 10, 1, 7, 451, DateTimeKind.Local).AddTicks(1786) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(1796), new DateTime(2024, 4, 7, 10, 1, 7, 451, DateTimeKind.Local).AddTicks(1801) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(1810), new DateTime(2024, 4, 7, 10, 1, 7, 451, DateTimeKind.Local).AddTicks(1813) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(2998));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3005));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e80d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3012));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e81d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3021));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e82d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3028));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e83d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e84d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3041));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e85d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3048));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(1433));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(1605), new DateTime(2024, 4, 12, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(1639), new DateTime(2024, 4, 9, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(1653), new DateTime(2024, 4, 10, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(1656) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(1662), new DateTime(2024, 4, 15, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(1670), new DateTime(2024, 4, 12, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(1673), new DateTime(2024, 4, 13, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(1675) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(3789), new DateTime(2024, 4, 17, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(3801) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(4116), new DateTime(2024, 4, 27, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(4125) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(1938));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(1949));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(1966));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(392));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3176));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3185));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(2073));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(2088));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(2128));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(2813));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(2801));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(2781));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(2771));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(2760));
        }
    }
}
