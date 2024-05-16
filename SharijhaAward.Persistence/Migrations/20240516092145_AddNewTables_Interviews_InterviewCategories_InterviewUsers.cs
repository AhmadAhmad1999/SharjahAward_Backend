using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddNewTables_Interviews_InterviewCategories_InterviewUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interview_Users_CreatedById",
                table: "Interview");

            migrationBuilder.DropForeignKey(
                name: "FK_Interview_Users_UpdatedById",
                table: "Interview");

            migrationBuilder.DropTable(
                name: "ArbitratorInterview");

            migrationBuilder.DropTable(
                name: "SubscriberInterview");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Interview",
                table: "Interview");

            migrationBuilder.DropIndex(
                name: "IX_Interview_CreatedById",
                table: "Interview");

            migrationBuilder.DropIndex(
                name: "IX_Interview_UpdatedById",
                table: "Interview");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Interview");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Interview");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Interview");

            migrationBuilder.RenameTable(
                name: "Interview",
                newName: "Interviews");

            migrationBuilder.RenameColumn(
                name: "UpdatedById",
                table: "Interviews",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Interviews",
                newName: "Date");

            migrationBuilder.AddColumn<string>(
                name: "ArabicDescription",
                table: "Interviews",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ArabicName",
                table: "Interviews",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ArabicReasonOfCanceling",
                table: "Interviews",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ArabicText",
                table: "Interviews",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Interviews",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EnglishDescription",
                table: "Interviews",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EnglishName",
                table: "Interviews",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EnglishReasonOfCanceling",
                table: "Interviews",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EnglishText",
                table: "Interviews",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "Interviews",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Interviews",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isCanceled",
                table: "Interviews",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Interviews",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isImplemented",
                table: "Interviews",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Interviews",
                table: "Interviews",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "InterviewCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InterviewId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterviewCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InterviewCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InterviewCategories_Interviews_InterviewId",
                        column: x => x.InterviewId,
                        principalTable: "Interviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InterviewUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InterviewId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterviewUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InterviewUsers_Interviews_InterviewId",
                        column: x => x.InterviewId,
                        principalTable: "Interviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(4689), new DateTime(2024, 5, 26, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(4701), new DateTime(2024, 5, 21, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(4713) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(4717), new DateTime(2024, 5, 31, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(4720), new DateTime(2024, 5, 26, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(4722) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(4724), new DateTime(2024, 6, 5, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(4726), new DateTime(2024, 5, 31, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(4728) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(4730), new DateTime(2024, 6, 10, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(4732), new DateTime(2024, 6, 5, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(4734) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(4736), new DateTime(2024, 6, 15, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(4739), new DateTime(2024, 6, 10, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(4740) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9946));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 107, DateTimeKind.Utc).AddTicks(28));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 107, DateTimeKind.Utc).AddTicks(34));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 107, DateTimeKind.Utc).AddTicks(39));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 107, DateTimeKind.Utc).AddTicks(43));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 107, DateTimeKind.Utc).AddTicks(48));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 107, DateTimeKind.Utc).AddTicks(52));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 107, DateTimeKind.Utc).AddTicks(56));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(4061));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(4096));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(4099));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 107, DateTimeKind.Utc).AddTicks(161));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 107, DateTimeKind.Utc).AddTicks(167));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 107, DateTimeKind.Utc).AddTicks(171));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 107, DateTimeKind.Utc).AddTicks(175));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 107, DateTimeKind.Utc).AddTicks(178));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(8434));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9101));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9105));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9109));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9113));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9222));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(5142));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9803));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9808));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9813));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9817));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9824));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9828));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9696));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9707));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(8066));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7431));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7434));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7248));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7261));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(5604), new DateTime(2024, 5, 16, 12, 21, 40, 106, DateTimeKind.Local).AddTicks(5616) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(5727), new DateTime(2024, 5, 16, 12, 21, 40, 106, DateTimeKind.Local).AddTicks(5730) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(5736), new DateTime(2024, 5, 16, 12, 21, 40, 106, DateTimeKind.Local).AddTicks(5738) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(5744), new DateTime(2024, 5, 16, 12, 21, 40, 106, DateTimeKind.Local).AddTicks(5747) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(6625));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(6641));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(6645));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(5476));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(2142), new DateTime(2024, 5, 21, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(2147), new DateTime(2024, 5, 18, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(2162), new DateTime(2024, 5, 19, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(2164) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(2202), new DateTime(2024, 5, 24, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(2205), new DateTime(2024, 5, 21, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(2207), new DateTime(2024, 5, 22, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(2209) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9325));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9428));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3682));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3687));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3691));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3173), new DateTime(2024, 5, 26, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3180), "Sunday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3451), new DateTime(2024, 6, 5, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3455), "Wednesday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(5878));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(5883));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7546));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7551));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7574));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7579));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7590));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7609));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7614));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7617));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7624));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7649));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7658));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7662));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7665));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7681));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7685));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7693));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(8974));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(1256));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(2012));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(2016));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(2019));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(2023));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(2026));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7003));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 107, DateTimeKind.Utc).AddTicks(286));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 107, DateTimeKind.Utc).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 107, DateTimeKind.Utc).AddTicks(298));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 107, DateTimeKind.Utc).AddTicks(305));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 107, DateTimeKind.Utc).AddTicks(308));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9581));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9595));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(6363));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(6371));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(6388));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(5246));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(5255));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(5266));

            migrationBuilder.CreateIndex(
                name: "IX_InterviewCategories_CategoryId",
                table: "InterviewCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_InterviewCategories_InterviewId",
                table: "InterviewCategories",
                column: "InterviewId");

            migrationBuilder.CreateIndex(
                name: "IX_InterviewUsers_InterviewId",
                table: "InterviewUsers",
                column: "InterviewId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InterviewCategories");

            migrationBuilder.DropTable(
                name: "InterviewUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Interviews",
                table: "Interviews");

            migrationBuilder.DropColumn(
                name: "ArabicDescription",
                table: "Interviews");

            migrationBuilder.DropColumn(
                name: "ArabicName",
                table: "Interviews");

            migrationBuilder.DropColumn(
                name: "ArabicReasonOfCanceling",
                table: "Interviews");

            migrationBuilder.DropColumn(
                name: "ArabicText",
                table: "Interviews");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Interviews");

            migrationBuilder.DropColumn(
                name: "EnglishDescription",
                table: "Interviews");

            migrationBuilder.DropColumn(
                name: "EnglishName",
                table: "Interviews");

            migrationBuilder.DropColumn(
                name: "EnglishReasonOfCanceling",
                table: "Interviews");

            migrationBuilder.DropColumn(
                name: "EnglishText",
                table: "Interviews");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "Interviews");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Interviews");

            migrationBuilder.DropColumn(
                name: "isCanceled",
                table: "Interviews");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Interviews");

            migrationBuilder.DropColumn(
                name: "isImplemented",
                table: "Interviews");

            migrationBuilder.RenameTable(
                name: "Interviews",
                newName: "Interview");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Interview",
                newName: "UpdatedById");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Interview",
                newName: "UpdatedAt");

            migrationBuilder.AddColumn<int>(
                name: "CreatedById",
                table: "Interview",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Interview",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Interview",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Interview",
                table: "Interview",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ArbitratorInterview",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArbitratorId = table.Column<int>(type: "int", nullable: false),
                    InterviewId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArbitratorInterview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArbitratorInterview_Arbitrators_ArbitratorId",
                        column: x => x.ArbitratorId,
                        principalTable: "Arbitrators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArbitratorInterview_Interview_InterviewId",
                        column: x => x.InterviewId,
                        principalTable: "Interview",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubscriberInterview",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InterviewId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriberInterview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubscriberInterview_Interview_InterviewId",
                        column: x => x.InterviewId,
                        principalTable: "Interview",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubscriberInterview_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9111));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(5921), new DateTime(2024, 5, 25, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(5934), new DateTime(2024, 5, 20, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(5945) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(5948), new DateTime(2024, 5, 30, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(5951), new DateTime(2024, 5, 25, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(5952) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(5954), new DateTime(2024, 6, 4, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(5957), new DateTime(2024, 5, 30, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(5960), new DateTime(2024, 6, 9, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(5965), new DateTime(2024, 6, 4, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(5966) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(5969), new DateTime(2024, 6, 14, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(5971), new DateTime(2024, 6, 9, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(5972) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 679, DateTimeKind.Utc).AddTicks(96));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 679, DateTimeKind.Utc).AddTicks(158));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 679, DateTimeKind.Utc).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 679, DateTimeKind.Utc).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 679, DateTimeKind.Utc).AddTicks(171));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 679, DateTimeKind.Utc).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 679, DateTimeKind.Utc).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 679, DateTimeKind.Utc).AddTicks(189));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(465));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(468));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(485));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(488));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(491));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(571));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(591));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(388));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(392));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 679, DateTimeKind.Utc).AddTicks(260));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 679, DateTimeKind.Utc).AddTicks(265));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 679, DateTimeKind.Utc).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 679, DateTimeKind.Utc).AddTicks(271));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 679, DateTimeKind.Utc).AddTicks(275));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8881));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8906));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9434));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9438));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9444));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9447));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9451));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9454));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9458));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9978));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9983));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9986));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 679, DateTimeKind.Utc).AddTicks(4));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9905));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8064));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8078));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7800));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7889));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7899));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7905));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(6687), new DateTime(2024, 5, 15, 16, 48, 16, 678, DateTimeKind.Local).AddTicks(6695) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(6814), new DateTime(2024, 5, 15, 16, 48, 16, 678, DateTimeKind.Local).AddTicks(6816) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(6821), new DateTime(2024, 5, 15, 16, 48, 16, 678, DateTimeKind.Local).AddTicks(6823) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(6829), new DateTime(2024, 5, 15, 16, 48, 16, 678, DateTimeKind.Local).AddTicks(6832) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7437));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7442));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7446));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7469));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(6592));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 13, 48, 16, 676, DateTimeKind.Utc).AddTicks(8697), new DateTime(2024, 5, 20, 13, 48, 16, 676, DateTimeKind.Utc).AddTicks(8702), new DateTime(2024, 5, 17, 13, 48, 16, 676, DateTimeKind.Utc).AddTicks(8715), new DateTime(2024, 5, 18, 13, 48, 16, 676, DateTimeKind.Utc).AddTicks(8717) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 13, 48, 16, 676, DateTimeKind.Utc).AddTicks(8720), new DateTime(2024, 5, 23, 13, 48, 16, 676, DateTimeKind.Utc).AddTicks(8724), new DateTime(2024, 5, 20, 13, 48, 16, 676, DateTimeKind.Utc).AddTicks(8726), new DateTime(2024, 5, 21, 13, 48, 16, 676, DateTimeKind.Utc).AddTicks(8727) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9607));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9696));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9708));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(283));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(287));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(291));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 15, 13, 48, 16, 676, DateTimeKind.Utc).AddTicks(9783), new DateTime(2024, 5, 25, 13, 48, 16, 676, DateTimeKind.Utc).AddTicks(9792), "Saturday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(110), new DateTime(2024, 6, 4, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(113), "Tuesday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8164));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8188));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8337));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8343));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9354));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9262));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9267));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 676, DateTimeKind.Utc).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 676, DateTimeKind.Utc).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 676, DateTimeKind.Utc).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 676, DateTimeKind.Utc).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 676, DateTimeKind.Utc).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 676, DateTimeKind.Utc).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7726));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 679, DateTimeKind.Utc).AddTicks(351));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 679, DateTimeKind.Utc).AddTicks(364));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 679, DateTimeKind.Utc).AddTicks(367));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 679, DateTimeKind.Utc).AddTicks(371));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 679, DateTimeKind.Utc).AddTicks(374));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9777));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9817));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7269));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(6401));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(6421));

            migrationBuilder.CreateIndex(
                name: "IX_Interview_CreatedById",
                table: "Interview",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Interview_UpdatedById",
                table: "Interview",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ArbitratorInterview_ArbitratorId",
                table: "ArbitratorInterview",
                column: "ArbitratorId");

            migrationBuilder.CreateIndex(
                name: "IX_ArbitratorInterview_InterviewId",
                table: "ArbitratorInterview",
                column: "InterviewId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriberInterview_InterviewId",
                table: "SubscriberInterview",
                column: "InterviewId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriberInterview_UserId",
                table: "SubscriberInterview",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Interview_Users_CreatedById",
                table: "Interview",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Interview_Users_UpdatedById",
                table: "Interview",
                column: "UpdatedById",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
