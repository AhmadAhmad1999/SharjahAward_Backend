using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addAttachmentToWorkshop : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_trainingWorkshops_trainingWorkshops_TrainingWorkshopId",
                table: "trainingWorkshops");

            migrationBuilder.DropIndex(
                name: "IX_trainingWorkshops_TrainingWorkshopId",
                table: "trainingWorkshops");

            migrationBuilder.DropColumn(
                name: "TrainingWorkshopId",
                table: "trainingWorkshops");

            migrationBuilder.CreateTable(
                name: "TrainingWrokshopeAttachment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttachementPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SizeOfAttachmentInKB = table.Column<int>(type: "int", nullable: false),
                    AttachmentType = table.Column<int>(type: "int", nullable: false),
                    WorkshopeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingWrokshopeAttachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingWrokshopeAttachment_trainingWorkshops_WorkshopeId",
                        column: x => x.WorkshopeId,
                        principalTable: "trainingWorkshops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 7, 10, 59, 20, 80, DateTimeKind.Utc).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 7, 10, 59, 20, 80, DateTimeKind.Utc).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 7, 10, 59, 20, 80, DateTimeKind.Utc).AddTicks(3429));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 7, 10, 59, 20, 80, DateTimeKind.Utc).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 7, 10, 59, 20, 80, DateTimeKind.Utc).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 7, 10, 59, 20, 80, DateTimeKind.Utc).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 7, 10, 59, 20, 80, DateTimeKind.Utc).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 7, 10, 59, 20, 80, DateTimeKind.Utc).AddTicks(3443));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 7, 10, 59, 20, 80, DateTimeKind.Utc).AddTicks(3514));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 7, 10, 59, 20, 80, DateTimeKind.Utc).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 7, 10, 59, 20, 80, DateTimeKind.Utc).AddTicks(3521));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 7, 10, 59, 20, 80, DateTimeKind.Utc).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 7, 10, 59, 20, 80, DateTimeKind.Utc).AddTicks(3526));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 7, 10, 59, 20, 80, DateTimeKind.Utc).AddTicks(3531));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 7, 10, 59, 20, 80, DateTimeKind.Utc).AddTicks(3533));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 7, 10, 59, 20, 80, DateTimeKind.Utc).AddTicks(3589));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 7, 10, 59, 20, 80, DateTimeKind.Utc).AddTicks(3036));

            migrationBuilder.CreateIndex(
                name: "IX_TrainingWrokshopeAttachment_WorkshopeId",
                table: "TrainingWrokshopeAttachment",
                column: "WorkshopeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrainingWrokshopeAttachment");

            migrationBuilder.AddColumn<Guid>(
                name: "TrainingWorkshopId",
                table: "trainingWorkshops",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 19, 56, 50, 493, DateTimeKind.Utc).AddTicks(1891));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 19, 56, 50, 493, DateTimeKind.Utc).AddTicks(1893));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 19, 56, 50, 493, DateTimeKind.Utc).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 19, 56, 50, 493, DateTimeKind.Utc).AddTicks(1896));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 19, 56, 50, 493, DateTimeKind.Utc).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 19, 56, 50, 493, DateTimeKind.Utc).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 19, 56, 50, 493, DateTimeKind.Utc).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 19, 56, 50, 493, DateTimeKind.Utc).AddTicks(1903));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 19, 56, 50, 493, DateTimeKind.Utc).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 19, 56, 50, 493, DateTimeKind.Utc).AddTicks(1946));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 19, 56, 50, 493, DateTimeKind.Utc).AddTicks(1948));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 19, 56, 50, 493, DateTimeKind.Utc).AddTicks(1949));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 19, 56, 50, 493, DateTimeKind.Utc).AddTicks(1951));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 19, 56, 50, 493, DateTimeKind.Utc).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 19, 56, 50, 493, DateTimeKind.Utc).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 19, 56, 50, 493, DateTimeKind.Utc).AddTicks(1956));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 19, 56, 50, 493, DateTimeKind.Utc).AddTicks(1698));

            migrationBuilder.CreateIndex(
                name: "IX_trainingWorkshops_TrainingWorkshopId",
                table: "trainingWorkshops",
                column: "TrainingWorkshopId");

            migrationBuilder.AddForeignKey(
                name: "FK_trainingWorkshops_trainingWorkshops_TrainingWorkshopId",
                table: "trainingWorkshops",
                column: "TrainingWorkshopId",
                principalTable: "trainingWorkshops",
                principalColumn: "Id");
        }
    }
}
