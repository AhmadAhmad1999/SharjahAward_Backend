using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddNewTables_Committees_CategoryCommittees_CategoryEducationalClasses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryCommittees_Committee_CommitteesId",
                table: "CategoryCommittees");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryCommittees_Users_CreatedById",
                table: "CategoryCommittees");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryCommittees_Users_UpdatedById",
                table: "CategoryCommittees");

            migrationBuilder.DropForeignKey(
                name: "FK_Committee_Users_ChairmanId",
                table: "Committee");

            migrationBuilder.DropForeignKey(
                name: "FK_Committee_Users_CreatedById",
                table: "Committee");

            migrationBuilder.DropForeignKey(
                name: "FK_Committee_Users_UpdatedById",
                table: "Committee");

            migrationBuilder.DropTable(
                name: "CategoryCommittee");

            migrationBuilder.DropIndex(
                name: "IX_CategoryCommittees_CommitteesId",
                table: "CategoryCommittees");

            migrationBuilder.DropIndex(
                name: "IX_CategoryCommittees_CreatedById",
                table: "CategoryCommittees");

            migrationBuilder.DropIndex(
                name: "IX_CategoryCommittees_UpdatedById",
                table: "CategoryCommittees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Committee",
                table: "Committee");

            migrationBuilder.DropIndex(
                name: "IX_Committee_CreatedById",
                table: "Committee");

            migrationBuilder.DropIndex(
                name: "IX_Committee_UpdatedById",
                table: "Committee");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "CategoryCommittees");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "CategoryCommittees");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "CategoryCommittees");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Committee");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Committee");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "Committee");

            migrationBuilder.RenameTable(
                name: "Committee",
                newName: "Committees");

            migrationBuilder.RenameIndex(
                name: "IX_Committee_ChairmanId",
                table: "Committees",
                newName: "IX_Committees_ChairmanId");

            migrationBuilder.AddColumn<Guid>(
                name: "CommitteeId",
                table: "CategoryCommittees",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "CategoryCommittees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "CategoryCommittees",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "CategoryCommittees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "CategoryCommittees",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "Committees",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Committees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "Committees",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Committees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Committees",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Committees",
                table: "Committees",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CategoryEducationalClasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EducationalClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryEducationalClasses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryEducationalClasses_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryEducationalClasses_EducationalClasses_EducationalClassId",
                        column: x => x.EducationalClassId,
                        principalTable: "EducationalClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(2924));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e5f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(7112), new DateTime(2024, 5, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(7117), new DateTime(2024, 4, 26, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e6f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(7090), new DateTime(2024, 4, 26, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(7095), new DateTime(2024, 4, 21, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(7098) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e7f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(7070), new DateTime(2024, 4, 21, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(7075), new DateTime(2024, 4, 16, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(7079) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(6984), new DateTime(2024, 4, 16, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(6990), new DateTime(2024, 4, 11, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(6994) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(6939), new DateTime(2024, 4, 11, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(6952), new DateTime(2024, 4, 6, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(6969) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(4018));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(4025));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(4054));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(4256));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(4262));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(4268));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(7831));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(8662));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 928, DateTimeKind.Utc).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 928, DateTimeKind.Utc).AddTicks(3816));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 928, DateTimeKind.Utc).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 928, DateTimeKind.Utc).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 928, DateTimeKind.Utc).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 928, DateTimeKind.Utc).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 928, DateTimeKind.Utc).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(3538));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(3039));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(9583), new DateTime(2024, 4, 1, 11, 57, 58, 930, DateTimeKind.Local).AddTicks(9597) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(9740), new DateTime(2024, 4, 1, 11, 57, 58, 930, DateTimeKind.Local).AddTicks(9748) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(9804), new DateTime(2024, 4, 1, 11, 57, 58, 930, DateTimeKind.Local).AddTicks(9813) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(9839), new DateTime(2024, 4, 1, 11, 57, 58, 930, DateTimeKind.Local).AddTicks(9846) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(2061));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(2071));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(2088));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e80d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(2106));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e81d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e82d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e83d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(2171));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e84d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e85d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(2194));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(9207));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(9195));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(9404));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 1, 9, 57, 58, 926, DateTimeKind.Utc).AddTicks(9211), new DateTime(2024, 4, 6, 9, 57, 58, 926, DateTimeKind.Utc).AddTicks(9250), new DateTime(2024, 4, 3, 9, 57, 58, 926, DateTimeKind.Utc).AddTicks(9347), new DateTime(2024, 4, 4, 9, 57, 58, 926, DateTimeKind.Utc).AddTicks(9353) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 1, 9, 57, 58, 926, DateTimeKind.Utc).AddTicks(9360), new DateTime(2024, 4, 9, 9, 57, 58, 926, DateTimeKind.Utc).AddTicks(9369), new DateTime(2024, 4, 6, 9, 57, 58, 926, DateTimeKind.Utc).AddTicks(9372), new DateTime(2024, 4, 7, 9, 57, 58, 926, DateTimeKind.Utc).AddTicks(9376) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(3427));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(3436));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(3685));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(2365), new DateTime(2024, 4, 11, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(2379) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(2739), new DateTime(2024, 4, 21, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(2749) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(120));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(154));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(167));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(3079));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(3094));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(2856));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(2436));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(2615));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(362));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(435));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(8194));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(8963));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(8998));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(1835));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(1817));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(1801));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(1784));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(1765));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(1742));

            migrationBuilder.CreateIndex(
                name: "IX_CategoryCommittees_CommitteeId",
                table: "CategoryCommittees",
                column: "CommitteeId");

            migrationBuilder.CreateIndex(
                name: "IX_Committees_CategoryId",
                table: "Committees",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryEducationalClasses_CategoryId",
                table: "CategoryEducationalClasses",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryEducationalClasses_EducationalClassId",
                table: "CategoryEducationalClasses",
                column: "EducationalClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryCommittees_Committees_CommitteeId",
                table: "CategoryCommittees",
                column: "CommitteeId",
                principalTable: "Committees",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Committees_Arbitrators_ChairmanId",
                table: "Committees",
                column: "ChairmanId",
                principalTable: "Arbitrators",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Committees_Categories_CategoryId",
                table: "Committees",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryCommittees_Committees_CommitteeId",
                table: "CategoryCommittees");

            migrationBuilder.DropForeignKey(
                name: "FK_Committees_Arbitrators_ChairmanId",
                table: "Committees");

            migrationBuilder.DropForeignKey(
                name: "FK_Committees_Categories_CategoryId",
                table: "Committees");

            migrationBuilder.DropTable(
                name: "CategoryEducationalClasses");

            migrationBuilder.DropIndex(
                name: "IX_CategoryCommittees_CommitteeId",
                table: "CategoryCommittees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Committees",
                table: "Committees");

            migrationBuilder.DropIndex(
                name: "IX_Committees_CategoryId",
                table: "Committees");

            migrationBuilder.DropColumn(
                name: "CommitteeId",
                table: "CategoryCommittees");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "CategoryCommittees");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "CategoryCommittees");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "CategoryCommittees");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "CategoryCommittees");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Committees");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Committees");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "Committees");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Committees");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Committees");

            migrationBuilder.RenameTable(
                name: "Committees",
                newName: "Committee");

            migrationBuilder.RenameIndex(
                name: "IX_Committees_ChairmanId",
                table: "Committee",
                newName: "IX_Committee_ChairmanId");

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedById",
                table: "CategoryCommittees",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "CategoryCommittees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedById",
                table: "CategoryCommittees",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedById",
                table: "Committee",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Committee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedById",
                table: "Committee",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Committee",
                table: "Committee",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CategoryCommittee",
                columns: table => new
                {
                    CategoriesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CommitteesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryCommittee", x => new { x.CategoriesId, x.CommitteesId });
                    table.ForeignKey(
                        name: "FK_CategoryCommittee_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryCommittee_Committee_CommitteesId",
                        column: x => x.CommitteesId,
                        principalTable: "Committee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(6379));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e5f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 1, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(8148), new DateTime(2024, 5, 1, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(8153), new DateTime(2024, 4, 26, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(8157) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e6f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 1, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(8127), new DateTime(2024, 4, 26, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(8132), new DateTime(2024, 4, 21, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(8136) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e7f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 1, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(8109), new DateTime(2024, 4, 21, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(8114), new DateTime(2024, 4, 16, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(8117) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 1, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(8089), new DateTime(2024, 4, 16, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(8094), new DateTime(2024, 4, 11, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(8098) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 1, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(8048), new DateTime(2024, 4, 11, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(8059), new DateTime(2024, 4, 6, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(8076) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7526));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7532));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7538));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7551));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7557));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7794));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7800));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(9729));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(9748));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(9761));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 724, DateTimeKind.Utc).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 724, DateTimeKind.Utc).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 724, DateTimeKind.Utc).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 724, DateTimeKind.Utc).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 724, DateTimeKind.Utc).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 724, DateTimeKind.Utc).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 724, DateTimeKind.Utc).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(4929));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(4939));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(4952));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(4958));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(4345));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(4671));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(719), new DateTime(2024, 4, 1, 9, 41, 31, 727, DateTimeKind.Local).AddTicks(737) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(872), new DateTime(2024, 4, 1, 9, 41, 31, 727, DateTimeKind.Local).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(906), new DateTime(2024, 4, 1, 9, 41, 31, 727, DateTimeKind.Local).AddTicks(913) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(938), new DateTime(2024, 4, 1, 9, 41, 31, 727, DateTimeKind.Local).AddTicks(945) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(3331));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e80d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(3358));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e81d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(3371));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e82d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e83d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e84d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(3398));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e85d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(3408));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(282));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(269));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(489));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(2550), new DateTime(2024, 4, 6, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(2592), new DateTime(2024, 4, 3, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(2607), new DateTime(2024, 4, 4, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(2610) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(2616), new DateTime(2024, 4, 9, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(2626), new DateTime(2024, 4, 6, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(2630), new DateTime(2024, 4, 7, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(2633) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(9516));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(5781), new DateTime(2024, 4, 11, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(5799) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(6176), new DateTime(2024, 4, 21, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(6188) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(1184));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(1233));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(1535));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(1551));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(1625));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(9306));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(9333));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(8));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(36));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(69));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(3019));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(3003));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(2984));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(2960));

            migrationBuilder.CreateIndex(
                name: "IX_CategoryCommittees_CommitteesId",
                table: "CategoryCommittees",
                column: "CommitteesId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryCommittees_CreatedById",
                table: "CategoryCommittees",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryCommittees_UpdatedById",
                table: "CategoryCommittees",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Committee_CreatedById",
                table: "Committee",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Committee_UpdatedById",
                table: "Committee",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryCommittee_CommitteesId",
                table: "CategoryCommittee",
                column: "CommitteesId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryCommittees_Committee_CommitteesId",
                table: "CategoryCommittees",
                column: "CommitteesId",
                principalTable: "Committee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryCommittees_Users_CreatedById",
                table: "CategoryCommittees",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryCommittees_Users_UpdatedById",
                table: "CategoryCommittees",
                column: "UpdatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Committee_Users_ChairmanId",
                table: "Committee",
                column: "ChairmanId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Committee_Users_CreatedById",
                table: "Committee",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Committee_Users_UpdatedById",
                table: "Committee",
                column: "UpdatedById",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
