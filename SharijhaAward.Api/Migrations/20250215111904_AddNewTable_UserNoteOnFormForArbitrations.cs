using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddNewTable_UserNoteOnFormForArbitrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WorkflowQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(5780),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 718, DateTimeKind.Utc).AddTicks(3405));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(8172),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 726, DateTimeKind.Utc).AddTicks(1152));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponseAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(8739),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 726, DateTimeKind.Utc).AddTicks(1809));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VirtualTableForSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(9273),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 715, DateTimeKind.Utc).AddTicks(7852));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(8979),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 721, DateTimeKind.Utc).AddTicks(4593));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserTokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(3112),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 723, DateTimeKind.Utc).AddTicks(4392));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UsersRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(2555),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 723, DateTimeKind.Utc).AddTicks(3776));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(1439),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 723, DateTimeKind.Utc).AddTicks(2523));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(3103),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 724, DateTimeKind.Utc).AddTicks(5072));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(1980),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 723, DateTimeKind.Utc).AddTicks(3130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(7588),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 726, DateTimeKind.Utc).AddTicks(505));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(7008),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 725, DateTimeKind.Utc).AddTicks(9886));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(6351),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 725, DateTimeKind.Utc).AddTicks(9296));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermsAndConditions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(5044),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 725, DateTimeKind.Utc).AddTicks(8096));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermAndConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(5765),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 725, DateTimeKind.Utc).AddTicks(8687));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Templates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(4503),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 725, DateTimeKind.Utc).AddTicks(7488));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SwitchArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(5043),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 717, DateTimeKind.Utc).AddTicks(464));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubcommitteeCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(9675),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 717, DateTimeKind.Utc).AddTicks(5342));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(8083),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 723, DateTimeKind.Utc).AddTicks(9846));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StrategicPartners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(3424),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 725, DateTimeKind.Utc).AddTicks(6280));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(2900),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 725, DateTimeKind.Utc).AddTicks(5702));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(8368),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 721, DateTimeKind.Utc).AddTicks(3863));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SocialMedias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(2407),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 725, DateTimeKind.Utc).AddTicks(5150));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SavedCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(1858),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 725, DateTimeKind.Utc).AddTicks(4538));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(336),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 723, DateTimeKind.Utc).AddTicks(1279));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RolePermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(904),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 723, DateTimeKind.Utc).AddTicks(1910));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RoleMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(1234),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 725, DateTimeKind.Utc).AddTicks(3828));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rewards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(641),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 725, DateTimeKind.Utc).AddTicks(3196));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ResponsibilitiesUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(9902),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 725, DateTimeKind.Utc).AddTicks(2496));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Responsibilities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(9336),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 725, DateTimeKind.Utc).AddTicks(1879));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(8091),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 725, DateTimeKind.Utc).AddTicks(611));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccountRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(8665),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 725, DateTimeKind.Utc).AddTicks(1252));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ReferenceSources",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(7554),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 725, DateTimeKind.Utc).AddTicks(26));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(6969),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 724, DateTimeKind.Utc).AddTicks(9412));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Personalnvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(7518),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 723, DateTimeKind.Utc).AddTicks(9238));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Permissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(9347),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 723, DateTimeKind.Utc).AddTicks(99));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PermissionHeaders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(9858),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 723, DateTimeKind.Utc).AddTicks(766));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(4663),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 724, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructureImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(6350),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 724, DateTimeKind.Utc).AddTicks(8718));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(5789),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 724, DateTimeKind.Utc).AddTicks(8062));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OurGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(883),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 714, DateTimeKind.Utc).AddTicks(5109));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OnePageText",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(4139),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 724, DateTimeKind.Utc).AddTicks(6304));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NotificationTemplates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(3652),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 724, DateTimeKind.Utc).AddTicks(5773));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Notifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(2565),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 724, DateTimeKind.Utc).AddTicks(4478));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsTickers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(2080),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 724, DateTimeKind.Utc).AddTicks(3904));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(1568),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 724, DateTimeKind.Utc).AddTicks(3342));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(1041),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 724, DateTimeKind.Utc).AddTicks(2791));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(2574),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 719, DateTimeKind.Utc).AddTicks(4058));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(524),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 724, DateTimeKind.Utc).AddTicks(2174));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Meetings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(9996),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 724, DateTimeKind.Utc).AddTicks(1612));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(9381),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 724, DateTimeKind.Utc).AddTicks(1038));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LogUserActions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(8733),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 724, DateTimeKind.Utc).AddTicks(441));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(4127),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 723, DateTimeKind.Utc).AddTicks(5555));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(4667),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 723, DateTimeKind.Utc).AddTicks(6147));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeParticipants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(6370),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 723, DateTimeKind.Utc).AddTicks(7959));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeNoteAndQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(5756),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 723, DateTimeKind.Utc).AddTicks(7313));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(5207),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 723, DateTimeKind.Utc).AddTicks(6726));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Instructions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(3632),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 723, DateTimeKind.Utc).AddTicks(5006));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(4421),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 716, DateTimeKind.Utc).AddTicks(9656));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(5211),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 724, DateTimeKind.Utc).AddTicks(7462));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HomePageSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(8826),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 722, DateTimeKind.Utc).AddTicks(9507));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GroupInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(6959),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 723, DateTimeKind.Utc).AddTicks(8622));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(8322),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 722, DateTimeKind.Utc).AddTicks(8954));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(7306),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 722, DateTimeKind.Utc).AddTicks(7736));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(7828),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 722, DateTimeKind.Utc).AddTicks(8356));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Galleries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(857),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 716, DateTimeKind.Utc).AddTicks(1274));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FrequentlyAskedQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(4913),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 722, DateTimeKind.Utc).AddTicks(3242));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(6711),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 722, DateTimeKind.Utc).AddTicks(6935));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(6073),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 722, DateTimeKind.Utc).AddTicks(5658));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(4375),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 722, DateTimeKind.Utc).AddTicks(2184));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(3285),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 722, DateTimeKind.Utc).AddTicks(119));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(3830),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 722, DateTimeKind.Utc).AddTicks(1128));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(2758),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 721, DateTimeKind.Utc).AddTicks(9093));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryGuides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(2227),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 721, DateTimeKind.Utc).AddTicks(8368));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(1698),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 721, DateTimeKind.Utc).AddTicks(7725));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EntitiesCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(9604),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 721, DateTimeKind.Utc).AddTicks(5328));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(2002),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 719, DateTimeKind.Utc).AddTicks(3074));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(1408),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 719, DateTimeKind.Utc).AddTicks(2340));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalInstitutions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(1169),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 721, DateTimeKind.Utc).AddTicks(7100));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(650),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 721, DateTimeKind.Utc).AddTicks(6505));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(172),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 721, DateTimeKind.Utc).AddTicks(5953));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(7172),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 721, DateTimeKind.Utc).AddTicks(2403));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeTableValue",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(6629),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 721, DateTimeKind.Utc).AddTicks(1714));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(6083),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 721, DateTimeKind.Utc).AddTicks(1089));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(3919),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 720, DateTimeKind.Utc).AddTicks(8452));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(5525),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 721, DateTimeKind.Utc).AddTicks(331));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(5001),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 720, DateTimeKind.Utc).AddTicks(9692));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(4479),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 720, DateTimeKind.Utc).AddTicks(9104));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(7734),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 721, DateTimeKind.Utc).AddTicks(3166));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DigitalSignatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(9840),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 720, DateTimeKind.Utc).AddTicks(2959));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(3305),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 720, DateTimeKind.Utc).AddTicks(7750));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(2671),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 720, DateTimeKind.Utc).AddTicks(6895));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Dependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(1932),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 720, DateTimeKind.Utc).AddTicks(5920));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cycles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(9307),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 720, DateTimeKind.Utc).AddTicks(2308));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(8765),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 720, DateTimeKind.Utc).AddTicks(1629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(8202),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 720, DateTimeKind.Utc).AddTicks(992));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(3983),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 725, DateTimeKind.Utc).AddTicks(6901));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleCondition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(7663),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 720, DateTimeKind.Utc).AddTicks(226));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Criterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(5948),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 719, DateTimeKind.Utc).AddTicks(8271));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(4187),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 719, DateTimeKind.Utc).AddTicks(6048));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(5371),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 719, DateTimeKind.Utc).AddTicks(7426));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(4761),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 719, DateTimeKind.Utc).AddTicks(6725));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(7116),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 719, DateTimeKind.Utc).AddTicks(9594));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(6542),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 719, DateTimeKind.Utc).AddTicks(8951));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Coordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(3655),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 719, DateTimeKind.Utc).AddTicks(5422));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CoordinatorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(3120),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 719, DateTimeKind.Utc).AddTicks(4767));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(850),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 719, DateTimeKind.Utc).AddTicks(1630));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(261),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 717, DateTimeKind.Utc).AddTicks(6052));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Committees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(269),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 719, DateTimeKind.Utc).AddTicks(760));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(9134),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 718, DateTimeKind.Utc).AddTicks(8978));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteeOfficers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(9711),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 718, DateTimeKind.Utc).AddTicks(9787));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Circulars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(6314),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 718, DateTimeKind.Utc).AddTicks(4349));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(8553),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 718, DateTimeKind.Utc).AddTicks(8276));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularChairmans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(7962),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 718, DateTimeKind.Utc).AddTicks(7564));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(7402),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 718, DateTimeKind.Utc).AddTicks(6486));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(6850),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 718, DateTimeKind.Utc).AddTicks(5384));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatBotQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(5242),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 718, DateTimeKind.Utc).AddTicks(2728));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnInitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(3817),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 716, DateTimeKind.Utc).AddTicks(8927));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnFinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(5475),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 722, DateTimeKind.Utc).AddTicks(4368));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(3230),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 716, DateTimeKind.Utc).AddTicks(8224));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(4124),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 718, DateTimeKind.Utc).AddTicks(1417));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryEducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(3568),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 718, DateTimeKind.Utc).AddTicks(768));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryCommittees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(2982),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 717, DateTimeKind.Utc).AddTicks(9900));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoriesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(2384),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 717, DateTimeKind.Utc).AddTicks(9077));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(4680),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 718, DateTimeKind.Utc).AddTicks(2080));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardStatistics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(1821),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 717, DateTimeKind.Utc).AddTicks(8264));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardSponsors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(1300),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 717, DateTimeKind.Utc).AddTicks(7507));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardPublications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(812),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 717, DateTimeKind.Utc).AddTicks(6789));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeTableNames",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(1310),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 720, DateTimeKind.Utc).AddTicks(4800));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeOperations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(841),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 720, DateTimeKind.Utc).AddTicks(4211));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeDataTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(364),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 720, DateTimeKind.Utc).AddTicks(3573));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(9134),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 717, DateTimeKind.Utc).AddTicks(4677));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(8580),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 717, DateTimeKind.Utc).AddTicks(4014));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(8006),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 717, DateTimeKind.Utc).AddTicks(3334));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScalesCriterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(7405),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 717, DateTimeKind.Utc).AddTicks(2575));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(6803),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 717, DateTimeKind.Utc).AddTicks(1887));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(1948),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 716, DateTimeKind.Utc).AddTicks(4923));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationResults",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(6247),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 717, DateTimeKind.Utc).AddTicks(1224));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(2618),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 716, DateTimeKind.Utc).AddTicks(7452));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AppVersions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(1362),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 716, DateTimeKind.Utc).AddTicks(2184));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Albums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(313),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 715, DateTimeKind.Utc).AddTicks(9311));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Agendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(9815),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 715, DateTimeKind.Utc).AddTicks(8672));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(8593),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 715, DateTimeKind.Utc).AddTicks(6985));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(7986),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 715, DateTimeKind.Utc).AddTicks(6194));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderTableValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(7426),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 715, DateTimeKind.Utc).AddTicks(5342));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(6871),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 715, DateTimeKind.Utc).AddTicks(4517));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(2112),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 714, DateTimeKind.Utc).AddTicks(6632));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(6327),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 715, DateTimeKind.Utc).AddTicks(2022));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(5815),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 715, DateTimeKind.Utc).AddTicks(1379));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(5307),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 715, DateTimeKind.Utc).AddTicks(740));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(4746),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 715, DateTimeKind.Utc).AddTicks(34));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(4073),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 714, DateTimeKind.Utc).AddTicks(9187));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(3526),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 714, DateTimeKind.Utc).AddTicks(8435));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(2834),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 714, DateTimeKind.Utc).AddTicks(7567));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Achievements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(1478),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 714, DateTimeKind.Utc).AddTicks(5866));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutAwardPage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(237),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 714, DateTimeKind.Utc).AddTicks(4291));

            migrationBuilder.CreateTable(
                name: "UserNoteOnFormForArbitrations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChairmanId = table.Column<int>(type: "int", nullable: false),
                    ProvidedFormId = table.Column<int>(type: "int", nullable: false),
                    ArbitrationStep = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(5647)),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserNoteOnFormForArbitrations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserNoteOnFormForArbitrations_ProvidedForms_ProvidedFormId",
                        column: x => x.ProvidedFormId,
                        principalTable: "ProvidedForms",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserNoteOnFormForArbitrations_Users_ChairmanId",
                        column: x => x.ChairmanId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserNoteOnFormForArbitrations_ChairmanId",
                table: "UserNoteOnFormForArbitrations",
                column: "ChairmanId");

            migrationBuilder.CreateIndex(
                name: "IX_UserNoteOnFormForArbitrations_ProvidedFormId",
                table: "UserNoteOnFormForArbitrations",
                column: "ProvidedFormId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserNoteOnFormForArbitrations");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WorkflowQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 718, DateTimeKind.Utc).AddTicks(3405),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(5780));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 726, DateTimeKind.Utc).AddTicks(1152),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(8172));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponseAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 726, DateTimeKind.Utc).AddTicks(1809),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(8739));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VirtualTableForSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 715, DateTimeKind.Utc).AddTicks(7852),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(9273));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 721, DateTimeKind.Utc).AddTicks(4593),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(8979));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserTokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 723, DateTimeKind.Utc).AddTicks(4392),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(3112));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UsersRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 723, DateTimeKind.Utc).AddTicks(3776),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(2555));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 723, DateTimeKind.Utc).AddTicks(2523),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(1439));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 724, DateTimeKind.Utc).AddTicks(5072),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(3103));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 723, DateTimeKind.Utc).AddTicks(3130),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(1980));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 726, DateTimeKind.Utc).AddTicks(505),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(7588));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 725, DateTimeKind.Utc).AddTicks(9886),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(7008));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 725, DateTimeKind.Utc).AddTicks(9296),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(6351));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermsAndConditions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 725, DateTimeKind.Utc).AddTicks(8096),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(5044));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermAndConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 725, DateTimeKind.Utc).AddTicks(8687),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(5765));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Templates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 725, DateTimeKind.Utc).AddTicks(7488),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(4503));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SwitchArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 717, DateTimeKind.Utc).AddTicks(464),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(5043));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubcommitteeCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 717, DateTimeKind.Utc).AddTicks(5342),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(9675));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 723, DateTimeKind.Utc).AddTicks(9846),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(8083));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StrategicPartners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 725, DateTimeKind.Utc).AddTicks(6280),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(3424));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 725, DateTimeKind.Utc).AddTicks(5702),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(2900));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 721, DateTimeKind.Utc).AddTicks(3863),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(8368));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SocialMedias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 725, DateTimeKind.Utc).AddTicks(5150),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(2407));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SavedCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 725, DateTimeKind.Utc).AddTicks(4538),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(1858));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 723, DateTimeKind.Utc).AddTicks(1279),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(336));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RolePermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 723, DateTimeKind.Utc).AddTicks(1910),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(904));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RoleMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 725, DateTimeKind.Utc).AddTicks(3828),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(1234));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rewards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 725, DateTimeKind.Utc).AddTicks(3196),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(641));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ResponsibilitiesUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 725, DateTimeKind.Utc).AddTicks(2496),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(9902));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Responsibilities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 725, DateTimeKind.Utc).AddTicks(1879),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(9336));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 725, DateTimeKind.Utc).AddTicks(611),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(8091));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccountRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 725, DateTimeKind.Utc).AddTicks(1252),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(8665));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ReferenceSources",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 725, DateTimeKind.Utc).AddTicks(26),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(7554));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 724, DateTimeKind.Utc).AddTicks(9412),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(6969));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Personalnvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 723, DateTimeKind.Utc).AddTicks(9238),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(7518));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Permissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 723, DateTimeKind.Utc).AddTicks(99),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(9347));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PermissionHeaders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 723, DateTimeKind.Utc).AddTicks(766),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(9858));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 724, DateTimeKind.Utc).AddTicks(6870),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(4663));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructureImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 724, DateTimeKind.Utc).AddTicks(8718),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(6350));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 724, DateTimeKind.Utc).AddTicks(8062),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(5789));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OurGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 714, DateTimeKind.Utc).AddTicks(5109),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(883));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OnePageText",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 724, DateTimeKind.Utc).AddTicks(6304),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(4139));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NotificationTemplates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 724, DateTimeKind.Utc).AddTicks(5773),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(3652));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Notifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 724, DateTimeKind.Utc).AddTicks(4478),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(2565));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsTickers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 724, DateTimeKind.Utc).AddTicks(3904),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(2080));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 724, DateTimeKind.Utc).AddTicks(3342),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(1568));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 724, DateTimeKind.Utc).AddTicks(2791),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(1041));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 719, DateTimeKind.Utc).AddTicks(4058),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(2574));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 724, DateTimeKind.Utc).AddTicks(2174),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Meetings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 724, DateTimeKind.Utc).AddTicks(1612),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(9996));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 724, DateTimeKind.Utc).AddTicks(1038),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(9381));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LogUserActions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 724, DateTimeKind.Utc).AddTicks(441),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(8733));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 723, DateTimeKind.Utc).AddTicks(5555),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(4127));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 723, DateTimeKind.Utc).AddTicks(6147),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(4667));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeParticipants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 723, DateTimeKind.Utc).AddTicks(7959),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(6370));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeNoteAndQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 723, DateTimeKind.Utc).AddTicks(7313),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(5756));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 723, DateTimeKind.Utc).AddTicks(6726),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(5207));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Instructions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 723, DateTimeKind.Utc).AddTicks(5006),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(3632));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 716, DateTimeKind.Utc).AddTicks(9656),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(4421));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 724, DateTimeKind.Utc).AddTicks(7462),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(5211));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HomePageSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 722, DateTimeKind.Utc).AddTicks(9507),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(8826));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GroupInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 723, DateTimeKind.Utc).AddTicks(8622),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(6959));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 722, DateTimeKind.Utc).AddTicks(8954),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(8322));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 722, DateTimeKind.Utc).AddTicks(7736),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(7306));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 722, DateTimeKind.Utc).AddTicks(8356),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(7828));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Galleries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 716, DateTimeKind.Utc).AddTicks(1274),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(857));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FrequentlyAskedQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 722, DateTimeKind.Utc).AddTicks(3242),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(4913));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 722, DateTimeKind.Utc).AddTicks(6935),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(6711));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 722, DateTimeKind.Utc).AddTicks(5658),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(6073));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 722, DateTimeKind.Utc).AddTicks(2184),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(4375));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 722, DateTimeKind.Utc).AddTicks(119),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(3285));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 722, DateTimeKind.Utc).AddTicks(1128),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(3830));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 721, DateTimeKind.Utc).AddTicks(9093),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(2758));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryGuides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 721, DateTimeKind.Utc).AddTicks(8368),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(2227));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 721, DateTimeKind.Utc).AddTicks(7725),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(1698));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EntitiesCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 721, DateTimeKind.Utc).AddTicks(5328),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(9604));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 719, DateTimeKind.Utc).AddTicks(3074),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(2002));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 719, DateTimeKind.Utc).AddTicks(2340),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(1408));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalInstitutions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 721, DateTimeKind.Utc).AddTicks(7100),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(1169));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 721, DateTimeKind.Utc).AddTicks(6505),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(650));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 721, DateTimeKind.Utc).AddTicks(5953),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(172));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 721, DateTimeKind.Utc).AddTicks(2403),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(7172));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeTableValue",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 721, DateTimeKind.Utc).AddTicks(1714),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(6629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 721, DateTimeKind.Utc).AddTicks(1089),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(6083));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 720, DateTimeKind.Utc).AddTicks(8452),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(3919));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 721, DateTimeKind.Utc).AddTicks(331),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(5525));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 720, DateTimeKind.Utc).AddTicks(9692),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(5001));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 720, DateTimeKind.Utc).AddTicks(9104),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(4479));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 721, DateTimeKind.Utc).AddTicks(3166),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(7734));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DigitalSignatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 720, DateTimeKind.Utc).AddTicks(2959),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(9840));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 720, DateTimeKind.Utc).AddTicks(7750),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(3305));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 720, DateTimeKind.Utc).AddTicks(6895),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(2671));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Dependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 720, DateTimeKind.Utc).AddTicks(5920),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(1932));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cycles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 720, DateTimeKind.Utc).AddTicks(2308),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(9307));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 720, DateTimeKind.Utc).AddTicks(1629),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(8765));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 720, DateTimeKind.Utc).AddTicks(992),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(8202));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 725, DateTimeKind.Utc).AddTicks(6901),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(3983));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleCondition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 720, DateTimeKind.Utc).AddTicks(226),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(7663));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Criterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 719, DateTimeKind.Utc).AddTicks(8271),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(5948));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 719, DateTimeKind.Utc).AddTicks(6048),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(4187));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 719, DateTimeKind.Utc).AddTicks(7426),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(5371));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 719, DateTimeKind.Utc).AddTicks(6725),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(4761));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 719, DateTimeKind.Utc).AddTicks(9594),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(7116));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 719, DateTimeKind.Utc).AddTicks(8951),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(6542));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Coordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 719, DateTimeKind.Utc).AddTicks(5422),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(3655));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CoordinatorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 719, DateTimeKind.Utc).AddTicks(4767),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 719, DateTimeKind.Utc).AddTicks(1630),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(850));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 717, DateTimeKind.Utc).AddTicks(6052),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(261));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Committees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 719, DateTimeKind.Utc).AddTicks(760),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(269));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 718, DateTimeKind.Utc).AddTicks(8978),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(9134));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteeOfficers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 718, DateTimeKind.Utc).AddTicks(9787),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(9711));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Circulars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 718, DateTimeKind.Utc).AddTicks(4349),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(6314));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 718, DateTimeKind.Utc).AddTicks(8276),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(8553));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularChairmans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 718, DateTimeKind.Utc).AddTicks(7564),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(7962));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 718, DateTimeKind.Utc).AddTicks(6486),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(7402));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 718, DateTimeKind.Utc).AddTicks(5384),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(6850));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatBotQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 718, DateTimeKind.Utc).AddTicks(2728),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(5242));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnInitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 716, DateTimeKind.Utc).AddTicks(8927),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(3817));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnFinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 722, DateTimeKind.Utc).AddTicks(4368),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(5475));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 716, DateTimeKind.Utc).AddTicks(8224),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(3230));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 718, DateTimeKind.Utc).AddTicks(1417),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(4124));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryEducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 718, DateTimeKind.Utc).AddTicks(768),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(3568));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryCommittees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 717, DateTimeKind.Utc).AddTicks(9900),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(2982));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoriesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 717, DateTimeKind.Utc).AddTicks(9077),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(2384));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 718, DateTimeKind.Utc).AddTicks(2080),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(4680));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardStatistics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 717, DateTimeKind.Utc).AddTicks(8264),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(1821));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardSponsors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 717, DateTimeKind.Utc).AddTicks(7507),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(1300));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardPublications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 717, DateTimeKind.Utc).AddTicks(6789),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(812));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeTableNames",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 720, DateTimeKind.Utc).AddTicks(4800),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(1310));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeOperations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 720, DateTimeKind.Utc).AddTicks(4211),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(841));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeDataTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 720, DateTimeKind.Utc).AddTicks(3573),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(364));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 717, DateTimeKind.Utc).AddTicks(4677),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(9134));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 717, DateTimeKind.Utc).AddTicks(4014),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(8580));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 717, DateTimeKind.Utc).AddTicks(3334),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(8006));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScalesCriterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 717, DateTimeKind.Utc).AddTicks(2575),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(7405));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 717, DateTimeKind.Utc).AddTicks(1887),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(6803));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 716, DateTimeKind.Utc).AddTicks(4923),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(1948));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationResults",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 717, DateTimeKind.Utc).AddTicks(1224),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(6247));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 716, DateTimeKind.Utc).AddTicks(7452),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(2618));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AppVersions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 716, DateTimeKind.Utc).AddTicks(2184),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(1362));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Albums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 715, DateTimeKind.Utc).AddTicks(9311),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(313));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Agendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 715, DateTimeKind.Utc).AddTicks(8672),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(9815));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 715, DateTimeKind.Utc).AddTicks(6985),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(8593));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 715, DateTimeKind.Utc).AddTicks(6194),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(7986));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderTableValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 715, DateTimeKind.Utc).AddTicks(5342),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(7426));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 715, DateTimeKind.Utc).AddTicks(4517),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(6871));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 714, DateTimeKind.Utc).AddTicks(6632),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(2112));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 715, DateTimeKind.Utc).AddTicks(2022),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(6327));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 715, DateTimeKind.Utc).AddTicks(1379),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(5815));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 715, DateTimeKind.Utc).AddTicks(740),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(5307));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 715, DateTimeKind.Utc).AddTicks(34),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(4746));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 714, DateTimeKind.Utc).AddTicks(9187),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(4073));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 714, DateTimeKind.Utc).AddTicks(8435),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(3526));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 714, DateTimeKind.Utc).AddTicks(7567),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(2834));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Achievements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 714, DateTimeKind.Utc).AddTicks(5866),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(1478));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutAwardPage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 7, 56, 42, 714, DateTimeKind.Utc).AddTicks(4291),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(237));
        }
    }
}
