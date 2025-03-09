using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddNewTable_RequestForChangeInterviewEligibilityStatuses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WorkflowQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(467),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(5780));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 104, DateTimeKind.Utc).AddTicks(3783),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(8172));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponseAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 104, DateTimeKind.Utc).AddTicks(4526),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(8739));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VirtualTableForSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(9472),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(9273));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(2222),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(8979));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserTokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(1764),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(3112));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UsersRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(1003),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(2555));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(9484),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(1439));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(4397),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(3103));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNoteOnFormForArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(7523),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(5647));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(219),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(1980));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 104, DateTimeKind.Utc).AddTicks(3040),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(7588));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 104, DateTimeKind.Utc).AddTicks(2343),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(7008));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 104, DateTimeKind.Utc).AddTicks(1654),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(6351));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermsAndConditions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 104, DateTimeKind.Utc).AddTicks(247),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(5044));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermAndConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 104, DateTimeKind.Utc).AddTicks(939),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(5765));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Templates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(9564),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(4503));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SwitchArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(6744),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(5043));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubcommitteeCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(2612),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(9675));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(8208),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(8083));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StrategicPartners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(8158),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(3424));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(7476),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(2900));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(1331),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(8368));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SocialMedias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(6839),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(2407));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SavedCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(6134),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(1858));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(7990),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(336));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RolePermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(8713),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(904));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RoleMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(5335),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(1234));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rewards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(4617),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(641));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ResponsibilitiesUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(3886),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(9902));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Responsibilities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(3174),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(9336));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(1696),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(8091));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccountRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(2448),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(8665));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ReferenceSources",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(994),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(7554));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(9466),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(6969));

            migrationBuilder.AddColumn<bool>(
                name: "EligibileForInterview",
                table: "ProvidedForms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Personalnvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(7494),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(7518));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Permissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(6531),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(9347));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PermissionHeaders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(7252),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(9858));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(6457),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(4663));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructureImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(8615),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(6350));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(7898),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(5789));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OurGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 92, DateTimeKind.Utc).AddTicks(8864),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(883));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OnePageText",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(5774),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(4139));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NotificationTemplates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(5126),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(3652));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Notifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(3678),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(2565));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsTickers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(3030),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(2080));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(2372),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(1568));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(1715),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(1041));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(9520),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(2574));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(1030),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Meetings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(352),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(9996));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(9658),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(9381));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LogUserActions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(8926),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(8733));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(3136),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(4127));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(3831),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(4667));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeParticipants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(6009),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(6370));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeNoteAndQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(5211),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(5756));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(4520),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(5207));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Instructions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(2473),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(3632));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(5954),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(4421));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(7162),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(5211));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HomePageSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(5806),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(8826));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GroupInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(6772),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(6959));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(5130),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(8322));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(3407),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(7306));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(4249),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(7828));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Galleries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(1450),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(857));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FrequentlyAskedQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(219),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(4913));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(2616),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(6711));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(1777),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(6073));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(9505),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(4375));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(8066),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(3285));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(8779),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(3830));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(7373),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(2758));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryGuides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(6684),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(2227));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(5955),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(1698));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EntitiesCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(3146),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(9604));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(8715),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(2002));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(7917),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(1408));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalInstitutions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(5234),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(1169));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(4501),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(650));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(3859),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(172));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(9601),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(7172));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeTableValue",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(8826),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(6629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(8110),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(6083));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(4989),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(3919));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(7360),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(5525));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(6631),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(5001));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(5732),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(4479));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(367),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(7734));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DigitalSignatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(9238),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(9840));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(4156),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(3305));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(3259),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(2671));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Dependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(2230),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(1932));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cycles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(8504),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(9307));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(7757),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(8765));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(7018),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(8202));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(8892),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(3983));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleCondition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(6307),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(7663));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Criterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(4051),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(5948));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(1701),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(4187));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(3282),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(5371));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(2490),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(4761));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(5588),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(7116));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(4849),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(6542));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Coordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(973),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(3655));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CoordinatorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(261),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(7149),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(850));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(3341),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(261));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Committees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(6399),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(269));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(4861),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(9134));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteeOfficers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(5637),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(9711));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Circulars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(1151),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(6314));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(4082),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(8553));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularChairmans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(3316),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(7962));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(2596),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(7402));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(1862),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(6850));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatBotQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(9773),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(5242));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnInitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(5189),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(3817));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnFinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(964),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(5475));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(4463),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(3230));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(8330),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(4124));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryEducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(7589),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(3568));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryCommittees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(6822),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(2982));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoriesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(6061),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(2384));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(9052),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(4680));

            migrationBuilder.AddColumn<int>(
                name: "MinimumEligibilityForInterview",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardStatistics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(5318),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(1821));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardSponsors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(4634),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(1300));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardPublications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(4004),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(812));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeTableNames",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(1401),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(1310));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeOperations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(743),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(841));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeDataTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(83),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(364));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(1929),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(9134));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(1275),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(8580));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(524),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(8006));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScalesCriterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(9773),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(7405));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(9009),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(6803));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(2838),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(1948));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationResults",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(8277),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(6247));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(3691),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(2618));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AppVersions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(2075),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(1362));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Albums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(785),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(313));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Agendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(143),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(9815));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(8630),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(8593));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(7851),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(7986));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderTableValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(7060),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(7426));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(6331),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(6871));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(462),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(2112));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(5628),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(6327));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(4957),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(5815));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(4326),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(5307));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(3637),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(4746));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(2838),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(4073));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(2172),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(3526));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(1371),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(2834));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Achievements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 92, DateTimeKind.Utc).AddTicks(9679),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(1478));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutAwardPage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 92, DateTimeKind.Utc).AddTicks(8070),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(237));

            migrationBuilder.CreateTable(
                name: "RequestForChangeInterviewEligibilityStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvidedFormId = table.Column<int>(type: "int", nullable: false),
                    RequestedById = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(305)),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestForChangeInterviewEligibilityStatuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestForChangeInterviewEligibilityStatuses_ProvidedForms_ProvidedFormId",
                        column: x => x.ProvidedFormId,
                        principalTable: "ProvidedForms",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestForChangeInterviewEligibilityStatuses_Users_RequestedById",
                        column: x => x.RequestedById,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_RequestForChangeInterviewEligibilityStatuses_ProvidedFormId",
                table: "RequestForChangeInterviewEligibilityStatuses",
                column: "ProvidedFormId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestForChangeInterviewEligibilityStatuses_RequestedById",
                table: "RequestForChangeInterviewEligibilityStatuses",
                column: "RequestedById");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RequestForChangeInterviewEligibilityStatuses");

            migrationBuilder.DropColumn(
                name: "EligibileForInterview",
                table: "ProvidedForms");

            migrationBuilder.DropColumn(
                name: "MinimumEligibilityForInterview",
                table: "Categories");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WorkflowQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(5780),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(467));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(8172),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 104, DateTimeKind.Utc).AddTicks(3783));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponseAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(8739),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 104, DateTimeKind.Utc).AddTicks(4526));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VirtualTableForSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(9273),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(9472));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(8979),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(2222));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserTokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(3112),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(1764));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UsersRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(2555),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(1003));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(1439),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(9484));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(3103),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(4397));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNoteOnFormForArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(5647),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(7523));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(1980),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(219));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(7588),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 104, DateTimeKind.Utc).AddTicks(3040));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(7008),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 104, DateTimeKind.Utc).AddTicks(2343));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(6351),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 104, DateTimeKind.Utc).AddTicks(1654));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermsAndConditions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(5044),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 104, DateTimeKind.Utc).AddTicks(247));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermAndConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(5765),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 104, DateTimeKind.Utc).AddTicks(939));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Templates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(4503),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(9564));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SwitchArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(5043),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(6744));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubcommitteeCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(9675),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(2612));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(8083),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(8208));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StrategicPartners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(3424),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(8158));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(2900),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(7476));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(8368),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(1331));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SocialMedias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(2407),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(6839));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SavedCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(1858),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(6134));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(336),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(7990));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RolePermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(904),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(8713));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RoleMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(1234),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(5335));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rewards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(641),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(4617));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ResponsibilitiesUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(9902),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(3886));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Responsibilities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(9336),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(3174));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(8091),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(1696));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccountRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(8665),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(2448));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ReferenceSources",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(7554),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(994));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(6969),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(9466));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Personalnvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(7518),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(7494));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Permissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(9347),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(6531));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PermissionHeaders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(9858),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(7252));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(4663),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(6457));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructureImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(6350),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(8615));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(5789),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(7898));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OurGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(883),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 92, DateTimeKind.Utc).AddTicks(8864));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OnePageText",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(4139),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(5774));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NotificationTemplates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(3652),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(5126));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Notifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(2565),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(3678));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsTickers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(2080),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(3030));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(1568),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(2372));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(1041),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(1715));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(2574),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(9520));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(524),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(1030));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Meetings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(9996),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(352));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(9381),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(9658));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LogUserActions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(8733),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(8926));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(4127),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(3136));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(4667),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(3831));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeParticipants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(6370),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(6009));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeNoteAndQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(5756),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(5211));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(5207),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(4520));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Instructions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(3632),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(2473));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(4421),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(5954));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 893, DateTimeKind.Utc).AddTicks(5211),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(7162));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HomePageSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(8826),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(5806));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GroupInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 892, DateTimeKind.Utc).AddTicks(6959),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(6772));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(8322),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(5130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(7306),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(3407));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(7828),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(4249));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Galleries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(857),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(1450));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FrequentlyAskedQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(4913),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(219));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(6711),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(2616));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(6073),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(1777));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(4375),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(9505));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(3285),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(8066));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(3830),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(8779));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(2758),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(7373));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryGuides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(2227),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(6684));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(1698),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(5955));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EntitiesCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(9604),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(3146));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(2002),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(8715));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(1408),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(7917));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalInstitutions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(1169),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(5234));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(650),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(4501));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(172),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(3859));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(7172),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(9601));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeTableValue",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(6629),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(8826));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(6083),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(8110));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(3919),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(4989));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(5525),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(7360));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(5001),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(6631));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(4479),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(5732));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(7734),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(367));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DigitalSignatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(9840),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(9238));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(3305),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(4156));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(2671),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(3259));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Dependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(1932),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(2230));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cycles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(9307),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(8504));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(8765),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(7757));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(8202),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(7018));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 894, DateTimeKind.Utc).AddTicks(3983),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(8892));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleCondition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(7663),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(6307));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Criterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(5948),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(4051));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(4187),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(1701));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(5371),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(3282));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(4761),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(2490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(7116),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(5588));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(6542),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(4849));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Coordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(3655),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(973));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CoordinatorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(3120),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(261));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(850),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(7149));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(261),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(3341));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Committees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 889, DateTimeKind.Utc).AddTicks(269),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(6399));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(9134),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(4861));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteeOfficers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(9711),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(5637));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Circulars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(6314),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(1151));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(8553),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(4082));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularChairmans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(7962),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(3316));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(7402),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(2596));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(6850),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(1862));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatBotQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(5242),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(9773));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnInitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(3817),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(5189));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnFinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 891, DateTimeKind.Utc).AddTicks(5475),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(964));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(3230),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(4463));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(4124),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(8330));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryEducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(3568),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(7589));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryCommittees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(2982),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(6822));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoriesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(2384),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(6061));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(4680),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(9052));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardStatistics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(1821),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(5318));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardSponsors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(1300),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(4634));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardPublications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 888, DateTimeKind.Utc).AddTicks(812),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(4004));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeTableNames",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(1310),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(1401));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeOperations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(841),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(743));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeDataTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 890, DateTimeKind.Utc).AddTicks(364),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(83));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(9134),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(1929));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(8580),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(1275));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(8006),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScalesCriterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(7405),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(9773));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(6803),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(9009));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(1948),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(2838));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationResults",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(6247),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(8277));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(2618),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(3691));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AppVersions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(1362),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(2075));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Albums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 887, DateTimeKind.Utc).AddTicks(313),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(785));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Agendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(9815),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(143));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(8593),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(8630));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(7986),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(7851));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderTableValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(7426),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(7060));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(6871),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(6331));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(2112),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(462));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(6327),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(5628));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(5815),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(4957));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(5307),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(4326));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(4746),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(3637));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(4073),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(2838));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(3526),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(2172));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(2834),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(1371));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Achievements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(1478),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 92, DateTimeKind.Utc).AddTicks(9679));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutAwardPage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 15, 11, 19, 2, 886, DateTimeKind.Utc).AddTicks(237),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 92, DateTimeKind.Utc).AddTicks(8070));
        }
    }
}
