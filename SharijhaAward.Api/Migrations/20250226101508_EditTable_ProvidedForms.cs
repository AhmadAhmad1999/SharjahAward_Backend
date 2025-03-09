using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Api.Migrations
{
    /// <inheritdoc />
    public partial class EditTable_ProvidedForms : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WorkflowQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(3764),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(5540));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 715, DateTimeKind.Utc).AddTicks(2982),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(9090));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponseAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 715, DateTimeKind.Utc).AddTicks(4301),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(9661));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VirtualTableForSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(675),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(8481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(7513),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(9228));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserTokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(6744),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(3725));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UsersRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(5966),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(3167));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(4430),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(2020));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(9761),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(3718));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNoteOnFormForArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(9694),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(4960));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(5162),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(2562));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 715, DateTimeKind.Utc).AddTicks(1487),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(8481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 715, DateTimeKind.Utc).AddTicks(201),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(7915));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 714, DateTimeKind.Utc).AddTicks(9034),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(7371));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermsAndConditions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 714, DateTimeKind.Utc).AddTicks(6412),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(6273));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermAndConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 714, DateTimeKind.Utc).AddTicks(7715),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(6804));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Templates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 714, DateTimeKind.Utc).AddTicks(5524),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(5741));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SwitchArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(8803),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(4344));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubcommitteeCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(5332),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(9192));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(3412),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(8873));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StrategicPartners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 714, DateTimeKind.Utc).AddTicks(4036),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(4658));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 714, DateTimeKind.Utc).AddTicks(3269),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(4142));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(6631),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(8595));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SocialMedias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 714, DateTimeKind.Utc).AddTicks(2641),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(3536));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SavedCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 714, DateTimeKind.Utc).AddTicks(1929),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(2960));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(2941),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(940));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RolePermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(3634),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(1478));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RoleMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 714, DateTimeKind.Utc).AddTicks(1129),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(2329));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rewards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 714, DateTimeKind.Utc).AddTicks(276),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(1742));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ResponsibilitiesUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(9511),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(1171));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Responsibilities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(8768),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(618));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RequestForChangeInterviewEligibilityStatuses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(5841),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(8355));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(7249),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(9474));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccountRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(7992),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(53));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ReferenceSources",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(6528),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(8915));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(4924),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(7709));

            migrationBuilder.AddColumn<int>(
                name: "EducationalInstitutionId",
                table: "ProvidedForms",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Personalnvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(2692),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(8306));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Permissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(1619),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(9887));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PermissionHeaders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(2311),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(430));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(1849),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(5294));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructureImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(4038),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(7056));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(3311),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(6478));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OurGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 702, DateTimeKind.Utc).AddTicks(8723),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 739, DateTimeKind.Utc).AddTicks(9598));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OnePageText",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(1136),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(4763));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NotificationTemplates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(501),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(4269));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Notifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(9012),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(3178));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsTickers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(8401),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(2684));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(7743),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(2157));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(7068),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(1620));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 707, DateTimeKind.Utc).AddTicks(4846),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(2488));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(6375),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(1092));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Meetings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(5675),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(574));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(4970),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(25));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LogUserActions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(4112),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(9458));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(8049),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(4783));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(8876),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(5308));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeParticipants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(1152),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(7000));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeNoteAndQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(320),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(6407));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(9617),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(5856));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Instructions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(7434),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(4270));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(7964),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(3728));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(2546),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(5884));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HomePageSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(921),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(9351));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GroupInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(1933),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(7750));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(286),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(8852));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(8953),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(7813));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(9641),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(8353));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Galleries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(2849),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(82));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FrequentlyAskedQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(5696),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(5345));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(8168),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(7214));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(7299),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(6582));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(4961),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(4803));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(3349),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(3714));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(4102),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(4255));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(2629),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(3188));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryGuides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(1984),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(2663));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(1297),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(2124));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EntitiesCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(8403),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(9844));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 707, DateTimeKind.Utc).AddTicks(4020),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(1917));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 707, DateTimeKind.Utc).AddTicks(2758),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(1277));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalInstitutions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(561),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(1592));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(9832),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(912));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(9143),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(398));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(5056),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(7439));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeTableValue",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(4230),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(6877));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(3269),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(6331));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(113),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(4143));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(2485),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(5767));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(1739),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(5236));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(970),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(4710));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(5838),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(8009));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DigitalSignatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(4643),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(9879));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(9282),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(3482));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(8412),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(2818));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Dependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(7371),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(2041));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cycles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(3885),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(9335));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(3146),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(8774));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(2363),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(8214));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 714, DateTimeKind.Utc).AddTicks(4846),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(5218));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleCondition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(1622),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(7670));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Criterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 707, DateTimeKind.Utc).AddTicks(9398),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(5934));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 707, DateTimeKind.Utc).AddTicks(6961),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(4203));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 707, DateTimeKind.Utc).AddTicks(8630),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(5344));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 707, DateTimeKind.Utc).AddTicks(7852),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(4780));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(903),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(7100));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(168),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(6539));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Coordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 707, DateTimeKind.Utc).AddTicks(6296),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(3563));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CoordinatorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 707, DateTimeKind.Utc).AddTicks(5586),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(3034));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 707, DateTimeKind.Utc).AddTicks(1470),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(710));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(6130),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(9782));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Committees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 707, DateTimeKind.Utc).AddTicks(313),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(144));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(8541),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(9002));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteeOfficers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(9344),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(9579));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Circulars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(4500),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(6087));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(7729),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(8407));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularChairmans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(6816),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(7813));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(5987),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(7209));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(5226),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(6629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatBotQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(3063),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(5002));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnInitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(7074),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(3096));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnFinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(6455),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(5928));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(6273),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(2511));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(1579),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(3806));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryEducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(781),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(3166));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryCommittees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(9919),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(2558));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoriesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(9031),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(1935));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(2338),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(4433));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardStatistics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(8269),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(1365));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardSponsors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(7576),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(831));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardPublications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(6840),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(302));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeTableNames",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(6594),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(1412));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeOperations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(5954),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(921));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeDataTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(5321),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(407));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(4587),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(8632));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(3892),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(8111));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(3072),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(7536));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScalesCriterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(2248),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(6932));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(1364),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(6216));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(4449),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(1233));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationResults",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(574),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(5563));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(5365),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(1902));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AppVersions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(3531),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(619));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Albums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(2134),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(9538));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Agendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(1410),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(9013));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(9754),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(7813));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(8875),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(7206));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderTableValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(7957),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(6565));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(7166),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(5975));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(563),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(899));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(6437),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(5406));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(5721),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(4885));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(5018),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(4367));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(4139),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(3709));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(3276),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(2980));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(2515),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(2394));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(1567),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(1673));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Achievements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 702, DateTimeKind.Utc).AddTicks(9684),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(228));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutAwardPage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 702, DateTimeKind.Utc).AddTicks(7847),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 739, DateTimeKind.Utc).AddTicks(8927));

            migrationBuilder.CreateIndex(
                name: "IX_ProvidedForms_EducationalInstitutionId",
                table: "ProvidedForms",
                column: "EducationalInstitutionId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProvidedForms_EducationalInstitutions_EducationalInstitutionId",
                table: "ProvidedForms",
                column: "EducationalInstitutionId",
                principalTable: "EducationalInstitutions",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProvidedForms_EducationalInstitutions_EducationalInstitutionId",
                table: "ProvidedForms");

            migrationBuilder.DropIndex(
                name: "IX_ProvidedForms_EducationalInstitutionId",
                table: "ProvidedForms");

            migrationBuilder.DropColumn(
                name: "EducationalInstitutionId",
                table: "ProvidedForms");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WorkflowQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(5540),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(3764));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(9090),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 715, DateTimeKind.Utc).AddTicks(2982));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponseAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(9661),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 715, DateTimeKind.Utc).AddTicks(4301));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VirtualTableForSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(8481),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(675));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(9228),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(7513));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserTokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(3725),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(6744));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UsersRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(3167),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(5966));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(2020),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(4430));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(3718),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(9761));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNoteOnFormForArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(4960),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(9694));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(2562),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(5162));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(8481),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 715, DateTimeKind.Utc).AddTicks(1487));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(7915),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 715, DateTimeKind.Utc).AddTicks(201));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(7371),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 714, DateTimeKind.Utc).AddTicks(9034));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermsAndConditions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(6273),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 714, DateTimeKind.Utc).AddTicks(6412));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermAndConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(6804),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 714, DateTimeKind.Utc).AddTicks(7715));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Templates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(5741),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 714, DateTimeKind.Utc).AddTicks(5524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SwitchArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(4344),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(8803));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubcommitteeCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(9192),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(5332));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(8873),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(3412));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StrategicPartners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(4658),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 714, DateTimeKind.Utc).AddTicks(4036));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(4142),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 714, DateTimeKind.Utc).AddTicks(3269));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(8595),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(6631));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SocialMedias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(3536),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 714, DateTimeKind.Utc).AddTicks(2641));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SavedCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(2960),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 714, DateTimeKind.Utc).AddTicks(1929));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(940),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(2941));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RolePermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(1478),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(3634));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RoleMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(2329),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 714, DateTimeKind.Utc).AddTicks(1129));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rewards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(1742),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 714, DateTimeKind.Utc).AddTicks(276));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ResponsibilitiesUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(1171),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(9511));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Responsibilities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(618),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(8768));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RequestForChangeInterviewEligibilityStatuses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(8355),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(5841));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(9474),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(7249));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccountRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(53),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(7992));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ReferenceSources",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(8915),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(6528));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(7709),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(4924));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Personalnvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(8306),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(2692));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Permissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(9887),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(1619));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PermissionHeaders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(430),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(2311));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(5294),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(1849));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructureImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(7056),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(4038));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(6478),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(3311));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OurGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 739, DateTimeKind.Utc).AddTicks(9598),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 702, DateTimeKind.Utc).AddTicks(8723));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OnePageText",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(4763),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(1136));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NotificationTemplates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(4269),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(501));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Notifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(3178),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(9012));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsTickers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(2684),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(8401));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(2157),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(7743));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(1620),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(7068));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(2488),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 707, DateTimeKind.Utc).AddTicks(4846));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(1092),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(6375));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Meetings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(574),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(5675));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(25),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(4970));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LogUserActions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(9458),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(4112));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(4783),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(8049));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(5308),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(8876));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeParticipants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(7000),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(1152));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeNoteAndQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(6407),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(320));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(5856),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(9617));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Instructions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(4270),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(7434));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(3728),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(7964));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 747, DateTimeKind.Utc).AddTicks(5884),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 713, DateTimeKind.Utc).AddTicks(2546));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HomePageSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(9351),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(921));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GroupInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 746, DateTimeKind.Utc).AddTicks(7750),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 712, DateTimeKind.Utc).AddTicks(1933));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(8852),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 711, DateTimeKind.Utc).AddTicks(286));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(7813),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(8953));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(8353),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(9641));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Galleries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(82),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(2849));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FrequentlyAskedQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(5345),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(5696));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(7214),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(8168));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(6582),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(7299));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(4803),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(4961));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(3714),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(3349));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(4255),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(4102));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(3188),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(2629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryGuides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(2663),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(1984));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(2124),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(1297));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EntitiesCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(9844),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(8403));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(1917),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 707, DateTimeKind.Utc).AddTicks(4020));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(1277),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 707, DateTimeKind.Utc).AddTicks(2758));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalInstitutions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(1592),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(561));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(912),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(9832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(398),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(9143));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(7439),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(5056));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeTableValue",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(6877),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(4230));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(6331),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(3269));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(4143),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(113));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(5767),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(2485));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(5236),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(1739));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(4710),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(970));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(8009),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 709, DateTimeKind.Utc).AddTicks(5838));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DigitalSignatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(9879),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(4643));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(3482),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(9282));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(2818),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(8412));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Dependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(2041),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(7371));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cycles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(9335),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(3885));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(8774),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(3146));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(8214),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(2363));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 748, DateTimeKind.Utc).AddTicks(5218),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 714, DateTimeKind.Utc).AddTicks(4846));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleCondition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(7670),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(1622));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Criterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(5934),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 707, DateTimeKind.Utc).AddTicks(9398));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(4203),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 707, DateTimeKind.Utc).AddTicks(6961));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(5344),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 707, DateTimeKind.Utc).AddTicks(8630));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(4780),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 707, DateTimeKind.Utc).AddTicks(7852));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(7100),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(903));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(6539),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(168));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Coordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(3563),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 707, DateTimeKind.Utc).AddTicks(6296));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CoordinatorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(3034),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 707, DateTimeKind.Utc).AddTicks(5586));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(710),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 707, DateTimeKind.Utc).AddTicks(1470));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(9782),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(6130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Committees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 743, DateTimeKind.Utc).AddTicks(144),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 707, DateTimeKind.Utc).AddTicks(313));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(9002),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(8541));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteeOfficers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(9579),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(9344));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Circulars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(6087),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(4500));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(8407),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(7729));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularChairmans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(7813),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(6816));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(7209),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(5987));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(6629),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(5226));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatBotQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(5002),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(3063));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnInitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(3096),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(7074));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnFinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 745, DateTimeKind.Utc).AddTicks(5928),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 710, DateTimeKind.Utc).AddTicks(6455));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(2511),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(6273));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(3806),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(1579));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryEducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(3166),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(781));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryCommittees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(2558),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(9919));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoriesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(1935),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(9031));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(4433),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 706, DateTimeKind.Utc).AddTicks(2338));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardStatistics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(1365),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(8269));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardSponsors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(831),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(7576));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardPublications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 742, DateTimeKind.Utc).AddTicks(302),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(6840));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeTableNames",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(1412),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(6594));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeOperations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(921),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(5954));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeDataTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 744, DateTimeKind.Utc).AddTicks(407),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 708, DateTimeKind.Utc).AddTicks(5321));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(8632),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(4587));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(8111),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(3892));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(7536),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(3072));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScalesCriterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(6932),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(2248));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(6216),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(1364));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(1233),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(4449));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationResults",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(5563),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 705, DateTimeKind.Utc).AddTicks(574));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(1902),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(5365));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AppVersions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 741, DateTimeKind.Utc).AddTicks(619),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(3531));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Albums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(9538),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(2134));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Agendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(9013),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 704, DateTimeKind.Utc).AddTicks(1410));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(7813),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(9754));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(7206),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(8875));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderTableValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(6565),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(7957));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(5975),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(7166));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(899),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(563));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(5406),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(6437));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(4885),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(5721));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(4367),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(5018));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(3709),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(4139));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(2980),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(3276));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(2394),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(2515));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(1673),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 703, DateTimeKind.Utc).AddTicks(1567));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Achievements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 740, DateTimeKind.Utc).AddTicks(228),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 702, DateTimeKind.Utc).AddTicks(9684));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutAwardPage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 24, 11, 48, 25, 739, DateTimeKind.Utc).AddTicks(8927),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 26, 10, 15, 6, 702, DateTimeKind.Utc).AddTicks(7847));
        }
    }
}
