using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RevertLastMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UserRole_CreatedAt",
                table: "UsersRoles");

            migrationBuilder.DropIndex(
                name: "IX_User_CreatedAt",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_TrainingWrokshopeAttachment_CreatedAt",
                table: "TrainingWrokshopeAttachment");

            migrationBuilder.DropIndex(
                name: "IX_TrainingWorkshopSubscriber_CreatedAt",
                table: "TrainingWorkshopSubscribers");

            migrationBuilder.DropIndex(
                name: "IX_TrainingWorkshop_CreatedAt",
                table: "TrainingWorkshops");

            migrationBuilder.DropIndex(
                name: "IX_TermAndCondition_CreatedAt",
                table: "TermsAndConditions");

            migrationBuilder.DropIndex(
                name: "IX_Student_CreatedAt",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_StaticAttribute_CreatedAt",
                table: "StaticAttributes");

            migrationBuilder.DropIndex(
                name: "IX_Scale_CreatedAt",
                table: "Scale");

            migrationBuilder.DropIndex(
                name: "IX_Role_CreatedAt",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_RolePermission_CreatedAt",
                table: "RolePermissions");

            migrationBuilder.DropIndex(
                name: "IX_RelatedAccount_CreatedAt",
                table: "RelatedAccounts");

            migrationBuilder.DropIndex(
                name: "IX_RelatedAccountRequest_CreatedAt",
                table: "RelatedAccountRequests");

            migrationBuilder.DropIndex(
                name: "IX_ProvidedForm_CreatedAt",
                table: "ProvidedForms");

            migrationBuilder.DropIndex(
                name: "IX_PersonalInvitee_CreatedAt",
                table: "Personalnvitees");

            migrationBuilder.DropIndex(
                name: "IX_Permission_CreatedAt",
                table: "Permissions");

            migrationBuilder.DropIndex(
                name: "IX_PermissionHeader_CreatedAt",
                table: "PermissionHeaders");

            migrationBuilder.DropIndex(
                name: "IX_OurGoal_CreatedAt",
                table: "OurGoals");

            migrationBuilder.DropIndex(
                name: "IX_News_CreatedAt",
                table: "News");

            migrationBuilder.DropIndex(
                name: "IX_Meeting_CreatedAt",
                table: "Meeting");

            migrationBuilder.DropIndex(
                name: "IX_Interview_CreatedAt",
                table: "Interview");

            migrationBuilder.DropIndex(
                name: "IX_Instruction_CreatedAt",
                table: "Instructions");

            migrationBuilder.DropIndex(
                name: "IX_EduInstitutionCoordinator_CreatedAt",
                table: "InstitutionCoordinators");

            migrationBuilder.DropIndex(
                name: "IX_GroupInvitee_CreatedAt",
                table: "GroupInvitees");

            migrationBuilder.DropIndex(
                name: "IX_GeneralWorkshop_CreatedAt",
                table: "GeneralWorkshops");

            migrationBuilder.DropIndex(
                name: "IX_GeneralFAQ_CreatedAt",
                table: "GeneralFAQs");

            migrationBuilder.DropIndex(
                name: "IX_GeneralFAQCategory_CreatedAt",
                table: "GeneralFAQCategories");

            migrationBuilder.DropIndex(
                name: "IX_FrequentlyAskedQuestion_CreatedAt",
                table: "FrequentlyAskedQuestions");

            migrationBuilder.DropIndex(
                name: "IX_ExtraAttachmentFile_CreatedAt",
                table: "ExtraAttachmentsProvidedForms");

            migrationBuilder.DropIndex(
                name: "IX_ExtraAttachment_CreatedAt",
                table: "ExtraAttachments");

            migrationBuilder.DropIndex(
                name: "IX_ExplanatoryGuide_CreatedAt",
                table: "ExplanatoryGuides");

            migrationBuilder.DropIndex(
                name: "IX_Event_CreatedAt",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_EduEntitiesCoordinator_CreatedAt",
                table: "EducationCoordinators");

            migrationBuilder.DropIndex(
                name: "IX_EducationalInstitution_CreatedAt",
                table: "EducationalInstitutions");

            migrationBuilder.DropIndex(
                name: "IX_EducationalEntity_CreatedAt",
                table: "EducationalEntities");

            migrationBuilder.DropIndex(
                name: "IX_EducationalClass_CreatedAt",
                table: "EducationalClasses");

            migrationBuilder.DropIndex(
                name: "IX_DynamicAttributeValue_CreatedAt",
                table: "DynamicAttributeValues");

            migrationBuilder.DropIndex(
                name: "IX_DynamicAttributeSection_CreatedAt",
                table: "DynamicAttributeSections");

            migrationBuilder.DropIndex(
                name: "IX_DynamicAttribute_CreatedAt",
                table: "DynamicAttributes");

            migrationBuilder.DropIndex(
                name: "IX_DynamicAttributePatternValue_CreatedAt",
                table: "DynamicAttributePatternValues");

            migrationBuilder.DropIndex(
                name: "IX_DynamicAttributePattern_CreatedAt",
                table: "DynamicAttributePatterns");

            migrationBuilder.DropIndex(
                name: "IX_DynamicAttributeListValue_CreatedAt",
                table: "DynamicAttributeListValues");

            migrationBuilder.DropIndex(
                name: "IX_GeneralValidation_CreatedAt",
                table: "DynamicAttributeGeneralValidations");

            migrationBuilder.DropIndex(
                name: "IX_DependencyValidation_CreatedAt",
                table: "DependencyValidations");

            migrationBuilder.DropIndex(
                name: "IX_DependencyGroup_CreatedAt",
                table: "DependencyGroup");

            migrationBuilder.DropIndex(
                name: "IX_Dependency_CreatedAt",
                table: "Dependencies");

            migrationBuilder.DropIndex(
                name: "IX_Cycle_CreatedAt",
                table: "Cycles");

            migrationBuilder.DropIndex(
                name: "IX_CycleConditionsProvidedForm_CreatedAt",
                table: "CycleConditionsProvidedForms");

            migrationBuilder.DropIndex(
                name: "IX_CycleConditionAttachment_CreatedAt",
                table: "CycleConditionAttachments");

            migrationBuilder.DropIndex(
                name: "IX_CycleCondition_CreatedAt",
                table: "CycleCondition");

            migrationBuilder.DropIndex(
                name: "IX_Criterion_CreatedAt",
                table: "Criterions");

            migrationBuilder.DropIndex(
                name: "IX_CriterionItemScale_CreatedAt",
                table: "CriterionItemScales");

            migrationBuilder.DropIndex(
                name: "IX_CriterionItem_CreatedAt",
                table: "CriterionItems");

            migrationBuilder.DropIndex(
                name: "IX_CriterionItemAttachment_CreatedAt",
                table: "CriterionItemAttachments");

            migrationBuilder.DropIndex(
                name: "IX_CriterionAttachment_CreatedAt",
                table: "CriterionAttachments");

            migrationBuilder.DropIndex(
                name: "IX_Coordinator_CreatedAt",
                table: "Coordinators");

            migrationBuilder.DropIndex(
                name: "IX_ConditionAttachment_CreatedAt",
                table: "ConditionAttachments");

            migrationBuilder.DropIndex(
                name: "IX_Committee_CreatedAt",
                table: "Committees");

            migrationBuilder.DropIndex(
                name: "IX_CategoryFAQ_CreatedAt",
                table: "CategoryFAQs");

            migrationBuilder.DropIndex(
                name: "IX_CategoryEducationalClass_CreatedAt",
                table: "CategoryEducationalClasses");

            migrationBuilder.DropIndex(
                name: "IX_CategoryCommittee_CreatedAt",
                table: "CategoryCommittees");

            migrationBuilder.DropIndex(
                name: "IX_CategoryArbitrator_CreatedAt",
                table: "CategoriesArbitrators");

            migrationBuilder.DropIndex(
                name: "IX_Category_CreatedAt",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_AttributeTableName_CreatedAt",
                table: "AttributeTableNames");

            migrationBuilder.DropIndex(
                name: "IX_AttributeOperation_CreatedAt",
                table: "AttributeOperations");

            migrationBuilder.DropIndex(
                name: "IX_AttributeDataType_CreatedAt",
                table: "AttributeDataTypes");

            migrationBuilder.DropIndex(
                name: "IX_ConditionsProvidedForms_CreatedAt",
                table: "Attachments");

            migrationBuilder.DropIndex(
                name: "IX_Arbitrator_CreatedAt",
                table: "Arbitrators");

            migrationBuilder.DropIndex(
                name: "IX_ArbitratorClass_CreatedAt",
                table: "ArbitratorClasses");

            migrationBuilder.DropIndex(
                name: "IX_ArbitrationProcedure_CreatedAt",
                table: "ArbitrationProcedure");

            migrationBuilder.DropIndex(
                name: "IX_AppVersion_CreatedAt",
                table: "AppVersions");

            migrationBuilder.DropIndex(
                name: "IX_Agenda_CreatedAt",
                table: "Agendas");

            migrationBuilder.DropIndex(
                name: "IX_Achievement_CreatedAt",
                table: "Achievements");

            migrationBuilder.DropIndex(
                name: "IX_AboutAwardPage_CreatedAt",
                table: "AboutAwardPage");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6243), new DateTime(2024, 4, 25, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6248), new DateTime(2024, 4, 20, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6264), new DateTime(2024, 4, 30, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6267), new DateTime(2024, 4, 25, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6269) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6271), new DateTime(2024, 5, 5, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6273), new DateTime(2024, 4, 30, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6274) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6277), new DateTime(2024, 5, 10, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6279), new DateTime(2024, 5, 5, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6280) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6283), new DateTime(2024, 5, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6285), new DateTime(2024, 5, 10, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6287) });

            migrationBuilder.UpdateData(
                table: "Arbitrators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(9107));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(57));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(63));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(65));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(68));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(166));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(169));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(171));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(175));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(178));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(182));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(184));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(9955));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(9958));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(9961));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6627));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6998));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(5501));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(5514));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(9001));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(9011));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8903));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8907));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7350), new DateTime(2024, 4, 15, 15, 34, 37, 206, DateTimeKind.Local).AddTicks(7357) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7457), new DateTime(2024, 4, 15, 15, 34, 37, 206, DateTimeKind.Local).AddTicks(7459) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7465), new DateTime(2024, 4, 15, 15, 34, 37, 206, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7472), new DateTime(2024, 4, 15, 15, 34, 37, 206, DateTimeKind.Local).AddTicks(7476) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8403));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8412));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8426));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8434));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8437));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8443));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(7463), new DateTime(2024, 4, 20, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(7472), new DateTime(2024, 4, 17, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(7483), new DateTime(2024, 4, 18, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(7485) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(7488), new DateTime(2024, 4, 23, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(7492), new DateTime(2024, 4, 20, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(7493), new DateTime(2024, 4, 21, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(7495) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(9774));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(9864));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(9871));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(9198), new DateTime(2024, 4, 25, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(9203) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(9440), new DateTime(2024, 5, 5, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(9444) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7557));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6415));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(9623));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8531));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8535));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8616));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7656));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8214));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7107));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8387), new DateTime(2024, 4, 25, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8395), new DateTime(2024, 4, 20, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8402) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8405), new DateTime(2024, 4, 30, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8407), new DateTime(2024, 4, 25, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8409) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8411), new DateTime(2024, 5, 5, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8414), new DateTime(2024, 4, 30, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8415) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8417), new DateTime(2024, 5, 10, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8420), new DateTime(2024, 5, 5, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8421) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8424), new DateTime(2024, 5, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8426), new DateTime(2024, 5, 10, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8427) });

            migrationBuilder.UpdateData(
                table: "Arbitrators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3928));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(4047));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9065));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9098));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(8439));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(1433));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(1437));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(1442));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(1208));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(1302));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(1306));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(1311));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(1316));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(1336));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(1344));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9464), new DateTime(2024, 4, 15, 15, 25, 1, 516, DateTimeKind.Local).AddTicks(9471) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9565), new DateTime(2024, 4, 15, 15, 25, 1, 516, DateTimeKind.Local).AddTicks(9567) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9572), new DateTime(2024, 4, 15, 15, 25, 1, 516, DateTimeKind.Local).AddTicks(9574) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9579), new DateTime(2024, 4, 15, 15, 25, 1, 516, DateTimeKind.Local).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(857));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(891));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9384));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(1340), new DateTime(2024, 4, 20, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(1353), new DateTime(2024, 4, 17, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(1365), new DateTime(2024, 4, 18, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(1367) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(1369), new DateTime(2024, 4, 23, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(1372), new DateTime(2024, 4, 20, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(1374), new DateTime(2024, 4, 21, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(1375) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3731));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3073), new DateTime(2024, 4, 25, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3079) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3311), new DateTime(2024, 5, 5, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3314) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9813));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9821));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3475));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(982));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(987));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9901));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9913));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9927));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9932));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8894));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8901));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(637));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(646));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(655));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9197));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9209));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_CreatedAt",
                table: "UsersRoles",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_User_CreatedAt",
                table: "Users",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingWrokshopeAttachment_CreatedAt",
                table: "TrainingWrokshopeAttachment",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingWorkshopSubscriber_CreatedAt",
                table: "TrainingWorkshopSubscribers",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingWorkshop_CreatedAt",
                table: "TrainingWorkshops",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_TermAndCondition_CreatedAt",
                table: "TermsAndConditions",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_Student_CreatedAt",
                table: "Students",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_StaticAttribute_CreatedAt",
                table: "StaticAttributes",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_Scale_CreatedAt",
                table: "Scale",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_Role_CreatedAt",
                table: "Roles",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermission_CreatedAt",
                table: "RolePermissions",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_RelatedAccount_CreatedAt",
                table: "RelatedAccounts",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_RelatedAccountRequest_CreatedAt",
                table: "RelatedAccountRequests",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_ProvidedForm_CreatedAt",
                table: "ProvidedForms",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalInvitee_CreatedAt",
                table: "Personalnvitees",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_Permission_CreatedAt",
                table: "Permissions",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionHeader_CreatedAt",
                table: "PermissionHeaders",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_OurGoal_CreatedAt",
                table: "OurGoals",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_News_CreatedAt",
                table: "News",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_Meeting_CreatedAt",
                table: "Meeting",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_Interview_CreatedAt",
                table: "Interview",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_Instruction_CreatedAt",
                table: "Instructions",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_EduInstitutionCoordinator_CreatedAt",
                table: "InstitutionCoordinators",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_GroupInvitee_CreatedAt",
                table: "GroupInvitees",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralWorkshop_CreatedAt",
                table: "GeneralWorkshops",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralFAQ_CreatedAt",
                table: "GeneralFAQs",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralFAQCategory_CreatedAt",
                table: "GeneralFAQCategories",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_FrequentlyAskedQuestion_CreatedAt",
                table: "FrequentlyAskedQuestions",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_ExtraAttachmentFile_CreatedAt",
                table: "ExtraAttachmentsProvidedForms",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_ExtraAttachment_CreatedAt",
                table: "ExtraAttachments",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_ExplanatoryGuide_CreatedAt",
                table: "ExplanatoryGuides",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_Event_CreatedAt",
                table: "Events",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_EduEntitiesCoordinator_CreatedAt",
                table: "EducationCoordinators",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_EducationalInstitution_CreatedAt",
                table: "EducationalInstitutions",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_EducationalEntity_CreatedAt",
                table: "EducationalEntities",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_EducationalClass_CreatedAt",
                table: "EducationalClasses",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_DynamicAttributeValue_CreatedAt",
                table: "DynamicAttributeValues",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_DynamicAttributeSection_CreatedAt",
                table: "DynamicAttributeSections",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_DynamicAttribute_CreatedAt",
                table: "DynamicAttributes",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_DynamicAttributePatternValue_CreatedAt",
                table: "DynamicAttributePatternValues",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_DynamicAttributePattern_CreatedAt",
                table: "DynamicAttributePatterns",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_DynamicAttributeListValue_CreatedAt",
                table: "DynamicAttributeListValues",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralValidation_CreatedAt",
                table: "DynamicAttributeGeneralValidations",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_DependencyValidation_CreatedAt",
                table: "DependencyValidations",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_DependencyGroup_CreatedAt",
                table: "DependencyGroup",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_Dependency_CreatedAt",
                table: "Dependencies",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_Cycle_CreatedAt",
                table: "Cycles",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_CycleConditionsProvidedForm_CreatedAt",
                table: "CycleConditionsProvidedForms",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_CycleConditionAttachment_CreatedAt",
                table: "CycleConditionAttachments",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_CycleCondition_CreatedAt",
                table: "CycleCondition",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_Criterion_CreatedAt",
                table: "Criterions",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_CriterionItemScale_CreatedAt",
                table: "CriterionItemScales",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_CriterionItem_CreatedAt",
                table: "CriterionItems",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_CriterionItemAttachment_CreatedAt",
                table: "CriterionItemAttachments",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_CriterionAttachment_CreatedAt",
                table: "CriterionAttachments",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_Coordinator_CreatedAt",
                table: "Coordinators",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionAttachment_CreatedAt",
                table: "ConditionAttachments",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_Committee_CreatedAt",
                table: "Committees",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryFAQ_CreatedAt",
                table: "CategoryFAQs",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryEducationalClass_CreatedAt",
                table: "CategoryEducationalClasses",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryCommittee_CreatedAt",
                table: "CategoryCommittees",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryArbitrator_CreatedAt",
                table: "CategoriesArbitrators",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_Category_CreatedAt",
                table: "Categories",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_AttributeTableName_CreatedAt",
                table: "AttributeTableNames",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_AttributeOperation_CreatedAt",
                table: "AttributeOperations",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_AttributeDataType_CreatedAt",
                table: "AttributeDataTypes",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionsProvidedForms_CreatedAt",
                table: "Attachments",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_Arbitrator_CreatedAt",
                table: "Arbitrators",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_ArbitratorClass_CreatedAt",
                table: "ArbitratorClasses",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_ArbitrationProcedure_CreatedAt",
                table: "ArbitrationProcedure",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_AppVersion_CreatedAt",
                table: "AppVersions",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_Agenda_CreatedAt",
                table: "Agendas",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_Achievement_CreatedAt",
                table: "Achievements",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_AboutAwardPage_CreatedAt",
                table: "AboutAwardPage",
                column: "CreatedAt");
        }
    }
}
