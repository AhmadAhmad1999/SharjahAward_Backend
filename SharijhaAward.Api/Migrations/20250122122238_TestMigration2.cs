using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Api.Migrations
{
    /// <inheritdoc />
    public partial class TestMigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WorkflowQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(4391),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 186, DateTimeKind.Utc).AddTicks(9273));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 354, DateTimeKind.Utc).AddTicks(3635),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 195, DateTimeKind.Utc).AddTicks(8904));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponseAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 354, DateTimeKind.Utc).AddTicks(4417),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 195, DateTimeKind.Utc).AddTicks(9657));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VirtualTableForSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(3055),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 184, DateTimeKind.Utc).AddTicks(1149));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(3780),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 190, DateTimeKind.Utc).AddTicks(1362));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserTokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(2112),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 192, DateTimeKind.Utc).AddTicks(1345));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UsersRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(1338),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 192, DateTimeKind.Utc).AddTicks(307));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(581),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 191, DateTimeKind.Utc).AddTicks(9516));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(5398),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 193, DateTimeKind.Utc).AddTicks(7381));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 354, DateTimeKind.Utc).AddTicks(2837),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 195, DateTimeKind.Utc).AddTicks(8114));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 354, DateTimeKind.Utc).AddTicks(2049),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 195, DateTimeKind.Utc).AddTicks(7378));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermsAndConditions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 354, DateTimeKind.Utc).AddTicks(1327),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 195, DateTimeKind.Utc).AddTicks(6614));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Templates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 354, DateTimeKind.Utc).AddTicks(606),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 195, DateTimeKind.Utc).AddTicks(5810));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SwitchArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(1362),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 185, DateTimeKind.Utc).AddTicks(4217));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(8870),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 192, DateTimeKind.Utc).AddTicks(8593));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StrategicPartners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(9114),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 195, DateTimeKind.Utc).AddTicks(4263));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(8437),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 195, DateTimeKind.Utc).AddTicks(3568));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(2919),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 190, DateTimeKind.Utc).AddTicks(385));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SocialMedias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(7771),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 195, DateTimeKind.Utc).AddTicks(2894));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SavedCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(7024),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 195, DateTimeKind.Utc).AddTicks(2121));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(8982),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 191, DateTimeKind.Utc).AddTicks(7974));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RolePermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(9802),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 191, DateTimeKind.Utc).AddTicks(8737));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RoleMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(6168),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 195, DateTimeKind.Utc).AddTicks(1234));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rewards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(5311),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 195, DateTimeKind.Utc).AddTicks(452));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ResponsibilitiesUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(4553),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 194, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Responsibilities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(3816),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 194, DateTimeKind.Utc).AddTicks(6305));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(2319),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 194, DateTimeKind.Utc).AddTicks(4570));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccountRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(3077),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 194, DateTimeKind.Utc).AddTicks(5432));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ReferenceSources",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(1600),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 194, DateTimeKind.Utc).AddTicks(3787));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(828),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 194, DateTimeKind.Utc).AddTicks(2920));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Personalnvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(8072),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 192, DateTimeKind.Utc).AddTicks(7818));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Permissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(7085),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 191, DateTimeKind.Utc).AddTicks(6550));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PermissionHeaders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(8042),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 191, DateTimeKind.Utc).AddTicks(7282));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(7698),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 193, DateTimeKind.Utc).AddTicks(9640));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructureImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(9935),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 194, DateTimeKind.Utc).AddTicks(2040));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(9180),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 194, DateTimeKind.Utc).AddTicks(1200));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OurGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(1551),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 182, DateTimeKind.Utc).AddTicks(5481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OnePageText",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(6773),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 193, DateTimeKind.Utc).AddTicks(8891));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NotificationTemplates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(6124),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 193, DateTimeKind.Utc).AddTicks(8158));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Notifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(4647),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 193, DateTimeKind.Utc).AddTicks(6586));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsTickers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(4010),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 193, DateTimeKind.Utc).AddTicks(5880));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(3277),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 193, DateTimeKind.Utc).AddTicks(5042));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(2598),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 193, DateTimeKind.Utc).AddTicks(2510));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(2982),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 187, DateTimeKind.Utc).AddTicks(9171));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(1897),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 193, DateTimeKind.Utc).AddTicks(1811));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Meetings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(1205),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 193, DateTimeKind.Utc).AddTicks(1091));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(464),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 193, DateTimeKind.Utc).AddTicks(346));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LogUserActions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(9611),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 192, DateTimeKind.Utc).AddTicks(9379));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(3531),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 192, DateTimeKind.Utc).AddTicks(2953));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(4253),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 192, DateTimeKind.Utc).AddTicks(3682));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeParticipants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(6551),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 192, DateTimeKind.Utc).AddTicks(6241));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeNoteAndQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(5739),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 192, DateTimeKind.Utc).AddTicks(5377));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(5003),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 192, DateTimeKind.Utc).AddTicks(4464));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Instructions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(2841),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 192, DateTimeKind.Utc).AddTicks(2259));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(502),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 185, DateTimeKind.Utc).AddTicks(3200));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(8439),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 194, DateTimeKind.Utc).AddTicks(395));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HomePageSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(6362),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 191, DateTimeKind.Utc).AddTicks(5725));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GroupInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(7336),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 192, DateTimeKind.Utc).AddTicks(7029));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(5668),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 191, DateTimeKind.Utc).AddTicks(4962));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(4318),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 191, DateTimeKind.Utc).AddTicks(3453));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(5015),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 191, DateTimeKind.Utc).AddTicks(4230));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Galleries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(5283),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 184, DateTimeKind.Utc).AddTicks(4731));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FrequentlyAskedQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(1070),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 190, DateTimeKind.Utc).AddTicks(9783));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(3496),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 191, DateTimeKind.Utc).AddTicks(2532));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(2662),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 191, DateTimeKind.Utc).AddTicks(1605));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(314),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 190, DateTimeKind.Utc).AddTicks(8769));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(9537),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 190, DateTimeKind.Utc).AddTicks(7954));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(8814),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 190, DateTimeKind.Utc).AddTicks(7197));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryGuides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(8103),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 190, DateTimeKind.Utc).AddTicks(6340));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(7394),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 190, DateTimeKind.Utc).AddTicks(5153));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EntitiesCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(4620),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 190, DateTimeKind.Utc).AddTicks(2239));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(2154),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 187, DateTimeKind.Utc).AddTicks(8307));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(1300),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 187, DateTimeKind.Utc).AddTicks(7432));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalInstitutions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(6689),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 190, DateTimeKind.Utc).AddTicks(4408));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(5988),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 190, DateTimeKind.Utc).AddTicks(3681));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(5349),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 190, DateTimeKind.Utc).AddTicks(3001));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(1304),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 189, DateTimeKind.Utc).AddTicks(8745));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeTableValue",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(535),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 189, DateTimeKind.Utc).AddTicks(7974));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(9773),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 189, DateTimeKind.Utc).AddTicks(7202));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(6722),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 189, DateTimeKind.Utc).AddTicks(3939));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(9005),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 189, DateTimeKind.Utc).AddTicks(6394));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(8268),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 189, DateTimeKind.Utc).AddTicks(5572));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(7510),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 189, DateTimeKind.Utc).AddTicks(4742));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(2104),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 189, DateTimeKind.Utc).AddTicks(9559));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DigitalSignatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(783),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 188, DateTimeKind.Utc).AddTicks(7775));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(5865),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 189, DateTimeKind.Utc).AddTicks(3046));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(4928),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 189, DateTimeKind.Utc).AddTicks(2071));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Dependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(3865),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 189, DateTimeKind.Utc).AddTicks(904));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cycles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(42),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 188, DateTimeKind.Utc).AddTicks(6986));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(9285),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 188, DateTimeKind.Utc).AddTicks(6143));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(9857),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 195, DateTimeKind.Utc).AddTicks(5062));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleCondition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(8498),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 188, DateTimeKind.Utc).AddTicks(5281));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Criterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(6897),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 188, DateTimeKind.Utc).AddTicks(3585));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(5254),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 188, DateTimeKind.Utc).AddTicks(1800));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(6069),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 188, DateTimeKind.Utc).AddTicks(2689));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(7717),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 188, DateTimeKind.Utc).AddTicks(4439));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Coordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(4530),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 188, DateTimeKind.Utc).AddTicks(1012));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CoordinatorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(3754),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 188, DateTimeKind.Utc).AddTicks(101));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(500),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 187, DateTimeKind.Utc).AddTicks(6595));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(6865),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 186, DateTimeKind.Utc).AddTicks(890));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Committees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(9711),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 187, DateTimeKind.Utc).AddTicks(5775));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(8935),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 187, DateTimeKind.Utc).AddTicks(4896));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Circulars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(5099),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 187, DateTimeKind.Utc).AddTicks(43));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(8144),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 187, DateTimeKind.Utc).AddTicks(3592));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularChairmans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(7328),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 187, DateTimeKind.Utc).AddTicks(2533));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(6602),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 187, DateTimeKind.Utc).AddTicks(1707));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(5852),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 187, DateTimeKind.Utc).AddTicks(898));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatBotQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(3650),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 186, DateTimeKind.Utc).AddTicks(8483));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnInitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(9632),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 185, DateTimeKind.Utc).AddTicks(2195));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnFinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(1840),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 191, DateTimeKind.Utc).AddTicks(682));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(8748),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 185, DateTimeKind.Utc).AddTicks(452));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(2135),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 186, DateTimeKind.Utc).AddTicks(6863));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryEducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(1361),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 186, DateTimeKind.Utc).AddTicks(5942));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryCommittees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(559),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 186, DateTimeKind.Utc).AddTicks(4979));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoriesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(9719),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 186, DateTimeKind.Utc).AddTicks(4051));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(2889),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 186, DateTimeKind.Utc).AddTicks(7683));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardStatistics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(8942),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 186, DateTimeKind.Utc).AddTicks(3169));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardSponsors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(8235),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 186, DateTimeKind.Utc).AddTicks(2378));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardPublications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(7571),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 186, DateTimeKind.Utc).AddTicks(1659));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeTableNames",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(2948),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 189, DateTimeKind.Utc).AddTicks(5));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeOperations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(2223),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 188, DateTimeKind.Utc).AddTicks(9275));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeDataTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(1518),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 188, DateTimeKind.Utc).AddTicks(8559));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(6148),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 186, DateTimeKind.Utc).AddTicks(97));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(5436),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 185, DateTimeKind.Utc).AddTicks(9293));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(4647),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 185, DateTimeKind.Utc).AddTicks(8447));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScalesCriterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(3822),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 185, DateTimeKind.Utc).AddTicks(7532));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(2997),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 185, DateTimeKind.Utc).AddTicks(6590));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(6871),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 184, DateTimeKind.Utc).AddTicks(6576));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationResults",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(2213),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 185, DateTimeKind.Utc).AddTicks(5632));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(7820),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 184, DateTimeKind.Utc).AddTicks(9461));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AppVersions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(6002),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 184, DateTimeKind.Utc).AddTicks(5559));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Albums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(4542),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 184, DateTimeKind.Utc).AddTicks(3799));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Agendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(3822),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 184, DateTimeKind.Utc).AddTicks(2959));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(2222),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 184, DateTimeKind.Utc).AddTicks(111));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(1216),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 183, DateTimeKind.Utc).AddTicks(9137));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderTableValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(451),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 183, DateTimeKind.Utc).AddTicks(8199));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(9632),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 183, DateTimeKind.Utc).AddTicks(7297));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(3226),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 182, DateTimeKind.Utc).AddTicks(7470));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(8905),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 183, DateTimeKind.Utc).AddTicks(5978));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(8187),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 183, DateTimeKind.Utc).AddTicks(5065));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(7429),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 183, DateTimeKind.Utc).AddTicks(4247));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(6689),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 183, DateTimeKind.Utc).AddTicks(3333));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(5894),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 183, DateTimeKind.Utc).AddTicks(2290));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(5104),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 183, DateTimeKind.Utc).AddTicks(1183));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(4247),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 182, DateTimeKind.Utc).AddTicks(8698));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Achievements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(2389),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 182, DateTimeKind.Utc).AddTicks(6448));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutAwardPage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(685),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 182, DateTimeKind.Utc).AddTicks(4463));

            migrationBuilder.CreateTable(
                name: "AAAs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 342, DateTimeKind.Utc).AddTicks(9864)),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AAAs", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AAAs");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WorkflowQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 186, DateTimeKind.Utc).AddTicks(9273),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(4391));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 195, DateTimeKind.Utc).AddTicks(8904),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 354, DateTimeKind.Utc).AddTicks(3635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponseAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 195, DateTimeKind.Utc).AddTicks(9657),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 354, DateTimeKind.Utc).AddTicks(4417));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VirtualTableForSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 184, DateTimeKind.Utc).AddTicks(1149),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(3055));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 190, DateTimeKind.Utc).AddTicks(1362),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(3780));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserTokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 192, DateTimeKind.Utc).AddTicks(1345),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(2112));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UsersRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 192, DateTimeKind.Utc).AddTicks(307),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(1338));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 191, DateTimeKind.Utc).AddTicks(9516),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(581));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 193, DateTimeKind.Utc).AddTicks(7381),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(5398));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 195, DateTimeKind.Utc).AddTicks(8114),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 354, DateTimeKind.Utc).AddTicks(2837));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 195, DateTimeKind.Utc).AddTicks(7378),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 354, DateTimeKind.Utc).AddTicks(2049));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermsAndConditions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 195, DateTimeKind.Utc).AddTicks(6614),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 354, DateTimeKind.Utc).AddTicks(1327));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Templates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 195, DateTimeKind.Utc).AddTicks(5810),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 354, DateTimeKind.Utc).AddTicks(606));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SwitchArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 185, DateTimeKind.Utc).AddTicks(4217),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(1362));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 192, DateTimeKind.Utc).AddTicks(8593),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(8870));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StrategicPartners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 195, DateTimeKind.Utc).AddTicks(4263),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(9114));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 195, DateTimeKind.Utc).AddTicks(3568),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(8437));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 190, DateTimeKind.Utc).AddTicks(385),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(2919));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SocialMedias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 195, DateTimeKind.Utc).AddTicks(2894),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(7771));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SavedCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 195, DateTimeKind.Utc).AddTicks(2121),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(7024));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 191, DateTimeKind.Utc).AddTicks(7974),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(8982));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RolePermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 191, DateTimeKind.Utc).AddTicks(8737),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(9802));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RoleMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 195, DateTimeKind.Utc).AddTicks(1234),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(6168));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rewards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 195, DateTimeKind.Utc).AddTicks(452),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(5311));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ResponsibilitiesUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 194, DateTimeKind.Utc).AddTicks(9620),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(4553));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Responsibilities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 194, DateTimeKind.Utc).AddTicks(6305),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(3816));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 194, DateTimeKind.Utc).AddTicks(4570),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(2319));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccountRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 194, DateTimeKind.Utc).AddTicks(5432),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(3077));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ReferenceSources",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 194, DateTimeKind.Utc).AddTicks(3787),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(1600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 194, DateTimeKind.Utc).AddTicks(2920),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(828));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Personalnvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 192, DateTimeKind.Utc).AddTicks(7818),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(8072));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Permissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 191, DateTimeKind.Utc).AddTicks(6550),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(7085));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PermissionHeaders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 191, DateTimeKind.Utc).AddTicks(7282),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(8042));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 193, DateTimeKind.Utc).AddTicks(9640),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(7698));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructureImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 194, DateTimeKind.Utc).AddTicks(2040),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(9935));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 194, DateTimeKind.Utc).AddTicks(1200),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(9180));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OurGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 182, DateTimeKind.Utc).AddTicks(5481),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(1551));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OnePageText",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 193, DateTimeKind.Utc).AddTicks(8891),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(6773));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NotificationTemplates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 193, DateTimeKind.Utc).AddTicks(8158),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(6124));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Notifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 193, DateTimeKind.Utc).AddTicks(6586),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(4647));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsTickers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 193, DateTimeKind.Utc).AddTicks(5880),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(4010));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 193, DateTimeKind.Utc).AddTicks(5042),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(3277));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 193, DateTimeKind.Utc).AddTicks(2510),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(2598));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 187, DateTimeKind.Utc).AddTicks(9171),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(2982));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 193, DateTimeKind.Utc).AddTicks(1811),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(1897));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Meetings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 193, DateTimeKind.Utc).AddTicks(1091),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(1205));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 193, DateTimeKind.Utc).AddTicks(346),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(464));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LogUserActions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 192, DateTimeKind.Utc).AddTicks(9379),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(9611));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 192, DateTimeKind.Utc).AddTicks(2953),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(3531));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 192, DateTimeKind.Utc).AddTicks(3682),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(4253));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeParticipants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 192, DateTimeKind.Utc).AddTicks(6241),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(6551));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeNoteAndQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 192, DateTimeKind.Utc).AddTicks(5377),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(5739));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 192, DateTimeKind.Utc).AddTicks(4464),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(5003));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Instructions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 192, DateTimeKind.Utc).AddTicks(2259),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(2841));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 185, DateTimeKind.Utc).AddTicks(3200),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(502));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 194, DateTimeKind.Utc).AddTicks(395),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(8439));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HomePageSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 191, DateTimeKind.Utc).AddTicks(5725),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(6362));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GroupInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 192, DateTimeKind.Utc).AddTicks(7029),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(7336));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 191, DateTimeKind.Utc).AddTicks(4962),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(5668));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 191, DateTimeKind.Utc).AddTicks(3453),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(4318));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 191, DateTimeKind.Utc).AddTicks(4230),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(5015));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Galleries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 184, DateTimeKind.Utc).AddTicks(4731),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(5283));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FrequentlyAskedQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 190, DateTimeKind.Utc).AddTicks(9783),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(1070));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 191, DateTimeKind.Utc).AddTicks(2532),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(3496));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 191, DateTimeKind.Utc).AddTicks(1605),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(2662));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 190, DateTimeKind.Utc).AddTicks(8769),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 190, DateTimeKind.Utc).AddTicks(7954),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(9537));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 190, DateTimeKind.Utc).AddTicks(7197),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(8814));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryGuides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 190, DateTimeKind.Utc).AddTicks(6340),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(8103));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 190, DateTimeKind.Utc).AddTicks(5153),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(7394));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EntitiesCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 190, DateTimeKind.Utc).AddTicks(2239),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(4620));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 187, DateTimeKind.Utc).AddTicks(8307),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(2154));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 187, DateTimeKind.Utc).AddTicks(7432),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(1300));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalInstitutions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 190, DateTimeKind.Utc).AddTicks(4408),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(6689));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 190, DateTimeKind.Utc).AddTicks(3681),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(5988));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 190, DateTimeKind.Utc).AddTicks(3001),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(5349));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 189, DateTimeKind.Utc).AddTicks(8745),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(1304));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeTableValue",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 189, DateTimeKind.Utc).AddTicks(7974),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(535));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 189, DateTimeKind.Utc).AddTicks(7202),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(9773));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 189, DateTimeKind.Utc).AddTicks(3939),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(6722));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 189, DateTimeKind.Utc).AddTicks(6394),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(9005));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 189, DateTimeKind.Utc).AddTicks(5572),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(8268));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 189, DateTimeKind.Utc).AddTicks(4742),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(7510));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 189, DateTimeKind.Utc).AddTicks(9559),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(2104));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DigitalSignatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 188, DateTimeKind.Utc).AddTicks(7775),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(783));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 189, DateTimeKind.Utc).AddTicks(3046),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(5865));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 189, DateTimeKind.Utc).AddTicks(2071),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(4928));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Dependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 189, DateTimeKind.Utc).AddTicks(904),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(3865));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cycles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 188, DateTimeKind.Utc).AddTicks(6986),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(42));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 188, DateTimeKind.Utc).AddTicks(6143),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(9285));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 195, DateTimeKind.Utc).AddTicks(5062),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(9857));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleCondition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 188, DateTimeKind.Utc).AddTicks(5281),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(8498));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Criterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 188, DateTimeKind.Utc).AddTicks(3585),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(6897));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 188, DateTimeKind.Utc).AddTicks(1800),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(5254));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 188, DateTimeKind.Utc).AddTicks(2689),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(6069));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 188, DateTimeKind.Utc).AddTicks(4439),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(7717));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Coordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 188, DateTimeKind.Utc).AddTicks(1012),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(4530));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CoordinatorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 188, DateTimeKind.Utc).AddTicks(101),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(3754));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 187, DateTimeKind.Utc).AddTicks(6595),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(500));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 186, DateTimeKind.Utc).AddTicks(890),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(6865));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Committees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 187, DateTimeKind.Utc).AddTicks(5775),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(9711));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 187, DateTimeKind.Utc).AddTicks(4896),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(8935));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Circulars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 187, DateTimeKind.Utc).AddTicks(43),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(5099));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 187, DateTimeKind.Utc).AddTicks(3592),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(8144));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularChairmans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 187, DateTimeKind.Utc).AddTicks(2533),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(7328));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 187, DateTimeKind.Utc).AddTicks(1707),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(6602));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 187, DateTimeKind.Utc).AddTicks(898),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(5852));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatBotQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 186, DateTimeKind.Utc).AddTicks(8483),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(3650));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnInitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 185, DateTimeKind.Utc).AddTicks(2195),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnFinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 191, DateTimeKind.Utc).AddTicks(682),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(1840));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 185, DateTimeKind.Utc).AddTicks(452),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(8748));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 186, DateTimeKind.Utc).AddTicks(6863),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(2135));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryEducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 186, DateTimeKind.Utc).AddTicks(5942),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(1361));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryCommittees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 186, DateTimeKind.Utc).AddTicks(4979),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(559));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoriesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 186, DateTimeKind.Utc).AddTicks(4051),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(9719));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 186, DateTimeKind.Utc).AddTicks(7683),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(2889));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardStatistics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 186, DateTimeKind.Utc).AddTicks(3169),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(8942));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardSponsors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 186, DateTimeKind.Utc).AddTicks(2378),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(8235));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardPublications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 186, DateTimeKind.Utc).AddTicks(1659),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(7571));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeTableNames",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 189, DateTimeKind.Utc).AddTicks(5),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(2948));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeOperations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 188, DateTimeKind.Utc).AddTicks(9275),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(2223));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeDataTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 188, DateTimeKind.Utc).AddTicks(8559),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(1518));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 186, DateTimeKind.Utc).AddTicks(97),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(6148));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 185, DateTimeKind.Utc).AddTicks(9293),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(5436));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 185, DateTimeKind.Utc).AddTicks(8447),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(4647));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScalesCriterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 185, DateTimeKind.Utc).AddTicks(7532),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(3822));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 185, DateTimeKind.Utc).AddTicks(6590),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(2997));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 184, DateTimeKind.Utc).AddTicks(6576),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(6871));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationResults",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 185, DateTimeKind.Utc).AddTicks(5632),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(2213));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 184, DateTimeKind.Utc).AddTicks(9461),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(7820));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AppVersions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 184, DateTimeKind.Utc).AddTicks(5559),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(6002));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Albums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 184, DateTimeKind.Utc).AddTicks(3799),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(4542));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Agendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 184, DateTimeKind.Utc).AddTicks(2959),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(3822));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 184, DateTimeKind.Utc).AddTicks(111),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(2222));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 183, DateTimeKind.Utc).AddTicks(9137),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(1216));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderTableValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 183, DateTimeKind.Utc).AddTicks(8199),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(451));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 183, DateTimeKind.Utc).AddTicks(7297),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 182, DateTimeKind.Utc).AddTicks(7470),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(3226));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 183, DateTimeKind.Utc).AddTicks(5978),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(8905));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 183, DateTimeKind.Utc).AddTicks(5065),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(8187));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 183, DateTimeKind.Utc).AddTicks(4247),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(7429));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 183, DateTimeKind.Utc).AddTicks(3333),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(6689));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 183, DateTimeKind.Utc).AddTicks(2290),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(5894));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 183, DateTimeKind.Utc).AddTicks(1183),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(5104));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 182, DateTimeKind.Utc).AddTicks(8698),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(4247));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Achievements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 182, DateTimeKind.Utc).AddTicks(6448),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(2389));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutAwardPage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 20, 38, 182, DateTimeKind.Utc).AddTicks(4463),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(685));
        }
    }
}
