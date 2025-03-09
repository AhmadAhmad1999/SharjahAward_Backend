using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Api.Migrations
{
    /// <inheritdoc />
    public partial class CreateNewTable_TermAndConditionAttachmentType_UpdateTable_TermAndCondition_RemoveColumn_AttachmentType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AttachmentType",
                table: "TermsAndConditions");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WorkflowQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(825),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(2309));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 913, DateTimeKind.Utc).AddTicks(2669),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(8349));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponseAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 913, DateTimeKind.Utc).AddTicks(4255),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(9017));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VirtualTableForSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(8874),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(4455));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(1763),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(7351));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserTokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(77),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(1923));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UsersRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(9272),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(1242));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(8490),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(623));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(3815),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(3021));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 911, DateTimeKind.Utc).AddTicks(2459),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(7676));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 911, DateTimeKind.Utc).AddTicks(1719),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(7050));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermsAndConditions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 911, DateTimeKind.Utc).AddTicks(200),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(6398));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Templates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(9484),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(5797));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SwitchArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(7111),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(1181));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(7126),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(7598));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StrategicPartners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(8013),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(4554));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(7318),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(3941));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(876),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(6698));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SocialMedias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(6649),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(3383));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SavedCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(5852),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(2745));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(6941),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(9390));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RolePermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(7712),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(9999));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RoleMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(4914),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(2043));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rewards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(4137),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(1404));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ResponsibilitiesUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(3305),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(717));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Responsibilities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(2462),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(67));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(853),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(8728));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccountRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(1679),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(9394));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ReferenceSources",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(105),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(8115));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(9253),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(7452));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Personalnvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(6360),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(6956));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Permissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(5458),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(8256));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PermissionHeaders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(6214),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(8841));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(6008),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(4793));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructureImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(8363),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(6732));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(7552),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(6078));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OurGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 899, DateTimeKind.Utc).AddTicks(6736),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 860, DateTimeKind.Utc).AddTicks(4892));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OnePageText",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(5295),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(4195));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NotificationTemplates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(4612),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(3673));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Notifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(3055),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(2395));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsTickers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(2411),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(1824));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(1705),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(1211));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(991),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(639));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(9792),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(9892));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(232),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(54));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Meetings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(9527),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(9477));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(8742),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(8867));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LogUserActions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(7921),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(8222));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(1538),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(3118));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(2288),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(3721));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeParticipants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(4726),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(5670));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeNoteAndQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(3856),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(4957));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(3086),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(4345));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Instructions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(812),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(2537));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(6213),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(436));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(6761),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(5423));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HomePageSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(4745),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(7640));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GroupInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(5584),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(6314));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(4067),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(7074));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(2657),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(5879));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(3374),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(6520));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Galleries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(1056),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(6230));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FrequentlyAskedQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(9281),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(3193));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(1848),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(5141));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(952),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(4432));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(8523),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(2620));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(7747),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(2043));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(6988),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(1481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryGuides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(6291),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(910));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(5558),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(265));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EntitiesCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(2638),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(8042));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(8934),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(9189));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(8086),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(8395));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalInstitutions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(4813),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(9644));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(4059),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(9109));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(3421),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(8603));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(9217),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(5456));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeTableValue",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(8432),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(4882));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(7676),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(4293));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(4617),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(1928));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(6877),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(3705));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(6145),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(3151));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(5412),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(2582));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(55),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(6071));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DigitalSignatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(8697),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(7173));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(3729),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(1258));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(2767),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(551));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Dependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(1693),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(9630));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cycles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(7846),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(6564));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(7008),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(5974));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(6221),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(5325));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(8768),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(5196));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleCondition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(5424),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(4682));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Criterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(3810),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(3389));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(2161),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(1941));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(2977),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(2638));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(4636),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(4050));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Coordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(1381),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(1173));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CoordinatorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(608),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(558));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(7276),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(7705));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(2853),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(5826));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Committees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(6484),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(6997));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(5697),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(6346));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Circulars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(1633),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(2972));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(4857),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(5668));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularChairmans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(3993),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(4975));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(3204),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(4328));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(2410),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(3691));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatBotQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(67),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(1681));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnInitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(5309),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(9699));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnFinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(70),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(3790));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(4486),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(8968));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(8476),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(383));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryEducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(7673),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(9727));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryCommittees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(6795),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(9042));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoriesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(5955),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(8373));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(9294),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(1038));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardStatistics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(5071),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(7702));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardSponsors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(4339),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(7095));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardPublications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(3608),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(6413));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeTableNames",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(808),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(8925));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeOperations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(139),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(8286));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeDataTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(9451),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(7763));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(2134),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(5230));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(1407),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(4600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(587),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(3938));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScalesCriterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(9727),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(3225));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(8822),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(2542));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(2624),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(7484));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationResults",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(8043),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(1925));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(3567),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(8259));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AppVersions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(1781),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(6806));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Albums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(322),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(5636));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Agendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(9616),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(5053));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(7930),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(3694));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(6955),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(2812));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderTableValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(6089),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(2080));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(5289),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(1411));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 899, DateTimeKind.Utc).AddTicks(8465),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 861, DateTimeKind.Utc).AddTicks(5600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(4518),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(770));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(3777),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(153));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(3045),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 861, DateTimeKind.Utc).AddTicks(9540));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(2238),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 861, DateTimeKind.Utc).AddTicks(8860));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(1294),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 861, DateTimeKind.Utc).AddTicks(8053));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(526),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 861, DateTimeKind.Utc).AddTicks(7400));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 899, DateTimeKind.Utc).AddTicks(9536),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 861, DateTimeKind.Utc).AddTicks(6568));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Achievements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 899, DateTimeKind.Utc).AddTicks(7583),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 861, DateTimeKind.Utc).AddTicks(4581));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutAwardPage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 899, DateTimeKind.Utc).AddTicks(5858),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 860, DateTimeKind.Utc).AddTicks(4115));

            migrationBuilder.CreateTable(
                name: "TermAndConditionAttachmentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TermAndConditionId = table.Column<int>(type: "int", nullable: false),
                    AttachmentType = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 911, DateTimeKind.Utc).AddTicks(938)),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TermAndConditionAttachmentTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TermAndConditionAttachmentTypes_TermsAndConditions_TermAndConditionId",
                        column: x => x.TermAndConditionId,
                        principalTable: "TermsAndConditions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TermAndConditionAttachmentTypes_TermAndConditionId",
                table: "TermAndConditionAttachmentTypes",
                column: "TermAndConditionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TermAndConditionAttachmentTypes");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WorkflowQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(2309),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(825));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(8349),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 913, DateTimeKind.Utc).AddTicks(2669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponseAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(9017),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 913, DateTimeKind.Utc).AddTicks(4255));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VirtualTableForSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(4455),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(8874));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(7351),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(1763));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserTokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(1923),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(77));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UsersRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(1242),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(9272));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(623),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(8490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(3021),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(3815));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(7676),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 911, DateTimeKind.Utc).AddTicks(2459));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(7050),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 911, DateTimeKind.Utc).AddTicks(1719));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermsAndConditions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(6398),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 911, DateTimeKind.Utc).AddTicks(200));

            migrationBuilder.AddColumn<int>(
                name: "AttachmentType",
                table: "TermsAndConditions",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Templates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(5797),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(9484));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SwitchArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(1181),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(7111));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(7598),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(7126));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StrategicPartners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(4554),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(8013));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(3941),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(7318));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(6698),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(876));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SocialMedias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(3383),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(6649));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SavedCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(2745),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(5852));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(9390),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(6941));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RolePermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(9999),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(7712));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RoleMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(2043),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(4914));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rewards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(1404),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(4137));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ResponsibilitiesUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(717),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(3305));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Responsibilities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(67),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(2462));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(8728),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(853));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccountRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(9394),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(1679));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ReferenceSources",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(8115),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(105));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(7452),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(9253));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Personalnvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(6956),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(6360));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Permissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(8256),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(5458));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PermissionHeaders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(8841),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(6214));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(4793),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(6008));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructureImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(6732),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(8363));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(6078),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(7552));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OurGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 860, DateTimeKind.Utc).AddTicks(4892),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 899, DateTimeKind.Utc).AddTicks(6736));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OnePageText",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(4195),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(5295));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NotificationTemplates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(3673),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(4612));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Notifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(2395),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(3055));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsTickers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(1824),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(2411));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(1211),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(1705));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(639),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(991));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(9892),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(9792));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(54),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(232));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Meetings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(9477),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(9527));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(8867),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(8742));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LogUserActions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(8222),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(7921));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(3118),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(1538));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(3721),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(2288));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeParticipants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(5670),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(4726));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeNoteAndQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(4957),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(3856));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(4345),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(3086));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Instructions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(2537),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(812));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(436),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(6213));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 869, DateTimeKind.Utc).AddTicks(5423),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(6761));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HomePageSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(7640),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(4745));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GroupInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 868, DateTimeKind.Utc).AddTicks(6314),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(5584));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(7074),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(4067));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(5879),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(2657));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(6520),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(3374));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Galleries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(6230),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(1056));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FrequentlyAskedQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(3193),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(9281));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(5141),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(1848));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(4432),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(952));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(2620),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(8523));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(2043),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(7747));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(1481),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(6988));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryGuides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(910),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(6291));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(265),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(5558));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EntitiesCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(8042),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(2638));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(9189),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(8934));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(8395),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(8086));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalInstitutions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(9644),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(4813));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(9109),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(4059));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(8603),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(3421));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(5456),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(9217));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeTableValue",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(4882),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(8432));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(4293),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(7676));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(1928),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(4617));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(3705),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(6877));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(3151),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(6145));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(2582),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(5412));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(6071),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(55));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DigitalSignatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(7173),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(8697));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(1258),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(3729));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 866, DateTimeKind.Utc).AddTicks(551),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(2767));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Dependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(9630),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(1693));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cycles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(6564),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(7846));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(5974),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(7008));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(5325),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(6221));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 870, DateTimeKind.Utc).AddTicks(5196),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(8768));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleCondition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(4682),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(5424));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Criterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(3389),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(3810));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(1941),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(2161));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(2638),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(2977));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(4050),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(4636));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Coordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(1173),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(1381));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CoordinatorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(558),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(608));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(7705),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(7276));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(5826),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(2853));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Committees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(6997),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(6484));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(6346),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(5697));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Circulars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(2972),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(1633));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(5668),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(4857));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularChairmans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(4975),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(3993));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(4328),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(3204));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(3691),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(2410));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatBotQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(1681),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(67));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnInitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(9699),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(5309));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnFinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 867, DateTimeKind.Utc).AddTicks(3790),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(70));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(8968),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(4486));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(383),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(8476));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryEducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(9727),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(7673));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryCommittees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(9042),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(6795));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoriesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(8373),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(5955));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 864, DateTimeKind.Utc).AddTicks(1038),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(9294));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardStatistics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(7702),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(5071));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardSponsors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(7095),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(4339));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardPublications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(6413),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(3608));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeTableNames",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(8925),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(808));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeOperations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(8286),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(139));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeDataTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 865, DateTimeKind.Utc).AddTicks(7763),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(9451));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(5230),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(2134));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(4600),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(1407));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(3938),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(587));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScalesCriterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(3225),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(9727));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(2542),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(8822));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(7484),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(2624));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationResults",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 863, DateTimeKind.Utc).AddTicks(1925),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(8043));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(8259),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(3567));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AppVersions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(6806),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(1781));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Albums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(5636),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(322));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Agendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(5053),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(9616));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(3694),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(7930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(2812),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(6955));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderTableValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(2080),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(6089));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(1411),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(5289));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 861, DateTimeKind.Utc).AddTicks(5600),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 899, DateTimeKind.Utc).AddTicks(8465));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(770),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(4518));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 862, DateTimeKind.Utc).AddTicks(153),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(3777));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 861, DateTimeKind.Utc).AddTicks(9540),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(3045));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 861, DateTimeKind.Utc).AddTicks(8860),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(2238));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 861, DateTimeKind.Utc).AddTicks(8053),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(1294));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 861, DateTimeKind.Utc).AddTicks(7400),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(526));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 861, DateTimeKind.Utc).AddTicks(6568),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 899, DateTimeKind.Utc).AddTicks(9536));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Achievements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 861, DateTimeKind.Utc).AddTicks(4581),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 899, DateTimeKind.Utc).AddTicks(7583));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutAwardPage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 11, 2, 56, 860, DateTimeKind.Utc).AddTicks(4115),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 899, DateTimeKind.Utc).AddTicks(5858));
        }
    }
}
