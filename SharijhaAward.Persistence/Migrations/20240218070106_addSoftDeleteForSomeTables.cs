using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addSoftDeleteForSomeTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FrequentlyAskedQuestion_Categories_CategoryId",
                table: "FrequentlyAskedQuestion");

            migrationBuilder.DropForeignKey(
                name: "FK_FrequentlyAskedQuestion_users_CreatedById",
                table: "FrequentlyAskedQuestion");

            migrationBuilder.DropForeignKey(
                name: "FK_FrequentlyAskedQuestion_users_UpdatedById",
                table: "FrequentlyAskedQuestion");

            migrationBuilder.DropForeignKey(
                name: "FK_News_users_CreatedById",
                table: "News");

            migrationBuilder.DropForeignKey(
                name: "FK_News_users_UpdatedById",
                table: "News");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriberTrainingWorkshop_TrainingWorkshop_TrainingWorkshopsId",
                table: "SubscriberTrainingWorkshop");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingWorkshop_Categories_CategoryId",
                table: "TrainingWorkshop");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingWorkshop_users_CreatedById",
                table: "TrainingWorkshop");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingWorkshop_users_UpdatedById",
                table: "TrainingWorkshop");

            migrationBuilder.DropForeignKey(
                name: "FK_trainingWorkshopSubscribers_TrainingWorkshop_TrainingWorkshopsId",
                table: "trainingWorkshopSubscribers");

            migrationBuilder.DropIndex(
                name: "IX_News_CreatedById",
                table: "News");

            migrationBuilder.DropIndex(
                name: "IX_News_UpdatedById",
                table: "News");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainingWorkshop",
                table: "TrainingWorkshop");

            migrationBuilder.DropIndex(
                name: "IX_TrainingWorkshop_CreatedById",
                table: "TrainingWorkshop");

            migrationBuilder.DropIndex(
                name: "IX_TrainingWorkshop_UpdatedById",
                table: "TrainingWorkshop");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FrequentlyAskedQuestion",
                table: "FrequentlyAskedQuestion");

            migrationBuilder.DropIndex(
                name: "IX_FrequentlyAskedQuestion_CreatedById",
                table: "FrequentlyAskedQuestion");

            migrationBuilder.DropIndex(
                name: "IX_FrequentlyAskedQuestion_UpdatedById",
                table: "FrequentlyAskedQuestion");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "News");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "News");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "News");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "News");

            migrationBuilder.DropColumn(
                name: "Visible",
                table: "News");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "TrainingWorkshop");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "TrainingWorkshop");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "TrainingWorkshop");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "TrainingWorkshop");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "FrequentlyAskedQuestion");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "FrequentlyAskedQuestion");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "FrequentlyAskedQuestion");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "FrequentlyAskedQuestion");

            migrationBuilder.RenameTable(
                name: "TrainingWorkshop",
                newName: "trainingWorkshops");

            migrationBuilder.RenameTable(
                name: "FrequentlyAskedQuestion",
                newName: "frequentlyAskedQuestions");

            migrationBuilder.RenameColumn(
                name: "IsDelete",
                table: "users",
                newName: "isDeleted");

            migrationBuilder.RenameColumn(
                name: "IsDelete",
                table: "Personalnvitees",
                newName: "isDeleted");

            migrationBuilder.RenameColumn(
                name: "IsDelete",
                table: "GroupInvitees",
                newName: "isDeleted");

            migrationBuilder.RenameColumn(
                name: "IsDelete",
                table: "cycles",
                newName: "isDeleted");

            migrationBuilder.RenameColumn(
                name: "IsDelete",
                table: "Categories",
                newName: "isDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_TrainingWorkshop_CategoryId",
                table: "trainingWorkshops",
                newName: "IX_trainingWorkshops_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_FrequentlyAskedQuestion_CategoryId",
                table: "frequentlyAskedQuestions",
                newName: "IX_frequentlyAskedQuestions_CategoryId");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Roles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Roles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Personalnvitees",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "News",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "GroupInvitees",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MainDynamicAttributeId",
                table: "Dependencies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "cycles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Categories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "trainingWorkshops",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "frequentlyAskedQuestions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_trainingWorkshops",
                table: "trainingWorkshops",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_frequentlyAskedQuestions",
                table: "frequentlyAskedQuestions",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                columns: new[] { "DeletedAt", "isDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                columns: new[] { "DeletedAt", "isDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                columns: new[] { "DeletedAt", "isDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                columns: new[] { "DeletedAt", "isDeleted" },
                values: new object[] { null, false });

            migrationBuilder.UpdateData(
                table: "cycles",
                keyColumn: "Id",
                keyValue: new Guid("784454bd-2d6c-49ae-9e8a-1932bd15aac1"),
                column: "DeletedAt",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Dependencies_MainDynamicAttributeId",
                table: "Dependencies",
                column: "MainDynamicAttributeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dependencies_DynamicAttributes_MainDynamicAttributeId",
                table: "Dependencies",
                column: "MainDynamicAttributeId",
                principalTable: "DynamicAttributes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_frequentlyAskedQuestions_Categories_CategoryId",
                table: "frequentlyAskedQuestions",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriberTrainingWorkshop_trainingWorkshops_TrainingWorkshopsId",
                table: "SubscriberTrainingWorkshop",
                column: "TrainingWorkshopsId",
                principalTable: "trainingWorkshops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_trainingWorkshops_Categories_CategoryId",
                table: "trainingWorkshops",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_trainingWorkshopSubscribers_trainingWorkshops_TrainingWorkshopsId",
                table: "trainingWorkshopSubscribers",
                column: "TrainingWorkshopsId",
                principalTable: "trainingWorkshops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dependencies_DynamicAttributes_MainDynamicAttributeId",
                table: "Dependencies");

            migrationBuilder.DropForeignKey(
                name: "FK_frequentlyAskedQuestions_Categories_CategoryId",
                table: "frequentlyAskedQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriberTrainingWorkshop_trainingWorkshops_TrainingWorkshopsId",
                table: "SubscriberTrainingWorkshop");

            migrationBuilder.DropForeignKey(
                name: "FK_trainingWorkshops_Categories_CategoryId",
                table: "trainingWorkshops");

            migrationBuilder.DropForeignKey(
                name: "FK_trainingWorkshopSubscribers_trainingWorkshops_TrainingWorkshopsId",
                table: "trainingWorkshopSubscribers");

            migrationBuilder.DropIndex(
                name: "IX_Dependencies_MainDynamicAttributeId",
                table: "Dependencies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_trainingWorkshops",
                table: "trainingWorkshops");

            migrationBuilder.DropPrimaryKey(
                name: "PK_frequentlyAskedQuestions",
                table: "frequentlyAskedQuestions");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "users");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Personalnvitees");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "News");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "GroupInvitees");

            migrationBuilder.DropColumn(
                name: "MainDynamicAttributeId",
                table: "Dependencies");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "cycles");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "trainingWorkshops");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "frequentlyAskedQuestions");

            migrationBuilder.RenameTable(
                name: "trainingWorkshops",
                newName: "TrainingWorkshop");

            migrationBuilder.RenameTable(
                name: "frequentlyAskedQuestions",
                newName: "FrequentlyAskedQuestion");

            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "users",
                newName: "IsDelete");

            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "Personalnvitees",
                newName: "IsDelete");

            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "GroupInvitees",
                newName: "IsDelete");

            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "cycles",
                newName: "IsDelete");

            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "Categories",
                newName: "IsDelete");

            migrationBuilder.RenameIndex(
                name: "IX_trainingWorkshops_CategoryId",
                table: "TrainingWorkshop",
                newName: "IX_TrainingWorkshop_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_frequentlyAskedQuestions_CategoryId",
                table: "FrequentlyAskedQuestion",
                newName: "IX_FrequentlyAskedQuestion_CategoryId");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedById",
                table: "News",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedById",
                table: "News",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "Visible",
                table: "News",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "TrainingWorkshop",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedById",
                table: "TrainingWorkshop",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "TrainingWorkshop",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedById",
                table: "TrainingWorkshop",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "FrequentlyAskedQuestion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedById",
                table: "FrequentlyAskedQuestion",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "FrequentlyAskedQuestion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedById",
                table: "FrequentlyAskedQuestion",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainingWorkshop",
                table: "TrainingWorkshop",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FrequentlyAskedQuestion",
                table: "FrequentlyAskedQuestion",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_News_CreatedById",
                table: "News",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_News_UpdatedById",
                table: "News",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingWorkshop_CreatedById",
                table: "TrainingWorkshop",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingWorkshop_UpdatedById",
                table: "TrainingWorkshop",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_FrequentlyAskedQuestion_CreatedById",
                table: "FrequentlyAskedQuestion",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_FrequentlyAskedQuestion_UpdatedById",
                table: "FrequentlyAskedQuestion",
                column: "UpdatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_FrequentlyAskedQuestion_Categories_CategoryId",
                table: "FrequentlyAskedQuestion",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FrequentlyAskedQuestion_users_CreatedById",
                table: "FrequentlyAskedQuestion",
                column: "CreatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FrequentlyAskedQuestion_users_UpdatedById",
                table: "FrequentlyAskedQuestion",
                column: "UpdatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_News_users_CreatedById",
                table: "News",
                column: "CreatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_News_users_UpdatedById",
                table: "News",
                column: "UpdatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriberTrainingWorkshop_TrainingWorkshop_TrainingWorkshopsId",
                table: "SubscriberTrainingWorkshop",
                column: "TrainingWorkshopsId",
                principalTable: "TrainingWorkshop",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingWorkshop_Categories_CategoryId",
                table: "TrainingWorkshop",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingWorkshop_users_CreatedById",
                table: "TrainingWorkshop",
                column: "CreatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingWorkshop_users_UpdatedById",
                table: "TrainingWorkshop",
                column: "UpdatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_trainingWorkshopSubscribers_TrainingWorkshop_TrainingWorkshopsId",
                table: "trainingWorkshopSubscribers",
                column: "TrainingWorkshopsId",
                principalTable: "TrainingWorkshop",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
