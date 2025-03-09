using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Api.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTable_CircularAttachments_AddNewColumn_FileName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WorkflowQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(27),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(3764));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 58, DateTimeKind.Utc).AddTicks(6153),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 715, DateTimeKind.Utc).AddTicks(2982));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponseAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 58, DateTimeKind.Utc).AddTicks(6988),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 715, DateTimeKind.Utc).AddTicks(4301));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VirtualTableForSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(6006),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(675));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(5066),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(7513));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserTokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 53, DateTimeKind.Utc).AddTicks(1161),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(6744));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UsersRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 52, DateTimeKind.Utc).AddTicks(9648),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(5966));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 52, DateTimeKind.Utc).AddTicks(6534),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(4430));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 55, DateTimeKind.Utc).AddTicks(7697),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(9761));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNoteOnFormForArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 45, DateTimeKind.Utc).AddTicks(5099),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(9694));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 52, DateTimeKind.Utc).AddTicks(8067),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(5162));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 58, DateTimeKind.Utc).AddTicks(5238),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 715, DateTimeKind.Utc).AddTicks(1487));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 58, DateTimeKind.Utc).AddTicks(4449),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 715, DateTimeKind.Utc).AddTicks(201));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 58, DateTimeKind.Utc).AddTicks(3651),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 714, DateTimeKind.Utc).AddTicks(9034));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermsAndConditions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 58, DateTimeKind.Utc).AddTicks(2027),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 714, DateTimeKind.Utc).AddTicks(6412));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermAndConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 58, DateTimeKind.Utc).AddTicks(2831),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 714, DateTimeKind.Utc).AddTicks(7715));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Templates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 58, DateTimeKind.Utc).AddTicks(1255),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 714, DateTimeKind.Utc).AddTicks(5524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SwitchArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 45, DateTimeKind.Utc).AddTicks(4225),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(8803));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubcommitteeCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(943),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(5332));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 54, DateTimeKind.Utc).AddTicks(4619),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(3412));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StrategicPartners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(9662),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 714, DateTimeKind.Utc).AddTicks(4036));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(8902),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 714, DateTimeKind.Utc).AddTicks(3269));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(4135),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(6631));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SocialMedias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(8187),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 714, DateTimeKind.Utc).AddTicks(2641));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SavedCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(7361),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 714, DateTimeKind.Utc).AddTicks(1929));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 52, DateTimeKind.Utc).AddTicks(3649),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(2941));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RolePermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 52, DateTimeKind.Utc).AddTicks(4982),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(3634));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RoleMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(6443),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 714, DateTimeKind.Utc).AddTicks(1129));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rewards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(5591),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 714, DateTimeKind.Utc).AddTicks(276));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ResponsibilitiesUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(4735),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(9511));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Responsibilities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(3882),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(8768));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RequestForChangeInterviewEligibilityStatuses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(458),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(5841));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(2125),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(7249));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccountRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(3022),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(7992));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ReferenceSources",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(1302),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(6528));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 56, DateTimeKind.Utc).AddTicks(9136),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(4924));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Personalnvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 54, DateTimeKind.Utc).AddTicks(3115),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(2692));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Permissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 52, DateTimeKind.Utc).AddTicks(1926),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(1619));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PermissionHeaders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 52, DateTimeKind.Utc).AddTicks(2742),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(2311));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 56, DateTimeKind.Utc).AddTicks(2025),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(1849));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructureImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 56, DateTimeKind.Utc).AddTicks(6582),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(4038));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 56, DateTimeKind.Utc).AddTicks(5060),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(3311));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OurGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 43, DateTimeKind.Utc).AddTicks(3768),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 702, DateTimeKind.Utc).AddTicks(8723));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OnePageText",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 56, DateTimeKind.Utc).AddTicks(582),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(1136));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NotificationTemplates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 55, DateTimeKind.Utc).AddTicks(9227),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(501));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Notifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 55, DateTimeKind.Utc).AddTicks(6162),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(9012));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsTickers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 55, DateTimeKind.Utc).AddTicks(4843),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(8401));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 55, DateTimeKind.Utc).AddTicks(3431),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(7743));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 55, DateTimeKind.Utc).AddTicks(2031),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(7068));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(245),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 707, DateTimeKind.Utc).AddTicks(4846));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 55, DateTimeKind.Utc).AddTicks(595),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(6375));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Meetings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 54, DateTimeKind.Utc).AddTicks(9186),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(5675));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 54, DateTimeKind.Utc).AddTicks(7724),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(4970));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LogUserActions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 54, DateTimeKind.Utc).AddTicks(6134),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(4112));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 53, DateTimeKind.Utc).AddTicks(3807),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(8049));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 53, DateTimeKind.Utc).AddTicks(5216),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(8876));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeParticipants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 53, DateTimeKind.Utc).AddTicks(9986),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(1152));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeNoteAndQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 53, DateTimeKind.Utc).AddTicks(8376),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(320));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 53, DateTimeKind.Utc).AddTicks(6672),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(9617));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Instructions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 53, DateTimeKind.Utc).AddTicks(2542),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(7434));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 45, DateTimeKind.Utc).AddTicks(3317),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(7964));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 56, DateTimeKind.Utc).AddTicks(3509),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(2546));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HomePageSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 52, DateTimeKind.Utc).AddTicks(1151),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(921));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GroupInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 54, DateTimeKind.Utc).AddTicks(1594),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(1933));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 52, DateTimeKind.Utc).AddTicks(403),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(286));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 51, DateTimeKind.Utc).AddTicks(8731),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(8953));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 51, DateTimeKind.Utc).AddTicks(9522),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(9641));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Galleries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(8228),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(2849));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FrequentlyAskedQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 51, DateTimeKind.Utc).AddTicks(4148),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(5696));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 51, DateTimeKind.Utc).AddTicks(7749),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(8168));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 51, DateTimeKind.Utc).AddTicks(6695),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(7299));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 51, DateTimeKind.Utc).AddTicks(3338),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(4961));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 51, DateTimeKind.Utc).AddTicks(1430),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(3349));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 51, DateTimeKind.Utc).AddTicks(2361),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(4102));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 51, DateTimeKind.Utc).AddTicks(670),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(2629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryGuides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(9907),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(1984));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(9132),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(1297));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EntitiesCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(5996),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(8403));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(9397),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 707, DateTimeKind.Utc).AddTicks(4020));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(8498),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 707, DateTimeKind.Utc).AddTicks(2758));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalInstitutions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(8353),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(561));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(7557),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(9832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(6794),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(9143));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(2383),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(5056));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeTableValue",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(1557),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(4230));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(715),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(3269));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(7463),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(113));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(9866),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(2485));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(9099),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(1739));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(8305),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(970));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(3229),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(5838));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DigitalSignatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(1185),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(4643));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(6512),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(9282));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(5511),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(8412));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Dependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(4354),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(7371));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cycles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(392),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(3885));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(9557),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(3146));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(8720),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(2363));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 58, DateTimeKind.Utc).AddTicks(495),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 714, DateTimeKind.Utc).AddTicks(4846));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleCondition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(7893),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(1622));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Criterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(5312),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 707, DateTimeKind.Utc).AddTicks(9398));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(2722),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 707, DateTimeKind.Utc).AddTicks(6961));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(4450),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 707, DateTimeKind.Utc).AddTicks(8630));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(3602),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 707, DateTimeKind.Utc).AddTicks(7852));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(7045),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(903));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(6191),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(168));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Coordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(1889),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 707, DateTimeKind.Utc).AddTicks(6296));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CoordinatorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(1077),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 707, DateTimeKind.Utc).AddTicks(5586));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(7647),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 707, DateTimeKind.Utc).AddTicks(1470));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(1764),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(6130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Committees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(6785),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 707, DateTimeKind.Utc).AddTicks(313));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(5061),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(8541));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteeOfficers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(5938),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(9344));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Circulars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(834),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(4500));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(4179),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(7729));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularChairmans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(3310),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(6816));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(2484),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(5987));

            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "CircularAttachments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(1641),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(5226));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatBotQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(9210),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(3063));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnInitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 45, DateTimeKind.Utc).AddTicks(2464),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(7074));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnFinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 51, DateTimeKind.Utc).AddTicks(5267),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(6455));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 45, DateTimeKind.Utc).AddTicks(1635),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(6273));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(7540),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(1579));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryEducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(6655),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(781));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryCommittees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(5756),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(9919));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoriesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(4854),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(9031));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(8384),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(2338));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardStatistics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(3973),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(8269));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardSponsors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(3212),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(7576));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardPublications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(2506),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(6840));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeTableNames",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(3439),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(6594));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeOperations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(2724),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(5954));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeDataTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(1974),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(5321));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(174),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(4587));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 45, DateTimeKind.Utc).AddTicks(9432),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(3892));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 45, DateTimeKind.Utc).AddTicks(8604),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(3072));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScalesCriterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 45, DateTimeKind.Utc).AddTicks(7723),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(2248));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 45, DateTimeKind.Utc).AddTicks(6843),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(1364));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(9789),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(4449));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationResults",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 45, DateTimeKind.Utc).AddTicks(5995),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(574));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 45, DateTimeKind.Utc).AddTicks(759),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(5365));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AppVersions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(8958),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(3531));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Albums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(7508),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(2134));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Agendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(6757),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(1410));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(5087),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(9754));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(4163),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(8875));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderTableValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(3284),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(7957));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(2469),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(7166));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 43, DateTimeKind.Utc).AddTicks(5628),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(563));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(1670),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(6437));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(933),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(5721));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(196),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(5018));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 43, DateTimeKind.Utc).AddTicks(9384),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(4139));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 43, DateTimeKind.Utc).AddTicks(8469),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(3276));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 43, DateTimeKind.Utc).AddTicks(7695),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(2515));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 43, DateTimeKind.Utc).AddTicks(6658),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(1567));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Achievements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 43, DateTimeKind.Utc).AddTicks(4720),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 702, DateTimeKind.Utc).AddTicks(9684));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutAwardPage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 43, DateTimeKind.Utc).AddTicks(2490),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 702, DateTimeKind.Utc).AddTicks(7847));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileName",
                table: "CircularAttachments");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WorkflowQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(3764),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(27));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 715, DateTimeKind.Utc).AddTicks(2982),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 58, DateTimeKind.Utc).AddTicks(6153));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponseAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 715, DateTimeKind.Utc).AddTicks(4301),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 58, DateTimeKind.Utc).AddTicks(6988));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VirtualTableForSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(675),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(6006));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(7513),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(5066));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserTokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(6744),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 53, DateTimeKind.Utc).AddTicks(1161));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UsersRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(5966),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 52, DateTimeKind.Utc).AddTicks(9648));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(4430),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 52, DateTimeKind.Utc).AddTicks(6534));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(9761),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 55, DateTimeKind.Utc).AddTicks(7697));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNoteOnFormForArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(9694),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 45, DateTimeKind.Utc).AddTicks(5099));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(5162),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 52, DateTimeKind.Utc).AddTicks(8067));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 715, DateTimeKind.Utc).AddTicks(1487),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 58, DateTimeKind.Utc).AddTicks(5238));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 715, DateTimeKind.Utc).AddTicks(201),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 58, DateTimeKind.Utc).AddTicks(4449));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 714, DateTimeKind.Utc).AddTicks(9034),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 58, DateTimeKind.Utc).AddTicks(3651));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermsAndConditions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 714, DateTimeKind.Utc).AddTicks(6412),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 58, DateTimeKind.Utc).AddTicks(2027));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermAndConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 714, DateTimeKind.Utc).AddTicks(7715),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 58, DateTimeKind.Utc).AddTicks(2831));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Templates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 714, DateTimeKind.Utc).AddTicks(5524),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 58, DateTimeKind.Utc).AddTicks(1255));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SwitchArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(8803),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 45, DateTimeKind.Utc).AddTicks(4225));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubcommitteeCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(5332),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(943));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(3412),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 54, DateTimeKind.Utc).AddTicks(4619));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StrategicPartners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 714, DateTimeKind.Utc).AddTicks(4036),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(9662));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 714, DateTimeKind.Utc).AddTicks(3269),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(8902));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(6631),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(4135));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SocialMedias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 714, DateTimeKind.Utc).AddTicks(2641),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(8187));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SavedCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 714, DateTimeKind.Utc).AddTicks(1929),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(7361));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(2941),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 52, DateTimeKind.Utc).AddTicks(3649));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RolePermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(3634),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 52, DateTimeKind.Utc).AddTicks(4982));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RoleMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 714, DateTimeKind.Utc).AddTicks(1129),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(6443));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rewards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 714, DateTimeKind.Utc).AddTicks(276),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(5591));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ResponsibilitiesUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(9511),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(4735));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Responsibilities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(8768),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(3882));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RequestForChangeInterviewEligibilityStatuses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(5841),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(458));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(7249),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(2125));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccountRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(7992),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(3022));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ReferenceSources",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(6528),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(1302));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(4924),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 56, DateTimeKind.Utc).AddTicks(9136));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Personalnvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(2692),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 54, DateTimeKind.Utc).AddTicks(3115));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Permissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(1619),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 52, DateTimeKind.Utc).AddTicks(1926));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PermissionHeaders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(2311),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 52, DateTimeKind.Utc).AddTicks(2742));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(1849),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 56, DateTimeKind.Utc).AddTicks(2025));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructureImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(4038),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 56, DateTimeKind.Utc).AddTicks(6582));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(3311),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 56, DateTimeKind.Utc).AddTicks(5060));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OurGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 702, DateTimeKind.Utc).AddTicks(8723),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 43, DateTimeKind.Utc).AddTicks(3768));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OnePageText",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(1136),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 56, DateTimeKind.Utc).AddTicks(582));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NotificationTemplates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(501),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 55, DateTimeKind.Utc).AddTicks(9227));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Notifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(9012),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 55, DateTimeKind.Utc).AddTicks(6162));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsTickers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(8401),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 55, DateTimeKind.Utc).AddTicks(4843));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(7743),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 55, DateTimeKind.Utc).AddTicks(3431));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(7068),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 55, DateTimeKind.Utc).AddTicks(2031));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 707, DateTimeKind.Utc).AddTicks(4846),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(245));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(6375),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 55, DateTimeKind.Utc).AddTicks(595));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Meetings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(5675),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 54, DateTimeKind.Utc).AddTicks(9186));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(4970),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 54, DateTimeKind.Utc).AddTicks(7724));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LogUserActions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(4112),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 54, DateTimeKind.Utc).AddTicks(6134));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(8049),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 53, DateTimeKind.Utc).AddTicks(3807));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(8876),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 53, DateTimeKind.Utc).AddTicks(5216));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeParticipants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(1152),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 53, DateTimeKind.Utc).AddTicks(9986));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeNoteAndQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(320),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 53, DateTimeKind.Utc).AddTicks(8376));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(9617),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 53, DateTimeKind.Utc).AddTicks(6672));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Instructions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(7434),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 53, DateTimeKind.Utc).AddTicks(2542));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(7964),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 45, DateTimeKind.Utc).AddTicks(3317));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(2546),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 56, DateTimeKind.Utc).AddTicks(3509));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HomePageSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(921),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 52, DateTimeKind.Utc).AddTicks(1151));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GroupInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(1933),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 54, DateTimeKind.Utc).AddTicks(1594));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(286),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 52, DateTimeKind.Utc).AddTicks(403));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(8953),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 51, DateTimeKind.Utc).AddTicks(8731));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(9641),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 51, DateTimeKind.Utc).AddTicks(9522));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Galleries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(2849),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(8228));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FrequentlyAskedQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(5696),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 51, DateTimeKind.Utc).AddTicks(4148));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(8168),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 51, DateTimeKind.Utc).AddTicks(7749));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(7299),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 51, DateTimeKind.Utc).AddTicks(6695));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(4961),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 51, DateTimeKind.Utc).AddTicks(3338));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(3349),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 51, DateTimeKind.Utc).AddTicks(1430));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(4102),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 51, DateTimeKind.Utc).AddTicks(2361));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(2629),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 51, DateTimeKind.Utc).AddTicks(670));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryGuides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(1984),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(9907));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(1297),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(9132));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EntitiesCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(8403),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(5996));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 707, DateTimeKind.Utc).AddTicks(4020),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(9397));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 707, DateTimeKind.Utc).AddTicks(2758),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(8498));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalInstitutions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(561),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(8353));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(9832),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(7557));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(9143),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(6794));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(5056),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(2383));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeTableValue",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(4230),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(1557));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(3269),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(715));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(113),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(7463));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(2485),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(9866));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(1739),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(9099));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(970),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(8305));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(5838),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(3229));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DigitalSignatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(4643),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(1185));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(9282),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(6512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(8412),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(5511));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Dependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(7371),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(4354));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cycles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(3885),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(392));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(3146),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(9557));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(2363),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(8720));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 714, DateTimeKind.Utc).AddTicks(4846),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 58, DateTimeKind.Utc).AddTicks(495));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleCondition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(1622),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(7893));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Criterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 707, DateTimeKind.Utc).AddTicks(9398),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(5312));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 707, DateTimeKind.Utc).AddTicks(6961),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(2722));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 707, DateTimeKind.Utc).AddTicks(8630),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(4450));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 707, DateTimeKind.Utc).AddTicks(7852),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(3602));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(903),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(7045));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(168),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(6191));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Coordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 707, DateTimeKind.Utc).AddTicks(6296),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(1889));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CoordinatorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 707, DateTimeKind.Utc).AddTicks(5586),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(1077));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 707, DateTimeKind.Utc).AddTicks(1470),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(7647));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(6130),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(1764));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Committees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 707, DateTimeKind.Utc).AddTicks(313),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(6785));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(8541),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(5061));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteeOfficers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(9344),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(5938));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Circulars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(4500),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(834));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(7729),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(4179));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularChairmans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(6816),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(3310));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(5987),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(2484));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(5226),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(1641));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatBotQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(3063),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(9210));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnInitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(7074),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 45, DateTimeKind.Utc).AddTicks(2464));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnFinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(6455),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 51, DateTimeKind.Utc).AddTicks(5267));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(6273),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 45, DateTimeKind.Utc).AddTicks(1635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(1579),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(7540));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryEducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(781),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(6655));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryCommittees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(9919),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(5756));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoriesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(9031),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(4854));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(2338),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(8384));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardStatistics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(8269),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(3973));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardSponsors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(7576),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(3212));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardPublications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(6840),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(2506));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeTableNames",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(6594),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(3439));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeOperations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(5954),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(2724));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeDataTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(5321),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(1974));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(4587),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(174));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(3892),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 45, DateTimeKind.Utc).AddTicks(9432));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(3072),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 45, DateTimeKind.Utc).AddTicks(8604));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScalesCriterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(2248),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 45, DateTimeKind.Utc).AddTicks(7723));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(1364),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 45, DateTimeKind.Utc).AddTicks(6843));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(4449),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(9789));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationResults",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(574),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 45, DateTimeKind.Utc).AddTicks(5995));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(5365),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 45, DateTimeKind.Utc).AddTicks(759));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AppVersions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(3531),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(8958));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Albums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(2134),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(7508));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Agendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(1410),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(6757));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(9754),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(5087));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(8875),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(4163));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderTableValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(7957),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(3284));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(7166),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(2469));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(563),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 43, DateTimeKind.Utc).AddTicks(5628));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(6437),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(1670));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(5721),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(933));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(5018),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(196));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(4139),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 43, DateTimeKind.Utc).AddTicks(9384));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(3276),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 43, DateTimeKind.Utc).AddTicks(8469));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(2515),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 43, DateTimeKind.Utc).AddTicks(7695));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(1567),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 43, DateTimeKind.Utc).AddTicks(6658));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Achievements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 702, DateTimeKind.Utc).AddTicks(9684),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 43, DateTimeKind.Utc).AddTicks(4720));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutAwardPage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 702, DateTimeKind.Utc).AddTicks(7847),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 43, DateTimeKind.Utc).AddTicks(2490));
        }
    }
}
