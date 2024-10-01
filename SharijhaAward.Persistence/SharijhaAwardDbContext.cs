using Microsoft.EntityFrameworkCore;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.EventModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.InvitationModels;
using SharijhaAward.Domain.Entities.CategoryCommitteeModel;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.TrainingWorkshopSubscriberModel;
using SharijhaAward.Domain.Entities.ProvidedFormModel;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.TrainingWorkshopModel;
using SharijhaAward.Domain.Entities.FAQModel;
using SharijhaAward.Domain.Entities.NewsModel;
using SharijhaAward.Domain.Entities.TermsAndConditionsModel;
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
using SharijhaAward.Domain.Entities.InterviewModel;
using SharijhaAward.Domain.Entities.FinalArbitrationModel;
using SharijhaAward.Domain.Entities.ArbitratorFormModel;
using SharijhaAward.Domain.Entities.CoordinatorFormModel;
using SharijhaAward.Domain.Entities.AdvancedFormBuilderModel;
using SharijhaAward.Domain.Entities.ExplanatoryMessageModel;
using SharijhaAward.Domain.Entities.ResponsibilityModel;
using SharijhaAward.Domain.Entities;
using SharijhaAward.Domain.Entities.ArbitrationResultModel;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using AutoMapper;
using System.Reflection;
using static SharijhaAward.Application.Helpers.DatabaseRelationsHelper.DatabaseRelationsClass;
using NPOI.HSSF.Record;
using SharijhaAward.Domain.Entities.ChatBotModel;
using Microsoft.Extensions.Configuration;

namespace SharijhaAward.Persistence
{
    public class SharijhaAwardDbContext : DbContext
    {
        public List<object> EntitiesToDelete;

        private IMapper _Mapper;
        private IConfiguration _Configuration;
        public SharijhaAwardDbContext(DbContextOptions<SharijhaAwardDbContext> options)
        : base(options)
        {
        }
        public SharijhaAwardDbContext(DbContextOptions<SharijhaAwardDbContext> options,
            IMapper Mapper,
            IConfiguration Configuration)
        : base(options)
        {
            _Mapper = Mapper;
            _Configuration = Configuration;
        }

        public DbSet<SwitchArbitration> SwitchArbitrations { get; set; }
        public DbSet<ViewWhenRelation> ViewWhenRelations { get; set; }
        public DbSet<ArbitrationResult> ArbitrationResults { get; set; }
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
        public DbSet<ImageCard> ImageCards { get; set; }
        public DbSet<PageStructureImages> PageStructureImages { get; set; }
        public DbSet<OnePageText> OnePageText { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<PageCard> PageCards { get; set; }
        public DbSet<ChatBotQuestion> ChatBotQuestions { get; set; }
        public DbSet<WorkflowQuestion> WorkflowQuestions { get; set; }
        

        public DbSet<AdvancedFormBuilderViewWhenRelation> AdvancedFormBuilderViewWhenRelations { get; set; }
        public DbSet<AdvancedFormBuilderDependency> AdvancedFormBuilderDependencies { get; set; }
        public DbSet<AdvancedFormBuilderDependencyGroup> AdvancedFormBuilderDependencyGroups { get; set; }
        public DbSet<AdvancedFormBuilderDependencyValidation> AdvancedFormBuilderDependencyValidations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                // Check if the entity inherits from AuditableEntity
                if (typeof(AuditableEntity).IsAssignableFrom(entityType.ClrType))
                {
                    // Configure the 'isDeleted' property to have a default value of false
                    modelBuilder.Entity(entityType.ClrType)
                        .Property(nameof(AuditableEntity.isDeleted))
                        .HasDefaultValue(false);

                    modelBuilder.Entity(entityType.ClrType)
                        .Property(nameof(AuditableEntity.DeletedAt))
                        .HasDefaultValue(null);

                    modelBuilder.Entity(entityType.ClrType)
                        .Property(nameof(AuditableEntity.CreatedBy))
                        .HasDefaultValue(null);

                    modelBuilder.Entity(entityType.ClrType)
                        .Property(nameof(AuditableEntity.CreatedAt))
                        .HasDefaultValue(DateTime.UtcNow);

                    modelBuilder.Entity(entityType.ClrType)
                        .Property(nameof(AuditableEntity.LastModifiedBy))
                        .HasDefaultValue(null);

                    modelBuilder.Entity(entityType.ClrType)
                        .Property(nameof(AuditableEntity.LastModifiedAt))
                        .HasDefaultValue(null);
                }
            }

            base.OnModelCreating(modelBuilder);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.NoAction;
            }


            //Filter for Deleted items
            modelBuilder.Entity<Achievement>()
                .Navigation(p => p.User)
                .AutoInclude();

            modelBuilder.Entity<Achievement>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<ChatBotQuestion>().HasQueryFilter(p => !p.isDeleted);


            modelBuilder.Entity<CriterionAttachment>()
                .Navigation(p => p.Criterion)
                .AutoInclude();

            modelBuilder.Entity<CriterionAttachment>()
                .Navigation(p => p.ProvidedForm)
                .AutoInclude();

            modelBuilder.Entity<CriterionAttachment>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<RelatedAccountRequest>()
                .Navigation(p => p.Sender)
                .AutoInclude();

            modelBuilder.Entity<RelatedAccountRequest>()
                .Navigation(p => p.Receiver)
                .AutoInclude();

            modelBuilder.Entity<RelatedAccountRequest>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<AppVersion>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Instruction>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Arbitration>()
                .Navigation(p => p.Arbitrator)
                .AutoInclude();

            modelBuilder.Entity<Arbitration>()
                .Navigation(p => p.ProvidedForm)
                .AutoInclude();

            modelBuilder.Entity<Arbitration>()
                .Navigation(p => p.DoneArbitrationUser)
                .AutoInclude();

            modelBuilder.Entity<Arbitration>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Notification>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<NotificationTemplate>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<LogUserAction>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<UserToken>()
                .Navigation(p => p.User)
                .AutoInclude();

            modelBuilder.Entity<UserToken>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<UserNotification>()
                .Navigation(p => p.User)
                .AutoInclude();

            modelBuilder.Entity<UserNotification>()
                .Navigation(p => p.Notification)
                .AutoInclude();

            modelBuilder.Entity<UserNotification>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<ChairmanNotesOnFinalArbitrationScore>()
                .Navigation(p => p.FinalArbitrationScore)
                .AutoInclude();

            modelBuilder.Entity<ChairmanNotesOnFinalArbitrationScore>()
                .Navigation(p => p.Chairman)
                .AutoInclude();

            modelBuilder.Entity<ChairmanNotesOnFinalArbitrationScore>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<DynamicAttributeTableValue>()
                .Navigation(p => p.DynamicAttribute)
                .AutoInclude();

            modelBuilder.Entity<DynamicAttributeTableValue>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<FinalArbitrationScore>()
                .Navigation(p => p.FinalArbitration)
                .AutoInclude();

            modelBuilder.Entity<FinalArbitrationScore>()
                .Navigation(p => p.CriterionItem)
                .AutoInclude();

            modelBuilder.Entity<FinalArbitrationScore>()
                .Navigation(p => p.Criterion)
                .AutoInclude();

            modelBuilder.Entity<FinalArbitrationScore>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<FinalArbitration>()
                .Navigation(p => p.ProvidedForm)
                .AutoInclude();

            modelBuilder.Entity<FinalArbitration>()
                .Navigation(p => p.Arbitrator)
                .AutoInclude();

            modelBuilder.Entity<FinalArbitration>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<AdvancedFormBuilderValue>()
                .Navigation(p => p.AdvancedFormBuilder)
                .AutoInclude();

            modelBuilder.Entity<AdvancedFormBuilderValue>()
                .Navigation(p => p.VirtualTable)
                .AutoInclude();

            modelBuilder.Entity<AdvancedFormBuilderValue>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<AdvancedFormBuilderGeneralValidation>()
                .Navigation(p => p.AdvancedFormBuilder)
                .AutoInclude();

            modelBuilder.Entity<AdvancedFormBuilderGeneralValidation>()
                .Navigation(p => p.AttributeOperation)
                .AutoInclude();

            modelBuilder.Entity<AdvancedFormBuilderGeneralValidation>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<ArbitrationResult>()
                .Navigation(p => p.ProvidedForm)
                .AutoInclude();

            modelBuilder.Entity<ArbitrationResult>()
                .Navigation(p => p.FinalArbitration)
                .AutoInclude();

            modelBuilder.Entity<ArbitrationResult>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<SwitchArbitration>()
                .Navigation(p => p.OldArbitrator)
                .AutoInclude();

            modelBuilder.Entity<SwitchArbitration>()
                .Navigation(p => p.NewArbitrator)
                .AutoInclude();

            modelBuilder.Entity<SwitchArbitration>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<ViewWhenRelation>()
                .Navigation(p => p.DynamicAttributeSection)
                .AutoInclude();

            modelBuilder.Entity<ViewWhenRelation>()
                .Navigation(p => p.DynamicAttribute)
                .AutoInclude();

            modelBuilder.Entity<ViewWhenRelation>()
                .Navigation(p => p.DynamicAttributeListValue)
                .AutoInclude();

            modelBuilder.Entity<ViewWhenRelation>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<ExplanatoryMessage>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<AdvancedFormBuilderTableValue>()
                .Navigation(p => p.AdvancedFormBuilder)
                .AutoInclude();

            modelBuilder.Entity<AdvancedFormBuilderTableValue>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<AdvancedFormBuilderPatternValue>()
                .Navigation(p => p.AdvancedFormBuilderPattern)
                .AutoInclude();

            modelBuilder.Entity<AdvancedFormBuilderPatternValue>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<AdvancedFormBuilderPattern>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<AdvancedFormBuilderListValue>()
                .Navigation(p => p.AdvancedFormBuilder)
                .AutoInclude();

            modelBuilder.Entity<AdvancedFormBuilderListValue>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<AdvancedFormBuilder>()
                .Navigation(p => p.AdvancedFormBuilderSection)
                .AutoInclude();

            modelBuilder.Entity<AdvancedFormBuilder>()
                .Navigation(p => p.AttributeDataType)
                .AutoInclude();

            modelBuilder.Entity<AdvancedFormBuilder>().HasQueryFilter(p => !p.isDeleted);
            
            modelBuilder.Entity<AdvancedFormBuilderSection>()
                .Navigation(p => p.VirtualTableForSection)
                .AutoInclude();

            modelBuilder.Entity<AdvancedFormBuilderSection>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<InterviewAttachment>()
                .Navigation(p => p.Interview)
                .AutoInclude();

            modelBuilder.Entity<InterviewAttachment>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Interview>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<InterviewQuestion>()
                .Navigation(p => p.Interview)
                .AutoInclude();

            modelBuilder.Entity<InterviewQuestion>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<InterviewNote>()
                .Navigation(p => p.Interview)
                .AutoInclude();

            modelBuilder.Entity<InterviewNote>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<InterviewCategory>()
                .Navigation(p => p.Interview)
                .AutoInclude();

            modelBuilder.Entity<InterviewCategory>()
                .Navigation(p => p.Category)
                .AutoInclude();

            modelBuilder.Entity<InterviewCategory>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<InterviewUser>()
                .Navigation(p => p.Interview)
                .AutoInclude();

            modelBuilder.Entity<InterviewUser>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<ChairmanNotesOnArbitrationAudit>()
                .Navigation(p => p.ArbitrationAudit)
                .AutoInclude();

            modelBuilder.Entity<ChairmanNotesOnArbitrationAudit>()
                .Navigation(p => p.Chairman)
                .AutoInclude();

            modelBuilder.Entity<ChairmanNotesOnArbitrationAudit>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<ChairmanNotesOnInitialArbitration>()
                .Navigation(p => p.InitialArbitration)
                .AutoInclude();

            modelBuilder.Entity<ChairmanNotesOnInitialArbitration>()
                .Navigation(p => p.Chairman)
                .AutoInclude();

            modelBuilder.Entity<ChairmanNotesOnInitialArbitration>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<InitialArbitration>()
                .Navigation(p => p.CriterionItem)
                .AutoInclude();

            modelBuilder.Entity<InitialArbitration>()
                .Navigation(p => p.Criterion)
                .AutoInclude();

            modelBuilder.Entity<InitialArbitration>()
                .Navigation(p => p.Arbitration)
                .AutoInclude();

            modelBuilder.Entity<InitialArbitration>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<ArbitrationAudit>()
                .Navigation(p => p.ProvidedForm)
                .AutoInclude();

            modelBuilder.Entity<ArbitrationAudit>()
                .Navigation(p => p.CriterionItem)
                .AutoInclude();

            modelBuilder.Entity<ArbitrationAudit>()
                .Navigation(p => p.Criterion)
                .AutoInclude();

            modelBuilder.Entity<ArbitrationAudit>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<ArbitrationScale>()
                .Navigation(p => p.Category)
                .AutoInclude();

            modelBuilder.Entity<ArbitrationScale>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<ArbitrationScalesCriterion>()
                .Navigation(p => p.ArbitrationScale)
                .AutoInclude();

            modelBuilder.Entity<ArbitrationScalesCriterion>()
                .Navigation(p => p.CriterionItem)
                .AutoInclude();

            modelBuilder.Entity<ArbitrationScalesCriterion>()
                .Navigation(p => p.Criterion)
                .AutoInclude();

            modelBuilder.Entity<ArbitrationScalesCriterion>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<MeetingCategory>()
                .Navigation(p => p.Meeting)
                .AutoInclude();

            modelBuilder.Entity<MeetingCategory>()
                .Navigation(p => p.Category)
                .AutoInclude();

            modelBuilder.Entity<MeetingCategory>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Meeting>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<MeetingUser>()
                .Navigation(p => p.Meeting)
                .AutoInclude();

            modelBuilder.Entity<MeetingUser>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<UserRole>()
                .Navigation(p => p.User)
                .AutoInclude();

            modelBuilder.Entity<UserRole>()
                .Navigation(p => p.Role)
                .AutoInclude();

            modelBuilder.Entity<UserRole>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<PermissionHeader>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<ArbitratorClass>()
                .Navigation(p => p.CategoryEducationalClass)
                .AutoInclude();

            modelBuilder.Entity<ArbitratorClass>()
                .Navigation(p => p.Arbitrator)
                .AutoInclude();

            modelBuilder.Entity<ArbitratorClass>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Committee>()
                .Navigation(p => p.Chairman)
                .AutoInclude();

            modelBuilder.Entity<Committee>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<ComitteeArbitrator>()
                .Navigation(p => p.Arbitrator)
                .AutoInclude();

            modelBuilder.Entity<ComitteeArbitrator>()
                .Navigation(p => p.Committee)
                .AutoInclude();

            modelBuilder.Entity<ComitteeArbitrator>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<CategoryCommittee>()
                .Navigation(p => p.Committee)
                .AutoInclude();

            modelBuilder.Entity<CategoryCommittee>()
                .Navigation(p => p.Category)
                .AutoInclude();

            modelBuilder.Entity<CategoryCommittee>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<CategoryEducationalClass>()
                .Navigation(p => p.Category)
                .AutoInclude();

            modelBuilder.Entity<CategoryEducationalClass>()
                .Navigation(p => p.EducationalClass)
                .AutoInclude();

            modelBuilder.Entity<CategoryEducationalClass>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<EducationalClass>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Agenda>()
                .Navigation(p => p.Cycle)
                .AutoInclude();

            modelBuilder.Entity<Agenda>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Arbitrator>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<CategoryArbitrator>()
                .Navigation(p => p.Category)
                .AutoInclude();

            modelBuilder.Entity<CategoryArbitrator>()
                .Navigation(p => p.Arbitrator)
                .AutoInclude();

            modelBuilder.Entity<CategoryArbitrator>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<OnePageText>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<RelatedAccount>()
                .Navigation(p => p.User1)
                .AutoInclude();

            modelBuilder.Entity<RelatedAccount>()
                .Navigation(p => p.User2)
                .AutoInclude();

            modelBuilder.Entity<RelatedAccount>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Criterion>()
                .Navigation(p => p.Category)
                .AutoInclude();

            modelBuilder.Entity<Criterion>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<CriterionItem>()
                .Navigation(p => p.Criterion)
                .AutoInclude();

            modelBuilder.Entity<CriterionItem>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<CriterionItemAttachment>()
                .Navigation(p => p.CriterionItem)
                .AutoInclude();

            modelBuilder.Entity<CriterionItemAttachment>()
                .Navigation(p => p.ProvidedForm)
                .AutoInclude();

            modelBuilder.Entity<CriterionItemAttachment>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<GeneralFAQ>()
                .Navigation(p => p.GeneralFrequentlyAskedQuestionCategory)
                .AutoInclude();

            modelBuilder.Entity<GeneralFAQ>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<GeneralFAQCategory>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Event>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Cycle>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<GroupInvitee>()
                .Navigation(p => p.Event)
                .AutoInclude();

            modelBuilder.Entity<GroupInvitee>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<PersonalInvitee>()
                .Navigation(p => p.Event)
                .AutoInclude();

            modelBuilder.Entity<PersonalInvitee>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Category>()
                .Navigation(p => p.Cycle)
                .AutoInclude();

            modelBuilder.Entity<Category>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<News>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<TrainingWorkshop>()
                .Navigation(p => p.Category)
                .AutoInclude();

            modelBuilder.Entity<TrainingWorkshop>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<FrequentlyAskedQuestion>()
                .Navigation(p => p.Category)
                .AutoInclude();

            modelBuilder.Entity<FrequentlyAskedQuestion>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<User>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Role>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Student>()
                .Navigation(p => p.GroupInvitee)
                .AutoInclude();

            modelBuilder.Entity<Student>().HasQueryFilter(p => !p.isDeleted);

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

            modelBuilder.Entity<Dependency>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<DependencyValidation>()
                .Navigation(p => p.AttributeOperation)
                .AutoInclude();

            modelBuilder.Entity<DependencyValidation>()
                .Navigation(p => p.DependencyGroup)
                .AutoInclude();

            modelBuilder.Entity<DependencyValidation>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<DynamicAttribute>()
                .Navigation(p => p.AttributeDataType)
                .AutoInclude();

            modelBuilder.Entity<DynamicAttribute>()
                .Navigation(p => p.DynamicAttributeSection)
                .AutoInclude();

            modelBuilder.Entity<DynamicAttribute>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<GeneralValidation>()
                .Navigation(p => p.DynamicAttribute)
                .AutoInclude();

            modelBuilder.Entity<GeneralValidation>()
                .Navigation(p => p.AttributeOperation)
                .AutoInclude();

            modelBuilder.Entity<GeneralValidation>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<DynamicAttributeListValue>()
                .Navigation(p => p.DynamicAttribute)
                .AutoInclude();

            modelBuilder.Entity<DynamicAttributeListValue>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<DynamicAttributeSection>()
                .Navigation(p => p.AttributeTableName)
                .AutoInclude();

            modelBuilder.Entity<DynamicAttributeSection>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<DynamicAttributeValue>()
                .Navigation(p => p.DynamicAttribute)
                .AutoInclude();

            modelBuilder.Entity<DynamicAttributeValue>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<StaticAttribute>()
                .Navigation(p => p.AttributeTableName)
                .AutoInclude();

            modelBuilder.Entity<StaticAttribute>()
                .Navigation(p => p.AttributeDataType)
                .AutoInclude();

            modelBuilder.Entity<StaticAttribute>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<TermAndCondition>()
                .Navigation(p => p.Category)
                .AutoInclude();

            modelBuilder.Entity<TermAndCondition>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<ConditionsProvidedForms>()
                .Navigation(p => p.ProvidedForm)
                .AutoInclude();

            modelBuilder.Entity<ConditionsProvidedForms>()
                .Navigation(p => p.TermAndCondition)
                .AutoInclude();

            modelBuilder.Entity<ConditionsProvidedForms>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<DynamicAttributePattern>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<DynamicAttributePatternValue>()
                .Navigation(p => p.DynamicAttributePattern)
                .AutoInclude();

            modelBuilder.Entity<DynamicAttributePatternValue>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<ProvidedForm>()
                .Navigation(p => p.User)
                .AutoInclude();

            modelBuilder.Entity<ProvidedForm>()
                .Navigation(p => p.Category)
                .AutoInclude();

            modelBuilder.Entity<ProvidedForm>()
                .Navigation(p => p.CategoryEducationalClass)
                .AutoInclude();

            modelBuilder.Entity<ProvidedForm>()
                .Navigation(p => p.EducationalEntity)
                .AutoInclude();

            modelBuilder.Entity<ProvidedForm>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<CategoryFAQ>()
                .Navigation(p => p.Category)
                .AutoInclude();

            modelBuilder.Entity<CategoryFAQ>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<ExplanatoryGuide>()
                .Navigation(p => p.Category)
                .AutoInclude();

            modelBuilder.Entity<ExplanatoryGuide>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<CycleCondition>()
                .Navigation(p => p.Cycle)
                .AutoInclude();

            modelBuilder.Entity<CycleCondition>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<ConditionAttachment>()
                .Navigation(p => p.ConditionsProvidedForms)
                .AutoInclude();

            modelBuilder.Entity<ConditionAttachment>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Coordinator>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<EducationalInstitution>()
                .Navigation(p => p.EducationalEntity)
                .AutoInclude();

            modelBuilder.Entity<EducationalInstitution>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<EducationalEntity>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<EduEntitiesCoordinator>()
                .Navigation(p => p.EducationalEntity)
                .AutoInclude();

            modelBuilder.Entity<EduEntitiesCoordinator>()
                .Navigation(p => p.Coordinator)
                .AutoInclude();

            modelBuilder.Entity<EduEntitiesCoordinator>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<AboutAwardPage>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<GeneralWorkshop>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<OurGoal>()
                .Navigation(p => p.AboutAwardPage)
                .AutoInclude();

            modelBuilder.Entity<OurGoal>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<CycleConditionAttachment>()
                .Navigation(p => p.CycleConditionsProvidedForm)
                .AutoInclude();

            modelBuilder.Entity<CycleConditionAttachment>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<CycleConditionsProvidedForm>()
                .Navigation(p => p.ProvidedForm)
                .AutoInclude();

            modelBuilder.Entity<CycleConditionsProvidedForm>()
                .Navigation(p => p.CycleCondition)
                .AutoInclude();

            modelBuilder.Entity<CycleConditionsProvidedForm>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<ExtraAttachment>()
                .Navigation(p => p.ProvidedForm)
                .AutoInclude();

            modelBuilder.Entity<ExtraAttachment>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<ExtraAttachmentFile>()
                .Navigation(p => p.ExtraAttachment)
                .AutoInclude();

            modelBuilder.Entity<ExtraAttachmentFile>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<EmailMessage>()
                .Navigation(p => p.Type)
                .AutoInclude();

            modelBuilder.Entity<EmailMessage>()
                .Navigation(p => p.User)
                .AutoInclude();

            modelBuilder.Entity<EmailMessage>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<EmailAttachment>()
                .Navigation(p => p.Message)
                .AutoInclude();

            modelBuilder.Entity<EmailAttachment>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<RoleMessageType>()
                .Navigation(p => p.Role)
                .AutoInclude();

            modelBuilder.Entity<RoleMessageType>()
                .Navigation(p => p.MessageType)
                .AutoInclude();

            modelBuilder.Entity<RoleMessageType>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<MessageType>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Circular>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<RolePermission>()
                .Navigation(p => p.Permission)
                .AutoInclude();

            modelBuilder.Entity<RolePermission>()
                .Navigation(p => p.Role)
                .AutoInclude();

            modelBuilder.Entity<RolePermission>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<AwardPublication>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Album>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Gallery>()
                .Navigation(p => p.Album)
                .AutoInclude();

            modelBuilder.Entity<Gallery>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<HomePageSlider>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<ReferenceSource>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<SocialMedia>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<StrategicPartner>().HasQueryFilter(p => !p.isDeleted);

            //modelBuilder.Entity<PageStructure>()
            //    .Navigation(p => p.pageStructure)
            //    .AutoInclude();

            modelBuilder.Entity<PageStructure>().HasQueryFilter(p => !p.isDeleted);

            //modelBuilder.Entity<PageCard>()
            //    .Navigation(p => p.PageStructure)
            //    .AutoInclude();

            modelBuilder.Entity<PageCard>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<AwardSponsor>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Reward>()
                .Navigation(p => p.Category)
                .AutoInclude();

            modelBuilder.Entity<Reward>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<AdvancedFormBuilderViewWhenRelation>()
                .Navigation(p => p.AdvancedFormBuilder)
                .AutoInclude();

            modelBuilder.Entity<AdvancedFormBuilderViewWhenRelation>()
                .Navigation(p => p.AdvancedFormBuilderListValue)
                .AutoInclude();

            modelBuilder.Entity<AdvancedFormBuilderViewWhenRelation>()
                .Navigation(p => p.AdvancedFormBuilderSection)
                .AutoInclude();

            modelBuilder.Entity<AdvancedFormBuilderViewWhenRelation>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<AdvancedFormBuilderDependency>()
                .Navigation(p => p.MainAdvancedFormBuilder)
                .AutoInclude();

            modelBuilder.Entity<AdvancedFormBuilderDependency>()
                .Navigation(p => p.AdvancedFormBuilderDependencyGroup)
                .AutoInclude();

            modelBuilder.Entity<AdvancedFormBuilderDependency>()
                .Navigation(p => p.AdvancedFormBuilder)
                .AutoInclude();

            modelBuilder.Entity<AdvancedFormBuilderDependency>()
                .Navigation(p => p.StaticAttribute)
                .AutoInclude();

            modelBuilder.Entity<AdvancedFormBuilderDependency>()
                .Navigation(p => p.AttributeOperation)
                .AutoInclude();

            modelBuilder.Entity<AdvancedFormBuilderDependency>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<AdvancedFormBuilderDependencyValidation>()
                .Navigation(p => p.AttributeOperation)
                .AutoInclude();

            modelBuilder.Entity<AdvancedFormBuilderDependencyValidation>()
                .Navigation(p => p.AdvancedFormBuilderDependencyGroup)
                .AutoInclude();

            modelBuilder.Entity<AdvancedFormBuilderDependencyValidation>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<AdvancedFormBuilderDependencyGroup>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<AwardStatistic>()
                .Navigation(p => p.Cycle)
                .AutoInclude();

            modelBuilder.Entity<AwardStatistic>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<CoordinatorForm>()
                .Navigation(p => p.ProvidedForm)
                .AutoInclude();

            modelBuilder.Entity<CoordinatorForm>()
                .Navigation(p => p.Coordinator)
                .AutoInclude();

            modelBuilder.Entity<CoordinatorForm>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<ArbitratorForm>()
                .Navigation(p => p.ProvidedForm)
                .AutoInclude();

            modelBuilder.Entity<ArbitratorForm>()
                .Navigation(p => p.Arbitrator)
                .AutoInclude();

            modelBuilder.Entity<ArbitratorForm>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<Responsibility>()
                .Navigation(p => p.Role)
                .AutoInclude();

            modelBuilder.Entity<Responsibility>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<ResponsibilityUser>()
                .Navigation(p => p.Responsibility)
                .AutoInclude();

            modelBuilder.Entity<ResponsibilityUser>()
                .Navigation(p => p.User)
                .AutoInclude();

            modelBuilder.Entity<ResponsibilityUser>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<NewsImage>()
                .Navigation(p => p.News)
                .AutoInclude();

            modelBuilder.Entity<NewsImage>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<CircularAttachment>()
                .Navigation(p => p.Circular)
                .AutoInclude();

            modelBuilder.Entity<CircularAttachment>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<CircularCoordinator>()
                .Navigation(p => p.Coordinator)
                .AutoInclude();

            modelBuilder.Entity<CircularCoordinator>()
                .Navigation(p => p.Circular)
                .AutoInclude();

            modelBuilder.Entity<CircularCoordinator>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<CircularArbitrator>()
                .Navigation(p => p.Circular)
                .AutoInclude();

            modelBuilder.Entity<CircularArbitrator>()
                .Navigation(p => p.Arbitrator)
                .AutoInclude();

            modelBuilder.Entity<CircularArbitrator>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<CircularChairman>()
                .Navigation(p => p.Chairman)
                .AutoInclude();

            modelBuilder.Entity<CircularChairman>()
                .Navigation(p => p.Circular)
                .AutoInclude();

            modelBuilder.Entity<CircularChairman>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<ImageCard>()
                .Navigation(p => p.PageStructure)
                .AutoInclude();

            modelBuilder.Entity<ImageCard>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<PageStructureImages>()
                .Navigation(p => p.ImageCard)
                .AutoInclude();

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
        public override int SaveChanges()
        {
            ApplySoftDeletes();

            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            ApplySoftDeletes();

            return base.SaveChangesAsync(cancellationToken);
        }
        private void ApplySoftDeletes()
        {
            if (EntitiesToDelete == null)
                EntitiesToDelete = new List<object>();

            ChangeTracker.DetectChanges();

            List<AuditableEntity> DeletedEntities = ChangeTracker.Entries<AuditableEntity>().Where(entry =>
            {
                return entry.State == EntityState.Modified &&
                       entry.Property(nameof(AuditableEntity.isDeleted)).IsModified &&
                       (bool)entry.Property(nameof(AuditableEntity.isDeleted)).CurrentValue!;
            }).Select(x => x.Entity).ToList();

            foreach (AuditableEntity DeletedEntity in DeletedEntities)
            {
                EntitiesToDelete.Add(DeletedEntity);

                string EntityId = DeletedEntity.GetType().GetProperty("Id")!.GetValue(DeletedEntity)!.ToString()!;

                DatabaseRelations Item = (DatabaseRelations)Enum.Parse(typeof(DatabaseRelations), DeletedEntity.GetType().Name);

                List<string> Path = GetEnumDescription(Item).Split(" ").ToList();

                List<PropertyInfo> ReflectedTables = this.GetType().GetProperties()
                    .Where(x => Path.Any(y => y.Split('/')[0] == x.Name))
                    .ToList();

                foreach (PropertyInfo ReflectedTable in ReflectedTables)
                {
                    if (ReflectedTable.Name == "DynamicAttributeValues")
                    {
                        string ForeignKeyName = Path.FirstOrDefault(x => x.Split('/')[0] == ReflectedTable.Name)!.Split('/')[1];
                        string MainTableName = Path.FirstOrDefault(x => x.Split('/')[0] == ReflectedTable.Name)!.Split('/')[2];

                        List<object> TableRecords = new List<object>();

                        if (MainTableName == "ProvidedForm")
                        {
                            TableRecords = _Mapper.Map<List<object>>(this.GetType().GetProperty(ReflectedTable.Name)!.GetValue(this))
                                .Where(Record => Record.GetType().GetProperty(ForeignKeyName)!.GetValue(Record) != null
                                    ? (Record!.GetType().GetProperty("DynamicAttribute")!
                                        .GetValue(Record)!.GetType().GetProperty("DynamicAttributeSection")!
                                            .GetValue(Record!.GetType().GetProperty("DynamicAttribute")!
                                                .GetValue(Record)!)!.GetType().GetProperty("AttributeTableNameId")!
                                                    .GetValue(Record!.GetType().GetProperty("DynamicAttribute")!
                                                        .GetValue(Record)!.GetType().GetProperty("DynamicAttributeSection")!
                                                            .GetValue(Record!.GetType().GetProperty("DynamicAttribute")!
                                                                .GetValue(Record)!)!)!.ToString() == "1")
                                : false)
                            .ToList();
                        }
                        else if (MainTableName == "Coordinator")
                        {
                            TableRecords = _Mapper.Map<List<object>>(this.GetType().GetProperty(ReflectedTable.Name)!.GetValue(this))
                                .Where(Record => Record.GetType().GetProperty(ForeignKeyName)!.GetValue(Record) != null
                                    ? (Record!.GetType().GetProperty("DynamicAttribute")!
                                        .GetValue(Record)!.GetType().GetProperty("DynamicAttributeSection")!
                                            .GetValue(Record!.GetType().GetProperty("DynamicAttribute")!
                                                .GetValue(Record)!)!.GetType().GetProperty("AttributeTableNameId")!
                                                    .GetValue(Record!.GetType().GetProperty("DynamicAttribute")!
                                                        .GetValue(Record)!.GetType().GetProperty("DynamicAttributeSection")!
                                                            .GetValue(Record!.GetType().GetProperty("DynamicAttribute")!
                                                                .GetValue(Record)!)!)!.ToString() == "2")
                                : false)
                            .ToList();
                        }
                        else if (MainTableName == "Arbitrator")
                        {
                            TableRecords = _Mapper.Map<List<object>>(this.GetType().GetProperty(ReflectedTable.Name)!.GetValue(this))
                                .Where(Record => Record.GetType().GetProperty(ForeignKeyName)!.GetValue(Record) != null
                                    ? (Record!.GetType().GetProperty("DynamicAttribute")!
                                        .GetValue(Record)!.GetType().GetProperty("DynamicAttributeSection")!
                                            .GetValue(Record!.GetType().GetProperty("DynamicAttribute")!
                                                .GetValue(Record)!)!.GetType().GetProperty("AttributeTableNameId")!
                                                    .GetValue(Record!.GetType().GetProperty("DynamicAttribute")!
                                                        .GetValue(Record)!.GetType().GetProperty("DynamicAttributeSection")!
                                                            .GetValue(Record!.GetType().GetProperty("DynamicAttribute")!
                                                                .GetValue(Record)!)!)!.ToString() == "3")
                                : false)
                            .ToList();
                        }

                        if (TableRecords.Any())
                        {
                            EntitiesToDelete.AddRange(TableRecords);

                            DeleteBackword(ReflectedTable.Name, TableRecords
                                .Select(TableRecord => TableRecord.GetType().GetProperty("Id")!.GetValue(TableRecord)!.ToString()!)
                                .ToList());
                        }
                    }
                    else
                    {
                        string ForeignKeyName = Path.FirstOrDefault(x => x.Split('/')[0] == ReflectedTable.Name)!.Split('/')[1];

                        List<object> TableRecords = _Mapper.Map<List<object>>(this.GetType().GetProperty(ReflectedTable.Name)!.GetValue(this))
                            .Where(Record => Record.GetType().GetProperty(ForeignKeyName)!.GetValue(Record) != null
                                ? Record.GetType().GetProperty(ForeignKeyName)!.GetValue(Record)!.ToString() == EntityId
                                : false)
                            .ToList();

                        if (TableRecords.Any())
                        {
                            EntitiesToDelete.AddRange(TableRecords);

                            DeleteBackword(ReflectedTable.Name, TableRecords
                                .Select(TableRecord => TableRecord.GetType().GetProperty("Id")!.GetValue(TableRecord)!.ToString()!)
                                .ToList());
                        }
                    }
                }
            }

            DateTime DeleteAtValue = DateTime.UtcNow;

            foreach (var TableRecord in EntitiesToDelete)
            {
                if (TableRecord.GetType().GetProperty("isDeleted") != null
                    ? bool.Parse(TableRecord.GetType().GetProperty("isDeleted")!.GetValue(TableRecord)!.ToString()!) != true
                    : false)
                {
                    TableRecord.GetType().GetProperty("isDeleted")!.SetValue(TableRecord, true);
                    TableRecord.GetType().GetProperty("DeletedAt")!.SetValue(TableRecord, DeleteAtValue);
                }
            }
        }

        public void DeleteBackword(string ReflectedTableName, List<string> EntitiesIds)
        {
            EntitiesIds = EntitiesToDelete
                .Where(x => x.GetType().Name.ToLower() == ReflectedTableName.ToLower() &&
                    !EntitiesIds.Contains(x.GetType().GetProperty("Id")!.GetValue(x)!.ToString()!))
                .Select(x => x.GetType().GetProperty("Id")!.GetValue(x)!.ToString()!)
                .ToList();

            DatabaseRelations Item = (DatabaseRelations)Enum.Parse(typeof(DatabaseRelations), ReflectedTableName);

            List<string> Path = GetEnumDescription(Item).Split(" ").ToList();

            List<PropertyInfo> ReflectedTables = this.GetType().GetProperties()
                .Where(x => Path.Any(y => y.Split('/')[0] == x.Name))
                .ToList();

            foreach (PropertyInfo ReflectedTable in ReflectedTables)
            {
                if (ReflectedTable.Name == "DynamicAttributeValues" &&
                    (ReflectedTableName == "Coordinator" || ReflectedTableName == "Coordinators" ||
                    ReflectedTableName == "Arbitrator" || ReflectedTableName == "Arbitrators" ||
                    ReflectedTableName == "ProvidedForm" || ReflectedTableName == "ProvidedForms"))
                {
                    string ForeignKeyName = Path.FirstOrDefault(x => x.Split('/')[0] == ReflectedTable.Name)!.Split('/')[1];
                    string MainTableName = Path.FirstOrDefault(x => x.Split('/')[0] == ReflectedTable.Name)!.Split('/')[2];

                    List<object> TableRecords = new List<object>();

                    if (MainTableName == "ProvidedForm")
                    {
                        TableRecords = _Mapper.Map<List<object>>(this.GetType().GetProperty(ReflectedTable.Name)!.GetValue(this))
                            .Where(Record => Record.GetType().GetProperty(ForeignKeyName)!.GetValue(Record) != null
                                ? (EntitiesIds.Contains(Record.GetType().GetProperty(ForeignKeyName)!.GetValue(Record)!.ToString()!) &&
                                    Record!.GetType().GetProperty("DynamicAttribute")!
                                        .GetValue(Record)!.GetType().GetProperty("DynamicAttributeSection")!
                                            .GetValue(Record!.GetType().GetProperty("DynamicAttribute")!
                                                .GetValue(Record)!)!.GetType().GetProperty("AttributeTableNameId")!
                                                    .GetValue(Record!.GetType().GetProperty("DynamicAttribute")!
                                                        .GetValue(Record)!.GetType().GetProperty("DynamicAttributeSection")!
                                                            .GetValue(Record!.GetType().GetProperty("DynamicAttribute")!
                                                                .GetValue(Record)!)!)!.ToString() == "1")
                                : false)
                            .ToList();
                    }
                    else if (MainTableName == "Coordinator")
                    {
                        TableRecords = _Mapper.Map<List<object>>(this.GetType().GetProperty(ReflectedTable.Name)!.GetValue(this))
                            .Where(Record => Record.GetType().GetProperty(ForeignKeyName)!.GetValue(Record) != null
                                ? (EntitiesIds.Contains(Record.GetType().GetProperty(ForeignKeyName)!.GetValue(Record)!.ToString()!) &&
                                    Record!.GetType().GetProperty("DynamicAttribute")!
                                        .GetValue(Record)!.GetType().GetProperty("DynamicAttributeSection")!
                                            .GetValue(Record!.GetType().GetProperty("DynamicAttribute")!
                                                .GetValue(Record)!)!.GetType().GetProperty("AttributeTableNameId")!
                                                    .GetValue(Record!.GetType().GetProperty("DynamicAttribute")!
                                                        .GetValue(Record)!.GetType().GetProperty("DynamicAttributeSection")!
                                                            .GetValue(Record!.GetType().GetProperty("DynamicAttribute")!
                                                                .GetValue(Record)!)!)!.ToString() == "2")
                                : false)
                            .ToList();
                    }
                    else if (MainTableName == "Arbitrator")
                    {
                        TableRecords = _Mapper.Map<List<object>>(this.GetType().GetProperty(ReflectedTable.Name)!.GetValue(this))
                            .Where(Record => Record.GetType().GetProperty(ForeignKeyName)!.GetValue(Record) != null
                                ? (EntitiesIds.Contains(Record.GetType().GetProperty(ForeignKeyName)!.GetValue(Record)!.ToString()!) &&
                                    Record!.GetType().GetProperty("DynamicAttribute")!
                                        .GetValue(Record)!.GetType().GetProperty("DynamicAttributeSection")!
                                            .GetValue(Record!.GetType().GetProperty("DynamicAttribute")!
                                                .GetValue(Record)!)!.GetType().GetProperty("AttributeTableNameId")!
                                                    .GetValue(Record!.GetType().GetProperty("DynamicAttribute")!
                                                        .GetValue(Record)!.GetType().GetProperty("DynamicAttributeSection")!
                                                            .GetValue(Record!.GetType().GetProperty("DynamicAttribute")!
                                                                .GetValue(Record)!)!)!.ToString() == "3")
                                : false)
                            .ToList();
                    }

                    if (TableRecords.Any())
                    {
                        EntitiesToDelete.AddRange(TableRecords);

                        DeleteBackword(ReflectedTable.Name, TableRecords
                            .Select(TableRecord => TableRecord.GetType().GetProperty("Id")!.GetValue(TableRecord)!.ToString()!)
                            .ToList());
                    }
                }
                else
                {
                    string ForeignKeyName = Path.FirstOrDefault(x => x.Split('/')[0] == ReflectedTable.Name)!.Split('/')[1];

                    List<object> TableRecords = _Mapper.Map<List<object>>(this.GetType().GetProperty(ReflectedTable.Name)!.GetValue(this))
                        .Where(Record => Record.GetType().GetProperty(ForeignKeyName)!.GetValue(Record) != null
                            ? EntitiesIds.Contains(Record.GetType().GetProperty(ForeignKeyName)!.GetValue(Record)!.ToString()!)
                            : false)
                        .ToList();

                    if (TableRecords.Any())
                    {
                        EntitiesToDelete.AddRange(TableRecords);

                        DeleteBackword(ReflectedTable.Name, TableRecords
                            .Select(TableRecord => TableRecord.GetType().GetProperty("Id")!.GetValue(TableRecord)!.ToString()!)
                            .ToList());
                    }
                }
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_Configuration.GetConnectionString("DefaultConnection"),
                    options => options.MigrationsAssembly("SharijhaAward.Api"));
            }
        }
    }
}
