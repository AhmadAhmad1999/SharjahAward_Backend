using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Api.Migrations
{
    /// <inheritdoc />
    public partial class CreateNewTables_CriterionAttachmentTypes_CriterionItemAttachmentTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AttachmentType",
                table: "Criterions");

            migrationBuilder.DropColumn(
                name: "AttachmentType",
                table: "CriterionItems");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WorkflowQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 833, DateTimeKind.Utc).AddTicks(557),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(825));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 841, DateTimeKind.Utc).AddTicks(5696),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 913, DateTimeKind.Utc).AddTicks(2669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponseAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 841, DateTimeKind.Utc).AddTicks(6453),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 913, DateTimeKind.Utc).AddTicks(4255));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VirtualTableForSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 830, DateTimeKind.Utc).AddTicks(7671),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(8874));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 836, DateTimeKind.Utc).AddTicks(6044),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(1763));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserTokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 838, DateTimeKind.Utc).AddTicks(4297),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(77));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UsersRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 838, DateTimeKind.Utc).AddTicks(3462),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(9272));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 838, DateTimeKind.Utc).AddTicks(2660),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(8490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 839, DateTimeKind.Utc).AddTicks(7285),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(3815));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 841, DateTimeKind.Utc).AddTicks(4927),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 911, DateTimeKind.Utc).AddTicks(2459));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 841, DateTimeKind.Utc).AddTicks(4182),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 911, DateTimeKind.Utc).AddTicks(1719));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermsAndConditions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 841, DateTimeKind.Utc).AddTicks(2743),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 911, DateTimeKind.Utc).AddTicks(200));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermAndConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 841, DateTimeKind.Utc).AddTicks(3421),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 911, DateTimeKind.Utc).AddTicks(938));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Templates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 841, DateTimeKind.Utc).AddTicks(2064),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(9484));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SwitchArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 831, DateTimeKind.Utc).AddTicks(5143),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(7111));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 839, DateTimeKind.Utc).AddTicks(1027),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(7126));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StrategicPartners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 841, DateTimeKind.Utc).AddTicks(665),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(8013));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 840, DateTimeKind.Utc).AddTicks(9971),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(7318));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 836, DateTimeKind.Utc).AddTicks(5199),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(876));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SocialMedias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 840, DateTimeKind.Utc).AddTicks(9333),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(6649));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SavedCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 840, DateTimeKind.Utc).AddTicks(8602),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(5852));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 838, DateTimeKind.Utc).AddTicks(1113),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(6941));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RolePermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 838, DateTimeKind.Utc).AddTicks(1893),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(7712));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RoleMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 840, DateTimeKind.Utc).AddTicks(7746),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(4914));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rewards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 840, DateTimeKind.Utc).AddTicks(6977),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(4137));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ResponsibilitiesUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 840, DateTimeKind.Utc).AddTicks(6235),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(3305));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Responsibilities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 840, DateTimeKind.Utc).AddTicks(5499),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(2462));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 840, DateTimeKind.Utc).AddTicks(3983),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(853));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccountRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 840, DateTimeKind.Utc).AddTicks(4736),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(1679));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ReferenceSources",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 840, DateTimeKind.Utc).AddTicks(3239),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(105));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 840, DateTimeKind.Utc).AddTicks(2466),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(9253));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Personalnvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 839, DateTimeKind.Utc).AddTicks(292),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(6360));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Permissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 837, DateTimeKind.Utc).AddTicks(9734),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(5458));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PermissionHeaders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 838, DateTimeKind.Utc).AddTicks(433),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(6214));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 839, DateTimeKind.Utc).AddTicks(9422),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(6008));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructureImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 840, DateTimeKind.Utc).AddTicks(1623),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(8363));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 840, DateTimeKind.Utc).AddTicks(894),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(7552));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OurGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 829, DateTimeKind.Utc).AddTicks(6648),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 899, DateTimeKind.Utc).AddTicks(6736));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OnePageText",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 839, DateTimeKind.Utc).AddTicks(8715),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(5295));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NotificationTemplates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 839, DateTimeKind.Utc).AddTicks(8040),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(4612));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Notifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 839, DateTimeKind.Utc).AddTicks(6562),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(3055));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsTickers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 839, DateTimeKind.Utc).AddTicks(5929),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(2411));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 839, DateTimeKind.Utc).AddTicks(5263),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(1705));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 839, DateTimeKind.Utc).AddTicks(4606),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(991));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 834, DateTimeKind.Utc).AddTicks(2839),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(9792));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 839, DateTimeKind.Utc).AddTicks(3926),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(232));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Meetings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 839, DateTimeKind.Utc).AddTicks(3243),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(9527));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 839, DateTimeKind.Utc).AddTicks(2521),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(8742));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LogUserActions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 839, DateTimeKind.Utc).AddTicks(1775),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(7921));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 838, DateTimeKind.Utc).AddTicks(5736),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(1538));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 838, DateTimeKind.Utc).AddTicks(6448),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(2288));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeParticipants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 838, DateTimeKind.Utc).AddTicks(8746),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(4726));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeNoteAndQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 838, DateTimeKind.Utc).AddTicks(7954),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(3856));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 838, DateTimeKind.Utc).AddTicks(7190),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(3086));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Instructions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 838, DateTimeKind.Utc).AddTicks(5028),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(812));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 831, DateTimeKind.Utc).AddTicks(4330),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(6213));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 840, DateTimeKind.Utc).AddTicks(157),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(6761));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HomePageSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 837, DateTimeKind.Utc).AddTicks(8995),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(4745));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GroupInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 838, DateTimeKind.Utc).AddTicks(9520),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(5584));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 837, DateTimeKind.Utc).AddTicks(8303),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(4067));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 837, DateTimeKind.Utc).AddTicks(6937),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(2657));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 837, DateTimeKind.Utc).AddTicks(7643),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(3374));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Galleries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 830, DateTimeKind.Utc).AddTicks(9699),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(1056));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FrequentlyAskedQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 837, DateTimeKind.Utc).AddTicks(3638),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(9281));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 837, DateTimeKind.Utc).AddTicks(6134),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(1848));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 837, DateTimeKind.Utc).AddTicks(5243),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(952));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 837, DateTimeKind.Utc).AddTicks(2793),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(8523));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 837, DateTimeKind.Utc).AddTicks(2042),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(7747));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 837, DateTimeKind.Utc).AddTicks(1315),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(6988));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryGuides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 837, DateTimeKind.Utc).AddTicks(586),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(6291));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 836, DateTimeKind.Utc).AddTicks(9855),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(5558));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EntitiesCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 836, DateTimeKind.Utc).AddTicks(6868),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(2638));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 834, DateTimeKind.Utc).AddTicks(1724),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(8934));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 834, DateTimeKind.Utc).AddTicks(528),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(8086));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalInstitutions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 836, DateTimeKind.Utc).AddTicks(9092),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(4813));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 836, DateTimeKind.Utc).AddTicks(8367),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(4059));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 836, DateTimeKind.Utc).AddTicks(7653),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(3421));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 836, DateTimeKind.Utc).AddTicks(3630),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(9217));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeTableValue",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 836, DateTimeKind.Utc).AddTicks(2883),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(8432));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 836, DateTimeKind.Utc).AddTicks(2136),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(7676));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 835, DateTimeKind.Utc).AddTicks(9239),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(4617));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 836, DateTimeKind.Utc).AddTicks(1379),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(6877));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 836, DateTimeKind.Utc).AddTicks(711),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(6145));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 836, DateTimeKind.Utc).AddTicks(4),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(5412));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 836, DateTimeKind.Utc).AddTicks(4401),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(55));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DigitalSignatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 835, DateTimeKind.Utc).AddTicks(3523),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(8697));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 835, DateTimeKind.Utc).AddTicks(8398),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(3729));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 835, DateTimeKind.Utc).AddTicks(7465),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(2767));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Dependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 835, DateTimeKind.Utc).AddTicks(6370),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(1693));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cycles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 835, DateTimeKind.Utc).AddTicks(2790),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(7846));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 835, DateTimeKind.Utc).AddTicks(2020),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(7008));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 835, DateTimeKind.Utc).AddTicks(1251),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(6221));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 841, DateTimeKind.Utc).AddTicks(1390),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(8768));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleCondition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 835, DateTimeKind.Utc).AddTicks(382),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(5424));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Criterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 834, DateTimeKind.Utc).AddTicks(7849),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(3810));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 834, DateTimeKind.Utc).AddTicks(5393),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(2161));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 834, DateTimeKind.Utc).AddTicks(6227),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(2977));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 834, DateTimeKind.Utc).AddTicks(8666),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(4636));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Coordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 834, DateTimeKind.Utc).AddTicks(4655),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(1381));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CoordinatorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 834, DateTimeKind.Utc).AddTicks(3916),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(608));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 833, DateTimeKind.Utc).AddTicks(9410),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(7276));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 832, DateTimeKind.Utc).AddTicks(532),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(2853));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Committees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 833, DateTimeKind.Utc).AddTicks(8311),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(6484));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 833, DateTimeKind.Utc).AddTicks(7083),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(5697));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Circulars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 833, DateTimeKind.Utc).AddTicks(1679),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(1633));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 833, DateTimeKind.Utc).AddTicks(5973),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(4857));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularChairmans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 833, DateTimeKind.Utc).AddTicks(4839),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(3993));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 833, DateTimeKind.Utc).AddTicks(3786),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(3204));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 833, DateTimeKind.Utc).AddTicks(2717),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(2410));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatBotQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 832, DateTimeKind.Utc).AddTicks(9365),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(67));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnInitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 831, DateTimeKind.Utc).AddTicks(3512),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(5309));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnFinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 837, DateTimeKind.Utc).AddTicks(4395),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(70));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 831, DateTimeKind.Utc).AddTicks(2761),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(4486));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 832, DateTimeKind.Utc).AddTicks(6862),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(8476));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryEducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 832, DateTimeKind.Utc).AddTicks(5773),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(7673));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryCommittees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 832, DateTimeKind.Utc).AddTicks(4908),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(6795));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoriesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 832, DateTimeKind.Utc).AddTicks(4070),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(5955));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 832, DateTimeKind.Utc).AddTicks(8130),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(9294));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardStatistics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 832, DateTimeKind.Utc).AddTicks(3195),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(5071));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardSponsors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 832, DateTimeKind.Utc).AddTicks(1910),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(4339));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardPublications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 832, DateTimeKind.Utc).AddTicks(1205),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(3608));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeTableNames",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 835, DateTimeKind.Utc).AddTicks(5553),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(808));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeOperations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 835, DateTimeKind.Utc).AddTicks(4915),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(139));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeDataTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 835, DateTimeKind.Utc).AddTicks(4247),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(9451));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 831, DateTimeKind.Utc).AddTicks(9807),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(2134));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 831, DateTimeKind.Utc).AddTicks(9092),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(1407));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 831, DateTimeKind.Utc).AddTicks(8332),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(587));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScalesCriterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 831, DateTimeKind.Utc).AddTicks(7487),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(9727));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 831, DateTimeKind.Utc).AddTicks(6688),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(8822));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 831, DateTimeKind.Utc).AddTicks(1133),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(2624));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationResults",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 831, DateTimeKind.Utc).AddTicks(5943),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(8043));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 831, DateTimeKind.Utc).AddTicks(1989),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(3567));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AppVersions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 831, DateTimeKind.Utc).AddTicks(335),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(1781));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Albums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 830, DateTimeKind.Utc).AddTicks(9014),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(322));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Agendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 830, DateTimeKind.Utc).AddTicks(8362),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(9616));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 830, DateTimeKind.Utc).AddTicks(6797),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(7930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 830, DateTimeKind.Utc).AddTicks(6024),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(6955));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderTableValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 830, DateTimeKind.Utc).AddTicks(5223),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(6089));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 830, DateTimeKind.Utc).AddTicks(4496),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(5289));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 829, DateTimeKind.Utc).AddTicks(8288),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 899, DateTimeKind.Utc).AddTicks(8465));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 830, DateTimeKind.Utc).AddTicks(3806),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(4518));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 830, DateTimeKind.Utc).AddTicks(3132),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(3777));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 830, DateTimeKind.Utc).AddTicks(2468),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(3045));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 830, DateTimeKind.Utc).AddTicks(1667),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(2238));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 830, DateTimeKind.Utc).AddTicks(848),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(1294));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 830, DateTimeKind.Utc).AddTicks(126),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(526));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 829, DateTimeKind.Utc).AddTicks(9228),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 899, DateTimeKind.Utc).AddTicks(9536));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Achievements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 829, DateTimeKind.Utc).AddTicks(7477),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 899, DateTimeKind.Utc).AddTicks(7583));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutAwardPage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 829, DateTimeKind.Utc).AddTicks(5807),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 899, DateTimeKind.Utc).AddTicks(5858));

            migrationBuilder.CreateTable(
                name: "CriterionItemAttachmentType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriterionId = table.Column<int>(type: "int", nullable: false),
                    AttachmentType = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 834, DateTimeKind.Utc).AddTicks(9573)),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CriterionItemAttachmentType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CriterionItemAttachmentType_Criterions_CriterionId",
                        column: x => x.CriterionId,
                        principalTable: "Criterions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CriterionItemAttachmentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriterionItemId = table.Column<int>(type: "int", nullable: false),
                    AttachmentType = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 834, DateTimeKind.Utc).AddTicks(6999)),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CriterionItemAttachmentTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CriterionItemAttachmentTypes_CriterionItems_CriterionItemId",
                        column: x => x.CriterionItemId,
                        principalTable: "CriterionItems",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CriterionItemAttachmentType_CriterionId",
                table: "CriterionItemAttachmentType",
                column: "CriterionId");

            migrationBuilder.CreateIndex(
                name: "IX_CriterionItemAttachmentTypes_CriterionItemId",
                table: "CriterionItemAttachmentTypes",
                column: "CriterionItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CriterionItemAttachmentType");

            migrationBuilder.DropTable(
                name: "CriterionItemAttachmentTypes");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WorkflowQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(825),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 833, DateTimeKind.Utc).AddTicks(557));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 913, DateTimeKind.Utc).AddTicks(2669),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 841, DateTimeKind.Utc).AddTicks(5696));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponseAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 913, DateTimeKind.Utc).AddTicks(4255),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 841, DateTimeKind.Utc).AddTicks(6453));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VirtualTableForSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(8874),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 830, DateTimeKind.Utc).AddTicks(7671));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(1763),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 836, DateTimeKind.Utc).AddTicks(6044));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserTokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(77),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 838, DateTimeKind.Utc).AddTicks(4297));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UsersRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(9272),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 838, DateTimeKind.Utc).AddTicks(3462));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(8490),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 838, DateTimeKind.Utc).AddTicks(2660));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(3815),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 839, DateTimeKind.Utc).AddTicks(7285));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 911, DateTimeKind.Utc).AddTicks(2459),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 841, DateTimeKind.Utc).AddTicks(4927));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 911, DateTimeKind.Utc).AddTicks(1719),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 841, DateTimeKind.Utc).AddTicks(4182));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermsAndConditions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 911, DateTimeKind.Utc).AddTicks(200),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 841, DateTimeKind.Utc).AddTicks(2743));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermAndConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 911, DateTimeKind.Utc).AddTicks(938),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 841, DateTimeKind.Utc).AddTicks(3421));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Templates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(9484),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 841, DateTimeKind.Utc).AddTicks(2064));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SwitchArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(7111),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 831, DateTimeKind.Utc).AddTicks(5143));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(7126),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 839, DateTimeKind.Utc).AddTicks(1027));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StrategicPartners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(8013),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 841, DateTimeKind.Utc).AddTicks(665));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(7318),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 840, DateTimeKind.Utc).AddTicks(9971));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(876),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 836, DateTimeKind.Utc).AddTicks(5199));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SocialMedias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(6649),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 840, DateTimeKind.Utc).AddTicks(9333));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SavedCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(5852),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 840, DateTimeKind.Utc).AddTicks(8602));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(6941),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 838, DateTimeKind.Utc).AddTicks(1113));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RolePermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(7712),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 838, DateTimeKind.Utc).AddTicks(1893));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RoleMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(4914),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 840, DateTimeKind.Utc).AddTicks(7746));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rewards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(4137),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 840, DateTimeKind.Utc).AddTicks(6977));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ResponsibilitiesUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(3305),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 840, DateTimeKind.Utc).AddTicks(6235));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Responsibilities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(2462),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 840, DateTimeKind.Utc).AddTicks(5499));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(853),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 840, DateTimeKind.Utc).AddTicks(3983));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccountRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(1679),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 840, DateTimeKind.Utc).AddTicks(4736));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ReferenceSources",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(105),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 840, DateTimeKind.Utc).AddTicks(3239));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(9253),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 840, DateTimeKind.Utc).AddTicks(2466));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Personalnvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(6360),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 839, DateTimeKind.Utc).AddTicks(292));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Permissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(5458),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 837, DateTimeKind.Utc).AddTicks(9734));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PermissionHeaders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(6214),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 838, DateTimeKind.Utc).AddTicks(433));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(6008),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 839, DateTimeKind.Utc).AddTicks(9422));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructureImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(8363),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 840, DateTimeKind.Utc).AddTicks(1623));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(7552),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 840, DateTimeKind.Utc).AddTicks(894));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OurGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 899, DateTimeKind.Utc).AddTicks(6736),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 829, DateTimeKind.Utc).AddTicks(6648));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OnePageText",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(5295),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 839, DateTimeKind.Utc).AddTicks(8715));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NotificationTemplates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(4612),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 839, DateTimeKind.Utc).AddTicks(8040));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Notifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(3055),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 839, DateTimeKind.Utc).AddTicks(6562));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsTickers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(2411),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 839, DateTimeKind.Utc).AddTicks(5929));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(1705),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 839, DateTimeKind.Utc).AddTicks(5263));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(991),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 839, DateTimeKind.Utc).AddTicks(4606));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(9792),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 834, DateTimeKind.Utc).AddTicks(2839));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(232),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 839, DateTimeKind.Utc).AddTicks(3926));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Meetings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(9527),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 839, DateTimeKind.Utc).AddTicks(3243));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(8742),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 839, DateTimeKind.Utc).AddTicks(2521));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LogUserActions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(7921),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 839, DateTimeKind.Utc).AddTicks(1775));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(1538),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 838, DateTimeKind.Utc).AddTicks(5736));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(2288),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 838, DateTimeKind.Utc).AddTicks(6448));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeParticipants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(4726),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 838, DateTimeKind.Utc).AddTicks(8746));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeNoteAndQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(3856),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 838, DateTimeKind.Utc).AddTicks(7954));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(3086),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 838, DateTimeKind.Utc).AddTicks(7190));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Instructions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(812),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 838, DateTimeKind.Utc).AddTicks(5028));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(6213),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 831, DateTimeKind.Utc).AddTicks(4330));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 909, DateTimeKind.Utc).AddTicks(6761),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 840, DateTimeKind.Utc).AddTicks(157));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HomePageSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(4745),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 837, DateTimeKind.Utc).AddTicks(8995));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GroupInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 908, DateTimeKind.Utc).AddTicks(5584),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 838, DateTimeKind.Utc).AddTicks(9520));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(4067),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 837, DateTimeKind.Utc).AddTicks(8303));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(2657),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 837, DateTimeKind.Utc).AddTicks(6937));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(3374),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 837, DateTimeKind.Utc).AddTicks(7643));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Galleries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(1056),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 830, DateTimeKind.Utc).AddTicks(9699));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FrequentlyAskedQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(9281),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 837, DateTimeKind.Utc).AddTicks(3638));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(1848),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 837, DateTimeKind.Utc).AddTicks(6134));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(952),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 837, DateTimeKind.Utc).AddTicks(5243));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(8523),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 837, DateTimeKind.Utc).AddTicks(2793));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(7747),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 837, DateTimeKind.Utc).AddTicks(2042));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(6988),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 837, DateTimeKind.Utc).AddTicks(1315));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryGuides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(6291),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 837, DateTimeKind.Utc).AddTicks(586));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(5558),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 836, DateTimeKind.Utc).AddTicks(9855));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EntitiesCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(2638),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 836, DateTimeKind.Utc).AddTicks(6868));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(8934),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 834, DateTimeKind.Utc).AddTicks(1724));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(8086),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 834, DateTimeKind.Utc).AddTicks(528));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalInstitutions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(4813),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 836, DateTimeKind.Utc).AddTicks(9092));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(4059),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 836, DateTimeKind.Utc).AddTicks(8367));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(3421),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 836, DateTimeKind.Utc).AddTicks(7653));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(9217),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 836, DateTimeKind.Utc).AddTicks(3630));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeTableValue",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(8432),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 836, DateTimeKind.Utc).AddTicks(2883));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(7676),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 836, DateTimeKind.Utc).AddTicks(2136));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(4617),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 835, DateTimeKind.Utc).AddTicks(9239));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(6877),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 836, DateTimeKind.Utc).AddTicks(1379));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(6145),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 836, DateTimeKind.Utc).AddTicks(711));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(5412),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 836, DateTimeKind.Utc).AddTicks(4));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 906, DateTimeKind.Utc).AddTicks(55),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 836, DateTimeKind.Utc).AddTicks(4401));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DigitalSignatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(8697),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 835, DateTimeKind.Utc).AddTicks(3523));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(3729),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 835, DateTimeKind.Utc).AddTicks(8398));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(2767),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 835, DateTimeKind.Utc).AddTicks(7465));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Dependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(1693),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 835, DateTimeKind.Utc).AddTicks(6370));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cycles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(7846),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 835, DateTimeKind.Utc).AddTicks(2790));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(7008),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 835, DateTimeKind.Utc).AddTicks(2020));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(6221),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 835, DateTimeKind.Utc).AddTicks(1251));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 910, DateTimeKind.Utc).AddTicks(8768),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 841, DateTimeKind.Utc).AddTicks(1390));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleCondition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(5424),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 835, DateTimeKind.Utc).AddTicks(382));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Criterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(3810),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 834, DateTimeKind.Utc).AddTicks(7849));

            migrationBuilder.AddColumn<int>(
                name: "AttachmentType",
                table: "Criterions",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(2161),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 834, DateTimeKind.Utc).AddTicks(5393));

            migrationBuilder.AddColumn<int>(
                name: "AttachmentType",
                table: "CriterionItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(2977),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 834, DateTimeKind.Utc).AddTicks(6227));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(4636),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 834, DateTimeKind.Utc).AddTicks(8666));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Coordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(1381),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 834, DateTimeKind.Utc).AddTicks(4655));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CoordinatorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(608),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 834, DateTimeKind.Utc).AddTicks(3916));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(7276),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 833, DateTimeKind.Utc).AddTicks(9410));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(2853),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 832, DateTimeKind.Utc).AddTicks(532));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Committees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(6484),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 833, DateTimeKind.Utc).AddTicks(8311));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(5697),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 833, DateTimeKind.Utc).AddTicks(7083));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Circulars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(1633),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 833, DateTimeKind.Utc).AddTicks(1679));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(4857),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 833, DateTimeKind.Utc).AddTicks(5973));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularChairmans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(3993),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 833, DateTimeKind.Utc).AddTicks(4839));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(3204),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 833, DateTimeKind.Utc).AddTicks(3786));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(2410),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 833, DateTimeKind.Utc).AddTicks(2717));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatBotQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 903, DateTimeKind.Utc).AddTicks(67),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 832, DateTimeKind.Utc).AddTicks(9365));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnInitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(5309),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 831, DateTimeKind.Utc).AddTicks(3512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnFinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 907, DateTimeKind.Utc).AddTicks(70),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 837, DateTimeKind.Utc).AddTicks(4395));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(4486),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 831, DateTimeKind.Utc).AddTicks(2761));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(8476),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 832, DateTimeKind.Utc).AddTicks(6862));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryEducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(7673),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 832, DateTimeKind.Utc).AddTicks(5773));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryCommittees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(6795),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 832, DateTimeKind.Utc).AddTicks(4908));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoriesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(5955),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 832, DateTimeKind.Utc).AddTicks(4070));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(9294),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 832, DateTimeKind.Utc).AddTicks(8130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardStatistics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(5071),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 832, DateTimeKind.Utc).AddTicks(3195));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardSponsors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(4339),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 832, DateTimeKind.Utc).AddTicks(1910));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardPublications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(3608),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 832, DateTimeKind.Utc).AddTicks(1205));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeTableNames",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(808),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 835, DateTimeKind.Utc).AddTicks(5553));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeOperations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 905, DateTimeKind.Utc).AddTicks(139),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 835, DateTimeKind.Utc).AddTicks(4915));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeDataTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 904, DateTimeKind.Utc).AddTicks(9451),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 835, DateTimeKind.Utc).AddTicks(4247));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(2134),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 831, DateTimeKind.Utc).AddTicks(9807));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(1407),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 831, DateTimeKind.Utc).AddTicks(9092));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 902, DateTimeKind.Utc).AddTicks(587),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 831, DateTimeKind.Utc).AddTicks(8332));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScalesCriterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(9727),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 831, DateTimeKind.Utc).AddTicks(7487));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(8822),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 831, DateTimeKind.Utc).AddTicks(6688));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(2624),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 831, DateTimeKind.Utc).AddTicks(1133));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationResults",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(8043),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 831, DateTimeKind.Utc).AddTicks(5943));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(3567),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 831, DateTimeKind.Utc).AddTicks(1989));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AppVersions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(1781),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 831, DateTimeKind.Utc).AddTicks(335));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Albums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 901, DateTimeKind.Utc).AddTicks(322),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 830, DateTimeKind.Utc).AddTicks(9014));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Agendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(9616),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 830, DateTimeKind.Utc).AddTicks(8362));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(7930),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 830, DateTimeKind.Utc).AddTicks(6797));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(6955),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 830, DateTimeKind.Utc).AddTicks(6024));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderTableValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(6089),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 830, DateTimeKind.Utc).AddTicks(5223));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(5289),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 830, DateTimeKind.Utc).AddTicks(4496));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 899, DateTimeKind.Utc).AddTicks(8465),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 829, DateTimeKind.Utc).AddTicks(8288));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(4518),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 830, DateTimeKind.Utc).AddTicks(3806));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(3777),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 830, DateTimeKind.Utc).AddTicks(3132));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(3045),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 830, DateTimeKind.Utc).AddTicks(2468));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(2238),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 830, DateTimeKind.Utc).AddTicks(1667));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(1294),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 830, DateTimeKind.Utc).AddTicks(848));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 900, DateTimeKind.Utc).AddTicks(526),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 830, DateTimeKind.Utc).AddTicks(126));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 899, DateTimeKind.Utc).AddTicks(9536),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 829, DateTimeKind.Utc).AddTicks(9228));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Achievements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 899, DateTimeKind.Utc).AddTicks(7583),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 829, DateTimeKind.Utc).AddTicks(7477));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutAwardPage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 6, 12, 15, 30, 899, DateTimeKind.Utc).AddTicks(5858),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 7, 18, 17, 14, 829, DateTimeKind.Utc).AddTicks(5807));
        }
    }
}
