using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Api.Migrations
{
    /// <inheritdoc />
    public partial class UpdateOnTables_TermsAndConditions_CycleConditions_DeleteTitleColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArabicTitle",
                table: "TermsAndConditions");

            migrationBuilder.DropColumn(
                name: "EnglishTitle",
                table: "TermsAndConditions");

            migrationBuilder.DropColumn(
                name: "ArabicTitle",
                table: "CycleCondition");

            migrationBuilder.DropColumn(
                name: "EnglishTitle",
                table: "CycleCondition");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WorkflowQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(793),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(5271));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 994, DateTimeKind.Utc).AddTicks(2628),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(5863));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponseAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 994, DateTimeKind.Utc).AddTicks(3524),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(6438));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VirtualTableForSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(4102),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(9305));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(3139),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(7398));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserTokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(6922),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(1511));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UsersRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(6315),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(713));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(5728),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(18));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 992, DateTimeKind.Utc).AddTicks(452),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(1901));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 994, DateTimeKind.Utc).AddTicks(1724),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(5239));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 994, DateTimeKind.Utc).AddTicks(758),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(4678));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermsAndConditions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 993, DateTimeKind.Utc).AddTicks(9880),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(4127));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Templates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 993, DateTimeKind.Utc).AddTicks(9029),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(3544));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SwitchArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(475),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(5365));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(2207),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(6925));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StrategicPartners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 993, DateTimeKind.Utc).AddTicks(7229),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(2425));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 993, DateTimeKind.Utc).AddTicks(6380),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(1897));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(2491),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(6710));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SocialMedias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 993, DateTimeKind.Utc).AddTicks(5613),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(1389));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SavedCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 993, DateTimeKind.Utc).AddTicks(4716),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(811));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(4602),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(8907));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RolePermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(5149),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(9461));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RoleMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 993, DateTimeKind.Utc).AddTicks(3742),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(175));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rewards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 993, DateTimeKind.Utc).AddTicks(2777),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ResponsibilitiesUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 993, DateTimeKind.Utc).AddTicks(1853),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(9000));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Responsibilities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 993, DateTimeKind.Utc).AddTicks(937),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(8420));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 992, DateTimeKind.Utc).AddTicks(8977),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(7221));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccountRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 992, DateTimeKind.Utc).AddTicks(9901),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(7807));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ReferenceSources",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 992, DateTimeKind.Utc).AddTicks(8087),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(6656));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 992, DateTimeKind.Utc).AddTicks(7124),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(6056));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Personalnvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(1629),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(6308));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Permissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(3558),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(7873));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PermissionHeaders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(4106),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(8407));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 992, DateTimeKind.Utc).AddTicks(3054),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(3662));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructureImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 992, DateTimeKind.Utc).AddTicks(6061),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(5414));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 992, DateTimeKind.Utc).AddTicks(5084),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(4840));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OurGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 984, DateTimeKind.Utc).AddTicks(4742),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 232, DateTimeKind.Utc).AddTicks(9906));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OnePageText",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 992, DateTimeKind.Utc).AddTicks(2201),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(3140));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NotificationTemplates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 992, DateTimeKind.Utc).AddTicks(1373),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(2516));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Notifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(9544),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(1241));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsTickers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(8732),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(753));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(7852),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(225));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(6762),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(9687));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(7505),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(1773));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(5036),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(9159));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Meetings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(4155),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(8629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(3539),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(8080));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LogUserActions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(2791),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(7497));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(7995),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(2766));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(8545),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(3354));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeParticipants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(395),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(5116));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeNoteAndQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(9695),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(4499));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(9115),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(3917));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Instructions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(7473),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(2057));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(9759),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(4668));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 992, DateTimeKind.Utc).AddTicks(4093),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(4236));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HomePageSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(2986),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(7323));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GroupInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(1022),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(5725));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(2454),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(6813));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(1361),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(5791));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(1930),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(6308));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Galleries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(5845),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(941));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FrequentlyAskedQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(8809),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(2983));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(732),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(5184));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(37),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(4456));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(8239),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(2403));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(7657),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(1798));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(7097),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(1261));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryGuides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(6528),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(719));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(5993),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(160));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EntitiesCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(3823),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(8049));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(6918),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(1192));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(6281),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(587));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalInstitutions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(5443),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(9612));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(4904),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(9077));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(4406),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(8588));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(1295),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(5490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeTableValue",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(691),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(4915));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(126),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(4353));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(7802),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(2110));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(9554),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(3787));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(9001),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(3224));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(8438),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(2683));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(1889),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(6072));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DigitalSignatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(3445),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(7841));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(7148),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(1465));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(6492),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(797));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Dependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(5697),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(9981));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cycles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(2898),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(7287));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(2315),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(6728));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 993, DateTimeKind.Utc).AddTicks(8182),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(3001));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleCondition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(1704),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(6138));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Criterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(424),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(4919));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(9199),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(3620));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(9797),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(4267));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(1054),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(5543));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Coordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(8636),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(2919));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CoordinatorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(8058),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(2366));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(5621),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(2));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(4895),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(9585));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Committees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(5035),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(9399));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(4424),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(8819));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Circulars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(1393),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(5828));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(3829),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(8205));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularChairmans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(3212),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(7590));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(2625),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(6991));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(2015),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(6378));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatBotQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(236),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(4721));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnInitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(9083),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(4055));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnFinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(9407),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(3769));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(8441),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(3452));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(9055),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(3539));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryEducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(8438),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(2941));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryCommittees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(7783),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(2347));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoriesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(7138),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(1745));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(9666),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(4165));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardStatistics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(6522),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(1165));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardSponsors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(5978),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(636));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardPublications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(5459),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(129));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeTableNames",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(5044),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(9363));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeOperations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(4524),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(8880));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeDataTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(3990),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(8382));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(4315),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(9013));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(3726),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(8466));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(3075),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(7873));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScalesCriterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(2420),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(7207));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(1762),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(6578));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(7036),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(2116));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationResults",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(1141),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(6001));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(7787),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(2812));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AppVersions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(6401),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(1477));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Albums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(5243),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(385));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Agendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(4663),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(9866));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(3369),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(8589));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(2716),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(7962));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderTableValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(2020),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(7317));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(1380),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(6707));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 984, DateTimeKind.Utc).AddTicks(6123),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(1243));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(775),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(6022));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(200),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(5501));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 984, DateTimeKind.Utc).AddTicks(9648),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(4840));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 984, DateTimeKind.Utc).AddTicks(9005),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(4196));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 984, DateTimeKind.Utc).AddTicks(8296),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(3373));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 984, DateTimeKind.Utc).AddTicks(7680),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(2814));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 984, DateTimeKind.Utc).AddTicks(6959),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(2079));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Achievements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 984, DateTimeKind.Utc).AddTicks(5402),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(555));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutAwardPage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 984, DateTimeKind.Utc).AddTicks(4048),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 232, DateTimeKind.Utc).AddTicks(9235));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WorkflowQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(5271),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(793));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(5863),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 994, DateTimeKind.Utc).AddTicks(2628));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponseAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(6438),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 994, DateTimeKind.Utc).AddTicks(3524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VirtualTableForSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(9305),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(4102));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(7398),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(3139));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserTokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(1511),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(6922));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UsersRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(713),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(6315));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(18),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(5728));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(1901),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 992, DateTimeKind.Utc).AddTicks(452));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(5239),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 994, DateTimeKind.Utc).AddTicks(1724));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(4678),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 994, DateTimeKind.Utc).AddTicks(758));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermsAndConditions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(4127),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 993, DateTimeKind.Utc).AddTicks(9880));

            migrationBuilder.AddColumn<string>(
                name: "ArabicTitle",
                table: "TermsAndConditions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EnglishTitle",
                table: "TermsAndConditions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Templates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(3544),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 993, DateTimeKind.Utc).AddTicks(9029));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SwitchArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(5365),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(475));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(6925),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(2207));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StrategicPartners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(2425),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 993, DateTimeKind.Utc).AddTicks(7229));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(1897),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 993, DateTimeKind.Utc).AddTicks(6380));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(6710),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(2491));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SocialMedias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(1389),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 993, DateTimeKind.Utc).AddTicks(5613));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SavedCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(811),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 993, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(8907),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(4602));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RolePermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(9461),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(5149));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RoleMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(175),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 993, DateTimeKind.Utc).AddTicks(3742));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rewards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(9590),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 993, DateTimeKind.Utc).AddTicks(2777));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ResponsibilitiesUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(9000),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 993, DateTimeKind.Utc).AddTicks(1853));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Responsibilities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(8420),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 993, DateTimeKind.Utc).AddTicks(937));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(7221),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 992, DateTimeKind.Utc).AddTicks(8977));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccountRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(7807),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 992, DateTimeKind.Utc).AddTicks(9901));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ReferenceSources",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(6656),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 992, DateTimeKind.Utc).AddTicks(8087));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(6056),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 992, DateTimeKind.Utc).AddTicks(7124));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Personalnvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(6308),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(1629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Permissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(7873),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(3558));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PermissionHeaders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(8407),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(4106));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(3662),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 992, DateTimeKind.Utc).AddTicks(3054));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructureImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(5414),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 992, DateTimeKind.Utc).AddTicks(6061));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(4840),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 992, DateTimeKind.Utc).AddTicks(5084));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OurGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 232, DateTimeKind.Utc).AddTicks(9906),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 984, DateTimeKind.Utc).AddTicks(4742));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OnePageText",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(3140),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 992, DateTimeKind.Utc).AddTicks(2201));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NotificationTemplates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(2516),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 992, DateTimeKind.Utc).AddTicks(1373));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Notifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(1241),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(9544));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsTickers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(753),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(8732));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(225),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(7852));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(9687),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(6762));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(1773),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(7505));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(9159),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(5036));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Meetings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(8629),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(4155));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(8080),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(3539));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LogUserActions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(7497),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(2791));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(2766),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(7995));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(3354),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(8545));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeParticipants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(5116),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(395));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeNoteAndQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(4499),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(9695));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(3917),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(9115));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Instructions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(2057),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(7473));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(4668),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(9759));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(4236),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 992, DateTimeKind.Utc).AddTicks(4093));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HomePageSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(7323),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(2986));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GroupInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(5725),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 991, DateTimeKind.Utc).AddTicks(1022));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(6813),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(2454));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(5791),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(1361));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(6308),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(1930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Galleries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(941),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(5845));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FrequentlyAskedQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(2983),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(8809));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(5184),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(732));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(4456),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 990, DateTimeKind.Utc).AddTicks(37));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(2403),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(8239));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(1798),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(7657));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(1261),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(7097));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryGuides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(719),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(6528));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(160),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(5993));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EntitiesCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(8049),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(3823));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(1192),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(6918));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(587),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(6281));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalInstitutions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(9612),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(5443));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(9077),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(4904));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(8588),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(4406));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(5490),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(1295));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeTableValue",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(4915),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(691));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(4353),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(126));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(2110),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(7802));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(3787),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(9554));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(3224),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(9001));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(2683),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(8438));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(6072),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(1889));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DigitalSignatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(7841),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(3445));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(1465),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(7148));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(797),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(6492));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Dependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(9981),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(5697));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cycles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(7287),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(2898));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(6728),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(2315));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(3001),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 993, DateTimeKind.Utc).AddTicks(8182));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleCondition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(6138),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(1704));

            migrationBuilder.AddColumn<string>(
                name: "ArabicTitle",
                table: "CycleCondition",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EnglishTitle",
                table: "CycleCondition",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Criterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(4919),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(424));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(3620),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(9199));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(4267),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(9797));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(5543),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(1054));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Coordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(2919),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(8636));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CoordinatorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(2366),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(8058));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(2),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(5621));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(9585),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(4895));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Committees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(9399),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(5035));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(8819),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(4424));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Circulars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(5828),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(1393));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(8205),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(3829));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularChairmans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(7590),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(3212));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(6991),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(2625));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(6378),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(2015));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatBotQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(4721),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 987, DateTimeKind.Utc).AddTicks(236));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnInitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(4055),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(9083));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnFinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(3769),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 989, DateTimeKind.Utc).AddTicks(9407));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(3452),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(8441));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(3539),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(9055));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryEducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(2941),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(8438));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryCommittees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(2347),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(7783));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoriesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(1745),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(7138));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(4165),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(9666));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardStatistics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(1165),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(6522));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardSponsors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(636),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(5978));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardPublications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(129),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(5459));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeTableNames",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(9363),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(5044));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeOperations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(8880),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(4524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeDataTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(8382),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 988, DateTimeKind.Utc).AddTicks(3990));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(9013),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(4315));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(8466),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(3726));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(7873),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(3075));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScalesCriterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(7207),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(2420));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(6578),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(1762));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(2116),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(7036));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationResults",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(6001),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 986, DateTimeKind.Utc).AddTicks(1141));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(2812),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(7787));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AppVersions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(1477),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(6401));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Albums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(385),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(5243));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Agendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(9866),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(4663));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(8589),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(3369));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(7962),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(2716));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderTableValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(7317),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(2020));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(6707),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(1380));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(1243),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 984, DateTimeKind.Utc).AddTicks(6123));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(6022),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(775));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(5501),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 985, DateTimeKind.Utc).AddTicks(200));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(4840),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 984, DateTimeKind.Utc).AddTicks(9648));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(4196),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 984, DateTimeKind.Utc).AddTicks(9005));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(3373),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 984, DateTimeKind.Utc).AddTicks(8296));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(2814),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 984, DateTimeKind.Utc).AddTicks(7680));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(2079),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 984, DateTimeKind.Utc).AddTicks(6959));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Achievements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(555),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 984, DateTimeKind.Utc).AddTicks(5402));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutAwardPage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 232, DateTimeKind.Utc).AddTicks(9235),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 2, 11, 6, 23, 984, DateTimeKind.Utc).AddTicks(4048));
        }
    }
}
