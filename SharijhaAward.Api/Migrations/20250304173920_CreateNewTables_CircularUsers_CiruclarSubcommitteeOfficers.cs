using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Api.Migrations
{
    /// <inheritdoc />
    public partial class CreateNewTables_CircularUsers_CiruclarSubcommitteeOfficers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WorkflowQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 634, DateTimeKind.Utc).AddTicks(5079),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(9568));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 644, DateTimeKind.Utc).AddTicks(4371),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 992, DateTimeKind.Utc).AddTicks(4809));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponseAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 644, DateTimeKind.Utc).AddTicks(5215),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 992, DateTimeKind.Utc).AddTicks(5547));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VirtualTableForSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 631, DateTimeKind.Utc).AddTicks(7609),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(7535));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 638, DateTimeKind.Utc).AddTicks(3539),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(9506));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserTokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 640, DateTimeKind.Utc).AddTicks(5106),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(795));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UsersRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 640, DateTimeKind.Utc).AddTicks(4269),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(9661));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 640, DateTimeKind.Utc).AddTicks(2577),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(7987));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 642, DateTimeKind.Utc).AddTicks(519),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(4346));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNoteOnFormForArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 632, DateTimeKind.Utc).AddTicks(7025),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(5662));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 640, DateTimeKind.Utc).AddTicks(3373),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(8723));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 644, DateTimeKind.Utc).AddTicks(3431),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 992, DateTimeKind.Utc).AddTicks(3973));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 644, DateTimeKind.Utc).AddTicks(2588),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 992, DateTimeKind.Utc).AddTicks(3177));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 644, DateTimeKind.Utc).AddTicks(1646),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 992, DateTimeKind.Utc).AddTicks(2470));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermsAndConditions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 643, DateTimeKind.Utc).AddTicks(9978),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 992, DateTimeKind.Utc).AddTicks(987));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermAndConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 644, DateTimeKind.Utc).AddTicks(792),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 992, DateTimeKind.Utc).AddTicks(1690));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Templates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 643, DateTimeKind.Utc).AddTicks(9154),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 992, DateTimeKind.Utc).AddTicks(284));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SwitchArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 632, DateTimeKind.Utc).AddTicks(6164),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(4896));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubcommitteeCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 633, DateTimeKind.Utc).AddTicks(5538),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(986));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 641, DateTimeKind.Utc).AddTicks(3024),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(7749));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StrategicPartners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 643, DateTimeKind.Utc).AddTicks(7269),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(8841));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 643, DateTimeKind.Utc).AddTicks(6452),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(8137));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 638, DateTimeKind.Utc).AddTicks(2529),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(8710));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SocialMedias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 643, DateTimeKind.Utc).AddTicks(5647),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(7133));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SavedCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 643, DateTimeKind.Utc).AddTicks(4830),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(6438));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 640, DateTimeKind.Utc).AddTicks(944),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(6529));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RolePermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 640, DateTimeKind.Utc).AddTicks(1753),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(7264));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RoleMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 643, DateTimeKind.Utc).AddTicks(3809),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(5646));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rewards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 643, DateTimeKind.Utc).AddTicks(2977),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(4882));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ResponsibilitiesUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 643, DateTimeKind.Utc).AddTicks(1962),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(4139));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Responsibilities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 643, DateTimeKind.Utc).AddTicks(995),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(3403));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RequestForChangeInterviewEligibilityStatuses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 642, DateTimeKind.Utc).AddTicks(7578),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(432));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 642, DateTimeKind.Utc).AddTicks(9224),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(1851));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccountRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 643, DateTimeKind.Utc).AddTicks(120),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(2644));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ReferenceSources",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 642, DateTimeKind.Utc).AddTicks(8373),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(1153));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 642, DateTimeKind.Utc).AddTicks(6575),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(9573));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Personalnvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 641, DateTimeKind.Utc).AddTicks(2180),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(7032));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Permissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 639, DateTimeKind.Utc).AddTicks(9431),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(5212));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PermissionHeaders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 640, DateTimeKind.Utc).AddTicks(203),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(5887));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 642, DateTimeKind.Utc).AddTicks(2911),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(6373));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructureImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 642, DateTimeKind.Utc).AddTicks(5576),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(8681));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 642, DateTimeKind.Utc).AddTicks(4703),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(7929));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OurGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 630, DateTimeKind.Utc).AddTicks(4226),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 980, DateTimeKind.Utc).AddTicks(6098));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OnePageText",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 642, DateTimeKind.Utc).AddTicks(2127),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(5707));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NotificationTemplates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 642, DateTimeKind.Utc).AddTicks(1338),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(5061));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Notifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 641, DateTimeKind.Utc).AddTicks(9712),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(3623));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsTickers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 641, DateTimeKind.Utc).AddTicks(8887),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(2980));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 641, DateTimeKind.Utc).AddTicks(8002),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(2316));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 641, DateTimeKind.Utc).AddTicks(7237),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(1632));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 635, DateTimeKind.Utc).AddTicks(7979),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(8343));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 641, DateTimeKind.Utc).AddTicks(6336),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(920));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Meetings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 641, DateTimeKind.Utc).AddTicks(5510),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(229));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 641, DateTimeKind.Utc).AddTicks(4724),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(9482));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LogUserActions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 641, DateTimeKind.Utc).AddTicks(3883),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(8598));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 640, DateTimeKind.Utc).AddTicks(6827),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(2480));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 640, DateTimeKind.Utc).AddTicks(7653),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(3196));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeParticipants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 641, DateTimeKind.Utc).AddTicks(386),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(5495));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeNoteAndQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 640, DateTimeKind.Utc).AddTicks(9406),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(4685));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 640, DateTimeKind.Utc).AddTicks(8513),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(3914));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Instructions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 640, DateTimeKind.Utc).AddTicks(5985),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(1788));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 632, DateTimeKind.Utc).AddTicks(5217),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(4112));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 642, DateTimeKind.Utc).AddTicks(3754),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(7142));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HomePageSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 639, DateTimeKind.Utc).AddTicks(8653),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(4508));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GroupInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 641, DateTimeKind.Utc).AddTicks(1279),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(6288));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 639, DateTimeKind.Utc).AddTicks(7913),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(3828));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 639, DateTimeKind.Utc).AddTicks(6404),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(2507));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 639, DateTimeKind.Utc).AddTicks(7170),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(3186));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Galleries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 632, DateTimeKind.Utc).AddTicks(68),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(9396));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FrequentlyAskedQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 639, DateTimeKind.Utc).AddTicks(2794),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(9216));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 639, DateTimeKind.Utc).AddTicks(5520),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(1726));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 639, DateTimeKind.Utc).AddTicks(4559),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(858));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 639, DateTimeKind.Utc).AddTicks(1983),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(8511));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 639, DateTimeKind.Utc).AddTicks(303),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(7163));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 639, DateTimeKind.Utc).AddTicks(1101),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(7839));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 638, DateTimeKind.Utc).AddTicks(9459),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(6274));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryGuides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 638, DateTimeKind.Utc).AddTicks(8662),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(4907));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 638, DateTimeKind.Utc).AddTicks(7814),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(3846));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EntitiesCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 638, DateTimeKind.Utc).AddTicks(4505),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(378));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 635, DateTimeKind.Utc).AddTicks(7063),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(7604));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 635, DateTimeKind.Utc).AddTicks(6108),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(6817));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalInstitutions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 638, DateTimeKind.Utc).AddTicks(7020),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(2592));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 638, DateTimeKind.Utc).AddTicks(6117),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(1817));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 638, DateTimeKind.Utc).AddTicks(5351),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(1080));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 638, DateTimeKind.Utc).AddTicks(773),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(7247));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeTableValue",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 637, DateTimeKind.Utc).AddTicks(9934),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(6539));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 637, DateTimeKind.Utc).AddTicks(9079),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(5812));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 637, DateTimeKind.Utc).AddTicks(5617),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(3082));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 637, DateTimeKind.Utc).AddTicks(8236),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(5126));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 637, DateTimeKind.Utc).AddTicks(7387),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(4431));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 637, DateTimeKind.Utc).AddTicks(6501),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(3770));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 638, DateTimeKind.Utc).AddTicks(1651),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(7973));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DigitalSignatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 636, DateTimeKind.Utc).AddTicks(9264),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(7711));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 637, DateTimeKind.Utc).AddTicks(4691),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(2258));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 637, DateTimeKind.Utc).AddTicks(3670),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(1436));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Dependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 637, DateTimeKind.Utc).AddTicks(2521),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(448));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cycles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 636, DateTimeKind.Utc).AddTicks(8392),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(7029));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 636, DateTimeKind.Utc).AddTicks(7544),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(6307));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 636, DateTimeKind.Utc).AddTicks(6692),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(5581));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 643, DateTimeKind.Utc).AddTicks(8297),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(9581));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleCondition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 636, DateTimeKind.Utc).AddTicks(5877),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(4907));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Criterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 636, DateTimeKind.Utc).AddTicks(3252),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(2661));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 636, DateTimeKind.Utc).AddTicks(529),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(425));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 636, DateTimeKind.Utc).AddTicks(2342),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(1928));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 636, DateTimeKind.Utc).AddTicks(1431),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(1175));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 636, DateTimeKind.Utc).AddTicks(5055),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(4163));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 636, DateTimeKind.Utc).AddTicks(4201),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(3422));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Coordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 635, DateTimeKind.Utc).AddTicks(9658),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(9747));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CoordinatorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 635, DateTimeKind.Utc).AddTicks(8840),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(9048));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 635, DateTimeKind.Utc).AddTicks(5204),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(6111));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 633, DateTimeKind.Utc).AddTicks(6545),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(1734));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Committees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 635, DateTimeKind.Utc).AddTicks(4280),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(5413));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 635, DateTimeKind.Utc).AddTicks(2478),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(3934));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteeOfficers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 635, DateTimeKind.Utc).AddTicks(3425),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(4676));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Circulars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 634, DateTimeKind.Utc).AddTicks(5906),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(281));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 634, DateTimeKind.Utc).AddTicks(9610),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(3211));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularChairmans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 634, DateTimeKind.Utc).AddTicks(8629),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(2381));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 634, DateTimeKind.Utc).AddTicks(7776),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(1652));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 634, DateTimeKind.Utc).AddTicks(6827),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(951));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatBotQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 634, DateTimeKind.Utc).AddTicks(4203),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(8869));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnInitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 632, DateTimeKind.Utc).AddTicks(4360),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(3332));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnFinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 639, DateTimeKind.Utc).AddTicks(3656),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(9984));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 632, DateTimeKind.Utc).AddTicks(3490),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(2596));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 634, DateTimeKind.Utc).AddTicks(2527),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(7357));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryEducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 634, DateTimeKind.Utc).AddTicks(1669),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(6600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryCommittees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 634, DateTimeKind.Utc).AddTicks(749),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(5753));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoriesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 633, DateTimeKind.Utc).AddTicks(9841),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(4954));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 634, DateTimeKind.Utc).AddTicks(3369),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(8167));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardStatistics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 633, DateTimeKind.Utc).AddTicks(8901),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(3831));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardSponsors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 633, DateTimeKind.Utc).AddTicks(8102),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(3062));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardPublications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 633, DateTimeKind.Utc).AddTicks(7342),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(2414));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeTableNames",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 637, DateTimeKind.Utc).AddTicks(1570),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(9631));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeOperations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 637, DateTimeKind.Utc).AddTicks(829),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(9030));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeDataTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 637, DateTimeKind.Utc).AddTicks(90),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(8413));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 633, DateTimeKind.Utc).AddTicks(4694),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(274));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 633, DateTimeKind.Utc).AddTicks(3841),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 633, DateTimeKind.Utc).AddTicks(2721),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(8815));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScalesCriterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 633, DateTimeKind.Utc).AddTicks(1153),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(8003));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 632, DateTimeKind.Utc).AddTicks(9265),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(7219));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 632, DateTimeKind.Utc).AddTicks(1620),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(944));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationResults",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 632, DateTimeKind.Utc).AddTicks(7990),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(6440));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 632, DateTimeKind.Utc).AddTicks(2623),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(1812));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AppVersions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 632, DateTimeKind.Utc).AddTicks(779),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(39));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Albums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 631, DateTimeKind.Utc).AddTicks(9249),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(8766));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Agendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 631, DateTimeKind.Utc).AddTicks(8473),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(8160));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 631, DateTimeKind.Utc).AddTicks(6529),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(6603));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 631, DateTimeKind.Utc).AddTicks(5543),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(5819));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderTableValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 631, DateTimeKind.Utc).AddTicks(4543),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(5026));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 631, DateTimeKind.Utc).AddTicks(3649),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(4290));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 630, DateTimeKind.Utc).AddTicks(6114),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 980, DateTimeKind.Utc).AddTicks(7774));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 631, DateTimeKind.Utc).AddTicks(2828),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(3584));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 631, DateTimeKind.Utc).AddTicks(1964),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(2874));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 631, DateTimeKind.Utc).AddTicks(1162),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(2178));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 631, DateTimeKind.Utc).AddTicks(260),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(1440));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 630, DateTimeKind.Utc).AddTicks(9237),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(536));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 630, DateTimeKind.Utc).AddTicks(8309),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 980, DateTimeKind.Utc).AddTicks(9764));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 630, DateTimeKind.Utc).AddTicks(7290),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 980, DateTimeKind.Utc).AddTicks(8858));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Achievements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 630, DateTimeKind.Utc).AddTicks(5115),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 980, DateTimeKind.Utc).AddTicks(6897));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutAwardPage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 630, DateTimeKind.Utc).AddTicks(3250),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 980, DateTimeKind.Utc).AddTicks(5313));

            migrationBuilder.CreateTable(
                name: "CircularUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CircularId = table.Column<int>(type: "int", nullable: false),
                    UserRoleId = table.Column<int>(type: "int", nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 635, DateTimeKind.Utc).AddTicks(534)),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CircularUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CircularUsers_Circulars_CircularId",
                        column: x => x.CircularId,
                        principalTable: "Circulars",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CircularUsers_UsersRoles_UserRoleId",
                        column: x => x.UserRoleId,
                        principalTable: "UsersRoles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CiruclarSubcommitteeOfficers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CircularId = table.Column<int>(type: "int", nullable: false),
                    SubcommitteeOfficerId = table.Column<int>(type: "int", nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 635, DateTimeKind.Utc).AddTicks(1564)),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiruclarSubcommitteeOfficers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CiruclarSubcommitteeOfficers_Arbitrators_SubcommitteeOfficerId",
                        column: x => x.SubcommitteeOfficerId,
                        principalTable: "Arbitrators",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CiruclarSubcommitteeOfficers_Circulars_CircularId",
                        column: x => x.CircularId,
                        principalTable: "Circulars",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CircularUsers_CircularId",
                table: "CircularUsers",
                column: "CircularId");

            migrationBuilder.CreateIndex(
                name: "IX_CircularUsers_UserRoleId",
                table: "CircularUsers",
                column: "UserRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_CiruclarSubcommitteeOfficers_CircularId",
                table: "CiruclarSubcommitteeOfficers",
                column: "CircularId");

            migrationBuilder.CreateIndex(
                name: "IX_CiruclarSubcommitteeOfficers_SubcommitteeOfficerId",
                table: "CiruclarSubcommitteeOfficers",
                column: "SubcommitteeOfficerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CircularUsers");

            migrationBuilder.DropTable(
                name: "CiruclarSubcommitteeOfficers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WorkflowQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(9568),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 634, DateTimeKind.Utc).AddTicks(5079));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 992, DateTimeKind.Utc).AddTicks(4809),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 644, DateTimeKind.Utc).AddTicks(4371));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponseAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 992, DateTimeKind.Utc).AddTicks(5547),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 644, DateTimeKind.Utc).AddTicks(5215));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VirtualTableForSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(7535),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 631, DateTimeKind.Utc).AddTicks(7609));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(9506),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 638, DateTimeKind.Utc).AddTicks(3539));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserTokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(795),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 640, DateTimeKind.Utc).AddTicks(5106));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UsersRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(9661),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 640, DateTimeKind.Utc).AddTicks(4269));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(7987),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 640, DateTimeKind.Utc).AddTicks(2577));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(4346),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 642, DateTimeKind.Utc).AddTicks(519));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNoteOnFormForArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(5662),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 632, DateTimeKind.Utc).AddTicks(7025));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(8723),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 640, DateTimeKind.Utc).AddTicks(3373));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 992, DateTimeKind.Utc).AddTicks(3973),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 644, DateTimeKind.Utc).AddTicks(3431));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 992, DateTimeKind.Utc).AddTicks(3177),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 644, DateTimeKind.Utc).AddTicks(2588));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 992, DateTimeKind.Utc).AddTicks(2470),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 644, DateTimeKind.Utc).AddTicks(1646));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermsAndConditions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 992, DateTimeKind.Utc).AddTicks(987),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 643, DateTimeKind.Utc).AddTicks(9978));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermAndConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 992, DateTimeKind.Utc).AddTicks(1690),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 644, DateTimeKind.Utc).AddTicks(792));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Templates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 992, DateTimeKind.Utc).AddTicks(284),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 643, DateTimeKind.Utc).AddTicks(9154));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SwitchArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(4896),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 632, DateTimeKind.Utc).AddTicks(6164));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubcommitteeCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(986),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 633, DateTimeKind.Utc).AddTicks(5538));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(7749),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 641, DateTimeKind.Utc).AddTicks(3024));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StrategicPartners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(8841),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 643, DateTimeKind.Utc).AddTicks(7269));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(8137),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 643, DateTimeKind.Utc).AddTicks(6452));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(8710),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 638, DateTimeKind.Utc).AddTicks(2529));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SocialMedias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(7133),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 643, DateTimeKind.Utc).AddTicks(5647));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SavedCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(6438),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 643, DateTimeKind.Utc).AddTicks(4830));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(6529),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 640, DateTimeKind.Utc).AddTicks(944));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RolePermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(7264),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 640, DateTimeKind.Utc).AddTicks(1753));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RoleMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(5646),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 643, DateTimeKind.Utc).AddTicks(3809));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rewards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(4882),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 643, DateTimeKind.Utc).AddTicks(2977));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ResponsibilitiesUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(4139),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 643, DateTimeKind.Utc).AddTicks(1962));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Responsibilities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(3403),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 643, DateTimeKind.Utc).AddTicks(995));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RequestForChangeInterviewEligibilityStatuses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(432),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 642, DateTimeKind.Utc).AddTicks(7578));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(1851),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 642, DateTimeKind.Utc).AddTicks(9224));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccountRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(2644),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 643, DateTimeKind.Utc).AddTicks(120));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ReferenceSources",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(1153),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 642, DateTimeKind.Utc).AddTicks(8373));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(9573),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 642, DateTimeKind.Utc).AddTicks(6575));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Personalnvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(7032),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 641, DateTimeKind.Utc).AddTicks(2180));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Permissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(5212),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 639, DateTimeKind.Utc).AddTicks(9431));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PermissionHeaders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(5887),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 640, DateTimeKind.Utc).AddTicks(203));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(6373),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 642, DateTimeKind.Utc).AddTicks(2911));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructureImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(8681),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 642, DateTimeKind.Utc).AddTicks(5576));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(7929),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 642, DateTimeKind.Utc).AddTicks(4703));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OurGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 980, DateTimeKind.Utc).AddTicks(6098),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 630, DateTimeKind.Utc).AddTicks(4226));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OnePageText",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(5707),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 642, DateTimeKind.Utc).AddTicks(2127));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NotificationTemplates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(5061),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 642, DateTimeKind.Utc).AddTicks(1338));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Notifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(3623),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 641, DateTimeKind.Utc).AddTicks(9712));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsTickers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(2980),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 641, DateTimeKind.Utc).AddTicks(8887));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(2316),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 641, DateTimeKind.Utc).AddTicks(8002));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(1632),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 641, DateTimeKind.Utc).AddTicks(7237));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(8343),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 635, DateTimeKind.Utc).AddTicks(7979));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(920),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 641, DateTimeKind.Utc).AddTicks(6336));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Meetings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(229),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 641, DateTimeKind.Utc).AddTicks(5510));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(9482),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 641, DateTimeKind.Utc).AddTicks(4724));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LogUserActions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(8598),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 641, DateTimeKind.Utc).AddTicks(3883));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(2480),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 640, DateTimeKind.Utc).AddTicks(6827));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(3196),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 640, DateTimeKind.Utc).AddTicks(7653));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeParticipants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(5495),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 641, DateTimeKind.Utc).AddTicks(386));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeNoteAndQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(4685),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 640, DateTimeKind.Utc).AddTicks(9406));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(3914),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 640, DateTimeKind.Utc).AddTicks(8513));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Instructions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(1788),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 640, DateTimeKind.Utc).AddTicks(5985));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(4112),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 632, DateTimeKind.Utc).AddTicks(5217));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 990, DateTimeKind.Utc).AddTicks(7142),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 642, DateTimeKind.Utc).AddTicks(3754));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HomePageSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(4508),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 639, DateTimeKind.Utc).AddTicks(8653));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GroupInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 989, DateTimeKind.Utc).AddTicks(6288),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 641, DateTimeKind.Utc).AddTicks(1279));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(3828),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 639, DateTimeKind.Utc).AddTicks(7913));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(2507),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 639, DateTimeKind.Utc).AddTicks(6404));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(3186),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 639, DateTimeKind.Utc).AddTicks(7170));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Galleries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(9396),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 632, DateTimeKind.Utc).AddTicks(68));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FrequentlyAskedQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(9216),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 639, DateTimeKind.Utc).AddTicks(2794));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(1726),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 639, DateTimeKind.Utc).AddTicks(5520));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 988, DateTimeKind.Utc).AddTicks(858),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 639, DateTimeKind.Utc).AddTicks(4559));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(8511),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 639, DateTimeKind.Utc).AddTicks(1983));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(7163),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 639, DateTimeKind.Utc).AddTicks(303));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(7839),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 639, DateTimeKind.Utc).AddTicks(1101));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(6274),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 638, DateTimeKind.Utc).AddTicks(9459));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryGuides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(4907),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 638, DateTimeKind.Utc).AddTicks(8662));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(3846),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 638, DateTimeKind.Utc).AddTicks(7814));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EntitiesCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(378),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 638, DateTimeKind.Utc).AddTicks(4505));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(7604),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 635, DateTimeKind.Utc).AddTicks(7063));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(6817),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 635, DateTimeKind.Utc).AddTicks(6108));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalInstitutions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(2592),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 638, DateTimeKind.Utc).AddTicks(7020));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(1817),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 638, DateTimeKind.Utc).AddTicks(6117));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(1080),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 638, DateTimeKind.Utc).AddTicks(5351));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(7247),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 638, DateTimeKind.Utc).AddTicks(773));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeTableValue",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(6539),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 637, DateTimeKind.Utc).AddTicks(9934));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(5812),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 637, DateTimeKind.Utc).AddTicks(9079));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(3082),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 637, DateTimeKind.Utc).AddTicks(5617));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(5126),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 637, DateTimeKind.Utc).AddTicks(8236));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(4431),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 637, DateTimeKind.Utc).AddTicks(7387));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(3770),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 637, DateTimeKind.Utc).AddTicks(6501));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(7973),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 638, DateTimeKind.Utc).AddTicks(1651));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DigitalSignatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(7711),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 636, DateTimeKind.Utc).AddTicks(9264));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(2258),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 637, DateTimeKind.Utc).AddTicks(4691));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(1436),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 637, DateTimeKind.Utc).AddTicks(3670));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Dependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 986, DateTimeKind.Utc).AddTicks(448),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 637, DateTimeKind.Utc).AddTicks(2521));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cycles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(7029),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 636, DateTimeKind.Utc).AddTicks(8392));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(6307),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 636, DateTimeKind.Utc).AddTicks(7544));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(5581),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 636, DateTimeKind.Utc).AddTicks(6692));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 991, DateTimeKind.Utc).AddTicks(9581),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 643, DateTimeKind.Utc).AddTicks(8297));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleCondition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(4907),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 636, DateTimeKind.Utc).AddTicks(5877));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Criterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(2661),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 636, DateTimeKind.Utc).AddTicks(3252));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(425),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 636, DateTimeKind.Utc).AddTicks(529));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(1928),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 636, DateTimeKind.Utc).AddTicks(2342));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(1175),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 636, DateTimeKind.Utc).AddTicks(1431));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(4163),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 636, DateTimeKind.Utc).AddTicks(5055));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(3422),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 636, DateTimeKind.Utc).AddTicks(4201));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Coordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(9747),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 635, DateTimeKind.Utc).AddTicks(9658));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CoordinatorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(9048),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 635, DateTimeKind.Utc).AddTicks(8840));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(6111),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 635, DateTimeKind.Utc).AddTicks(5204));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(1734),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 633, DateTimeKind.Utc).AddTicks(6545));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Committees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(5413),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 635, DateTimeKind.Utc).AddTicks(4280));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(3934),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 635, DateTimeKind.Utc).AddTicks(2478));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteeOfficers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(4676),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 635, DateTimeKind.Utc).AddTicks(3425));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Circulars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(281),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 634, DateTimeKind.Utc).AddTicks(5906));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(3211),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 634, DateTimeKind.Utc).AddTicks(9610));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularChairmans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(2381),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 634, DateTimeKind.Utc).AddTicks(8629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(1652),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 634, DateTimeKind.Utc).AddTicks(7776));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 984, DateTimeKind.Utc).AddTicks(951),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 634, DateTimeKind.Utc).AddTicks(6827));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatBotQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(8869),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 634, DateTimeKind.Utc).AddTicks(4203));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnInitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(3332),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 632, DateTimeKind.Utc).AddTicks(4360));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnFinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 987, DateTimeKind.Utc).AddTicks(9984),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 639, DateTimeKind.Utc).AddTicks(3656));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(2596),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 632, DateTimeKind.Utc).AddTicks(3490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(7357),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 634, DateTimeKind.Utc).AddTicks(2527));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryEducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(6600),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 634, DateTimeKind.Utc).AddTicks(1669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryCommittees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(5753),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 634, DateTimeKind.Utc).AddTicks(749));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoriesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(4954),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 633, DateTimeKind.Utc).AddTicks(9841));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(8167),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 634, DateTimeKind.Utc).AddTicks(3369));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardStatistics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(3831),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 633, DateTimeKind.Utc).AddTicks(8901));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardSponsors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(3062),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 633, DateTimeKind.Utc).AddTicks(8102));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardPublications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(2414),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 633, DateTimeKind.Utc).AddTicks(7342));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeTableNames",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(9631),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 637, DateTimeKind.Utc).AddTicks(1570));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeOperations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(9030),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 637, DateTimeKind.Utc).AddTicks(829));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeDataTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 985, DateTimeKind.Utc).AddTicks(8413),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 637, DateTimeKind.Utc).AddTicks(90));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 983, DateTimeKind.Utc).AddTicks(274),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 633, DateTimeKind.Utc).AddTicks(4694));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(9590),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 633, DateTimeKind.Utc).AddTicks(3841));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(8815),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 633, DateTimeKind.Utc).AddTicks(2721));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScalesCriterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(8003),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 633, DateTimeKind.Utc).AddTicks(1153));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(7219),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 632, DateTimeKind.Utc).AddTicks(9265));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(944),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 632, DateTimeKind.Utc).AddTicks(1620));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationResults",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(6440),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 632, DateTimeKind.Utc).AddTicks(7990));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(1812),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 632, DateTimeKind.Utc).AddTicks(2623));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AppVersions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 982, DateTimeKind.Utc).AddTicks(39),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 632, DateTimeKind.Utc).AddTicks(779));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Albums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(8766),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 631, DateTimeKind.Utc).AddTicks(9249));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Agendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(8160),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 631, DateTimeKind.Utc).AddTicks(8473));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(6603),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 631, DateTimeKind.Utc).AddTicks(6529));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(5819),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 631, DateTimeKind.Utc).AddTicks(5543));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderTableValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(5026),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 631, DateTimeKind.Utc).AddTicks(4543));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(4290),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 631, DateTimeKind.Utc).AddTicks(3649));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 980, DateTimeKind.Utc).AddTicks(7774),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 630, DateTimeKind.Utc).AddTicks(6114));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(3584),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 631, DateTimeKind.Utc).AddTicks(2828));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(2874),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 631, DateTimeKind.Utc).AddTicks(1964));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(2178),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 631, DateTimeKind.Utc).AddTicks(1162));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(1440),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 631, DateTimeKind.Utc).AddTicks(260));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 981, DateTimeKind.Utc).AddTicks(536),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 630, DateTimeKind.Utc).AddTicks(9237));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 980, DateTimeKind.Utc).AddTicks(9764),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 630, DateTimeKind.Utc).AddTicks(8309));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 980, DateTimeKind.Utc).AddTicks(8858),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 630, DateTimeKind.Utc).AddTicks(7290));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Achievements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 980, DateTimeKind.Utc).AddTicks(6897),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 630, DateTimeKind.Utc).AddTicks(5115));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutAwardPage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 3, 2, 10, 20, 50, 980, DateTimeKind.Utc).AddTicks(5313),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 3, 4, 17, 39, 18, 630, DateTimeKind.Utc).AddTicks(3250));
        }
    }
}
