using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Api.Migrations
{
    /// <inheritdoc />
    public partial class UpdateOnNotificationsTable_AddNewColumn_isStaticNotification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WorkflowQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(1669),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(5524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 26, DateTimeKind.Utc).AddTicks(4622),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 837, DateTimeKind.Utc).AddTicks(1927));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponseAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 26, DateTimeKind.Utc).AddTicks(5610),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 837, DateTimeKind.Utc).AddTicks(2491));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VirtualTableForSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(2291),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(9837));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(8202),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(6394));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserTokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(4629),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(9207));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UsersRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(3938),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(8646));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(3247),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(8111));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(7934),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(8940));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 26, DateTimeKind.Utc).AddTicks(3671),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 837, DateTimeKind.Utc).AddTicks(1348));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 26, DateTimeKind.Utc).AddTicks(2951),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 837, DateTimeKind.Utc).AddTicks(815));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermsAndConditions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 26, DateTimeKind.Utc).AddTicks(2312),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 837, DateTimeKind.Utc).AddTicks(280));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Templates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 26, DateTimeKind.Utc).AddTicks(1636),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(9763));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SwitchArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(9928),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(5822));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(1794),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(4006));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StrategicPartners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 26, DateTimeKind.Utc).AddTicks(223),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(8718));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(9548),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(8181));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(7316),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(5741));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SocialMedias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(8965),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(7672));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SavedCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(8282),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(7057));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(1886),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(7060));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RolePermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(2548),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(7583));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RoleMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(7523),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(6467));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rewards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(6784),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(5927));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ResponsibilitiesUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(6088),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(5384));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Responsibilities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(5423),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(4842));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(4070),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(3751));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccountRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(4757),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(4305));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ReferenceSources",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(3404),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(3235));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(2667),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(2674));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Personalnvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(1039),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(3480));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Permissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(542),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(6018));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PermissionHeaders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(1217),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(6563));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(9873),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(453));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructureImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(1876),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(2068));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(1216),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(1529));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OurGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(1218),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(646));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OnePageText",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(9241),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(9947));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NotificationTemplates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(8627),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(9461));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Notifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(7242),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(8410));

            migrationBuilder.AddColumn<bool>(
                name: "isStaticNotification",
                table: "Notifications",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsTickers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(6615),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(7937));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(5981),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(7347));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(5283),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(6806));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(9375),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(1577));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(4606),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(6174));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Meetings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(3948),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(5636));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(3243),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(5119));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LogUserActions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(2479),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(4536));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(5941),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(213));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(6587),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(734));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeParticipants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(9425),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(2376));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeNoteAndQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(8527),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(1792));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(7471),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(1263));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Instructions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(5303),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(9721));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(9143),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(5215));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(527),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(975));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HomePageSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(9903),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(5457));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GroupInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(324),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(2943));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(9307),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(4979));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(8108),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(4016));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(8718),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(4507));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Galleries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(4351),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(1434));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FrequentlyAskedQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(5051),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(1701));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(7360),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(3446));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(6602),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(2835));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(4315),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(1176));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(3658),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(643));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(3028),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(133));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryGuides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(2415),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(9637));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(1776),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(9128));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EntitiesCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(9001),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(7031));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(8635),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(1026));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(7896),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(454));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalInstitutions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(1079),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(8609));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(406),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(8087));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(9692),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(7585));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(5742),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(4402));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeTableValue",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(5027),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(3873));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(4255),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(3347));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(1435),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(1258));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(3491),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(2812));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(2739),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(2309));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(2103),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(1802));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(6477),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(5103));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DigitalSignatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(6317),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(7243));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(647),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(664));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(9823),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(40));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Dependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(8899),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(9318));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cycles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(5612),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(6735));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(4930),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(6202));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 26, DateTimeKind.Utc).AddTicks(965),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(9257));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleCondition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(4187),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(5625));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Criterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(2784),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(4493));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(1333),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(3131));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(2052),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(3871));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(3490),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(5067));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Coordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(692),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(2616));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CoordinatorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(62),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(2096));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(7204),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(9892));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(4915),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(9775));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Committees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(6500),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(9350));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(5816),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(8801));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Circulars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(2322),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(6058));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(5104),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(8237));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularChairmans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(4393),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(7662));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(3709),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(7128));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(2990),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(6583));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatBotQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(1019),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(5006));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnInitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(8360),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(4618));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnFinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(5827),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(2249));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(7627),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(4046));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(9639),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(3894));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryEducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(8949),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(3235));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryCommittees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(8231),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(2622));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoriesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(7514),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(2005));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(356),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(4455));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardStatistics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(6789),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(1310));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardSponsors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(6170),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(777));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardPublications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(5557),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(294));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeTableNames",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(8113),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(8728));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeOperations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(7513),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(8251));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeDataTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(6946),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(7766));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(4259),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(9246));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(3630),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(8722));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(2911),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(8169));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScalesCriterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(2167),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(7565));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(1425),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(6981));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(5851),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(2679));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationResults",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(720),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(6425));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(6803),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(3373));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AppVersions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(5004),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(1942));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Albums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(3682),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(925));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Agendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(3001),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(392));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(1441),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(9096));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(595),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(8471));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderTableValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(9821),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(7893));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(9089),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(7329));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(2850),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(2093));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(8388),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(6791));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(7710),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(6253));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(7042),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(5604));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(6308),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(4944));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(5454),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(4184));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(4736),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(3636));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(3831),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(2916));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Achievements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(2048),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(1435));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutAwardPage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(402),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 828, DateTimeKind.Utc).AddTicks(9971));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isStaticNotification",
                table: "Notifications");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WorkflowQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(5524),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(1669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 837, DateTimeKind.Utc).AddTicks(1927),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 26, DateTimeKind.Utc).AddTicks(4622));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponseAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 837, DateTimeKind.Utc).AddTicks(2491),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 26, DateTimeKind.Utc).AddTicks(5610));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VirtualTableForSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(9837),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(2291));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(6394),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(8202));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserTokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(9207),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(4629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UsersRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(8646),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(3938));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(8111),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(3247));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(8940),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(7934));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 837, DateTimeKind.Utc).AddTicks(1348),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 26, DateTimeKind.Utc).AddTicks(3671));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 837, DateTimeKind.Utc).AddTicks(815),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 26, DateTimeKind.Utc).AddTicks(2951));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermsAndConditions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 837, DateTimeKind.Utc).AddTicks(280),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 26, DateTimeKind.Utc).AddTicks(2312));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Templates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(9763),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 26, DateTimeKind.Utc).AddTicks(1636));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SwitchArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(5822),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(9928));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(4006),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(1794));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StrategicPartners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(8718),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 26, DateTimeKind.Utc).AddTicks(223));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(8181),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(9548));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(5741),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(7316));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SocialMedias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(7672),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(8965));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SavedCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(7057),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(8282));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(7060),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(1886));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RolePermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(7583),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(2548));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RoleMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(6467),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(7523));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rewards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(5927),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(6784));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ResponsibilitiesUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(5384),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(6088));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Responsibilities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(4842),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(5423));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(3751),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(4070));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccountRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(4305),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(4757));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ReferenceSources",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(3235),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(3404));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(2674),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(2667));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Personalnvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(3480),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(1039));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Permissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(6018),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(542));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PermissionHeaders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(6563),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(1217));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(453),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(9873));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructureImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(2068),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(1876));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(1529),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(1216));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OurGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(646),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(1218));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OnePageText",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(9947),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(9241));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NotificationTemplates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(9461),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(8627));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Notifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(8410),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(7242));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsTickers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(7937),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(6615));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(7347),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(5981));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(6806),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(5283));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(1577),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(9375));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(6174),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(4606));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Meetings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(5636),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(3948));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(5119),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(3243));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LogUserActions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(4536),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(2479));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(213),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(5941));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(734),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(6587));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeParticipants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(2376),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(9425));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeNoteAndQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(1792),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(8527));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(1263),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(7471));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Instructions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(9721),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(5303));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(5215),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(9143));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(975),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(527));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HomePageSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(5457),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(9903));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GroupInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(2943),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(324));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(4979),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(9307));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(4016),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(8108));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(4507),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(8718));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Galleries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(1434),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(4351));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FrequentlyAskedQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(1701),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(5051));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(3446),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(7360));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(2835),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(6602));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(1176),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(4315));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(643),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(3658));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(133),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(3028));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryGuides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(9637),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(2415));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(9128),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(1776));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EntitiesCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(7031),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(9001));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(1026),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(8635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(454),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(7896));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalInstitutions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(8609),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(1079));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(8087),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(406));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(7585),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(9692));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(4402),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(5742));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeTableValue",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(3873),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(5027));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(3347),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(4255));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(1258),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(1435));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(2812),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(3491));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(2309),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(2739));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(1802),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(2103));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(5103),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(6477));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DigitalSignatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(7243),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(6317));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(664),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(647));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(40),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(9823));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Dependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(9318),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(8899));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cycles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(6735),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(5612));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(6202),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(4930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(9257),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 26, DateTimeKind.Utc).AddTicks(965));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleCondition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(5625),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(4187));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Criterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(4493),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(2784));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(3131),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(1333));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(3871),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(2052));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(5067),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(3490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Coordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(2616),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(692));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CoordinatorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(2096),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(62));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(9892),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(7204));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(9775),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(4915));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Committees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(9350),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(6500));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(8801),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(5816));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Circulars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(6058),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(2322));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(8237),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(5104));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularChairmans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(7662),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(4393));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(7128),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(3709));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(6583),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(2990));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatBotQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(5006),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(1019));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnInitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(4618),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(8360));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnFinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(2249),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(5827));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(4046),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(7627));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(3894),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(9639));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryEducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(3235),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(8949));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryCommittees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(2622),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(8231));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoriesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(2005),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(7514));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(4455),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(356));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardStatistics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(1310),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(6789));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardSponsors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(777),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(6170));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardPublications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(294),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(5557));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeTableNames",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(8728),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(8113));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeOperations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(8251),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(7513));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeDataTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(7766),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(6946));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(9246),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(4259));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(8722),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(3630));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(8169),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(2911));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScalesCriterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(7565),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(2167));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(6981),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(1425));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(2679),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(5851));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationResults",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(6425),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(720));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(3373),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(6803));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AppVersions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(1942),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(5004));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Albums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(925),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(3682));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Agendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(392),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(3001));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(9096),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(1441));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(8471),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(595));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderTableValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(7893),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(9821));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(7329),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(9089));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(2093),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(2850));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(6791),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(8388));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(6253),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(7710));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(5604),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(7042));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(4944),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(6308));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(4184),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(5454));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(3636),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(4736));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(2916),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(3831));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Achievements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(1435),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(2048));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutAwardPage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 828, DateTimeKind.Utc).AddTicks(9971),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(402));
        }
    }
}
