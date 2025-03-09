using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Api.Migrations
{
    /// <inheritdoc />
    public partial class CreateNewTable_CycleConditionAttachmentTypes_UpdateTable_CycleCondition_RemoveColumn_AttachmentType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AttachmentType",
                table: "CycleCondition");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WorkflowQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(2309),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(1473));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(8349),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 279, DateTimeKind.Utc).AddTicks(5795));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponseAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(9017),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 279, DateTimeKind.Utc).AddTicks(6550));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VirtualTableForSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(4455),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(9740));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(7351),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(8728));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserTokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(1923),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(5094));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UsersRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(1242),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(4384));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(623),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(3685));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(3021),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(8042));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(7676),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 279, DateTimeKind.Utc).AddTicks(5012));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(7050),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 279, DateTimeKind.Utc).AddTicks(4304));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermsAndConditions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(6398),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 279, DateTimeKind.Utc).AddTicks(3571));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Templates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(5797),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 279, DateTimeKind.Utc).AddTicks(2847));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SwitchArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(1181),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 270, DateTimeKind.Utc).AddTicks(8893));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(7598),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(1408));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StrategicPartners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(4554),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 279, DateTimeKind.Utc).AddTicks(1414));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(3941),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 279, DateTimeKind.Utc).AddTicks(736));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(6698),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(7949));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SocialMedias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(3383),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 279, DateTimeKind.Utc).AddTicks(65));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SavedCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(2745),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(9321));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(9390),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(2310));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RolePermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(9999),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(2995));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RoleMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(2043),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(8494));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rewards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(1404),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(7752));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ResponsibilitiesUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(717),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(6984));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Responsibilities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(67),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(6217));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(8728),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(4708));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccountRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(9394),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(5486));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ReferenceSources",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(8115),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(3966));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(7452),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(3182));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Personalnvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(6956),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(714));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Permissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(8256),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(1016));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PermissionHeaders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(8841),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(1685));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(4793),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(104));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructureImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(6732),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(2330));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(6078),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(1593));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OurGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 860, DateTimeKind.Utc).AddTicks(4892),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 268, DateTimeKind.Utc).AddTicks(9017));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OnePageText",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(4195),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(9403));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NotificationTemplates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(3673),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(8757));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Notifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(2395),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(7328));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsTickers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(1824),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(6683));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(1211),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(6007));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(639),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(5314));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(9892),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(9532));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(54),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(4605));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Meetings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(9477),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(3807));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(8867),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(3094));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LogUserActions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(8222),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(2335));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(3118),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(6432));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(3721),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(7107));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeParticipants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(5670),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(9255));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeNoteAndQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(4957),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(8502));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(4345),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(7808));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Instructions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(2537),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(5766));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(436),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 270, DateTimeKind.Utc).AddTicks(8075));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(5423),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(834));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HomePageSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(7640),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(357));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GroupInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(6314),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(15));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(7074),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(9736));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(5879),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(8486));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(6520),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(9120));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Galleries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(6230),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 270, DateTimeKind.Utc).AddTicks(2626));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FrequentlyAskedQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(3193),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(5479));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(5141),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(7738));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(4432),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(6957));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(2620),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(4789));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(2043),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(4095));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(1481),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(3435));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryGuides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(910),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(2794));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(265),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(2124));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EntitiesCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(8042),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(9537));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(9189),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(8784));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(8395),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(8020));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalInstitutions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(9644),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(1453));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(9109),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(807));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(8603),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(198));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(5456),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(6505));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeTableValue",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(4882),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(5733));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(4293),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(5024));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(1928),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(2201));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(3705),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(4293));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(3151),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(3613));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(2582),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(2932));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(6071),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(7217));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DigitalSignatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(7173),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(6771));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(1258),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(1421));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(551),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(566));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Dependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(9630),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(9561));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cycles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(6564),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(6077));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(5974),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(5353));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(5196),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 279, DateTimeKind.Utc).AddTicks(2153));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleCondition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(4682),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(4607));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Criterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(3389),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(3031));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(1941),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(1563));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(2638),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(2297));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(4050),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(3773));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Coordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(1173),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(891));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CoordinatorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(558),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(224));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(7705),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(7300));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(5826),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(4252));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Committees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(6997),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(6580));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(6346),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(5864));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Circulars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(2972),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(2173));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(5668),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(5106));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularChairmans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(4975),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(4355));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(4328),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(3616));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(3691),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(2885));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatBotQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(1681),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(764));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnInitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(9699),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 270, DateTimeKind.Utc).AddTicks(7062));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnFinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(3790),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(6199));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(8968),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 270, DateTimeKind.Utc).AddTicks(6285));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(383),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(9279));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryEducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(9727),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(8546));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryCommittees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(9042),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(7779));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoriesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(8373),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(7014));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(1038),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(43));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardStatistics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(7702),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(6263));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardSponsors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(7095),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(5582));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardPublications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(6413),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(4937));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeTableNames",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(8925),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(8736));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeOperations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(8286),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(8106));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeDataTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(7763),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(7460));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(5230),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(3546));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(4600),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(2851));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(3938),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(2099));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScalesCriterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(3225),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(1288));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(2542),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(506));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(7484),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 270, DateTimeKind.Utc).AddTicks(4458));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationResults",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(1925),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 270, DateTimeKind.Utc).AddTicks(9750));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(8259),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 270, DateTimeKind.Utc).AddTicks(5389));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AppVersions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(6806),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 270, DateTimeKind.Utc).AddTicks(3346));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Albums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(5636),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 270, DateTimeKind.Utc).AddTicks(1933));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Agendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(5053),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 270, DateTimeKind.Utc).AddTicks(1235));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(3694),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(8856));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(2812),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(8062));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderTableValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(2080),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(7288));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(1411),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(6489));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 861, DateTimeKind.Utc).AddTicks(5600),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(528));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(770),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(5796));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(153),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(5104));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 861, DateTimeKind.Utc).AddTicks(9540),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(4459));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 861, DateTimeKind.Utc).AddTicks(8860),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(3757));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 861, DateTimeKind.Utc).AddTicks(8053),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(2955));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 861, DateTimeKind.Utc).AddTicks(7400),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(2268));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 861, DateTimeKind.Utc).AddTicks(6568),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(1419));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Achievements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 861, DateTimeKind.Utc).AddTicks(4581),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 268, DateTimeKind.Utc).AddTicks(9765));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutAwardPage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 860, DateTimeKind.Utc).AddTicks(4115),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 268, DateTimeKind.Utc).AddTicks(8227));

            migrationBuilder.CreateTable(
                name: "CycleConditionAttachmentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CycleConditionId = table.Column<int>(type: "int", nullable: false),
                    AttachmentType = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(5325)),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CycleConditionAttachmentTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CycleConditionAttachmentTypes_CycleCondition_CycleConditionId",
                        column: x => x.CycleConditionId,
                        principalTable: "CycleCondition",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CycleConditionAttachmentTypes_CycleConditionId",
                table: "CycleConditionAttachmentTypes",
                column: "CycleConditionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CycleConditionAttachmentTypes");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WorkflowQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(1473),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(2309));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 279, DateTimeKind.Utc).AddTicks(5795),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(8349));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponseAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 279, DateTimeKind.Utc).AddTicks(6550),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(9017));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VirtualTableForSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(9740),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(4455));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(8728),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(7351));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserTokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(5094),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(1923));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UsersRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(4384),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(1242));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(3685),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(623));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(8042),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(3021));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 279, DateTimeKind.Utc).AddTicks(5012),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(7676));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 279, DateTimeKind.Utc).AddTicks(4304),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(7050));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermsAndConditions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 279, DateTimeKind.Utc).AddTicks(3571),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(6398));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Templates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 279, DateTimeKind.Utc).AddTicks(2847),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(5797));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SwitchArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 270, DateTimeKind.Utc).AddTicks(8893),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(1181));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(1408),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(7598));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StrategicPartners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 279, DateTimeKind.Utc).AddTicks(1414),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(4554));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 279, DateTimeKind.Utc).AddTicks(736),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(3941));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(7949),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(6698));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SocialMedias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 279, DateTimeKind.Utc).AddTicks(65),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(3383));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SavedCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(9321),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(2745));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(2310),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(9390));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RolePermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(2995),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(9999));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RoleMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(8494),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(2043));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rewards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(7752),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(1404));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ResponsibilitiesUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(6984),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(717));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Responsibilities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(6217),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(67));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(4708),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(8728));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccountRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(5486),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(9394));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ReferenceSources",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(3966),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(8115));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(3182),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(7452));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Personalnvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(714),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(6956));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Permissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(1016),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(8256));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PermissionHeaders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(1685),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(8841));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(104),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(4793));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructureImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(2330),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(6732));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(1593),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(6078));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OurGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 268, DateTimeKind.Utc).AddTicks(9017),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 860, DateTimeKind.Utc).AddTicks(4892));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OnePageText",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(9403),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(4195));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NotificationTemplates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(8757),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(3673));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Notifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(7328),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(2395));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsTickers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(6683),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(1824));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(6007),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(1211));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(5314),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(639));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(9532),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(9892));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(4605),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(54));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Meetings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(3807),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(9477));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(3094),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(8867));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LogUserActions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(2335),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(8222));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(6432),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(3118));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(7107),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(3721));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeParticipants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(9255),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(5670));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeNoteAndQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(8502),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(4957));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(7808),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(4345));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Instructions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(5766),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(2537));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 270, DateTimeKind.Utc).AddTicks(8075),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(436));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(834),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(5423));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HomePageSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(357),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(7640));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GroupInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(15),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(6314));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(9736),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(7074));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(8486),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(5879));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(9120),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(6520));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Galleries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 270, DateTimeKind.Utc).AddTicks(2626),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(6230));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FrequentlyAskedQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(5479),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(3193));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(7738),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(5141));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(6957),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(4432));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(4789),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(2620));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(4095),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(2043));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(3435),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(1481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryGuides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(2794),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(910));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(2124),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(265));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EntitiesCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(9537),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(8042));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(8784),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(9189));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(8020),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(8395));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalInstitutions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(1453),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(9644));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(807),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(9109));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(198),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(8603));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(6505),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(5456));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeTableValue",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(5733),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(4882));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(5024),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(4293));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(2201),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(1928));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(4293),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(3705));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(3613),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(3151));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(2932),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(2582));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(7217),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(6071));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DigitalSignatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(6771),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(7173));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(1421),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(1258));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(566),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(551));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Dependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(9561),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(9630));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cycles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(6077),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(6564));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(5353),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(5974));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 279, DateTimeKind.Utc).AddTicks(2153),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(5196));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleCondition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(4607),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(4682));

            migrationBuilder.AddColumn<int>(
                name: "AttachmentType",
                table: "CycleCondition",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Criterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(3031),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(3389));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(1563),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(1941));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(2297),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(2638));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(3773),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(4050));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Coordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(891),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(1173));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CoordinatorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(224),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(558));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(7300),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(7705));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(4252),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(5826));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Committees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(6580),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(6997));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(5864),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(6346));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Circulars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(2173),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(2972));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(5106),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(5668));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularChairmans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(4355),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(4975));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(3616),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(4328));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(2885),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(3691));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatBotQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(764),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(1681));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnInitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 270, DateTimeKind.Utc).AddTicks(7062),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(9699));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnFinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(6199),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(3790));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 270, DateTimeKind.Utc).AddTicks(6285),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(8968));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(9279),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(383));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryEducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(8546),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(9727));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryCommittees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(7779),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(9042));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoriesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(7014),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(8373));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(43),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(1038));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardStatistics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(6263),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(7702));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardSponsors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(5582),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(7095));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardPublications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(4937),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(6413));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeTableNames",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(8736),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(8925));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeOperations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(8106),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(8286));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeDataTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(7460),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(7763));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(3546),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(5230));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(2851),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(4600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(2099),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(3938));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScalesCriterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(1288),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(3225));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(506),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(2542));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 270, DateTimeKind.Utc).AddTicks(4458),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(7484));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationResults",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 270, DateTimeKind.Utc).AddTicks(9750),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(1925));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 270, DateTimeKind.Utc).AddTicks(5389),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(8259));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AppVersions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 270, DateTimeKind.Utc).AddTicks(3346),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(6806));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Albums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 270, DateTimeKind.Utc).AddTicks(1933),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(5636));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Agendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 270, DateTimeKind.Utc).AddTicks(1235),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(5053));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(8856),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(3694));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(8062),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(2812));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderTableValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(7288),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(2080));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(6489),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(1411));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(528),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 861, DateTimeKind.Utc).AddTicks(5600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(5796),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(770));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(5104),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(153));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(4459),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 861, DateTimeKind.Utc).AddTicks(9540));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(3757),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 861, DateTimeKind.Utc).AddTicks(8860));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(2955),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 861, DateTimeKind.Utc).AddTicks(8053));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(2268),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 861, DateTimeKind.Utc).AddTicks(7400));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(1419),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 861, DateTimeKind.Utc).AddTicks(6568));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Achievements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 268, DateTimeKind.Utc).AddTicks(9765),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 861, DateTimeKind.Utc).AddTicks(4581));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutAwardPage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 268, DateTimeKind.Utc).AddTicks(8227),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 860, DateTimeKind.Utc).AddTicks(4115));
        }
    }
}
