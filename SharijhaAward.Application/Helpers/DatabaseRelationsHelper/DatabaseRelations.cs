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
                "Categories/ParentId ArbitrationScales/CategoryId DynamicAttributeSections/RecordIdOnRelation")] // Done
            Category,

            [Description("TrainingWorkshops/CategoryId TermsAndConditions/CategoryId Rewards/CategoryId ProvidedForms/categoryId " + // Done
                "MeetingCategories/CategoryId InterviewCategories/CategoryId FrequentlyAskedQuestions/CategoryId " + // Done
                "ExplanatoryGuides/CategoryId Criterions/CategoryId CategoryFAQs/CategoryId CategoryEducationalEntities/CategoryId " + // Done
                "CategoryEducationalClasses/CategoryId CategoryCommittees/CategoryId CategoriesArbitrators/CategoryId " + // Done
                "Categories/ParentId ArbitrationScales/CategoryId DynamicAttributeSections/RecordIdOnRelation")] // Done
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
                "CriterionItemAttachments/ProvidedFormId CriterionAttachments/ProvidedFormId DynamicAttributeValues/RecordId/ProvidedForm " +
                "SwitchArbitrations/ProvidedFormId")] // Done
            ProvidedForm,

            [Description("Arbitrations/ProvidedFormId ArbitrationAudits/ProvidedFormId ArbitrationResults/ProvidedFormId " + // Done
                "ArbitratorForms/ProvidedFormId ConditionsProvidedForms/ProvidedFormId CoordinatorForms/ProvidedFormId " + // Done
                "FinalArbitrations/ProvidedFormId ExtraAttachments/ProvidedFormId CycleConditionsProvidedForms/ProvidedFormId " + // Done
                "CriterionItemAttachments/ProvidedFormId CriterionAttachments/ProvidedFormId DynamicAttributeValues/RecordId/ProvidedForm " +
                "SwitchArbitrations/ProvidedFormId")] // Done
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

            [Description("ProvidedForms/CategoryEducationalClassId ArbitratorClasses/CategoryEducationalClassId")] // Done
            CategoryEducationalClass,

            [Description("ProvidedForms/CategoryEducationalClassId ArbitratorClasses/CategoryEducationalClassId")] // Done
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

            [Description("InterviewUsers/InterviewId InterviewQuestions/InterviewId InterviewNotes/InterviewId " + // Done
                "InterviewCategories/InterviewId InterviewAttachments/InterviewId")] // Done
            Interview,

            [Description("InterviewUsers/InterviewId InterviewQuestions/InterviewId InterviewNotes/InterviewId " + // Done
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

            [Description("ComitteesArbitrators/CommitteeId CategoryCommittees/CommitteeId")] // Done
            Committee,

            [Description("ComitteesArbitrators/CommitteeId CategoryCommittees/CommitteeId")] // Done
            Committees,

            [Description("")] // Done
            ComitteeArbitrator,

            [Description("")] // Done
            ComitteesArbitrators,

            [Description("CategoryEducationalClasses/EducationalClassId")] // Done
            EducationalClass,

            [Description("CategoryEducationalClasses/EducationalClassId")] // Done
            EducationalClasses,

            [Description("FinalArbitrations/ArbitratorId Committees/ChairmanId ComitteesArbitrators/ArbitratorId CircularChairmans/ChairmanId " +
                "CircularArbitrators/ArbitratorId CategoriesArbitrators/ArbitratorId ArbitratorForms/ArbitratorId " +
                "ArbitratorClasses/ArbitratorId Arbitrations/ArbitratorId Users/Id DynamicAttributeValues/RecordId/Arbitrator " +
                "SwitchArbitrations/OldArbitratorId SwitchArbitrations/NewArbitratorId")] // Done
            Arbitrator,

            [Description("FinalArbitrations/ArbitratorId Committees/ChairmanId ComitteesArbitrators/ArbitratorId CircularChairmans/ChairmanId " +
                "CircularArbitrators/ArbitratorId CategoriesArbitrators/ArbitratorId ArbitratorForms/ArbitratorId " +
                "ArbitratorClasses/ArbitratorId Arbitrations/ArbitratorId Users/Id DynamicAttributeValues/RecordId/Arbitrator " +
                "SwitchArbitrations/OldArbitratorId SwitchArbitrations/NewArbitratorId")] // Done
            Arbitrators,

            [Description("")] // Done
            RelatedAccount,

            [Description("")] // Done
            RelatedAccounts,

            [Description("")] // Done
            GeneralFAQ,

            [Description("")] // Done
            GeneralFAQs,

            [Description("GeneralFAQs/GeneralFrequentlyAskedQuestionCategoryId")] // Done
            GeneralFAQCategory,

            [Description("GeneralFAQs/GeneralFrequentlyAskedQuestionCategoryId")] // Done
            GeneralFAQCategories,

            [Description("Personalnvitees/EventId GroupInvitees/EventId")] // Done
            Event,

            [Description("Personalnvitees/EventId GroupInvitees/EventId")] // Done
            Events,

            [Description("")] // Done
            PersonalInvitee,

            [Description("")] // Done
            Personalnvitees,

            [Description("Students/GroupInviteeId")] // Done
            GroupInvitee,

            [Description("Students/GroupInviteeId")] // Done
            GroupInvitees,

            [Description("Arbitrators/Id Coordinators/Id UserTokens/UserId UsersRoles/UserId UserNotifications/UserId " + // Done
                "TrainingWorkshopSubscribers/UserId ResponsibilitiesUsers/UserId RelatedAccountRequests/SenderId " + // Done
                "RelatedAccountRequests/ReceiverId RelatedAccounts/User1Id RelatedAccounts/User2Id " + // Done
                "ProvidedForms/userId FinalArbitrations/DoneArbitrationUserId EmailMessages/UserId " + // Done
                "Arbitrations/DoneArbitrationUserId Achievements/UserId")] // Done
            User,

            [Description("Arbitrators/Id Coordinators/Id UserTokens/UserId UsersRoles/UserId UserNotifications/UserId " + // Done
                "TrainingWorkshopSubscribers/UserId ResponsibilitiesUsers/UserId RelatedAccountRequests/SenderId " + // Done
                "RelatedAccountRequests/ReceiverId RelatedAccounts/User1Id RelatedAccounts/User2Id " + // Done
                "ProvidedForms/userId FinalArbitrations/DoneArbitrationUserId EmailMessages/UserId " + // Done
                "Arbitrations/DoneArbitrationUserId Achievements/UserId")] // Done
            Users,

            [Description("UsersRoles/RoleId RolePermissions/RoleId RoleMessageTypes/RoleId Responsibilities/RoleId")] // Done
            Role,

            [Description("UsersRoles/RoleId RolePermissions/RoleId RoleMessageTypes/RoleId Responsibilities/RoleId")] // Done
            Roles,

            [Description("")] // Done
            RolePermission,

            [Description("")] // Done
            RolePermissions,

            [Description("")] // Done
            Dependency,

            [Description("")] // Done
            Dependencies,

            [Description("")] // Done
            DependencyValidation,

            [Description("")] // Done
            DependencyValidations,
            
            [Description("ViewWhenRelations/DynamicAttributeId DynamicAttributeGeneralValidations/DynamicAttributeId " + // Done
                "DynamicAttributeValues/DynamicAttributeId DynamicAttributeTableValue/DynamicAttributeId " + // Done
                "DynamicAttributeListValues/DynamicAttributeId Dependencies/DynamicAttributeId Dependencies/MainDynamicAttributeId")] // Done
            DynamicAttribute,

            [Description("ViewWhenRelations/DynamicAttributeId DynamicAttributeGeneralValidations/DynamicAttributeId " + // Done
                "DynamicAttributeValues/DynamicAttributeId DynamicAttributeTableValue/DynamicAttributeId " + // Done
                "DynamicAttributeListValues/DynamicAttributeId Dependencies/DynamicAttributeId Dependencies/MainDynamicAttributeId")] // Done
            DynamicAttributes,

            [Description("")] // Done
            GeneralValidation,

            [Description("")] // Done
            DynamicAttributeGeneralValidations,

            [Description("ViewWhenRelations/DynamicAttributeListValueId")] // Done
            DynamicAttributeListValue,
            
            [Description("ViewWhenRelations/DynamicAttributeListValueId")] // Done
            DynamicAttributeListValues,

            [Description("ViewWhenRelations/DynamicAttributeSectionId DynamicAttributes/DynamicAttributeSectionId")] // Done
            DynamicAttributeSection,

            [Description("ViewWhenRelations/DynamicAttributeSectionId DynamicAttributes/DynamicAttributeSectionId")] // Done
            DynamicAttributeSections,

            [Description("")] // Done
            DynamicAttributeValue,

            [Description("")] // Done
            DynamicAttributeValues,

            [Description("")] // Done
            Student,

            [Description("")] // Done
            Students,

            [Description("DynamicAttributePatternValues/DynamicAttributePatternId")] // Done
            DynamicAttributePattern,
            
            [Description("DynamicAttributePatternValues/DynamicAttributePatternId")] // Done
            DynamicAttributePatterns,

            [Description("")] // Done
            DynamicAttributePatternValue,

            [Description("")] // Done
            DynamicAttributePatternValues,

            [Description("")] // Done
            ConditionAttachment,

            [Description("")] // Done
            ConditionAttachments,

            [Description("Users/Id EntitiesCoordinators/CoordinatorId CoordinatorForms/CoordinatorId " + // Done
                "CircularCoordinators/CoordinatorId DynamicAttributeValues/RecordId/Coordinator")] // Done
            Coordinator,

            [Description("Users/Id EntitiesCoordinators/CoordinatorId CoordinatorForms/CoordinatorId " + // Done
                "CircularCoordinators/CoordinatorId DynamicAttributeValues/RecordId/Coordinator")] // Done
            Coordinators,

            [Description("EntitiesCoordinators/EducationalEntityId EducationalInstitutions/EducationalEntityId " + // Done
                "CategoryEducationalEntities/EducationalEntityId")] // Done
            EducationalEntity,

            [Description("EntitiesCoordinators/EducationalEntityId EducationalInstitutions/EducationalEntityId " + // Done
                "CategoryEducationalEntities/EducationalEntityId")] // Done
            EducationalEntities,

            [Description("")] // Done
            EducationalInstitution,

            [Description("")] // Done
            EducationalInstitutions,

            [Description("")] // Done
            EduEntitiesCoordinator,

            [Description("")] // Done
            EduEntitiesCoordinators,

            [Description("OurGoals/AboutAwardPageId")] // Done
            AboutAwardPage,

            [Description("")] // Done
            GeneralWorkshop,

            [Description("")] // Done
            GeneralWorkshops,

            [Description("")] // Done
            OurGoal,

            [Description("")] // Done
            OurGoals,

            [Description("")] // Done
            Achievement,

            [Description("")] // Done
            Achievements,

            [Description("EmailMessages/MessageId EmailAttachments/MessageId")] // Done
            EmailMessage,

            [Description("EmailMessages/MessageId EmailAttachments/MessageId")] // Done
            EmailMessages,

            [Description("")] // Done
            EmailAttachment,

            [Description("")] // Done
            EmailAttachments,

            [Description("")] // Done
            RoleMessageType,

            [Description("")] // Done
            RoleMessageTypes,

            [Description("RoleMessageTypes/MessageTypeId EmailMessages/TypeId")] // Done
            MessageType,

            [Description("RoleMessageTypes/MessageTypeId EmailMessages/TypeId")] // Done
            MessageTypes,

            [Description("CircularCoordinators/CircularId CircularChairmans/CircularId CircularAttachments/CircularId " + // Done
                "CircularArbitrators/CircularId")] // Done
            Circular,

            [Description("CircularCoordinators/CircularId CircularChairmans/CircularId CircularAttachments/CircularId " + // Done
                "CircularArbitrators/CircularId")] // Done
            Circulars,

            [Description("")] // Done
            AwardPublication,

            [Description("")] // Done
            AwardPublications,

            [Description("Galleries/AlbumId")] // Done
            Album,

            [Description("Galleries/AlbumId")] // Done
            Albums,

            [Description("")] // Done
            Gallery,

            [Description("")] // Done
            Galleries,

            [Description("")] // Done
            HomePageSlider,

            [Description("")] // Done
            HomePageSliders,

            [Description("")] // Done
            ReferenceSource,

            [Description("")] // Done
            ReferenceSources,

            [Description("")] // Done
            StrategicPartner,

            [Description("")] // Done
            StrategicPartners,

            [Description("")] // Done
            SocialMedia,

            [Description("")] // Done
            SocialMedias,

            [Description("PageStructures/ParentId TextCards/PageStructureId ParagraphCards/PageId " + // Done
                "ImageCards/PageId DarkCards/PageId")] // Done
            PageStructure,

            [Description("PageStructures/ParentId TextCards/PageStructureId ParagraphCards/PageId " + // Done
                "ImageCards/PageId DarkCards/PageId")] // Done
            PageStructures,

            [Description("")] // Done
            DarkCard,

            [Description("")] // Done
            DarkCards,

            [Description("")] // Done
            ParagraphCard,

            [Description("")] // Done
            ParagraphCards,

            [Description("")] // Done
            AwardSponsor,

            [Description("")] // Done
            AwardSponsors,

            [Description("ResponsibilitiesUsers/ResponsibilityId")] // Done
            Responsibility,

            [Description("ResponsibilitiesUsers/ResponsibilityId")] // Done
            Responsibilities,

            [Description("")] // Done
            ResponsibilityUser,

            [Description("")] // Done
            ResponsibilitiesUsers,

            [Description("")] // Done
            NewsImage,

            [Description("")] // Done
            NewsImages,

            [Description("")] // Done
            CircularArbitrator,

            [Description("")] // Done
            CircularArbitrators,

            [Description("")] // Done
            CircularCoordinator,

            [Description("")] // Done
            CircularCoordinators,

            [Description("")] // Done
            CircularChairman,

            [Description("")] // Done
            CircularChairmans,

            [Description("")] // Done
            CircularAttachment,

            [Description("")] // Done
            CircularAttachments,

            [Description("")] // Done
            TextCard,

            [Description("")] // Done
            TextCards,

            [Description("PageStructureImages/ImageCardId")] // Done
            ImageCard,
            
            [Description("PageStructureImages/ImageCardId")] // Done
            ImageCards,

            [Description("")] // Done
            PageStructureImages,

            [Description("")] // Done
            OnePageText,

            [Description("NewsImages/NewsId")] // Done
            News,

            [Description("")] // Done
            SwitchArbitration,

            [Description("")] // Done
            SwitchArbitrations
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
