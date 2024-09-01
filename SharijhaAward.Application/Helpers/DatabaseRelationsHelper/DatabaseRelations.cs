using System.ComponentModel;
using System.Reflection;

namespace SharijhaAward.Application.Helpers.DatabaseRelationsHelper
{
    public class DatabaseRelationsClass
    {
        public enum DatabaseRelations
        {
            [Description("Categories/CycleId Agendas/CycleId AwardStatistics/CycleId CycleCondition/CycleId")] // Done
            Cycle,

            [Description("Categories/CycleId Agendas/CycleId AwardStatistics/CycleId CycleCondition/CycleId")] // Done
            Cycles,

            [Description("")] // Done
            Agenda,

            [Description("")] // Done
            Agendas,

            [Description("TrainingWorkshops/CategoryId TermsAndConditions/CategoryId Rewards/CategoryId ProvidedForms/categoryId " + // Done
                "MeetingCategories/CategoryId InterviewCategories/CategoryId FrequentlyAskedQuestions/CategoryId " + // Done
                "ExplanatoryGuides/CategoryId Criterions/CategoryId CategoryFAQs/CategoryId CategoryEducationalEntities/CategoryId " + // Done
                "CategoryEducationalClasses/CategoryId CategoryCommittees/CategoryId CategoriesArbitrators/CategoryId " + // Done
                "Categories/ParentId ArbitrationScales/CategoryId")] // Done
            Category,

            [Description("TrainingWorkshops/CategoryId TermsAndConditions/CategoryId Rewards/CategoryId ProvidedForms/categoryId " + // Done
                "MeetingCategories/CategoryId InterviewCategories/CategoryId FrequentlyAskedQuestions/CategoryId " + // Done
                "ExplanatoryGuides/CategoryId Criterions/CategoryId CategoryFAQs/CategoryId CategoryEducationalEntities/CategoryId " + // Done
                "CategoryEducationalClasses/CategoryId CategoryCommittees/CategoryId CategoriesArbitrators/CategoryId " + // Done
                "Categories/ParentId ArbitrationScales/CategoryId")] // Done
            Categories,

            [Description("")] // Done
            AwardStatistic,
            
            [Description("")] // Done
            AwardStatistics,

            [Description("CycleConditionsProvidedForms/CycleConditionId")] // Done
            CycleCondition,

            [Description("TrainingWrokshopeAttachment/WorkshopeId TrainingWorkshopSubscriber/TrainingWorkshopsId")] // Done
            TrainingWorkshop,

            [Description("TrainingWrokshopeAttachment/WorkshopeId TrainingWorkshopSubscriber/TrainingWorkshopsId")] // Done
            TrainingWorkshops,

            [Description("ConditionsProvidedForms/TermAndConditionId")] // Done
            TermAndCondition,

            [Description("ConditionsProvidedForms/TermAndConditionId")] // Done
            TermsAndConditions,

            [Description("")] // Done
            Reward,
            
            [Description("")] // Done
            Rewards,

            [Description("Arbitrations/ProvidedFormId ArbitrationAudits/ProvidedFormId ArbitrationResults/ProvidedFormId " + // Done
                "ArbitratorForms/ProvidedFormId ConditionsProvidedForms/ProvidedFormId CoordinatorForms/ProvidedFormId " + // Done
                "FinalArbitrations/ProvidedFormId ExtraAttachments/ProvidedFormId CycleConditionsProvidedForms/ProvidedFormId " + // Done
                "CriterionItemAttachments/ProvidedFormId CriterionAttachments/ProvidedFormId")] // Done
            ProvidedForm,

            [Description("Arbitrations/ProvidedFormId ArbitrationAudits/ProvidedFormId ArbitrationResults/ProvidedFormId " + // Done
                "ArbitratorForms/ProvidedFormId ConditionsProvidedForms/ProvidedFormId CoordinatorForms/ProvidedFormId " + // Done
                "FinalArbitrations/ProvidedFormId ExtraAttachments/ProvidedFormId CycleConditionsProvidedForms/ProvidedFormId " + // Done
                "CriterionItemAttachments/ProvidedFormId CriterionAttachments/ProvidedFormId")] // Done
            ProvidedForms,

            [Description("")] // Done
            MeetingCategory,
            
            [Description("")] // Done
            MeetingCategories,

            [Description("")] // Done
            InterviewCategory,

            [Description("")] // Done
            InterviewCategories,

            [Description("")] // Done
            FrequentlyAskedQuestion,
            
            [Description("")] // Done
            FrequentlyAskedQuestions,
            
            [Description("")] // Done
            ExplanatoryGuide,
            
            [Description("")] // Done
            ExplanatoryGuides,
            
            [Description("InitialArbitrations/CriterionId FinalArbitrationScores/CriterionId CriterionItems/CriterionId " + // Done
                "CriterionAttachments/CriterionId Criterions/ParentId ArbitrationScalesCriterions/CriterionId ArbitrationAudits/CriterionId")] // Done
            Criterion,

            [Description("InitialArbitrations/CriterionId FinalArbitrationScores/CriterionId CriterionItems/CriterionId " + // Done
                "CriterionAttachments/CriterionId Criterions/ParentId ArbitrationScalesCriterions/CriterionId ArbitrationAudits/CriterionId")] // Done
            Criterions,

            [Description("")] // Done
            CategoryFAQ,

            [Description("")] // Done
            CategoryFAQs,

            [Description("ProvidedForms/CategoryEducationalEntityId")] // Done
            CategoryEducationalEntity,

            [Description("ProvidedForms/CategoryEducationalEntityId")] // Done
            CategoryEducationalEntities,

            [Description("ProvidedForms/CategoryEducationalClassId")] // Done
            CategoryEducationalClass,

            [Description("ProvidedForms/CategoryEducationalClassId")] // Done
            CategoryEducationalClasses,

            [Description("")] // Done
            CategoryCommittee,

            [Description("")] // Done
            CategoryCommittees,

            [Description("")] // Done
            CategoryArbitrator,

            [Description("")] // Done
            CategoriesArbitrators,

            [Description("ArbitrationScalesCriterions/ArbitrationScaleId")] // Done
            ArbitrationScale,

            [Description("ArbitrationScalesCriterions/ArbitrationScaleId")] // Done
            ArbitrationScales,

            [Description("CycleConditionAttachments/CycleConditionsProvidedFormId")] // Done
            CycleConditionsProvidedForm,

            [Description("CycleConditionAttachments/CycleConditionsProvidedFormId")] // Done
            CycleConditionsProvidedForms,

            [Description("")] // Done
            TrainingWrokshopeAttachment,

            [Description("")] // Done
            TrainingWorkshopSubscriber,

            [Description("")] // Done
            TrainingWorkshopSubscribers,

            [Description("ConditionAttachments/ConditionsProvidedFormsId")] // Done
            ConditionsProvidedForms,

            [Description("InitialArbitrations/ArbitrationId")] // Done
            Arbitration,

            [Description("InitialArbitrations/ArbitrationId")] // Done
            Arbitrations,

            [Description("ChairmanNotesOnArbitrationAudits/ArbitrationAuditId")] // Done
            ArbitrationAudit,

            [Description("ChairmanNotesOnArbitrationAudits/ArbitrationAuditId")] // Done
            ArbitrationAudits,

            [Description("")] // Done
            ArbitrationResult,

            [Description("")] // Done
            ArbitrationResults,

            [Description("")] // Done
            ArbitratorForm,

            [Description("")] // Done
            ArbitratorForms,

            [Description("")] // Done
            CoordinatorForm,

            [Description("")] // Done
            CoordinatorForms,

            [Description("FinalArbitrationScores/FinalArbitrationId ArbitrationResults/FinalArbitrationId")] // Done
            FinalArbitration,

            [Description("FinalArbitrationScores/FinalArbitrationId ArbitrationResults/FinalArbitrationId")] // Done
            FinalArbitrations,

            [Description("ExtraAttachmentsProvidedForms/ExtraAttachmentId")] // Done
            ExtraAttachment,

            [Description("ExtraAttachmentsProvidedForms/ExtraAttachmentId")] // Done
            ExtraAttachments,

            [Description("")] // Done
            CriterionItemAttachment,

            [Description("")] // Done
            CriterionItemAttachments,

            [Description("")] // Done
            CriterionAttachment,

            [Description("")] // Done
            CriterionAttachments,

            [Description("ChairmanNotesOnInitialArbitration/InitialArbitrationId")] // Done
            InitialArbitration,

            [Description("ChairmanNotesOnInitialArbitration/InitialArbitrationId")] // Done
            InitialArbitrations,

            [Description("ChairmanNotesOnFinalArbitrationScores/FinalArbitrationScoreId")] // Done
            FinalArbitrationScore,
            
            [Description("ChairmanNotesOnFinalArbitrationScores/FinalArbitrationScoreId")] // Done
            FinalArbitrationScores,

            [Description("ArbitrationAudits/CriterionItemId InitialArbitrations/CriterionItemId FinalArbitrationScores/CriterionItemId " + // Done
                "CriterionItemAttachments/CriterionItemId ArbitrationScalesCriterions/CriterionItemId")] // Done
            CriterionItem,

            [Description("ArbitrationAudits/CriterionItemId InitialArbitrations/CriterionItemId FinalArbitrationScores/CriterionItemId " + // Done
                "CriterionItemAttachments/CriterionItemId ArbitrationScalesCriterions/CriterionItemId")] // Done
            CriterionItems,

            [Description("")] // Done
            ArbitrationScalesCriterion,

            [Description("")] // Done
            ArbitrationScalesCriterions,

            [Description("")] // Done
            CycleConditionAttachment,

            [Description("")] // Done
            CycleConditionAttachments,

            [Description("")] // Done
            ChairmanNotesOnArbitrationAudit,

            [Description("")] // Done
            ChairmanNotesOnArbitrationAudits,

            [Description("")] // Done
            ExtraAttachmentFile,

            [Description("")] // Done
            ExtraAttachmentsProvidedForms,

            [Description("")] // Done
            ChairmanNotesOnInitialArbitration,

            [Description("")] // Done
            ChairmanNotesOnInitialArbitrations,

            [Description("")] // Done
            ChairmanNotesOnFinalArbitrationScore,
            
            [Description("")] // Done
            ChairmanNotesOnFinalArbitrationScores,

            [Description("")] // Done
            ViewWhenRelation,

            [Description("")] // Done
            ViewWhenRelations,

            [Description("")] // Done
            ExplanatoryMessage,

            [Description("")] // Done
            ExplanatoryMessages,

            [Description("")] // Done
            AdvancedFormBuilderGeneralValidation,

            [Description("")] // Done
            AdvancedFormBuilderGeneralValidations,

            [Description("AdvancedFormBuilderSections/VirtualTableForSectionId")] // Done
            VirtualTableForSection,

            [Description("AdvancedFormBuilderSections/VirtualTableForSectionId")] // Done
            VirtualTableForSections,

            [Description("")] // Done
            DynamicAttributeTableValue,

            [Description("")] // Done
            InterviewAttachment,

            [Description("")] // Done
            InterviewAttachments,

            [Description("InterviewUsers/InterviewId InterviewQuestions/InterviewId InterviewNotes/InterviewId " +
                "InterviewCategories/InterviewId InterviewAttachments/InterviewId")] // Done
            Interview,

            [Description("InterviewUsers/InterviewId InterviewQuestions/InterviewId InterviewNotes/InterviewId " +
                "InterviewCategories/InterviewId InterviewAttachments/InterviewId")] // Done
            Interviews,

            [Description("")] // Done
            InterviewNote,

            [Description("")] // Done
            InterviewNotes,

            [Description("")] // Done
            InterviewQuestion,

            [Description("")] // Done
            InterviewQuestions,

            [Description("")] // Done
            InterviewUser,

            [Description("")] // Done
            InterviewUsers,

            [Description("")] // Done
            UserNotifications,

            [Description("")] // Done
            UserNotification,

            [Description("")] // Done
            UserToken,

            [Description("")] // Done
            UserTokens,

            [Description("")] // Done
            NotificationTemplate,

            [Description("")] // Done
            NotificationTemplates,

            [Description("MeetingUsers/MeetingId MeetingCategories/MeetingId")] // Done
            Meeting,

            [Description("MeetingUsers/MeetingId MeetingCategories/MeetingId")] // Done
            Meetings,

            [Description("")] // Done
            MeetingUser,

            [Description("")] // Done
            MeetingUsers,

            [Description("UserNotifications/NotificationId")] // Done
            Notification,

            [Description("UserNotifications/NotificationId")] // Done
            Notifications,

            [Description("")] // Done
            UserRole,

            [Description("")] // Done
            UsersRoles,

            [Description("")] // Done
            Instruction,

            [Description("")] // Done
            Instructions,

            [Description("")] // Done
            RelatedAccountRequest,

            [Description("")] // Done
            RelatedAccountRequests,

            [Description("")] // Done
            ArbitratorClass,

            [Description("")] // Done
            ArbitratorClasses,

            Committee,
            Committees,

            ComitteeArbitrator,
            ComitteesArbitrators,

            EducationalClass,
            EducationalClasses,

            Arbitrator,
            Arbitrators,

            RelatedAccount,
            RelatedAccounts,

            GeneralFAQ,
            GeneralFAQs,

            GeneralFAQCategory,
            GeneralFAQCategories,

            Event,
            Events,

            PersonalInvitee,
            Personalnvitees,

            GroupInvitee,
            GroupInvitees,

            User,
            Users,

            Role,
            Roles,

            RolePermission,
            RolePermissions,

            Dependency,
            Dependencies,

            DependencyValidation,
            DependencyValidations,

            DynamicAttribute,
            DynamicAttributes,

            GeneralValidation,
            DynamicAttributeGeneralValidations,

            DynamicAttributeListValue,
            DynamicAttributeListValues,

            DynamicAttributeSection,
            DynamicAttributeSections,

            DynamicAttributeValue,
            DynamicAttributeValues,

            Student,
            Students,

            DynamicAttributePattern,
            DynamicAttributePatterns,

            DynamicAttributePatternValue,
            DynamicAttributePatternValues,

            ConditionAttachments,

            Coordinator,
            Coordinators,

            EducationalEntity,
            EducationalEntities,

            EducationalInstitution,
            EducationalInstitutions,

            EduEntitiesCoordinator,
            EduEntitiesCoordinators,

            AboutAwardPage,

            GeneralWorkshop,
            GeneralWorkshops,

            OurGoal,
            OurGoals,

            Achievement,
            Achievements,

            EmailMessage,
            EmailMessages,

            EmailAttachment,
            EmailAttachments,

            RoleMessageType,
            RoleMessageTypes,

            MessageType,
            MessageTypes,

            Circular,
            Circulars,

            AwardPublication,
            AwardPublications,

            Album,
            Albums,

            Gallery,
            Galleries,

            HomePageSlider,
            HomePageSliders,

            ReferenceSource,
            ReferenceSources,

            StrategicPartner,
            StrategicPartners,

            SocialMedia,
            SocialMedias,

            PageStructure,
            PageStructures,

            DarkCard,
            DarkCards,

            ParagraphCard,
            ParagraphCards,

            AwardSponsor,
            AwardSponsors,

            Responsibility,
            Responsibilities,

            ResponsibilityUser,
            ResponsibilitiesUsers,

            NewsImage,
            NewsImages,

            CircularArbitrator,
            CircularArbitrators,

            CircularCoordinator,
            CircularCoordinators,

            CircularChairman,
            CircularChairmans,

            CircularAttachment,
            CircularAttachments,

            TextCard,
            TextCards,

            ImageCard,
            ImageCards,

            PageStructureImages,

            OnePageText,

            News
        }
        public static string GetEnumDescription(Enum value)
        {
            FieldInfo FI = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])FI.GetCustomAttributes(
                typeof(DescriptionAttribute),
                false);

            if (attributes != null &&
                attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }
    }
}
