using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Api.Migrations
{
    /// <inheritdoc />
    public partial class UpdateOnTable_Circulars_DeleteColumn_IsRead : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRead",
                table: "Circulars");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WorkflowQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(9586),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(1669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 912, DateTimeKind.Utc).AddTicks(31),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 26, DateTimeKind.Utc).AddTicks(4622));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponseAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 912, DateTimeKind.Utc).AddTicks(846),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 26, DateTimeKind.Utc).AddTicks(5610));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VirtualTableForSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(342),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(2291));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(5286),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(8202));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserTokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(1018),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(4629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UsersRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(328),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(3938));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(9643),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(3247));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(2847),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(7934));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(9319),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 26, DateTimeKind.Utc).AddTicks(3671));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(8646),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 26, DateTimeKind.Utc).AddTicks(2951));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermsAndConditions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(8018),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 26, DateTimeKind.Utc).AddTicks(2312));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Templates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(7396),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 26, DateTimeKind.Utc).AddTicks(1636));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SwitchArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(8090),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(9928));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(7091),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(1794));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StrategicPartners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(6118),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 26, DateTimeKind.Utc).AddTicks(223));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(5496),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(9548));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(4520),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(7316));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SocialMedias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(4928),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(8965));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SavedCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(4219),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(8282));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(8323),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(1886));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RolePermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(8976),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(2548));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RoleMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(3430),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(7523));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rewards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(2706),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(6784));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ResponsibilitiesUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(1970),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(6088));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Responsibilities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(1029),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(5423));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(9382),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(4070));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccountRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(227),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(4757));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ReferenceSources",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(8686),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(3404));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(7883),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(2667));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Personalnvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(6435),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(1039));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Permissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(7067),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(542));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PermissionHeaders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(7695),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(1217));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(4829),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(9873));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructureImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(7041),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(1876));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(6373),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(1216));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OurGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 901, DateTimeKind.Utc).AddTicks(8785),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(1218));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OnePageText",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(4154),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(9241));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NotificationTemplates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(3562),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(8627));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Notifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(2117),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(7242));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsTickers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(1559),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(6615));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(961),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(5981));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(335),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(5283));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(7257),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(9375));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(9658),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(4606));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Meetings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(9053),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(3948));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(8417),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(3243));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LogUserActions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(7738),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(2479));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(2227),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(5941));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(2861),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(6587));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeParticipants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(4999),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(9425));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeNoteAndQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(4171),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(8527));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(3503),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(7471));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Instructions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(1638),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(5303));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(7098),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(9143));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(5597),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(527));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HomePageSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(6442),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(9903));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GroupInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(5669),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(324));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(5838),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(9307));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(4566),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(8108));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(5176),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(8718));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Galleries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(2269),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(4351));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FrequentlyAskedQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(1697),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(5051));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(3874),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(7360));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(3102),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(6602));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(1056),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(4315));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(399),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(3658));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(9758),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(3028));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryGuides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(9152),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(2415));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(8522),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(1776));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EntitiesCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(6069),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(9001));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(6609),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(8635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(5783),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(7896));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalInstitutions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(7891),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(1079));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(7282),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(406));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(6721),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(9692));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(3143),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(5742));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeTableValue",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(2481),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(5027));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(1707),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(4255));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(9091),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(1435));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(1110),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(3491));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(404),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(2739));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(9782),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(2103));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(3831),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(6477));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DigitalSignatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(4044),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(6317));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(8371),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(647));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(7577),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(9823));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Dependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(6578),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(8899));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cycles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(3414),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(5612));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(2770),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(4930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(6784),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 26, DateTimeKind.Utc).AddTicks(965));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleCondition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(2108),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(4187));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Criterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(708),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(2784));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(9262),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(1333));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(9984),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(2052));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(1412),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(3490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Coordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(8628),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(692));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CoordinatorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(7981),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(62));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(5026),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(7204));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(3010),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(4915));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Committees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(4365),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(6500));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(3687),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(5816));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Circulars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(240),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(2322));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(2985),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(5104));

            migrationBuilder.AddColumn<bool>(
                name: "IsRead",
                table: "CircularCoordinators",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularChairmans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(2288),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(4393));

            migrationBuilder.AddColumn<bool>(
                name: "IsRead",
                table: "CircularChairmans",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(1626),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(3709));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(978),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(2990));

            migrationBuilder.AddColumn<bool>(
                name: "IsRead",
                table: "CircularArbitrators",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatBotQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(8939),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(1019));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnInitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(6354),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(8360));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnFinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(2362),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(5827));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(5648),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(7627));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(7606),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(9639));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryEducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(6907),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(8949));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryCommittees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(6171),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(8231));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoriesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(5471),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(7514));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(8280),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(356));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardStatistics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(4806),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(6789));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardSponsors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(4196),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(6170));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardPublications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(3620),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(5557));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeTableNames",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(5824),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(8113));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeOperations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(5236),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(7513));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeDataTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(4659),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(6946));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(2366),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(4259));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(1743),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(3630));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(963),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(2911));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScalesCriterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(244),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(2167));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(9511),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(1425));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(4011),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(5851));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationResults",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(8835),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(720));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(4930),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(6803));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AppVersions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(3142),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(5004));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Albums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(1595),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(3682));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Agendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(985),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(3001));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(9411),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(1441));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(8617),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(595));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderTableValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(7842),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(9821));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(7081),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(9089));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(481),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(2850));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(6356),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(8388));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(5706),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(7710));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(5050),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(7042));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(4325),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(6308));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(3499),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(5454));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(2754),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(4736));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(1469),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(3831));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Achievements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 901, DateTimeKind.Utc).AddTicks(9635),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(2048));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutAwardPage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 901, DateTimeKind.Utc).AddTicks(7828),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(402));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRead",
                table: "CircularCoordinators");

            migrationBuilder.DropColumn(
                name: "IsRead",
                table: "CircularChairmans");

            migrationBuilder.DropColumn(
                name: "IsRead",
                table: "CircularArbitrators");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WorkflowQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(1669),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(9586));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 26, DateTimeKind.Utc).AddTicks(4622),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 912, DateTimeKind.Utc).AddTicks(31));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponseAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 26, DateTimeKind.Utc).AddTicks(5610),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 912, DateTimeKind.Utc).AddTicks(846));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VirtualTableForSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(2291),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(342));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(8202),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(5286));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserTokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(4629),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(1018));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UsersRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(3938),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(328));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(3247),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(9643));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(7934),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(2847));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 26, DateTimeKind.Utc).AddTicks(3671),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(9319));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 26, DateTimeKind.Utc).AddTicks(2951),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(8646));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermsAndConditions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 26, DateTimeKind.Utc).AddTicks(2312),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(8018));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Templates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 26, DateTimeKind.Utc).AddTicks(1636),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(7396));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SwitchArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(9928),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(8090));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(1794),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(7091));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StrategicPartners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 26, DateTimeKind.Utc).AddTicks(223),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(6118));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(9548),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(5496));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(7316),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(4520));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SocialMedias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(8965),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(4928));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SavedCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(8282),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(4219));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(1886),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(8323));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RolePermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(2548),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(8976));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RoleMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(7523),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(3430));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rewards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(6784),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(2706));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ResponsibilitiesUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(6088),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(1970));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Responsibilities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(5423),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(1029));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(4070),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(9382));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccountRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(4757),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(227));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ReferenceSources",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(3404),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(8686));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(2667),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(7883));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Personalnvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(1039),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(6435));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Permissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(542),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(7067));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PermissionHeaders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(1217),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(7695));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(9873),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(4829));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructureImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(1876),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(7041));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(1216),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(6373));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OurGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(1218),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 901, DateTimeKind.Utc).AddTicks(8785));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OnePageText",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(9241),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(4154));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NotificationTemplates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(8627),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(3562));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Notifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(7242),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(2117));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsTickers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(6615),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(1559));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(5981),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(961));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(5283),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(335));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(9375),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(7257));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(4606),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(9658));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Meetings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(3948),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(9053));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(3243),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(8417));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LogUserActions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(2479),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(7738));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(5941),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(2227));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(6587),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(2861));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeParticipants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(9425),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(4999));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeNoteAndQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(8527),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(4171));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(7471),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(3503));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Instructions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 23, DateTimeKind.Utc).AddTicks(5303),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(1638));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(9143),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(7098));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 25, DateTimeKind.Utc).AddTicks(527),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(5597));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HomePageSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(9903),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(6442));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GroupInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 24, DateTimeKind.Utc).AddTicks(324),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(5669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(9307),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(5838));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(8108),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(4566));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(8718),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(5176));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Galleries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(4351),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(2269));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FrequentlyAskedQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(5051),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(1697));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(7360),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(3874));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(6602),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(3102));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(4315),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(1056));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(3658),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(399));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(3028),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(9758));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryGuides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(2415),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(9152));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(1776),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(8522));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EntitiesCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(9001),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(6069));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(8635),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(6609));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(7896),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(5783));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalInstitutions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(1079),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(7891));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(406),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(7282));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(9692),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(6721));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(5742),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(3143));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeTableValue",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(5027),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(2481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(4255),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(1707));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(1435),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(9091));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(3491),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(1110));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(2739),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(404));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(2103),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(9782));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(6477),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(3831));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DigitalSignatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(6317),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(4044));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 21, DateTimeKind.Utc).AddTicks(647),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(8371));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(9823),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(7577));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Dependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(8899),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(6578));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cycles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(5612),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(3414));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(4930),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(2770));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 26, DateTimeKind.Utc).AddTicks(965),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(6784));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleCondition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(4187),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(2108));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Criterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(2784),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(708));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(1333),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(9262));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(2052),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(9984));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(3490),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(1412));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Coordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(692),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(8628));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CoordinatorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(62),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(7981));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(7204),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(5026));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(4915),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(3010));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Committees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(6500),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(4365));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(5816),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(3687));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Circulars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(2322),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(240));

            migrationBuilder.AddColumn<bool>(
                name: "IsRead",
                table: "Circulars",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(5104),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(2985));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularChairmans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(4393),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(2288));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(3709),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(1626));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(2990),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(978));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatBotQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(1019),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(8939));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnInitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(8360),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(6354));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnFinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 22, DateTimeKind.Utc).AddTicks(5827),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(2362));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(7627),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(5648));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(9639),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(7606));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryEducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(8949),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(6907));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryCommittees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(8231),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(6171));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoriesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(7514),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(5471));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 19, DateTimeKind.Utc).AddTicks(356),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(8280));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardStatistics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(6789),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(4806));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardSponsors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(6170),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(4196));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardPublications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(5557),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(3620));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeTableNames",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(8113),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(5824));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeOperations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(7513),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(5236));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeDataTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 20, DateTimeKind.Utc).AddTicks(6946),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(4659));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(4259),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(2366));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(3630),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(1743));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(2911),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(963));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScalesCriterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(2167),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(244));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(1425),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(9511));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(5851),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(4011));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationResults",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 18, DateTimeKind.Utc).AddTicks(720),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(8835));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(6803),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(4930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AppVersions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(5004),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(3142));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Albums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(3682),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(1595));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Agendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(3001),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(985));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(1441),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(9411));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 17, DateTimeKind.Utc).AddTicks(595),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(8617));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderTableValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(9821),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(7842));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(9089),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(7081));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(2850),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(8388),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(6356));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(7710),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(5706));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(7042),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(5050));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(6308),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(4325));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(5454),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(3499));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(4736),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(2754));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(3831),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(1469));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Achievements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(2048),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 901, DateTimeKind.Utc).AddTicks(9635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutAwardPage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 8, 40, 54, 16, DateTimeKind.Utc).AddTicks(402),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 901, DateTimeKind.Utc).AddTicks(7828));
        }
    }
}
