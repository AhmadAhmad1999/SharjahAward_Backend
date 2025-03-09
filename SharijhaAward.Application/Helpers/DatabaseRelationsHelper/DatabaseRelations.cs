using System.ComponentModel;
using System.Reflection;

namespace SharijhaAward.Application.Helpers.DatabaseRelationsHelper
{
    public class DatabaseRelationsClass
    {
        public enum DatabaseRelations
        {
            [Description("Categories/CycleId Agendas/CycleId AwardStatistics/CycleId CycleCondition/CycleId " +
                "EducationalEntities/CycleId")] // Done
            Cycle,

            [Description("Categories/CycleId Agendas/CycleId AwardStatistics/CycleId CycleCondition/CycleId " +
                "EducationalEntities/CycleId")] // Done
            Cycles,

            [Description("")] // Done
            Agenda,

            [Description("")] // Done
            Agendas,

            [Description("TrainingWorkshops/CategoryId TermsAndConditions/CategoryId Rewards/CategoryId ProvidedForms/categoryId " + // Done
                "MeetingCategories/CategoryId InterviewCategories/CategoryId FrequentlyAskedQuestions/CategoryId " + // Done
                "ExplanatoryGuides/CategoryId Criterions/CategoryId CategoryFAQs/CategoryId CategoryEducationalEntities/CategoryId " + // Done
                "CategoryEducationalClasses/CategoryId CategoryCommittees/CategoryId CategoriesArbitrators/CategoryId " + // Done
                "Categories/ParentId ArbitrationScales/CategoryId DynamicAttributeSections/RecordIdOnRelation " +
                "SubcommitteeCategories/CategoryId UserCategories/CategoryId")] // Done
            Category,

            [Description("TrainingWorkshops/CategoryId TermsAndConditions/CategoryId Rewards/CategoryId ProvidedForms/categoryId " + // Done
                "MeetingCategories/CategoryId InterviewCategories/CategoryId FrequentlyAskedQuestions/CategoryId " + // Done
                "ExplanatoryGuides/CategoryId Criterions/CategoryId CategoryFAQs/CategoryId CategoryEducationalEntities/CategoryId " + // Done
                "CategoryEducationalClasses/CategoryId CategoryCommittees/CategoryId CategoriesArbitrators/CategoryId " + // Done
                "Categories/ParentId ArbitrationScales/CategoryId DynamicAttributeSections/RecordIdOnRelation " +
                "SubcommitteeCategories/CategoryId UserCategories/CategoryId")] // Done
            Categories,

            [Description("")] // Done
            AwardStatistic,
            
            [Description("")] // Done
            AwardStatistics,

            [Description("CycleConditionsProvidedForms/CycleConditionId CycleConditionAttachmentType/CycleConditionId")] // Done
            CycleCondition,

            [Description("TrainingWorkshopAttachments/TrainingWorkshopId TrainingWorkshopSubscriber/TrainingWorkshopsId")] // Done
            TrainingWorkshop,

            [Description("TrainingWorkshopAttachments/TrainingWorkshopId TrainingWorkshopSubscriber/TrainingWorkshopsId")] // Done
            TrainingWorkshops,

            [Description("ConditionsProvidedForms/TermAndConditionId TermAndConditionAttachmentTypes/TermAndConditionId")] // Done
            TermAndCondition,

            [Description("ConditionsProvidedForms/TermAndConditionId TermAndConditionAttachmentTypes/TermAndConditionId")] // Done
            TermsAndConditions,

            [Description("")] // Done
            Reward,
            
            [Description("")] // Done
            Rewards,

            [Description("Arbitrations/ProvidedFormId ArbitrationAudits/ProvidedFormId ArbitrationResults/ProvidedFormId " + // Done
                "ArbitratorForms/ProvidedFormId ConditionsProvidedForms/ProvidedFormId CoordinatorForms/ProvidedFormId " + // Done
                "FinalArbitrations/ProvidedFormId ExtraAttachments/ProvidedFormId CycleConditionsProvidedForms/ProvidedFormId " + // Done
                "CriterionItemAttachments/ProvidedFormId CriterionAttachments/ProvidedFormId DynamicAttributeValues/RecordId/ProvidedForm " +
                "SwitchArbitrations/ProvidedFormId SavedCertificate/ProvidedFormId UserNoteOnFormForArbitrations/ProvidedFormId " +
                "RequestForChangeInterviewEligibilityStatuses/ProvidedFormId")] // Done
            ProvidedForm,

            [Description("Arbitrations/ProvidedFormId ArbitrationAudits/ProvidedFormId ArbitrationResults/ProvidedFormId " + // Done
                "ArbitratorForms/ProvidedFormId ConditionsProvidedForms/ProvidedFormId CoordinatorForms/ProvidedFormId " + // Done
                "FinalArbitrations/ProvidedFormId ExtraAttachments/ProvidedFormId CycleConditionsProvidedForms/ProvidedFormId " + // Done
                "CriterionItemAttachments/ProvidedFormId CriterionAttachments/ProvidedFormId DynamicAttributeValues/RecordId/ProvidedForm " +
                "SwitchArbitrations/ProvidedFormId SavedCertificate/ProvidedFormId UserNoteOnFormForArbitrations/ProvidedFormId " +
                "RequestForChangeInterviewEligibilityStatuses/ProvidedFormId")] // Done
            ProvidedForms,

            [Description("")] // Done
            MeetingCategory,
            
            [Description("")] // Done
            MeetingCategories,

            [Description("")] // Done
            FrequentlyAskedQuestion,
            
            [Description("")] // Done
            FrequentlyAskedQuestions,
            
            [Description("")] // Done
            ExplanatoryGuide,
            
            [Description("")] // Done
            ExplanatoryGuides,
            
            [Description("InitialArbitrations/CriterionId FinalArbitrationScores/CriterionId CriterionItems/CriterionId " + // Done
                "CriterionAttachments/CriterionId Criterions/ParentId ArbitrationScalesCriterions/CriterionId ArbitrationAudits/CriterionId " +
                "CriterionAttachmentTypes/CriterionId")] // Done
            Criterion,

            [Description("InitialArbitrations/CriterionId FinalArbitrationScores/CriterionId CriterionItems/CriterionId " + // Done
                "CriterionAttachments/CriterionId Criterions/ParentId ArbitrationScalesCriterions/CriterionId ArbitrationAudits/CriterionId " +
                "CriterionAttachmentTypes/CriterionId")] // Done
            Criterions,

            [Description("")] // Done
            CategoryFAQ,

            [Description("")] // Done
            CategoryFAQs,

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

            [Description("TrainingWorkshopAttachmentTypes/TrainingWorkshopAttachmentId")] // Done
            TrainingWorkshopAttachment,

            [Description("TrainingWorkshopAttachmentTypes/TrainingWorkshopAttachmentId")] // Done
            TrainingWorkshopAttachments,

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

            [Description("ExtraAttachmentsProvidedForms/ExtraAttachmentId ExtraAttachmentAttachmentTypes/ExtraAttachmentId")] // Done
            ExtraAttachment,

            [Description("ExtraAttachmentsProvidedForms/ExtraAttachmentId ExtraAttachmentAttachmentTypes/ExtraAttachmentId")] // Done
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
                "CriterionItemAttachments/CriterionItemId ArbitrationScalesCriterions/CriterionItemId CriterionItemAttachmentTypes/CriterionItemId")] // Done
            CriterionItem,

            [Description("ArbitrationAudits/CriterionItemId InitialArbitrations/CriterionItemId FinalArbitrationScores/CriterionItemId " + // Done
                "CriterionItemAttachments/CriterionItemId ArbitrationScalesCriterions/CriterionItemId CriterionItemAttachmentTypes/CriterionItemId")] // Done
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

            [Description("")] // Done
            DynamicAttributeTableValue,

            [Description("InterviewCategories/InterviewId InterviewInvitees/InterviewId")] // Done
            Interview,

            [Description("InterviewCategories/InterviewId InterviewInvitees/InterviewId")] // Done
            Interviews,

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

            [Description("UserCategories/UserRoleId CircularUsers/UserRoleId")] // Done
            UserRole,

            [Description("UserCategories/UserRoleId CircularUsers/UserRoleId")] // Done
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

            [Description("ComitteesArbitrators/CommitteeId CategoryCommittees/CommitteeId ComitteeOfficers/CommitteeId")] // Done
            Committee,

            [Description("ComitteesArbitrators/CommitteeId CategoryCommittees/CommitteeId ComitteeOfficers/CommitteeId")] // Done
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
                "SwitchArbitrations/OldArbitratorId SwitchArbitrations/NewArbitratorId InterviewInviteeParticipants/ArbitratorId " +
                "SubcommitteeCategories/ArbitratorId ComitteeOfficers/ArbitratorId CiruclarSubcommitteeOfficers/SubcommitteeOfficerId")] // Done
            Arbitrator,

            [Description("FinalArbitrations/ArbitratorId Committees/ChairmanId ComitteesArbitrators/ArbitratorId CircularChairmans/ChairmanId " +
                "CircularArbitrators/ArbitratorId CategoriesArbitrators/ArbitratorId ArbitratorForms/ArbitratorId " +
                "ArbitratorClasses/ArbitratorId Arbitrations/ArbitratorId Users/Id DynamicAttributeValues/RecordId/Arbitrator " +
                "SwitchArbitrations/OldArbitratorId SwitchArbitrations/NewArbitratorId InterviewInviteeParticipants/ArbitratorId " +
                "SubcommitteeCategories/ArbitratorId ComitteeOfficers/ArbitratorId CiruclarSubcommitteeOfficers/SubcommitteeOfficerId")] // Done
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
                "Arbitrations/DoneArbitrationUserId Achievements/UserId ChairmanNotesOnInitialArbitrations/ChairmanId " +
                "ChairmanNotesOnArbitrationAudits/ChairmanId ChairmanNotesOnFinalArbitrationScores/ChairmanId " +
                "DigitalSignatures/UserId InterviewInviteeParticipants/SubscriberId WebSiteResponses/UserId " +
                "UserNoteOnFormForArbitrations/ChairmanId RequestForChangeInterviewEligibilityStatuses/RequestedById")] // Done
            User,

            [Description("Arbitrators/Id Coordinators/Id UserTokens/UserId UsersRoles/UserId UserNotifications/UserId " + // Done
                "TrainingWorkshopSubscribers/UserId ResponsibilitiesUsers/UserId RelatedAccountRequests/SenderId " + // Done
                "RelatedAccountRequests/ReceiverId RelatedAccounts/User1Id RelatedAccounts/User2Id " + // Done
                "ProvidedForms/userId FinalArbitrations/DoneArbitrationUserId EmailMessages/UserId " + // Done
                "Arbitrations/DoneArbitrationUserId Achievements/UserId ChairmanNotesOnInitialArbitrations/ChairmanId " +
                "ChairmanNotesOnArbitrationAudits/ChairmanId ChairmanNotesOnFinalArbitrationScores/ChairmanId " +
                "DigitalSignatures/UserId InterviewInviteeParticipants/SubscriberId WebSiteResponses/UserId " +
                "UserNoteOnFormForArbitrations/ChairmanId RequestForChangeInterviewEligibilityStatuses/RequestedById")] // Done
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

            [Description("EntitiesCoordinators/EducationalEntityId EducationalInstitutions/EducationalEntityId " +
                "ProvidedForms/EducationalEntityId")] // Done
            EducationalEntity,

            [Description("EntitiesCoordinators/EducationalEntityId EducationalInstitutions/EducationalEntityId " +
                "ProvidedForms/EducationalEntityId")] // Done
            EducationalEntities,

            [Description("ProvidedForms/EducationalInstitutionId")] // Done
            EducationalInstitution,

            [Description("ProvidedForms/EducationalInstitutionId")] // Done
            EducationalInstitutions,

            [Description("")] // Done
            EntitiesCoordinator,

            [Description("")] // Done
            EntitiesCoordinators,

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

            [Description("EmailMessages/MessageId EmailAttachments/MessageId WebSiteResponses/EmailMessageId")] // Done
            EmailMessage,

            [Description("EmailMessages/MessageId EmailAttachments/MessageId WebSiteResponses/EmailMessageId")] // Done
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
                "CircularArbitrators/CircularId CircularUsers/CircularId CiruclarSubcommitteeOfficers/CircularId")] // Done
            Circular,

            [Description("CircularCoordinators/CircularId CircularChairmans/CircularId CircularAttachments/CircularId " + // Done
                "CircularArbitrators/CircularId CircularUsers/CircularId CiruclarSubcommitteeOfficers/CircularId")] // Done
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
                "ImageCards/PageId DarkCards/PageId PageCards/PageId")] // Done
            PageStructure,

            [Description("PageStructures/ParentId TextCards/PageStructureId ParagraphCards/PageId " + // Done
                "ImageCards/PageId DarkCards/PageId PageCards/PageId")] // Done
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
            SwitchArbitrations,

            [Description("PageCards/ParentId")] // Done
            PageCard,

            [Description("PageCards/ParentId")] // Done
            PageCards,
            
            [Description("")] // Done
            AdvancedFormBuilderViewWhenRelation,

            [Description("")] // Done
            AdvancedFormBuilderViewWhenRelations,

            [Description("AdvancedFormBuilderDependencies/MainAdvancedFormBuilderId AdvancedFormBuilderDependencies/AdvancedFormBuilderId " +
                "AdvancedFormBuilderGeneralValidations/AdvancedFormBuilderId AdvancedFormBuilderListValues/AdvancedFormBuilderId " +
                "AdvancedFormBuilderTableValues/AdvancedFormBuilderId AdvancedFormBuilderValues/AdvancedFormBuilderId " +
                "AdvancedFormBuilderViewWhenRelations/AdvancedFormBuilderId")] // Done
            AdvancedFormBuilder,

            [Description("AdvancedFormBuilderDependencies/MainAdvancedFormBuilderId AdvancedFormBuilderDependencies/AdvancedFormBuilderId " +
                "AdvancedFormBuilderGeneralValidations/AdvancedFormBuilderId AdvancedFormBuilderListValues/AdvancedFormBuilderId " +
                "AdvancedFormBuilderTableValues/AdvancedFormBuilderId AdvancedFormBuilderValues/AdvancedFormBuilderId " +
                "AdvancedFormBuilderViewWhenRelations/AdvancedFormBuilderId")] // Done
            AdvancedFormBuilders,

            [Description("")] // Done
            AdvancedFormBuilderDependency,

            [Description("")] // Done
            AdvancedFormBuilderDependencies,

            [Description("AdvancedFormBuilders/AttributeDataTypeId")] // Done
            AttributeDataType,

            [Description("AdvancedFormBuilders/AttributeDataTypeId")] // Done
            AttributeDataTypes,

            [Description("AdvancedFormBuilders/AdvancedFormBuilderSectionId AdvancedFormBuilderViewWhenRelations/AdvancedFormBuilderSectionId")] // Done
            AdvancedFormBuilderSection,

            [Description("AdvancedFormBuilders/AdvancedFormBuilderSectionId AdvancedFormBuilderViewWhenRelations/AdvancedFormBuilderSectionId")] // Done
            AdvancedFormBuilderSections,

            [Description("AdvancedFormBuilderDependencies/AdvancedFormBuilderDependencyGroupId AdvancedFormBuilderDependencyValidations/AdvancedFormBuilderDependencyGroupId")] // Done
            AdvancedFormBuilderDependencyGroup,

            [Description("AdvancedFormBuilderDependencies/AdvancedFormBuilderDependencyGroupId AdvancedFormBuilderDependencyValidations/AdvancedFormBuilderDependencyGroupId")] // Done
            AdvancedFormBuilderDependencyGroups,

            [Description("AdvancedFormBuilderDependencies/StaticAttributeId")] // Done
            StaticAttribute,

            [Description("AdvancedFormBuilderDependencies/StaticAttributeId")] // Done
            StaticAttributes,

            [Description("AdvancedFormBuilderDependencies/AttributeOperationId AdvancedFormBuilderDependencyValidations/AttributeOperationId " +
                "AdvancedFormBuilderGeneralValidations/AttributeOperationId")] // Done
            AttributeOperation,

            [Description("AdvancedFormBuilderDependencies/AttributeOperationId AdvancedFormBuilderDependencyValidations/AttributeOperationId " +
                "AdvancedFormBuilderGeneralValidations/AttributeOperationId")] // Done
            AttributeOperations,

            [Description("")] // Done
            AdvancedFormBuilderDependencyValidation,

            [Description("")] // Done
            AdvancedFormBuilderDependencyValidations,

            [Description("AdvancedFormBuilderViewWhenRelations/AdvancedFormBuilderListValueId")] // Done
            AdvancedFormBuilderListValue,

            [Description("AdvancedFormBuilderViewWhenRelations/AdvancedFormBuilderListValueId")] // Done
            AdvancedFormBuilderListValues,

            [Description("AdvancedFormBuilderPatternValues/AdvancedFormBuilderPatternId")] // Done
            AdvancedFormBuilderPattern,

            [Description("AdvancedFormBuilderPatternValues/AdvancedFormBuilderPatternId")] // Done
            AdvancedFormBuilderPatterns,

            [Description("")] // Done
            AdvancedFormBuilderPatternValue,

            [Description("")] // Done
            AdvancedFormBuilderPatternValues,

            [Description("")] // Done
            AdvancedFormBuilderTableValue,

            [Description("")] // Done
            AdvancedFormBuilderTableValues,

            [Description("")] // Done
            AdvancedFormBuilderValue,

            [Description("")] // Done
            AdvancedFormBuilderValues,
            
            [Description("SavedCertificates/TemplateId")] // Done
            Template,

            [Description("SavedCertificates/TemplateId")] // Done
            Templates,

            [Description("SavedCertificates/DigitalSignatureId")] // Done
            DigitalSignature,

            [Description("SavedCertificates/DigitalSignatureId")] // Done
            DigitalSignatures,

            [Description("InterviewInviteeParticipants/InterviewInviteeId InterviewInviteeNoteAndQuestions/InterviewInviteeId " +
                "InterviewInviteeAttachments/InterviewInviteeId")] // Done
            InterviewInvitee,

            [Description("InterviewInviteeParticipants/InterviewInviteeId InterviewInviteeNoteAndQuestions/InterviewInviteeId " +
                "InterviewInviteeAttachments/InterviewInviteeId")] // Done
            InterviewInvitees,

            [Description("")] // Done
            InterviewInviteeParticipant,

            [Description("")] // Done
            InterviewInviteeParticipants,

            [Description("")] // Done
            InterviewInviteeNoteAndQuestion,

            [Description("")] // Done
            InterviewInviteeNoteAndQuestions,

            [Description("")] // Done
            InterviewInviteeAttachment,

            [Description("")] // Done
            InterviewInviteeAttachments,

            [Description("")] // Done
            WorkflowQuestion,

            [Description("")] // Done
            WorkflowQuestions,

            [Description("")] // Done
            StaticNotification,

            [Description("")] // Done
            StaticNotifications,

            [Description("")] // Done
            NewsTicker,

            [Description("")] // Done
            NewsTickers,

            [Description("")] // Done
            SavedCertificate,

            [Description("")] // Done
            SavedCertificates,

            [Description("WebSiteResponseAttachments/WebSiteResponseId")] // Done
            WebSiteResponse,

            [Description("WebSiteResponseAttachments/WebSiteResponseId")] // Done
            WebSiteResponses,

            [Description("")] // Done
            WebSiteResponseAttachment,

            [Description("")] // Done
            WebSiteResponseAttachments,

            [Description("")] // Done
            VirtualTableForSection,

            [Description("")] // Done
            VirtualTableForSections,

            [Description("")] // Done
            EduEntitiesCoordinator,

            [Description("")] // Done
            EduEntitiesCoordinators,

            [Description("")] // Done
            CycleConditionAttachmentType,

            [Description("")] // Done
            CycleConditionAttachmentTypes,

            [Description("")] // Done
            TermAndConditionAttachmentType,

            [Description("")] // Done
            TermAndConditionAttachmentTypes,

            [Description("")] // Done
            CriterionAttachmentType,

            [Description("")] // Done
            CriterionAttachmentTypes,

            [Description("")] // Done
            CriterionItemAttachmentType,

            [Description("")] // Done
            CriterionItemAttachmentTypes,

            [Description("")] // Done
            TrainingWorkshopAttachmentType,

            [Description("")] // Done
            TrainingWorkshopAttachmentTypes,

            [Description("")] // Done
            ExtraAttachmentAttachmentType,

            [Description("")] // Done
            ExtraAttachmentAttachmentTypes,

            [Description("")] // Done
            SubcommitteeCategory,

            [Description("")] // Done
            SubcommitteeCategories,

            [Description("")] // Done
            ComitteeOfficer,

            [Description("")] // Done
            ComitteeOfficers,

            [Description("")] // Done
            UserCategory,

            [Description("")] // Done
            UserCategories,

            [Description("")] // Done
            UserNoteOnFormForArbitration,

            [Description("")] // Done
            UserNoteOnFormForArbitrations,

            [Description("")] // Done
            RequestForChangeInterviewEligibilityStatus,

            [Description("")] // Done
            RequestForChangeInterviewEligibilityStatuses,

            [Description("")] // Done
            CircularUser,

            [Description("")] // Done
            CircularUsers,

            [Description("")] // Done
            CiruclarSubcommitteeOfficer,

            [Description("")] // Done
            CiruclarSubcommitteeOfficers
        }
        public static string GetEnumDescription(Enum value)
        {
            FieldInfo? FI = value.GetType().GetField(value.ToString());

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
