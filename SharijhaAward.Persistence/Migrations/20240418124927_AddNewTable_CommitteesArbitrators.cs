using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddNewTable_CommitteesArbitrators : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryCommittees_Categories_CategoryId",
                table: "CategoryCommittees");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryCommittees_Committees_CommitteeId",
                table: "CategoryCommittees");

            migrationBuilder.DeleteData(
                table: "Arbitrators",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "CategoriesId",
                table: "CategoryCommittees");

            migrationBuilder.DropColumn(
                name: "CommitteesId",
                table: "CategoryCommittees");

            migrationBuilder.AlterColumn<int>(
                name: "CommitteeId",
                table: "CategoryCommittees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "CategoryCommittees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isChairman",
                table: "Arbitrators",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "ComitteesArbitrators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommitteeId = table.Column<int>(type: "int", nullable: false),
                    ArbitratorId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComitteesArbitrators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComitteesArbitrators_Arbitrators_ArbitratorId",
                        column: x => x.ArbitratorId,
                        principalTable: "Arbitrators",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ComitteesArbitrators_Committees_CommitteeId",
                        column: x => x.CommitteeId,
                        principalTable: "Committees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5293));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5010), new DateTime(2024, 4, 28, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5023), new DateTime(2024, 4, 23, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5033) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5036), new DateTime(2024, 5, 3, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5038), new DateTime(2024, 4, 28, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5040) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5042), new DateTime(2024, 5, 8, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5044), new DateTime(2024, 5, 3, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5046) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5048), new DateTime(2024, 5, 13, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5050), new DateTime(2024, 5, 8, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5052) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5054), new DateTime(2024, 5, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5056), new DateTime(2024, 5, 13, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5058) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5859));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5862));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5864));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5867));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5983));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5986));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5989));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5992));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5998));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(6001));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5778));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5439));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5456));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5811));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5815));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5819));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 123, DateTimeKind.Utc).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 123, DateTimeKind.Utc).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 123, DateTimeKind.Utc).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 123, DateTimeKind.Utc).AddTicks(819));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 123, DateTimeKind.Utc).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 123, DateTimeKind.Utc).AddTicks(545));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 123, DateTimeKind.Utc).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(8132));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7986));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7999));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(8009));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(6226), new DateTime(2024, 4, 18, 14, 49, 22, 124, DateTimeKind.Local).AddTicks(6233) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(6337), new DateTime(2024, 4, 18, 14, 49, 22, 124, DateTimeKind.Local).AddTicks(6339) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(6344), new DateTime(2024, 4, 18, 14, 49, 22, 124, DateTimeKind.Local).AddTicks(6346) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(6350), new DateTime(2024, 4, 18, 14, 49, 22, 124, DateTimeKind.Local).AddTicks(6354) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7447));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7470));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(6138));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(3866), new DateTime(2024, 4, 23, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(3870), new DateTime(2024, 4, 20, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(3881), new DateTime(2024, 4, 21, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(3882) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(3887), new DateTime(2024, 4, 26, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(3889), new DateTime(2024, 4, 23, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(3891), new DateTime(2024, 4, 24, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(3892) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5703));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5676));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(4905), new DateTime(2024, 4, 28, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(4911) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5181), new DateTime(2024, 5, 8, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5184) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(6459));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(6463));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5188));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5488));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5492));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(3763));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(3774));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(3777));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7799));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7625));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7724));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5601));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5935));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5944));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5949));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5954));

            migrationBuilder.CreateIndex(
                name: "IX_ComitteesArbitrators_ArbitratorId",
                table: "ComitteesArbitrators",
                column: "ArbitratorId");

            migrationBuilder.CreateIndex(
                name: "IX_ComitteesArbitrators_CommitteeId",
                table: "ComitteesArbitrators",
                column: "CommitteeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryCommittees_Categories_CategoryId",
                table: "CategoryCommittees",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryCommittees_Committees_CommitteeId",
                table: "CategoryCommittees",
                column: "CommitteeId",
                principalTable: "Committees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryCommittees_Categories_CategoryId",
                table: "CategoryCommittees");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryCommittees_Committees_CommitteeId",
                table: "CategoryCommittees");

            migrationBuilder.DropTable(
                name: "ComitteesArbitrators");

            migrationBuilder.DropColumn(
                name: "isChairman",
                table: "Arbitrators");

            migrationBuilder.AlterColumn<int>(
                name: "CommitteeId",
                table: "CategoryCommittees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "CategoryCommittees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CategoriesId",
                table: "CategoryCommittees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CommitteesId",
                table: "CategoryCommittees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(6869), new DateTime(2024, 4, 28, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(6879), new DateTime(2024, 4, 23, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(6889) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(6893), new DateTime(2024, 5, 3, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(6895), new DateTime(2024, 4, 28, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(6897) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(6899), new DateTime(2024, 5, 8, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(6902), new DateTime(2024, 5, 3, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(6903) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(6906), new DateTime(2024, 5, 13, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(6908), new DateTime(2024, 5, 8, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(6909) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(6911), new DateTime(2024, 5, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(6914), new DateTime(2024, 5, 13, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(6916) });

            migrationBuilder.InsertData(
                table: "Arbitrators",
                columns: new[] { "Id", "ArabicName", "CreatedAt", "CreatedBy", "DeletedAt", "Email", "EnglishName", "LastModifiedAt", "LastModifiedBy", "PhoneNumber", "isDeleted" },
                values: new object[] { 1, "", new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(6579), null, null, "", "", null, null, "", false });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7768));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7905));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7915));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7918));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7670));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(7636));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(7658));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 833, DateTimeKind.Utc).AddTicks(9031));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 833, DateTimeKind.Utc).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 833, DateTimeKind.Utc).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 833, DateTimeKind.Utc).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 833, DateTimeKind.Utc).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 833, DateTimeKind.Utc).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 833, DateTimeKind.Utc).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 836, DateTimeKind.Utc).AddTicks(139));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 836, DateTimeKind.Utc).AddTicks(143));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 836, DateTimeKind.Utc).AddTicks(146));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 836, DateTimeKind.Utc).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 836, DateTimeKind.Utc).AddTicks(153));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9902));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9911));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9929));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9933));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9942));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(8118), new DateTime(2024, 4, 18, 13, 50, 9, 835, DateTimeKind.Local).AddTicks(8126) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(8230), new DateTime(2024, 4, 18, 13, 50, 9, 835, DateTimeKind.Local).AddTicks(8232) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(8238), new DateTime(2024, 4, 18, 13, 50, 9, 835, DateTimeKind.Local).AddTicks(8240) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(8246), new DateTime(2024, 4, 18, 13, 50, 9, 835, DateTimeKind.Local).AddTicks(8248) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9381));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9392));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(7903));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(8013));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(5594), new DateTime(2024, 4, 23, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(5599), new DateTime(2024, 4, 20, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(5611), new DateTime(2024, 4, 21, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(5612) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(5615), new DateTime(2024, 4, 26, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(5617), new DateTime(2024, 4, 23, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(5619), new DateTime(2024, 4, 24, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7468));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(6687), new DateTime(2024, 4, 28, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(6692) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7037), new DateTime(2024, 5, 8, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7041) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7375));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(5485));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(5492));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9694));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9615));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(8464));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(7454));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9103));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9108));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(7801));

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryCommittees_Categories_CategoryId",
                table: "CategoryCommittees",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryCommittees_Committees_CommitteeId",
                table: "CategoryCommittees",
                column: "CommitteeId",
                principalTable: "Committees",
                principalColumn: "Id");
        }
    }
}
