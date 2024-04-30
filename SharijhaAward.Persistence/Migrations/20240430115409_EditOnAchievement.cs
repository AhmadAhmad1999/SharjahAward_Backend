using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditOnAchievement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CriterionItems_Scale_ScaleId",
                table: "CriterionItems");

            migrationBuilder.DropTable(
                name: "CriterionItemScales");

            migrationBuilder.DropTable(
                name: "Scale");

            migrationBuilder.DropIndex(
                name: "IX_CriterionItems_ScaleId",
                table: "CriterionItems");

            migrationBuilder.DropColumn(
                name: "ScaleId",
                table: "CriterionItems");

            migrationBuilder.RenameColumn(
                name: "ImageinStart",
                table: "ParagraphCards",
                newName: "ImageInStart");

            migrationBuilder.AddColumn<bool>(
                name: "IsAccepted",
                table: "Achievements",
                type: "bit",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ArbitrationScales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DegreeScale = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArbitrationScales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArbitrationScalesCriterions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CriterionId = table.Column<int>(type: "int", nullable: true),
                    CriterionItemId = table.Column<int>(type: "int", nullable: true),
                    ArbitrationScaleId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArbitrationScalesCriterions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArbitrationScalesCriterions_ArbitrationScales_ArbitrationScaleId",
                        column: x => x.ArbitrationScaleId,
                        principalTable: "ArbitrationScales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArbitrationScalesCriterions_CriterionItems_CriterionItemId",
                        column: x => x.CriterionItemId,
                        principalTable: "CriterionItems",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ArbitrationScalesCriterions_Criterions_CriterionId",
                        column: x => x.CriterionId,
                        principalTable: "Criterions",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4499));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7336), new DateTime(2024, 5, 10, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7345), new DateTime(2024, 5, 5, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7354) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7359), new DateTime(2024, 5, 15, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7360), new DateTime(2024, 5, 10, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7362) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7363), new DateTime(2024, 5, 20, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7366), new DateTime(2024, 5, 15, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7367) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7369), new DateTime(2024, 5, 25, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7371), new DateTime(2024, 5, 20, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7372) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7374), new DateTime(2024, 5, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7376), new DateTime(2024, 5, 25, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7377) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4914));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(5006));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(5009));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(5012));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(5015));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(5017));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(5024));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4836));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7702));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8009));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8013));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9713));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9716));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9718));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9721));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9608));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9624));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8350), new DateTime(2024, 4, 30, 14, 54, 5, 464, DateTimeKind.Local).AddTicks(8359) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8375), new DateTime(2024, 4, 30, 14, 54, 5, 464, DateTimeKind.Local).AddTicks(8377) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8379), new DateTime(2024, 4, 30, 14, 54, 5, 464, DateTimeKind.Local).AddTicks(8380) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8382), new DateTime(2024, 4, 30, 14, 54, 5, 464, DateTimeKind.Local).AddTicks(8384) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9225));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9241));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9245));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(3153), new DateTime(2024, 5, 5, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(3160), new DateTime(2024, 5, 2, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(3170), new DateTime(2024, 5, 3, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(3174), new DateTime(2024, 5, 8, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(3176), new DateTime(2024, 5, 5, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(3177), new DateTime(2024, 5, 6, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(3178) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7921));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7927));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4178), new DateTime(2024, 5, 10, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4184), "Friday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4383), new DateTime(2024, 5, 20, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4386), "Monday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(2976));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(3071));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(3075));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(3082));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9457));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9325));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9329));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9399));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9039));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8116));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8126));

            migrationBuilder.CreateIndex(
                name: "IX_ArbitrationScalesCriterions_ArbitrationScaleId",
                table: "ArbitrationScalesCriterions",
                column: "ArbitrationScaleId");

            migrationBuilder.CreateIndex(
                name: "IX_ArbitrationScalesCriterions_CriterionId",
                table: "ArbitrationScalesCriterions",
                column: "CriterionId");

            migrationBuilder.CreateIndex(
                name: "IX_ArbitrationScalesCriterions_CriterionItemId",
                table: "ArbitrationScalesCriterions",
                column: "CriterionItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArbitrationScalesCriterions");

            migrationBuilder.DropTable(
                name: "ArbitrationScales");

            migrationBuilder.DropColumn(
                name: "IsAccepted",
                table: "Achievements");

            migrationBuilder.RenameColumn(
                name: "ImageInStart",
                table: "ParagraphCards",
                newName: "ImageinStart");

            migrationBuilder.AddColumn<int>(
                name: "ScaleId",
                table: "CriterionItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Scale",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriterionId = table.Column<int>(type: "int", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxScore = table.Column<int>(type: "int", nullable: false),
                    MinScore = table.Column<int>(type: "int", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scale", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Scale_Criterions_CriterionId",
                        column: x => x.CriterionId,
                        principalTable: "Criterions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CriterionItemScales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriterionItemId = table.Column<int>(type: "int", nullable: false),
                    ScaleId = table.Column<int>(type: "int", nullable: false),
                    ArabicDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CriterionItemsId = table.Column<int>(type: "int", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EnglishDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScalesId = table.Column<int>(type: "int", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CriterionItemScales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CriterionItemScales_CriterionItems_CriterionItemId",
                        column: x => x.CriterionItemId,
                        principalTable: "CriterionItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CriterionItemScales_Scale_ScaleId",
                        column: x => x.ScaleId,
                        principalTable: "Scale",
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
                columns: new[] { "CreatedAt", "ScaleId" },
                values: new object[] { new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(9939), null });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ScaleId" },
                values: new object[] { new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(9944), null });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ScaleId" },
                values: new object[] { new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(9948), null });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ScaleId" },
                values: new object[] { new DateTime(2024, 4, 29, 7, 2, 45, 847, DateTimeKind.Utc).AddTicks(9952), null });

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
                name: "IX_CriterionItems_ScaleId",
                table: "CriterionItems",
                column: "ScaleId");

            migrationBuilder.CreateIndex(
                name: "IX_CriterionItemScales_CriterionItemId",
                table: "CriterionItemScales",
                column: "CriterionItemId");

            migrationBuilder.CreateIndex(
                name: "IX_CriterionItemScales_ScaleId",
                table: "CriterionItemScales",
                column: "ScaleId");

            migrationBuilder.CreateIndex(
                name: "IX_Scale_CriterionId",
                table: "Scale",
                column: "CriterionId");

            migrationBuilder.AddForeignKey(
                name: "FK_CriterionItems_Scale_ScaleId",
                table: "CriterionItems",
                column: "ScaleId",
                principalTable: "Scale",
                principalColumn: "Id");
        }
    }
}
