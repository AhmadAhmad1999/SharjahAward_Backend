using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdateIdentityTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Achievement_Subscriber_subscriberId",
                table: "Achievement");

            migrationBuilder.DropForeignKey(
                name: "FK_Agenda_Cycle_CycleId",
                table: "Agenda");

            migrationBuilder.DropForeignKey(
                name: "FK_Category_Cycle_CycleId",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_Cycle_Users_CreatedById",
                table: "Cycle");

            migrationBuilder.DropForeignKey(
                name: "FK_Cycle_Users_UpdatedById",
                table: "Cycle");

            migrationBuilder.DropForeignKey(
                name: "FK_CycleClass_Cycle_CycleId",
                table: "CycleClass");

            migrationBuilder.DropForeignKey(
                name: "FK_CycleCondition_Cycle_CycleId",
                table: "CycleCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_MeetingSubscriber_Subscriber_subscriberId",
                table: "MeetingSubscriber");

            migrationBuilder.DropForeignKey(
                name: "FK_News_Cycle_CycleId",
                table: "News");

            migrationBuilder.DropForeignKey(
                name: "FK_ProvidedForm_Subscriber_subscriberId",
                table: "ProvidedForm");

            migrationBuilder.DropForeignKey(
                name: "FK_RelatedAccount_Subscriber_SubscriberId",
                table: "RelatedAccount");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriberAchievement_Subscriber_SubscriberId",
                table: "SubscriberAchievement");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriberInterview_Subscriber_SubscriberId",
                table: "SubscriberInterview");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriberTrainingWorkshop_Subscriber_SubscribersId",
                table: "SubscriberTrainingWorkshop");

            migrationBuilder.DropForeignKey(
                name: "FK_trainingWorkshopSubscribers_Subscriber_SubscribersId",
                table: "trainingWorkshopSubscribers");

            migrationBuilder.DropTable(
                name: "Subscriber");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cycle",
                table: "Cycle");

            migrationBuilder.DropIndex(
                name: "IX_Cycle_CreatedById",
                table: "Cycle");

            migrationBuilder.DropIndex(
                name: "IX_Cycle_UpdatedById",
                table: "Cycle");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Cycle");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Cycle");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Cycle");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Cycle");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "Cycle");

            migrationBuilder.RenameTable(
                name: "Cycle",
                newName: "cycles");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Users",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IdentityNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "RoleId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SubscriptionDate",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_cycles",
                table: "cycles",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "RolePermissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RolePermissionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Permissions_RolePermissions_RolePermissionId",
                        column: x => x.RolePermissionId,
                        principalTable: "RolePermissions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RolePermissionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                    table.ForeignKey(
                        name: "FK_Roles_RolePermissions_RolePermissionId",
                        column: x => x.RolePermissionId,
                        principalTable: "RolePermissions",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Name", "RolePermissionId" },
                values: new object[,]
                {
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db10"), "AccessPermissions", null },
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db11"), "ViewPermissions", null },
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db12"), "ShowPermission", null },
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db13"), "CreatePermission", null },
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db14"), "EditPermission", null },
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db15"), "RemovePermission", null },
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db16"), "All", null },
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353dba0"), "ShowUser", null },
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353dba1"), "CreateUser", null },
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353dba2"), "EditUser", null },
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353dba3"), "RemoveUser", null },
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353dba4"), "AccessRoles", null },
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353dba5"), "ViewRoles", null },
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353dba6"), "ViewRole", null },
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353dba7"), "EditRole", null },
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353dba8"), "RemoveRole", null },
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353dba9"), "AssignRole", null },
                    { new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"), "AccessUsers", null },
                    { new Guid("f00b7eb9-c7b9-4f35-8085-cdc97b8a0b47"), "ViewUsers", null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "RoleName", "RolePermissionId" },
                values: new object[,]
                {
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"), "Admin", null },
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"), "Subscriber", null },
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"), "Manager", null },
                    { new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"), "User", null }
                });

            migrationBuilder.InsertData(
                table: "cycles",
                columns: new[] { "Id", "ArabicName", "ArbitratorsResultsMargin", "EnglishName", "GroupCategoryNumber", "IndividualCategoryNumber", "MinAmountForStatement", "Status", "Year" },
                values: new object[] { new Guid("784454bd-2d6c-49ae-9e8a-1932bd15aac1"), "جائزة الشارقة", 0, "SharijhaAward", 0, 0, 0, 1, 2023 });

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_RolePermissionId",
                table: "Permissions",
                column: "RolePermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_RolePermissionId",
                table: "Roles",
                column: "RolePermissionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Achievement_Users_subscriberId",
                table: "Achievement",
                column: "subscriberId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Agenda_cycles_CycleId",
                table: "Agenda",
                column: "CycleId",
                principalTable: "cycles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Category_cycles_CycleId",
                table: "Category",
                column: "CycleId",
                principalTable: "cycles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CycleClass_cycles_CycleId",
                table: "CycleClass",
                column: "CycleId",
                principalTable: "cycles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CycleCondition_cycles_CycleId",
                table: "CycleCondition",
                column: "CycleId",
                principalTable: "cycles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MeetingSubscriber_Users_subscriberId",
                table: "MeetingSubscriber",
                column: "subscriberId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_News_cycles_CycleId",
                table: "News",
                column: "CycleId",
                principalTable: "cycles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProvidedForm_Users_subscriberId",
                table: "ProvidedForm",
                column: "subscriberId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RelatedAccount_Users_SubscriberId",
                table: "RelatedAccount",
                column: "SubscriberId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriberAchievement_Users_SubscriberId",
                table: "SubscriberAchievement",
                column: "SubscriberId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriberInterview_Users_SubscriberId",
                table: "SubscriberInterview",
                column: "SubscriberId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriberTrainingWorkshop_Users_SubscribersId",
                table: "SubscriberTrainingWorkshop",
                column: "SubscribersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_trainingWorkshopSubscribers_Users_SubscribersId",
                table: "trainingWorkshopSubscribers",
                column: "SubscribersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Achievement_Users_subscriberId",
                table: "Achievement");

            migrationBuilder.DropForeignKey(
                name: "FK_Agenda_cycles_CycleId",
                table: "Agenda");

            migrationBuilder.DropForeignKey(
                name: "FK_Category_cycles_CycleId",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_CycleClass_cycles_CycleId",
                table: "CycleClass");

            migrationBuilder.DropForeignKey(
                name: "FK_CycleCondition_cycles_CycleId",
                table: "CycleCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_MeetingSubscriber_Users_subscriberId",
                table: "MeetingSubscriber");

            migrationBuilder.DropForeignKey(
                name: "FK_News_cycles_CycleId",
                table: "News");

            migrationBuilder.DropForeignKey(
                name: "FK_ProvidedForm_Users_subscriberId",
                table: "ProvidedForm");

            migrationBuilder.DropForeignKey(
                name: "FK_RelatedAccount_Users_SubscriberId",
                table: "RelatedAccount");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriberAchievement_Users_SubscriberId",
                table: "SubscriberAchievement");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriberInterview_Users_SubscriberId",
                table: "SubscriberInterview");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriberTrainingWorkshop_Users_SubscribersId",
                table: "SubscriberTrainingWorkshop");

            migrationBuilder.DropForeignKey(
                name: "FK_trainingWorkshopSubscribers_Users_SubscribersId",
                table: "trainingWorkshopSubscribers");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "RolePermissions");

            migrationBuilder.DropIndex(
                name: "IX_Users_RoleId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cycles",
                table: "cycles");

            migrationBuilder.DeleteData(
                table: "cycles",
                keyColumn: "Id",
                keyValue: new Guid("784454bd-2d6c-49ae-9e8a-1932bd15aac1"));

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IdentityNumber",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SubscriptionDate",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "cycles",
                newName: "Cycle");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Cycle",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedById",
                table: "Cycle",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Cycle",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Cycle",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedById",
                table: "Cycle",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cycle",
                table: "Cycle",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Subscriber",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdentityNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    SubscriptionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriber", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subscriber_Users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Subscriber_Users_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Subscriber_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cycle_CreatedById",
                table: "Cycle",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Cycle_UpdatedById",
                table: "Cycle",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriber_CreatedById",
                table: "Subscriber",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriber_UpdatedById",
                table: "Subscriber",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriber_UserId",
                table: "Subscriber",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Achievement_Subscriber_subscriberId",
                table: "Achievement",
                column: "subscriberId",
                principalTable: "Subscriber",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Agenda_Cycle_CycleId",
                table: "Agenda",
                column: "CycleId",
                principalTable: "Cycle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Cycle_CycleId",
                table: "Category",
                column: "CycleId",
                principalTable: "Cycle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cycle_Users_CreatedById",
                table: "Cycle",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cycle_Users_UpdatedById",
                table: "Cycle",
                column: "UpdatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CycleClass_Cycle_CycleId",
                table: "CycleClass",
                column: "CycleId",
                principalTable: "Cycle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CycleCondition_Cycle_CycleId",
                table: "CycleCondition",
                column: "CycleId",
                principalTable: "Cycle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MeetingSubscriber_Subscriber_subscriberId",
                table: "MeetingSubscriber",
                column: "subscriberId",
                principalTable: "Subscriber",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_News_Cycle_CycleId",
                table: "News",
                column: "CycleId",
                principalTable: "Cycle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProvidedForm_Subscriber_subscriberId",
                table: "ProvidedForm",
                column: "subscriberId",
                principalTable: "Subscriber",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RelatedAccount_Subscriber_SubscriberId",
                table: "RelatedAccount",
                column: "SubscriberId",
                principalTable: "Subscriber",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriberAchievement_Subscriber_SubscriberId",
                table: "SubscriberAchievement",
                column: "SubscriberId",
                principalTable: "Subscriber",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriberInterview_Subscriber_SubscriberId",
                table: "SubscriberInterview",
                column: "SubscriberId",
                principalTable: "Subscriber",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriberTrainingWorkshop_Subscriber_SubscribersId",
                table: "SubscriberTrainingWorkshop",
                column: "SubscribersId",
                principalTable: "Subscriber",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_trainingWorkshopSubscribers_Subscriber_SubscribersId",
                table: "trainingWorkshopSubscribers",
                column: "SubscribersId",
                principalTable: "Subscriber",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
