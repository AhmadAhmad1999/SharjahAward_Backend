using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Api.Migrations
{
    /// <inheritdoc />
    public partial class UpdateOnTable_EducationalEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WorkflowQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(5540),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(9412));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(9090),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(7566));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponseAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(9661),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(8230));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VirtualTableForSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(8481),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(9367));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(9228),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(7299));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserTokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(3725),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 447, DateTimeKind.Utc).AddTicks(7428));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UsersRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(3167),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 447, DateTimeKind.Utc).AddTicks(6425));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(2020),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 447, DateTimeKind.Utc).AddTicks(4434));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(3718),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(9932));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNoteOnFormForArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(4960),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(7074));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(2562),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 447, DateTimeKind.Utc).AddTicks(5464));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(8481),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(6863));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(7915),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(6211));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(7371),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(5609));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermsAndConditions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(6273),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(4353));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermAndConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(6804),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(4961));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Templates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(5741),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(3780));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SwitchArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(4344),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(6319));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubcommitteeCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(9192),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(2019));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(8873),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(4203));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StrategicPartners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(4658),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(2505));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(4142),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(1875));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(8595),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(6548));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SocialMedias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(3536),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(1296));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SavedCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(2960),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(645));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(940),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 447, DateTimeKind.Utc).AddTicks(2489));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RolePermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(1478),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 447, DateTimeKind.Utc).AddTicks(3527));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RoleMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(2329),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(9889));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rewards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(1742),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(9244));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ResponsibilitiesUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(1171),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(8574));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Responsibilities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(618),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(7942));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RequestForChangeInterviewEligibilityStatuses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(8355),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(5381));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(9474),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(6653));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccountRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(53),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(7308));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ReferenceSources",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(8915),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(6039));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(7709),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(4648));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Personalnvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(8306),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(3578));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Permissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(9887),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 447, DateTimeKind.Utc).AddTicks(640));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PermissionHeaders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(430),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 447, DateTimeKind.Utc).AddTicks(1591));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(5294),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(1852));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructureImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(7056),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(3827));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(6478),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(3144));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OurGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 739, DateTimeKind.Utc).AddTicks(9598),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 439, DateTimeKind.Utc).AddTicks(8470));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OnePageText",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(4763),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(1270));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NotificationTemplates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(4269),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(624));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Notifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(3178),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(9255));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsTickers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(2684),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(8637));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(2157),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(7950));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(1620),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(7264));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(2488),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(7745));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(1092),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(6651));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Meetings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(574),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(6072));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(25),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(5451));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LogUserActions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(9458),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(4815));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(4783),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 447, DateTimeKind.Utc).AddTicks(9122));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(5308),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 447, DateTimeKind.Utc).AddTicks(9793));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeParticipants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(7000),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(2045));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeNoteAndQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(6407),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(1218));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(5856),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(585));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Instructions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(4270),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 447, DateTimeKind.Utc).AddTicks(8109));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(3728),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(5586));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(5884),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(2459));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HomePageSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(9351),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(9651));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GroupInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(7750),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(2863));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(8852),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(8651));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(7813),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(7358));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(8353),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(7994));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Galleries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(82),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(1244));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FrequentlyAskedQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(5345),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(4275));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(7214),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(6423));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(6582),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(5648));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(4803),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(3613));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(3714),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(2308));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(4255),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(2959));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(3188),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(1638));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryGuides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(2663),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(1046));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(2124),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(421));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EntitiesCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(9844),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(8026));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(1917),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(7100));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(1277),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(6415));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalInstitutions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(1592),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(9808));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(912),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(9196));

            migrationBuilder.AddColumn<int>(
                name: "CycleId",
                table: "EducationalEntities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(398),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(8651));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(7439),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(5163));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeTableValue",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(6877),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(4537));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(6331),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(3917));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(4143),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(1387));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(5767),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(3283));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(5236),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(2676));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(4710),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(2028));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(8009),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(5819));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DigitalSignatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(9879),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(6336));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(3482),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(685));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(2818),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(9896));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Dependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(2041),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(8838));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cycles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(9335),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(5720));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(8774),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(5055));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(8214),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(4410));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(5218),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(3211));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleCondition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(7670),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(3780));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Criterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(5934),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(1748));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(4203),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(9639));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(5344),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(1057));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(4780),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(384));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(7100),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(3122));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(6539),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(2463));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Coordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(3563),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(9018));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CoordinatorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(3034),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(8383));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(710),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(5773));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(9782),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(2805));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Committees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(144),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(5063));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(9002),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(3688));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteeOfficers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(9579),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(4403));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Circulars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(6087),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(78));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(8407),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(2990));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularChairmans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(7813),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(2204));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(7209),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(1546));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(6629),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(729));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatBotQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(5002),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(8772));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnInitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(3096),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(4865));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnFinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(5928),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(4943));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(2511),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(4127));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(3806),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(7415));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryEducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(3166),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(6753));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryCommittees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(2558),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(6023));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoriesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(1935),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(5348));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(4433),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(8121));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardStatistics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(1365),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(4700));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardSponsors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(831),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(4041));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardPublications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(302),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(3458));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeTableNames",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(1412),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(8095));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeOperations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(921),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(7511));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeDataTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(407),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(6944));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(8632),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(1370));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(8111),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(7536),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(9952));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScalesCriterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(6932),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(9216));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(6216),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(8499));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(1233),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(2550));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationResults",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(5563),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(7801));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(1902),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(3358));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AppVersions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(619),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(1844));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Albums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(9538),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(632));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Agendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(9013),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(2));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(7813),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(8545));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(7206),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(7752));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderTableValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(6565),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(6999));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(5975),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(6333));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(899),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(89));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(5406),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(5667));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(4885),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(5034));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(4367),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(4370));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(3709),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(2980),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(2668));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(2394),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(1981));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(1673),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(1065));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Achievements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(228),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 439, DateTimeKind.Utc).AddTicks(9266));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutAwardPage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 739, DateTimeKind.Utc).AddTicks(8927),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 439, DateTimeKind.Utc).AddTicks(7657));

            migrationBuilder.CreateIndex(
                name: "IX_EducationalEntities_CycleId",
                table: "EducationalEntities",
                column: "CycleId");

            migrationBuilder.AddForeignKey(
                name: "FK_EducationalEntities_Cycles_CycleId",
                table: "EducationalEntities",
                column: "CycleId",
                principalTable: "Cycles",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EducationalEntities_Cycles_CycleId",
                table: "EducationalEntities");

            migrationBuilder.DropIndex(
                name: "IX_EducationalEntities_CycleId",
                table: "EducationalEntities");

            migrationBuilder.DropColumn(
                name: "CycleId",
                table: "EducationalEntities");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WorkflowQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(9412),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(5540));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(7566),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(9090));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponseAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(8230),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(9661));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VirtualTableForSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(9367),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(8481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(7299),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(9228));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserTokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 447, DateTimeKind.Utc).AddTicks(7428),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(3725));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UsersRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 447, DateTimeKind.Utc).AddTicks(6425),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(3167));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 447, DateTimeKind.Utc).AddTicks(4434),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(2020));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(9932),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(3718));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNoteOnFormForArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(7074),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(4960));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 447, DateTimeKind.Utc).AddTicks(5464),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(2562));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(6863),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(8481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(6211),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(7915));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(5609),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(7371));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermsAndConditions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(4353),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(6273));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermAndConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(4961),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(6804));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Templates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(3780),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(5741));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SwitchArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(6319),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(4344));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubcommitteeCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(2019),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(9192));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(4203),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(8873));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StrategicPartners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(2505),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(4658));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(1875),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(4142));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(6548),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(8595));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SocialMedias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(1296),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(3536));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SavedCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(645),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(2960));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 447, DateTimeKind.Utc).AddTicks(2489),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(940));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RolePermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 447, DateTimeKind.Utc).AddTicks(3527),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(1478));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RoleMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(9889),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(2329));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rewards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(9244),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(1742));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ResponsibilitiesUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(8574),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(1171));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Responsibilities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(7942),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(618));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RequestForChangeInterviewEligibilityStatuses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(5381),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(8355));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(6653),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(9474));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccountRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(7308),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(53));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ReferenceSources",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(6039),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(8915));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(4648),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(7709));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Personalnvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(3578),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(8306));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Permissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 447, DateTimeKind.Utc).AddTicks(640),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(9887));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PermissionHeaders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 447, DateTimeKind.Utc).AddTicks(1591),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(430));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(1852),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(5294));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructureImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(3827),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(7056));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(3144),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(6478));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OurGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 439, DateTimeKind.Utc).AddTicks(8470),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 739, DateTimeKind.Utc).AddTicks(9598));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OnePageText",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(1270),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(4763));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NotificationTemplates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(624),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(4269));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Notifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(9255),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(3178));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsTickers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(8637),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(2684));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(7950),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(2157));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(7264),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(1620));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(7745),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(2488));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(6651),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(1092));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Meetings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(6072),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(574));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(5451),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(25));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LogUserActions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(4815),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(9458));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 447, DateTimeKind.Utc).AddTicks(9122),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(4783));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 447, DateTimeKind.Utc).AddTicks(9793),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(5308));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeParticipants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(2045),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(7000));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeNoteAndQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(1218),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(6407));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(585),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(5856));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Instructions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 447, DateTimeKind.Utc).AddTicks(8109),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(4270));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(5586),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(3728));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 449, DateTimeKind.Utc).AddTicks(2459),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(5884));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HomePageSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(9651),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(9351));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GroupInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 448, DateTimeKind.Utc).AddTicks(2863),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(7750));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(8651),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(8852));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(7358),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(7813));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(7994),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(8353));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Galleries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(1244),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(82));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FrequentlyAskedQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(4275),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(5345));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(6423),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(7214));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(5648),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(6582));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(3613),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(4803));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(2308),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(3714));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(2959),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(4255));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(1638),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(3188));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryGuides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(1046),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(2663));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(421),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(2124));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EntitiesCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(8026),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(9844));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(7100),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(1917));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(6415),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(1277));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalInstitutions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(9808),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(1592));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(9196),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(912));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(8651),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(398));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(5163),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(7439));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeTableValue",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(4537),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(6877));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(3917),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(6331));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(1387),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(4143));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(3283),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(5767));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(2676),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(5236));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(2028),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(4710));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(5819),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(8009));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DigitalSignatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(6336),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(9879));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 445, DateTimeKind.Utc).AddTicks(685),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(3482));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(9896),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(2818));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Dependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(8838),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(2041));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cycles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(5720),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(9335));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(5055),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(8774));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(4410),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(8214));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 450, DateTimeKind.Utc).AddTicks(3211),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(5218));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleCondition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(3780),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(7670));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Criterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(1748),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(5934));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(9639),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(4203));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(1057),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(5344));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(384),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(4780));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(3122),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(7100));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(2463),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(6539));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Coordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(9018),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(3563));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CoordinatorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(8383),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(3034));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(5773),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(710));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(2805),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(9782));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Committees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(5063),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(144));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(3688),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(9002));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteeOfficers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(4403),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(9579));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Circulars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(78),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(6087));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(2990),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(8407));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularChairmans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(2204),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(7813));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(1546),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(7209));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 443, DateTimeKind.Utc).AddTicks(729),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(6629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatBotQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(8772),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(5002));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnInitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(4865),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(3096));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnFinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 446, DateTimeKind.Utc).AddTicks(4943),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(5928));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(4127),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(2511));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(7415),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(3806));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryEducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(6753),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(3166));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryCommittees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(6023),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(2558));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoriesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(5348),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(1935));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(8121),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(4433));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardStatistics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(4700),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(1365));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardSponsors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(4041),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(831));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardPublications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(3458),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(302));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeTableNames",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(8095),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(1412));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeOperations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(7511),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(921));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeDataTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 444, DateTimeKind.Utc).AddTicks(6944),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(407));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(1370),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(8632));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 442, DateTimeKind.Utc).AddTicks(635),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(8111));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(9952),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(7536));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScalesCriterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(9216),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(6932));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(8499),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(6216));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(2550),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(1233));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationResults",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(7801),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(5563));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(3358),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(1902));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AppVersions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(1844),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(619));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Albums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(632),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(9538));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Agendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 441, DateTimeKind.Utc).AddTicks(2),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(9013));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(8545),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(7813));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(7752),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(7206));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderTableValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(6999),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(6565));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(6333),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(5975));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(89),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(899));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(5667),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(5406));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(5034),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(4885));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(4370),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(4367));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(3680),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(3709));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(2668),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(2980));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(1981),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(2394));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 440, DateTimeKind.Utc).AddTicks(1065),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(1673));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Achievements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 439, DateTimeKind.Utc).AddTicks(9266),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(228));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutAwardPage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 7, 49, 55, 439, DateTimeKind.Utc).AddTicks(7657),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 739, DateTimeKind.Utc).AddTicks(8927));
        }
    }
}
