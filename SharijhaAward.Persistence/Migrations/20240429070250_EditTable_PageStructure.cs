using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTable_PageStructure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PageStructures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hasHelography = table.Column<bool>(type: "bit", nullable: false),
                    IconUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishSubTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArabicSubTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnglishContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArabicContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageStructures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PageStructures_PageStructures_ParentId",
                        column: x => x.ParentId,
                        principalTable: "PageStructures",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DarkCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PageId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DarkCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DarkCards_PageStructures_PageId",
                        column: x => x.PageId,
                        principalTable: "PageStructures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParagraphCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArabicContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageinStart = table.Column<bool>(type: "bit", nullable: true),
                    PageId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParagraphCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParagraphCards_PageStructures_PageId",
                        column: x => x.PageId,
                        principalTable: "PageStructures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(3155));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(3178), new DateTime(2024, 5, 9, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(3190), new DateTime(2024, 5, 4, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(3200) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(3202), new DateTime(2024, 5, 14, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(3204), new DateTime(2024, 5, 9, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(3205) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(3207), new DateTime(2024, 5, 19, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(3209), new DateTime(2024, 5, 14, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(3210) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(3212), new DateTime(2024, 5, 24, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(3215), new DateTime(2024, 5, 19, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(3216) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(3218), new DateTime(2024, 5, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(3220), new DateTime(2024, 5, 24, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(3221) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(3747));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(3757));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(3762));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(3652));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(9944));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(9948));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(9811));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(9825));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(5969));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(5973));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(5976));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(5837));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(5859));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(5862));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(5866));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(4310), new DateTime(2024, 4, 29, 10, 2, 45, 849, DateTimeKind.Local).AddTicks(4316) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(4405), new DateTime(2024, 4, 29, 10, 2, 45, 849, DateTimeKind.Local).AddTicks(4407) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(4411), new DateTime(2024, 4, 29, 10, 2, 45, 849, DateTimeKind.Local).AddTicks(4413) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(4416), new DateTime(2024, 4, 29, 10, 2, 45, 849, DateTimeKind.Local).AddTicks(4419) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(5395));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(1761), new DateTime(2024, 5, 4, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(1765), new DateTime(2024, 5, 1, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(1775), new DateTime(2024, 5, 2, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(1777) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(1780), new DateTime(2024, 5, 7, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(1783), new DateTime(2024, 5, 4, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(1784), new DateTime(2024, 5, 5, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(1785) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(3775));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(3429));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(3433));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(3526));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(2825), new DateTime(2024, 5, 9, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(2829), "Thursday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(3054), new DateTime(2024, 5, 19, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(3057), "Sunday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(4512));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(932));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(3324));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(3327));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(3242));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(1552));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(1636));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(1639));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(1642));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(1645));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(1648));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(5518));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(5524));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(5608));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(5612));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(4635));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(5155));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(4002));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 29, 7, 2, 45, 849, DateTimeKind.Utc).AddTicks(4006));

            migrationBuilder.CreateIndex(
                name: "IX_DarkCards_PageId",
                table: "DarkCards",
                column: "PageId");

            migrationBuilder.CreateIndex(
                name: "IX_PageStructures_ParentId",
                table: "PageStructures",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_ParagraphCards_PageId",
                table: "ParagraphCards",
                column: "PageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DarkCards");

            migrationBuilder.DropTable(
                name: "ParagraphCards");

            migrationBuilder.DropTable(
                name: "PageStructures");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(3343), new DateTime(2024, 5, 8, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(3351), new DateTime(2024, 5, 3, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(3361) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(3365), new DateTime(2024, 5, 13, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(3368), new DateTime(2024, 5, 8, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(3370) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(3372), new DateTime(2024, 5, 18, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(3375), new DateTime(2024, 5, 13, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(3376) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(3378), new DateTime(2024, 5, 23, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(3380), new DateTime(2024, 5, 18, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(3382) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(3384), new DateTime(2024, 5, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(3386), new DateTime(2024, 5, 23, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(3388) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6769));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6778));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6905));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6639));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6642));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(4432));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(4436));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 766, DateTimeKind.Utc).AddTicks(1674));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 766, DateTimeKind.Utc).AddTicks(1683));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 766, DateTimeKind.Utc).AddTicks(1686));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 766, DateTimeKind.Utc).AddTicks(1689));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 766, DateTimeKind.Utc).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 766, DateTimeKind.Utc).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 766, DateTimeKind.Utc).AddTicks(1576));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(6628));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(6631));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(6634));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(6638));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(6384));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(6481));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(6503));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(4834), new DateTime(2024, 4, 28, 17, 23, 1, 767, DateTimeKind.Local).AddTicks(4844) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(4940), new DateTime(2024, 4, 28, 17, 23, 1, 767, DateTimeKind.Local).AddTicks(4942) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(4948), new DateTime(2024, 4, 28, 17, 23, 1, 767, DateTimeKind.Local).AddTicks(4950) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(4955), new DateTime(2024, 4, 28, 17, 23, 1, 767, DateTimeKind.Local).AddTicks(4957) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5966));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5977));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5983));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5986));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5989));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5992));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5994));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(4747));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(4365), new DateTime(2024, 5, 3, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(4370), new DateTime(2024, 4, 30, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(4382), new DateTime(2024, 5, 1, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(4383) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(4386), new DateTime(2024, 5, 6, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(4389), new DateTime(2024, 5, 3, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(4391), new DateTime(2024, 5, 4, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(4392) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(4324));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6534));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6538));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(5762), new DateTime(2024, 5, 8, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(5767), "Wednesday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6022), new DateTime(2024, 5, 18, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6025), "Saturday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5057));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5064));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(2804));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(2813));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6342));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(4205));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(4208));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(6288));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(6214));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5169));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5751));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5755));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(4537));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(4558));
        }
    }
}
