using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Api.Migrations
{
    /// <inheritdoc />
    public partial class UpdateOnTable_ExtraAttachments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WorkflowQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(9412),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(5940));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(7566),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(6677));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponseAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(8230),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(7333));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VirtualTableForSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(9367),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(7389));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(7299),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(2321));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserTokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 447, DateTimeKind.Utc).AddTicks(7428),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(8216));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UsersRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 447, DateTimeKind.Utc).AddTicks(6425),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(7600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 447, DateTimeKind.Utc).AddTicks(4434),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(6318));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(9932),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNoteOnFormForArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(7074),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(4549));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 447, DateTimeKind.Utc).AddTicks(5464),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(6918));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(6863),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(5979));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(6211),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(5380));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(5609),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(4780));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermsAndConditions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(4353),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(3503));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermAndConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(4961),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(4150));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Templates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(3780),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(2898));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SwitchArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(6319),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(3883));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubcommitteeCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(2019),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(9088));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(4203),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(3986));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StrategicPartners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(2505),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(1703));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(1875),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(1122));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(6548),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(1632));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SocialMedias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(1296),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(572));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SavedCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(645),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(9954));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 447, DateTimeKind.Utc).AddTicks(2489),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(5112));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RolePermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 447, DateTimeKind.Utc).AddTicks(3527),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(5717));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RoleMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(9889),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(9267));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rewards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(9244),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(8609));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ResponsibilitiesUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(8574),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(7942));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Responsibilities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(7942),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(7312));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RequestForChangeInterviewEligibilityStatuses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(5381),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(4811));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(6653),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(6016));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccountRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(7308),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(6677));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ReferenceSources",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(6039),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(5407));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(4648),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(4091));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Personalnvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(3578),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(3197));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Permissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 447, DateTimeKind.Utc).AddTicks(640),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(3970));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PermissionHeaders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 447, DateTimeKind.Utc).AddTicks(1591),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(4566));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(1852),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(1375));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructureImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(3827),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(3331));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(3144),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(2688));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OurGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 439, DateTimeKind.Utc).AddTicks(8470),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 91, DateTimeKind.Utc).AddTicks(7360));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OnePageText",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(1270),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(769));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NotificationTemplates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(624),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(128));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Notifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(9255),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(8834));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsTickers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(8637),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(8265));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(7950),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(7679));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(7264),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(7109));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(7745),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(3719));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(6651),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(6503));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Meetings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(6072),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(5906));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(5451),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(5279));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LogUserActions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(4815),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(4632));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 447, DateTimeKind.Utc).AddTicks(9122),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(9373));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 447, DateTimeKind.Utc).AddTicks(9793),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(9970));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeParticipants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(2045),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(1870));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeNoteAndQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(1218),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(1190));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(585),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(578));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Instructions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 447, DateTimeKind.Utc).AddTicks(8109),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(8803));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(5586),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(3152));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(2459),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(1997));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HomePageSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(9651),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(3375));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GroupInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(2863),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(2556));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(8651),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(2796));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(7358),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(1658));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(7994),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(2248));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Galleries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(1244),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(9113));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FrequentlyAskedQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(4275),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(8928));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(6423),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(986));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(5648),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(278));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(3613),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(8322));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(2308),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(7107));

            migrationBuilder.AddColumn<bool>(
                name: "isAccepted",
                table: "ExtraAttachments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(2959),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(7706));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(1638),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(6524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryGuides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(1046),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(5945));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(421),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(5349));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EntitiesCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(8026),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(3006));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(7100),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(3073));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(6415),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(2410));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalInstitutions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(9808),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(4731));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(9196),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(4174));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(8651),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(3602));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(5163),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(245));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeTableValue",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(4537),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(9641));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(3917),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(9014));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(1387),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(6566));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(3283),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(8381));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(2676),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(7790));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(2028),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(7199));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(5819),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(931));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DigitalSignatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(6336),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(1873));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(685),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(5872));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(9896),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(5086));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Dependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(8838),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(4224));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cycles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(5720),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(1277));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(5055),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(644));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(4410),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(3));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(3211),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(2320));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleCondition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(3780),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(9405));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Criterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(1748),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(7481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(9639),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(5513));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(1057),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(6841));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(384),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(6176));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(3122),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(8799));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(2463),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(8172));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Coordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(9018),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(4920));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CoordinatorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(8383),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(4328));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(5773),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(1726));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(2805),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(9783));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Committees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(5063),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(1084));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(3688),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(9788));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteeOfficers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(4403),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(448));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Circulars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(78),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(6526));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(2990),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(9140));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularChairmans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(2204),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(8437));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(1546),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(7811));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(729),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(7130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatBotQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(8772),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(5330));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnInitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(4865),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(2469));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnFinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(4943),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(9593));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(4127),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(1827));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(7415),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(4080));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryEducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(6753),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(3439));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryCommittees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(6023),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(2788));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoriesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(5348),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(2143));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(8121),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(4726));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardStatistics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(4700),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(1495));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardSponsors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(4041),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(907));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardPublications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(3458),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(363));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeTableNames",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(8095),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(3540));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeOperations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(7511),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(3002));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeDataTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(6944),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(2459));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(1370),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(8491));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(635),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(7887));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(9952),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(7246));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScalesCriterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(9216),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(6564));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(8499),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(5880));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(2550),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(347));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationResults",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(7801),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(5237));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(3358),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(1091));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AppVersions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(1844),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(9689));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Albums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(632),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(8539));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Agendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(2),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(7970));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(8545),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(7752),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(5937));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderTableValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(6999),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(5225));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(6333),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(4557));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(89),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 91, DateTimeKind.Utc).AddTicks(8898));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(5667),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(3910));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(5034),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(3306));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(4370),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(2712));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(3680),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(2038));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(2668),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(1193));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(1981),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(537));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(1065),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 91, DateTimeKind.Utc).AddTicks(9760));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Achievements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 439, DateTimeKind.Utc).AddTicks(9266),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 91, DateTimeKind.Utc).AddTicks(8124));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutAwardPage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 439, DateTimeKind.Utc).AddTicks(7657),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 91, DateTimeKind.Utc).AddTicks(6633));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isAccepted",
                table: "ExtraAttachments");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WorkflowQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(5940),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(9412));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(6677),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(7566));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponseAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(7333),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(8230));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VirtualTableForSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(7389),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(9367));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(2321),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(7299));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserTokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(8216),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 447, DateTimeKind.Utc).AddTicks(7428));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UsersRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(7600),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 447, DateTimeKind.Utc).AddTicks(6425));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(6318),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 447, DateTimeKind.Utc).AddTicks(4434));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(9512),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(9932));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNoteOnFormForArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(4549),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(7074));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(6918),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 447, DateTimeKind.Utc).AddTicks(5464));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(5979),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(6863));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(5380),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(6211));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(4780),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(5609));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermsAndConditions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(3503),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(4353));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermAndConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(4150),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(4961));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Templates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(2898),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(3780));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SwitchArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(3883),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(6319));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubcommitteeCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(9088),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(2019));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(3986),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(4203));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StrategicPartners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(1703),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(2505));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(1122),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(1875));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(1632),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(6548));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SocialMedias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(572),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(1296));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SavedCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(9954),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(645));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(5112),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 447, DateTimeKind.Utc).AddTicks(2489));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RolePermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(5717),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 447, DateTimeKind.Utc).AddTicks(3527));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RoleMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(9267),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(9889));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rewards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(8609),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(9244));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ResponsibilitiesUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(7942),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(8574));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Responsibilities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(7312),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(7942));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RequestForChangeInterviewEligibilityStatuses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(4811),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(5381));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(6016),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(6653));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccountRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(6677),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(7308));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ReferenceSources",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(5407),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(6039));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(4091),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(4648));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Personalnvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(3197),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(3578));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Permissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(3970),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 447, DateTimeKind.Utc).AddTicks(640));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PermissionHeaders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(4566),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 447, DateTimeKind.Utc).AddTicks(1591));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(1375),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(1852));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructureImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(3331),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(3827));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(2688),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(3144));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OurGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 91, DateTimeKind.Utc).AddTicks(7360),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 439, DateTimeKind.Utc).AddTicks(8470));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OnePageText",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(769),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(1270));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NotificationTemplates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(128),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(624));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Notifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(8834),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(9255));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsTickers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(8265),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(8637));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(7679),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(7950));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(7109),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(7264));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(3719),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(7745));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(6503),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(6651));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Meetings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(5906),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(6072));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(5279),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(5451));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LogUserActions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(4632),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(4815));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(9373),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 447, DateTimeKind.Utc).AddTicks(9122));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(9970),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 447, DateTimeKind.Utc).AddTicks(9793));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeParticipants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(1870),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(2045));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeNoteAndQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(1190),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(1218));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(578),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(585));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Instructions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(8803),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 447, DateTimeKind.Utc).AddTicks(8109));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(3152),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(5586));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(1997),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(2459));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HomePageSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(3375),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(9651));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GroupInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(2556),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(2863));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(2796),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(8651));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(1658),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(7358));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(2248),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(7994));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Galleries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(9113),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(1244));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FrequentlyAskedQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(8928),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(4275));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(986),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(6423));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(278),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(5648));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(8322),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(3613));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(7107),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(2308));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(7706),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(2959));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(6524),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(1638));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryGuides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(5945),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(1046));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(5349),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(421));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EntitiesCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(3006),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(8026));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(3073),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(7100));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(2410),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(6415));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalInstitutions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(4731),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(9808));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(4174),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(9196));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(3602),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(8651));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(245),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(5163));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeTableValue",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(9641),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(4537));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(9014),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(3917));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(6566),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(1387));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(8381),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(3283));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(7790),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(2676));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(7199),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(2028));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(931),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(5819));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DigitalSignatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(1873),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(6336));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(5872),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(685));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(5086),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(9896));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Dependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(4224),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(8838));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cycles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(1277),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(5720));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(644),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(5055));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(3),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(4410));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(2320),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(3211));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleCondition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(9405),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(3780));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Criterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(7481),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(1748));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(5513),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(9639));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(6841),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(1057));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(6176),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(384));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(8799),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(3122));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(8172),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(2463));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Coordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(4920),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(9018));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CoordinatorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(4328),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(8383));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(1726),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(5773));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(9783),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(2805));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Committees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(1084),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(5063));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(9788),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(3688));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteeOfficers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(448),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(4403));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Circulars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(6526),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(78));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(9140),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(2990));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularChairmans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(8437),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(2204));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(7811),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(1546));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(7130),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(729));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatBotQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(5330),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(8772));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnInitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(2469),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(4865));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnFinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(9593),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(4943));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(1827),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(4127));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(4080),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(7415));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryEducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(3439),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(6753));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryCommittees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(2788),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(6023));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoriesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(2143),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(5348));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(4726),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(8121));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardStatistics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(1495),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(4700));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardSponsors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(907),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(4041));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardPublications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(363),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(3458));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeTableNames",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(3540),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(8095));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeOperations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(3002),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(7511));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeDataTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(2459),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(6944));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(8491),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(1370));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(7887),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(7246),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(9952));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScalesCriterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(6564),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(9216));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(5880),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(8499));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(347),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(2550));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationResults",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(5237),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(7801));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(1091),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(3358));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AppVersions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(9689),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(1844));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Albums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(8539),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(632));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Agendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(7970),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(2));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(6633),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(8545));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(5937),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(7752));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderTableValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(5225),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(6999));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(4557),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(6333));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 91, DateTimeKind.Utc).AddTicks(8898),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(89));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(3910),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(5667));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(3306),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(5034));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(2712),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(4370));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(2038),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(1193),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(2668));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(537),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(1981));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 91, DateTimeKind.Utc).AddTicks(9760),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(1065));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Achievements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 91, DateTimeKind.Utc).AddTicks(8124),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 439, DateTimeKind.Utc).AddTicks(9266));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutAwardPage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 91, DateTimeKind.Utc).AddTicks(6633),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 439, DateTimeKind.Utc).AddTicks(7657));
        }
    }
}
