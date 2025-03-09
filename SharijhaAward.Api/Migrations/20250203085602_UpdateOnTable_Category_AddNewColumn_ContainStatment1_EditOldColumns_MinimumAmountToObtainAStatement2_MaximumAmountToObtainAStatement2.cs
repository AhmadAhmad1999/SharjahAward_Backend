using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Api.Migrations
{
    /// <inheritdoc />
    public partial class UpdateOnTable_Category_AddNewColumn_ContainStatment1_EditOldColumns_MinimumAmountToObtainAStatement2_MaximumAmountToObtainAStatement2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MinimumAmountToObtainAStatement",
                table: "Categories",
                newName: "MinimumAmountToObtainAStatement2");

            migrationBuilder.RenameColumn(
                name: "MaximumAmountToObtainAStatement",
                table: "Categories",
                newName: "MaximumAmountToObtainAStatement2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WorkflowQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(1473),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(793));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 279, DateTimeKind.Utc).AddTicks(5795),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 994, DateTimeKind.Utc).AddTicks(2628));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponseAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 279, DateTimeKind.Utc).AddTicks(6550),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 994, DateTimeKind.Utc).AddTicks(3524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VirtualTableForSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(9740),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(4102));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(8728),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(3139));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserTokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(5094),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(6922));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UsersRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(4384),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(6315));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(3685),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(5728));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(8042),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 992, DateTimeKind.Utc).AddTicks(452));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 279, DateTimeKind.Utc).AddTicks(5012),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 994, DateTimeKind.Utc).AddTicks(1724));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 279, DateTimeKind.Utc).AddTicks(4304),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 994, DateTimeKind.Utc).AddTicks(758));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermsAndConditions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 279, DateTimeKind.Utc).AddTicks(3571),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 993, DateTimeKind.Utc).AddTicks(9880));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Templates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 279, DateTimeKind.Utc).AddTicks(2847),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 993, DateTimeKind.Utc).AddTicks(9029));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SwitchArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 270, DateTimeKind.Utc).AddTicks(8893),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(475));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(1408),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(2207));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StrategicPartners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 279, DateTimeKind.Utc).AddTicks(1414),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 993, DateTimeKind.Utc).AddTicks(7229));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 279, DateTimeKind.Utc).AddTicks(736),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 993, DateTimeKind.Utc).AddTicks(6380));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(7949),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(2491));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SocialMedias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 279, DateTimeKind.Utc).AddTicks(65),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 993, DateTimeKind.Utc).AddTicks(5613));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SavedCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(9321),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 993, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(2310),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(4602));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RolePermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(2995),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(5149));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RoleMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(8494),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 993, DateTimeKind.Utc).AddTicks(3742));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rewards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(7752),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 993, DateTimeKind.Utc).AddTicks(2777));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ResponsibilitiesUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(6984),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 993, DateTimeKind.Utc).AddTicks(1853));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Responsibilities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(6217),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 993, DateTimeKind.Utc).AddTicks(937));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(4708),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 992, DateTimeKind.Utc).AddTicks(8977));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccountRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(5486),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 992, DateTimeKind.Utc).AddTicks(9901));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ReferenceSources",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(3966),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 992, DateTimeKind.Utc).AddTicks(8087));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(3182),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 992, DateTimeKind.Utc).AddTicks(7124));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Personalnvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(714),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(1629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Permissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(1016),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(3558));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PermissionHeaders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(1685),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(4106));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(104),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 992, DateTimeKind.Utc).AddTicks(3054));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructureImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(2330),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 992, DateTimeKind.Utc).AddTicks(6061));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(1593),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 992, DateTimeKind.Utc).AddTicks(5084));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OurGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 268, DateTimeKind.Utc).AddTicks(9017),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 984, DateTimeKind.Utc).AddTicks(4742));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OnePageText",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(9403),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 992, DateTimeKind.Utc).AddTicks(2201));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NotificationTemplates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(8757),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 992, DateTimeKind.Utc).AddTicks(1373));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Notifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(7328),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(9544));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsTickers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(6683),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(8732));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(6007),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(7852));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(5314),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(6762));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(9532),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(7505));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(4605),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(5036));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Meetings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(3807),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(4155));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(3094),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(3539));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LogUserActions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(2335),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(2791));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(6432),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(7995));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(7107),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(8545));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeParticipants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(9255),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(395));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeNoteAndQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(8502),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(9695));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(7808),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(9115));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Instructions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(5766),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(7473));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 270, DateTimeKind.Utc).AddTicks(8075),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(9759));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(834),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 992, DateTimeKind.Utc).AddTicks(4093));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HomePageSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(357),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(2986));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GroupInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(15),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(1022));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(9736),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(2454));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(8486),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(1361));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(9120),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(1930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Galleries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 270, DateTimeKind.Utc).AddTicks(2626),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(5845));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FrequentlyAskedQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(5479),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(8809));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(7738),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(732));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(6957),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(37));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(4789),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(8239));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(4095),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(7657));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(3435),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(7097));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryGuides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(2794),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(6528));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(2124),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(5993));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EntitiesCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(9537),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(3823));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(8784),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(6918));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(8020),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(6281));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalInstitutions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(1453),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(5443));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(807),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(4904));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(198),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(4406));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(6505),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(1295));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeTableValue",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(5733),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(691));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(5024),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(126));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(2201),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(7802));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(4293),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(9554));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(3613),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(9001));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(2932),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(8438));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(7217),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(1889));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DigitalSignatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(6771),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(3445));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(1421),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(7148));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(566),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(6492));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Dependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(9561),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(5697));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cycles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(6077),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(2898));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(5353),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(2315));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 279, DateTimeKind.Utc).AddTicks(2153),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 993, DateTimeKind.Utc).AddTicks(8182));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleCondition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(4607),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(1704));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Criterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(3031),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(424));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(1563),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(9199));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(2297),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(9797));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(3773),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(1054));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Coordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(891),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(8636));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CoordinatorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(224),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(8058));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(7300),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(5621));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(4252),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(4895));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Committees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(6580),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(5035));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(5864),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(4424));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Circulars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(2173),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(1393));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(5106),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(3829));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularChairmans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(4355),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(3212));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(3616),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(2625));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(2885),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(2015));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatBotQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(764),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(236));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnInitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 270, DateTimeKind.Utc).AddTicks(7062),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(9083));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnFinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(6199),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(9407));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 270, DateTimeKind.Utc).AddTicks(6285),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(8441));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(9279),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(9055));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryEducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(8546),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(8438));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryCommittees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(7779),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(7783));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoriesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(7014),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(7138));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(43),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(9666));

            migrationBuilder.AddColumn<bool>(
                name: "ContainStatment1",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardStatistics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(6263),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(6522));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardSponsors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(5582),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(5978));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardPublications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(4937),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(5459));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeTableNames",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(8736),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(5044));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeOperations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(8106),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(4524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeDataTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(7460),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(3990));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(3546),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(4315));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(2851),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(3726));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(2099),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(3075));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScalesCriterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(1288),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(2420));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(506),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(1762));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 270, DateTimeKind.Utc).AddTicks(4458),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(7036));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationResults",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 270, DateTimeKind.Utc).AddTicks(9750),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(1141));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 270, DateTimeKind.Utc).AddTicks(5389),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(7787));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AppVersions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 270, DateTimeKind.Utc).AddTicks(3346),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(6401));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Albums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 270, DateTimeKind.Utc).AddTicks(1933),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(5243));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Agendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 270, DateTimeKind.Utc).AddTicks(1235),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(4663));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(8856),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(3369));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(8062),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(2716));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderTableValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(7288),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(2020));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(6489),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(1380));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(528),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 984, DateTimeKind.Utc).AddTicks(6123));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(5796),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(775));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(5104),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(200));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(4459),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 984, DateTimeKind.Utc).AddTicks(9648));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(3757),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 984, DateTimeKind.Utc).AddTicks(9005));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(2955),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 984, DateTimeKind.Utc).AddTicks(8296));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(2268),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 984, DateTimeKind.Utc).AddTicks(7680));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(1419),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 984, DateTimeKind.Utc).AddTicks(6959));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Achievements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 268, DateTimeKind.Utc).AddTicks(9765),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 984, DateTimeKind.Utc).AddTicks(5402));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutAwardPage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 268, DateTimeKind.Utc).AddTicks(8227),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 984, DateTimeKind.Utc).AddTicks(4048));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContainStatment1",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "MinimumAmountToObtainAStatement2",
                table: "Categories",
                newName: "MinimumAmountToObtainAStatement");

            migrationBuilder.RenameColumn(
                name: "MaximumAmountToObtainAStatement2",
                table: "Categories",
                newName: "MaximumAmountToObtainAStatement");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WorkflowQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(793),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(1473));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 994, DateTimeKind.Utc).AddTicks(2628),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 279, DateTimeKind.Utc).AddTicks(5795));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponseAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 994, DateTimeKind.Utc).AddTicks(3524),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 279, DateTimeKind.Utc).AddTicks(6550));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VirtualTableForSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(4102),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(9740));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(3139),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(8728));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserTokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(6922),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(5094));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UsersRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(6315),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(4384));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(5728),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(3685));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 992, DateTimeKind.Utc).AddTicks(452),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(8042));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 994, DateTimeKind.Utc).AddTicks(1724),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 279, DateTimeKind.Utc).AddTicks(5012));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 994, DateTimeKind.Utc).AddTicks(758),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 279, DateTimeKind.Utc).AddTicks(4304));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermsAndConditions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 993, DateTimeKind.Utc).AddTicks(9880),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 279, DateTimeKind.Utc).AddTicks(3571));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Templates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 993, DateTimeKind.Utc).AddTicks(9029),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 279, DateTimeKind.Utc).AddTicks(2847));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SwitchArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(475),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 270, DateTimeKind.Utc).AddTicks(8893));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(2207),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(1408));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StrategicPartners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 993, DateTimeKind.Utc).AddTicks(7229),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 279, DateTimeKind.Utc).AddTicks(1414));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 993, DateTimeKind.Utc).AddTicks(6380),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 279, DateTimeKind.Utc).AddTicks(736));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(2491),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(7949));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SocialMedias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 993, DateTimeKind.Utc).AddTicks(5613),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 279, DateTimeKind.Utc).AddTicks(65));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SavedCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 993, DateTimeKind.Utc).AddTicks(4716),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(9321));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(4602),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(2310));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RolePermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(5149),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(2995));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RoleMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 993, DateTimeKind.Utc).AddTicks(3742),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(8494));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rewards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 993, DateTimeKind.Utc).AddTicks(2777),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(7752));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ResponsibilitiesUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 993, DateTimeKind.Utc).AddTicks(1853),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(6984));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Responsibilities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 993, DateTimeKind.Utc).AddTicks(937),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(6217));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 992, DateTimeKind.Utc).AddTicks(8977),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(4708));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccountRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 992, DateTimeKind.Utc).AddTicks(9901),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(5486));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ReferenceSources",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 992, DateTimeKind.Utc).AddTicks(8087),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(3966));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 992, DateTimeKind.Utc).AddTicks(7124),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(3182));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Personalnvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(1629),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(714));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Permissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(3558),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(1016));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PermissionHeaders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(4106),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(1685));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 992, DateTimeKind.Utc).AddTicks(3054),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(104));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructureImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 992, DateTimeKind.Utc).AddTicks(6061),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(2330));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 992, DateTimeKind.Utc).AddTicks(5084),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(1593));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OurGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 984, DateTimeKind.Utc).AddTicks(4742),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 268, DateTimeKind.Utc).AddTicks(9017));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OnePageText",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 992, DateTimeKind.Utc).AddTicks(2201),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(9403));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NotificationTemplates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 992, DateTimeKind.Utc).AddTicks(1373),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(8757));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Notifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(9544),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(7328));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsTickers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(8732),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(6683));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(7852),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(6007));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(6762),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(5314));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(7505),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(9532));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(5036),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(4605));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Meetings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(4155),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(3807));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(3539),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(3094));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LogUserActions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(2791),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(2335));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(7995),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(6432));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(8545),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(7107));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeParticipants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(395),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(9255));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeNoteAndQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(9695),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(8502));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(9115),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(7808));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Instructions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(7473),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(5766));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(9759),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 270, DateTimeKind.Utc).AddTicks(8075));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 992, DateTimeKind.Utc).AddTicks(4093),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 278, DateTimeKind.Utc).AddTicks(834));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HomePageSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(2986),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 276, DateTimeKind.Utc).AddTicks(357));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GroupInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(1022),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 277, DateTimeKind.Utc).AddTicks(15));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(2454),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(9736));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(1361),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(8486));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(1930),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(9120));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Galleries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(5845),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 270, DateTimeKind.Utc).AddTicks(2626));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FrequentlyAskedQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(8809),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(5479));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(732),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(7738));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(37),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(6957));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(8239),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(4789));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(7657),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(4095));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(7097),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(3435));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryGuides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(6528),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(2794));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(5993),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(2124));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EntitiesCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(3823),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(9537));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(6918),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(8784));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(6281),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(8020));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalInstitutions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(5443),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(1453));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(4904),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(807));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(4406),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(198));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(1295),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(6505));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeTableValue",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(691),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(5733));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(126),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(5024));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(7802),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(2201));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(9554),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(4293));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(9001),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(3613));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(8438),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(2932));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(1889),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(7217));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DigitalSignatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(3445),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(6771));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(7148),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(1421));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(6492),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 274, DateTimeKind.Utc).AddTicks(566));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Dependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(5697),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(9561));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cycles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(2898),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(6077));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(2315),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(5353));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 993, DateTimeKind.Utc).AddTicks(8182),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 279, DateTimeKind.Utc).AddTicks(2153));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleCondition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(1704),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(4607));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Criterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(424),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(3031));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(9199),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(1563));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(9797),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(2297));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(1054),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(3773));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Coordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(8636),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(891));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CoordinatorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(8058),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(224));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(5621),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(7300));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(4895),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(4252));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Committees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(5035),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(6580));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(4424),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(5864));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Circulars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(1393),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(2173));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(3829),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(5106));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularChairmans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(3212),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(4355));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(2625),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(3616));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(2015),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(2885));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatBotQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(236),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(764));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnInitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(9083),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 270, DateTimeKind.Utc).AddTicks(7062));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnFinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(9407),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 275, DateTimeKind.Utc).AddTicks(6199));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(8441),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 270, DateTimeKind.Utc).AddTicks(6285));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(9055),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(9279));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryEducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(8438),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(8546));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryCommittees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(7783),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(7779));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoriesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(7138),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(7014));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(9666),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 272, DateTimeKind.Utc).AddTicks(43));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardStatistics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(6522),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(6263));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardSponsors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(5978),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(5582));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardPublications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(5459),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(4937));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeTableNames",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(5044),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(8736));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeOperations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(4524),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(8106));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeDataTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(3990),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 273, DateTimeKind.Utc).AddTicks(7460));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(4315),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(3546));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(3726),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(2851));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(3075),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(2099));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScalesCriterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(2420),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(1288));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(1762),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 271, DateTimeKind.Utc).AddTicks(506));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(7036),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 270, DateTimeKind.Utc).AddTicks(4458));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationResults",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(1141),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 270, DateTimeKind.Utc).AddTicks(9750));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(7787),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 270, DateTimeKind.Utc).AddTicks(5389));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AppVersions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(6401),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 270, DateTimeKind.Utc).AddTicks(3346));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Albums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(5243),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 270, DateTimeKind.Utc).AddTicks(1933));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Agendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(4663),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 270, DateTimeKind.Utc).AddTicks(1235));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(3369),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(8856));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(2716),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(8062));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderTableValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(2020),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(7288));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(1380),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(6489));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 984, DateTimeKind.Utc).AddTicks(6123),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(528));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(775),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(5796));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(200),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(5104));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 984, DateTimeKind.Utc).AddTicks(9648),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(4459));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 984, DateTimeKind.Utc).AddTicks(9005),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(3757));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 984, DateTimeKind.Utc).AddTicks(8296),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(2955));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 984, DateTimeKind.Utc).AddTicks(7680),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(2268));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 984, DateTimeKind.Utc).AddTicks(6959),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 269, DateTimeKind.Utc).AddTicks(1419));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Achievements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 984, DateTimeKind.Utc).AddTicks(5402),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 268, DateTimeKind.Utc).AddTicks(9765));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutAwardPage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 984, DateTimeKind.Utc).AddTicks(4048),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 3, 8, 56, 0, 268, DateTimeKind.Utc).AddTicks(8227));
        }
    }
}
