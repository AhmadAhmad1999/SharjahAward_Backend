using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Api.Migrations
{
    /// <inheritdoc />
    public partial class UpdateOnTables_Cycles_Categories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MarginOfDifferenceBetweenArbitrators",
                table: "Cycles");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WorkflowQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(5940),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(467));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(6677),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 104, DateTimeKind.Utc).AddTicks(3783));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponseAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(7333),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 104, DateTimeKind.Utc).AddTicks(4526));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VirtualTableForSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(7389),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(9472));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(2321),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(2222));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserTokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(8216),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(1764));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UsersRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(7600),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(1003));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(6318),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(9484));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(9512),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(4397));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNoteOnFormForArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(4549),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(7523));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(6918),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(219));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(5979),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 104, DateTimeKind.Utc).AddTicks(3040));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(5380),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 104, DateTimeKind.Utc).AddTicks(2343));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(4780),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 104, DateTimeKind.Utc).AddTicks(1654));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermsAndConditions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(3503),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 104, DateTimeKind.Utc).AddTicks(247));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermAndConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(4150),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 104, DateTimeKind.Utc).AddTicks(939));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Templates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(2898),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(9564));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SwitchArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(3883),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(6744));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubcommitteeCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(9088),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(2612));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(3986),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(8208));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StrategicPartners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(1703),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(8158));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(1122),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(7476));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(1632),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(1331));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SocialMedias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(572),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(6839));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SavedCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(9954),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(6134));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(5112),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(7990));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RolePermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(5717),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(8713));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RoleMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(9267),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(5335));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rewards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(8609),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(4617));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ResponsibilitiesUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(7942),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(3886));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Responsibilities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(7312),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(3174));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RequestForChangeInterviewEligibilityStatuses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(4811),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(305));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(6016),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(1696));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccountRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(6677),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(2448));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ReferenceSources",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(5407),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(994));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(4091),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(9466));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Personalnvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(3197),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(7494));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Permissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(3970),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(6531));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PermissionHeaders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(4566),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(7252));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(1375),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(6457));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructureImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(3331),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(8615));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(2688),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(7898));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OurGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 91, DateTimeKind.Utc).AddTicks(7360),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 92, DateTimeKind.Utc).AddTicks(8864));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OnePageText",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(769),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(5774));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NotificationTemplates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(128),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(5126));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Notifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(8834),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(3678));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsTickers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(8265),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(3030));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(7679),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(2372));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(7109),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(1715));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(3719),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(9520));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(6503),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(1030));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Meetings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(5906),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(352));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(5279),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(9658));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LogUserActions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(4632),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(8926));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(9373),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(3136));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(9970),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(3831));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeParticipants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(1870),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(6009));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeNoteAndQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(1190),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(5211));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(578),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(4520));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Instructions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(8803),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(2473));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(3152),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(5954));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(1997),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(7162));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HomePageSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(3375),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(5806));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GroupInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(2556),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(6772));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(2796),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(5130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(1658),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(3407));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(2248),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(4249));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Galleries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(9113),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(1450));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FrequentlyAskedQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(8928),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(219));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(986),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(2616));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(278),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(1777));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(8322),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(9505));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(7107),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(8066));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(7706),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(8779));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(6524),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(7373));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryGuides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(5945),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(6684));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(5349),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(5955));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EntitiesCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(3006),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(3146));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(3073),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(8715));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(2410),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(7917));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalInstitutions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(4731),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(5234));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(4174),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(4501));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(3602),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(3859));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(245),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(9601));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeTableValue",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(9641),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(8826));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(9014),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(8110));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(6566),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(4989));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(8381),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(7360));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(7790),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(6631));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(7199),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(5732));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(931),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(367));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DigitalSignatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(1873),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(9238));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(5872),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(4156));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(5086),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(3259));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Dependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(4224),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(2230));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cycles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(1277),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(8504));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(644),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(7757));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(3),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(7018));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(2320),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(8892));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleCondition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(9405),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(6307));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Criterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(7481),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(4051));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(5513),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(1701));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(6841),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(3282));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(6176),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(2490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(8799),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(5588));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(8172),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(4849));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Coordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(4920),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(973));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CoordinatorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(4328),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(261));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(1726),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(7149));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(9783),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(3341));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Committees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(1084),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(6399));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(9788),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(4861));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteeOfficers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(448),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(5637));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Circulars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(6526),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(1151));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(9140),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(4082));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularChairmans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(8437),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(3316));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(7811),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(2596));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(7130),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(1862));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatBotQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(5330),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(9773));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnInitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(2469),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(5189));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnFinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(9593),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(964));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(1827),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(4463));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(4080),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(8330));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryEducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(3439),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(7589));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryCommittees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(2788),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(6822));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoriesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(2143),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(6061));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(4726),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(9052));

            migrationBuilder.AddColumn<int>(
                name: "MarginOfDifferenceBetweenArbitrators",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardStatistics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(1495),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(5318));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardSponsors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(907),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(4634));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardPublications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(363),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(4004));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeTableNames",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(3540),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(1401));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeOperations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(3002),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(743));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeDataTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(2459),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(83));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(8491),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(1929));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(7887),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(1275));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(7246),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScalesCriterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(6564),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(9773));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(5880),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(9009));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(347),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(2838));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationResults",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(5237),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(8277));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(1091),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(3691));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AppVersions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(9689),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(2075));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Albums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(8539),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(785));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Agendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(7970),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(143));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(6633),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(8630));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(5937),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(7851));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderTableValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(5225),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(7060));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(4557),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(6331));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 91, DateTimeKind.Utc).AddTicks(8898),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(462));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(3910),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(5628));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(3306),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(4957));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(2712),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(4326));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(2038),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(3637));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(1193),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(2838));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(537),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(2172));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 91, DateTimeKind.Utc).AddTicks(9760),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(1371));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Achievements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 91, DateTimeKind.Utc).AddTicks(8124),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 92, DateTimeKind.Utc).AddTicks(9679));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutAwardPage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 91, DateTimeKind.Utc).AddTicks(6633),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 92, DateTimeKind.Utc).AddTicks(8070));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MarginOfDifferenceBetweenArbitrators",
                table: "Categories");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WorkflowQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(467),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(5940));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 104, DateTimeKind.Utc).AddTicks(3783),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(6677));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "WebSiteResponseAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 104, DateTimeKind.Utc).AddTicks(4526),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(7333));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "VirtualTableForSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(9472),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(7389));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(2222),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(2321));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserTokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(1764),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(8216));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UsersRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(1003),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(7600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(9484),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(6318));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(4397),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserNoteOnFormForArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(7523),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(4549));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(219),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(6918));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 104, DateTimeKind.Utc).AddTicks(3040),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(5979));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 104, DateTimeKind.Utc).AddTicks(2343),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(5380));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshopAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 104, DateTimeKind.Utc).AddTicks(1654),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(4780));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermsAndConditions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 104, DateTimeKind.Utc).AddTicks(247),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(3503));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "TermAndConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 104, DateTimeKind.Utc).AddTicks(939),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(4150));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Templates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(9564),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(2898));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SwitchArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(6744),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(3883));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SubcommitteeCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(2612),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(9088));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(8208),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(3986));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StrategicPartners",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(8158),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(1703));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(7476),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(1122));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(1331),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(1632));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SocialMedias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(6839),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(572));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "SavedCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(6134),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(9954));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(7990),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(5112));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RolePermissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(8713),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(5717));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RoleMessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(5335),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(9267));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Rewards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(4617),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(8609));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ResponsibilitiesUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(3886),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(7942));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Responsibilities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(3174),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(7312));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RequestForChangeInterviewEligibilityStatuses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(305),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(4811));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(1696),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(6016));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "RelatedAccountRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(2448),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(6677));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ReferenceSources",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(994),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(5407));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(9466),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(4091));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Personalnvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(7494),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(3197));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Permissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(6531),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(3970));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PermissionHeaders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(7252),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(4566));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(6457),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(1375));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageStructureImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(8615),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(3331));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(7898),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(2688));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OurGoals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 92, DateTimeKind.Utc).AddTicks(8864),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 91, DateTimeKind.Utc).AddTicks(7360));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "OnePageText",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(5774),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(769));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NotificationTemplates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(5126),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(128));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Notifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(3678),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(8834));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsTickers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(3030),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(8265));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "NewsImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(2372),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(7679));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(1715),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(7109));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MessageTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(9520),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(3719));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(1030),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(6503));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Meetings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(352),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(5906));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "MeetingCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(9658),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(5279));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LogUserActions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(8926),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(4632));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Interviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(3136),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(9373));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(3831),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(9970));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeParticipants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(6009),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(1870));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeNoteAndQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(5211),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(1190));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InterviewInviteeAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(4520),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(578));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Instructions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(2473),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(8803));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "InitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(5954),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(3152));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ImageCards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 102, DateTimeKind.Utc).AddTicks(7162),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 100, DateTimeKind.Utc).AddTicks(1997));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "HomePageSliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(5806),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(3375));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GroupInvitees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 101, DateTimeKind.Utc).AddTicks(6772),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 99, DateTimeKind.Utc).AddTicks(2556));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralWorkshops",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(5130),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(2796));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(3407),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(1658));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "GeneralFAQCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(4249),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(2248));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Galleries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(1450),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(9113));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FrequentlyAskedQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(219),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(8928));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(2616),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(986));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "FinalArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(1777),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 98, DateTimeKind.Utc).AddTicks(278));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(9505),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(8322));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(8066),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(7107));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExtraAttachmentAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(8779),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(7706));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(7373),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(6524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ExplanatoryGuides",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(6684),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(5945));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(5955),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(5349));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EntitiesCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(3146),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(3006));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(8715),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(3073));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EmailAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(7917),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(2410));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalInstitutions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(5234),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(4731));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalEntities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(4501),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(4174));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "EducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(3859),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(3602));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(9601),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(245));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeTableValue",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(8826),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(9641));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(8110),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(9014));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(4989),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(6566));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(7360),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(8381));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributePatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(6631),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(7790));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(5732),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(7199));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 99, DateTimeKind.Utc).AddTicks(367),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(931));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DigitalSignatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(9238),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(1873));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(4156),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(5872));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(3259),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(5086));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Dependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(2230),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(4224));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Cycles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(8504),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(1277));

            migrationBuilder.AddColumn<int>(
                name: "MarginOfDifferenceBetweenArbitrators",
                table: "Cycles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(7757),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(644));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(7018),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(3));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 103, DateTimeKind.Utc).AddTicks(8892),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 101, DateTimeKind.Utc).AddTicks(2320));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CycleCondition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(6307),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(9405));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Criterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(4051),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(7481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(1701),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(5513));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(3282),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(6841));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionItemAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(2490),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(6176));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachmentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(5588),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(8799));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CriterionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(4849),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(8172));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Coordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(973),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(4920));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CoordinatorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 97, DateTimeKind.Utc).AddTicks(261),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(4328));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionsProvidedForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(7149),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(1726));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ConditionAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(3341),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(9783));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Committees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(6399),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(1084));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(4861),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(9788));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ComitteeOfficers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(5637),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 95, DateTimeKind.Utc).AddTicks(448));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Circulars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(1151),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(6526));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularCoordinators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(4082),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(9140));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularChairmans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(3316),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(8437));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(2596),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(7811));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CircularArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 96, DateTimeKind.Utc).AddTicks(1862),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(7130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChatBotQuestions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(9773),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(5330));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnInitialArbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(5189),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(2469));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnFinalArbitrationScores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 100, DateTimeKind.Utc).AddTicks(964),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 97, DateTimeKind.Utc).AddTicks(9593));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ChairmanNotesOnArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(4463),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(1827));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFAQs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(8330),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(4080));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryEducationalClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(7589),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(3439));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryCommittees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(6822),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(2788));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoriesArbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(6061),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(2143));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(9052),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(4726));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardStatistics",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(5318),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(1495));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardSponsors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(4634),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(907));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AwardPublications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(4004),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 94, DateTimeKind.Utc).AddTicks(363));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeTableNames",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(1401),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(3540));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeOperations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(743),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(3002));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeDataTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 98, DateTimeKind.Utc).AddTicks(83),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 96, DateTimeKind.Utc).AddTicks(2459));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(1929),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(8491));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorForms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(1275),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(7887));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 95, DateTimeKind.Utc).AddTicks(524),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(7246));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScalesCriterions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(9773),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(6564));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationScales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(9009),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(5880));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(2838),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(347));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationResults",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(8277),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(5237));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitrationAudits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(3691),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 93, DateTimeKind.Utc).AddTicks(1091));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AppVersions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(2075),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(9689));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Albums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(785),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(8539));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Agendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 94, DateTimeKind.Utc).AddTicks(143),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(7970));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderViewWhenRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(8630),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(7851),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(5937));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderTableValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(7060),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(5225));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(6331),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(4557));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(462),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 91, DateTimeKind.Utc).AddTicks(8898));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatternValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(5628),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(3910));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderPatterns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(4957),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(3306));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(4326),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(2712));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(3637),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(2038));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(2838),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(1193));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencyGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(2172),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 92, DateTimeKind.Utc).AddTicks(537));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AdvancedFormBuilderDependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 93, DateTimeKind.Utc).AddTicks(1371),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 91, DateTimeKind.Utc).AddTicks(9760));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Achievements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 92, DateTimeKind.Utc).AddTicks(9679),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 91, DateTimeKind.Utc).AddTicks(8124));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "AboutAwardPage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 17, 9, 17, 25, 92, DateTimeKind.Utc).AddTicks(8070),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 18, 12, 5, 23, 91, DateTimeKind.Utc).AddTicks(6633));
        }
    }
}
