using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Api.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTable_VirtualTableForSections_AddNewColumn_isOpen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WorkflowQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(9568),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(27));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 992, DateTimeKind.Utc).AddTicks(4809),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 58, DateTimeKind.Utc).AddTicks(6153));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponseAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 992, DateTimeKind.Utc).AddTicks(5547),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 58, DateTimeKind.Utc).AddTicks(6988));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VirtualTableForSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(7535),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(6006));

            migrationBuilder.AddColumn<bool>(
                name: "isOpen",
                table: "VirtualTableForSections",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(9506),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(5066));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserTokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(795),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 53, DateTimeKind.Utc).AddTicks(1161));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UsersRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(9661),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 52, DateTimeKind.Utc).AddTicks(9648));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(7987),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 52, DateTimeKind.Utc).AddTicks(6534));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(4346),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 55, DateTimeKind.Utc).AddTicks(7697));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNoteOnFormForArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(5662),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 45, DateTimeKind.Utc).AddTicks(5099));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(8723),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 52, DateTimeKind.Utc).AddTicks(8067));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 992, DateTimeKind.Utc).AddTicks(3973),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 58, DateTimeKind.Utc).AddTicks(5238));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 992, DateTimeKind.Utc).AddTicks(3177),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 58, DateTimeKind.Utc).AddTicks(4449));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 992, DateTimeKind.Utc).AddTicks(2470),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 58, DateTimeKind.Utc).AddTicks(3651));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermsAndConditions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 992, DateTimeKind.Utc).AddTicks(987),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 58, DateTimeKind.Utc).AddTicks(2027));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermAndConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 992, DateTimeKind.Utc).AddTicks(1690),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 58, DateTimeKind.Utc).AddTicks(2831));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Templates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 992, DateTimeKind.Utc).AddTicks(284),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 58, DateTimeKind.Utc).AddTicks(1255));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SwitchArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(4896),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 45, DateTimeKind.Utc).AddTicks(4225));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubcommitteeCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(986),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(943));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(7749),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 54, DateTimeKind.Utc).AddTicks(4619));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StrategicPartners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(8841),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(9662));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(8137),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(8902));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(8710),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(4135));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SocialMedias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(7133),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(8187));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SavedCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(6438),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(7361));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(6529),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 52, DateTimeKind.Utc).AddTicks(3649));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RolePermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(7264),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 52, DateTimeKind.Utc).AddTicks(4982));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RoleMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(5646),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(6443));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rewards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(4882),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(5591));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ResponsibilitiesUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(4139),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(4735));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Responsibilities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(3403),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(3882));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RequestForChangeInterviewEligibilityStatuses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(432),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(458));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(1851),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(2125));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccountRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(2644),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(3022));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ReferenceSources",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(1153),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(1302));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(9573),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 56, DateTimeKind.Utc).AddTicks(9136));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Personalnvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(7032),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 54, DateTimeKind.Utc).AddTicks(3115));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Permissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(5212),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 52, DateTimeKind.Utc).AddTicks(1926));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PermissionHeaders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(5887),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 52, DateTimeKind.Utc).AddTicks(2742));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(6373),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 56, DateTimeKind.Utc).AddTicks(2025));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructureImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(8681),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 56, DateTimeKind.Utc).AddTicks(6582));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(7929),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 56, DateTimeKind.Utc).AddTicks(5060));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OurGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 980, DateTimeKind.Utc).AddTicks(6098),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 43, DateTimeKind.Utc).AddTicks(3768));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OnePageText",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(5707),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 56, DateTimeKind.Utc).AddTicks(582));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NotificationTemplates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(5061),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 55, DateTimeKind.Utc).AddTicks(9227));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Notifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(3623),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 55, DateTimeKind.Utc).AddTicks(6162));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsTickers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(2980),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 55, DateTimeKind.Utc).AddTicks(4843));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(2316),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 55, DateTimeKind.Utc).AddTicks(3431));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(1632),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 55, DateTimeKind.Utc).AddTicks(2031));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(8343),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(245));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(920),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 55, DateTimeKind.Utc).AddTicks(595));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Meetings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(229),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 54, DateTimeKind.Utc).AddTicks(9186));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(9482),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 54, DateTimeKind.Utc).AddTicks(7724));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LogUserActions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(8598),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 54, DateTimeKind.Utc).AddTicks(6134));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(2480),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 53, DateTimeKind.Utc).AddTicks(3807));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(3196),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 53, DateTimeKind.Utc).AddTicks(5216));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeParticipants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(5495),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 53, DateTimeKind.Utc).AddTicks(9986));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeNoteAndQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(4685),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 53, DateTimeKind.Utc).AddTicks(8376));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(3914),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 53, DateTimeKind.Utc).AddTicks(6672));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Instructions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(1788),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 53, DateTimeKind.Utc).AddTicks(2542));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(4112),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 45, DateTimeKind.Utc).AddTicks(3317));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(7142),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 56, DateTimeKind.Utc).AddTicks(3509));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HomePageSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(4508),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 52, DateTimeKind.Utc).AddTicks(1151));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GroupInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(6288),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 54, DateTimeKind.Utc).AddTicks(1594));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(3828),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 52, DateTimeKind.Utc).AddTicks(403));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(2507),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 51, DateTimeKind.Utc).AddTicks(8731));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(3186),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 51, DateTimeKind.Utc).AddTicks(9522));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Galleries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(9396),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(8228));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FrequentlyAskedQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(9216),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 51, DateTimeKind.Utc).AddTicks(4148));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(1726),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 51, DateTimeKind.Utc).AddTicks(7749));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(858),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 51, DateTimeKind.Utc).AddTicks(6695));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(8511),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 51, DateTimeKind.Utc).AddTicks(3338));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(7163),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 51, DateTimeKind.Utc).AddTicks(1430));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(7839),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 51, DateTimeKind.Utc).AddTicks(2361));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(6274),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 51, DateTimeKind.Utc).AddTicks(670));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryGuides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(4907),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(9907));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(3846),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(9132));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EntitiesCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(378),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(5996));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(7604),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(9397));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(6817),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(8498));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalInstitutions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(2592),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(8353));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(1817),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(7557));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(1080),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(6794));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(7247),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(2383));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeTableValue",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(6539),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(1557));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(5812),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(715));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(3082),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(7463));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(5126),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(9866));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(4431),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(9099));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(3770),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(8305));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(7973),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(3229));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DigitalSignatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(7711),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(1185));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(2258),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(6512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(1436),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(5511));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Dependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(448),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(4354));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cycles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(7029),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(392));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(6307),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(9557));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(5581),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(8720));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(9581),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 58, DateTimeKind.Utc).AddTicks(495));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleCondition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(4907),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(7893));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Criterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(2661),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(5312));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(425),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(2722));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(1928),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(4450));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(1175),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(3602));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(4163),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(7045));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(3422),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(6191));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Coordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(9747),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(1889));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CoordinatorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(9048),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(1077));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(6111),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(7647));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(1734),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(1764));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Committees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(5413),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(6785));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(3934),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(5061));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteeOfficers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(4676),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(5938));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Circulars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(281),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(834));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(3211),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(4179));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularChairmans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(2381),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(3310));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(1652),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(2484));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(951),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(1641));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatBotQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(8869),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(9210));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnInitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(3332),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 45, DateTimeKind.Utc).AddTicks(2464));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnFinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(9984),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 51, DateTimeKind.Utc).AddTicks(5267));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(2596),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 45, DateTimeKind.Utc).AddTicks(1635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(7357),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(7540));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryEducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(6600),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(6655));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryCommittees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(5753),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(5756));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoriesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(4954),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(4854));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(8167),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(8384));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardStatistics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(3831),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(3973));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardSponsors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(3062),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(3212));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardPublications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(2414),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(2506));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeTableNames",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(9631),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(3439));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeOperations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(9030),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(2724));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeDataTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(8413),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(1974));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(274),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(174));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(9590),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 45, DateTimeKind.Utc).AddTicks(9432));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(8815),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 45, DateTimeKind.Utc).AddTicks(8604));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScalesCriterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(8003),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 45, DateTimeKind.Utc).AddTicks(7723));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(7219),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 45, DateTimeKind.Utc).AddTicks(6843));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(944),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(9789));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationResults",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(6440),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 45, DateTimeKind.Utc).AddTicks(5995));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(1812),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 45, DateTimeKind.Utc).AddTicks(759));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AppVersions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(39),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(8958));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Albums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(8766),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(7508));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Agendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(8160),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(6757));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(6603),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(5087));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(5819),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(4163));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderTableValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(5026),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(3284));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(4290),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(2469));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 980, DateTimeKind.Utc).AddTicks(7774),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 43, DateTimeKind.Utc).AddTicks(5628));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(3584),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(1670));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(2874),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(933));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(2178),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(196));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(1440),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 43, DateTimeKind.Utc).AddTicks(9384));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(536),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 43, DateTimeKind.Utc).AddTicks(8469));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 980, DateTimeKind.Utc).AddTicks(9764),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 43, DateTimeKind.Utc).AddTicks(7695));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 980, DateTimeKind.Utc).AddTicks(8858),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 43, DateTimeKind.Utc).AddTicks(6658));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Achievements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 980, DateTimeKind.Utc).AddTicks(6897),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 43, DateTimeKind.Utc).AddTicks(4720));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutAwardPage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 980, DateTimeKind.Utc).AddTicks(5313),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 43, DateTimeKind.Utc).AddTicks(2490));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isOpen",
                table: "VirtualTableForSections");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WorkflowQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(27),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(9568));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 58, DateTimeKind.Utc).AddTicks(6153),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 992, DateTimeKind.Utc).AddTicks(4809));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponseAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 58, DateTimeKind.Utc).AddTicks(6988),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 992, DateTimeKind.Utc).AddTicks(5547));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VirtualTableForSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(6006),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(7535));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(5066),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(9506));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserTokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 53, DateTimeKind.Utc).AddTicks(1161),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(795));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UsersRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 52, DateTimeKind.Utc).AddTicks(9648),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(9661));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 52, DateTimeKind.Utc).AddTicks(6534),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(7987));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 55, DateTimeKind.Utc).AddTicks(7697),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(4346));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNoteOnFormForArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 45, DateTimeKind.Utc).AddTicks(5099),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(5662));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 52, DateTimeKind.Utc).AddTicks(8067),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(8723));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 58, DateTimeKind.Utc).AddTicks(5238),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 992, DateTimeKind.Utc).AddTicks(3973));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 58, DateTimeKind.Utc).AddTicks(4449),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 992, DateTimeKind.Utc).AddTicks(3177));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 58, DateTimeKind.Utc).AddTicks(3651),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 992, DateTimeKind.Utc).AddTicks(2470));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermsAndConditions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 58, DateTimeKind.Utc).AddTicks(2027),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 992, DateTimeKind.Utc).AddTicks(987));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermAndConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 58, DateTimeKind.Utc).AddTicks(2831),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 992, DateTimeKind.Utc).AddTicks(1690));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Templates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 58, DateTimeKind.Utc).AddTicks(1255),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 992, DateTimeKind.Utc).AddTicks(284));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SwitchArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 45, DateTimeKind.Utc).AddTicks(4225),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(4896));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubcommitteeCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(943),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(986));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 54, DateTimeKind.Utc).AddTicks(4619),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(7749));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StrategicPartners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(9662),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(8841));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(8902),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(8137));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(4135),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(8710));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SocialMedias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(8187),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(7133));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SavedCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(7361),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(6438));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 52, DateTimeKind.Utc).AddTicks(3649),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(6529));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RolePermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 52, DateTimeKind.Utc).AddTicks(4982),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(7264));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RoleMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(6443),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(5646));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rewards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(5591),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(4882));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ResponsibilitiesUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(4735),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(4139));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Responsibilities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(3882),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(3403));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RequestForChangeInterviewEligibilityStatuses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(458),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(432));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(2125),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(1851));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccountRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(3022),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(2644));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ReferenceSources",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 57, DateTimeKind.Utc).AddTicks(1302),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(1153));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 56, DateTimeKind.Utc).AddTicks(9136),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(9573));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Personalnvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 54, DateTimeKind.Utc).AddTicks(3115),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(7032));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Permissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 52, DateTimeKind.Utc).AddTicks(1926),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(5212));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PermissionHeaders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 52, DateTimeKind.Utc).AddTicks(2742),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(5887));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 56, DateTimeKind.Utc).AddTicks(2025),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(6373));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructureImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 56, DateTimeKind.Utc).AddTicks(6582),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(8681));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 56, DateTimeKind.Utc).AddTicks(5060),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(7929));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OurGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 43, DateTimeKind.Utc).AddTicks(3768),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 980, DateTimeKind.Utc).AddTicks(6098));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OnePageText",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 56, DateTimeKind.Utc).AddTicks(582),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(5707));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NotificationTemplates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 55, DateTimeKind.Utc).AddTicks(9227),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(5061));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Notifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 55, DateTimeKind.Utc).AddTicks(6162),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(3623));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsTickers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 55, DateTimeKind.Utc).AddTicks(4843),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(2980));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 55, DateTimeKind.Utc).AddTicks(3431),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(2316));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 55, DateTimeKind.Utc).AddTicks(2031),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(1632));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(245),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(8343));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 55, DateTimeKind.Utc).AddTicks(595),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(920));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Meetings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 54, DateTimeKind.Utc).AddTicks(9186),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(229));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 54, DateTimeKind.Utc).AddTicks(7724),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(9482));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LogUserActions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 54, DateTimeKind.Utc).AddTicks(6134),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(8598));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 53, DateTimeKind.Utc).AddTicks(3807),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(2480));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 53, DateTimeKind.Utc).AddTicks(5216),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(3196));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeParticipants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 53, DateTimeKind.Utc).AddTicks(9986),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(5495));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeNoteAndQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 53, DateTimeKind.Utc).AddTicks(8376),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(4685));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 53, DateTimeKind.Utc).AddTicks(6672),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(3914));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Instructions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 53, DateTimeKind.Utc).AddTicks(2542),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(1788));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 45, DateTimeKind.Utc).AddTicks(3317),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(4112));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 56, DateTimeKind.Utc).AddTicks(3509),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(7142));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HomePageSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 52, DateTimeKind.Utc).AddTicks(1151),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(4508));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GroupInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 54, DateTimeKind.Utc).AddTicks(1594),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(6288));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 52, DateTimeKind.Utc).AddTicks(403),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(3828));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 51, DateTimeKind.Utc).AddTicks(8731),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(2507));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 51, DateTimeKind.Utc).AddTicks(9522),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(3186));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Galleries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(8228),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(9396));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FrequentlyAskedQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 51, DateTimeKind.Utc).AddTicks(4148),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(9216));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 51, DateTimeKind.Utc).AddTicks(7749),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(1726));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 51, DateTimeKind.Utc).AddTicks(6695),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(858));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 51, DateTimeKind.Utc).AddTicks(3338),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(8511));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 51, DateTimeKind.Utc).AddTicks(1430),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(7163));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 51, DateTimeKind.Utc).AddTicks(2361),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(7839));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 51, DateTimeKind.Utc).AddTicks(670),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(6274));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryGuides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(9907),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(4907));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(9132),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(3846));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EntitiesCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(5996),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(378));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(9397),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(7604));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(8498),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(6817));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalInstitutions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(8353),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(2592));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(7557),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(1817));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(6794),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(1080));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(2383),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(7247));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeTableValue",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(1557),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(6539));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(715),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(5812));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(7463),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(3082));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(9866),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(5126));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(9099),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(4431));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(8305),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(3770));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 50, DateTimeKind.Utc).AddTicks(3229),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(7973));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DigitalSignatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(1185),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(7711));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(6512),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(2258));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(5511),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(1436));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Dependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(4354),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(448));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cycles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(392),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(7029));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(9557),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(6307));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(8720),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(5581));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 58, DateTimeKind.Utc).AddTicks(495),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(9581));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleCondition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(7893),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(4907));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Criterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(5312),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(2661));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(2722),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(425));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(4450),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(1928));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(3602),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(1175));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(7045),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(4163));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(6191),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(3422));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Coordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(1889),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(9747));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CoordinatorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 48, DateTimeKind.Utc).AddTicks(1077),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(9048));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(7647),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(6111));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(1764),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(1734));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Committees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(6785),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(5413));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(5061),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(3934));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteeOfficers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(5938),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(4676));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Circulars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(834),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(281));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(4179),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(3211));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularChairmans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(3310),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(2381));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(2484),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(1652));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 47, DateTimeKind.Utc).AddTicks(1641),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(951));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatBotQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(9210),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(8869));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnInitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 45, DateTimeKind.Utc).AddTicks(2464),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(3332));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnFinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 51, DateTimeKind.Utc).AddTicks(5267),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(9984));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 45, DateTimeKind.Utc).AddTicks(1635),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(2596));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(7540),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(7357));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryEducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(6655),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(6600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryCommittees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(5756),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(5753));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoriesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(4854),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(4954));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(8384),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(8167));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardStatistics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(3973),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(3831));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardSponsors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(3212),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(3062));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardPublications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(2506),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(2414));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeTableNames",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(3439),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(9631));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeOperations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(2724),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(9030));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeDataTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 49, DateTimeKind.Utc).AddTicks(1974),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(8413));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 46, DateTimeKind.Utc).AddTicks(174),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(274));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 45, DateTimeKind.Utc).AddTicks(9432),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 45, DateTimeKind.Utc).AddTicks(8604),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(8815));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScalesCriterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 45, DateTimeKind.Utc).AddTicks(7723),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(8003));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 45, DateTimeKind.Utc).AddTicks(6843),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(7219));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(9789),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(944));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationResults",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 45, DateTimeKind.Utc).AddTicks(5995),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(6440));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 45, DateTimeKind.Utc).AddTicks(759),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(1812));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AppVersions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(8958),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(39));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Albums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(7508),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(8766));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Agendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(6757),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(8160));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(5087),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(6603));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(4163),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(5819));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderTableValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(3284),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(5026));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(2469),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(4290));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 43, DateTimeKind.Utc).AddTicks(5628),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 980, DateTimeKind.Utc).AddTicks(7774));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(1670),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(3584));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(933),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(2874));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 44, DateTimeKind.Utc).AddTicks(196),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(2178));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 43, DateTimeKind.Utc).AddTicks(9384),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(1440));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 43, DateTimeKind.Utc).AddTicks(8469),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(536));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 43, DateTimeKind.Utc).AddTicks(7695),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 980, DateTimeKind.Utc).AddTicks(9764));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 43, DateTimeKind.Utc).AddTicks(6658),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 980, DateTimeKind.Utc).AddTicks(8858));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Achievements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 43, DateTimeKind.Utc).AddTicks(4720),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 980, DateTimeKind.Utc).AddTicks(6897));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutAwardPage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 9, 30, 50, 43, DateTimeKind.Utc).AddTicks(2490),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 980, DateTimeKind.Utc).AddTicks(5313));
        }
    }
}
