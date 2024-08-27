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
            modelBuilder.Entity<Achievement>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<CriterionAttachment>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<RelatedAccountRequest>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<AppVersion>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Instruction>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Arbitration>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Notification>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<NotificationTemplate>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<LogUserAction>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<UserToken>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<UserNotification>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<ChairmanNotesOnFinalArbitrationScore>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<DynamicAttributeTableValue>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<FinalArbitrationScore>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<FinalArbitration>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<AdvancedFormBuilderValue>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<AdvancedFormBuilderGeneralValidation>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<CategoryEducationalEntity>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<ArbitrationResult>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<ViewWhenRelation>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<ExplanatoryMessage>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<AdvancedFormBuilderTableValue>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<AdvancedFormBuilderPatternValue>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<AdvancedFormBuilderPattern>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<AdvancedFormBuilderListValue>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<AdvancedFormBuilder>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<AdvancedFormBuilderSection>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<InterviewAttachment>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Interview>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<InterviewQuestion>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<InterviewNote>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<InterviewCategory>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<InterviewUser>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<ChairmanNotesOnArbitrationAudit>().HasQueryFilter(p => !p.isDeleted);
            
            modelBuilder.Entity<ChairmanNotesOnInitialArbitration>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<InitialArbitration>().HasQueryFilter(p => !p.isDeleted);
            
            modelBuilder.Entity<ArbitrationAudit>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<ArbitrationScale>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<ArbitrationScalesCriterion>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<MeetingCategory>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Meeting>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<MeetingUser>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<UserRole>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<PermissionHeader>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<ArbitratorClass>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Committee>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<ComitteeArbitrator>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<CategoryCommittee>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<CategoryEducationalClass>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<EducationalClass>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Agenda>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Arbitrator>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<CategoryArbitrator>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<OnePageText>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<RelatedAccount>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Criterion>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<CriterionItem>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<CriterionItemAttachment>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<GeneralFAQ>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<GeneralFAQCategory>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Event>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Cycle>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<GroupInvitee>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<PersonalInvitee>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Category>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<News>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<TrainingWorkshop>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<FrequentlyAskedQuestion>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<User>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Role>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Student>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<AttributeDataType>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<AttributeOperation>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<AttributeTableName>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Dependency>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<DependencyValidation>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<DynamicAttribute>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<GeneralValidation>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<DynamicAttributeListValue>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<DynamicAttributeSection>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<DynamicAttributeValue>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<StaticAttribute>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<TermAndCondition>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<ConditionsProvidedForms>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<DynamicAttributePattern>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<DynamicAttributePatternValue>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<ProvidedForm>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<CategoryFAQ>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<ExplanatoryGuide>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<CycleCondition>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<ConditionAttachment>().HasQueryFilter(p => !p.isDeleted);
            
            modelBuilder.Entity<Coordinator>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<EducationalInstitution>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<EducationalEntity>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<EduEntitiesCoordinator>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<AboutAwardPage>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<GeneralWorkshop>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<OurGoal>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<CycleConditionAttachment>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<CycleConditionsProvidedForm>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<ExtraAttachment>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<ExtraAttachmentFile>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<EmailMessage>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<EmailAttachment>().HasQueryFilter(p => !p.isDeleted);
            
            modelBuilder.Entity<RoleMessageType>().HasQueryFilter(p => !p.isDeleted);
            
            modelBuilder.Entity<MessageType>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Circular>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<RolePermission>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<AwardPublication>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Album>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Gallery>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<HomePageSlider>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<ReferenceSource>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<SocialMedia>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<StrategicPartner>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<PageStructure>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<DarkCard>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<ParagraphCard>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<AwardSponsor>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Reward>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<AwardStatistic>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<CoordinatorForm>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<ArbitratorForm>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Responsibility>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<ResponsibilityUser>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<NewsImage>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<CircularAttachment>().HasQueryFilter(p => !p.isDeleted);
            
            modelBuilder.Entity<CircularCoordinator>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<CircularArbitrator>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<CircularChairman>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<TextCard>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<ImageCard>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<PageStructureImages>().HasQueryFilter(p => !p.isDeleted);

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
