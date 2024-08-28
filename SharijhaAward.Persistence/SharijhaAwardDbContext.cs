using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1.Crmf;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.EventModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.InvitationModels;
using SharijhaAward.Domain.Entities.CategoryCommitteeModel;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.TrainingWorkshopSubscriberModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharijhaAward.Domain.Entities.ProvidedFormModel;
using SharijhaAward.Domain.Constants;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.TrainingWorkshopModel;
using SharijhaAward.Domain.Entities.FAQModel;
using SharijhaAward.Domain.Entities.NewsModel;
using SharijhaAward.Domain.Entities.TermsAndConditionsModel;
using System.Net.Mail;
using SharijhaAward.Domain.Entities.CategoryFAQ;
using SharijhaAward.Domain.Entities.ExplanatoryGuideModel;
using SharijhaAward.Domain.Entities.CycleConditionModel;
using SharijhaAward.Domain.Entities.TrainingWrokshopeAttachments;
using SharijhaAward.Domain.Entities.ConditionsProvidedFormsModel;
using SharijhaAward.Domain.Entities.AttachmentModel;
using SharijhaAward.Domain.Entities.CoordinatorModel;
using SharijhaAward.Domain.Entities.EducationCoordinatorModel;
using SharijhaAward.Domain.Entities.EducationalInstitutionModel;
using SharijhaAward.Domain.Entities.EducationalEntityModel;
using SharijhaAward.Domain.Entities.CriterionModel;
using SharijhaAward.Domain.Entities.CriterionItemModel;
using SharijhaAward.Domain.Entities.GeneralFrequentlyAskedQuestionModel;
using SharijhaAward.Domain.Entities.EduInstitutionCoordinatorModel;
using SharijhaAward.Domain.Entities.RelatedAccountModel;
using SharijhaAward.Domain.Entities.AboutAwardPageModel;
using SharijhaAward.Domain.Entities.GeneralWorkshopsModel;
using SharijhaAward.Domain.Entities.OnePageTextModel;
using SharijhaAward.Domain.Entities.AchievementModel;
using SharijhaAward.Domain.Entities.AgendaModel;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.CategoryArbitratorModel;
using SharijhaAward.Domain.Entities.CycleConditionsProvidedFormModel;
using SharijhaAward.Domain.Entities.SystemAttachmentModel;
using SharijhaAward.Domain.Entities.EducationalClassModel;
using SharijhaAward.Domain.Entities.CommitteeModel;
using SharijhaAward.Domain.Entities.CategoryEducationalClassModel;
using SharijhaAward.Domain.Entities.ArbitratorClassModel;
using SharijhaAward.Domain.Entities.ExtraAttachmentModel;
using SharijhaAward.Domain.Entities.ExtraAttachmentProvidedFormModel;
using SharijhaAward.Domain.Entities.AppVersioningModel;
using SharijhaAward.Domain.Entities.InstructionModel;
using SharijhaAward.Domain.Entities.ContactUsModels;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Internal;
using SharijhaAward.Domain.Entities.RoleMessageTypeModel;
using SharijhaAward.Domain.Entities.CircularModel;
using SharijhaAward.Domain.Entities.ComitteeArbitratorModel;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.NotificationModel;
using SharijhaAward.Domain.Entities.MeetingUserModel;
using SharijhaAward.Domain.Entities.MeetingModel;
using SharijhaAward.Domain.Entities.MeetingCategoryModel;
using SharijhaAward.Domain.Entities.NotificationTemplateModel;
using SharijhaAward.Domain.Entities.AwardPublicationsModel;
using SharijhaAward.Domain.Entities.AlbumModel;
using SharijhaAward.Domain.Entities.HomePageSliderModel;
using SharijhaAward.Domain.Entities.ReferenceSourcesModel;
using SharijhaAward.Domain.Entities.StrategicPartnerModel;
using SharijhaAward.Domain.Entities.SocialMediaModel;
using SharijhaAward.Domain.Entities.PageStructureModel;
using SharijhaAward.Domain.Entities.PageStructureModels;
using SharijhaAward.Domain.Entities.ArbitrationScaleModel;
using SharijhaAward.Domain.Entities.AwardSponsorModel;
using SharijhaAward.Domain.Entities.RewardModel;
using SharijhaAward.Domain.Entities.LoggerModel;
using SharijhaAward.Domain.Entities.AwardStatisticModel;
using SharijhaAward.Domain.Entities.TrainingManualModel;
using SharijhaAward.Domain.Entities.InterviewModel;
using SharijhaAward.Domain.Entities.FinalArbitrationModel;
using SharijhaAward.Domain.Entities.ArbitratorFormModel;
using SharijhaAward.Domain.Entities.CoordinatorFormModel;
using SharijhaAward.Domain.Entities.AdvancedFormBuilderModel;
using SharijhaAward.Domain.Entities.ExplanatoryMessageModel;
using SharijhaAward.Domain.Entities.ResponsibilityModel;
using SharijhaAward.Domain.Entities;
using SharijhaAward.Domain.Entities.ArbitrationResultModel;
using SharijhaAward.Domain.Entities.IndexModel;

namespace SharijhaAward.Persistence
{
    public class SharijhaAwardDbContext : DbContext
    {
        public SharijhaAwardDbContext(DbContextOptions<SharijhaAwardDbContext> options)
        : base(options)
        {

        }

        public DbSet<ViewWhenRelation> ViewWhenRelations { get; set; }
        public DbSet<ArbitrationResult> ArbitrationResults { get; set; }
        public DbSet<CategoryEducationalEntity> CategoryEducationalEntities { get; set; }
        public DbSet<ExplanatoryMessage> ExplanatoryMessages { get; set; }
        public DbSet<AdvancedFormBuilderGeneralValidation> AdvancedFormBuilderGeneralValidations { get; set; }
        public DbSet<VirtualTable> VirtualTables { get; set; }
        public DbSet<VirtualTableForSection> VirtualTableForSections { get; set; }
        public DbSet<AdvancedFormBuilderValue> AdvancedFormBuilderValues { get; set; }
        public DbSet<AdvancedFormBuilderTableValue> AdvancedFormBuilderTableValues { get; set; }
        public DbSet<AdvancedFormBuilderPatternValue> AdvancedFormBuilderPatternValues { get; set; }
        public DbSet<AdvancedFormBuilderPattern> AdvancedFormBuilderPatterns { get; set; }
        public DbSet<AdvancedFormBuilderListValue> AdvancedFormBuilderListValues { get; set; }
        public DbSet<AdvancedFormBuilder> AdvancedFormBuilders { get; set; }
        public DbSet<AdvancedFormBuilderSection> AdvancedFormBuilderSections { get; set; }
        public DbSet<DynamicAttributeTableValue> DynamicAttributeTableValue { get; set; }
        public DbSet<FinalArbitrationScore> FinalArbitrationScores { get; set; }
        public DbSet<ChairmanNotesOnFinalArbitrationScore> ChairmanNotesOnFinalArbitrationScores { get; set; }
        public DbSet<FinalArbitration> FinalArbitrations { get; set; }
        public DbSet<InterviewAttachment> InterviewAttachments { get; set; }
        public DbSet<Interview> Interviews { get; set; }
        public DbSet<InterviewNote> InterviewNotes { get; set; }
        public DbSet<InterviewQuestion> InterviewQuestions { get; set; }
        public DbSet<InterviewCategory> InterviewCategories { get; set; }
        public DbSet<InterviewUser> InterviewUsers { get; set; }
        public DbSet<InitialArbitration> InitialArbitrations { get; set; }
        public DbSet<ArbitrationAudit> ArbitrationAudits { get; set; }
        public DbSet<ChairmanNotesOnInitialArbitration> ChairmanNotesOnInitialArbitrations { get; set; }
        public DbSet<ChairmanNotesOnArbitrationAudit> ChairmanNotesOnArbitrationAudits { get; set; }
        public DbSet<UserNotification> UserNotifications { get; set; }
        public DbSet<UserToken> UserTokens { get; set; }
        public DbSet<LogUserAction> LogUserActions { get; set; }
        public DbSet<ArbitrationScale> ArbitrationScales { get; set; }
        public DbSet<ArbitrationScalesCriterion> ArbitrationScalesCriterions { get; set; }
        public DbSet<NotificationTemplate> NotificationTemplates { get; set; }
        public DbSet<MeetingCategory> MeetingCategories { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<MeetingUser> MeetingUsers { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Arbitration> Arbitrations { get; set; }
        public DbSet<UserRole> UsersRoles { get; set; }
        public DbSet<PermissionHeader> PermissionHeaders { get; set; }
        public DbSet<Instruction> Instructions { get; set; }
        public DbSet<AppVersion> AppVersions { get; set; }
        public DbSet<RelatedAccountRequest> RelatedAccountRequests { get; set; }
        public DbSet<ArbitratorClass> ArbitratorClasses { get; set; }
        public DbSet<Committee> Committees { get; set; }
        public DbSet<ComitteeArbitrator> ComitteesArbitrators { get; set; }
        public DbSet<CategoryCommittee> CategoryCommittees { get; set; }
        public DbSet<CategoryEducationalClass> CategoryEducationalClasses { get; set; }
        public DbSet<EducationalClass> EducationalClasses { get; set; }
        public DbSet<Arbitrator> Arbitrators { get; set; }
        public DbSet<CategoryArbitrator> CategoriesArbitrators { get; set; }
        public DbSet<Agenda> Agendas { get; set; }
        public DbSet<RelatedAccount> RelatedAccounts { get; set; }
        public DbSet<FrequentlyAskedQuestion> FrequentlyAskedQuestions { get; set; }
        public DbSet<GeneralFAQ> GeneralFAQs { get; set; }
        public DbSet<GeneralFAQCategory> GeneralFAQCategories { get; set; }
        public DbSet<TrainingWorkshop> TrainingWorkshops { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<PersonalInvitee> Personalnvitees { get; set; }
        public DbSet<GroupInvitee> GroupInvitees { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<TrainingWorkshopSubscriber> TrainingWorkshopSubscribers { get; set; }
        public DbSet<Cycle> Cycles { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<ProvidedForm> ProvidedForms { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<AttributeDataType> AttributeDataTypes { get; set; }
        public DbSet<AttributeOperation> AttributeOperations { get; set; }
        public DbSet<AttributeTableName> AttributeTableNames { get; set; }
        public DbSet<Dependency> Dependencies { get; set; }
        public DbSet<DependencyValidation> DependencyValidations { get; set; }
        public DbSet<DynamicAttribute> DynamicAttributes { get; set; }
        public DbSet<GeneralValidation> DynamicAttributeGeneralValidations { get; set; }
        public DbSet<DynamicAttributeListValue> DynamicAttributeListValues { get; set; }
        public DbSet<DynamicAttributeSection> DynamicAttributeSections { get; set; }
        public DbSet<DynamicAttributeValue> DynamicAttributeValues { get; set; }
        public DbSet<StaticAttribute> StaticAttributes { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<TermAndCondition> TermsAndConditions { get; set; }
        public DbSet<ConditionsProvidedForms> ConditionsProvidedForms { get; set; }
        public DbSet<DynamicAttributePattern> DynamicAttributePatterns { get; set; }
        public DbSet<DynamicAttributePatternValue> DynamicAttributePatternValues { get; set; }
        public DbSet<CategoryFAQ> CategoryFAQs { get; set; }
        public DbSet<ExplanatoryGuide> ExplanatoryGuides { get; set; }
        public DbSet<CycleCondition> CycleCondition { get; set; }
        public DbSet<TrainingWrokshopeAttachment> TrainingWrokshopeAttachment { get; set; }
        public DbSet<ConditionAttachment> ConditionAttachments { get; set; }
        public DbSet<Coordinator> Coordinators { get; set; }
        public DbSet<EducationalEntity> EducationalEntities { get; set; }
        public DbSet<EducationalInstitution> EducationalInstitutions { get; set; }
        public DbSet<EduEntitiesCoordinator> EntitiesCoordinators { get; set; }
        public DbSet<CriterionAttachment> CriterionAttachments { get; set; }
        public DbSet<Criterion> Criterions { get; set; }
        public DbSet<CriterionItem> CriterionItems { get; set; }
        public DbSet<CriterionItemAttachment> CriterionItemAttachments { get; set; }
        public DbSet<AboutAwardPage> AboutAwardPage { get; set; }
        public DbSet<GeneralWorkshop> GeneralWorkshops { get; set; }
        public DbSet<OurGoal> OurGoals { get; set; }
        public DbSet<Achievement> Achievements { get; set; }
        public DbSet<CycleConditionsProvidedForm> CycleConditionsProvidedForms { get; set; }
        public DbSet<CycleConditionAttachment> CycleConditionAttachments { get; set; }
        public DbSet<ExtraAttachment> ExtraAttachments { get; set; }
        public DbSet<ExtraAttachmentFile> ExtraAttachmentsProvidedForms { get; set; }
        public DbSet<EmailMessage> EmailMessages { get; set; }
        public DbSet<EmailAttachment> EmailAttachments { get; set; }
        public DbSet<RoleMessageType> RoleMessageTypes { get; set; }
        public DbSet<MessageType> MessageTypes { get; set; }
        public DbSet<Circular> Circulars { get; set; }
        public DbSet<AwardPublication> AwardPublications { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<HomePageSlider> HomePageSliders { get; set; }
        public DbSet<ReferenceSource> ReferenceSources { get; set; }
        public DbSet<StrategicPartner> StrategicPartners { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<PageStructure> PageStructures { get; set; }
        public DbSet<DarkCard> DarkCards { get; set; }
        public DbSet<ParagraphCard> ParagraphCards { get; set; }
        public DbSet<AwardSponsor> AwardSponsors { get; set; }
        public DbSet<Reward> Rewards { get; set; }
        public DbSet<AwardStatistic> AwardStatistics { get; set; }
        public DbSet<ArbitratorForm> ArbitratorForms { get; set; }
        public DbSet<CoordinatorForm> CoordinatorForms { get; set; }
        public DbSet<Responsibility> Responsibilities { get; set; }
        public DbSet<ResponsibilityUser> ResponsibilitiesUsers { get; set; }
        public DbSet<NewsImage> NewsImages { get; set; }
        public DbSet<CircularArbitrator> CircularArbitrators { get; set; }
        public DbSet<CircularCoordinator> CircularCoordinators { get; set; }
        public DbSet<CircularChairman> CircularChairmans { get; set; }
        public DbSet<CircularAttachment> CircularAttachments { get; set; }
        public DbSet<TextCard> TextCards { get; set; }
        public DbSet<ImageCard> ImageCards { get; set; }
        public DbSet<PageStructureImages> PageStructureImages { get; set; }
        public DbSet<OnePageText> OnePageText { get; set; }
        public DbSet<News> News { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Filter for Deleted items
            modelBuilder.Entity<Achievement>()
                .Navigation(p => p.User)
                .AutoInclude();

            modelBuilder.Entity<Achievement>().HasQueryFilter(p => !p.isDeleted &&
                (p.User != null ? !p.User.isDeleted : true));

            modelBuilder.Entity<CriterionAttachment>()
                .Navigation(p => p.Criterion)
                .AutoInclude();

            modelBuilder.Entity<CriterionAttachment>()
                .Navigation(p => p.ProvidedForm)
                .AutoInclude();

            modelBuilder.Entity<CriterionAttachment>().HasQueryFilter(p => !p.isDeleted &&
                (p.Criterion != null ? !p.Criterion.isDeleted : true) &&
                (p.ProvidedForm != null ? !p.ProvidedForm.isDeleted : true));

            modelBuilder.Entity<RelatedAccountRequest>()
                .Navigation(p => p.Sender)
                .AutoInclude();

            modelBuilder.Entity<RelatedAccountRequest>()
                .Navigation(p => p.Receiver)
                .AutoInclude();

            modelBuilder.Entity<RelatedAccountRequest>().HasQueryFilter(p => !p.isDeleted &&
                (p.Sender != null ? !p.Sender.isDeleted : true) &&
                (p.Receiver != null ? !p.Receiver.isDeleted : true));

            modelBuilder.Entity<AppVersion>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Instruction>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Arbitration>()
                .Navigation(p => p.Arbitrator)
                .AutoInclude();

            modelBuilder.Entity<Arbitration>()
                .Navigation(p => p.ProvidedForm)
                .AutoInclude();

            modelBuilder.Entity<Arbitration>().HasQueryFilter(p => !p.isDeleted &&
                (p.Arbitrator != null ? !p.Arbitrator.isDeleted : true) &&
                (p.ProvidedForm != null ? !p.ProvidedForm.isDeleted : true));

            modelBuilder.Entity<Notification>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<NotificationTemplate>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<LogUserAction>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<UserToken>()
                .Navigation(p => p.User)
                .AutoInclude();

            modelBuilder.Entity<UserToken>().HasQueryFilter(p => !p.isDeleted &&
                (p.User != null ? !p.User.isDeleted : true));

            modelBuilder.Entity<UserNotification>()
                .Navigation(p => p.User)
                .AutoInclude();

            modelBuilder.Entity<UserNotification>()
                .Navigation(p => p.Notification)
                .AutoInclude();

            modelBuilder.Entity<UserNotification>().HasQueryFilter(p => !p.isDeleted &&
                (p.User != null ? !p.User.isDeleted : true) &&
                (p.Notification != null ? !p.Notification.isDeleted : true));

            modelBuilder.Entity<ChairmanNotesOnFinalArbitrationScore>()
                .Navigation(p => p.FinalArbitrationScore)
                .AutoInclude();

            modelBuilder.Entity<ChairmanNotesOnFinalArbitrationScore>().HasQueryFilter(p => !p.isDeleted &&
                (p.FinalArbitrationScore != null
                    ? !p.FinalArbitrationScore.isDeleted : true));

            modelBuilder.Entity<DynamicAttributeTableValue>()
                .Navigation(p => p.DynamicAttribute)
                .AutoInclude();

            modelBuilder.Entity<DynamicAttributeTableValue>().HasQueryFilter(p => !p.isDeleted &&
                (p.DynamicAttribute != null ? !p.DynamicAttribute.isDeleted : true));

            modelBuilder.Entity<FinalArbitrationScore>()
                .Navigation(p => p.FinalArbitration)
                .AutoInclude();

            modelBuilder.Entity<FinalArbitrationScore>()
                .Navigation(p => p.CriterionItem)
                .AutoInclude();

            modelBuilder.Entity<FinalArbitrationScore>()
                .Navigation(p => p.Criterion)
                .AutoInclude();

            modelBuilder.Entity<FinalArbitrationScore>().HasQueryFilter(p => !p.isDeleted &&
                (p.Criterion != null ? !p.Criterion.isDeleted : true) &&
                (p.CriterionItem != null ? !p.CriterionItem.isDeleted : true) &&
                (p.FinalArbitration != null ? !p.FinalArbitration.isDeleted : true));

            modelBuilder.Entity<FinalArbitration>()
                .Navigation(p => p.ProvidedForm)
                .AutoInclude();

            modelBuilder.Entity<FinalArbitration>()
                .Navigation(p => p.Arbitrator)
                .AutoInclude();

            modelBuilder.Entity<FinalArbitration>().HasQueryFilter(p => !p.isDeleted &&
                (p.Arbitrator != null ? !p.Arbitrator.isDeleted : true) &&
                (p.ProvidedForm != null ? !p.ProvidedForm.isDeleted : true));

            modelBuilder.Entity<AdvancedFormBuilderValue>()
                .Navigation(p => p.AdvancedFormBuilder)
                .AutoInclude();

            modelBuilder.Entity<AdvancedFormBuilderValue>().HasQueryFilter(p => !p.isDeleted &&
                (p.AdvancedFormBuilder != null ? !p.AdvancedFormBuilder.isDeleted : true));

            modelBuilder.Entity<AdvancedFormBuilderGeneralValidation>()
                .Navigation(p => p.AdvancedFormBuilder)
                .AutoInclude();

            modelBuilder.Entity<AdvancedFormBuilderGeneralValidation>()
                .Navigation(p => p.AttributeOperation)
                .AutoInclude();

            modelBuilder.Entity<AdvancedFormBuilderGeneralValidation>().HasQueryFilter(p => !p.isDeleted &&
                (p.AdvancedFormBuilder != null
                    ? !p.AdvancedFormBuilder.isDeleted : true) &&
                (p.AttributeOperation != null
                    ? !p.AttributeOperation.isDeleted : true));

            modelBuilder.Entity<CategoryEducationalEntity>()
                .Navigation(p => p.Category)
                .AutoInclude();

            modelBuilder.Entity<CategoryEducationalEntity>()
                .Navigation(p => p.EducationalEntity)
                .AutoInclude();

            modelBuilder.Entity<CategoryEducationalEntity>().HasQueryFilter(p => !p.isDeleted &&
                (p.EducationalEntity != null ? !p.EducationalEntity.isDeleted : true) &&
                (p.Category != null ? !p.Category.isDeleted : true));

            modelBuilder.Entity<ArbitrationResult>()
                .Navigation(p => p.ProvidedForm)
                .AutoInclude();

            modelBuilder.Entity<ArbitrationResult>()
                .Navigation(p => p.FinalArbitration)
                .AutoInclude();

            modelBuilder.Entity<ArbitrationResult>().HasQueryFilter(p => !p.isDeleted &&
                (p.FinalArbitration != null ? !p.FinalArbitration.isDeleted : true) &&
                (p.ProvidedForm != null ? !p.ProvidedForm.isDeleted : true));

            modelBuilder.Entity<ViewWhenRelation>()
                .Navigation(p => p.DynamicAttributeSection)
                .AutoInclude();

            modelBuilder.Entity<ViewWhenRelation>()
                .Navigation(p => p.DynamicAttribute)
                .AutoInclude();

            modelBuilder.Entity<ViewWhenRelation>()
                .Navigation(p => p.DynamicAttributeListValue)
                .AutoInclude();

            modelBuilder.Entity<ViewWhenRelation>().HasQueryFilter(p => !p.isDeleted &&
                (p.DynamicAttributeListValue != null
                    ? !p.DynamicAttributeListValue.isDeleted : true) &&
                (p.DynamicAttribute != null
                    ? !p.DynamicAttribute.isDeleted : true) &&
                (p.DynamicAttributeSection != null
                    ? !p.DynamicAttributeSection.isDeleted : true));

            modelBuilder.Entity<ExplanatoryMessage>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<AdvancedFormBuilderTableValue>()
                .Navigation(p => p.AdvancedFormBuilder)
                .AutoInclude();

            modelBuilder.Entity<AdvancedFormBuilderTableValue>().HasQueryFilter(p => !p.isDeleted &&
                (p.AdvancedFormBuilder != null
                    ? !p.AdvancedFormBuilder.isDeleted : true));

            modelBuilder.Entity<AdvancedFormBuilderPatternValue>()
                .Navigation(p => p.AdvancedFormBuilderPattern)
                .AutoInclude();

            modelBuilder.Entity<AdvancedFormBuilderPatternValue>().HasQueryFilter(p => !p.isDeleted &&
                (p.AdvancedFormBuilderPattern != null
                    ? !p.AdvancedFormBuilderPattern.isDeleted : true));

            modelBuilder.Entity<AdvancedFormBuilderPattern>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<AdvancedFormBuilderListValue>()
                .Navigation(p => p.AdvancedFormBuilder)
                .AutoInclude();

            modelBuilder.Entity<AdvancedFormBuilderListValue>().HasQueryFilter(p => !p.isDeleted &&
                (p.AdvancedFormBuilder != null
                    ? !p.AdvancedFormBuilder.isDeleted : true));

            modelBuilder.Entity<AdvancedFormBuilder>()
                .Navigation(p => p.AdvancedFormBuilderSection)
                .AutoInclude();

            modelBuilder.Entity<AdvancedFormBuilder>()
                .Navigation(p => p.AttributeDataType)
                .AutoInclude();

            modelBuilder.Entity<AdvancedFormBuilder>().HasQueryFilter(p => !p.isDeleted &&
                (p.AttributeDataType != null
                    ? !p.AttributeDataType.isDeleted : true) &&
                (p.AdvancedFormBuilderSection != null
                    ? !p.AdvancedFormBuilderSection.isDeleted : true));

            modelBuilder.Entity<AdvancedFormBuilderSection>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<InterviewAttachment>()
                .Navigation(p => p.Interview)
                .AutoInclude();

            modelBuilder.Entity<InterviewAttachment>().HasQueryFilter(p => !p.isDeleted &&
                (p.Interview != null ? !p.Interview.isDeleted : true));

            modelBuilder.Entity<Interview>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<InterviewQuestion>()
                .Navigation(p => p.Interview)
                .AutoInclude();

            modelBuilder.Entity<InterviewQuestion>().HasQueryFilter(p => !p.isDeleted &&
                (p.Interview != null ? !p.Interview.isDeleted : true));

            modelBuilder.Entity<InterviewNote>()
                .Navigation(p => p.Interview)
                .AutoInclude();

            modelBuilder.Entity<InterviewNote>().HasQueryFilter(p => !p.isDeleted &&
                (p.Interview != null ? !p.Interview.isDeleted : true));

            modelBuilder.Entity<InterviewCategory>()
                .Navigation(p => p.Interview)
                .AutoInclude();

            modelBuilder.Entity<InterviewCategory>()
                .Navigation(p => p.Category)
                .AutoInclude();

            modelBuilder.Entity<InterviewCategory>().HasQueryFilter(p => !p.isDeleted &&
                (p.Interview != null ? !p.Interview.isDeleted : true) &&
                (p.Category != null ? !p.Category.isDeleted : true));

            modelBuilder.Entity<InterviewUser>()
                .Navigation(p => p.Interview)
                .AutoInclude();

            modelBuilder.Entity<InterviewUser>().HasQueryFilter(p => !p.isDeleted &&
                (p.Interview != null ? !p.Interview.isDeleted : true));

            modelBuilder.Entity<ChairmanNotesOnArbitrationAudit>()
                .Navigation(p => p.ArbitrationAudit)
                .AutoInclude();

            modelBuilder.Entity<ChairmanNotesOnArbitrationAudit>().HasQueryFilter(p => !p.isDeleted &&
                (p.ArbitrationAudit != null
                    ? !p.ArbitrationAudit.isDeleted : true));

            modelBuilder.Entity<ChairmanNotesOnInitialArbitration>()
                .Navigation(p => p.InitialArbitration)
                .AutoInclude();

            modelBuilder.Entity<ChairmanNotesOnInitialArbitration>().HasQueryFilter(p => !p.isDeleted &&
                (p.InitialArbitration != null
                    ? !p.InitialArbitration.isDeleted : true));

            modelBuilder.Entity<InitialArbitration>()
                .Navigation(p => p.CriterionItem)
                .AutoInclude();

            modelBuilder.Entity<InitialArbitration>()
                .Navigation(p => p.Criterion)
                .AutoInclude();

            modelBuilder.Entity<InitialArbitration>()
                .Navigation(p => p.Arbitration)
                .AutoInclude();

            modelBuilder.Entity<InitialArbitration>().HasQueryFilter(p => !p.isDeleted &&
                (p.Arbitration != null ? !p.Arbitration.isDeleted : true) &&
                (p.Criterion != null ? !p.Criterion.isDeleted : true) &&
                (p.CriterionItem != null ? !p.CriterionItem.isDeleted : true));

            modelBuilder.Entity<ArbitrationAudit>()
                .Navigation(p => p.ProvidedForm)
                .AutoInclude();

            modelBuilder.Entity<ArbitrationAudit>()
                .Navigation(p => p.CriterionItem)
                .AutoInclude();

            modelBuilder.Entity<ArbitrationAudit>()
                .Navigation(p => p.Criterion)
                .AutoInclude();

            modelBuilder.Entity<ArbitrationAudit>().HasQueryFilter(p => !p.isDeleted &&
                (p.Criterion != null ? !p.Criterion.isDeleted : true) &&
                (p.CriterionItem != null ? !p.CriterionItem.isDeleted : true) &&
                (p.ProvidedForm != null ? !p.ProvidedForm.isDeleted : true));

            modelBuilder.Entity<ArbitrationScale>()
                .Navigation(p => p.Category)
                .AutoInclude();

            modelBuilder.Entity<ArbitrationScale>().HasQueryFilter(p => !p.isDeleted &&
                (p.Category != null ? !p.Category.isDeleted : true));

            modelBuilder.Entity<ArbitrationScalesCriterion>()
                .Navigation(p => p.ArbitrationScale)
                .AutoInclude();

            modelBuilder.Entity<ArbitrationScalesCriterion>()
                .Navigation(p => p.CriterionItem)
                .AutoInclude();

            modelBuilder.Entity<ArbitrationScalesCriterion>()
                .Navigation(p => p.Criterion)
                .AutoInclude();

            modelBuilder.Entity<ArbitrationScalesCriterion>().HasQueryFilter(p => !p.isDeleted &&
                (p.Criterion != null ? !p.Criterion.isDeleted : true) &&
                (p.CriterionItem != null ? !p.CriterionItem.isDeleted : true) &&
                (p.ArbitrationScale != null ? !p.ArbitrationScale.isDeleted : true));

            modelBuilder.Entity<MeetingCategory>()
                .Navigation(p => p.Meeting)
                .AutoInclude();

            modelBuilder.Entity<MeetingCategory>()
                .Navigation(p => p.Category)
                .AutoInclude();

            modelBuilder.Entity<MeetingCategory>().HasQueryFilter(p => !p.isDeleted &&
                (p.Category != null ? !p.Category.isDeleted : true) &&
                (p.Meeting != null ? !p.Meeting.isDeleted : true));

            modelBuilder.Entity<Meeting>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<MeetingUser>()
                .Navigation(p => p.Meeting)
                .AutoInclude();

            modelBuilder.Entity<MeetingUser>().HasQueryFilter(p => !p.isDeleted &&
                (p.Meeting != null ? !p.Meeting.isDeleted : true));

            modelBuilder.Entity<UserRole>()
                .Navigation(p => p.User)
                .AutoInclude();

            modelBuilder.Entity<UserRole>()
                .Navigation(p => p.Role)
                .AutoInclude();

            modelBuilder.Entity<UserRole>().HasQueryFilter(p => !p.isDeleted &&
                (p.Role != null ? !p.Role.isDeleted : true) &&
                (p.User != null ? !p.User.isDeleted : true));

            modelBuilder.Entity<PermissionHeader>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<ArbitratorClass>()
                .Navigation(p => p.EducationalClass)
                .AutoInclude();

            modelBuilder.Entity<ArbitratorClass>()
                .Navigation(p => p.Arbitrator)
                .AutoInclude();

            modelBuilder.Entity<ArbitratorClass>().HasQueryFilter(p => !p.isDeleted &&
                (p.Arbitrator != null ? !p.Arbitrator.isDeleted : true) &&
                (p.EducationalClass != null ? !p.EducationalClass.isDeleted : true));

            modelBuilder.Entity<Committee>()
                .Navigation(p => p.Chairman)
                .AutoInclude();

            modelBuilder.Entity<Committee>().HasQueryFilter(p => !p.isDeleted &&
                (p.Chairman != null ? !p.Chairman.isDeleted : true));

            modelBuilder.Entity<ComitteeArbitrator>()
                .Navigation(p => p.Arbitrator)
                .AutoInclude();

            modelBuilder.Entity<ComitteeArbitrator>()
                .Navigation(p => p.Committee)
                .AutoInclude();

            modelBuilder.Entity<ComitteeArbitrator>().HasQueryFilter(p => !p.isDeleted &&
                (p.Committee != null ? !p.Committee.isDeleted : true) &&
                (p.Arbitrator != null ? !p.Arbitrator.isDeleted : true));

            modelBuilder.Entity<CategoryCommittee>()
                .Navigation(p => p.Committee)
                .AutoInclude();

            modelBuilder.Entity<CategoryCommittee>()
                .Navigation(p => p.Category)
                .AutoInclude();

            modelBuilder.Entity<CategoryCommittee>().HasQueryFilter(p => !p.isDeleted &&
                (p.Committee != null ? !p.Committee.isDeleted : true) &&
                (p.Category != null ? !p.Category.isDeleted : true));

            modelBuilder.Entity<CategoryEducationalClass>()
                .Navigation(p => p.Category)
                .AutoInclude();

            modelBuilder.Entity<CategoryEducationalClass>()
                .Navigation(p => p.EducationalClass)
                .AutoInclude();

            modelBuilder.Entity<CategoryEducationalClass>().HasQueryFilter(p => !p.isDeleted &&
                (p.Category != null ? !p.Category.isDeleted : true) &&
                (p.EducationalClass != null ? !p.EducationalClass.isDeleted : true));

            modelBuilder.Entity<EducationalClass>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Agenda>()
                .Navigation(p => p.Cycle)
                .AutoInclude();

            modelBuilder.Entity<Agenda>().HasQueryFilter(p => !p.isDeleted &&
                (p.Cycle != null ? !p.Cycle.isDeleted : true));

            modelBuilder.Entity<Arbitrator>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<CategoryArbitrator>()
                .Navigation(p => p.Category)
                .AutoInclude();

            modelBuilder.Entity<CategoryArbitrator>()
                .Navigation(p => p.Arbitrator)
                .AutoInclude();

            modelBuilder.Entity<CategoryArbitrator>().HasQueryFilter(p => !p.isDeleted &&
                (p.Category != null ? !p.Category.isDeleted : true) &&
                (p.Arbitrator != null ? !p.Arbitrator.isDeleted : true));

            modelBuilder.Entity<OnePageText>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<RelatedAccount>()
                .Navigation(p => p.User1)
                .AutoInclude();

            modelBuilder.Entity<RelatedAccount>()
                .Navigation(p => p.User2)
                .AutoInclude();

            modelBuilder.Entity<RelatedAccount>().HasQueryFilter(p => !p.isDeleted &&
                (p.User1 != null ? !p.User1.isDeleted : true) &&
                (p.User2 != null ? !p.User2.isDeleted : true));

            modelBuilder.Entity<Criterion>()
                .Navigation(p => p.Category)
                .AutoInclude();

            modelBuilder.Entity<Criterion>().HasQueryFilter(p => !p.isDeleted &&
                (p.Category != null ? !p.Category.isDeleted : true));

            modelBuilder.Entity<CriterionItem>()
                .Navigation(p => p.Criterion)
                .AutoInclude();

            modelBuilder.Entity<CriterionItem>().HasQueryFilter(p => !p.isDeleted &&
                (p.Criterion != null ? !p.Criterion.isDeleted : true));

            modelBuilder.Entity<CriterionItemAttachment>()
                .Navigation(p => p.CriterionItem)
                .AutoInclude();

            modelBuilder.Entity<CriterionItemAttachment>()
                .Navigation(p => p.ProvidedForm)
                .AutoInclude();

            modelBuilder.Entity<CriterionItemAttachment>().HasQueryFilter(p => !p.isDeleted &&
                (p.ProvidedForm != null ? !p.ProvidedForm.isDeleted : true) &&
                (p.CriterionItem != null ? !p.CriterionItem.isDeleted : true));

            modelBuilder.Entity<GeneralFAQ>()
                .Navigation(p => p.GeneralFrequentlyAskedQuestionCategory)
                .AutoInclude();

            modelBuilder.Entity<GeneralFAQ>().HasQueryFilter(p => !p.isDeleted &&
                (p.GeneralFrequentlyAskedQuestionCategory != null
                    ? !p.GeneralFrequentlyAskedQuestionCategory.isDeleted : true));

            modelBuilder.Entity<GeneralFAQCategory>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Event>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Cycle>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<GroupInvitee>()
                .Navigation(p => p.Event)
                .AutoInclude();

            modelBuilder.Entity<GroupInvitee>().HasQueryFilter(p => !p.isDeleted &&
                (p.Event != null ? !p.Event.isDeleted : true));

            modelBuilder.Entity<PersonalInvitee>()
                .Navigation(p => p.Event)
                .AutoInclude();

            modelBuilder.Entity<PersonalInvitee>().HasQueryFilter(p => !p.isDeleted &&
                (p.Event != null ? !p.Event.isDeleted : true));

            modelBuilder.Entity<Category>()
                .Navigation(p => p.Cycle)
                .AutoInclude();

            modelBuilder.Entity<Category>().HasQueryFilter(p => !p.isDeleted &&
                (p.Cycle != null ? !p.Cycle.isDeleted : true));

            modelBuilder.Entity<News>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<TrainingWorkshop>()
                .Navigation(p => p.Category)
                .AutoInclude();

            modelBuilder.Entity<TrainingWorkshop>().HasQueryFilter(p => !p.isDeleted &&
                (p.Category != null ? !p.Category.isDeleted : true));

            modelBuilder.Entity<FrequentlyAskedQuestion>()
                .Navigation(p => p.Category)
                .AutoInclude();

            modelBuilder.Entity<FrequentlyAskedQuestion>().HasQueryFilter(p => !p.isDeleted &&
                (p.Category != null ? !p.Category.isDeleted : true));

            modelBuilder.Entity<User>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Role>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Student>()
                .Navigation(p => p.GroupInvitee)
                .AutoInclude();

            modelBuilder.Entity<Student>().HasQueryFilter(p => !p.isDeleted &&
                (p.GroupInvitee != null ? !p.GroupInvitee.isDeleted : true));

            modelBuilder.Entity<AttributeDataType>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<AttributeOperation>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<AttributeTableName>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Dependency>()
                .Navigation(p => p.MainDynamicAttribute)
                .AutoInclude();

            modelBuilder.Entity<Dependency>()
                .Navigation(p => p.DynamicAttribute)
                .AutoInclude();

            modelBuilder.Entity<Dependency>()
                .Navigation(p => p.AttributeOperation)
                .AutoInclude();

            modelBuilder.Entity<Dependency>()
                .Navigation(p => p.DependencyGroup)
                .AutoInclude();

            modelBuilder.Entity<Dependency>()
                .Navigation(p => p.StaticAttribute)
                .AutoInclude();

            modelBuilder.Entity<Dependency>().HasQueryFilter(p => !p.isDeleted &&
                (p.StaticAttribute != null ? !p.StaticAttribute.isDeleted : true) &&
                (p.DependencyGroup != null ? !p.DependencyGroup.isDeleted : true) &&
                (p.AttributeOperation != null ? !p.AttributeOperation.isDeleted : true) &&
                (p.DynamicAttribute != null ? !p.DynamicAttribute.isDeleted : true) &&
                (p.MainDynamicAttribute != null ? !p.MainDynamicAttribute.isDeleted : true));

            modelBuilder.Entity<DependencyValidation>()
                .Navigation(p => p.AttributeOperation)
                .AutoInclude();

            modelBuilder.Entity<DependencyValidation>()
                .Navigation(p => p.DependencyGroup)
                .AutoInclude();

            modelBuilder.Entity<DependencyValidation>().HasQueryFilter(p => !p.isDeleted &&
                (p.DependencyGroup != null ? !p.DependencyGroup.isDeleted : true) &&
                (p.AttributeOperation != null ? !p.AttributeOperation.isDeleted : true));

            modelBuilder.Entity<DynamicAttribute>()
                .Navigation(p => p.AttributeDataType)
                .AutoInclude();

            modelBuilder.Entity<DynamicAttribute>()
                .Navigation(p => p.DynamicAttributeSection)
                .AutoInclude();

            modelBuilder.Entity<DynamicAttribute>().HasQueryFilter(p => !p.isDeleted &&
                (p.DynamicAttributeSection != null ? !p.DynamicAttributeSection.isDeleted : true) &&
                (p.AttributeDataType != null ? !p.AttributeDataType.isDeleted : true));

            modelBuilder.Entity<GeneralValidation>()
                .Navigation(p => p.DynamicAttribute)
                .AutoInclude();

            modelBuilder.Entity<GeneralValidation>()
                .Navigation(p => p.AttributeOperation)
                .AutoInclude();

            modelBuilder.Entity<GeneralValidation>().HasQueryFilter(p => !p.isDeleted &&
                (p.AttributeOperation != null ? !p.AttributeOperation.isDeleted : true) &&
                (p.DynamicAttribute != null ? !p.DynamicAttribute.isDeleted : true));

            modelBuilder.Entity<DynamicAttributeListValue>()
                .Navigation(p => p.DynamicAttribute)
                .AutoInclude();

            modelBuilder.Entity<DynamicAttributeListValue>().HasQueryFilter(p => !p.isDeleted &&
                (p.DynamicAttribute != null ? !p.DynamicAttribute.isDeleted : true));

            modelBuilder.Entity<DynamicAttributeSection>()
                .Navigation(p => p.AttributeTableName)
                .AutoInclude();

            modelBuilder.Entity<DynamicAttributeSection>().HasQueryFilter(p => !p.isDeleted &&
                (p.AttributeTableName != null ? !p.AttributeTableName.isDeleted : true));

            modelBuilder.Entity<DynamicAttributeValue>()
                .Navigation(p => p.DynamicAttribute)
                .AutoInclude();

            modelBuilder.Entity<DynamicAttributeValue>().HasQueryFilter(p => !p.isDeleted &&
                (p.DynamicAttribute != null ? !p.DynamicAttribute.isDeleted : true));

            modelBuilder.Entity<StaticAttribute>()
                .Navigation(p => p.AttributeTableName)
                .AutoInclude();

            modelBuilder.Entity<StaticAttribute>()
                .Navigation(p => p.AttributeDataType)
                .AutoInclude();

            modelBuilder.Entity<StaticAttribute>().HasQueryFilter(p => !p.isDeleted &&
                (p.AttributeDataType != null ? !p.AttributeDataType.isDeleted : true) &&
                (p.AttributeTableName != null ? !p.AttributeTableName.isDeleted : true));

            modelBuilder.Entity<TermAndCondition>()
                .Navigation(p => p.Category)
                .AutoInclude();

            modelBuilder.Entity<TermAndCondition>().HasQueryFilter(p => !p.isDeleted &&
                (p.Category != null ? !p.Category.isDeleted : true));

            modelBuilder.Entity<ConditionsProvidedForms>()
                .Navigation(p => p.ProvidedForm)
                .AutoInclude();

            modelBuilder.Entity<ConditionsProvidedForms>()
                .Navigation(p => p.TermAndCondition)
                .AutoInclude();

            modelBuilder.Entity<ConditionsProvidedForms>().HasQueryFilter(p => !p.isDeleted &&
                (p.TermAndCondition != null ? !p.TermAndCondition.isDeleted : true) &&
                (p.ProvidedForm != null ? !p.ProvidedForm.isDeleted : true));

            modelBuilder.Entity<DynamicAttributePattern>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<DynamicAttributePatternValue>()
                .Navigation(p => p.DynamicAttributePattern)
                .AutoInclude();

            modelBuilder.Entity<DynamicAttributePatternValue>().HasQueryFilter(p => !p.isDeleted &&
                (p.DynamicAttributePattern != null
                    ? !p.DynamicAttributePattern.isDeleted : true));

            modelBuilder.Entity<ProvidedForm>()
                .Navigation(p => p.User)
                .AutoInclude();

            modelBuilder.Entity<ProvidedForm>()
                .Navigation(p => p.Category)
                .AutoInclude();

            modelBuilder.Entity<ProvidedForm>()
                .Navigation(p => p.CategoryEducationalEntity)
                .AutoInclude();

            modelBuilder.Entity<ProvidedForm>()
                .Navigation(p => p.CategoryEducationalClass)
                .AutoInclude();

            modelBuilder.Entity<ProvidedForm>().HasQueryFilter(p => !p.isDeleted &&
                (p.CategoryEducationalClass != null ? !p.CategoryEducationalClass.isDeleted : true) &&
                (p.CategoryEducationalEntity != null ? !p.CategoryEducationalEntity.isDeleted : true) &&
                (p.Category != null ? !p.Category.isDeleted : true) &&
                (p.User != null ? !p.User.isDeleted : true));

            modelBuilder.Entity<CategoryFAQ>()
                .Navigation(p => p.Category)
                .AutoInclude();

            modelBuilder.Entity<CategoryFAQ>().HasQueryFilter(p => !p.isDeleted &&
                (p.Category != null ? !p.Category.isDeleted : true));

            modelBuilder.Entity<ExplanatoryGuide>()
                .Navigation(p => p.Category)
                .AutoInclude();

            modelBuilder.Entity<ExplanatoryGuide>().HasQueryFilter(p => !p.isDeleted &&
                (p.Category != null ? !p.Category.isDeleted : true));

            modelBuilder.Entity<CycleCondition>()
                .Navigation(p => p.Cycle)
                .AutoInclude();

            modelBuilder.Entity<CycleCondition>().HasQueryFilter(p => !p.isDeleted &&
                (p.Cycle != null ? !p.Cycle.isDeleted : true));

            modelBuilder.Entity<ConditionAttachment>()
                .Navigation(p => p.ConditionsProvidedForms)
                .AutoInclude();

            modelBuilder.Entity<ConditionAttachment>().HasQueryFilter(p => !p.isDeleted &&
                (p.ConditionsProvidedForms != null ? !p.ConditionsProvidedForms.isDeleted : true));

            modelBuilder.Entity<Coordinator>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<EducationalInstitution>()
                .Navigation(p => p.EducationalEntity)
                .AutoInclude();

            modelBuilder.Entity<EducationalInstitution>().HasQueryFilter(p => !p.isDeleted &&
                (p.EducationalEntity != null ? !p.EducationalEntity.isDeleted : true));

            modelBuilder.Entity<EducationalEntity>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<EduEntitiesCoordinator>()
                .Navigation(p => p.EducationalEntity)
                .AutoInclude();

            modelBuilder.Entity<EduEntitiesCoordinator>()
                .Navigation(p => p.Coordinator)
                .AutoInclude();

            modelBuilder.Entity<EduEntitiesCoordinator>().HasQueryFilter(p => !p.isDeleted &&
                (p.Coordinator != null ? !p.Coordinator.isDeleted : true) &&
                (p.EducationalEntity != null ? !p.EducationalEntity.isDeleted : true));

            modelBuilder.Entity<AboutAwardPage>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<GeneralWorkshop>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<OurGoal>()
                .Navigation(p => p.AboutAwardPage)
                .AutoInclude();

            modelBuilder.Entity<OurGoal>().HasQueryFilter(p => !p.isDeleted &&
                (p.AboutAwardPage != null ? !p.AboutAwardPage.isDeleted : true));

            modelBuilder.Entity<CycleConditionAttachment>()
                .Navigation(p => p.CycleConditionsProvidedForm)
                .AutoInclude();

            modelBuilder.Entity<CycleConditionAttachment>().HasQueryFilter(p => !p.isDeleted &&
                (p.CycleConditionsProvidedForm != null
                    ? !p.CycleConditionsProvidedForm.isDeleted : true));

            modelBuilder.Entity<CycleConditionsProvidedForm>()
                .Navigation(p => p.ProvidedForm)
                .AutoInclude();

            modelBuilder.Entity<CycleConditionsProvidedForm>()
                .Navigation(p => p.CycleCondition)
                .AutoInclude();

            modelBuilder.Entity<CycleConditionsProvidedForm>().HasQueryFilter(p => !p.isDeleted &&
                (p.CycleCondition != null ? !p.CycleCondition.isDeleted : true) &&
                (p.ProvidedForm != null ? !p.ProvidedForm.isDeleted : true));

            modelBuilder.Entity<ExtraAttachment>()
                .Navigation(p => p.ProvidedForm)
                .AutoInclude();

            modelBuilder.Entity<ExtraAttachment>().HasQueryFilter(p => !p.isDeleted &&
                (p.ProvidedForm != null ? !p.ProvidedForm.isDeleted : true));

            modelBuilder.Entity<ExtraAttachmentFile>()
                .Navigation(p => p.ExtraAttachment)
                .AutoInclude();

            modelBuilder.Entity<ExtraAttachmentFile>().HasQueryFilter(p => !p.isDeleted &&
                (p.ExtraAttachment != null ? !p.ExtraAttachment.isDeleted : true));

            modelBuilder.Entity<EmailMessage>()
                .Navigation(p => p.Type)
                .AutoInclude();

            modelBuilder.Entity<EmailMessage>()
                .Navigation(p => p.User)
                .AutoInclude();

            modelBuilder.Entity<EmailMessage>()
                .Navigation(p => p.message)
                .AutoInclude();

            modelBuilder.Entity<EmailMessage>().HasQueryFilter(p => !p.isDeleted &&
                (p.message != null ? !p.message.isDeleted : true) &&
                (p.User != null ? !p.User.isDeleted : true) &&
                (p.Type != null ? !p.Type.isDeleted : true));

            modelBuilder.Entity<EmailAttachment>()
                .Navigation(p => p.Message)
                .AutoInclude();

            modelBuilder.Entity<EmailAttachment>().HasQueryFilter(p => !p.isDeleted &&
                (p.Message != null ? !p.Message.isDeleted : true));

            modelBuilder.Entity<RoleMessageType>()
                .Navigation(p => p.Role)
                .AutoInclude();

            modelBuilder.Entity<RoleMessageType>()
                .Navigation(p => p.MessageType)
                .AutoInclude();

            modelBuilder.Entity<RoleMessageType>().HasQueryFilter(p => !p.isDeleted &&
                (p.MessageType != null ? !p.MessageType.isDeleted : true) &&
                (p.Role != null ? !p.Role.isDeleted : true));

            modelBuilder.Entity<MessageType>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Circular>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<RolePermission>()
                .Navigation(p => p.Permission)
                .AutoInclude();

            modelBuilder.Entity<RolePermission>()
                .Navigation(p => p.Role)
                .AutoInclude();

            modelBuilder.Entity<RolePermission>().HasQueryFilter(p => !p.isDeleted &&
                (p.Role != null ? !p.Role.isDeleted : true) &&
                (p.Permission != null ? !p.Permission.isDeleted : true));

            modelBuilder.Entity<AwardPublication>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Album>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Gallery>()
                .Navigation(p => p.Album)
                .AutoInclude();

            modelBuilder.Entity<Gallery>().HasQueryFilter(p => !p.isDeleted &&
                (p.Album != null ? !p.Album.isDeleted : true));

            modelBuilder.Entity<HomePageSlider>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<ReferenceSource>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<SocialMedia>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<StrategicPartner>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<PageStructure>()
                .Navigation(p => p.pageStructure)
                .AutoInclude();

            modelBuilder.Entity<PageStructure>().HasQueryFilter(p => !p.isDeleted &&
                (p.pageStructure != null ? !p.pageStructure.isDeleted : true));

            modelBuilder.Entity<DarkCard>()
                .Navigation(p => p.PageStructure)
                .AutoInclude();

            modelBuilder.Entity<DarkCard>().HasQueryFilter(p => !p.isDeleted &&
                (p.PageStructure != null ? !p.PageStructure.isDeleted : true));

            modelBuilder.Entity<ParagraphCard>()
                .Navigation(p => p.PageStructure)
                .AutoInclude();

            modelBuilder.Entity<ParagraphCard>().HasQueryFilter(p => !p.isDeleted &&
                (p.PageStructure != null ? !p.PageStructure.isDeleted : true));

            modelBuilder.Entity<AwardSponsor>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Reward>()
                .Navigation(p => p.Category)
                .AutoInclude();

            modelBuilder.Entity<Reward>().HasQueryFilter(p => !p.isDeleted &&
                (p.Category != null ? !p.Category.isDeleted : true));

            modelBuilder.Entity<AwardStatistic>()
                .Navigation(p => p.Cycle)
                .AutoInclude();

            modelBuilder.Entity<AwardStatistic>().HasQueryFilter(p => !p.isDeleted &&
                (p.Cycle != null ? !p.Cycle.isDeleted : true));

            modelBuilder.Entity<CoordinatorForm>()
                .Navigation(p => p.ProvidedForm)
                .AutoInclude();

            modelBuilder.Entity<CoordinatorForm>()
                .Navigation(p => p.Coordinator)
                .AutoInclude();

            modelBuilder.Entity<CoordinatorForm>().HasQueryFilter(p => !p.isDeleted &&
                (p.Coordinator != null ? !p.Coordinator.isDeleted : true) &&
                (p.ProvidedForm != null ? !p.ProvidedForm.isDeleted : true));

            modelBuilder.Entity<ArbitratorForm>()
                .Navigation(p => p.ProvidedForm)
                .AutoInclude();

            modelBuilder.Entity<ArbitratorForm>()
                .Navigation(p => p.Arbitrator)
                .AutoInclude();

            modelBuilder.Entity<ArbitratorForm>().HasQueryFilter(p => !p.isDeleted &&
                (p.Arbitrator != null ? !p.Arbitrator.isDeleted : true) &&
                (p.ProvidedForm != null ? !p.ProvidedForm.isDeleted : true));

            modelBuilder.Entity<Responsibility>()
                .Navigation(p => p.Role)
                .AutoInclude();

            modelBuilder.Entity<Responsibility>().HasQueryFilter(p => !p.isDeleted &&
                (p.Role != null ? !p.Role.isDeleted : true));

            modelBuilder.Entity<ResponsibilityUser>()
                .Navigation(p => p.Responsibility)
                .AutoInclude();

            modelBuilder.Entity<ResponsibilityUser>()
                .Navigation(p => p.User)
                .AutoInclude();

            modelBuilder.Entity<ResponsibilityUser>().HasQueryFilter(p => !p.isDeleted &&
                (p.Responsibility != null ? !p.Responsibility.isDeleted : true) &&
                (p.User != null ? !p.User.isDeleted : true));

            modelBuilder.Entity<NewsImage>()
                .Navigation(p => p.News)
                .AutoInclude();

            modelBuilder.Entity<NewsImage>().HasQueryFilter(p => !p.isDeleted &&
                (p.News != null ? !p.News.isDeleted : true));

            modelBuilder.Entity<CircularAttachment>()
                .Navigation(p => p.Circular)
                .AutoInclude();

            modelBuilder.Entity<CircularAttachment>().HasQueryFilter(p => !p.isDeleted &&
                (p.Circular != null ? !p.Circular.isDeleted : true));

            modelBuilder.Entity<CircularCoordinator>()
                .Navigation(p => p.Coordinator)
                .AutoInclude();

            modelBuilder.Entity<CircularCoordinator>()
                .Navigation(p => p.Circular)
                .AutoInclude();

            modelBuilder.Entity<CircularCoordinator>().HasQueryFilter(p => !p.isDeleted &&
                (p.Circular != null ? !p.Circular.isDeleted : true) &&
                (p.Coordinator != null ? !p.Coordinator.isDeleted : true));

            modelBuilder.Entity<CircularArbitrator>()
                .Navigation(p => p.Circular)
                .AutoInclude();

            modelBuilder.Entity<CircularArbitrator>()
                .Navigation(p => p.Arbitrator)
                .AutoInclude();

            modelBuilder.Entity<CircularArbitrator>().HasQueryFilter(p => !p.isDeleted &&
                (p.Circular != null ? !p.Circular.isDeleted : true) &&
                (p.Arbitrator != null ? !p.Arbitrator.isDeleted : true));

            modelBuilder.Entity<CircularChairman>()
                .Navigation(p => p.Chairman)
                .AutoInclude();

            modelBuilder.Entity<CircularChairman>()
                .Navigation(p => p.Circular)
                .AutoInclude();

            modelBuilder.Entity<CircularChairman>().HasQueryFilter(p => !p.isDeleted &&
                (p.Circular != null ? !p.Circular.isDeleted : true) &&
                (p.Chairman != null ? !p.Chairman.isDeleted : true));

            modelBuilder.Entity<TextCard>()
                .Navigation(p => p.PageStructure)
                .AutoInclude();

            modelBuilder.Entity<TextCard>().HasQueryFilter(p => !p.isDeleted &&
                (p.PageStructure != null ? !p.PageStructure.isDeleted : true));

            modelBuilder.Entity<ImageCard>()
                .Navigation(p => p.PageStructure)
                .AutoInclude();

            modelBuilder.Entity<ImageCard>().HasQueryFilter(p => !p.isDeleted &&
                (p.PageStructure != null ? !p.PageStructure.isDeleted : true));

            modelBuilder.Entity<PageStructureImages>()
                .Navigation(p => p.ImageCard)
                .AutoInclude();

            modelBuilder.Entity<PageStructureImages>().HasQueryFilter(p => !p.isDeleted &&
                (p.ImageCard != null ? !p.ImageCard.isDeleted : true));

            modelBuilder.Entity<Domain.Entities.IndexModel.Index>()
                .HasIndex(p => p.EnglishName)
                .IsUnique();

            modelBuilder.Entity<Domain.Entities.IndexModel.Index>()
                .HasIndex(p => p.ArabicName)
                .IsUnique();

            modelBuilder.Entity<Domain.Entities.IndexModel.Index>()
                .HasIndex(p => p.Slug)
                .IsUnique();

            modelBuilder.Entity<PageStructure>()
                .HasIndex(p => p.EnglishTitle)
                .IsUnique();

            modelBuilder.Entity<PageStructure>()
                .HasIndex(p => p.Slug)
                .IsUnique();

            modelBuilder.Entity<User>()
                .HasIndex(u => u.SubscriberId)
                .IsUnique();

            modelBuilder.Entity<Instruction>()
                .HasIndex(x => x.Slug)
                .IsUnique();

            modelBuilder.Entity<Arbitrator>()
                .Property(a => a.Id)
                .ValueGeneratedNever();

            modelBuilder.Entity<Coordinator>()
                .Property(a => a.Id)
                .ValueGeneratedNever();

            modelBuilder.Entity<Domain.Entities.IndexModel.Index>()
                .HasData(
                new Domain.Entities.IndexModel.Index()
                {
                    Id = 1,
                    ArabicName = "نوع الرسالة",
                    EnglishName = "Message Type",
                    Slug = "Message_Type"
                });

            modelBuilder.Entity<OnePageText>()
                .Property(e => e.ArabicText)
                .HasColumnType("nvarchar(max)");
            modelBuilder.Entity<OnePageText>()
                .Property(e => e.EnglishText)
                .HasColumnType("nvarchar(max)");


            // modelBuilder.Entity<User>().ToTable("users");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SharijhaAwardDbContext).Assembly);

            modelBuilder.Entity<PersonalInvitee>()
                .HasIndex(p => new { p.Email, p.isDeleted })
                .HasFilter("[isDeleted] = 0")
                .IsUnique();

            modelBuilder.Entity<GroupInvitee>()
                .HasIndex(p => new { p.Email, p.isDeleted })
                .HasFilter("[isDeleted] = 0")
                .IsUnique();

            modelBuilder.Entity<ProvidedForm>()
                .HasIndex(p => new { p.Id })
                .HasFilter("[isDeleted] = 0")
                .IsUnique();

        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedAt = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedAt = DateTime.Now;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
