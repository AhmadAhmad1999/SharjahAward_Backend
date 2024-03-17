using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class BulidDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RelatedAccount");

            migrationBuilder.CreateTable(
                name: "RelatedAccountRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReceiverId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelatedAccountRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RelatedAccountRequests_subscribers_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "subscribers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RelatedAccountRequests_subscribers_SenderId",
                        column: x => x.SenderId,
                        principalTable: "subscribers",
                        principalColumn: "Id");
                });

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
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 4, 38, 4, DateTimeKind.Utc).AddTicks(476));

            migrationBuilder.CreateIndex(
                name: "IX_RelatedAccountRequests_ReceiverId",
                table: "RelatedAccountRequests",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_RelatedAccountRequests_SenderId",
                table: "RelatedAccountRequests",
                column: "SenderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RelatedAccountRequests");

            migrationBuilder.CreateTable(
                name: "RelatedAccount",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubscriberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelatedAccount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RelatedAccount_subscribers_SubscriberId",
                        column: x => x.SubscriberId,
                        principalTable: "subscribers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RelatedAccount_users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RelatedAccount_users_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "users",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(468));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(473));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(474));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(476));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(479));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(521));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(527));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(530));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(441));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(6899), new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(6901), new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(6902), new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(6903), new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(6904) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(6871), new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(6874), new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(6879), new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(6892), new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(6894) });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(2859));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(2864));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(2814));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(2807));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(7212));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(7223));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(7237));

            migrationBuilder.UpdateData(
                table: "GeneralFrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "GeneralFrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(213));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(7075));

            migrationBuilder.CreateIndex(
                name: "IX_RelatedAccount_CreatedById",
                table: "RelatedAccount",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_RelatedAccount_SubscriberId",
                table: "RelatedAccount",
                column: "SubscriberId");

            migrationBuilder.CreateIndex(
                name: "IX_RelatedAccount_UpdatedById",
                table: "RelatedAccount",
                column: "UpdatedById");
        }
    }
}
