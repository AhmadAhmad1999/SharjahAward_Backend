using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class primaryToSubscriber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Achievement_Users_subscriberId",
                table: "Achievement");

            migrationBuilder.DropForeignKey(
                name: "FK_AchievementClassification_Users_CreatedById",
                table: "AchievementClassification");

            migrationBuilder.DropForeignKey(
                name: "FK_AchievementClassification_Users_UpdatedById",
                table: "AchievementClassification");

            migrationBuilder.DropForeignKey(
                name: "FK_Agenda_Users_CreatedById",
                table: "Agenda");

            migrationBuilder.DropForeignKey(
                name: "FK_Agenda_Users_UpdatedById",
                table: "Agenda");

            migrationBuilder.DropForeignKey(
                name: "FK_ArbitrationProcedure_Users_CreatedById",
                table: "ArbitrationProcedure");

            migrationBuilder.DropForeignKey(
                name: "FK_ArbitrationProcedure_Users_UpdatedById",
                table: "ArbitrationProcedure");

            migrationBuilder.DropForeignKey(
                name: "FK_Arbitrator_Users_CreatedById",
                table: "Arbitrator");

            migrationBuilder.DropForeignKey(
                name: "FK_Arbitrator_Users_UpdatedById",
                table: "Arbitrator");

            migrationBuilder.DropForeignKey(
                name: "FK_Category_Users_CreatedById",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_Category_Users_UpdatedById",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_categoryCommittees_Users_CreatedById",
                table: "categoryCommittees");

            migrationBuilder.DropForeignKey(
                name: "FK_categoryCommittees_Users_UpdatedById",
                table: "categoryCommittees");

            migrationBuilder.DropForeignKey(
                name: "FK_Committee_Users_ChairmanId",
                table: "Committee");

            migrationBuilder.DropForeignKey(
                name: "FK_Committee_Users_CreatedById",
                table: "Committee");

            migrationBuilder.DropForeignKey(
                name: "FK_Committee_Users_UpdatedById",
                table: "Committee");

            migrationBuilder.DropForeignKey(
                name: "FK_Coordinator_Users_CreatedById",
                table: "Coordinator");

            migrationBuilder.DropForeignKey(
                name: "FK_Coordinator_Users_UpdatedById",
                table: "Coordinator");

            migrationBuilder.DropForeignKey(
                name: "FK_Criterion_Users_CreatedById",
                table: "Criterion");

            migrationBuilder.DropForeignKey(
                name: "FK_Criterion_Users_UpdatedById",
                table: "Criterion");

            migrationBuilder.DropForeignKey(
                name: "FK_CriterionItem_Users_CreatedById",
                table: "CriterionItem");

            migrationBuilder.DropForeignKey(
                name: "FK_CriterionItem_Users_UpdatedById",
                table: "CriterionItem");

            migrationBuilder.DropForeignKey(
                name: "FK_criterionItemScales_Users_CreatedById",
                table: "criterionItemScales");

            migrationBuilder.DropForeignKey(
                name: "FK_criterionItemScales_Users_UpdatedById",
                table: "criterionItemScales");

            migrationBuilder.DropForeignKey(
                name: "FK_CycleCondition_Users_CreatedById",
                table: "CycleCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_CycleCondition_Users_UpdatedById",
                table: "CycleCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_EducationalClass_Users_CreatedById",
                table: "EducationalClass");

            migrationBuilder.DropForeignKey(
                name: "FK_EducationalClass_Users_UpdatedById",
                table: "EducationalClass");

            migrationBuilder.DropForeignKey(
                name: "FK_FrequentlyAskedQuestion_Users_CreatedById",
                table: "FrequentlyAskedQuestion");

            migrationBuilder.DropForeignKey(
                name: "FK_FrequentlyAskedQuestion_Users_UpdatedById",
                table: "FrequentlyAskedQuestion");

            migrationBuilder.DropForeignKey(
                name: "FK_Interview_Users_CreatedById",
                table: "Interview");

            migrationBuilder.DropForeignKey(
                name: "FK_Interview_Users_UpdatedById",
                table: "Interview");

            migrationBuilder.DropForeignKey(
                name: "FK_Meeting_Users_CreatedById",
                table: "Meeting");

            migrationBuilder.DropForeignKey(
                name: "FK_Meeting_Users_UpdatedById",
                table: "Meeting");

            migrationBuilder.DropForeignKey(
                name: "FK_MeetingSubscriber_Users_subscriberId",
                table: "MeetingSubscriber");

            migrationBuilder.DropForeignKey(
                name: "FK_MeetingUser_Users_UserId",
                table: "MeetingUser");

            migrationBuilder.DropForeignKey(
                name: "FK_News_Users_CreatedById",
                table: "News");

            migrationBuilder.DropForeignKey(
                name: "FK_News_Users_UpdatedById",
                table: "News");

            migrationBuilder.DropForeignKey(
                name: "FK_Note_Users_UserId",
                table: "Note");

            migrationBuilder.DropForeignKey(
                name: "FK_ProvidedForm_Users_CreatedById",
                table: "ProvidedForm");

            migrationBuilder.DropForeignKey(
                name: "FK_ProvidedForm_Users_UpdatedById",
                table: "ProvidedForm");

            migrationBuilder.DropForeignKey(
                name: "FK_ProvidedForm_Users_subscriberId",
                table: "ProvidedForm");

            migrationBuilder.DropForeignKey(
                name: "FK_RelatedAccount_Users_CreatedById",
                table: "RelatedAccount");

            migrationBuilder.DropForeignKey(
                name: "FK_RelatedAccount_Users_SubscriberId",
                table: "RelatedAccount");

            migrationBuilder.DropForeignKey(
                name: "FK_RelatedAccount_Users_UpdatedById",
                table: "RelatedAccount");

            migrationBuilder.DropForeignKey(
                name: "FK_Scale_Users_CreatedById",
                table: "Scale");

            migrationBuilder.DropForeignKey(
                name: "FK_Scale_Users_UpdatedById",
                table: "Scale");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriberAchievement_Users_CreatedById",
                table: "SubscriberAchievement");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriberAchievement_Users_SubscriberId",
                table: "SubscriberAchievement");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriberAchievement_Users_UpdatedById",
                table: "SubscriberAchievement");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriberInterview_Users_SubscriberId",
                table: "SubscriberInterview");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriberTrainingWorkshop_Users_SubscribersId",
                table: "SubscriberTrainingWorkshop");

            migrationBuilder.DropForeignKey(
                name: "FK_TermsAndConditions_Users_CreatedById",
                table: "TermsAndConditions");

            migrationBuilder.DropForeignKey(
                name: "FK_TermsAndConditions_Users_UpdatedById",
                table: "TermsAndConditions");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingManual_Users_CreatedById",
                table: "TrainingManual");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingManual_Users_UpdatedById",
                table: "TrainingManual");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingWorkshop_Users_CreatedById",
                table: "TrainingWorkshop");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingWorkshop_Users_UpdatedById",
                table: "TrainingWorkshop");

            migrationBuilder.DropForeignKey(
                name: "FK_trainingWorkshopSubscribers_Users_CreatedById",
                table: "trainingWorkshopSubscribers");

            migrationBuilder.DropForeignKey(
                name: "FK_trainingWorkshopSubscribers_Users_SubscribersId",
                table: "trainingWorkshopSubscribers");

            migrationBuilder.DropForeignKey(
                name: "FK_trainingWorkshopSubscribers_Users_UpdatedById",
                table: "trainingWorkshopSubscribers");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IdentityNumber",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SubscriptionDate",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "users");

            migrationBuilder.RenameIndex(
                name: "IX_Users_RoleId",
                table: "users",
                newName: "IX_users_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "subscribers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubscriptionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IdentityNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subscribers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_subscribers_users_Id",
                        column: x => x.Id,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Achievement_subscribers_subscriberId",
                table: "Achievement",
                column: "subscriberId",
                principalTable: "subscribers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AchievementClassification_users_CreatedById",
                table: "AchievementClassification",
                column: "CreatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AchievementClassification_users_UpdatedById",
                table: "AchievementClassification",
                column: "UpdatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Agenda_users_CreatedById",
                table: "Agenda",
                column: "CreatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Agenda_users_UpdatedById",
                table: "Agenda",
                column: "UpdatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ArbitrationProcedure_users_CreatedById",
                table: "ArbitrationProcedure",
                column: "CreatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ArbitrationProcedure_users_UpdatedById",
                table: "ArbitrationProcedure",
                column: "UpdatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Arbitrator_users_CreatedById",
                table: "Arbitrator",
                column: "CreatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Arbitrator_users_UpdatedById",
                table: "Arbitrator",
                column: "UpdatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_users_CreatedById",
                table: "Category",
                column: "CreatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_users_UpdatedById",
                table: "Category",
                column: "UpdatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_categoryCommittees_users_CreatedById",
                table: "categoryCommittees",
                column: "CreatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_categoryCommittees_users_UpdatedById",
                table: "categoryCommittees",
                column: "UpdatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Committee_users_ChairmanId",
                table: "Committee",
                column: "ChairmanId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Committee_users_CreatedById",
                table: "Committee",
                column: "CreatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Committee_users_UpdatedById",
                table: "Committee",
                column: "UpdatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Coordinator_users_CreatedById",
                table: "Coordinator",
                column: "CreatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Coordinator_users_UpdatedById",
                table: "Coordinator",
                column: "UpdatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Criterion_users_CreatedById",
                table: "Criterion",
                column: "CreatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Criterion_users_UpdatedById",
                table: "Criterion",
                column: "UpdatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CriterionItem_users_CreatedById",
                table: "CriterionItem",
                column: "CreatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CriterionItem_users_UpdatedById",
                table: "CriterionItem",
                column: "UpdatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_criterionItemScales_users_CreatedById",
                table: "criterionItemScales",
                column: "CreatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_criterionItemScales_users_UpdatedById",
                table: "criterionItemScales",
                column: "UpdatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CycleCondition_users_CreatedById",
                table: "CycleCondition",
                column: "CreatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CycleCondition_users_UpdatedById",
                table: "CycleCondition",
                column: "UpdatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EducationalClass_users_CreatedById",
                table: "EducationalClass",
                column: "CreatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EducationalClass_users_UpdatedById",
                table: "EducationalClass",
                column: "UpdatedById",
                principalTable: "users",
                principalColumn: "Id");

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
                name: "FK_Interview_users_CreatedById",
                table: "Interview",
                column: "CreatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Interview_users_UpdatedById",
                table: "Interview",
                column: "UpdatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Meeting_users_CreatedById",
                table: "Meeting",
                column: "CreatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Meeting_users_UpdatedById",
                table: "Meeting",
                column: "UpdatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MeetingSubscriber_subscribers_subscriberId",
                table: "MeetingSubscriber",
                column: "subscriberId",
                principalTable: "subscribers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MeetingUser_users_UserId",
                table: "MeetingUser",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_Note_users_UserId",
                table: "Note",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProvidedForm_subscribers_subscriberId",
                table: "ProvidedForm",
                column: "subscriberId",
                principalTable: "subscribers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProvidedForm_users_CreatedById",
                table: "ProvidedForm",
                column: "CreatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProvidedForm_users_UpdatedById",
                table: "ProvidedForm",
                column: "UpdatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RelatedAccount_subscribers_SubscriberId",
                table: "RelatedAccount",
                column: "SubscriberId",
                principalTable: "subscribers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RelatedAccount_users_CreatedById",
                table: "RelatedAccount",
                column: "CreatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RelatedAccount_users_UpdatedById",
                table: "RelatedAccount",
                column: "UpdatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Scale_users_CreatedById",
                table: "Scale",
                column: "CreatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Scale_users_UpdatedById",
                table: "Scale",
                column: "UpdatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriberAchievement_subscribers_SubscriberId",
                table: "SubscriberAchievement",
                column: "SubscriberId",
                principalTable: "subscribers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriberAchievement_users_CreatedById",
                table: "SubscriberAchievement",
                column: "CreatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriberAchievement_users_UpdatedById",
                table: "SubscriberAchievement",
                column: "UpdatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriberInterview_subscribers_SubscriberId",
                table: "SubscriberInterview",
                column: "SubscriberId",
                principalTable: "subscribers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriberTrainingWorkshop_subscribers_SubscribersId",
                table: "SubscriberTrainingWorkshop",
                column: "SubscribersId",
                principalTable: "subscribers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TermsAndConditions_users_CreatedById",
                table: "TermsAndConditions",
                column: "CreatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TermsAndConditions_users_UpdatedById",
                table: "TermsAndConditions",
                column: "UpdatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingManual_users_CreatedById",
                table: "TrainingManual",
                column: "CreatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingManual_users_UpdatedById",
                table: "TrainingManual",
                column: "UpdatedById",
                principalTable: "users",
                principalColumn: "Id");

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
                name: "FK_trainingWorkshopSubscribers_subscribers_SubscribersId",
                table: "trainingWorkshopSubscribers",
                column: "SubscribersId",
                principalTable: "subscribers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_trainingWorkshopSubscribers_users_CreatedById",
                table: "trainingWorkshopSubscribers",
                column: "CreatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_trainingWorkshopSubscribers_users_UpdatedById",
                table: "trainingWorkshopSubscribers",
                column: "UpdatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_users_Roles_RoleId",
                table: "users",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Achievement_subscribers_subscriberId",
                table: "Achievement");

            migrationBuilder.DropForeignKey(
                name: "FK_AchievementClassification_users_CreatedById",
                table: "AchievementClassification");

            migrationBuilder.DropForeignKey(
                name: "FK_AchievementClassification_users_UpdatedById",
                table: "AchievementClassification");

            migrationBuilder.DropForeignKey(
                name: "FK_Agenda_users_CreatedById",
                table: "Agenda");

            migrationBuilder.DropForeignKey(
                name: "FK_Agenda_users_UpdatedById",
                table: "Agenda");

            migrationBuilder.DropForeignKey(
                name: "FK_ArbitrationProcedure_users_CreatedById",
                table: "ArbitrationProcedure");

            migrationBuilder.DropForeignKey(
                name: "FK_ArbitrationProcedure_users_UpdatedById",
                table: "ArbitrationProcedure");

            migrationBuilder.DropForeignKey(
                name: "FK_Arbitrator_users_CreatedById",
                table: "Arbitrator");

            migrationBuilder.DropForeignKey(
                name: "FK_Arbitrator_users_UpdatedById",
                table: "Arbitrator");

            migrationBuilder.DropForeignKey(
                name: "FK_Category_users_CreatedById",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_Category_users_UpdatedById",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_categoryCommittees_users_CreatedById",
                table: "categoryCommittees");

            migrationBuilder.DropForeignKey(
                name: "FK_categoryCommittees_users_UpdatedById",
                table: "categoryCommittees");

            migrationBuilder.DropForeignKey(
                name: "FK_Committee_users_ChairmanId",
                table: "Committee");

            migrationBuilder.DropForeignKey(
                name: "FK_Committee_users_CreatedById",
                table: "Committee");

            migrationBuilder.DropForeignKey(
                name: "FK_Committee_users_UpdatedById",
                table: "Committee");

            migrationBuilder.DropForeignKey(
                name: "FK_Coordinator_users_CreatedById",
                table: "Coordinator");

            migrationBuilder.DropForeignKey(
                name: "FK_Coordinator_users_UpdatedById",
                table: "Coordinator");

            migrationBuilder.DropForeignKey(
                name: "FK_Criterion_users_CreatedById",
                table: "Criterion");

            migrationBuilder.DropForeignKey(
                name: "FK_Criterion_users_UpdatedById",
                table: "Criterion");

            migrationBuilder.DropForeignKey(
                name: "FK_CriterionItem_users_CreatedById",
                table: "CriterionItem");

            migrationBuilder.DropForeignKey(
                name: "FK_CriterionItem_users_UpdatedById",
                table: "CriterionItem");

            migrationBuilder.DropForeignKey(
                name: "FK_criterionItemScales_users_CreatedById",
                table: "criterionItemScales");

            migrationBuilder.DropForeignKey(
                name: "FK_criterionItemScales_users_UpdatedById",
                table: "criterionItemScales");

            migrationBuilder.DropForeignKey(
                name: "FK_CycleCondition_users_CreatedById",
                table: "CycleCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_CycleCondition_users_UpdatedById",
                table: "CycleCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_EducationalClass_users_CreatedById",
                table: "EducationalClass");

            migrationBuilder.DropForeignKey(
                name: "FK_EducationalClass_users_UpdatedById",
                table: "EducationalClass");

            migrationBuilder.DropForeignKey(
                name: "FK_FrequentlyAskedQuestion_users_CreatedById",
                table: "FrequentlyAskedQuestion");

            migrationBuilder.DropForeignKey(
                name: "FK_FrequentlyAskedQuestion_users_UpdatedById",
                table: "FrequentlyAskedQuestion");

            migrationBuilder.DropForeignKey(
                name: "FK_Interview_users_CreatedById",
                table: "Interview");

            migrationBuilder.DropForeignKey(
                name: "FK_Interview_users_UpdatedById",
                table: "Interview");

            migrationBuilder.DropForeignKey(
                name: "FK_Meeting_users_CreatedById",
                table: "Meeting");

            migrationBuilder.DropForeignKey(
                name: "FK_Meeting_users_UpdatedById",
                table: "Meeting");

            migrationBuilder.DropForeignKey(
                name: "FK_MeetingSubscriber_subscribers_subscriberId",
                table: "MeetingSubscriber");

            migrationBuilder.DropForeignKey(
                name: "FK_MeetingUser_users_UserId",
                table: "MeetingUser");

            migrationBuilder.DropForeignKey(
                name: "FK_News_users_CreatedById",
                table: "News");

            migrationBuilder.DropForeignKey(
                name: "FK_News_users_UpdatedById",
                table: "News");

            migrationBuilder.DropForeignKey(
                name: "FK_Note_users_UserId",
                table: "Note");

            migrationBuilder.DropForeignKey(
                name: "FK_ProvidedForm_subscribers_subscriberId",
                table: "ProvidedForm");

            migrationBuilder.DropForeignKey(
                name: "FK_ProvidedForm_users_CreatedById",
                table: "ProvidedForm");

            migrationBuilder.DropForeignKey(
                name: "FK_ProvidedForm_users_UpdatedById",
                table: "ProvidedForm");

            migrationBuilder.DropForeignKey(
                name: "FK_RelatedAccount_subscribers_SubscriberId",
                table: "RelatedAccount");

            migrationBuilder.DropForeignKey(
                name: "FK_RelatedAccount_users_CreatedById",
                table: "RelatedAccount");

            migrationBuilder.DropForeignKey(
                name: "FK_RelatedAccount_users_UpdatedById",
                table: "RelatedAccount");

            migrationBuilder.DropForeignKey(
                name: "FK_Scale_users_CreatedById",
                table: "Scale");

            migrationBuilder.DropForeignKey(
                name: "FK_Scale_users_UpdatedById",
                table: "Scale");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriberAchievement_subscribers_SubscriberId",
                table: "SubscriberAchievement");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriberAchievement_users_CreatedById",
                table: "SubscriberAchievement");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriberAchievement_users_UpdatedById",
                table: "SubscriberAchievement");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriberInterview_subscribers_SubscriberId",
                table: "SubscriberInterview");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscriberTrainingWorkshop_subscribers_SubscribersId",
                table: "SubscriberTrainingWorkshop");

            migrationBuilder.DropForeignKey(
                name: "FK_TermsAndConditions_users_CreatedById",
                table: "TermsAndConditions");

            migrationBuilder.DropForeignKey(
                name: "FK_TermsAndConditions_users_UpdatedById",
                table: "TermsAndConditions");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingManual_users_CreatedById",
                table: "TrainingManual");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingManual_users_UpdatedById",
                table: "TrainingManual");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingWorkshop_users_CreatedById",
                table: "TrainingWorkshop");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingWorkshop_users_UpdatedById",
                table: "TrainingWorkshop");

            migrationBuilder.DropForeignKey(
                name: "FK_trainingWorkshopSubscribers_subscribers_SubscribersId",
                table: "trainingWorkshopSubscribers");

            migrationBuilder.DropForeignKey(
                name: "FK_trainingWorkshopSubscribers_users_CreatedById",
                table: "trainingWorkshopSubscribers");

            migrationBuilder.DropForeignKey(
                name: "FK_trainingWorkshopSubscribers_users_UpdatedById",
                table: "trainingWorkshopSubscribers");

            migrationBuilder.DropForeignKey(
                name: "FK_users_Roles_RoleId",
                table: "users");

            migrationBuilder.DropTable(
                name: "subscribers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "Users");

            migrationBuilder.RenameIndex(
                name: "IX_users_RoleId",
                table: "Users",
                newName: "IX_Users_RoleId");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Users",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IdentityNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SubscriptionDate",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Achievement_Users_subscriberId",
                table: "Achievement",
                column: "subscriberId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AchievementClassification_Users_CreatedById",
                table: "AchievementClassification",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AchievementClassification_Users_UpdatedById",
                table: "AchievementClassification",
                column: "UpdatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Agenda_Users_CreatedById",
                table: "Agenda",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Agenda_Users_UpdatedById",
                table: "Agenda",
                column: "UpdatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ArbitrationProcedure_Users_CreatedById",
                table: "ArbitrationProcedure",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ArbitrationProcedure_Users_UpdatedById",
                table: "ArbitrationProcedure",
                column: "UpdatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Arbitrator_Users_CreatedById",
                table: "Arbitrator",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Arbitrator_Users_UpdatedById",
                table: "Arbitrator",
                column: "UpdatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Users_CreatedById",
                table: "Category",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Users_UpdatedById",
                table: "Category",
                column: "UpdatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_categoryCommittees_Users_CreatedById",
                table: "categoryCommittees",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_categoryCommittees_Users_UpdatedById",
                table: "categoryCommittees",
                column: "UpdatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Committee_Users_ChairmanId",
                table: "Committee",
                column: "ChairmanId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Committee_Users_CreatedById",
                table: "Committee",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Committee_Users_UpdatedById",
                table: "Committee",
                column: "UpdatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Coordinator_Users_CreatedById",
                table: "Coordinator",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Coordinator_Users_UpdatedById",
                table: "Coordinator",
                column: "UpdatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Criterion_Users_CreatedById",
                table: "Criterion",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Criterion_Users_UpdatedById",
                table: "Criterion",
                column: "UpdatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CriterionItem_Users_CreatedById",
                table: "CriterionItem",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CriterionItem_Users_UpdatedById",
                table: "CriterionItem",
                column: "UpdatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_criterionItemScales_Users_CreatedById",
                table: "criterionItemScales",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_criterionItemScales_Users_UpdatedById",
                table: "criterionItemScales",
                column: "UpdatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CycleCondition_Users_CreatedById",
                table: "CycleCondition",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CycleCondition_Users_UpdatedById",
                table: "CycleCondition",
                column: "UpdatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EducationalClass_Users_CreatedById",
                table: "EducationalClass",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EducationalClass_Users_UpdatedById",
                table: "EducationalClass",
                column: "UpdatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FrequentlyAskedQuestion_Users_CreatedById",
                table: "FrequentlyAskedQuestion",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FrequentlyAskedQuestion_Users_UpdatedById",
                table: "FrequentlyAskedQuestion",
                column: "UpdatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Interview_Users_CreatedById",
                table: "Interview",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Interview_Users_UpdatedById",
                table: "Interview",
                column: "UpdatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Meeting_Users_CreatedById",
                table: "Meeting",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Meeting_Users_UpdatedById",
                table: "Meeting",
                column: "UpdatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MeetingSubscriber_Users_subscriberId",
                table: "MeetingSubscriber",
                column: "subscriberId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MeetingUser_Users_UserId",
                table: "MeetingUser",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_News_Users_CreatedById",
                table: "News",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_News_Users_UpdatedById",
                table: "News",
                column: "UpdatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Note_Users_UserId",
                table: "Note",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProvidedForm_Users_CreatedById",
                table: "ProvidedForm",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProvidedForm_Users_UpdatedById",
                table: "ProvidedForm",
                column: "UpdatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProvidedForm_Users_subscriberId",
                table: "ProvidedForm",
                column: "subscriberId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RelatedAccount_Users_CreatedById",
                table: "RelatedAccount",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RelatedAccount_Users_SubscriberId",
                table: "RelatedAccount",
                column: "SubscriberId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RelatedAccount_Users_UpdatedById",
                table: "RelatedAccount",
                column: "UpdatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Scale_Users_CreatedById",
                table: "Scale",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Scale_Users_UpdatedById",
                table: "Scale",
                column: "UpdatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriberAchievement_Users_CreatedById",
                table: "SubscriberAchievement",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriberAchievement_Users_SubscriberId",
                table: "SubscriberAchievement",
                column: "SubscriberId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriberAchievement_Users_UpdatedById",
                table: "SubscriberAchievement",
                column: "UpdatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriberInterview_Users_SubscriberId",
                table: "SubscriberInterview",
                column: "SubscriberId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriberTrainingWorkshop_Users_SubscribersId",
                table: "SubscriberTrainingWorkshop",
                column: "SubscribersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TermsAndConditions_Users_CreatedById",
                table: "TermsAndConditions",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TermsAndConditions_Users_UpdatedById",
                table: "TermsAndConditions",
                column: "UpdatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingManual_Users_CreatedById",
                table: "TrainingManual",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingManual_Users_UpdatedById",
                table: "TrainingManual",
                column: "UpdatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingWorkshop_Users_CreatedById",
                table: "TrainingWorkshop",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingWorkshop_Users_UpdatedById",
                table: "TrainingWorkshop",
                column: "UpdatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_trainingWorkshopSubscribers_Users_CreatedById",
                table: "trainingWorkshopSubscribers",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_trainingWorkshopSubscribers_Users_SubscribersId",
                table: "trainingWorkshopSubscribers",
                column: "SubscribersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_trainingWorkshopSubscribers_Users_UpdatedById",
                table: "trainingWorkshopSubscribers",
                column: "UpdatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "RoleId");
        }
    }
}
