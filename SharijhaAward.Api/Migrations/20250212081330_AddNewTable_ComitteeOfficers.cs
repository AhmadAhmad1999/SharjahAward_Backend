using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddNewTable_ComitteeOfficers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WorkflowQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 406, DateTimeKind.Utc).AddTicks(2606),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 689, DateTimeKind.Utc).AddTicks(4812));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 413, DateTimeKind.Utc).AddTicks(2246),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 697, DateTimeKind.Utc).AddTicks(1453));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponseAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 413, DateTimeKind.Utc).AddTicks(2857),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 697, DateTimeKind.Utc).AddTicks(2156));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VirtualTableForSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 404, DateTimeKind.Utc).AddTicks(5380),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 687, DateTimeKind.Utc).AddTicks(6359));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 408, DateTimeKind.Utc).AddTicks(7854),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 692, DateTimeKind.Utc).AddTicks(1173));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserTokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 410, DateTimeKind.Utc).AddTicks(2347),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 694, DateTimeKind.Utc).AddTicks(267));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UsersRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 410, DateTimeKind.Utc).AddTicks(1721),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 693, DateTimeKind.Utc).AddTicks(9516));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 410, DateTimeKind.Utc).AddTicks(1112),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 693, DateTimeKind.Utc).AddTicks(8757));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 411, DateTimeKind.Utc).AddTicks(2817),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 695, DateTimeKind.Utc).AddTicks(3704));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 413, DateTimeKind.Utc).AddTicks(1611),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 697, DateTimeKind.Utc).AddTicks(705));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 413, DateTimeKind.Utc).AddTicks(1034),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 696, DateTimeKind.Utc).AddTicks(9991));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 413, DateTimeKind.Utc).AddTicks(468),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 696, DateTimeKind.Utc).AddTicks(9260));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermsAndConditions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 412, DateTimeKind.Utc).AddTicks(9224),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 696, DateTimeKind.Utc).AddTicks(7935));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermAndConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 412, DateTimeKind.Utc).AddTicks(9842),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 696, DateTimeKind.Utc).AddTicks(8598));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Templates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 412, DateTimeKind.Utc).AddTicks(8650),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 696, DateTimeKind.Utc).AddTicks(7282));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SwitchArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 405, DateTimeKind.Utc).AddTicks(1626),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 688, DateTimeKind.Utc).AddTicks(2905));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubcommitteeCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 405, DateTimeKind.Utc).AddTicks(5987),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 688, DateTimeKind.Utc).AddTicks(7489));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 410, DateTimeKind.Utc).AddTicks(7659),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 694, DateTimeKind.Utc).AddTicks(6900));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StrategicPartners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 412, DateTimeKind.Utc).AddTicks(7480),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 696, DateTimeKind.Utc).AddTicks(5937));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 412, DateTimeKind.Utc).AddTicks(6798),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 696, DateTimeKind.Utc).AddTicks(5297));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 408, DateTimeKind.Utc).AddTicks(7146),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 692, DateTimeKind.Utc).AddTicks(439));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SocialMedias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 412, DateTimeKind.Utc).AddTicks(6229),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 696, DateTimeKind.Utc).AddTicks(4723));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SavedCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 412, DateTimeKind.Utc).AddTicks(5540),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 696, DateTimeKind.Utc).AddTicks(4057));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 409, DateTimeKind.Utc).AddTicks(9919),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 693, DateTimeKind.Utc).AddTicks(7320));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RolePermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 410, DateTimeKind.Utc).AddTicks(529),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 693, DateTimeKind.Utc).AddTicks(8032));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RoleMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 412, DateTimeKind.Utc).AddTicks(4491),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 696, DateTimeKind.Utc).AddTicks(3307));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rewards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 412, DateTimeKind.Utc).AddTicks(3525),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 696, DateTimeKind.Utc).AddTicks(2626));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ResponsibilitiesUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 412, DateTimeKind.Utc).AddTicks(2636),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 696, DateTimeKind.Utc).AddTicks(1889));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Responsibilities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 412, DateTimeKind.Utc).AddTicks(1862),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 696, DateTimeKind.Utc).AddTicks(1190));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 412, DateTimeKind.Utc).AddTicks(252),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 695, DateTimeKind.Utc).AddTicks(9802));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccountRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 412, DateTimeKind.Utc).AddTicks(1023),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 696, DateTimeKind.Utc).AddTicks(482));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ReferenceSources",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 411, DateTimeKind.Utc).AddTicks(9567),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 695, DateTimeKind.Utc).AddTicks(9166));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 411, DateTimeKind.Utc).AddTicks(8744),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 695, DateTimeKind.Utc).AddTicks(8462));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Personalnvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 410, DateTimeKind.Utc).AddTicks(7087),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 694, DateTimeKind.Utc).AddTicks(6076));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Permissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 409, DateTimeKind.Utc).AddTicks(8855),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 693, DateTimeKind.Utc).AddTicks(6045));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PermissionHeaders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 409, DateTimeKind.Utc).AddTicks(9396),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 693, DateTimeKind.Utc).AddTicks(6715));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 411, DateTimeKind.Utc).AddTicks(4830),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 695, DateTimeKind.Utc).AddTicks(5588));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructureImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 411, DateTimeKind.Utc).AddTicks(7891),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 695, DateTimeKind.Utc).AddTicks(7691));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 411, DateTimeKind.Utc).AddTicks(6841),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 695, DateTimeKind.Utc).AddTicks(6957));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OurGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 403, DateTimeKind.Utc).AddTicks(6099),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 686, DateTimeKind.Utc).AddTicks(6552));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OnePageText",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 411, DateTimeKind.Utc).AddTicks(3940),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 695, DateTimeKind.Utc).AddTicks(4985));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NotificationTemplates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 411, DateTimeKind.Utc).AddTicks(3404),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 695, DateTimeKind.Utc).AddTicks(4411));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Notifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 411, DateTimeKind.Utc).AddTicks(2227),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 695, DateTimeKind.Utc).AddTicks(3061));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsTickers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 411, DateTimeKind.Utc).AddTicks(1694),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 695, DateTimeKind.Utc).AddTicks(2466));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 411, DateTimeKind.Utc).AddTicks(1159),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 695, DateTimeKind.Utc).AddTicks(1826));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 411, DateTimeKind.Utc).AddTicks(614),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 695, DateTimeKind.Utc).AddTicks(1130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 407, DateTimeKind.Utc).AddTicks(60),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 690, DateTimeKind.Utc).AddTicks(2130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 411, DateTimeKind.Utc).AddTicks(57),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 695, DateTimeKind.Utc).AddTicks(285));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Meetings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 410, DateTimeKind.Utc).AddTicks(9509),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 694, DateTimeKind.Utc).AddTicks(9503));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 410, DateTimeKind.Utc).AddTicks(8937),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 694, DateTimeKind.Utc).AddTicks(8757));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LogUserActions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 410, DateTimeKind.Utc).AddTicks(8290),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 694, DateTimeKind.Utc).AddTicks(7899));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 410, DateTimeKind.Utc).AddTicks(3433),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 694, DateTimeKind.Utc).AddTicks(1586));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 410, DateTimeKind.Utc).AddTicks(4040),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 694, DateTimeKind.Utc).AddTicks(2355));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeParticipants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 410, DateTimeKind.Utc).AddTicks(5865),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 694, DateTimeKind.Utc).AddTicks(4509));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeNoteAndQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 410, DateTimeKind.Utc).AddTicks(5218),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 694, DateTimeKind.Utc).AddTicks(3773));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 410, DateTimeKind.Utc).AddTicks(4640),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 694, DateTimeKind.Utc).AddTicks(3086));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Instructions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 410, DateTimeKind.Utc).AddTicks(2904),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 694, DateTimeKind.Utc).AddTicks(942));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 405, DateTimeKind.Utc).AddTicks(959),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 688, DateTimeKind.Utc).AddTicks(2196));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 411, DateTimeKind.Utc).AddTicks(5767),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 695, DateTimeKind.Utc).AddTicks(6240));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HomePageSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 409, DateTimeKind.Utc).AddTicks(8297),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 693, DateTimeKind.Utc).AddTicks(5297));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GroupInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 410, DateTimeKind.Utc).AddTicks(6495),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 694, DateTimeKind.Utc).AddTicks(5358));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 409, DateTimeKind.Utc).AddTicks(7778),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 693, DateTimeKind.Utc).AddTicks(2539));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 409, DateTimeKind.Utc).AddTicks(6720),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 693, DateTimeKind.Utc).AddTicks(695));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 409, DateTimeKind.Utc).AddTicks(7260),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 693, DateTimeKind.Utc).AddTicks(1539));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Galleries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 404, DateTimeKind.Utc).AddTicks(7129),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 687, DateTimeKind.Utc).AddTicks(8101));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FrequentlyAskedQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 409, DateTimeKind.Utc).AddTicks(4130),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 692, DateTimeKind.Utc).AddTicks(7979));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 409, DateTimeKind.Utc).AddTicks(6087),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 692, DateTimeKind.Utc).AddTicks(9992));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 409, DateTimeKind.Utc).AddTicks(5396),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 692, DateTimeKind.Utc).AddTicks(9298));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 409, DateTimeKind.Utc).AddTicks(3524),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 692, DateTimeKind.Utc).AddTicks(7356));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 409, DateTimeKind.Utc).AddTicks(2373),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 692, DateTimeKind.Utc).AddTicks(6106));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 409, DateTimeKind.Utc).AddTicks(2948),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 692, DateTimeKind.Utc).AddTicks(6727));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 409, DateTimeKind.Utc).AddTicks(1827),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 692, DateTimeKind.Utc).AddTicks(5494));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryGuides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 409, DateTimeKind.Utc).AddTicks(1267),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 692, DateTimeKind.Utc).AddTicks(4912));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 409, DateTimeKind.Utc).AddTicks(676),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 692, DateTimeKind.Utc).AddTicks(4244));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EntitiesCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 408, DateTimeKind.Utc).AddTicks(8517),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 692, DateTimeKind.Utc).AddTicks(1880));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 406, DateTimeKind.Utc).AddTicks(9435),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 690, DateTimeKind.Utc).AddTicks(1483));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 406, DateTimeKind.Utc).AddTicks(8734),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 690, DateTimeKind.Utc).AddTicks(775));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalInstitutions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 409, DateTimeKind.Utc).AddTicks(123),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 692, DateTimeKind.Utc).AddTicks(3616));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 408, DateTimeKind.Utc).AddTicks(9572),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 692, DateTimeKind.Utc).AddTicks(3043));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 408, DateTimeKind.Utc).AddTicks(9074),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 692, DateTimeKind.Utc).AddTicks(2500));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 408, DateTimeKind.Utc).AddTicks(5866),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 691, DateTimeKind.Utc).AddTicks(9078));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeTableValue",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 408, DateTimeKind.Utc).AddTicks(5281),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 691, DateTimeKind.Utc).AddTicks(8432));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 408, DateTimeKind.Utc).AddTicks(4686),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 691, DateTimeKind.Utc).AddTicks(7775));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 408, DateTimeKind.Utc).AddTicks(2368),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 691, DateTimeKind.Utc).AddTicks(5294));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 408, DateTimeKind.Utc).AddTicks(4072),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 691, DateTimeKind.Utc).AddTicks(7145));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 408, DateTimeKind.Utc).AddTicks(3530),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 691, DateTimeKind.Utc).AddTicks(6554));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 408, DateTimeKind.Utc).AddTicks(2979),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 691, DateTimeKind.Utc).AddTicks(5948));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 408, DateTimeKind.Utc).AddTicks(6472),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 691, DateTimeKind.Utc).AddTicks(9742));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DigitalSignatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 407, DateTimeKind.Utc).AddTicks(7884),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 691, DateTimeKind.Utc).AddTicks(446));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 408, DateTimeKind.Utc).AddTicks(1700),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 691, DateTimeKind.Utc).AddTicks(4579));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 408, DateTimeKind.Utc).AddTicks(999),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 691, DateTimeKind.Utc).AddTicks(3808));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Dependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 408, DateTimeKind.Utc).AddTicks(193),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 691, DateTimeKind.Utc).AddTicks(2940));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cycles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 407, DateTimeKind.Utc).AddTicks(7322),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 690, DateTimeKind.Utc).AddTicks(9807));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 407, DateTimeKind.Utc).AddTicks(6729),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 690, DateTimeKind.Utc).AddTicks(9185));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 407, DateTimeKind.Utc).AddTicks(6097),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 690, DateTimeKind.Utc).AddTicks(8536));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 412, DateTimeKind.Utc).AddTicks(8088),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 696, DateTimeKind.Utc).AddTicks(6640));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleCondition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 407, DateTimeKind.Utc).AddTicks(5517),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 690, DateTimeKind.Utc).AddTicks(7911));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Criterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 407, DateTimeKind.Utc).AddTicks(3623),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 690, DateTimeKind.Utc).AddTicks(5974));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 407, DateTimeKind.Utc).AddTicks(1787),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 690, DateTimeKind.Utc).AddTicks(3964));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 407, DateTimeKind.Utc).AddTicks(3023),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 690, DateTimeKind.Utc).AddTicks(5307));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 407, DateTimeKind.Utc).AddTicks(2404),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 690, DateTimeKind.Utc).AddTicks(4645));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 407, DateTimeKind.Utc).AddTicks(4926),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 690, DateTimeKind.Utc).AddTicks(7279));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 407, DateTimeKind.Utc).AddTicks(4326),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 690, DateTimeKind.Utc).AddTicks(6642));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Coordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 407, DateTimeKind.Utc).AddTicks(1221),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 690, DateTimeKind.Utc).AddTicks(3358));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CoordinatorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 407, DateTimeKind.Utc).AddTicks(651),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 690, DateTimeKind.Utc).AddTicks(2746));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 406, DateTimeKind.Utc).AddTicks(8108),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 690, DateTimeKind.Utc).AddTicks(88));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 405, DateTimeKind.Utc).AddTicks(6649),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 688, DateTimeKind.Utc).AddTicks(8137));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Committees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 406, DateTimeKind.Utc).AddTicks(7499),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 689, DateTimeKind.Utc).AddTicks(9451));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 406, DateTimeKind.Utc).AddTicks(6275),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 689, DateTimeKind.Utc).AddTicks(8797));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Circulars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 406, DateTimeKind.Utc).AddTicks(3170),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 689, DateTimeKind.Utc).AddTicks(5415));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 406, DateTimeKind.Utc).AddTicks(5601),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 689, DateTimeKind.Utc).AddTicks(8077));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularChairmans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 406, DateTimeKind.Utc).AddTicks(4973),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 689, DateTimeKind.Utc).AddTicks(7399));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 406, DateTimeKind.Utc).AddTicks(4367),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 689, DateTimeKind.Utc).AddTicks(6757));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 406, DateTimeKind.Utc).AddTicks(3753),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 689, DateTimeKind.Utc).AddTicks(6094));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatBotQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 406, DateTimeKind.Utc).AddTicks(2033),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 689, DateTimeKind.Utc).AddTicks(4200));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnInitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 405, DateTimeKind.Utc).AddTicks(314),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 688, DateTimeKind.Utc).AddTicks(1511));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnFinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 409, DateTimeKind.Utc).AddTicks(4749),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 692, DateTimeKind.Utc).AddTicks(8625));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 404, DateTimeKind.Utc).AddTicks(9704),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 688, DateTimeKind.Utc).AddTicks(847));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 406, DateTimeKind.Utc).AddTicks(856),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 689, DateTimeKind.Utc).AddTicks(2805));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryEducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 406, DateTimeKind.Utc).AddTicks(230),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 689, DateTimeKind.Utc).AddTicks(2124));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryCommittees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 405, DateTimeKind.Utc).AddTicks(9587),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 689, DateTimeKind.Utc).AddTicks(1379));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoriesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 405, DateTimeKind.Utc).AddTicks(8954),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 689, DateTimeKind.Utc).AddTicks(540));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 406, DateTimeKind.Utc).AddTicks(1457),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 689, DateTimeKind.Utc).AddTicks(3481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardStatistics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 405, DateTimeKind.Utc).AddTicks(8347),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 688, DateTimeKind.Utc).AddTicks(9913));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardSponsors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 405, DateTimeKind.Utc).AddTicks(7769),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 688, DateTimeKind.Utc).AddTicks(9264));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardPublications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 405, DateTimeKind.Utc).AddTicks(7262),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 688, DateTimeKind.Utc).AddTicks(8717));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeTableNames",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 407, DateTimeKind.Utc).AddTicks(9500),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 691, DateTimeKind.Utc).AddTicks(2164));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeOperations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 407, DateTimeKind.Utc).AddTicks(8991),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 691, DateTimeKind.Utc).AddTicks(1625));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeDataTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 407, DateTimeKind.Utc).AddTicks(8463),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 691, DateTimeKind.Utc).AddTicks(1108));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 405, DateTimeKind.Utc).AddTicks(5394),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 688, DateTimeKind.Utc).AddTicks(6872));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 405, DateTimeKind.Utc).AddTicks(4842),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 688, DateTimeKind.Utc).AddTicks(6282));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 405, DateTimeKind.Utc).AddTicks(4214),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 688, DateTimeKind.Utc).AddTicks(5628));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScalesCriterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 405, DateTimeKind.Utc).AddTicks(3567),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 688, DateTimeKind.Utc).AddTicks(4927));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 405, DateTimeKind.Utc).AddTicks(2934),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 688, DateTimeKind.Utc).AddTicks(4258));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 404, DateTimeKind.Utc).AddTicks(8298),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 687, DateTimeKind.Utc).AddTicks(9363));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationResults",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 405, DateTimeKind.Utc).AddTicks(2339),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 688, DateTimeKind.Utc).AddTicks(3618));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 404, DateTimeKind.Utc).AddTicks(9040),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 688, DateTimeKind.Utc).AddTicks(123));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AppVersions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 404, DateTimeKind.Utc).AddTicks(7687),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 687, DateTimeKind.Utc).AddTicks(8681));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Albums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 404, DateTimeKind.Utc).AddTicks(6565),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 687, DateTimeKind.Utc).AddTicks(7529));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Agendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 404, DateTimeKind.Utc).AddTicks(6014),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 687, DateTimeKind.Utc).AddTicks(6946));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 404, DateTimeKind.Utc).AddTicks(4654),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 687, DateTimeKind.Utc).AddTicks(5601));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 404, DateTimeKind.Utc).AddTicks(3976),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 687, DateTimeKind.Utc).AddTicks(4910));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderTableValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 404, DateTimeKind.Utc).AddTicks(3301),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 687, DateTimeKind.Utc).AddTicks(4202));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 404, DateTimeKind.Utc).AddTicks(2672),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 687, DateTimeKind.Utc).AddTicks(3561));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 403, DateTimeKind.Utc).AddTicks(7510),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 686, DateTimeKind.Utc).AddTicks(7977));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 404, DateTimeKind.Utc).AddTicks(2088),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 687, DateTimeKind.Utc).AddTicks(2927));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 404, DateTimeKind.Utc).AddTicks(1529),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 687, DateTimeKind.Utc).AddTicks(2296));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 404, DateTimeKind.Utc).AddTicks(975),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 687, DateTimeKind.Utc).AddTicks(1704));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 404, DateTimeKind.Utc).AddTicks(378),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 687, DateTimeKind.Utc).AddTicks(995));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 403, DateTimeKind.Utc).AddTicks(9683),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 687, DateTimeKind.Utc).AddTicks(223));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 403, DateTimeKind.Utc).AddTicks(9092),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 686, DateTimeKind.Utc).AddTicks(9611));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 403, DateTimeKind.Utc).AddTicks(8306),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 686, DateTimeKind.Utc).AddTicks(8813));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Achievements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 403, DateTimeKind.Utc).AddTicks(6820),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 686, DateTimeKind.Utc).AddTicks(7265));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutAwardPage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 403, DateTimeKind.Utc).AddTicks(5406),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 686, DateTimeKind.Utc).AddTicks(5841));

            migrationBuilder.CreateTable(
                name: "ComitteeOfficers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommitteeId = table.Column<int>(type: "int", nullable: false),
                    ArbitratorId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 406, DateTimeKind.Utc).AddTicks(6904)),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComitteeOfficers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComitteeOfficers_Arbitrators_ArbitratorId",
                        column: x => x.ArbitratorId,
                        principalTable: "Arbitrators",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ComitteeOfficers_Committees_CommitteeId",
                        column: x => x.CommitteeId,
                        principalTable: "Committees",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComitteeOfficers_ArbitratorId",
                table: "ComitteeOfficers",
                column: "ArbitratorId");

            migrationBuilder.CreateIndex(
                name: "IX_ComitteeOfficers_CommitteeId",
                table: "ComitteeOfficers",
                column: "CommitteeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComitteeOfficers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WorkflowQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 689, DateTimeKind.Utc).AddTicks(4812),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 406, DateTimeKind.Utc).AddTicks(2606));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 697, DateTimeKind.Utc).AddTicks(1453),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 413, DateTimeKind.Utc).AddTicks(2246));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponseAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 697, DateTimeKind.Utc).AddTicks(2156),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 413, DateTimeKind.Utc).AddTicks(2857));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VirtualTableForSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 687, DateTimeKind.Utc).AddTicks(6359),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 404, DateTimeKind.Utc).AddTicks(5380));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 692, DateTimeKind.Utc).AddTicks(1173),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 408, DateTimeKind.Utc).AddTicks(7854));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserTokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 694, DateTimeKind.Utc).AddTicks(267),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 410, DateTimeKind.Utc).AddTicks(2347));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UsersRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 693, DateTimeKind.Utc).AddTicks(9516),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 410, DateTimeKind.Utc).AddTicks(1721));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 693, DateTimeKind.Utc).AddTicks(8757),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 410, DateTimeKind.Utc).AddTicks(1112));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 695, DateTimeKind.Utc).AddTicks(3704),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 411, DateTimeKind.Utc).AddTicks(2817));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 697, DateTimeKind.Utc).AddTicks(705),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 413, DateTimeKind.Utc).AddTicks(1611));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 696, DateTimeKind.Utc).AddTicks(9991),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 413, DateTimeKind.Utc).AddTicks(1034));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 696, DateTimeKind.Utc).AddTicks(9260),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 413, DateTimeKind.Utc).AddTicks(468));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermsAndConditions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 696, DateTimeKind.Utc).AddTicks(7935),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 412, DateTimeKind.Utc).AddTicks(9224));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermAndConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 696, DateTimeKind.Utc).AddTicks(8598),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 412, DateTimeKind.Utc).AddTicks(9842));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Templates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 696, DateTimeKind.Utc).AddTicks(7282),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 412, DateTimeKind.Utc).AddTicks(8650));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SwitchArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 688, DateTimeKind.Utc).AddTicks(2905),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 405, DateTimeKind.Utc).AddTicks(1626));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubcommitteeCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 688, DateTimeKind.Utc).AddTicks(7489),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 405, DateTimeKind.Utc).AddTicks(5987));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 694, DateTimeKind.Utc).AddTicks(6900),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 410, DateTimeKind.Utc).AddTicks(7659));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StrategicPartners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 696, DateTimeKind.Utc).AddTicks(5937),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 412, DateTimeKind.Utc).AddTicks(7480));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 696, DateTimeKind.Utc).AddTicks(5297),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 412, DateTimeKind.Utc).AddTicks(6798));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 692, DateTimeKind.Utc).AddTicks(439),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 408, DateTimeKind.Utc).AddTicks(7146));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SocialMedias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 696, DateTimeKind.Utc).AddTicks(4723),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 412, DateTimeKind.Utc).AddTicks(6229));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SavedCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 696, DateTimeKind.Utc).AddTicks(4057),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 412, DateTimeKind.Utc).AddTicks(5540));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 693, DateTimeKind.Utc).AddTicks(7320),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 409, DateTimeKind.Utc).AddTicks(9919));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RolePermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 693, DateTimeKind.Utc).AddTicks(8032),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 410, DateTimeKind.Utc).AddTicks(529));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RoleMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 696, DateTimeKind.Utc).AddTicks(3307),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 412, DateTimeKind.Utc).AddTicks(4491));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rewards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 696, DateTimeKind.Utc).AddTicks(2626),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 412, DateTimeKind.Utc).AddTicks(3525));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ResponsibilitiesUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 696, DateTimeKind.Utc).AddTicks(1889),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 412, DateTimeKind.Utc).AddTicks(2636));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Responsibilities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 696, DateTimeKind.Utc).AddTicks(1190),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 412, DateTimeKind.Utc).AddTicks(1862));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 695, DateTimeKind.Utc).AddTicks(9802),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 412, DateTimeKind.Utc).AddTicks(252));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccountRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 696, DateTimeKind.Utc).AddTicks(482),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 412, DateTimeKind.Utc).AddTicks(1023));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ReferenceSources",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 695, DateTimeKind.Utc).AddTicks(9166),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 411, DateTimeKind.Utc).AddTicks(9567));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 695, DateTimeKind.Utc).AddTicks(8462),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 411, DateTimeKind.Utc).AddTicks(8744));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Personalnvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 694, DateTimeKind.Utc).AddTicks(6076),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 410, DateTimeKind.Utc).AddTicks(7087));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Permissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 693, DateTimeKind.Utc).AddTicks(6045),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 409, DateTimeKind.Utc).AddTicks(8855));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PermissionHeaders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 693, DateTimeKind.Utc).AddTicks(6715),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 409, DateTimeKind.Utc).AddTicks(9396));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 695, DateTimeKind.Utc).AddTicks(5588),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 411, DateTimeKind.Utc).AddTicks(4830));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructureImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 695, DateTimeKind.Utc).AddTicks(7691),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 411, DateTimeKind.Utc).AddTicks(7891));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 695, DateTimeKind.Utc).AddTicks(6957),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 411, DateTimeKind.Utc).AddTicks(6841));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OurGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 686, DateTimeKind.Utc).AddTicks(6552),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 403, DateTimeKind.Utc).AddTicks(6099));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OnePageText",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 695, DateTimeKind.Utc).AddTicks(4985),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 411, DateTimeKind.Utc).AddTicks(3940));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NotificationTemplates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 695, DateTimeKind.Utc).AddTicks(4411),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 411, DateTimeKind.Utc).AddTicks(3404));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Notifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 695, DateTimeKind.Utc).AddTicks(3061),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 411, DateTimeKind.Utc).AddTicks(2227));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsTickers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 695, DateTimeKind.Utc).AddTicks(2466),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 411, DateTimeKind.Utc).AddTicks(1694));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 695, DateTimeKind.Utc).AddTicks(1826),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 411, DateTimeKind.Utc).AddTicks(1159));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 695, DateTimeKind.Utc).AddTicks(1130),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 411, DateTimeKind.Utc).AddTicks(614));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 690, DateTimeKind.Utc).AddTicks(2130),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 407, DateTimeKind.Utc).AddTicks(60));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 695, DateTimeKind.Utc).AddTicks(285),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 411, DateTimeKind.Utc).AddTicks(57));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Meetings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 694, DateTimeKind.Utc).AddTicks(9503),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 410, DateTimeKind.Utc).AddTicks(9509));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 694, DateTimeKind.Utc).AddTicks(8757),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 410, DateTimeKind.Utc).AddTicks(8937));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LogUserActions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 694, DateTimeKind.Utc).AddTicks(7899),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 410, DateTimeKind.Utc).AddTicks(8290));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 694, DateTimeKind.Utc).AddTicks(1586),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 410, DateTimeKind.Utc).AddTicks(3433));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 694, DateTimeKind.Utc).AddTicks(2355),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 410, DateTimeKind.Utc).AddTicks(4040));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeParticipants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 694, DateTimeKind.Utc).AddTicks(4509),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 410, DateTimeKind.Utc).AddTicks(5865));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeNoteAndQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 694, DateTimeKind.Utc).AddTicks(3773),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 410, DateTimeKind.Utc).AddTicks(5218));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 694, DateTimeKind.Utc).AddTicks(3086),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 410, DateTimeKind.Utc).AddTicks(4640));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Instructions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 694, DateTimeKind.Utc).AddTicks(942),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 410, DateTimeKind.Utc).AddTicks(2904));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 688, DateTimeKind.Utc).AddTicks(2196),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 405, DateTimeKind.Utc).AddTicks(959));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 695, DateTimeKind.Utc).AddTicks(6240),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 411, DateTimeKind.Utc).AddTicks(5767));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HomePageSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 693, DateTimeKind.Utc).AddTicks(5297),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 409, DateTimeKind.Utc).AddTicks(8297));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GroupInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 694, DateTimeKind.Utc).AddTicks(5358),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 410, DateTimeKind.Utc).AddTicks(6495));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 693, DateTimeKind.Utc).AddTicks(2539),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 409, DateTimeKind.Utc).AddTicks(7778));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 693, DateTimeKind.Utc).AddTicks(695),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 409, DateTimeKind.Utc).AddTicks(6720));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 693, DateTimeKind.Utc).AddTicks(1539),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 409, DateTimeKind.Utc).AddTicks(7260));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Galleries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 687, DateTimeKind.Utc).AddTicks(8101),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 404, DateTimeKind.Utc).AddTicks(7129));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FrequentlyAskedQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 692, DateTimeKind.Utc).AddTicks(7979),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 409, DateTimeKind.Utc).AddTicks(4130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 692, DateTimeKind.Utc).AddTicks(9992),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 409, DateTimeKind.Utc).AddTicks(6087));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 692, DateTimeKind.Utc).AddTicks(9298),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 409, DateTimeKind.Utc).AddTicks(5396));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 692, DateTimeKind.Utc).AddTicks(7356),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 409, DateTimeKind.Utc).AddTicks(3524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 692, DateTimeKind.Utc).AddTicks(6106),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 409, DateTimeKind.Utc).AddTicks(2373));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 692, DateTimeKind.Utc).AddTicks(6727),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 409, DateTimeKind.Utc).AddTicks(2948));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 692, DateTimeKind.Utc).AddTicks(5494),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 409, DateTimeKind.Utc).AddTicks(1827));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryGuides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 692, DateTimeKind.Utc).AddTicks(4912),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 409, DateTimeKind.Utc).AddTicks(1267));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 692, DateTimeKind.Utc).AddTicks(4244),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 409, DateTimeKind.Utc).AddTicks(676));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EntitiesCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 692, DateTimeKind.Utc).AddTicks(1880),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 408, DateTimeKind.Utc).AddTicks(8517));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 690, DateTimeKind.Utc).AddTicks(1483),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 406, DateTimeKind.Utc).AddTicks(9435));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 690, DateTimeKind.Utc).AddTicks(775),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 406, DateTimeKind.Utc).AddTicks(8734));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalInstitutions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 692, DateTimeKind.Utc).AddTicks(3616),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 409, DateTimeKind.Utc).AddTicks(123));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 692, DateTimeKind.Utc).AddTicks(3043),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 408, DateTimeKind.Utc).AddTicks(9572));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 692, DateTimeKind.Utc).AddTicks(2500),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 408, DateTimeKind.Utc).AddTicks(9074));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 691, DateTimeKind.Utc).AddTicks(9078),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 408, DateTimeKind.Utc).AddTicks(5866));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeTableValue",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 691, DateTimeKind.Utc).AddTicks(8432),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 408, DateTimeKind.Utc).AddTicks(5281));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 691, DateTimeKind.Utc).AddTicks(7775),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 408, DateTimeKind.Utc).AddTicks(4686));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 691, DateTimeKind.Utc).AddTicks(5294),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 408, DateTimeKind.Utc).AddTicks(2368));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 691, DateTimeKind.Utc).AddTicks(7145),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 408, DateTimeKind.Utc).AddTicks(4072));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 691, DateTimeKind.Utc).AddTicks(6554),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 408, DateTimeKind.Utc).AddTicks(3530));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 691, DateTimeKind.Utc).AddTicks(5948),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 408, DateTimeKind.Utc).AddTicks(2979));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 691, DateTimeKind.Utc).AddTicks(9742),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 408, DateTimeKind.Utc).AddTicks(6472));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DigitalSignatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 691, DateTimeKind.Utc).AddTicks(446),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 407, DateTimeKind.Utc).AddTicks(7884));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 691, DateTimeKind.Utc).AddTicks(4579),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 408, DateTimeKind.Utc).AddTicks(1700));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 691, DateTimeKind.Utc).AddTicks(3808),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 408, DateTimeKind.Utc).AddTicks(999));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Dependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 691, DateTimeKind.Utc).AddTicks(2940),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 408, DateTimeKind.Utc).AddTicks(193));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cycles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 690, DateTimeKind.Utc).AddTicks(9807),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 407, DateTimeKind.Utc).AddTicks(7322));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 690, DateTimeKind.Utc).AddTicks(9185),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 407, DateTimeKind.Utc).AddTicks(6729));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 690, DateTimeKind.Utc).AddTicks(8536),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 407, DateTimeKind.Utc).AddTicks(6097));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 696, DateTimeKind.Utc).AddTicks(6640),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 412, DateTimeKind.Utc).AddTicks(8088));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleCondition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 690, DateTimeKind.Utc).AddTicks(7911),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 407, DateTimeKind.Utc).AddTicks(5517));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Criterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 690, DateTimeKind.Utc).AddTicks(5974),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 407, DateTimeKind.Utc).AddTicks(3623));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 690, DateTimeKind.Utc).AddTicks(3964),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 407, DateTimeKind.Utc).AddTicks(1787));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 690, DateTimeKind.Utc).AddTicks(5307),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 407, DateTimeKind.Utc).AddTicks(3023));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 690, DateTimeKind.Utc).AddTicks(4645),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 407, DateTimeKind.Utc).AddTicks(2404));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 690, DateTimeKind.Utc).AddTicks(7279),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 407, DateTimeKind.Utc).AddTicks(4926));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 690, DateTimeKind.Utc).AddTicks(6642),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 407, DateTimeKind.Utc).AddTicks(4326));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Coordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 690, DateTimeKind.Utc).AddTicks(3358),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 407, DateTimeKind.Utc).AddTicks(1221));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CoordinatorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 690, DateTimeKind.Utc).AddTicks(2746),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 407, DateTimeKind.Utc).AddTicks(651));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 690, DateTimeKind.Utc).AddTicks(88),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 406, DateTimeKind.Utc).AddTicks(8108));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 688, DateTimeKind.Utc).AddTicks(8137),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 405, DateTimeKind.Utc).AddTicks(6649));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Committees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 689, DateTimeKind.Utc).AddTicks(9451),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 406, DateTimeKind.Utc).AddTicks(7499));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 689, DateTimeKind.Utc).AddTicks(8797),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 406, DateTimeKind.Utc).AddTicks(6275));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Circulars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 689, DateTimeKind.Utc).AddTicks(5415),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 406, DateTimeKind.Utc).AddTicks(3170));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 689, DateTimeKind.Utc).AddTicks(8077),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 406, DateTimeKind.Utc).AddTicks(5601));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularChairmans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 689, DateTimeKind.Utc).AddTicks(7399),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 406, DateTimeKind.Utc).AddTicks(4973));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 689, DateTimeKind.Utc).AddTicks(6757),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 406, DateTimeKind.Utc).AddTicks(4367));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 689, DateTimeKind.Utc).AddTicks(6094),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 406, DateTimeKind.Utc).AddTicks(3753));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatBotQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 689, DateTimeKind.Utc).AddTicks(4200),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 406, DateTimeKind.Utc).AddTicks(2033));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnInitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 688, DateTimeKind.Utc).AddTicks(1511),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 405, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnFinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 692, DateTimeKind.Utc).AddTicks(8625),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 409, DateTimeKind.Utc).AddTicks(4749));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 688, DateTimeKind.Utc).AddTicks(847),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 404, DateTimeKind.Utc).AddTicks(9704));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 689, DateTimeKind.Utc).AddTicks(2805),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 406, DateTimeKind.Utc).AddTicks(856));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryEducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 689, DateTimeKind.Utc).AddTicks(2124),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 406, DateTimeKind.Utc).AddTicks(230));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryCommittees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 689, DateTimeKind.Utc).AddTicks(1379),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 405, DateTimeKind.Utc).AddTicks(9587));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoriesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 689, DateTimeKind.Utc).AddTicks(540),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 405, DateTimeKind.Utc).AddTicks(8954));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 689, DateTimeKind.Utc).AddTicks(3481),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 406, DateTimeKind.Utc).AddTicks(1457));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardStatistics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 688, DateTimeKind.Utc).AddTicks(9913),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 405, DateTimeKind.Utc).AddTicks(8347));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardSponsors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 688, DateTimeKind.Utc).AddTicks(9264),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 405, DateTimeKind.Utc).AddTicks(7769));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardPublications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 688, DateTimeKind.Utc).AddTicks(8717),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 405, DateTimeKind.Utc).AddTicks(7262));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeTableNames",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 691, DateTimeKind.Utc).AddTicks(2164),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 407, DateTimeKind.Utc).AddTicks(9500));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeOperations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 691, DateTimeKind.Utc).AddTicks(1625),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 407, DateTimeKind.Utc).AddTicks(8991));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeDataTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 691, DateTimeKind.Utc).AddTicks(1108),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 407, DateTimeKind.Utc).AddTicks(8463));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 688, DateTimeKind.Utc).AddTicks(6872),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 405, DateTimeKind.Utc).AddTicks(5394));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 688, DateTimeKind.Utc).AddTicks(6282),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 405, DateTimeKind.Utc).AddTicks(4842));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 688, DateTimeKind.Utc).AddTicks(5628),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 405, DateTimeKind.Utc).AddTicks(4214));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScalesCriterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 688, DateTimeKind.Utc).AddTicks(4927),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 405, DateTimeKind.Utc).AddTicks(3567));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 688, DateTimeKind.Utc).AddTicks(4258),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 405, DateTimeKind.Utc).AddTicks(2934));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 687, DateTimeKind.Utc).AddTicks(9363),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 404, DateTimeKind.Utc).AddTicks(8298));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationResults",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 688, DateTimeKind.Utc).AddTicks(3618),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 405, DateTimeKind.Utc).AddTicks(2339));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 688, DateTimeKind.Utc).AddTicks(123),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 404, DateTimeKind.Utc).AddTicks(9040));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AppVersions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 687, DateTimeKind.Utc).AddTicks(8681),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 404, DateTimeKind.Utc).AddTicks(7687));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Albums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 687, DateTimeKind.Utc).AddTicks(7529),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 404, DateTimeKind.Utc).AddTicks(6565));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Agendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 687, DateTimeKind.Utc).AddTicks(6946),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 404, DateTimeKind.Utc).AddTicks(6014));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 687, DateTimeKind.Utc).AddTicks(5601),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 404, DateTimeKind.Utc).AddTicks(4654));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 687, DateTimeKind.Utc).AddTicks(4910),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 404, DateTimeKind.Utc).AddTicks(3976));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderTableValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 687, DateTimeKind.Utc).AddTicks(4202),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 404, DateTimeKind.Utc).AddTicks(3301));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 687, DateTimeKind.Utc).AddTicks(3561),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 404, DateTimeKind.Utc).AddTicks(2672));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 686, DateTimeKind.Utc).AddTicks(7977),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 403, DateTimeKind.Utc).AddTicks(7510));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 687, DateTimeKind.Utc).AddTicks(2927),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 404, DateTimeKind.Utc).AddTicks(2088));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 687, DateTimeKind.Utc).AddTicks(2296),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 404, DateTimeKind.Utc).AddTicks(1529));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 687, DateTimeKind.Utc).AddTicks(1704),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 404, DateTimeKind.Utc).AddTicks(975));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 687, DateTimeKind.Utc).AddTicks(995),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 404, DateTimeKind.Utc).AddTicks(378));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 687, DateTimeKind.Utc).AddTicks(223),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 403, DateTimeKind.Utc).AddTicks(9683));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 686, DateTimeKind.Utc).AddTicks(9611),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 403, DateTimeKind.Utc).AddTicks(9092));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 686, DateTimeKind.Utc).AddTicks(8813),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 403, DateTimeKind.Utc).AddTicks(8306));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Achievements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 686, DateTimeKind.Utc).AddTicks(7265),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 403, DateTimeKind.Utc).AddTicks(6820));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutAwardPage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 11, 12, 36, 39, 686, DateTimeKind.Utc).AddTicks(5841),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 12, 8, 13, 28, 403, DateTimeKind.Utc).AddTicks(5406));
        }
    }
}
