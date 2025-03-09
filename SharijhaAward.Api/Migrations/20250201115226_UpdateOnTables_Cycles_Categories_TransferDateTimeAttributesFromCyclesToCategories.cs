using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Api.Migrations
{
    /// <inheritdoc />
    public partial class UpdateOnTables_Cycles_Categories_TransferDateTimeAttributesFromCyclesToCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FinalArbitrationEndDate",
                table: "Cycles");

            migrationBuilder.DropColumn(
                name: "FinalArbitrationStartDate",
                table: "Cycles");

            migrationBuilder.DropColumn(
                name: "InitialArbitrationEndDate",
                table: "Cycles");

            migrationBuilder.DropColumn(
                name: "InitialArbitrationStartDate",
                table: "Cycles");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WorkflowQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(5271),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(9586));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(5863),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 912, DateTimeKind.Utc).AddTicks(31));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponseAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(6438),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 912, DateTimeKind.Utc).AddTicks(846));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VirtualTableForSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(9305),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(342));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(7398),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(5286));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserTokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(1511),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(1018));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UsersRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(713),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(328));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(18),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(9643));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(1901),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(2847));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(5239),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(9319));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(4678),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(8646));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermsAndConditions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(4127),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(8018));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Templates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(3544),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(7396));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SwitchArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(5365),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(8090));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(6925),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(7091));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StrategicPartners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(2425),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(6118));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(1897),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(5496));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(6710),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(4520));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SocialMedias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(1389),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(4928));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SavedCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(811),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(4219));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(8907),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(8323));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RolePermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(9461),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(8976));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RoleMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(175),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(3430));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rewards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(9590),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(2706));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ResponsibilitiesUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(9000),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(1970));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Responsibilities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(8420),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(1029));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(7221),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(9382));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccountRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(7807),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(227));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ReferenceSources",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(6656),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(8686));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(6056),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(7883));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Personalnvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(6308),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(6435));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Permissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(7873),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(7067));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PermissionHeaders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(8407),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(7695));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(3662),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(4829));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructureImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(5414),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(7041));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(4840),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(6373));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OurGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 232, DateTimeKind.Utc).AddTicks(9906),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 901, DateTimeKind.Utc).AddTicks(8785));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OnePageText",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(3140),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(4154));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NotificationTemplates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(2516),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(3562));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Notifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(1241),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(2117));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsTickers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(753),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(1559));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(225),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(961));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(9687),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(335));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(1773),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(7257));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(9159),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(9658));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Meetings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(8629),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(9053));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(8080),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(8417));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LogUserActions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(7497),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(7738));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(2766),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(2227));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(3354),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(2861));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeParticipants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(5116),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(4999));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeNoteAndQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(4499),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(4171));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(3917),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(3503));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Instructions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(2057),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(1638));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(4668),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(7098));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(4236),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(5597));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HomePageSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(7323),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(6442));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GroupInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(5725),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(5669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(6813),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(5838));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(5791),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(4566));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(6308),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(5176));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Galleries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(941),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(2269));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FrequentlyAskedQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(2983),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(1697));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(5184),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(3874));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(4456),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(3102));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(2403),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(1056));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(1798),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(399));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(1261),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(9758));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryGuides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(719),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(9152));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(160),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(8522));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EntitiesCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(8049),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(6069));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(1192),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(6609));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(587),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(5783));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalInstitutions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(9612),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(7891));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(9077),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(7282));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(8588),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(6721));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(5490),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(3143));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeTableValue",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(4915),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(2481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(4353),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(1707));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(2110),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(9091));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(3787),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(1110));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(3224),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(404));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(2683),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(9782));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(6072),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(3831));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DigitalSignatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(7841),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(4044));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(1465),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(8371));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(797),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(7577));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Dependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(9981),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(6578));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cycles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(7287),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(3414));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(6728),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(2770));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(3001),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(6784));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleCondition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(6138),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(2108));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Criterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(4919),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(708));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(3620),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(9262));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(4267),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(9984));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(5543),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(1412));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Coordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(2919),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(8628));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CoordinatorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(2366),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(7981));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(2),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(5026));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(9585),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(3010));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Committees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(9399),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(4365));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(8819),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(3687));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Circulars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(5828),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(240));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(8205),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(2985));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularChairmans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(7590),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(2288));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(6991),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(1626));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(6378),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(978));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatBotQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(4721),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(8939));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnInitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(4055),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(6354));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnFinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(3769),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(2362));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(3452),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(5648));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(3539),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(7606));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryEducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(2941),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(6907));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryCommittees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(2347),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(6171));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoriesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(1745),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(5471));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(4165),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(8280));

            migrationBuilder.AddColumn<DateTime>(
                name: "ArbitrationAuditEndDate",
                table: "Categories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ArbitrationAuditStartDate",
                table: "Categories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FinalArbitrationEndDate",
                table: "Categories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FinalArbitrationStartDate",
                table: "Categories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InitialArbitrationEndDate",
                table: "Categories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InitialArbitrationStartDate",
                table: "Categories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SortingFormsEndDate",
                table: "Categories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SortingFormsStartDate",
                table: "Categories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardStatistics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(1165),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(4806));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardSponsors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(636),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(4196));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardPublications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(129),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(3620));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeTableNames",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(9363),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(5824));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeOperations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(8880),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(5236));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeDataTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(8382),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(4659));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(9013),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(2366));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(8466),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(1743));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(7873),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(963));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScalesCriterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(7207),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(244));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(6578),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(9511));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(2116),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(4011));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationResults",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(6001),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(8835));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(2812),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(4930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AppVersions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(1477),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(3142));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Albums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(385),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(1595));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Agendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(9866),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(985));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(8589),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(9411));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(7962),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(8617));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderTableValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(7317),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(7842));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(6707),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(7081));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(1243),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(6022),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(6356));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(5501),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(5706));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(4840),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(5050));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(4196),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(4325));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(3373),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(3499));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(2814),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(2754));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(2079),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(1469));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Achievements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(555),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 901, DateTimeKind.Utc).AddTicks(9635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutAwardPage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 232, DateTimeKind.Utc).AddTicks(9235),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 901, DateTimeKind.Utc).AddTicks(7828));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArbitrationAuditEndDate",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ArbitrationAuditStartDate",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "FinalArbitrationEndDate",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "FinalArbitrationStartDate",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "InitialArbitrationEndDate",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "InitialArbitrationStartDate",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "SortingFormsEndDate",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "SortingFormsStartDate",
                table: "Categories");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WorkflowQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(9586),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(5271));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 912, DateTimeKind.Utc).AddTicks(31),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(5863));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponseAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 912, DateTimeKind.Utc).AddTicks(846),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(6438));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VirtualTableForSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(342),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(9305));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(5286),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(7398));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserTokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(1018),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(1511));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UsersRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(328),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(713));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(9643),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(18));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(2847),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(1901));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(9319),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(5239));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(8646),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(4678));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermsAndConditions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(8018),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(4127));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Templates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(7396),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(3544));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SwitchArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(8090),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(5365));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(7091),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(6925));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StrategicPartners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(6118),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(2425));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(5496),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(1897));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(4520),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(6710));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SocialMedias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(4928),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(1389));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SavedCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(4219),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(811));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(8323),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(8907));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RolePermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(8976),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(9461));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RoleMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(3430),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(175));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rewards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(2706),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ResponsibilitiesUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(1970),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(9000));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Responsibilities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(1029),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(8420));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(9382),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(7221));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccountRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(227),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(7807));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ReferenceSources",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(8686),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(6656));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(7883),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(6056));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Personalnvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(6435),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(6308));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Permissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(7067),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(7873));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PermissionHeaders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(7695),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(8407));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(4829),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(3662));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructureImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(7041),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(5414));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(6373),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(4840));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OurGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 901, DateTimeKind.Utc).AddTicks(8785),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 232, DateTimeKind.Utc).AddTicks(9906));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OnePageText",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(4154),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(3140));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NotificationTemplates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(3562),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(2516));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Notifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(2117),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(1241));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsTickers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(1559),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(753));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(961),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(225));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(335),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(9687));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(7257),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(1773));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(9658),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(9159));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Meetings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(9053),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(8629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(8417),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(8080));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LogUserActions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(7738),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(7497));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(2227),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(2766));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(2861),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(3354));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeParticipants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(4999),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(5116));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeNoteAndQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(4171),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(4499));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(3503),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(3917));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Instructions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(1638),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(2057));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(7098),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(4668));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 910, DateTimeKind.Utc).AddTicks(5597),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 240, DateTimeKind.Utc).AddTicks(4236));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HomePageSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(6442),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(7323));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GroupInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 909, DateTimeKind.Utc).AddTicks(5669),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 239, DateTimeKind.Utc).AddTicks(5725));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(5838),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(6813));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(4566),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(5791));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(5176),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(6308));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Galleries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(2269),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(941));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FrequentlyAskedQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(1697),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(2983));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(3874),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(5184));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(3102),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(4456));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(1056),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(2403));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(399),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(1798));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(9758),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(1261));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryGuides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(9152),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(719));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(8522),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(160));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EntitiesCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(6069),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(8049));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(6609),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(1192));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(5783),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(587));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalInstitutions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(7891),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(9612));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(7282),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(9077));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(6721),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(8588));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(3143),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(5490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeTableValue",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(2481),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(4915));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(1707),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(4353));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(9091),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(2110));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(1110),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(3787));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(404),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(3224));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(9782),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(2683));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 907, DateTimeKind.Utc).AddTicks(3831),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(6072));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DigitalSignatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(4044),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(7841));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(8371),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(1465));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(7577),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 237, DateTimeKind.Utc).AddTicks(797));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Dependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(6578),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(9981));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cycles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(3414),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(7287));

            migrationBuilder.AddColumn<DateTime>(
                name: "FinalArbitrationEndDate",
                table: "Cycles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FinalArbitrationStartDate",
                table: "Cycles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InitialArbitrationEndDate",
                table: "Cycles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InitialArbitrationStartDate",
                table: "Cycles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(2770),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(6728));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 911, DateTimeKind.Utc).AddTicks(6784),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 241, DateTimeKind.Utc).AddTicks(3001));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleCondition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(2108),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(6138));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Criterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(708),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(4919));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(9262),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(3620));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(9984),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(4267));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(1412),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(5543));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Coordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(8628),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(2919));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CoordinatorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(7981),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(2366));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(5026),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(2));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(3010),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(9585));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Committees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(4365),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(9399));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(3687),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(8819));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Circulars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(240),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(5828));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(2985),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(8205));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularChairmans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(2288),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(7590));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(1626),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(6991));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 905, DateTimeKind.Utc).AddTicks(978),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(6378));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatBotQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(8939),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(4721));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnInitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(6354),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(4055));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnFinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 908, DateTimeKind.Utc).AddTicks(2362),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 238, DateTimeKind.Utc).AddTicks(3769));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(5648),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(3452));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(7606),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(3539));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryEducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(6907),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(2941));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryCommittees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(6171),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(2347));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoriesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(5471),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(1745));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(8280),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(4165));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardStatistics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(4806),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(1165));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardSponsors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(4196),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(636));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardPublications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(3620),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 235, DateTimeKind.Utc).AddTicks(129));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeTableNames",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(5824),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(9363));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeOperations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(5236),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(8880));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeDataTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 906, DateTimeKind.Utc).AddTicks(4659),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 236, DateTimeKind.Utc).AddTicks(8382));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(2366),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(9013));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(1743),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(8466));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(963),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(7873));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScalesCriterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 904, DateTimeKind.Utc).AddTicks(244),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(7207));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(9511),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(6578));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(4011),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(2116));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationResults",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(8835),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(6001));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(4930),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(2812));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AppVersions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(3142),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(1477));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Albums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(1595),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 234, DateTimeKind.Utc).AddTicks(385));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Agendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 903, DateTimeKind.Utc).AddTicks(985),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(9866));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(9411),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(8589));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(8617),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(7962));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderTableValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(7842),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(7317));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(7081),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(6707));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(481),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(1243));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(6356),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(6022));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(5706),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(5501));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(5050),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(4840));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(4325),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(4196));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(3499),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(3373));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(2754),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(2814));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 902, DateTimeKind.Utc).AddTicks(1469),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(2079));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Achievements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 901, DateTimeKind.Utc).AddTicks(9635),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 233, DateTimeKind.Utc).AddTicks(555));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutAwardPage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 23, 11, 3, 23, 901, DateTimeKind.Utc).AddTicks(7828),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 11, 52, 25, 232, DateTimeKind.Utc).AddTicks(9235));
        }
    }
}
