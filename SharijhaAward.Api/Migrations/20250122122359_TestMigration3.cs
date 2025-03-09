using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Api.Migrations
{
    /// <inheritdoc />
    public partial class TestMigration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AAAs");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WorkflowQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(5524),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(4391));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 837, DateTimeKind.Utc).AddTicks(1927),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 354, DateTimeKind.Utc).AddTicks(3635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponseAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 837, DateTimeKind.Utc).AddTicks(2491),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 354, DateTimeKind.Utc).AddTicks(4417));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VirtualTableForSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(9837),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(3055));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(6394),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(3780));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserTokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(9207),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(2112));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UsersRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(8646),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(1338));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(8111),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(581));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(8940),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(5398));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 837, DateTimeKind.Utc).AddTicks(1348),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 354, DateTimeKind.Utc).AddTicks(2837));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 837, DateTimeKind.Utc).AddTicks(815),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 354, DateTimeKind.Utc).AddTicks(2049));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermsAndConditions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 837, DateTimeKind.Utc).AddTicks(280),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 354, DateTimeKind.Utc).AddTicks(1327));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Templates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(9763),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 354, DateTimeKind.Utc).AddTicks(606));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SwitchArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(5822),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(1362));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(4006),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(8870));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StrategicPartners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(8718),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(9114));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(8181),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(8437));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(5741),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(2919));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SocialMedias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(7672),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(7771));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SavedCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(7057),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(7024));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(7060),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(8982));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RolePermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(7583),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(9802));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RoleMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(6467),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(6168));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rewards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(5927),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(5311));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ResponsibilitiesUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(5384),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(4553));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Responsibilities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(4842),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(3816));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(3751),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(2319));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccountRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(4305),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(3077));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ReferenceSources",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(3235),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(1600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(2674),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(828));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Personalnvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(3480),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(8072));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Permissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(6018),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(7085));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PermissionHeaders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(6563),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(8042));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(453),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(7698));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructureImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(2068),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(9935));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(1529),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(9180));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OurGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(646),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(1551));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OnePageText",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(9947),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(6773));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NotificationTemplates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(9461),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(6124));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Notifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(8410),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(4647));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsTickers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(7937),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(4010));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(7347),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(3277));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(6806),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(2598));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(1577),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(2982));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(6174),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(1897));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Meetings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(5636),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(1205));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(5119),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(464));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LogUserActions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(4536),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(9611));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(213),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(3531));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(734),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(4253));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeParticipants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(2376),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(6551));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeNoteAndQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(1792),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(5739));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(1263),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(5003));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Instructions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(9721),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(2841));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(5215),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(502));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(975),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(8439));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HomePageSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(5457),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(6362));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GroupInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(2943),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(7336));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(4979),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(5668));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(4016),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(4318));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(4507),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(5015));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Galleries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(1434),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(5283));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FrequentlyAskedQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(1701),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(1070));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(3446),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(3496));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(2835),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(2662));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(1176),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(643),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(9537));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(133),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(8814));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryGuides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(9637),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(8103));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(9128),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(7394));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EntitiesCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(7031),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(4620));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(1026),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(2154));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(454),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(1300));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalInstitutions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(8609),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(6689));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(8087),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(5988));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(7585),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(5349));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(4402),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(1304));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeTableValue",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(3873),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(535));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(3347),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(9773));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(1258),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(6722));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(2812),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(9005));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(2309),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(8268));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(1802),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(7510));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(5103),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(2104));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DigitalSignatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(7243),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(783));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(664),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(5865));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(40),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(4928));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Dependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(9318),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(3865));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cycles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(6735),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(42));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(6202),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(9285));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(9257),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(9857));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleCondition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(5625),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(8498));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Criterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(4493),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(6897));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(3131),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(5254));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(3871),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(6069));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(5067),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(7717));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Coordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(2616),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(4530));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CoordinatorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(2096),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(3754));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(9892),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(500));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(9775),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(6865));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Committees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(9350),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(9711));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(8801),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(8935));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Circulars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(6058),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(5099));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(8237),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(8144));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularChairmans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(7662),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(7328));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(7128),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(6602));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(6583),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(5852));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatBotQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(5006),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(3650));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnInitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(4618),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnFinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(2249),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(1840));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(4046),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(8748));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(3894),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(2135));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryEducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(3235),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(1361));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryCommittees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(2622),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(559));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoriesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(2005),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(9719));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(4455),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(2889));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardStatistics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(1310),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(8942));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardSponsors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(777),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(8235));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardPublications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(294),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(7571));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeTableNames",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(8728),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(2948));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeOperations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(8251),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(2223));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeDataTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(7766),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(1518));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(9246),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(6148));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(8722),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(5436));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(8169),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(4647));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScalesCriterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(7565),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(3822));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(6981),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(2997));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(2679),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(6871));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationResults",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(6425),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(2213));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(3373),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(7820));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AppVersions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(1942),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(6002));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Albums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(925),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(4542));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Agendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(392),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(3822));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(9096),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(2222));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(8471),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(1216));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderTableValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(7893),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(451));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(7329),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(2093),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(3226));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(6791),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(8905));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(6253),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(8187));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(5604),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(7429));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(4944),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(6689));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(4184),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(5894));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(3636),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(5104));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(2916),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(4247));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Achievements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(1435),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(2389));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutAwardPage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 828, DateTimeKind.Utc).AddTicks(9971),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(685));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WorkflowQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(4391),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(5524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 354, DateTimeKind.Utc).AddTicks(3635),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 837, DateTimeKind.Utc).AddTicks(1927));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponseAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 354, DateTimeKind.Utc).AddTicks(4417),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 837, DateTimeKind.Utc).AddTicks(2491));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VirtualTableForSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(3055),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(9837));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(3780),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(6394));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserTokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(2112),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(9207));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UsersRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(1338),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(8646));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(581),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(8111));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(5398),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(8940));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 354, DateTimeKind.Utc).AddTicks(2837),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 837, DateTimeKind.Utc).AddTicks(1348));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 354, DateTimeKind.Utc).AddTicks(2049),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 837, DateTimeKind.Utc).AddTicks(815));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermsAndConditions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 354, DateTimeKind.Utc).AddTicks(1327),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 837, DateTimeKind.Utc).AddTicks(280));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Templates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 354, DateTimeKind.Utc).AddTicks(606),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(9763));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SwitchArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(1362),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(5822));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(8870),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(4006));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StrategicPartners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(9114),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(8718));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(8437),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(8181));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(2919),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(5741));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SocialMedias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(7771),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(7672));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SavedCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(7024),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(7057));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(8982),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(7060));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RolePermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(9802),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(7583));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RoleMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(6168),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(6467));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rewards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(5311),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(5927));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ResponsibilitiesUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(4553),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(5384));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Responsibilities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(3816),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(4842));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(2319),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(3751));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccountRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(3077),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(4305));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ReferenceSources",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(1600),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(3235));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(828),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(2674));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Personalnvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(8072),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(3480));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Permissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(7085),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(6018));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PermissionHeaders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(8042),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(6563));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(7698),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(453));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructureImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(9935),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(2068));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(9180),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(1529));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OurGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(1551),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(646));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OnePageText",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(6773),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(9947));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NotificationTemplates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(6124),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(9461));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Notifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(4647),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(8410));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsTickers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(4010),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(7937));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(3277),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(7347));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(2598),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(6806));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(2982),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(1577));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(1897),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(6174));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Meetings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(1205),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(5636));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(464),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(5119));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LogUserActions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(9611),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(4536));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(3531),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(213));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(4253),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(734));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeParticipants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(6551),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(2376));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeNoteAndQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(5739),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(1792));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(5003),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(1263));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Instructions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(2841),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(9721));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(502),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(5215));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 352, DateTimeKind.Utc).AddTicks(8439),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(975));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HomePageSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(6362),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(5457));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GroupInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 351, DateTimeKind.Utc).AddTicks(7336),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 835, DateTimeKind.Utc).AddTicks(2943));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(5668),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(4979));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(4318),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(4016));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(5015),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(4507));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Galleries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(5283),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(1434));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FrequentlyAskedQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(1070),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(1701));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(3496),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(3446));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(2662),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(2835));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(314),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(1176));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(9537),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(643));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(8814),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(133));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryGuides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(8103),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(9637));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(7394),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(9128));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EntitiesCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(4620),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(7031));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(2154),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(1026));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(1300),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(454));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalInstitutions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(6689),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(8609));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(5988),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(8087));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(5349),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(7585));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(1304),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(4402));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeTableValue",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(535),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(3873));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(9773),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(3347));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(6722),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(1258));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(9005),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(2812));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(8268),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(2309));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(7510),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(1802));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 349, DateTimeKind.Utc).AddTicks(2104),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(5103));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DigitalSignatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(783),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(7243));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(5865),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(664));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(4928),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 833, DateTimeKind.Utc).AddTicks(40));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Dependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(3865),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(9318));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cycles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(42),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(6735));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(9285),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(6202));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 353, DateTimeKind.Utc).AddTicks(9857),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 836, DateTimeKind.Utc).AddTicks(9257));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleCondition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(8498),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(5625));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Criterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(6897),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(4493));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(5254),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(3131));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(6069),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(3871));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(7717),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(5067));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Coordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(4530),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(2616));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CoordinatorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(3754),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(2096));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 347, DateTimeKind.Utc).AddTicks(500),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(9892));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(6865),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(9775));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Committees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(9711),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(9350));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(8935),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(8801));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Circulars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(5099),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(6058));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(8144),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(8237));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularChairmans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(7328),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(7662));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(6602),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(7128));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(5852),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(6583));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatBotQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(3650),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(5006));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnInitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(9632),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(4618));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnFinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 350, DateTimeKind.Utc).AddTicks(1840),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 834, DateTimeKind.Utc).AddTicks(2249));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(8748),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(4046));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(2135),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(3894));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryEducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(1361),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(3235));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryCommittees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(559),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(2622));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoriesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(9719),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(2005));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 346, DateTimeKind.Utc).AddTicks(2889),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(4455));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardStatistics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(8942),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(1310));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardSponsors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(8235),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(777));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardPublications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(7571),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 831, DateTimeKind.Utc).AddTicks(294));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeTableNames",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(2948),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(8728));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeOperations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(2223),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(8251));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeDataTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 348, DateTimeKind.Utc).AddTicks(1518),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 832, DateTimeKind.Utc).AddTicks(7766));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(6148),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(9246));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(5436),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(8722));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(4647),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(8169));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScalesCriterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(3822),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(7565));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(2997),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(6981));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(6871),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(2679));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationResults",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 345, DateTimeKind.Utc).AddTicks(2213),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(6425));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(7820),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(3373));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AppVersions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(6002),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(1942));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Albums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(4542),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(925));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Agendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(3822),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 830, DateTimeKind.Utc).AddTicks(392));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(2222),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(9096));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(1216),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(8471));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderTableValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 344, DateTimeKind.Utc).AddTicks(451),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(7893));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(9632),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(7329));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(3226),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(2093));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(8905),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(6791));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(8187),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(6253));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(7429),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(5604));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(6689),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(4944));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(5894),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(4184));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(5104),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(3636));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(4247),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(2916));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Achievements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(2389),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 829, DateTimeKind.Utc).AddTicks(1435));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutAwardPage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 343, DateTimeKind.Utc).AddTicks(685),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 22, 12, 23, 57, 828, DateTimeKind.Utc).AddTicks(9971));

            migrationBuilder.CreateTable(
                name: "AAAs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 1, 22, 12, 22, 37, 342, DateTimeKind.Utc).AddTicks(9864)),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AAAs", x => x.Id);
                });
        }
    }
}
