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

namespace SharijhaAward.Persistence
{
    public class SharijhaAwardDbContext : DbContext
    {
        public SharijhaAwardDbContext(DbContextOptions<SharijhaAwardDbContext> options)
        : base(options)
        {

        }

        public DbSet<FinalArbitration> FinalArbitrations { get; set; }
        public DbSet<InterviewAttachment> InterviewAttachments { get; set; }
        public DbSet<Interview> Interviews { get; set; }
        public DbSet<InterviewNote> InterviewNotes { get; set; }
        public DbSet<InterviewQuestion> InterviewQuestions { get; set; }
        public DbSet<InterviewCategory> InterviewCategories { get; set; }
        public DbSet<InterviewUser> InterviewUsers { get; set; }
        public DbSet<InitialArbitration> InitialArbitrations { get; set; }
        public DbSet<ChairmanNotesOnInitialArbitration> ChairmanNotesOnInitialArbitrations { get; set; }
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
        public DbSet<EduEntitiesCoordinator> EducationCoordinators { get; set; }
        public DbSet<EducationalInstitution> EducationalInstitutions { get; set; }
        public DbSet<EduInstitutionCoordinator> InstitutionCoordinators { get; set; }
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
            modelBuilder.Entity<FinalArbitration>().HasQueryFilter(p => !p.isDeleted);
            modelBuilder.Entity<InterviewAttachment>().HasQueryFilter(p => !p.isDeleted);
            modelBuilder.Entity<Interview>().HasQueryFilter(p => !p.isDeleted);
            modelBuilder.Entity<InterviewQuestion>().HasQueryFilter(p => !p.isDeleted);
            modelBuilder.Entity<InterviewNote>().HasQueryFilter(p => !p.isDeleted);
            modelBuilder.Entity<InterviewCategory>().HasQueryFilter(p => !p.isDeleted);
            modelBuilder.Entity<InterviewUser>().HasQueryFilter(p => !p.isDeleted);
            modelBuilder.Entity<ChairmanNotesOnInitialArbitration>().HasQueryFilter(p => !p.isDeleted);
            modelBuilder.Entity<InitialArbitration>().HasQueryFilter(p => !p.isDeleted);
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
            modelBuilder.Entity<EduEntitiesCoordinator>().HasQueryFilter(p => !p.isDeleted);
            modelBuilder.Entity<EducationalInstitution>().HasQueryFilter(p => !p.isDeleted);
            modelBuilder.Entity<EducationalEntity>().HasQueryFilter(p => !p.isDeleted);
            modelBuilder.Entity<EduInstitutionCoordinator>().HasQueryFilter(p => !p.isDeleted);
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

            modelBuilder.Entity<PermissionHeader>()
                .HasData(new PermissionHeader()
                {
                    Id = 1,
                    Name = "إدارة الدورات",
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                });

            modelBuilder.Entity<Permission>()
                .HasData(new Permission()
                {
                    Id = 1,
                    Name = "عرض الدورات",
                    PermissionHeaderId = 1,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    Id = 2,
                    Name = "إضافة دورة",
                    PermissionHeaderId = 1,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    Id = 3,
                    Name = "عرض معلومات دورة",
                    PermissionHeaderId = 1,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    Id = 4,
                    Name = "تعديل دورة",
                    PermissionHeaderId = 1,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Permission()
                {
                    Id = 5,
                    Name = "حذف دورة",
                    PermissionHeaderId = 1,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                });

            modelBuilder.Entity<Event>()
                .HasData(new Event()
                {
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Id = 1,
                    ArabicDescription = "اختبار وصف حدث 1",
                    ArabicLocation = "اختبار موقع الفعالية 1",
                    ArabicName = "اختبار اسم حدث 1",
                    ArabicSiteName = "اختبار اسم مكان الحدث 1",
                    EndDate = DateTime.UtcNow.AddDays(5),
                    EnglishDescription = "Test Event Description 1",
                    EnglishLocation = "Test Event Location 1",
                    EnglishName = "Test Event Name 1",
                    EnglishSiteName = "Test Event Site Name 1",
                    EventDate = DateTime.UtcNow.AddDays(2),
                    StartDate = DateTime.UtcNow.AddDays(3),
                    UniqueIntegerId = 1
                }, new Event()
                {
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Id = 2,
                    ArabicDescription = "اختبار وصف حدث 2",
                    ArabicLocation = "اختبار موقع الفعالية 2",
                    ArabicName = "اختبار اسم حدث 2",
                    ArabicSiteName = "اختبار اسم مكان الحدث 2",
                    EndDate = DateTime.UtcNow.AddDays(8),
                    EnglishDescription = "Test Event Description 2",
                    EnglishLocation = "Test Event Location 2",
                    EnglishName = "Test Event Name 2",
                    EnglishSiteName = "Test Event Site Name 2",
                    EventDate = DateTime.UtcNow.AddDays(5),
                    StartDate = DateTime.UtcNow.AddDays(6),
                    UniqueIntegerId = 2
                });

            modelBuilder.Entity<OnePageText>()
                .Property(e => e.ArabicText)
                .HasColumnType("nvarchar(max)");
            modelBuilder.Entity<OnePageText>()
                .Property(e => e.EnglishText)
                .HasColumnType("nvarchar(max)");

            modelBuilder.Entity<GeneralWorkshop>()
                .HasData(new GeneralWorkshop()
                {
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Id = 1,
                    EnglishTitle = "Test General Workshop Title 1",
                    EnglishDescription = "Test General Workshop Description 1",
                    ArabicTitle = "اختبار عنوان الورش العامة 1",
                    ArabicDescription = "اختبار وصف الورش العامة 1",
                    AgendaImage = null,
                    DateOfWorkShop = DateTime.UtcNow.AddDays(10),
                    DayName = DateTime.UtcNow.AddDays(10).DayOfWeek.ToString(),
                    RegistrationUrl = null,
                    Thumbnale = "https://backend.stg.award-shj.ae/UploadedFiles/photo_2024-03-25_10-21-14.jpg",
                    Time = "10:00 - 12:00",
                    Video = null
                }, new GeneralWorkshop()
                {
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Id = 2,
                    EnglishTitle = "Test General Workshop Title 2",
                    EnglishDescription = "Test General Workshop Description 2",
                    ArabicTitle = "اختبار عنوان الورش العامة 2",
                    ArabicDescription = "اختبار وصف الورش العامة 2",
                    AgendaImage = null,
                    DateOfWorkShop = DateTime.UtcNow.AddDays(20),
                    DayName = DateTime.UtcNow.AddDays(20).DayOfWeek.ToString(),
                    RegistrationUrl = null,
                    Thumbnale = "https://backend.stg.award-shj.ae/UploadedFiles/photo_2024-03-25_10-21-14.jpg",
                    Time = "2:00 - 3:00",
                    Video = null
                });

            modelBuilder.Entity<GeneralFAQCategory>()
                .HasData(new GeneralFAQCategory()
                {
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Id = 1,
                    ArabicName = "اختبار فئة أسئلة شائعة عامة 1",
                    EnglishName = "Test General FAQ Category 1"
                }, new GeneralFAQCategory()
                {
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Id = 2,
                    ArabicName = "اختبار فئة أسئلة شائعة عامة 2",
                    EnglishName = "Test General FAQ Category 2"
                });

            modelBuilder.Entity<GeneralFAQ>()
                .HasData(new GeneralFAQ()
                {
                    Id = 1,
                    ArabicAnswer = "اختبار جواب 1",
                    ArabicQuestion = "اختبار سؤال 1",
                    EnglishAnswer = "Test Answer 1",
                    EnglishQuestion = "Test Question 1",
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    GeneralFrequentlyAskedQuestionCategoryId = 1
                }, new GeneralFAQ()
                {
                    Id = 2,
                    ArabicAnswer = "اختبار جواب 2",
                    ArabicQuestion = "اختبار سؤال 2",
                    EnglishAnswer = "Test Answer 2",
                    EnglishQuestion = "Test Question 2",
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    GeneralFrequentlyAskedQuestionCategoryId = 1
                }, new GeneralFAQ()
                {
                    Id = 3,
                    ArabicAnswer = "اختبار جواب 3",
                    ArabicQuestion = "اختبار سؤال 3",
                    EnglishAnswer = "Test Answer 3",
                    EnglishQuestion = "Test Question 3",
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    GeneralFrequentlyAskedQuestionCategoryId = 2
                }, new GeneralFAQ()
                {
                    Id = 4,
                    ArabicAnswer = "اختبار جواب 4",
                    ArabicQuestion = "اختبار سؤال 4",
                    EnglishAnswer = "Test Answer 4",
                    EnglishQuestion = "Test Question 4",
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    GeneralFrequentlyAskedQuestionCategoryId = 2
                });
            modelBuilder.Entity<AttributeTableName>()
                .HasData(new AttributeTableName()
                {
                    Id = 1,
                    Name = "ProvidedForm",
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new AttributeTableName()
                {
                    Id = 2,
                    Name = "Coordinator",
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new AttributeTableName()
                {
                    Id = 3,
                    Name = "Arbitrator",
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                });

            modelBuilder.Entity<AttributeDataType>()
                .HasData(new AttributeDataType()
                {
                    Id = 1,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Name = "Text"
                }, new AttributeDataType()
                {
                    Id = 2,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Name = "Email"
                }, new AttributeDataType()
                {
                    Id = 3,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Name = "Image"
                }, new AttributeDataType()
                {
                    Id = 4,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Name = "File"
                }, new AttributeDataType()
                {
                    Id = 5,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Name = "Phone Number"
                }, new AttributeDataType()
                {
                    Id = 6,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Name = "Number"
                }, new AttributeDataType()
                {
                    Id = 7,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Name = "Date"
                }, new AttributeDataType()
                {
                    Id = 8,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Name = "List"
                }, new AttributeDataType()
                {
                    Id = 9,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Name = "Location"
                }, new AttributeDataType()
                {
                    Id = 10,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Name = "Emirates ID number"
                });

            modelBuilder.Entity<AttributeOperation>()
                .HasData(new AttributeOperation()
                {
                    Id = 1,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    OperationAsString = ">"
                }, new AttributeOperation()
                {
                    Id = 2,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    OperationAsString = ">="
                }, new AttributeOperation()
                {
                    Id = 3,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    OperationAsString = "<"
                }, new AttributeOperation()
                {
                    Id = 4,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    OperationAsString = "<="
                }, new AttributeOperation()
                {
                    Id = 5,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    OperationAsString = "="
                }, new AttributeOperation()
                {
                    Id = 6,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    OperationAsString = "!="
                }, new AttributeOperation()
                {
                    Id = 7,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    OperationAsString = "is Empty"
                }, new AttributeOperation()
                {
                    Id = 8,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    OperationAsString = "is not Empty"
                });

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

            modelBuilder.Entity<Agenda>()
                .HasData(new Agenda()
                {
                    CycleId = 1,
                    Id = 1,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    ArabicTitle = "اختبار عنوان جدول أعمال 1",
                    DateType = Domain.Constants.AgendaConstants.AgendaDateType.Date,
                    EndDate = DateTime.UtcNow.AddDays(10),
                    EnglishTitle = "Test Agenda Titile 1",
                    Icon = "https://backend.stg.award-shj.ae/UploadedFiles/cancel (1) (1).png",
                    StartDate = DateTime.UtcNow.AddDays(5),
                    Status = Domain.Constants.AgendaConstants.AgendaStatus.Previous
                }, new Agenda()
                {
                    CycleId = 1,
                    Id = 2,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    ArabicTitle = "اختبار عنوان جدول أعمال 2",
                    DateType = Domain.Constants.AgendaConstants.AgendaDateType.Full,
                    EndDate = DateTime.UtcNow.AddDays(15),
                    EnglishTitle = "Test Agenda Titile 2",
                    Icon = "https://backend.stg.award-shj.ae/UploadedFiles/cancel (1) (2).png",
                    StartDate = DateTime.UtcNow.AddDays(10),
                    Status = Domain.Constants.AgendaConstants.AgendaStatus.Active
                }, new Agenda()
                {
                    CycleId = 1,
                    Id = 3,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    ArabicTitle = "اختبار عنوان جدول أعمال 3",
                    DateType = Domain.Constants.AgendaConstants.AgendaDateType.YearMonth,
                    EndDate = DateTime.UtcNow.AddDays(20),
                    EnglishTitle = "Test Agenda Titile 3",
                    Icon = "https://backend.stg.award-shj.ae/UploadedFiles/cancel (1).png",
                    StartDate = DateTime.UtcNow.AddDays(15),
                    Status = Domain.Constants.AgendaConstants.AgendaStatus.Later
                }, new Agenda()
                {
                    CycleId = 1,
                    Id = 4,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    ArabicTitle = "اختبار عنوان جدول أعمال 4",
                    DateType = Domain.Constants.AgendaConstants.AgendaDateType.YearMonth,
                    EndDate = DateTime.UtcNow.AddDays(25),
                    EnglishTitle = "Test Agenda Titile 4",
                    Icon = "https://backend.stg.award-shj.ae/UploadedFiles/cancel (1).png",
                    StartDate = DateTime.UtcNow.AddDays(20),
                    Status = Domain.Constants.AgendaConstants.AgendaStatus.Later
                }, new Agenda()
                {
                    CycleId = 1,
                    Id = 5,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    ArabicTitle = "اختبار عنوان جدول أعمال 5",
                    DateType = Domain.Constants.AgendaConstants.AgendaDateType.YearMonth,
                    EndDate = DateTime.UtcNow.AddDays(30),
                    EnglishTitle = "Test Agenda Titile 5",
                    Icon = "https://backend.stg.award-shj.ae/UploadedFiles/cancel (1).png",
                    StartDate = DateTime.UtcNow.AddDays(25),
                    Status = Domain.Constants.AgendaConstants.AgendaStatus.Later
                });

            modelBuilder.Entity<TrainingWorkshop>()
                .HasData(new TrainingWorkshop()
                {
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Id = 1,
                    CategoryId = 2,
                    ArabicDescription = "اختبار وصف ورشة تدريبية 1",
                    ArabicTitle = "اختبار عنوان ورشة تدريبية 1",
                    EnglishDescription = "Test Training Workshop Description 1",
                    EnglishTitle = "Test Training Workshop Title 1",
                    Thumbnail = "https://backend.stg.award-shj.ae/UploadedFiles/photo_2024-03-25_10-21-14.jpg"
                }, new TrainingWorkshop()
                {
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Id = 2,
                    CategoryId = 2,
                    ArabicDescription = "اختبار وصف ورشة تدريبية 2",
                    ArabicTitle = "اختبار عنوان ورشة تدريبية 2",
                    EnglishDescription = "Test Training Workshop Description 2",
                    EnglishTitle = "Test Training Workshop Title 2",
                    Thumbnail = "https://backend.stg.award-shj.ae/UploadedFiles/photo_2024-03-25_10-21-14.jpg"
                });

            modelBuilder.Entity<Coordinator>()
                .HasData(new Coordinator()
                {
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Id = 10,
                    ArabicName = "منسق 1",
                    EducationType = EducationType.Government,
                    Email = "Coordinator@Coordinator.com",
                    Emirates = Emirates.Sharjah,
                    EnglishName = "Coordinator 1",
                    PersonalPhoto = "https://backend.stg.award-shj.ae/UploadedFiles/02ef2561-b108-4b12-8a3f-6734b4e0345f.jpg",
                    PhoneNumber = "0993521579"
                }, new Coordinator()
                {
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Id = 11,
                    ArabicName = "منسق 2",
                    EducationType = EducationType.Government,
                    Email = "Coordinator2@Coordinator2.com",
                    Emirates = Emirates.Dubai,
                    EnglishName = "Coordinator 2",
                    PersonalPhoto = "https://backend.stg.award-shj.ae/UploadedFiles/e6258b6f-5ca5-4168-bb7c-fe1f24a6e553.jpg",
                    PhoneNumber = "0993521579"
                }, new Coordinator()
                {
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Id = 12,
                    ArabicName = "منسق 3",
                    EducationType = EducationType.Private,
                    Email = "Coordinator3@Coordinator3.com",
                    Emirates = Emirates.Ajman,
                    EnglishName = "Coordinator 3",
                    PersonalPhoto = "https://backend.stg.award-shj.ae/UploadedFiles/eecad556-2d56-4010-b10a-780f7500f693.png",
                    PhoneNumber = "0993521579"
                }, new Coordinator()
                {
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Id = 13,
                    ArabicName = "منسق 4",
                    EducationType = EducationType.Private,
                    Email = "Coordinator4@Coordinator4.com",
                    Emirates = Emirates.Dubai,
                    EnglishName = "Coordinator 4",
                    PersonalPhoto = "https://backend.stg.award-shj.ae/UploadedFiles/eecad556-2d56-4010-b10a-780f7500f693.png",
                    PhoneNumber = "0993521579"
                });

            modelBuilder.Entity<User>()
                .HasData(new User()
                {
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Id = 10,
                    Email = "Coordinator@Coordinator.com",
                    PhoneNumber = "0993521579",
                    Password = "vO2sa5VimvnqRAqRbqHARyr9kG2rrXN6brfIXLU4ikM=",
                    EnglishName = "Coordinator 1",
                    ArabicName = "منسق 1",
                    ConfirmationCodeForResetPassword = null,
                    ConfirmationCodeForSignUp = null,
                    isValidAccount = true,
                    Gender = Gender.Male,
                    ImageURL = null
                }, new User()
                {
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Id = 11,
                    Email = "Coordinator2@Coordinator2.com",
                    PhoneNumber = "0993521579",
                    Password = "vO2sa5VimvnqRAqRbqHARyr9kG2rrXN6brfIXLU4ikM=",
                    EnglishName = "Coordinator 2",
                    ArabicName = "منسق 2",
                    ConfirmationCodeForResetPassword = null,
                    ConfirmationCodeForSignUp = null,
                    isValidAccount = true,
                    Gender = Gender.Male,
                    ImageURL = null
                }, new User()
                {
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Id = 12,
                    Email = "Coordinator3@Coordinator3.com",
                    PhoneNumber = "0993521579",
                    Password = "vO2sa5VimvnqRAqRbqHARyr9kG2rrXN6brfIXLU4ikM=",
                    EnglishName = "Coordinator 3",
                    ArabicName = "منسق 3",
                    ConfirmationCodeForResetPassword = null,
                    ConfirmationCodeForSignUp = null,
                    isValidAccount = true,
                    Gender = Gender.Male,
                    ImageURL = null
                }, new User()
                {
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Id = 13,
                    Email = "Coordinator4@Coordinator4.com",
                    PhoneNumber = "0993521579",
                    Password = "vO2sa5VimvnqRAqRbqHARyr9kG2rrXN6brfIXLU4ikM=",
                    EnglishName = "Coordinator 4",
                    ArabicName = "منسق 4",
                    ConfirmationCodeForResetPassword = null,
                    ConfirmationCodeForSignUp = null,
                    isValidAccount = true,
                    Gender = Gender.Male,
                    ImageURL = null
                });

            modelBuilder.Entity<EducationalEntity>()
                .HasData(new EducationalEntity()
                {
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Id = 1,
                    EnglishName = "Educational Entity 1",
                    ArabicName = "جهة تعليمية 1"
                }, new EducationalEntity()
                {
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Id = 2,
                    EnglishName = "Educational Entity 2",
                    ArabicName = "جهة تعليمية 2"
                });

            modelBuilder.Entity<EducationalInstitution>()
                .HasData(new EducationalInstitution()
                {
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Id = 1,
                    ArabicName = "مؤسسة تعليمية 1",
                    EducationalEntityId = 1,
                    EnglishName = "Educational Entity 1"
                }, new EducationalInstitution()
                {
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Id = 2,
                    ArabicName = "مؤسسة تعليمية 2",
                    EducationalEntityId = 2,
                    EnglishName = "Educational Entity 2"
                });

            modelBuilder.Entity<EduEntitiesCoordinator>()
                .HasData(new EduEntitiesCoordinator()
                {
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Id = 1,
                    RelatedDate = DateTime.Now,
                    EducationalEntityId = 1,
                    CoordinatorId = 10
                }, new EduEntitiesCoordinator()
                {
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Id = 2,
                    RelatedDate = DateTime.Now,
                    EducationalEntityId = 1,
                    CoordinatorId = 11
                }, new EduEntitiesCoordinator()
                {
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Id = 3,
                    RelatedDate = DateTime.Now,
                    EducationalEntityId = 2,
                    CoordinatorId = 12
                }, new EduEntitiesCoordinator()
                {
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Id = 4,
                    RelatedDate = DateTime.Now,
                    EducationalEntityId = 2,
                    CoordinatorId = 13
                });

            modelBuilder.Entity<EduInstitutionCoordinator>()
                .HasData(new EduInstitutionCoordinator()
                {
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Id = 1,
                    EducationalInstitutionId = 1,
                    CoordinatorId = 10
                }, new EduInstitutionCoordinator()
                {
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Id = 2,
                    EducationalInstitutionId = 1,
                    CoordinatorId = 11
                }, new EduInstitutionCoordinator()
                {
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Id = 3,
                    EducationalInstitutionId = 2,
                    CoordinatorId = 12
                }, new EduInstitutionCoordinator()
                {
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Id = 4,
                    EducationalInstitutionId = 2,
                    CoordinatorId = 13
                });

            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    Id = 1,
                    EnglishName = "Admin",
                    ArabicName = "ادمن"
                });
            modelBuilder.Entity<Role>().HasData(
            new Role
            {
                Id = 2,
                EnglishName = "Subscriber",
                ArabicName = "مشترك"
            });
            modelBuilder.Entity<Role>().HasData(
            new Role
            {
                Id = 3,
                EnglishName = "Manager",
                ArabicName = "مدير"
            });
            modelBuilder.Entity<Role>().HasData(
            new Role
            {
                Id = 4,
                EnglishName = "User",
                ArabicName = "مستخدم"
            });
            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    Id = 5,
                    EnglishName = "Coordinator",
                    ArabicName = "منسق"
                }, new Role
                {
                    Id = 6,
                    EnglishName = "Arbitrator",
                    ArabicName = "محكم"
                });

            modelBuilder.Entity<User>()
                .HasData(new User()
                {
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicName = "ادمن 123",
                    Email = "ahmad.a.ahmad.100011@gmail.com",
                    PhoneNumber = "0993521579",
                    EnglishName = "Admin 123",
                    Gender = Gender.Male,
                    Password = "vO2sa5VimvnqRAqRbqHARyr9kG2rrXN6brfIXLU4ikM=",
                    Id = 1,
                    ConfirmationCodeForResetPassword = null,
                    ConfirmationCodeForSignUp = null,
                    isValidAccount = true,
                    ImageURL = null
                }, new User()
                {
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicName = "ادمن 123 #",
                    Email = "Ahmad@Ahmad.com",
                    PhoneNumber = "0993521579",
                    EnglishName = "Admin 123 #",
                    Gender = Gender.Male,
                    Password = "vO2sa5VimvnqRAqRbqHARyr9kG2rrXN6brfIXLU4ikM=",
                    Id = 2,
                    ConfirmationCodeForResetPassword = null,
                    ConfirmationCodeForSignUp = null,
                    isValidAccount = true,
                    ImageURL = null
                }, new User()
                {
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicName = "ادمن 123 ##",
                    Email = "Ahmad2@Ahmad2.com",
                    PhoneNumber = "0993521579",
                    EnglishName = "Admin 123 ##",
                    Gender = Gender.Male,
                    Password = "vO2sa5VimvnqRAqRbqHARyr9kG2rrXN6brfIXLU4ikM=",
                    Id = 3,
                    ConfirmationCodeForResetPassword = null,
                    ConfirmationCodeForSignUp = null,
                    isValidAccount = true,
                    ImageURL = null
                }, new User()
                {
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicName = "ادمن 123 ##@",
                    Email = "Ahmad3@Ahmad3.com",
                    PhoneNumber = "0993521579",
                    EnglishName = "Admin 123 ##@",
                    Gender = Gender.Male,
                    Password = "vO2sa5VimvnqRAqRbqHARyr9kG2rrXN6brfIXLU4ikM=",
                    Id = 4,
                    ConfirmationCodeForResetPassword = null,
                    ConfirmationCodeForSignUp = null,
                    isValidAccount = true,
                    ImageURL = null
                }, new User()
                {
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicName = "ادمن 123 ##@@",
                    Email = "Ahmad4@Ahmad4.com",
                    PhoneNumber = "0993521579",
                    EnglishName = "Admin 123 ##@@",
                    Gender = Gender.Male,
                    Password = "vO2sa5VimvnqRAqRbqHARyr9kG2rrXN6brfIXLU4ikM=",
                    Id = 5,
                    ConfirmationCodeForResetPassword = null,
                    ConfirmationCodeForSignUp = null,
                    isValidAccount = true,
                    ImageURL = null
                }, new User()
                {
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicName = "تامر",
                    Email = "tamer@gmail.com",
                    PhoneNumber = "0993521579",
                    EnglishName = "Tamer",
                    Gender = Gender.Male,
                    Password = "vO2sa5VimvnqRAqRbqHARyr9kG2rrXN6brfIXLU4ikM=",
                    Id = 6,
                    ConfirmationCodeForResetPassword = null,
                    ConfirmationCodeForSignUp = null,
                    isValidAccount = true,
                    ImageURL = null,
                    SubscriberId = "ABC123"
                });

            modelBuilder.Entity<UserRole>()
                .HasData(new UserRole()
                {
                    Id = 1,
                    UserId = 10,
                    RoleId = 5
                }, new UserRole()
                {
                    Id = 2,
                    UserId = 11,
                    RoleId = 5
                }, new UserRole()
                {
                    Id = 3,
                    UserId = 12,
                    RoleId = 5
                }, new UserRole()
                {
                    Id = 4,
                    UserId = 13,
                    RoleId = 5
                }, new UserRole()
                {
                    Id = 5,
                    UserId = 1,
                    RoleId = 1
                }, new UserRole()
                {
                    Id = 6,
                    UserId = 2,
                    RoleId = 1
                }, new UserRole()
                {
                    Id = 7,
                    UserId = 3,
                    RoleId = 1
                }, new UserRole()
                {
                    Id = 8,
                    UserId = 4,
                    RoleId = 1
                }, new UserRole()
                {
                    Id = 9,
                    UserId = 5,
                    RoleId = 1
                }, new UserRole()
                {
                    Id = 10,
                    UserId = 6,
                    RoleId = 2
                });

            modelBuilder.Entity<EducationalClass>()
                .HasData(new EducationalClass()
                {
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Id = 1,
                    ArabicName = "الصف الأول",
                    EnglishName = "First class"
                }, new EducationalClass()
                {
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Id = 2,
                    ArabicName = "الصف الثاني",
                    EnglishName = "Second class"
                }, new EducationalClass()
                {
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Id = 3,
                    ArabicName = "الصف الثالث",
                    EnglishName = "Third class"
                }, new EducationalClass()
                {
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Id = 4,
                    ArabicName = "الصف الرابع",
                    EnglishName = "Forth class"
                }, new EducationalClass()
                {
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Id = 5,
                    ArabicName = "الصف الخامس",
                    EnglishName = "Fifth class"
                }, new EducationalClass()
                {
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Id = 6,
                    ArabicName = "الصف السادس",
                    EnglishName = "Sixth class"
                }, new EducationalClass()
                {
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Id = 7,
                    ArabicName = "الصف السابع",
                    EnglishName = "Seventh class"
                }, new EducationalClass()
                {
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Id = 8,
                    ArabicName = "الصف الثامن",
                    EnglishName = "Eighth class"
                }, new EducationalClass()
                {
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Id = 9,
                    ArabicName = "الصف التاسع",
                    EnglishName = "Ninth class"
                }, new EducationalClass()
                {
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Id = 10,
                    ArabicName = "الصف العاشر",
                    EnglishName = "Tenth class"
                }, new EducationalClass()
                {
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Id = 11,
                    ArabicName = "الصف الحادي عشر",
                    EnglishName = "Eleventh class"
                }, new EducationalClass()
                {
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Id = 12,
                    ArabicName = "الصف الثاني عشر",
                    EnglishName = "Twelfth class"
                });

            modelBuilder.Entity<RelatedAccountRequest>()
                .HasData(new RelatedAccountRequest()
                {
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Id = 1,
                    ReceiverId = 1,
                    SenderId = 2
                }, new RelatedAccountRequest()
                {
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Id = 2,
                    ReceiverId = 1,
                    SenderId = 3
                });

            modelBuilder.Entity<RelatedAccount>()
                .HasData(new RelatedAccount()
                {
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Id = 1,
                    User1Id = 1,
                    User2Id = 4,
                }, new RelatedAccount()
                {
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Id = 2,
                    User1Id = 1,
                    User2Id = 5,
                });

            modelBuilder.Entity<DynamicAttributeSection>()
                .HasData(new DynamicAttributeSection()
                {
                    ArabicName = "اختبار اسم 1",
                    EnglishName = "Test Name 1",
                    isDeleted = false,
                    AttributeTableNameId = 1,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    RecordIdOnRelation = 2,
                    Id = 1,
                    OrderId = 1
                });

            modelBuilder.Entity<DynamicAttribute>()
                .HasData(new DynamicAttribute()
                {
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Id = 1,
                    OrderId = 1,
                    ArabicLabel = "اختبار نص 1",
                    ArabicTitle = "اختبار نص 1",
                    ArabicPlaceHolder = "اختبار نص 1",
                    AttributeDataTypeId = 1,
                    DynamicAttributeSectionId = 1,
                    EnglishLabel = "Test Text 1",
                    EnglishTitle = "Test Text 1",
                    EnglishPlaceHolder = "Test Text 1",
                    IsRequired = true,
                    IsUnique = true,
                    MaxSizeInKB = null,
                    Status = Domain.Constants.DynamicAttribute.DynamicAttributeStatus.Active,
                    LinkedToAnotherAttribute = false
                }, new DynamicAttribute()
                {
                    Id = 2,
                    OrderId = 2,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicLabel = "اختبار ايميل 1",
                    ArabicTitle = "اختبار ايميل 1",
                    ArabicPlaceHolder = "اختبار ايميل 1",
                    AttributeDataTypeId = 2,
                    DynamicAttributeSectionId = 1,
                    EnglishLabel = "Test Email 1",
                    EnglishTitle = "Test Email 1",
                    EnglishPlaceHolder = "Test Email 1",
                    IsRequired = true,
                    IsUnique = true,
                    MaxSizeInKB = null,
                    Status = Domain.Constants.DynamicAttribute.DynamicAttributeStatus.Active,
                    LinkedToAnotherAttribute = false
                }, new DynamicAttribute()
                {
                    Id = 3,
                    OrderId = 3,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicLabel = "اختبار صورة 1",
                    ArabicTitle = "اختبار صورة 1",
                    ArabicPlaceHolder = "اختبار صورة 1",
                    AttributeDataTypeId = 3,
                    DynamicAttributeSectionId = 1,
                    EnglishLabel = "Test Image 1",
                    EnglishTitle = "Test Image 1",
                    EnglishPlaceHolder = "Test Image 1",
                    IsRequired = false,
                    IsUnique = false,
                    MaxSizeInKB = 1028,
                    Status = Domain.Constants.DynamicAttribute.DynamicAttributeStatus.Active,
                    LinkedToAnotherAttribute = false
                }, new DynamicAttribute()
                {
                    Id = 4,
                    OrderId = 4,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicTitle = "اختبار ملف 1",
                    ArabicLabel = "اختبار ملف 1",
                    ArabicPlaceHolder = "اختبار ملف 1",
                    AttributeDataTypeId = 4,
                    DynamicAttributeSectionId = 1,
                    EnglishLabel = "Test File 1",
                    EnglishTitle = "Test File 1",
                    EnglishPlaceHolder = "Test File 1",
                    IsRequired = false,
                    IsUnique = false,
                    MaxSizeInKB = 4112,
                    Status = Domain.Constants.DynamicAttribute.DynamicAttributeStatus.Active,
                    LinkedToAnotherAttribute = false
                }, new DynamicAttribute()
                {
                    Id = 5,
                    OrderId = 5,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicLabel = "اختبار رقم متحرك 1",
                    ArabicTitle = "اختبار رقم متحرك 1",
                    ArabicPlaceHolder = "اختبار رقم متحرك 1",
                    AttributeDataTypeId = 5,
                    DynamicAttributeSectionId = 1,
                    EnglishLabel = "Test Phone Number 1",
                    EnglishTitle = "Test Phone Number 1",
                    EnglishPlaceHolder = "Test Phone Number 1",
                    IsRequired = false,
                    IsUnique = false,
                    MaxSizeInKB = null,
                    Status = Domain.Constants.DynamicAttribute.DynamicAttributeStatus.Active,
                    LinkedToAnotherAttribute = false
                }, new DynamicAttribute()
                {
                    Id = 6,
                    OrderId = 6,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicLabel = "اختبار رقم 1",
                    ArabicTitle = "اختبار رقم 1",
                    ArabicPlaceHolder = "اختبار رقم 1",
                    AttributeDataTypeId = 6,
                    DynamicAttributeSectionId = 1,
                    EnglishLabel = "Test Number 1",
                    EnglishTitle = "Test Number 1",
                    EnglishPlaceHolder = "Test Number 1",
                    IsRequired = false,
                    IsUnique = false,
                    MaxSizeInKB = null,
                    Status = Domain.Constants.DynamicAttribute.DynamicAttributeStatus.Active,
                    LinkedToAnotherAttribute = false
                }, new DynamicAttribute()
                {
                    Id = 7,
                    OrderId = 7,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicLabel = "اختبار تاريخ 1",
                    ArabicTitle = "اختبار تاريخ 1",
                    ArabicPlaceHolder = "اختبار تاريخ 1",
                    AttributeDataTypeId = 7,
                    DynamicAttributeSectionId = 1,
                    EnglishLabel = "Test Date 1",
                    EnglishTitle = "Test Date 1",
                    EnglishPlaceHolder = "Test Date 1",
                    IsRequired = false,
                    IsUnique = false,
                    MaxSizeInKB = null,
                    Status = Domain.Constants.DynamicAttribute.DynamicAttributeStatus.Active,
                    LinkedToAnotherAttribute = false
                }, new DynamicAttribute()
                {
                    Id = 8,
                    OrderId = 8,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicLabel = "اختبار قائمة 1",
                    ArabicTitle = "اختبار قائمة 1",
                    ArabicPlaceHolder = "اختبار قائمة 1",
                    AttributeDataTypeId = 8,
                    DynamicAttributeSectionId = 1,
                    EnglishTitle = "Test List 1",
                    EnglishLabel = "Test List 1",
                    EnglishPlaceHolder = "Test List 1",
                    IsRequired = false,
                    IsUnique = false,
                    MaxSizeInKB = null,
                    Status = Domain.Constants.DynamicAttribute.DynamicAttributeStatus.Active,
                    LinkedToAnotherAttribute = false
                });
            modelBuilder.Entity<DynamicAttributeListValue>()
                .HasData(new DynamicAttributeListValue()
                {
                    Id = 1,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DynamicAttributeId = 8,
                    Value = "Test Value 1"
                }, new DynamicAttributeListValue()
                {
                    Id = 2,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DynamicAttributeId = 8,
                    Value = "Test Value 2"
                }, new DynamicAttributeListValue()
                {
                    Id = 3,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DynamicAttributeId = 8,
                    Value = "Test Value 3"
                }, new DynamicAttributeListValue()
                {
                    Id = 4,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DynamicAttributeId = 8,
                    Value = "Test Value 4"
                }, new DynamicAttributeListValue()
                {
                    Id = 5,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DynamicAttributeId = 8,
                    Value = "Test Value 5"
                });

            ////////////////////////////////////////
            /// Profissional Data Seeder..
            ////////////////////////////////////////
            #region Instructions
            modelBuilder.Entity<Instruction>()
                .HasData(new Instruction()
                {
                    Id = 1,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "events_index",
                    Title = "جدول الفعاليات"
                }, new Instruction()
                {
                    Id = 2,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "event_attendees_index",
                    Title = "جدول حضور الفعاليات"
                }, new Instruction()
                {
                    Id = 3,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "arbitrators_index",
                    Title = "جدول المًحكّمين"
                }, new Instruction()
                {
                    Id = 4,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "coordinators_index",
                    Title = "جدول المًنسقين"
                }, new Instruction()
                {
                    Id = 5,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "arbitrator_form",
                    Title = "إضافة أو تعديل معلومات مًحكّم"
                }, new Instruction()
                {
                    Id = 6,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "coordinator_form",
                    Title = "إضافة أو تعديل معلومات مًنسق"
                }, new Instruction()
                {
                    Id = 7,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "class_arbitrators_index",
                    Title = "جدول مًحكّمين الصف"
                }, new Instruction()
                {
                    Id = 8,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "class_form",
                    Title = "إضافة أو تعديل معلومات صف"
                }, new Instruction()
                {
                    Id = 9,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "classes_index",
                    Title = "جدول الصفوف"
                }, new Instruction()
                {
                    Id = 10,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "cycle_form",
                    Title = "إضافة أو تعديل معلومات دورة"
                }, new Instruction()
                {
                    Id = 11,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "cycles_index",
                    Title = "جدول الدورات"
                }, new Instruction()
                {
                    Id = 12,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "Agendas_index",
                    Title = "جدول الأجندة"
                }, new Instruction()
                {
                    Id = 13,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "categories_index",
                    Title = "جدول الفئات الرئيسية مع الفئات الفرعية التابعة له"
                }, new Instruction()
                {
                    Id = 14,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "subcategory_form",
                    Title = "إضافة أو تعديل معلومات فئة فرعية"
                }, new Instruction()
                {
                    Id = 15,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "cycle_specifications_form",
                    Title = "إضافة أو تعديل محددات الدورة"
                }, new Instruction()
                {
                    Id = 16,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "explanatory_guide",
                    Title = "عرض الدليل التفسيري مع الإجراءات الممكنة"
                }, new Instruction()
                {
                    Id = 17,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "faq_index",
                    Title = "جدول الأسئلة الشائعة"
                }, new Instruction()
                {
                    Id = 18,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "cycle_conditions_index",
                    Title = "جدول الشروط العامة للدورة"
                }, new Instruction()
                {
                    Id = 19,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "data_import",
                    Title = "صفحة استيراد المعلومات"
                }, new Instruction()
                {
                    Id = 20,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "subcategory_conditions_index",
                    Title = "جدول شروط الفئة الفرعية"
                }, new Instruction()
                {
                    Id = 21,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "subcategory_fields_index",
                    Title = "جدول حقول الفئة الفرعية"
                }, new Instruction()
                {
                    Id = 22,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "subcategory_workshops_index",
                    Title = "جدول الورشات التدريبية للفئة الفرعية"
                }, new Instruction()
                {
                    Id = 23,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "educational_entities_index",
                    Title = "جدول الجهات التعليمية"
                }, new Instruction()
                {
                    Id = 24,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "educational_entities_form",
                    Title = "إضافة أو تعديل جهة تعليمية مع عرض المؤسسات التابعة في حال التعديل"
                }, new Instruction()
                {
                    Id = 25,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "educational_institution_form",
                    Title = "إضافة أو تعديل مؤسسة تعليمية"
                }, new Instruction()
                {
                    Id = 26,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "home",
                    Title = "الصفحة الرئيسية"
                }, new Instruction()
                {
                    Id = 27,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "instructions_index",
                    Title = "جدول الإرشادات"
                }, new Instruction()
                {
                    Id = 28,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "instruction_form",
                    Title = "صفحة تعديل إرشاد"
                }, new Instruction()
                {
                    Id = 29,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "notifications_index",
                    Title = "جدول الإشعارات"
                }, new Instruction()
                {
                    Id = 30,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "notifications_form",
                    Title = "إضافة إشعار"
                }, new Instruction()
                {
                    Id = 31,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "roles_index",
                    Title = "جدول الأدوار"
                }, new Instruction()
                {
                    Id = 32,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "role_form",
                    Title = "إضافة أو تعديل دور"
                }, new Instruction()
                {
                    Id = 33,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "subscribers_accounts_index",
                    Title = "جدول حسابات المشتركين"
                }, new Instruction()
                {
                    Id = 34,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "users_index",
                    Title = "جدول المستخدمين"
                }, new Instruction()
                {
                    Id = 35,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "user_form",
                    Title = "إضافة أو تعديل معلومات مستخدم"
                }, new Instruction()
                {
                    Id = 36,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "notifications_templates_index",
                    Title = "جدول نماذج الإشعارات"
                }, new Instruction()
                {
                    Id = 37,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "notification_template_form",
                    Title = "إضافة أو تعديل نموذج إشعارات"
                }, new Instruction()
                {
                    Id = 38,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "contact_us_index",
                    Title = "جدول طلبات التواصل"
                }, new Instruction()
                {
                    Id = 39,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "contact_us_details",
                    Title = "تفاصيل طلب تواصل"
                }, new Instruction()
                {
                    Id = 40,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "committees_index",
                    Title = "جدول اللجان"
                }, new Instruction()
                {
                    Id = 41,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "committee_form",
                    Title = "إضافة أو تعديل لجنة"
                }, new Instruction()
                {
                    Id = 42,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "meetings_index",
                    Title = "جدول الاجتماعات"
                }, new Instruction()
                {
                    Id = 43,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "meeting_form",
                    Title = "إضافة اجتماع"
                }, new Instruction()
                {
                    Id = 44,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "circulars_index",
                    Title = "جدول التعاميم"
                }, new Instruction()
                {
                    Id = 45,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "circular_form",
                    Title = "إضافة أو تعديل تعميم"
                }, new Instruction()
                {
                    Id = 46,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "general_workshops_index",
                    Title = "جدول الورشات التدريبية العامة"
                }, new Instruction()
                {
                    Id = 47,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "general_workshops_form",
                    Title = "إضافة أو تعديل ورشة تدريبية عامة"
                }, new Instruction()
                {
                    Id = 48,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "app_versions_index",
                    Title = "جدول نسخ التطبيق"
                }, new Instruction()
                {
                    Id = 49,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "app_version_form",
                    Title = "إضافة نسخة تطبيق"
                }, new Instruction()
                {
                    Id = 50,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "subscribers_profiles_index",
                    Title = "جدول برفايلات المستخدمين"
                }, new Instruction()
                {
                    Id = 51,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    Content = null,
                    Slug = "subscriber_profile",
                    Title = "بروفايل مستخدم"
                });
            #endregion
            #region Cycle
            modelBuilder.Entity<Cycle>()
                .HasData(new Cycle()
                {
                    Id = 1,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    CycleNumber = 31,
                    Year = "2024 - 2025",
                    ArabicName = "جائزة الشارقة للتفوق والتميز التربوي",
                    EnglishName = "Sharjah Award for Educational Excellence",
                    Status = Domain.Constants.Common.Status.Active,
                    RegistrationPortalOpeningDate = new DateTime(2025, 1, 1),
                    RegistrationPortalClosingDate = new DateTime(2025, 5, 1),
                    SubscriberPortalClosingDate = null,
                    InitialArbitrationStartDate = null,
                    InitialArbitrationEndDate = null,
                    FinalArbitrationStartDate = null,
                    FinalArbitrationEndDate = null,
                    IndividualCategoryNumber = 1,
                    TheUpperLimitForObtainingInformation = 10,
                    MarginOfDifferenceBetweenArbitrators = 10,
                    GroupCategoryNumber = 1
                });
            #endregion
            #region Category
            modelBuilder.Entity<Category>()
                .HasData(new Category()
                {
                    Id = 1,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicName = "جائزة جوهرة اللغة العربية",
                    EnglishName = "The \"Gem\" of the Arabic Language",
                    ArabicDescription = string.Empty,
                    EnglishDescription = string.Empty,
                    Icon = "https://award-shj.ae/media/cb2igx0d/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%A7%D9%84%D8%AC%D9%88%D9%87%D8%B1%D8%A9.png",
                    CategoryClassification = Domain.Constants.CategoryConstants.CategoryClassification.Individual,
                    FinalArbitrationQualificationMark = null,
                    WinningScore = null,
                    MinimumAmountToParticipateInTheAward = null,
                    MinimumAmountToObtainACertificateOfParticipation = null,
                    ExpectedNumberOfWinners = null,
                    RelatedToClasses = null,
                    ParentId = null,
                    CycleId = 1
                }, new Category()
                {
                    Id = 2,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicName = "جائزة جوهرة اللغة العربية",
                    EnglishName = "The \"Gem\" of the Arabic Language",
                    ArabicDescription = "جائزة رائدة استثنائيّة تتسابق فيها المدارس الحكومية والخاصة في رعاية اللغة العربية، وتمكين المجتمع المدرسيّ (طالب، معلم، ولي الأمر...) من امتلاك مهارات اللغة العربية وتوظيفها في العلم والحياة.",
                    EnglishDescription = "It is an exceptional pioneering award where both public and private schools compete to promote the Arabic language, empower the school community students, teachers, and parents and equip them with the Arabic language skills that they can utilize in life and knowledge acquisition.",
                    Icon = "https://award-shj.ae/media/cb2igx0d/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%A7%D9%84%D8%AC%D9%88%D9%87%D8%B1%D8%A9.png",
                    CategoryClassification = Domain.Constants.CategoryConstants.CategoryClassification.Individual,
                    FinalArbitrationQualificationMark = 100,
                    WinningScore = 90,
                    MinimumAmountToParticipateInTheAward = 60,
                    MinimumAmountToObtainACertificateOfParticipation = 80,
                    ExpectedNumberOfWinners = 4,
                    RelatedToClasses = false,
                    ParentId = 1,
                    CycleId = 1
                }, new Category()
                {
                    Id = 3,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicName = "فئة الأفراد المتميزين",
                    EnglishName = "Distinguished Individuals Category",
                    ArabicDescription = string.Empty,
                    EnglishDescription = string.Empty,
                    Icon = "https://award-shj.ae/media/iqzhrizm/%D9%81%D8%A6%D8%A9-%D8%A7%D9%84%D9%82%D8%A7%D8%A6%D8%AF-%D8%A7%D9%84%D8%AA%D8%B1%D8%A8%D9%88%D9%8A-%D8%A7%D9%84%D9%85%D8%AA%D9%85%D9%8A%D8%B2.png",
                    CategoryClassification = Domain.Constants.CategoryConstants.CategoryClassification.Individual,
                    FinalArbitrationQualificationMark = null,
                    WinningScore = null,
                    MinimumAmountToParticipateInTheAward = null,
                    MinimumAmountToObtainACertificateOfParticipation = null,
                    ExpectedNumberOfWinners = null,
                    RelatedToClasses = false,
                    ParentId = null,
                    CycleId = 1
                }, new Category()
                {
                    Id = 4,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicName = "فئة القائد التربوي المتميز",
                    EnglishName = "Distinguished Educational Leader Category",
                    ArabicDescription = "تشمل جميع القيادات التّربويّة في القطاعين الحكوميّ والخاص من فئة القيادات العليا والقيادات الوسطى.\r\n\r\nتشمل القيادة العليا (مدير مدرسة).\r\nتشمل القيادة الوسطى (مساعد مدير أكاديمي، رئيس وحدة الشؤون الأكاديمية، رئيس وحدة شؤون الطلبة، رئيس وحدة الخدمات).",
                    EnglishDescription = "This category consists of all educational leaders in the public and private sectors including senior leaders and middle leaders.\r\n\r\n- Senior leadership includes school principal.\r\n\r\n- Middle leadership includes Assistant Academic Principal, Head of Academic Affairs Unit, Head of Student Affairs Unit, Head of Services Unit.",
                    Icon = "https://award-shj.ae/media/iqzhrizm/%D9%81%D8%A6%D8%A9-%D8%A7%D9%84%D9%82%D8%A7%D8%A6%D8%AF-%D8%A7%D9%84%D8%AA%D8%B1%D8%A8%D9%88%D9%8A-%D8%A7%D9%84%D9%85%D8%AA%D9%85%D9%8A%D8%B2.png",
                    CategoryClassification = Domain.Constants.CategoryConstants.CategoryClassification.Individual,
                    FinalArbitrationQualificationMark = 100,
                    WinningScore = 90,
                    MinimumAmountToParticipateInTheAward = 60,
                    MinimumAmountToObtainACertificateOfParticipation = 80,
                    ExpectedNumberOfWinners = 3,
                    RelatedToClasses = false,
                    ParentId = 3,
                    CycleId = 1
                }, new Category()
                {
                    Id = 5,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicName = "فئة المعلم المتميز",
                    EnglishName = "Distinguished Teacher Category",
                    ArabicDescription = "المعلم هو المحرك الأساسي لعملية التعليم والتعلم، فبمقدار جودة عطائه ترتقي العملية التعليمية، وخاصة مع المتغيرات الحديثة التي تقتضي من المعلم مواكبتها، لينتج التعليم ثماره المرجوة، ويمتزج بعصر المعرفة والثورات التكنولوجية، ويصبح جزءاً فاعلًا في الحياة والاقتصاد، وتهتم الجائزة بهذه الفئة وتأهيلها ليثبت المعلم المشارك إنجازه وقيادته الفاعلة، وتطوّره المهنيّ، ويبرهن على إبداعه وابتكاراته الوظيفيّة ومسؤولياته المجتمعيّة، ويحق لجميع المعلمين من مرحلة رياض الأطفال إلى الصف الثاني عشر ومن ذوي التّخصصات المختلفة في التعليم الحكومي والخاص والفنّي والتكنولوجي الترشح لهذه الفئة.",
                    EnglishDescription = "The teacher is the main guide of the teaching and learning process as the quality of his/her input elevates the educational process, especially with the new changes and the technological revolution that require teachers to keep up with in order to achieve the desired results in life and economy. The Sharjah Award for Educational Excellence acknowledges this category and requires participant teachers to underscore their distinguished performance, effective leadership, professional development, creativity and innovation in the job, and social responsibility. All teachers from kindergarten to the twelfth grade with various specializations in public, private, and applied technology schools are eligible to nominate for this category.",
                    Icon = "https://award-shj.ae/media/5kbhcktn/%D9%81%D8%A6%D8%A9-%D8%A7%D9%84%D9%85%D8%B9%D9%84%D9%85-%D8%A7%D9%84%D9%85%D8%AA%D9%85%D9%8A%D8%B2.png",
                    CategoryClassification = Domain.Constants.CategoryConstants.CategoryClassification.Individual,
                    FinalArbitrationQualificationMark = 100,
                    WinningScore = 90,
                    MinimumAmountToParticipateInTheAward = 60,
                    MinimumAmountToObtainACertificateOfParticipation = 80,
                    ExpectedNumberOfWinners = 4,
                    RelatedToClasses = false,
                    ParentId = 3,
                    CycleId = 1
                }, new Category()
                {
                    Id = 6,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicName = "فئة المؤسسات المتميزة",
                    EnglishName = "Distinguished Institutions Category",
                    ArabicDescription = string.Empty,
                    EnglishDescription = string.Empty,
                    Icon = "https://award-shj.ae/media/ceihv5g3/%D9%81%D8%A6%D8%A9-%D8%A7%D9%84%D9%85%D8%A4%D8%B3%D8%B3%D8%A7%D8%AA-%D8%A7%D9%84%D8%AA%D8%B9%D9%84%D9%8A%D9%85%D9%8A%D8%A9-%D8%A7%D9%84%D8%AD%D8%B6%D8%A7%D9%86%D8%A9-%D8%A7%D9%84%D9%85%D8%AA%D9%85%D9%8A%D8%B2%D8%A9.png",
                    CategoryClassification = Domain.Constants.CategoryConstants.CategoryClassification.Group,
                    FinalArbitrationQualificationMark = null,
                    WinningScore = null,
                    MinimumAmountToParticipateInTheAward = null,
                    MinimumAmountToObtainACertificateOfParticipation = null,
                    ExpectedNumberOfWinners = null,
                    RelatedToClasses = false,
                    ParentId = null,
                    CycleId = 1
                }, new Category()
                {
                    Id = 7,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicName = "فئة الحضانة المتميزة",
                    EnglishName = "Distinguished Nursery Category",
                    ArabicDescription = "تحرص الحكومة الرشيدة في دولة الامارات العربية المتحدة على جودة الخدمات المقدمة للطفل باعتباره اللبنة الأولى في بناء المجتمع وتلقينه الدروس الأولى للانطلاق إلى فضاء الحياة مسلحاً بالقيم والسلوكيات الإيجابية ومتمكنا من المهارات الأساسية الأولى لذا فقد أفردت الجائزة لهذه الفئة مجالًا لإبراز تميزها في مجال تطوير الأدوات وبيئة العمل وتقديم الخدمات المتميزة للعاملين فيها، وللطلبة ولأولياء الأمور، وللمجتمع ككل، ويحق لجميع الحضانات الحكومية والخاصة على مستوى دولة الإمارات التّقدّم للجائزة وفق معايير مخصّصة وضمن شروط محدّدة.",
                    EnglishDescription = "The rational government in the United Arab Emirates accentuates the quality of the services provided to the children as they are the first building block of the society and emphasizes on preparing them for life, equipping them with values and positive behavior, and mastering the key basic skills. Therefore, the Sharjah Award has devoted space to this category to highlight its excellence in developing the tools and work environment and providing distinguished services to its staff, students, parents, and the community. All nurseries at the UAE level are eligible to apply for the award according to specific criteria and conditions.",
                    Icon = "https://award-shj.ae/media/ceihv5g3/%D9%81%D8%A6%D8%A9-%D8%A7%D9%84%D9%85%D8%A4%D8%B3%D8%B3%D8%A7%D8%AA-%D8%A7%D9%84%D8%AA%D8%B9%D9%84%D9%8A%D9%85%D9%8A%D8%A9-%D8%A7%D9%84%D8%AD%D8%B6%D8%A7%D9%86%D8%A9-%D8%A7%D9%84%D9%85%D8%AA%D9%85%D9%8A%D8%B2%D8%A9.png",
                    CategoryClassification = Domain.Constants.CategoryConstants.CategoryClassification.Group,
                    FinalArbitrationQualificationMark = 100,
                    WinningScore = 90,
                    MinimumAmountToParticipateInTheAward = 60,
                    MinimumAmountToObtainACertificateOfParticipation = 80,
                    ExpectedNumberOfWinners = 4,
                    RelatedToClasses = false,
                    ParentId = 6,
                    CycleId = 1
                }, new Category()
                {
                    Id = 8,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicName = "فئة المدرسة المتميزة",
                    EnglishName = "Distinguished School Category",
                    ArabicDescription = "تسهم المدرسة الفاعلة في معالجة مشكلات المجتمع ومساعدته على التطوير؛ وتقوم بدور طليعي في خدمته، وتعمل على تعزيز الصلة والتلاحم بين أفراده وتوجيه التربية وجهة عملية تتصل بواقع الحياة ، وتدريب الطلاب على التنظيم والتخطيط والعمل الجماعي لذا حظيت المدرسة المتميزة على جل اهتمام القائمين على الجائزة وخصصوا لها فئة لتحدد المدارس المشاركة من خلالها قدرتها الفائقة على قيادة التعليم والتعلم والأمن والسلامة وتحقيق جودة الحياة لطلابها، ويحق لجميع المدارس الحكومية و الخاصة على مستوى دولة الإمارات التّقدّم للجائزة وفق معايير مخصّصة وضمن شروط محدّدة.",
                    EnglishDescription = "An effective school contributes to developing the community and addressing its problems. It plays a key role in serving the community, strengthening the links and relations between its members, directing education to address real life, as well as training the students on organization, planning and teamwork. The Sharjah Award paid special attention to this category through providing schools with opportunities to demonstrate their abilities in leading teaching and learning, security and safety as well as wellbeing for its students. All public and private schools in the UAE are eligible to apply for the award according to specific criteria and conditions.",
                    Icon = "https://award-shj.ae/media/1dlpga1u/%D9%81%D8%A6%D8%A9-%D8%A7%D9%84%D9%85%D8%A4%D8%B3%D8%B3%D8%A7%D8%AA-%D8%A7%D9%84%D8%AA%D8%B9%D9%84%D9%8A%D9%85%D9%8A%D8%A9-%D8%A7%D9%84%D9%85%D8%AF%D8%B1%D8%B3%D8%A9-%D8%A7%D9%84%D9%85%D8%AA%D9%85%D9%8A%D8%B2%D8%A9.png",
                    CategoryClassification = Domain.Constants.CategoryConstants.CategoryClassification.Group,
                    FinalArbitrationQualificationMark = 100,
                    WinningScore = 90,
                    MinimumAmountToParticipateInTheAward = 60,
                    MinimumAmountToObtainACertificateOfParticipation = 80,
                    ExpectedNumberOfWinners = 4,
                    RelatedToClasses = false,
                    ParentId = 6,
                    CycleId = 1
                });
            #endregion
            #region AwardSponsor
            modelBuilder.Entity<AwardSponsor>()
                .HasData(new AwardSponsor()
                {
                    Id = 1,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicName = "صاحبِ السموّ الشيخ الدكتور سلطان بن محمد القاسمي، عضوِ المجلس الأعلى، حاكمِ الشارقةِ، إمارةِ الثقافةِ والتميّز",
                    EnglishName = "His Highness Sheikh Dr. Sultan bin Muhammad Al Qasimi, Supreme Council Member and Ruler of Sharjah",
                    ArabicDescription = "حفلت السيرة الذاتية لصاحب السمو الشيخ الدكتور سلطان بن محمد القاسمي عضو المجلس الأعلى حاكم الشارقة بالعديد من الإنجازات التي تكشف عن اهتمام سموه المبكر بتحصيل العلوم بمختلف أنواعها، وحرص سموه على إفادة المجتمع من هذا العلم، سواء عن طريق إنشاء الكليات والجامعات، أو تأليف نحو 17 كتاباً ودراسة في مختلف أنواع الآداب والمعارف، رغم انشغال سموه بأمور الدولة، ومتابعة شؤون إمارة الشارقة الباسمة.\r\n\r\n \r\n\r\nإن منح صاحب السمو الشيخ الدكتور سلطان بن محمد القاسمي عضو المجلس الأعلى حاكم الشارقة دكتوراه فخرية من جامعة تيوبنجن الألمانية، تلك الجامعة التي تعد واحدة من أعرق الجامعات الألمانية يؤكد من جديد ما يتمتع به سموه حفظه الله من مكانة رفيعة بين الأوساط العلمية والأكاديمية، تلك المكانة التي تتوج مسيرة طويلة من الجهد المضني الذي بذله ويبذله سموه بتفان وإخلاص من أجل إرساء قواعد نهضة حقيقية للبلاد تنبعث من الإنسان الواعي المثقف الذي يتخذ من العلم والإيمان والثقافة طريقا وحياة ليجعل لبلاده مكاناً ومكانة رفيعة بين الأمم.\r\n\r\n \r\n\r\nتلك الرؤية العميقة لصاحب السمو حاكم الشارقة من أجل التطور والنهوض كانت دائماً هي الهاجس الذي كرس سموه من أجله وقته وحياته وبدأ من أجل تحقيقها مسيرة طويلة من الجهد والعمل الدؤؤوب.\r\n\r\n \r\n\r\nوقد كانت جهود سموه المشهودة الساعية باستمرار الى نشر العلم ودعم البحث العلمي والأخذ بأسبابه، وما يقدمه من مؤلفات وأبحاث ودراسات وآراء قيمة، وكذلك اهتمام كبير بنشر ثقافة الحوار بين الشعوب العربية والإسلامية وشعوب العالم الغربي، وسعي سموه المتواصل لدعم هذا التوجه عبر فعاليات ثقافية ومد خطوط تواصل دائمة بين الشارقة والعديد من البلدان الأوروبية، جعلت من سموه شخصية استثنائية بكل المقاييس وأحد أهم وأبرز شخصيات العالم العربي التي تحظي بتقدير عالمي في الأوساط الأكاديمية والعلمية ما حدا بجامعات العالم أن تسعى الى تكريم سموه وإهدائه أعلى درجاتها العلمية، وما حصول سموه بالأمس على الدكتوراه الفخرية من جامعة تيوبنجن الألمانية إلا تقديرا واعترافا جديدا بفضل سموه وشخصيته وجهوده وأعماله المقدرة.. ففضلا عن حصول سموه على درجة الدكتوراه في فلسفة التاريخ بامتياز من جامعة إكسيتر 1985م بالمملكة المتحدة ودرجة الدكتوراه في الفلسفة في الجغرافيا السياسية للخليج من جامعة دورهام 1999م بالمملكة المتحدة. فإن سموه يحمل تسع شهادات دكتوراه فخرية من أعرق الجامعات العربية والإسلامية والآسيوية والأوروبية حيث منح سموه دكتوراه فخرية في الآداب 1985م من جامعة أكستر بالمملكة المتحدة، في الحقوق 1986م من جامعة الخرطوم بالسودان، في القانون من جامعة ماك ماستر الكندية، في التاريخ من معهد الاستشراق التابع لأكاديمية العلوم الروسية، دكتوراه فخرية من جامعة فيصل أباد البنجاب في باكستان، من جامعة أدنبرة، من الجامعة الإسلامية العالمية بماليزيا، دكتوراه فخرية من جامعة ساوث بانك البريطانية وأخرى من أكاديمية العلوم القومية بجمهورية أرمينيا. هذا التكريم الذي صادف أهله بحق والذي حصل عليه سموه من جامعات العالم، والذي يشكل إجماعاً أكاديمياً على قدر سموه العلمي والإنساني وعلى قيمة وأهمية مايقدمه سموه لبلاده وشعبه من جهد وعمل، هو في حقيقة الأمر وسام على صدر كل ابن من أبناء الإمارات. بارك الله في جهود سموه  المخلصة البناءة التي تحث وتشهد على عظمة الإنسان عندما يكرس حياته وجهده وعمله لخدمة الوطن وأبنائه المخلصين.",
                    EnglishDescription = "The biography of His Highness Sheikh Dr. Sultan bin Muhammad Al Qasimi, Member of the Supreme Council and Ruler of Sharjah, is full of many achievements that reveal his early interest in acquiring all kinds of sciences. His Highness was keen to support the society with this knowledge, whether by establishing colleges and universities, or authoring more than 17 books and studies in various types of literature and knowledge, beside his responsibilities of country affairs, and following up on the affairs of the smiling Emirate of Sharjah.\r\n\r\n \r\n\r\nHis Highness Sheikh Dr. Sultan bin Muhammad Al Qasimi, Member of the Supreme Council and Ruler of Sharjah, has an honorary doctorate from the German University of Tuebingen, which is one of the ancient German universities. This confirms His Highness’s high status among the scientific and academic community. This prestige status culminates the long march of strenuous effort that His Highness made and is making with devotion and sincerity in order to empower the foundations for a real advantage for the country, emanating from the conscious and educated person who takes science, faith and culture as a path and life guide to give his country a high status place among nations.\r\n\r\n \r\n\r\nThat deep vision of His Highness the Ruler of Sharjah for development and advancement has always been the obsession for which His Highness devoted his time and life and began to achieve it through a long journey of effort and hard work.\r\n\r\n \r\n\r\nHis Highness's remarkable efforts were constantly attempt to spread knowledge, support scientific research and take into account its causes, and what his highness presents of valuable books, research, studies and opinions, as well as his great interest in spreading the culture of dialogue between the Arabic and Islamic people and the people of the Western world. His Highness' continuous endeavor to support this trend through cultural activities and extending permanent lines of communication between Sharjah and many European countries, made His Highness an exceptional personality by all standards and one of the most important and prominent personalities in the Arab world that enjoys global appreciation in the academic and scientific circles, which prompted the world's universities to seek to honor His Highness and bestow upon him the highest academic degrees. His Highness received an honorary doctorate from the University of Tuebingen in Germany, is an appreciation and recognition of His Highness, his personality, his efforts, and his appreciable work. In addition to his obtaining a PhD in Philosophy of History with distinction from the University of Exeter in 1985 in the United Kingdom, and a PhD in Philosophy in the Political Geography of the Gulf from Durham University in 1999 in the United Kingdom, His Highness holds nine honorary doctorates from the most prestigious Arab, Islamic, Asian and European universities. Furthermore, his Highness was awarded an honorary doctorate in literature in 1985 from the University of Exeter in the United Kingdom, in law in 1986 from the University of Khartoum in Sudan, in law from Canadian McMaster University, in history from the Oriental Institute of the Russian Academy of Sciences, an honorary doctorate from the University of Faisalabad Punjab in Pakistan, from University of Edinburgh, International Islamic University Malaysia, Honorary Doctorate from British South Bank University and another from the National Academy of Sciences of the Republic of Armenia. This honor which His Highness received from the universities of the world, constitutes an academic consensus on the scientific and human value of His Highness and on the value and importance of what His Highness offers to his country and his people of effort and work, is in fact a medal on the chest of every son of the Emirates. May God bless His Highness's sincere and constructive efforts that urge and testify to the greatness of man who devotes his life, effort and work to the country and people.",
                    Image = "https://award-shj.ae/media/hk2fyzfv/%D8%A7%D9%84%D8%B4%D9%8A%D8%AE-%D8%B3%D9%84%D8%B7%D8%A7%D9%86.jpg?anchor=center&mode=crop&width=420&height=232&rnd=133099679521200000",
                    ArabicUpbringingAndAiography = "هو صاحب السمو الشيخ الدكتور سلطان بن محمد بن صقر بن خالد بن سلطان بن صقر بن راشد القاسمي ولد يوم الأحد في الرابع عشر من جمادى الأولى سنة 1358 هـ، الموافق الثاني من يوليو عام 1939 م بمدينة الشارقة.\r\n\r\nوالدته الشيخة مريم بنت الشيخ غانم ابن الشيخ سالم بن عبدالله بن سعيد ابن سبت بن مطر بن سلطان بن فارس بن شهوان الشامسي.\r\n\r\nله من والدته من الأشقاء أربع الشيخ خالد والشيخ صقر والشيخ عبدالعزيز والشيخ عبدالله ومن  الشقيقات اثنتان الشيخة شيخة والشيخة ناعمة .\r\n\r\nولصاحب السمو حاكم الشارقة أخوة غير أشقاء هم الشيخ راشد والشيخ حميد والشيخ علي والشيخة موزة والشيخة علياء والشيخات غاية ونورة وعائشة وعزة.\r\n\r\nتزوج سموه من الشيخة موزة بنت سالم بن محمد ابن مانع الفلاسي (جدتها الشيخة موزة بنت الشيخ غانم ابن الشيخ سالم الشامسي خالة صاحب السمو الشيخ الدكتور سلطان بن محمد القاسمي)، وقد انجبت له ابنه المرحوم الشيخ محمد الذي توفي في الثالث من أبريل عام 1999 عن عمر يناهز 24 عاماً، وابنته الشيخة عزة .\r\n\r\nكما تزوج صاحب السمو حاكم الشارقة سمو الشيخة جواهر بنت الشيخ محمد بن سلطان بن صقر القاسمي ، وأنجبت له من الأبناء الشيخ خالد (توفي في 01 يوليو2019 عن عمر ناهز الأربعين عامًا) و الشيخة بدور والشيخة نور و الشيخة حور .. .\r\n\r\nتربى سموه على الوطنية، وترعرع على حب العلم والمعرفة، وكان شغوفا جدا بتاريخ وطنه، تفرغ في بداية عمره للدراسة وانتقل بين الشارقة والكويت ومصر ليتلقى تعليمه، وقد بدأ سموه تعليمه العام في شهر سبتمبر سنة 1948 في مدرسة الإصلاح القاسمية وكان عمره آنذاك تسع سنوات وشهرين، وكان قد درس سموه قبلها القرآن لدى الشيخ فارس ابن عبد الرحمن. وفي العام 1954 انضم صاحب السمو حاكم الشارقة للمدرسة الإنجليزية الخاصة ليدرس اللغة الإنجليزية. وانتقل سموه بين الشارقة والكويت لتلقي تعليمه الإعدادي والثانوي لينتهي به المطاف في نهاية عام 1965 في القاهرة حيث بدأ الدراسة الجامعية في كلية الزراعة بجامعة القاهرة.\r\n\r\nعمل سموه مدة عامين منذ فبراير عام 1961 وإلى سبتمبر 1963 كمدرس لمادتي اللغة الانجليزية والرياضيات بالمدرسة الصناعية بالشارقة.\r\n\r\nثم تسلم رئاسة البلدية في عام 1965 . وبعد عودته إلى الشارقة بعد اتمامه دراسته الجامعية عام 1971 تسلم صاحب السمو حاكم الشارقة إدارة مكتب سمو الحاكم بإمارة الشارقة.\r\n\r\nوبعد أيام من قيام اتحاد دولة الإمارات العربية المتحدة صباح يوم الثاني من ديسمبر عام 1971، وتحديداً في اليوم التاسع من ديسمبر تم تشكيل مجلس الوزراء ونصب صاحب السمو الشيخ الدكتور سلطان القاسمي يومها وزيراً للتربية والتعليم.\r\n\r\nوفي يوم الثلاثاء التاسع من ذي الحجة، يوم عرفة سنة 1391 هـ الموافق الخامس والعشرين من يناير 1972 تسلم صاحب السمو الشيخ الدكتور سلطان بن محمد القاسمي مقاليد حكم إمارة الشارقة بعد مقتل حاكم الشارقة آنذاك الشيخ خالد بن محمد القاسمي بعد انقلاب قاده الشيخ صقر بن سلطان القاسمي ، وليكون عضواً في المجلس الأعلى لدولة الامارات العربية المتحدة، وكان عمر سموه آنذاك 32 عاماً.\r\n\r\nويعد سموه الحاكم الثامن عشر لإمارة الشارقة من حكم القواسم الذي يعود للعام 1600 ميلادية.\r\n\r\nوقد قاد سموه التنمية الثقافية والاقتصادية والاجتماعية في إمارة الشارقة، وبذل سموه جهداً اضافياً ووفر مصادر لتشجيع التفاعل والحوار الثقافي محلياً واقليمياً ودولياً بين الشعوب كافة.",
                    EnglishUpbringingAndAiography = "He is His Highness Sheikh Dr. Sultan bin Muhammad bin Saqr bin Khalid bin Sultan bin Saqr bin Rashid Al Qasimi. He was born on Sunday, the fourteenth of Jumada Al-Awwal, 1358 AH, corresponding to the second of July, 1939 AD, in the city of Sharjah.\r\n\r\nHis mother is Sheikha Maryam, daughter of Sheikh Ghanem, son of Sheikh Salem bin Abdullah bin Saeed bin Sabt bin Matar bin Sultan bin Faris bin Shahwan Al Shamsi.\r\n\r\nHe has four brothers from his mother, Sheikh Khaled, Sheikh Saqr, Sheikh Abdulaziz, and Sheikh Abdullah, and two sisters, Sheikha Sheikha and Sheikha Naamah.\r\n\r\nHis Highness the Ruler of Sharjah has half-siblings, Sheikh Rashid, Sheikh Humaid, Sheikh Ali, Sheikha Moza, Sheikha Alia, and Sheikhs Ghaya, Noura, Aisha and Azza.\r\n\r\nHis Highness married Sheikha Moza bint Salem bin Mohammed bin Mani Al Falasi (her grandmother was Sheikha Moza bint Sheikh Ghanem bin Sheikh Salem Al Shamsi, aunt of His Highness Sheikh Dr. Sultan bin Muhammad Al Qasimi), and she gave birth to his son, the late Sheikh Mohammed, who died on April 3, 1999. Omar is 24 years old, and his daughter, Sheikha Azza.\r\n\r\nHis Highness the Ruler of Sharjah also married Her Highness Sheikha Jawaher, daughter of Sheikh Mohammed bin Sultan bin Saqr Al Qasimi, and she bore him children Sheikh Khaled (died on July 1, 2019 at the age of forty), Sheikha Bodour, Sheikha Nour, and Sheikha Hoor...\r\n\r\nHis Highness was raised on patriotism, and he grew up with a love of science and knowledge, and he was very passionate about the history of his homeland. At the beginning of his life, he devoted himself to studying and moved between Sharjah, Kuwait, and Egypt to receive his education. His Highness began his general education in September 1948 at Al-Islah Al-Qasimia School, and he was nine years and two months old at the time. Before that, His Highness had studied the Qur’an with Sheikh Faris bin Abdul Rahman. In 1954, His Highness the Ruler of Sharjah joined the private English school to study the English language. His Highness moved between Sharjah and Kuwait to receive his preparatory and secondary education, ending up at the end of 1965 in Cairo, where he began university studies at the Faculty of Agriculture at Cairo University.\r\n\r\nHis Highness worked for two years from February 1961 to September 1963 as a teacher of English and mathematics at the Sharjah Industrial School.\r\n\r\nThen he assumed the presidency of the municipality in 1965. After his return to Sharjah after completing his university studies in 1971, His Highness the Ruler of Sharjah assumed the management of the Office of His Highness the Ruler in the Emirate of Sharjah.\r\n\r\nDays after the establishment of the United Arab Emirates on the morning of December 2, 1971, and specifically on the ninth of December, the Council of Ministers was formed and His Highness Sheikh Dr. Sultan Al Qasimi was appointed Minister of Education that day.\r\n\r\nOn Tuesday, the ninth of Dhu al-Hijjah, the day of Arafah in the year 1391 AH, corresponding to the twenty-fifth of January 1972, His Highness Sheikh Dr. Sultan bin Muhammad Al Qasimi took over the reins of rule of the Emirate of Sharjah after the killing of the ruler of Sharjah at the time, Sheikh Khalid bin Muhammad Al Qasimi, after a coup led by Sheikh Saqr bin Sultan Al Qasimi. To be a member of the Supreme Council of the United Arab Emirates, His Highness was 32 years old at the time.\r\n\r\nHis Highness is the eighteenth ruler of the Emirate of Sharjah during the Qawasim rule, which dates back to the year 1600 AD.\r\n\r\nHis Highness led the cultural, economic and social development in the Emirate of Sharjah, and His Highness made an additional effort and provided resources to encourage cultural interaction and dialogue locally, regionally and internationally among all peoples.",
                    Image2 = "https://award-shj.ae/media/bxpppdue/ddddd.png?crop=0,0.12824379935491048,0,0.41253923275760135&cropmode=percentage&width=1903&height=424&rnd=132551077852800000",
                    ArabicHonoraryPositions = "الزمالة الفخرية من المعهد الملكي للمهندسين المعماريين البريطانيين، تقديراً لجهود ومساهمات سموه الكبيرة في عالم التصميم والهندسة المعمارية ودوره في بناء مجتمعات أكثر استدامة، 02 نوفمبر 2018.\r\nالعضوية الفخرية بمجمع اللغة العربية وذلك تقديراً لدور سموه في خدمة اللغة والثقافة العربية، 24 ديسمبر 2015.\r\nالزمالة الفخرية من كليات الأطباء الملكية في كل من لندن وجلاسكو وأدنبرة وذلك تقديراً لدور سموه في دعم المسيرة التعليمية والطبية على مستوى العالم، 16 يونيو 2015.\r\nالرئيس الشرفي للاتحاد العربي للمرشدين السياحيين، 2013.\r\nالرئيس الفخري لاتحاد كتاب وأدباء الإمارات، 2012.\r\nالزمالة الشرفية من الكلية الملكية الإنجليزية للجراحيين، لندن، بريطانيا 12نوفمبر 2009.\r\nالرئيس الفخري لاتحاد الجامعات العربية، 2009.\r\nالرئيس الأعلى للهيئة العربية للمسرح،2008.\r\nالرئيس الفخري للجمعية العربية لعلوم الفضاء والفلك 2008.\r\nالرئيس الفخري للمؤسسة الدولية لتاريخ العلوم عند العرب والمسلمين 2008.\r\nالعضوية الفخرية باتحاد كتاب مصر 2008.\r\nالعضوية الشرفية، الجمعية الوطنية للجغرافيا، تقديراً لدعم سموه للجمعية الوطنية للجغرافيا بالولايات المتحدة الأمريكية، التي تأسست في عام 1888، للعناية بعلم الجغرافيا وتطوير البحث والاستكشاف، واشنطن، أمريكا يناير 2004.\r\nالرئيس الفخري للجمعية المصرية للدراسات التاريخية 2001.\r\nالرئيس الفخري للمؤسسة العربية للعلوم والتكنولوجيا، 2000.\r\nالرئيس الفخري للخدمات الجامعية العالمية 1998.\r\nالرئيس الفخري لمدينة الشارقة للخدمات الإنسانية 1998.\r\nالعضوية الفخرية في مركز الدراسات الشرق أوسطية والإسلامية، جامعة درم، المملكة المتحدة 22 اكتوبر 1992.\r\nالزمالة الفخرية، معهد الدراسات الأفريقية، جامعة الخرطوم، السودان، 1977.",
                    EnglishHonoraryPositions = "Honorary Fellowship from the Royal Institute of British Architects, in recognition of His Highness’s great efforts and contributions to the world of design and architecture and his role in building more sustainable societies, 02 November 2018.\r\nHonorary membership in the Arabic Language Academy in recognition of His Highness’s role in serving the Arabic language and culture, December 24, 2015.\r\nHonorary Fellowship from the Royal Colleges of Physicians in London, Glasgow and Edinburgh in recognition of His Highness’s role in supporting the educational and medical process worldwide, June 16, 2015.\r\nHonorary President of the Arab Federation of Tourist Guides, 2013.\r\nHonorary President of the Emirates Writers and Writers Union, 2012.\r\nHonorary Fellowship from the Royal College of Surgeons, London, Britain November 12, 2009.\r\nHonorary President of the Association of Arab Universities, 2009.\r\nSupreme President of the Arab Theater Authority, 2008.\r\nHonorary President of the Arab Society for Space and Astronomy 2008.\r\nHonorary President of the International Foundation for the History of Science among Arabs and Muslims 2008.\r\nHonorary membership in the Egyptian Writers Union 2008.\r\nHonorary Membership, National Geographic Society, in recognition of His Highness’s support for the National Geographic Society of the United States of America, which was founded in 1888, to care for the science of geography and develop research and exploration, Washington, America, January 2004.\r\nHonorary President of the Egyptian Society for Historical Studies 2001.\r\nHonorary President of the Arab Science and Technology Foundation, 2000.\r\nHonorary President of Global University Services 1998.\r\nHonorary President of Sharjah City for Humanitarian Services 1998.\r\nHonorary membership in the Center for Middle Eastern and Islamic Studies, Durham University, United Kingdom, October 22, 1992.\r\nHonorary Fellowship, Institute of African Studies, University of Khartoum, Sudan, 1977.",
                    Image3 = "https://award-shj.ae/media/bxpppdue/ddddd.png?crop=0,0.12824379935491048,0,0.41253923275760135&cropmode=percentage&width=1903&height=424&rnd=132551077852800000",
                    ArabicEducationalStages = "1948 التعليم الابتدائي - مدرسة الإصلاح القاسمية\r\nالتعليم الإعدادي والثانوي - الشارقة ودبي\r\n 1971 البكالوريوس في الزراعة - كلية الزراعة، جامعة القاهرة، القاهرة، مصر\r\nدكتوراه في التاريخ بامتياز - عن أطروحة تناولت مزاعم القرصنة ومحاولات شركة الهند الشرقية السيطرة على الخليج بين 1797-1820 ، جامعة إكسيتر، إكسيتر، المملكة المتحدة - 10 مايو 1985 م\r\nدكتوراه في الجغرافية السياسية للخليج - عن أطروحة بعنوان «صراع القوى والتجارة في الخليج خلال الفترة من سنة 1620 م وحتى سنة 1820 م» ، جامعة درهام، درهام، المملكة المتحدة ، 2 يوليو 1999 م",
                    EnglishEducationalStages = "1948 Primary Education - Al-Islah Al-Qasimiya School\r\nPreparatory and secondary education - Sharjah and Dubai\r\n  1971 Bachelor of Agriculture - Faculty of Agriculture, Cairo University, Cairo, Egypt\r\nDoctorate in History with distinction - on a thesis that dealt with allegations of piracy and the attempts of the East India Company to control the Gulf between 1797-1820, University of Exeter, Exeter, United Kingdom - May 10, 1985 AD\r\nDoctorate in the Political Geography of the Gulf - for a thesis entitled “Power Conflict and Trade in the Gulf during the Period from 1620 AD to 1820 AD,” Durham University, Durham, United Kingdom, July 2, 1999 AD.",
                    ArabicWritings = "صاحب السمو الشيخ الدكتور سلطان القاسمي، له العديد من المؤلفات منها\r\n\r\nمحاكم التفتيش\r\nسيرة مدينة (الجزء الأول)ـ\r\nسيرة مدينة (الجزء الثاني)ـ",
                    EnglishWritings = "His Highness Sheikh Dr. Sultan Al Qasimi has many publications, including:\r\n\r\ninquisition\r\nBiography of a city (Part One).\r\nBiography of a city (Part Two)."
                });
            #endregion
            #region AboutAwardPage
            modelBuilder.Entity<AboutAwardPage>()
                .HasData(new AboutAwardPage()
                {
                    Id = 1,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicAboutTitle = "نبذة عن الجائزة",
                    EnglishAboutTitle = "About the award",
                    ArabicAboutDescription = "تأسست جائزة الشارقة للتفوق والتميز التربوي عام 1994-1995 برعاية كريمة من صاحب السمو الشيخ الدكتور سلطان بن محمد القاسمي عضو المجلس الاعلى حاكم إمارة الشارقة حفظه الله ورعاه... وتعتبر أول جائزة تربوية على مستوى الدولة",
                    EnglishAboutDescription = "The Sharjah Award for Educational Excellence and Excellence was established in 1994-1995 under the generous patronage of His Highness Sheikh Dr. Sultan bin Muhammad Al Qasimi, Member of the Supreme Council and Ruler of the Emirate of Sharjah, may God protect and preserve him... It is considered the first educational award at the state level.",
                    AboutImage = "https://award-shj.ae/media/fuebwvg4/17.jpg?center=0.15180018758166036,0.48777667777111344&mode=crop&width=796&height=329&rnd=133312190453500000",
                    ArabicOurVisionTitle = "رؤيتنا",
                    EnglishOurVisionTitle = "Our vision",
                    ArabicOurVisionDescription = "تعلـــيم متــميز",
                    EnglishOurVisionDescription = "Distinguished education",
                    OurVisionImage = "https://award-shj.ae/media/fuebwvg4/17.jpg?center=0.15180018758166036,0.48777667777111344&mode=crop&width=796&height=329&rnd=133312190453500000"
                });
            #endregion
            #region OurGoal
            modelBuilder.Entity<OurGoal>()
                .HasData(new OurGoal()
                {
                    Id = 1,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    AboutAwardPageId = 1,
                    ArabicGoal = "1- تطوير القطاع التربوي من خلال بث روح التنافس بينهم؛ لتحقيق أفضل الممارسات التربوية. 2- تطوير أعمال الجائزة ومنهجياتها، ورفع الكفايات المهنية للعاملين بها. 3- دعم الطلاب المتميزين في مختلف المجالات، وإكسابهم مهارات متنوعة ومتكاملة. 4- تبني منهجية مبتكرة لاستقطاب وبناء الشراكات الداعمة للجائزة والتعليم.",
                    EnglishGoal = "1- Developing the educational sector by spreading the spirit of competition among them; To achieve best educational practices. 2- Developing the Award’s work and methodologies, and raising the professional competencies of its employees. 3- Supporting distinguished students in various fields, and providing them with diverse and integrated skills. 4- Adopting an innovative methodology to attract and build partnerships that support the award and education."
                });
            #endregion
            #region OnePageText
            modelBuilder.Entity<OnePageText>()
                .HasData(new OnePageText()
                {
                    Id = 1,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicText = "إن هذا الموقع تابع لجائزة الشارقة للتفوق والتميز التربوي وكغيره من المواقع التابعة للجائزة، ملتزمٌ بحماية حقوق جميع زوار هذا الموقع، أي إننا نلتزم بالحفاظ على سرية المعلومات الحساسة، وقد أعددنا هذا الإعلان الخاص بسياسة الخصوصية للإفصاح عن النهج الذي نتبعه في جمع ونشر المعلومات على هذا الموقع الإلكتروني.\r\n\r\nتعتبر سياسة الخصوصية الموضحة في هذه الصفحة، جزءاً من شروط استخدام الموقع الإلكتروني وأحكامه.\r\n\r\n\r\nجمع واستخدام المعلومات الإلكترونية\r\n\r\nتعمل الخوادم الخاصة بنا تلقائياً على التقاط وجمع عنوان بروتوكول الإنترنت الخاص بك عند زيارتك للموقع، إن عنوان بروتوكول الإنترنت الخاص بك هو الرقم الخاص بجهاز الكمبيوتر أو الجهاز اللوحي أو الهاتف الذكي الذي تستخدمه، والذي يسمح للأجهزة الأخرى الموصولة بشبكة الإنترنت بتحديد وجهة البيانات الصادرة عنها، لكن من دون التعرف عليك شخصياً.\r\nإن استخدامنا لبروتوكول الإنترنت الخاص بك يساعدنا على تشخيص المشكلات التي قد تحدث في الخادم الخاص بنا، وعلى إجراء الإحصاء اللازم لقياس استخدام الموقع، ونحن لا نسمح لأي جهة خارج إطار الفريق الفني المكلف من الجائزة بالاطلاع على بروتوكول الإنترنت الخاص بك.\r\nمن أجل تقديم خدمة أفضل، وموقع إلكتروني أكثر فاعلية، يمكن لبعض أقسام هذا الموقع استخدام برامج تعريف الارتباط (cookies) كجزء من التفاعل مع متصفحك، وهذا البرنامج هو عبارة عن ملف نصي صغير يرسل إلى القرص الصلب الخاص بك ليتمكن خادمنا من التعرف على الجهاز والمتصفح الذي تستخدمه لتحسين تعاملك مع موقعنا.\r\nلن يقوم برنامج تعريف الارتباط المرسل من قبلنا بمحاولة قراءة أي من المعلومات الخاصة الموجودة على قرصك الصلب، ونحن لا نقوم بتجميع هذه المعلومات من خلال هذا البرامج لمعرفة بيانات أو معلومات شخصية أخرى من أجل تحديد هويتك أو عنوان بريدك الإلكتروني.\r\nفي حال كانت زيارتك للموقع للحصول على خدمة أو معلومات محددة، فقد يطلب منك عند زيارتك لبعض أجزاء هذا الموقع، تقديم معلومات شخصية للتعريف بهويتك (مثل الاسم، رقم الهاتف، والعنوان،...)، وهي كلها معلومات ضرورية لإتمام معاملتك غير أن هذه المعلومات لن يتم مشاركتها أو إساءة استخدامها تحت أي ظرف، وفي حال رفضك تقديم تلك المعلومات، فللجائزة الحق في رفض تقديم تلك الخدمة، وفي كل الأحوال، فإننا لانزل ندعوك لزيارة موقعنا والاستفادة من المعلومات القيمة التي يوفرها.\r\n \r\n\r\nحماية المعلومات الشخصية\r\n\r\nباستخدامك لهذا الموقع فإنك توافق على شروط سياسة الخصوصية هذه، حيث تلتزم الجائزة من خلال إدارته لموقعه الإلكتروني، عند جمع معلومات شخصية عنك عندما تقوم بزيارة الموقع بأن يكون استخدام تلك المعلومات التي قدمتها، فقط من أجل إنجاز طلبك للحصول على معلومات أو خدمات عبر الموقع.\r\nيحتفظ جائزة الشارقة للتفوق والتميز التربوي بالحق في إجراء أي تعديل طفيف أو جذري لشروط سياسة الخصوصية من وقت لآخر دون الحاجة إلى تقديم إخطار، حيث يتم تعديل هذه السياسة ونشر هذه التعديلات بمجرد اعتمادها، لذا ننصحك بالاطلاع على هذه الصفحة من وقت لأخر لمعرفة التحديثات التي طرأت على سياسة الخصوصية، ولذلك فإن زيارتك واستخدامك لموقعنا بعد إدخال التعديلات على سياسة الخصوصية هذه، يعني قبولك لهذه التغييرات.\r\nلن تكون معلوماتك الشخصية متاحة إلا لموظفي الجائزة الذين يحتاجون للاطلاع على تلك المعلومات، ولن تكون تلك المعلومات متاحة لاطلاع الجمهور عليها بدون موافقتك على ذلك، وعلاوة على ذلك، لن يتم تبادل، أو تداول أي من تلك المعلومات أو بيعها لأي طرف آخر من دون موافقتك المسبقة، ولن يتم السماح بالوصول إلى المعلومات إلا لأولئك المؤهلين والمحترفين الذين يتولون تقديم خدمات الجائزة المتسقة مع تعاملاتك مع موقعنا.\r\n \r\n\r\nانتقال آمن للمعلومات\r\nهذا الموقع يمتلك إجراءات أمن لحماية المعلومات التي تقدمها لنا، فإننا نعمل على تشفير المعلومات التي تعتبر حساسة (مثل بياناتك الشخصية) أو البيانات التي يتعين الحفاظ على سريتها تماشياً مع المتطلبات القانونية.\r\n\r\n\r\nالمرجعية القانونية للجائزة\r\n\r\nيحق لجائزة الشارقة للتفوق والتميز التربوي اتخاذ التدابير التي يراها ملائمة لحماية أي فقدان أو إساءة استخدام أو تغيير للمعلومات الموجودة على الموقع الإلكتروني، وذلك دون أن تضمن الجائزة في هذه الحالة الاحتفاظ بسرية محتويات هذا الموقع الإلكتروني، ولا يعتبر مسؤولاً قانوناً عن أي ضرر قد تتعرض له أنت أو أي شخص نتيجة لانتهاك السرية بشأن المعلومات التي تكون قد نقلتها إلى الموقع.\r\nتكون قوانين دولة الإمارات العربية المتحدة وحدها هي القوانين واجبة التطبيق في كل ما يتعلق بالنزاعات التي قد تنشأ من جراء استخدام هذا الموقع الإلكتروني، أو أياً من أجزائه وأقسامه، كما تختص محاكم إمارة الشارقة حصرياً بالنظر في تلك النزاعات والبت فيها.",
                    EnglishText = "This site is affiliated with the Sharjah Award for Excellence and Educational Excellence, and like other sites affiliated with the award, it is committed to protecting the rights of all visitors to this site. That is, we are committed to maintaining the confidentiality of sensitive information. We have prepared this announcement of the privacy policy to disclose the approach we follow in collecting and publishing information on this site. website.\r\n\r\nThe privacy policy shown on this page is considered part of the terms and conditions of use of the website.\r\n\r\n\r\nCollection and use of electronic information\r\n\r\nOur servers automatically capture and collect your Internet Protocol address when you visit the site. Your Internet Protocol address is the number for the computer, tablet, or smartphone that you use, which allows other devices connected to the Internet to determine the destination of the data issued by it. But without getting to know you personally.\r\nOur use of your Internet Protocol helps us diagnose problems that may occur in our server, and to conduct the necessary statistics to measure the use of the site, and we do not allow any party outside the framework of the technical team assigned by the award to view your Internet Protocol.\r\nIn order to provide better service and a more effective website, some sections of this site may use cookies as part of the interaction with your browser. This program is a small text file sent to your hard disk so that our server can recognize your device and browser. which you use to improve your interaction with our site.\r\nThe cookie software sent by us will not attempt to read any of the private information on your hard drive, and we do not collect this information through this software to find out other personal data or information in order to determine your identity or email address.\r\nIf your visit to the site is to obtain a specific service or information, when you visit some parts of this site, you may be asked to provide personal information to identify yourself (such as name, phone number, address,...), which are all necessary information to complete your transaction, but this The information will not be shared or misused under any circumstances, and if you refuse to provide that information, the award has the right to refuse to provide that service. In any case, we still invite you to visit our website and benefit from the valuable information it provides.\r\n \r\n\r\nProtection of personal information\r\n\r\nBy using this website, you agree to the terms of this privacy policy, as the award, through its management of its website, is committed to collecting personal information about you when you visit the site, to use that information that you provided, only in order to fulfill your request for information or services through the site.\r\nThe Sharjah Award for Excellence and Educational Excellence reserves the right to make any minor or radical amendment to the terms of the privacy policy from time to time without the need to provide notification. This policy is amended and these amendments are published as soon as they are approved. Therefore, we advise you to check this page from time to time to find out the updates that have occurred. On the Privacy Policy, therefore, your visit and use of our site after making amendments to this Privacy Policy means that you accept these changes.\r\nYour personal information will only be available to award employees who need to see that information, and that information will not be available for public access without your consent. Furthermore, none of that information will be exchanged, traded, or sold to any other party without your consent. Access to the information will only be granted to those qualified and professional people who provide award services consistent with your dealings with our website.\r\n \r\n\r\nSecure transmission of information\r\nThis site has security measures in place to protect the information you provide to us. We encrypt information that is considered sensitive (such as your personal data) or data that must be kept confidential in line with legal requirements.\r\n\r\n\r\nLegal reference for the award\r\n\r\nThe Sharjah Award for Educational Excellence and Excellence has the right to take the measures it deems appropriate to protect any loss, misuse, or change of information on the website, without the award in this case guaranteeing the confidentiality of the contents of this website, and it is not considered legally responsible for any damage you may be exposed to. You or any person as a result of a breach of confidentiality regarding information you have transmitted to the Site.\r\nThe laws of the United Arab Emirates alone are the applicable laws in all matters related to disputes that may arise as a result of the use of this website, or any of its parts and sections, and the courts of the Emirate of Sharjah have exclusive jurisdiction to consider and decide on these disputes.",
                    Type = Domain.Constants.OnePageText.OnePageTextType.PrivacyPolicy,
                    Slug = "Privacy_Policy_Website"
                }, new OnePageText()
                {
                    Id = 2,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicText = "إن هذا الموقع تابع لجائزة الشارقة للتفوق والتميز التربوي وكغيره من المواقع التابعة للجائزة، ملتزمٌ بحماية حقوق جميع زوار هذا الموقع، أي إننا نلتزم بالحفاظ على سرية المعلومات الحساسة، وقد أعددنا هذا الإعلان الخاص بسياسة الخصوصية للإفصاح عن النهج الذي نتبعه في جمع ونشر المعلومات على هذا الموقع الإلكتروني.\r\n\r\nتعتبر سياسة الخصوصية الموضحة في هذه الصفحة، جزءاً من شروط استخدام الموقع الإلكتروني وأحكامه.\r\n\r\n\r\nجمع واستخدام المعلومات الإلكترونية\r\n\r\nتعمل الخوادم الخاصة بنا تلقائياً على التقاط وجمع عنوان بروتوكول الإنترنت الخاص بك عند زيارتك للموقع، إن عنوان بروتوكول الإنترنت الخاص بك هو الرقم الخاص بجهاز الكمبيوتر أو الجهاز اللوحي أو الهاتف الذكي الذي تستخدمه، والذي يسمح للأجهزة الأخرى الموصولة بشبكة الإنترنت بتحديد وجهة البيانات الصادرة عنها، لكن من دون التعرف عليك شخصياً.\r\nإن استخدامنا لبروتوكول الإنترنت الخاص بك يساعدنا على تشخيص المشكلات التي قد تحدث في الخادم الخاص بنا، وعلى إجراء الإحصاء اللازم لقياس استخدام الموقع، ونحن لا نسمح لأي جهة خارج إطار الفريق الفني المكلف من الجائزة بالاطلاع على بروتوكول الإنترنت الخاص بك.\r\nمن أجل تقديم خدمة أفضل، وموقع إلكتروني أكثر فاعلية، يمكن لبعض أقسام هذا الموقع استخدام برامج تعريف الارتباط (cookies) كجزء من التفاعل مع متصفحك، وهذا البرنامج هو عبارة عن ملف نصي صغير يرسل إلى القرص الصلب الخاص بك ليتمكن خادمنا من التعرف على الجهاز والمتصفح الذي تستخدمه لتحسين تعاملك مع موقعنا.\r\nلن يقوم برنامج تعريف الارتباط المرسل من قبلنا بمحاولة قراءة أي من المعلومات الخاصة الموجودة على قرصك الصلب، ونحن لا نقوم بتجميع هذه المعلومات من خلال هذا البرامج لمعرفة بيانات أو معلومات شخصية أخرى من أجل تحديد هويتك أو عنوان بريدك الإلكتروني.\r\nفي حال كانت زيارتك للموقع للحصول على خدمة أو معلومات محددة، فقد يطلب منك عند زيارتك لبعض أجزاء هذا الموقع، تقديم معلومات شخصية للتعريف بهويتك (مثل الاسم، رقم الهاتف، والعنوان،...)، وهي كلها معلومات ضرورية لإتمام معاملتك غير أن هذه المعلومات لن يتم مشاركتها أو إساءة استخدامها تحت أي ظرف، وفي حال رفضك تقديم تلك المعلومات، فللجائزة الحق في رفض تقديم تلك الخدمة، وفي كل الأحوال، فإننا لانزل ندعوك لزيارة موقعنا والاستفادة من المعلومات القيمة التي يوفرها.\r\n \r\n\r\nحماية المعلومات الشخصية\r\n\r\nباستخدامك لهذا الموقع فإنك توافق على شروط سياسة الخصوصية هذه، حيث تلتزم الجائزة من خلال إدارته لموقعه الإلكتروني، عند جمع معلومات شخصية عنك عندما تقوم بزيارة الموقع بأن يكون استخدام تلك المعلومات التي قدمتها، فقط من أجل إنجاز طلبك للحصول على معلومات أو خدمات عبر الموقع.\r\nيحتفظ جائزة الشارقة للتفوق والتميز التربوي بالحق في إجراء أي تعديل طفيف أو جذري لشروط سياسة الخصوصية من وقت لآخر دون الحاجة إلى تقديم إخطار، حيث يتم تعديل هذه السياسة ونشر هذه التعديلات بمجرد اعتمادها، لذا ننصحك بالاطلاع على هذه الصفحة من وقت لأخر لمعرفة التحديثات التي طرأت على سياسة الخصوصية، ولذلك فإن زيارتك واستخدامك لموقعنا بعد إدخال التعديلات على سياسة الخصوصية هذه، يعني قبولك لهذه التغييرات.\r\nلن تكون معلوماتك الشخصية متاحة إلا لموظفي الجائزة الذين يحتاجون للاطلاع على تلك المعلومات، ولن تكون تلك المعلومات متاحة لاطلاع الجمهور عليها بدون موافقتك على ذلك، وعلاوة على ذلك، لن يتم تبادل، أو تداول أي من تلك المعلومات أو بيعها لأي طرف آخر من دون موافقتك المسبقة، ولن يتم السماح بالوصول إلى المعلومات إلا لأولئك المؤهلين والمحترفين الذين يتولون تقديم خدمات الجائزة المتسقة مع تعاملاتك مع موقعنا.\r\n \r\n\r\nانتقال آمن للمعلومات\r\nهذا الموقع يمتلك إجراءات أمن لحماية المعلومات التي تقدمها لنا، فإننا نعمل على تشفير المعلومات التي تعتبر حساسة (مثل بياناتك الشخصية) أو البيانات التي يتعين الحفاظ على سريتها تماشياً مع المتطلبات القانونية.\r\n\r\n\r\nالمرجعية القانونية للجائزة\r\n\r\nيحق لجائزة الشارقة للتفوق والتميز التربوي اتخاذ التدابير التي يراها ملائمة لحماية أي فقدان أو إساءة استخدام أو تغيير للمعلومات الموجودة على الموقع الإلكتروني، وذلك دون أن تضمن الجائزة في هذه الحالة الاحتفاظ بسرية محتويات هذا الموقع الإلكتروني، ولا يعتبر مسؤولاً قانوناً عن أي ضرر قد تتعرض له أنت أو أي شخص نتيجة لانتهاك السرية بشأن المعلومات التي تكون قد نقلتها إلى الموقع.\r\nتكون قوانين دولة الإمارات العربية المتحدة وحدها هي القوانين واجبة التطبيق في كل ما يتعلق بالنزاعات التي قد تنشأ من جراء استخدام هذا الموقع الإلكتروني، أو أياً من أجزائه وأقسامه، كما تختص محاكم إمارة الشارقة حصرياً بالنظر في تلك النزاعات والبت فيها.",
                    EnglishText = "This site is affiliated with the Sharjah Award for Excellence and Educational Excellence, and like other sites affiliated with the award, it is committed to protecting the rights of all visitors to this site. That is, we are committed to maintaining the confidentiality of sensitive information. We have prepared this announcement of the privacy policy to disclose the approach we follow in collecting and publishing information on this site. website.\r\n\r\nThe privacy policy shown on this page is considered part of the terms and conditions of use of the website.\r\n\r\n\r\nCollection and use of electronic information\r\n\r\nOur servers automatically capture and collect your Internet Protocol address when you visit the site. Your Internet Protocol address is the number for the computer, tablet, or smartphone that you use, which allows other devices connected to the Internet to determine the destination of the data issued by it. But without getting to know you personally.\r\nOur use of your Internet Protocol helps us diagnose problems that may occur in our server, and to conduct the necessary statistics to measure the use of the site, and we do not allow any party outside the framework of the technical team assigned by the award to view your Internet Protocol.\r\nIn order to provide better service and a more effective website, some sections of this site may use cookies as part of the interaction with your browser. This program is a small text file sent to your hard disk so that our server can recognize your device and browser. which you use to improve your interaction with our site.\r\nThe cookie software sent by us will not attempt to read any of the private information on your hard drive, and we do not collect this information through this software to find out other personal data or information in order to determine your identity or email address.\r\nIf your visit to the site is to obtain a specific service or information, when you visit some parts of this site, you may be asked to provide personal information to identify yourself (such as name, phone number, address,...), which are all necessary information to complete your transaction, but this The information will not be shared or misused under any circumstances, and if you refuse to provide that information, the award has the right to refuse to provide that service. In any case, we still invite you to visit our website and benefit from the valuable information it provides.\r\n \r\n\r\nProtection of personal information\r\n\r\nBy using this website, you agree to the terms of this privacy policy, as the award, through its management of its website, is committed to collecting personal information about you when you visit the site, to use that information that you provided, only in order to fulfill your request for information or services through the site.\r\nThe Sharjah Award for Excellence and Educational Excellence reserves the right to make any minor or radical amendment to the terms of the privacy policy from time to time without the need to provide notification. This policy is amended and these amendments are published as soon as they are approved. Therefore, we advise you to check this page from time to time to find out the updates that have occurred. On the Privacy Policy, therefore, your visit and use of our site after making amendments to this Privacy Policy means that you accept these changes.\r\nYour personal information will only be available to award employees who need to see that information, and that information will not be available for public access without your consent. Furthermore, none of that information will be exchanged, traded, or sold to any other party without your consent. Access to the information will only be granted to those qualified and professional people who provide award services consistent with your dealings with our website.\r\n \r\n\r\nSecure transmission of information\r\nThis site has security measures in place to protect the information you provide to us. We encrypt information that is considered sensitive (such as your personal data) or data that must be kept confidential in line with legal requirements.\r\n\r\n\r\nLegal reference for the award\r\n\r\nThe Sharjah Award for Educational Excellence and Excellence has the right to take the measures it deems appropriate to protect any loss, misuse, or change of information on the website, without the award in this case guaranteeing the confidentiality of the contents of this website, and it is not considered legally responsible for any damage you may be exposed to. You or any person as a result of a breach of confidentiality regarding information you have transmitted to the Site.\r\nThe laws of the United Arab Emirates alone are the applicable laws in all matters related to disputes that may arise as a result of the use of this website, or any of its parts and sections, and the courts of the Emirate of Sharjah have exclusive jurisdiction to consider and decide on these disputes.",
                    Type = Domain.Constants.OnePageText.OnePageTextType.PrivacyPolicy,
                    Slug = "Privacy_Policy_Subscriber"
                }, new OnePageText()
                {
                    Id = 3,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicText = "إن دخولك واستخدامك الموقع الإلكتروني لجائزة الشارقة للتفوق والتميز التربوي يخضع للشروط والأحكام الآتية، إضافة إلى قوانين دولة الإمارات العربية المتحدة المتعلقة بالتعامل مع المواقع والمنصات الإلكترونية.\r\nدخولك إلى الموقع يعني موافقتك على هذه الشروط والأحكام، سواءً كنت مستخدماً مسجلاً أو غيرمسجل. وبدخولك وتصفحك واستخدامك الموقع تكون قد قبلت دون قيد أو شرط، أحكام وشروط الاستخدام الواردة في هذه الوثيقة.\r\n\r\n \r\n\r\nتعريفات:\r\n\r\nالدولة: دولة الامارات العربية المتحدة.\r\nالجائزة: جائزة الشارقة للتفوق والتميز التربوي.\r\nالموقع: موقع جائزة الشارقة للتفوق والتميز التربوي على الشبكة العنكبوتية (الانترنت).\r\nالقانون: هي أي أو كل قانون تصدره وتقره دولة الامارات العربية المتحدة التي يتعلق بالتعامل مع تقنية المعلومات، والجرائم المتعلقة بها.\r\n \r\n\r\nتعديل الاتفاقية\r\nللجائزة الحق في تعديل هذه الشروط والأحكام على أن يتم وضع إشعار بحدوث تعديلات على هذه الصفحة، وتدخل التعديلات حيز النفاذ بمجرد إعلانها ما لم ينَصّ على خلاف ذلك.\r\nإن استخدامك المتكرر للموقع بعد إحداث تلك التعديلات يعني موافقتك على التعديلات، ويتعين عليك القيام بزيارات دورية لهذه الصفحة لمراجعة الشروط والأحكام المستحدثة أو المعدلة.\r\n\r\n \r\n\r\nالتصرف\r\nإن دخولك واستخدامك للموقع يعتبر موافقة وإقرار منك على دخول واستخدام الموقع لأغراض مشروعة فقط، وأنت مسؤول مسؤولية كاملة عن العلم والعمل بأي من وكل القوانين والأنظمة والقواعد والأحكام المتعلقة باستخدامك له، وبمجرد دخولك إلى الموقع فإنك توافق على الامتناع عن ما يلي:\r\n\r\nإدخال أو نشر أي محتويات غير قانونية تتضمن تمييزاً أو تشهيراً أو إساءة أو قذفاً أو مواد غير لائقة.\r\nاستخدام الموقع من أجل انتحال شخصيات أو أطراف أخرى.\r\nاستخدام الموقع من أجل ارتكاب جرم أو تشجيع الآخرين على التورط في أي تصرف قد يعد جريمة أو ينطوي على مسؤولية مدنية.\r\nالإساءة للآخرين أفراداً أو مؤسسات بأي شكل من الإساءة.\r\nالتحزب أو العنصرية ضد الآخرين أو الإساءة إلى أي عرق أو دين أو لون أو جنسية أو وضع اجتماعي.\r\nاستخدام الموقع لتحميل أي مادة فيها برامج تحتوي على فيروسات، أو برامج خبيثة، أو أي شفرات حاسوبية أو ملفات أو برامج قد تعمل على تغيير أو إتلاف أو إعاقة عمل الموقع أو أي جهاز أو برنامج عائد إلى أي شخص يدخل إلى الموقع.\r\nإدخال أو إرسال أو تحميل أو بث أي مواد لا يحق لك بثها أو نشرها بموجب أي قانون أو علاقة تعاقدية.\r\nتغيير أو إتلاف أو شطب أو تعطيل أي محتوى على الموقع.\r\nإتلاف أو تعطيل أي من خطوط أو قنوات أو وسائل الاتصال أو التواصل الاعتيادية أو الإلكترونية بأي شكل كان.\r\nالادعاء بتمثيل أي شركة أو جمعية أو هيئة أو مؤسسة عامة أو خاصة أو الادعاء بأنك مرتبط بها، وذلك دون أن تكون مخولاً بادعاء تلك العلاقة أو ذلك التمثيل.\r\nنشر أو بث أي إعلان أو مادة دعائية أو تسويقية لأي منتج أو خدمة بأي شكل من أشكال الترويج أو التسويق.\r\nنشر أي مادة تتنافى أو تتعارض مع حقوق الملكية الفكرية للآخرين، أو جمع أو تخزين المعلومات الشخصية عن الآخرين.\r\n \r\n\r\nالتسجيل\r\nبعض أجزاء وخدمات الموقع لا تعمل ولا يمكن الوصول اليها إلا للأعضاء المسجلين و/ أو تتيح للمستخدم طلب الدعم أو الخدمات إلكترونياً عبر إدخال بعض المعلومات الشخصية، لذا ، فأنت توافق على أن أي معلومات تقدم لنا عبر تلك الأجزاء هي معلومات صحيحة وكاملة ودقيقة، وأنك لن تقوم بالتسجيل، أو تحاول دخول الموقع مستخدماً أو منتحلا اسم أو صفة شخص آخر، وأنك لم تدعي بامتلاكك اسم مستخدم أو بيانات مستخدم ليست لك، أو قد ترى الجائزة أنه (وفق حقه في حرية التصرف)، بأنه غير مناسب.\r\n\r\n \r\n\r\nإنهاء الاستخدام\r\nللجائزة كل الحق، وفق ما يراه مناسباً، منع أو إنهاء أو تعليق دخولك إلى واستخدامك لهذا الموقع من دون إشعار ولأي سبب كان، بما في ذلك انتهاك هذه الشروط والأحكام أو بسبب أي تصرف قد يرى للجائزة أنه مخالف للقانون أو مضر بالآخرين، وفي هذه الحالات لن يعود بإمكانك الدخول إلى الموقع، وللجائزة الحق في استخدام كل وسيلة متاحة لتطبيق هذا الأمر.\r\n\r\n\r\nوصلات المواقع الأخرى\r\nبعض الوصلات على الموقع تقود إلى مواقع إلكترونية أخرى لا يتم تشغيلها من قبل الجائزة، وليس له السيطرة عليها. كما أن الجائزة لا يقوم بمراجعة المحتوى الخاص بتلك المواقع أو التحكم بها، حيث إن الجائزة يوفر تلك الوصلات من باب التسهيل على مستخدمي وزوار موقعه، كما أن تلك المواقع الأخرى ليست لها أي مضامين ترويجية أو تسويقية خاصة بالسلع أو خدمات خاصة، إنما هي وصلات لمواقع ذات صلة بعمل الجائزة و / أو تقدم خدمات تتعلق بعمل الجائزة لخدمة زوار ومستخدمي الموقع، وعند الضغط على واختيارك وصلة خاصة بموقع خارجي، فإنك تكون خاضعاً للشروط والأحكام الخاصة بذلك الموقع الخارجي.\r\n\r\n \r\n\r\nالمحتوى\r\nتحتفظ الجائزة بالحق في مراقبة أي محتوى يتم إدخاله من قبلك، غير أنه ليس ملزماً بذلك، ومع أن الجائزة قد لا يستطيع مراقبة كل ما يتم إدخاله على الموقع، فإننا نحتفظ بالحق (من دون التزام) في شطب أو إزالة أو تحرير أي مواد مدخلة من شأنها انتهاك هذه الشروط والأحكام، إن قوانين حقوق النشر والتأليف الإماراتية والأجنبية والمعاهدات الدولية تحمي محتويات هذا الموقع، وأنت توافق على الالتزام بإشعارات حقوق النشر التي تظهر على هذا الموقع.\r\n\r\n \r\n\r\nالتعويض\r\nأنت توافق على الدفاع عن، وتأمين، والحفاظ على سلامة موقع الجائزة، وكل موظفيه ووكلائه تجاه أي وكل مسؤولية قد تترتب على أي مطالبة ناجمة عن أي خرق من قبلك لهذه الشروط والأحكام، بما في ذلك التكاليف والرسوم المقررة لهيئة الدفاع أو المحامين، كما أنك توافق على التعاون الكامل في الدفاع ضد تلك المطالبات، وللجائزة الحق في أن يتولى على حسابه الخاص، الدفاع الحصري والتحكم في أي مسألة خاضعة، بخلاف ذلك، للتعويض من قبلك، وأنت توافق على عدم تسوية أي قضية إلا بموافقة خطية من قبل الجائزة.\r\n\r\nتعتبر سياسة الخصوصية الموضحة في هذه الصفحة، جزءاً من شروط استخدام الموقع الإلكتروني وأحكامه.\r\n\r\n\r\nجمع واستخدام المعلومات الإلكترونية\r\n\r\nتعمل الخوادم الخاصة بنا تلقائياً على التقاط وجمع عنوان بروتوكول الإنترنت الخاص بك عند زيارتك للموقع، إن عنوان بروتوكول الإنترنت الخاص بك هو الرقم الخاص بجهاز الكمبيوتر أو الجهاز اللوحي أو الهاتف الذكي الذي تستخدمه، والذي يسمح للأجهزة الأخرى الموصولة بشبكة الإنترنت بتحديد وجهة البيانات الصادرة عنها، لكن من دون التعرف عليك شخصياً.\r\nإن استخدامنا لبروتوكول الإنترنت الخاص بك يساعدنا على تشخيص المشكلات التي قد تحدث في الخادم الخاص بنا، وعلى إجراء الإحصاء اللازم لقياس استخدام الموقع، ونحن لا نسمح لأي جهة خارج إطار الفريق الفني المكلف من الجائزة بالاطلاع على بروتوكول الإنترنت الخاص بك.\r\nمن أجل تقديم خدمة أفضل، وموقع إلكتروني أكثر فاعلية، يمكن لبعض أقسام هذا الموقع استخدام برامج تعريف الارتباط (cookies) كجزء من التفاعل مع متصفحك، وهذا البرنامج هو عبارة عن ملف نصي صغير يرسل إلى القرص الصلب الخاص بك ليتمكن خادمنا من التعرف على الجهاز والمتصفح الذي تستخدمه لتحسين تعاملك مع موقعنا.\r\nلن يقوم برنامج تعريف الارتباط المرسل من قبلنا بمحاولة قراءة أي من المعلومات الخاصة الموجودة على قرصك الصلب، ونحن لا نقوم بتجميع هذه المعلومات من خلال هذا البرامج لمعرفة بيانات أو معلومات شخصية أخرى من أجل تحديد هويتك أو عنوان بريدك الإلكتروني.\r\nفي حال كانت زيارتك للموقع للحصول على خدمة أو معلومات محددة، فقد يطلب منك عند زيارتك لبعض أجزاء هذا الموقع، تقديم معلومات شخصية للتعريف بهويتك (مثل الاسم، رقم الهاتف، والعنوان،...)، وهي كلها معلومات ضرورية لإتمام معاملتك غير أن هذه المعلومات لن يتم مشاركتها أو إساءة استخدامها تحت أي ظرف، وفي حال رفضك تقديم تلك المعلومات، فللجائزة الحق في رفض تقديم تلك الخدمة، وفي كل الأحوال، فإننا لانزل ندعوك لزيارة موقعنا والاستفادة من المعلومات القيمة التي يوفرها.\r\n \r\n\r\nحماية المعلومات الشخصية\r\n\r\nباستخدامك لهذا الموقع فإنك توافق على شروط سياسة الخصوصية هذه، حيث تلتزم الجائزة من خلال إدارته لموقعه الإلكتروني، عند جمع معلومات شخصية عنك عندما تقوم بزيارة الموقع بأن يكون استخدام تلك المعلومات التي قدمتها، فقط من أجل إنجاز طلبك للحصول على معلومات أو خدمات عبر الموقع.\r\nتحتفظ جائزة الشارقة للتفوق والتميز التربوي بالحق في إجراء أي تعديل طفيف أو جذري لشروط سياسة الخصوصية من وقت لآخر دون الحاجة إلى تقديم إخطار، حيث يتم تعديل هذه السياسة ونشر هذه التعديلات بمجرد اعتمادها، لذا ننصحك بالاطلاع على هذه الصفحة من وقت لأخر لمعرفة التحديثات التي طرأت على سياسة الخصوصية، ولذلك فإن زيارتك واستخدامك لموقعنا بعد إدخال التعديلات على سياسة الخصوصية هذه، يعني قبولك لهذه التغييرات.\r\nلن تكون معلوماتك الشخصية متاحة إلا لموظفي الجائزة الذين يحتاجون للاطلاع على تلك المعلومات، ولن تكون تلك المعلومات متاحة لاطلاع الجمهور عليها بدون موافقتك على ذلك، وعلاوة على ذلك، لن يتم تبادل، أو تداول أي من تلك المعلومات أو بيعها لأي طرف آخر من دون موافقتك المسبقة، ولن يتم السماح بالوصول إلى المعلومات إلا لأولئك المؤهلين والمحترفين الذين يتولون تقديم خدمات الجائزة المتسقة مع تعاملاتك مع موقعنا.\r\n \r\n\r\nانتقال آمن للمعلومات\r\nهذا الموقع يمتلك إجراءات أمن لحماية المعلومات التي تقدمها لنا، فإننا نعمل على تشفير المعلومات التي تعتبر حساسة (مثل بياناتك الشخصية) أو البيانات التي يتعين الحفاظ على سريتها تماشياً مع المتطلبات القانونية.\r\n\r\n\r\nالمرجعية القانونية للجائزة\r\n\r\nيحق لجائزة الشارقة للتفوق والتميز التربوي اتخاذ التدابير التي يراها ملائمة لحماية أي فقدان أو إساءة استخدام أو تغيير للمعلومات الموجودة على الموقع الإلكتروني، وذلك دون أن تضمن الجائزة في هذه الحالة الاحتفاظ بسرية محتويات هذا الموقع الإلكتروني، ولا يعتبر مسؤولاً قانوناً عن أي ضرر قد تتعرض له أنت أو أي شخص نتيجة لانتهاك السرية بشأن المعلومات التي تكون قد نقلتها إلى الموقع.\r\nتكون قوانين دولة الإمارات العربية المتحدة وحدها هي القوانين واجبة التطبيق في كل ما يتعلق بالنزاعات التي قد تنشأ من جراء استخدام هذا الموقع الإلكتروني، أو أياً من أجزائه وأقسامه، كما تختص محاكم إمارة الشارقة حصرياً بالنظر في تلك النزاعات والبت فيها.",
                    EnglishText = "Your entry and use of the Sharjah Award for Excellence and Educational Excellence website is subject to the following terms and conditions, in addition to the laws of the United Arab Emirates related to dealing with websites and electronic platforms.\r\nYour access to the site means your acceptance of these terms and conditions, whether you are a registered user or not. By entering, browsing, and using the site, you have accepted, without restriction or condition, the terms and conditions of use contained in this document.\r\n\r\n \r\n\r\nDefinitions:\r\n\r\nCountry: United Arab Emirates.\r\nAward: Sharjah Award for Excellence and Educational Excellence.\r\nWebsite: The Sharjah Award for Excellence and Educational Excellence website on the Internet.\r\nLaw: Any or all laws issued and approved by the United Arab Emirates that relate to dealing with information technology and crimes related to it.\r\n \r\n\r\nAmending the agreement\r\nThe Award has the right to amend these terms and conditions, provided that notice of amendments is placed on this page. Amendments will enter into force as soon as they are announced, unless otherwise stated.\r\nYour repeated use of the site after these modifications are made means that you agree to the modifications, and you must make periodic visits to this page to review the updated or amended terms and conditions.\r\n\r\n \r\n\r\nAct\r\nYour entry and use of the site constitutes your agreement and acknowledgment to enter and use the site for lawful purposes only, and you are fully responsible for knowing and acting on any and all laws, regulations, rules and provisions related to your use of it. Once you enter the site, you agree to refrain from the following:\r\n\r\nEnter or publish any illegal content that includes discrimination, defamation, abuse, slander, or inappropriate material.\r\nUse the Site to impersonate other individuals or parties.\r\nUse the Site in order to commit an offense or encourage others to engage in any conduct that may constitute a criminal offense or give rise to civil liability.\r\nInsulting others, individuals or institutions, in any way.\r\nPartisanship or racism against others or insulting any race, religion, color, nationality or social status.\r\nUse the site to upload any material that contains programs that contain viruses, malicious programs, or any computer codes, files or programs that may alter, damage or impede the operation of the site or any device or program belonging to any person who accesses the site.\r\nInput, send, upload or broadcast any material that you do not have the right to broadcast or publish under any law or contractual relationship.\r\nAlter, damage, delete or disable any content on the Site.\r\nDamaging or disrupting any regular or electronic lines, channels, or means of communication or communication in any way.\r\nClaiming to represent any company, association, body, or public or private institution, or claiming to be connected to it, without being authorized to claim that relationship or that representation.\r\nPublish or broadcast any advertisement, promotional or marketing material for any product or service in any form of promotion or marketing.\r\nPost any material that infringes or conflicts with the intellectual property rights of others, or collect or store personal information about others.\r\n \r\n\r\nRegister\r\nSome parts and services of the site do not work and can only be accessed by registered members and/or allow the user to request support or services electronically by entering some personal information. Therefore, you agree that any information provided to us through those parts is true, complete and accurate information, and that you will not You register, or attempt to enter the site using or impersonating the name or capacity of another person, and that you do not claim to have a user name or user data that is not yours, or that the Award may find (according to its right to discretion) to be inappropriate.\r\n\r\n \r\n\r\nTermination of use\r\nThe Award has every right, as it deems appropriate, to prevent, terminate or suspend your access to and use of this site without notice and for any reason whatsoever, including violation of these terms and conditions or due to any behavior that the Award may deem to be contrary to the law or harmful to others, and in these cases You will no longer be able to access the site, and the award has the right to use every means available to implement this matter.\r\n\r\nLinks to other websites\r\nSome links on the site lead to other websites that are not operated by the Award, and it has no control over them. The Award also does not review or control the content of those sites, as the Award provides these links as a matter of convenience for the users and visitors of its site, and those other sites do not have any promotional or marketing content for goods or special services, but rather they are links to sites Related to the work of the award and/or providing services related to the work of the award to serve visitors and users of the site, and when you click on and choose a link to an external site, you are subject to the terms and conditions of that external site.\r\n\r\n \r\n\r\nContent\r\nThe Award reserves the right to monitor any content entered by you, but is not obligated to do so. Although the Award may not be able to monitor everything that is entered on the site, we reserve the right (but not the obligation) to delete, remove or edit any materials entered from the site. If you violate these terms and conditions, UAE and foreign copyright laws and international treaties protect the contents of this site, and you agree to abide by the copyright notices that appear on this site.\r\n\r\n \r\n\r\nCompensation\r\nYou agree to defend, insure, and maintain the integrity of the award website, and all its employees and agents against any and all liability that may arise from any claim resulting from any breach by you of these terms and conditions, including the costs and fees determined for the defense or lawyers, and you also agree You will cooperate fully in defending against such claims, and the Award has the right to assume, at its own expense, the exclusive defense and control of any matter otherwise subject to indemnification by you, and you agree not to settle any matter except with the written approval of the Award.\r\n\r\nThe privacy policy shown on this page is considered part of the terms and conditions of use of the website.\r\n\r\n\r\nCollection and use of electronic information\r\n\r\nOur servers automatically capture and collect your Internet Protocol address when you visit the site. Your Internet Protocol address is the number for the computer, tablet, or smartphone that you use, which allows other devices connected to the Internet to determine the destination of the data issued by it. But without getting to know you personally.\r\nOur use of your Internet Protocol helps us diagnose problems that may occur in our server, and to conduct the necessary statistics to measure the use of the site, and we do not allow any party outside the framework of the technical team assigned by the award to view your Internet Protocol.\r\nIn order to provide better service and a more effective website, some sections of this site may use cookies as part of the interaction with your browser. This program is a small text file sent to your hard disk so that our server can recognize your device and browser. which you use to improve your interaction with our site.\r\nThe cookie software sent by us will not attempt to read any of the private information on your hard drive, and we do not collect this information through this software to find out other personal data or information in order to determine your identity or email address.\r\nIf your visit to the site is to obtain a specific service or information, when you visit some parts of this site, you may be asked to provide personal information to identify yourself (such as name, phone number, address,...), which are all necessary information to complete your transaction, but this The information will not be shared or misused under any circumstances, and if you refuse to provide that information, the award has the right to refuse to provide that service. In any case, we still invite you to visit our website and benefit from the valuable information it provides.\r\n\r\n\r\nProtection of personal information\r\n\r\nBy using this website, you agree to the terms of this privacy policy, as the award, through its management of its website, is committed to collecting personal information about you when you visit the site, to use that information that you provided, only in order to fulfill your request for information or services through the site.\r\nThe Sharjah Award for Excellence and Educational Excellence reserves the right to make any minor or radical amendment to the terms of the privacy policy from time to time without the need to provide notification. This policy is amended and these amendments are published as soon as they are approved. Therefore, we advise you to check this page from time to time to find out the updates that have occurred. on the Privacy Policy. Therefore, your visit and use of our site after making changes to this Privacy Policy means that you accept these changes.\r\nYour personal information will only be available to award employees who need to see that information, and that information will not be available for public access without your consent. Moreover, none of that information will be exchanged, traded, or sold to any other party without your consent. Access to the information will only be granted to those qualified and professional people who provide award services consistent with your dealings with our website.\r\n \r\n\r\nSecure transmission of information\r\nThis site has security measures in place to protect the information you provide to us. We encrypt information that is considered sensitive (such as your personal data) or data that must be kept confidential in line with legal requirements.\r\n\r\n\r\nLegal reference for the award\r\n\r\nThe Sharjah Award for Educational Excellence and Excellence has the right to take the measures it deems appropriate to protect any loss, misuse, or change of information on the website, without the award in this case guaranteeing the confidentiality of the contents of this website, and it is not considered legally responsible for any damage you may be exposed to. You or any person as a result of a breach of confidentiality regarding information you have transmitted to the Site.\r\nThe laws of the United Arab Emirates alone are the applicable laws in all matters related to disputes that may arise as a result of the use of this website, or any of its parts and sections, and the courts of the Emirate of Sharjah have exclusive jurisdiction to consider and decide on these disputes.",
                    Type = Domain.Constants.OnePageText.OnePageTextType.TermsOfUse,
                    Slug = "Terms_Of_Use_Website"
                }, new OnePageText()
                {
                    Id = 4,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicText = "إن دخولك واستخدامك الموقع الإلكتروني لجائزة الشارقة للتفوق والتميز التربوي يخضع للشروط والأحكام الآتية، إضافة إلى قوانين دولة الإمارات العربية المتحدة المتعلقة بالتعامل مع المواقع والمنصات الإلكترونية.\r\nدخولك إلى الموقع يعني موافقتك على هذه الشروط والأحكام، سواءً كنت مستخدماً مسجلاً أو غيرمسجل. وبدخولك وتصفحك واستخدامك الموقع تكون قد قبلت دون قيد أو شرط، أحكام وشروط الاستخدام الواردة في هذه الوثيقة.\r\n\r\n \r\n\r\nتعريفات:\r\n\r\nالدولة: دولة الامارات العربية المتحدة.\r\nالجائزة: جائزة الشارقة للتفوق والتميز التربوي.\r\nالموقع: موقع جائزة الشارقة للتفوق والتميز التربوي على الشبكة العنكبوتية (الانترنت).\r\nالقانون: هي أي أو كل قانون تصدره وتقره دولة الامارات العربية المتحدة التي يتعلق بالتعامل مع تقنية المعلومات، والجرائم المتعلقة بها.\r\n \r\n\r\nتعديل الاتفاقية\r\nللجائزة الحق في تعديل هذه الشروط والأحكام على أن يتم وضع إشعار بحدوث تعديلات على هذه الصفحة، وتدخل التعديلات حيز النفاذ بمجرد إعلانها ما لم ينَصّ على خلاف ذلك.\r\nإن استخدامك المتكرر للموقع بعد إحداث تلك التعديلات يعني موافقتك على التعديلات، ويتعين عليك القيام بزيارات دورية لهذه الصفحة لمراجعة الشروط والأحكام المستحدثة أو المعدلة.\r\n\r\n \r\n\r\nالتصرف\r\nإن دخولك واستخدامك للموقع يعتبر موافقة وإقرار منك على دخول واستخدام الموقع لأغراض مشروعة فقط، وأنت مسؤول مسؤولية كاملة عن العلم والعمل بأي من وكل القوانين والأنظمة والقواعد والأحكام المتعلقة باستخدامك له، وبمجرد دخولك إلى الموقع فإنك توافق على الامتناع عن ما يلي:\r\n\r\nإدخال أو نشر أي محتويات غير قانونية تتضمن تمييزاً أو تشهيراً أو إساءة أو قذفاً أو مواد غير لائقة.\r\nاستخدام الموقع من أجل انتحال شخصيات أو أطراف أخرى.\r\nاستخدام الموقع من أجل ارتكاب جرم أو تشجيع الآخرين على التورط في أي تصرف قد يعد جريمة أو ينطوي على مسؤولية مدنية.\r\nالإساءة للآخرين أفراداً أو مؤسسات بأي شكل من الإساءة.\r\nالتحزب أو العنصرية ضد الآخرين أو الإساءة إلى أي عرق أو دين أو لون أو جنسية أو وضع اجتماعي.\r\nاستخدام الموقع لتحميل أي مادة فيها برامج تحتوي على فيروسات، أو برامج خبيثة، أو أي شفرات حاسوبية أو ملفات أو برامج قد تعمل على تغيير أو إتلاف أو إعاقة عمل الموقع أو أي جهاز أو برنامج عائد إلى أي شخص يدخل إلى الموقع.\r\nإدخال أو إرسال أو تحميل أو بث أي مواد لا يحق لك بثها أو نشرها بموجب أي قانون أو علاقة تعاقدية.\r\nتغيير أو إتلاف أو شطب أو تعطيل أي محتوى على الموقع.\r\nإتلاف أو تعطيل أي من خطوط أو قنوات أو وسائل الاتصال أو التواصل الاعتيادية أو الإلكترونية بأي شكل كان.\r\nالادعاء بتمثيل أي شركة أو جمعية أو هيئة أو مؤسسة عامة أو خاصة أو الادعاء بأنك مرتبط بها، وذلك دون أن تكون مخولاً بادعاء تلك العلاقة أو ذلك التمثيل.\r\nنشر أو بث أي إعلان أو مادة دعائية أو تسويقية لأي منتج أو خدمة بأي شكل من أشكال الترويج أو التسويق.\r\nنشر أي مادة تتنافى أو تتعارض مع حقوق الملكية الفكرية للآخرين، أو جمع أو تخزين المعلومات الشخصية عن الآخرين.\r\n \r\n\r\nالتسجيل\r\nبعض أجزاء وخدمات الموقع لا تعمل ولا يمكن الوصول اليها إلا للأعضاء المسجلين و/ أو تتيح للمستخدم طلب الدعم أو الخدمات إلكترونياً عبر إدخال بعض المعلومات الشخصية، لذا ، فأنت توافق على أن أي معلومات تقدم لنا عبر تلك الأجزاء هي معلومات صحيحة وكاملة ودقيقة، وأنك لن تقوم بالتسجيل، أو تحاول دخول الموقع مستخدماً أو منتحلا اسم أو صفة شخص آخر، وأنك لم تدعي بامتلاكك اسم مستخدم أو بيانات مستخدم ليست لك، أو قد ترى الجائزة أنه (وفق حقه في حرية التصرف)، بأنه غير مناسب.\r\n\r\n \r\n\r\nإنهاء الاستخدام\r\nللجائزة كل الحق، وفق ما يراه مناسباً، منع أو إنهاء أو تعليق دخولك إلى واستخدامك لهذا الموقع من دون إشعار ولأي سبب كان، بما في ذلك انتهاك هذه الشروط والأحكام أو بسبب أي تصرف قد يرى للجائزة أنه مخالف للقانون أو مضر بالآخرين، وفي هذه الحالات لن يعود بإمكانك الدخول إلى الموقع، وللجائزة الحق في استخدام كل وسيلة متاحة لتطبيق هذا الأمر.\r\n\r\n\r\nوصلات المواقع الأخرى\r\nبعض الوصلات على الموقع تقود إلى مواقع إلكترونية أخرى لا يتم تشغيلها من قبل الجائزة، وليس له السيطرة عليها. كما أن الجائزة لا يقوم بمراجعة المحتوى الخاص بتلك المواقع أو التحكم بها، حيث إن الجائزة يوفر تلك الوصلات من باب التسهيل على مستخدمي وزوار موقعه، كما أن تلك المواقع الأخرى ليست لها أي مضامين ترويجية أو تسويقية خاصة بالسلع أو خدمات خاصة، إنما هي وصلات لمواقع ذات صلة بعمل الجائزة و / أو تقدم خدمات تتعلق بعمل الجائزة لخدمة زوار ومستخدمي الموقع، وعند الضغط على واختيارك وصلة خاصة بموقع خارجي، فإنك تكون خاضعاً للشروط والأحكام الخاصة بذلك الموقع الخارجي.\r\n\r\n \r\n\r\nالمحتوى\r\nتحتفظ الجائزة بالحق في مراقبة أي محتوى يتم إدخاله من قبلك، غير أنه ليس ملزماً بذلك، ومع أن الجائزة قد لا يستطيع مراقبة كل ما يتم إدخاله على الموقع، فإننا نحتفظ بالحق (من دون التزام) في شطب أو إزالة أو تحرير أي مواد مدخلة من شأنها انتهاك هذه الشروط والأحكام، إن قوانين حقوق النشر والتأليف الإماراتية والأجنبية والمعاهدات الدولية تحمي محتويات هذا الموقع، وأنت توافق على الالتزام بإشعارات حقوق النشر التي تظهر على هذا الموقع.\r\n\r\n \r\n\r\nالتعويض\r\nأنت توافق على الدفاع عن، وتأمين، والحفاظ على سلامة موقع الجائزة، وكل موظفيه ووكلائه تجاه أي وكل مسؤولية قد تترتب على أي مطالبة ناجمة عن أي خرق من قبلك لهذه الشروط والأحكام، بما في ذلك التكاليف والرسوم المقررة لهيئة الدفاع أو المحامين، كما أنك توافق على التعاون الكامل في الدفاع ضد تلك المطالبات، وللجائزة الحق في أن يتولى على حسابه الخاص، الدفاع الحصري والتحكم في أي مسألة خاضعة، بخلاف ذلك، للتعويض من قبلك، وأنت توافق على عدم تسوية أي قضية إلا بموافقة خطية من قبل الجائزة.\r\n\r\nتعتبر سياسة الخصوصية الموضحة في هذه الصفحة، جزءاً من شروط استخدام الموقع الإلكتروني وأحكامه.\r\n\r\n\r\nجمع واستخدام المعلومات الإلكترونية\r\n\r\nتعمل الخوادم الخاصة بنا تلقائياً على التقاط وجمع عنوان بروتوكول الإنترنت الخاص بك عند زيارتك للموقع، إن عنوان بروتوكول الإنترنت الخاص بك هو الرقم الخاص بجهاز الكمبيوتر أو الجهاز اللوحي أو الهاتف الذكي الذي تستخدمه، والذي يسمح للأجهزة الأخرى الموصولة بشبكة الإنترنت بتحديد وجهة البيانات الصادرة عنها، لكن من دون التعرف عليك شخصياً.\r\nإن استخدامنا لبروتوكول الإنترنت الخاص بك يساعدنا على تشخيص المشكلات التي قد تحدث في الخادم الخاص بنا، وعلى إجراء الإحصاء اللازم لقياس استخدام الموقع، ونحن لا نسمح لأي جهة خارج إطار الفريق الفني المكلف من الجائزة بالاطلاع على بروتوكول الإنترنت الخاص بك.\r\nمن أجل تقديم خدمة أفضل، وموقع إلكتروني أكثر فاعلية، يمكن لبعض أقسام هذا الموقع استخدام برامج تعريف الارتباط (cookies) كجزء من التفاعل مع متصفحك، وهذا البرنامج هو عبارة عن ملف نصي صغير يرسل إلى القرص الصلب الخاص بك ليتمكن خادمنا من التعرف على الجهاز والمتصفح الذي تستخدمه لتحسين تعاملك مع موقعنا.\r\nلن يقوم برنامج تعريف الارتباط المرسل من قبلنا بمحاولة قراءة أي من المعلومات الخاصة الموجودة على قرصك الصلب، ونحن لا نقوم بتجميع هذه المعلومات من خلال هذا البرامج لمعرفة بيانات أو معلومات شخصية أخرى من أجل تحديد هويتك أو عنوان بريدك الإلكتروني.\r\nفي حال كانت زيارتك للموقع للحصول على خدمة أو معلومات محددة، فقد يطلب منك عند زيارتك لبعض أجزاء هذا الموقع، تقديم معلومات شخصية للتعريف بهويتك (مثل الاسم، رقم الهاتف، والعنوان،...)، وهي كلها معلومات ضرورية لإتمام معاملتك غير أن هذه المعلومات لن يتم مشاركتها أو إساءة استخدامها تحت أي ظرف، وفي حال رفضك تقديم تلك المعلومات، فللجائزة الحق في رفض تقديم تلك الخدمة، وفي كل الأحوال، فإننا لانزل ندعوك لزيارة موقعنا والاستفادة من المعلومات القيمة التي يوفرها.\r\n \r\n\r\nحماية المعلومات الشخصية\r\n\r\nباستخدامك لهذا الموقع فإنك توافق على شروط سياسة الخصوصية هذه، حيث تلتزم الجائزة من خلال إدارته لموقعه الإلكتروني، عند جمع معلومات شخصية عنك عندما تقوم بزيارة الموقع بأن يكون استخدام تلك المعلومات التي قدمتها، فقط من أجل إنجاز طلبك للحصول على معلومات أو خدمات عبر الموقع.\r\nتحتفظ جائزة الشارقة للتفوق والتميز التربوي بالحق في إجراء أي تعديل طفيف أو جذري لشروط سياسة الخصوصية من وقت لآخر دون الحاجة إلى تقديم إخطار، حيث يتم تعديل هذه السياسة ونشر هذه التعديلات بمجرد اعتمادها، لذا ننصحك بالاطلاع على هذه الصفحة من وقت لأخر لمعرفة التحديثات التي طرأت على سياسة الخصوصية، ولذلك فإن زيارتك واستخدامك لموقعنا بعد إدخال التعديلات على سياسة الخصوصية هذه، يعني قبولك لهذه التغييرات.\r\nلن تكون معلوماتك الشخصية متاحة إلا لموظفي الجائزة الذين يحتاجون للاطلاع على تلك المعلومات، ولن تكون تلك المعلومات متاحة لاطلاع الجمهور عليها بدون موافقتك على ذلك، وعلاوة على ذلك، لن يتم تبادل، أو تداول أي من تلك المعلومات أو بيعها لأي طرف آخر من دون موافقتك المسبقة، ولن يتم السماح بالوصول إلى المعلومات إلا لأولئك المؤهلين والمحترفين الذين يتولون تقديم خدمات الجائزة المتسقة مع تعاملاتك مع موقعنا.\r\n \r\n\r\nانتقال آمن للمعلومات\r\nهذا الموقع يمتلك إجراءات أمن لحماية المعلومات التي تقدمها لنا، فإننا نعمل على تشفير المعلومات التي تعتبر حساسة (مثل بياناتك الشخصية) أو البيانات التي يتعين الحفاظ على سريتها تماشياً مع المتطلبات القانونية.\r\n\r\n\r\nالمرجعية القانونية للجائزة\r\n\r\nيحق لجائزة الشارقة للتفوق والتميز التربوي اتخاذ التدابير التي يراها ملائمة لحماية أي فقدان أو إساءة استخدام أو تغيير للمعلومات الموجودة على الموقع الإلكتروني، وذلك دون أن تضمن الجائزة في هذه الحالة الاحتفاظ بسرية محتويات هذا الموقع الإلكتروني، ولا يعتبر مسؤولاً قانوناً عن أي ضرر قد تتعرض له أنت أو أي شخص نتيجة لانتهاك السرية بشأن المعلومات التي تكون قد نقلتها إلى الموقع.\r\nتكون قوانين دولة الإمارات العربية المتحدة وحدها هي القوانين واجبة التطبيق في كل ما يتعلق بالنزاعات التي قد تنشأ من جراء استخدام هذا الموقع الإلكتروني، أو أياً من أجزائه وأقسامه، كما تختص محاكم إمارة الشارقة حصرياً بالنظر في تلك النزاعات والبت فيها.",
                    EnglishText = "Your entry and use of the Sharjah Award for Excellence and Educational Excellence website is subject to the following terms and conditions, in addition to the laws of the United Arab Emirates related to dealing with websites and electronic platforms.\r\nYour access to the site means your acceptance of these terms and conditions, whether you are a registered user or not. By entering, browsing, and using the site, you have accepted, without restriction or condition, the terms and conditions of use contained in this document.\r\n\r\n \r\n\r\nDefinitions:\r\n\r\nCountry: United Arab Emirates.\r\nAward: Sharjah Award for Excellence and Educational Excellence.\r\nWebsite: The Sharjah Award for Excellence and Educational Excellence website on the Internet.\r\nLaw: Any or all laws issued and approved by the United Arab Emirates that relate to dealing with information technology and crimes related to it.\r\n \r\n\r\nAmending the agreement\r\nThe Award has the right to amend these terms and conditions, provided that notice of amendments is placed on this page. Amendments will enter into force as soon as they are announced, unless otherwise stated.\r\nYour repeated use of the site after these modifications are made means that you agree to the modifications, and you must make periodic visits to this page to review the updated or amended terms and conditions.\r\n\r\n \r\n\r\nAct\r\nYour entry and use of the site constitutes your agreement and acknowledgment to enter and use the site for lawful purposes only, and you are fully responsible for knowing and acting on any and all laws, regulations, rules and provisions related to your use of it. Once you enter the site, you agree to refrain from the following:\r\n\r\nEnter or publish any illegal content that includes discrimination, defamation, abuse, slander, or inappropriate material.\r\nUse the Site to impersonate other individuals or parties.\r\nUse the Site in order to commit an offense or encourage others to engage in any conduct that may constitute a criminal offense or give rise to civil liability.\r\nInsulting others, individuals or institutions, in any way.\r\nPartisanship or racism against others or insulting any race, religion, color, nationality or social status.\r\nUse the site to upload any material that contains programs that contain viruses, malicious programs, or any computer codes, files or programs that may alter, damage or impede the operation of the site or any device or program belonging to any person who accesses the site.\r\nInput, send, upload or broadcast any material that you do not have the right to broadcast or publish under any law or contractual relationship.\r\nAlter, damage, delete or disable any content on the Site.\r\nDamaging or disrupting any regular or electronic lines, channels, or means of communication or communication in any way.\r\nClaiming to represent any company, association, body, or public or private institution, or claiming to be connected to it, without being authorized to claim that relationship or that representation.\r\nPublish or broadcast any advertisement, promotional or marketing material for any product or service in any form of promotion or marketing.\r\nPost any material that infringes or conflicts with the intellectual property rights of others, or collect or store personal information about others.\r\n \r\n\r\nRegister\r\nSome parts and services of the site do not work and can only be accessed by registered members and/or allow the user to request support or services electronically by entering some personal information. Therefore, you agree that any information provided to us through those parts is true, complete and accurate information, and that you will not You register, or attempt to enter the site using or impersonating the name or capacity of another person, and that you do not claim to have a user name or user data that is not yours, or that the Award may find (according to its right to discretion) to be inappropriate.\r\n\r\n \r\n\r\nTermination of use\r\nThe Award has every right, as it deems appropriate, to prevent, terminate or suspend your access to and use of this site without notice and for any reason whatsoever, including violation of these terms and conditions or due to any behavior that the Award may deem to be contrary to the law or harmful to others, and in these cases You will no longer be able to access the site, and the award has the right to use every means available to implement this matter.\r\n\r\nLinks to other websites\r\nSome links on the site lead to other websites that are not operated by the Award, and it has no control over them. The Award also does not review or control the content of those sites, as the Award provides these links as a matter of convenience for the users and visitors of its site, and those other sites do not have any promotional or marketing content for goods or special services, but rather they are links to sites Related to the work of the award and/or providing services related to the work of the award to serve visitors and users of the site, and when you click on and choose a link to an external site, you are subject to the terms and conditions of that external site.\r\n\r\n \r\n\r\nContent\r\nThe Award reserves the right to monitor any content entered by you, but is not obligated to do so. Although the Award may not be able to monitor everything that is entered on the site, we reserve the right (but not the obligation) to delete, remove or edit any materials entered from the site. If you violate these terms and conditions, UAE and foreign copyright laws and international treaties protect the contents of this site, and you agree to abide by the copyright notices that appear on this site.\r\n\r\n \r\n\r\nCompensation\r\nYou agree to defend, insure, and maintain the integrity of the award website, and all its employees and agents against any and all liability that may arise from any claim resulting from any breach by you of these terms and conditions, including the costs and fees determined for the defense or lawyers, and you also agree You will cooperate fully in defending against such claims, and the Award has the right to assume, at its own expense, the exclusive defense and control of any matter otherwise subject to indemnification by you, and you agree not to settle any matter except with the written approval of the Award.\r\n\r\nThe privacy policy shown on this page is considered part of the terms and conditions of use of the website.\r\n\r\n\r\nCollection and use of electronic information\r\n\r\nOur servers automatically capture and collect your Internet Protocol address when you visit the site. Your Internet Protocol address is the number for the computer, tablet, or smartphone that you use, which allows other devices connected to the Internet to determine the destination of the data issued by it. But without getting to know you personally.\r\nOur use of your Internet Protocol helps us diagnose problems that may occur in our server, and to conduct the necessary statistics to measure the use of the site, and we do not allow any party outside the framework of the technical team assigned by the award to view your Internet Protocol.\r\nIn order to provide better service and a more effective website, some sections of this site may use cookies as part of the interaction with your browser. This program is a small text file sent to your hard disk so that our server can recognize your device and browser. which you use to improve your interaction with our site.\r\nThe cookie software sent by us will not attempt to read any of the private information on your hard drive, and we do not collect this information through this software to find out other personal data or information in order to determine your identity or email address.\r\nIf your visit to the site is to obtain a specific service or information, when you visit some parts of this site, you may be asked to provide personal information to identify yourself (such as name, phone number, address,...), which are all necessary information to complete your transaction, but this The information will not be shared or misused under any circumstances, and if you refuse to provide that information, the award has the right to refuse to provide that service. In any case, we still invite you to visit our website and benefit from the valuable information it provides.\r\n\r\n\r\nProtection of personal information\r\n\r\nBy using this website, you agree to the terms of this privacy policy, as the award, through its management of its website, is committed to collecting personal information about you when you visit the site, to use that information that you provided, only in order to fulfill your request for information or services through the site.\r\nThe Sharjah Award for Excellence and Educational Excellence reserves the right to make any minor or radical amendment to the terms of the privacy policy from time to time without the need to provide notification. This policy is amended and these amendments are published as soon as they are approved. Therefore, we advise you to check this page from time to time to find out the updates that have occurred. on the Privacy Policy. Therefore, your visit and use of our site after making changes to this Privacy Policy means that you accept these changes.\r\nYour personal information will only be available to award employees who need to see that information, and that information will not be available for public access without your consent. Moreover, none of that information will be exchanged, traded, or sold to any other party without your consent. Access to the information will only be granted to those qualified and professional people who provide award services consistent with your dealings with our website.\r\n \r\n\r\nSecure transmission of information\r\nThis site has security measures in place to protect the information you provide to us. We encrypt information that is considered sensitive (such as your personal data) or data that must be kept confidential in line with legal requirements.\r\n\r\n\r\nLegal reference for the award\r\n\r\nThe Sharjah Award for Educational Excellence and Excellence has the right to take the measures it deems appropriate to protect any loss, misuse, or change of information on the website, without the award in this case guaranteeing the confidentiality of the contents of this website, and it is not considered legally responsible for any damage you may be exposed to. You or any person as a result of a breach of confidentiality regarding information you have transmitted to the Site.\r\nThe laws of the United Arab Emirates alone are the applicable laws in all matters related to disputes that may arise as a result of the use of this website, or any of its parts and sections, and the courts of the Emirate of Sharjah have exclusive jurisdiction to consider and decide on these disputes.",
                    Type = Domain.Constants.OnePageText.OnePageTextType.TermsOfUse,
                    Slug = "Terms_Of_Use_Subscriber"
                });
            #endregion
            #region News
            modelBuilder.Entity<News>()
                .HasData(new News()
                {
                    Id = 1,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicTitle = "سلطان بن أحمد يكرّم فائزي «جائزة الشارقة للتفوق التربوي»",
                    ArabicDescription = "كرّم سموّ الشيخ سلطان بن أحمد بن سلطان القاسمي، نائب حاكم إمارة الشارقة، صباح الثلاثاء، الفائزين بجائزة الشارقة للتفوق والتميز التربوي في دورتها التاسعة والعشرين، في مركز الجواهر للمناسبات والمؤتمرات.\r\n\r\n\r\nاستهل الحفل بالسلام الوطني لدولة الإمارات، أعقبه تلاوة آيات بيّنات من الذكر الحكيم، ألقت بعدها الدكتورة محدّثة الهاشمي، رئيسة هيئة الشارقة للتعليم الخاص، كلمة قدمت فيها الشكر والامتنان إلى صاحب السموّ الشيخ الدكتور سلطان بن محمد القاسمي، عضو المجلس الأعلى، حاكم الشارقة، على دعمه المطلق، لكل ما يعزّز الواقع التعليمي والثقافي في الإمارة.\r\n\r\n\r\nكما قدمت الشكر والعرفان إلى سموّ الشيخ سلطان بن أحمد القاسمي، على تشريفه للحفل وتكريم الفائزين والفائزات.\r\n\r\n \r\n\r\nوأشارت إلى أن الجائزة، وهي الأولى تاريخياً التي تحتفي بالطلبة، لا تعدّ رمزاً للتفوق والإلهام فحسب، بل منصة تنطلق بها جسور الإبداع والبناء في مستقبل المنظومة التربوية.\r\n\r\n\r\nمشيدةً بمستوى مشاركات الطلبة في هذه الدورة التي بلغت 64%، ما يعكس نجاح الجائزة في تحقيق أهم أهدافها في تشجيع الطلبة وتحفيزهم على التطور والإبداع والابتكار.\r\n\r\n\r\nواختتمت محدّثة الهاشمي، كلمتها بتهنئة الفائزين الذين بذلوا جهوداً كبيرة، وعملوا بتفانٍ لتحقيق التميز، وأصبحوا يمثلون نماذج طيبة لروح العطاء الملهم في التعليم. لافتةً إلى أهمية الجائزة في تحفيز العقول، ونشر ثقافة التميّز، ومساندة المتميزين في الميدان التربوي بكل شرائحه وفئاته، والمجتمع المحلي. كما قدمت الشكر إلى لجنة التحكيم.\r\n\r\n\r\nوشاهد الحضور عرضاً عن مسيرة الجائزة، خلال السنوات الماضية وتطورها، وأدوارها في تعزيز التفوق التربوي والتعليمي في إمارة الشارقة.\r\n\r\n\r\nوتفضل سموّ نائب حاكم الشارقة، في نهاية الحفل بتكريم الفائزين، حيث فازت «مؤسسة الإمارات للتعليم المدرسي»، بجائزة أفضل جهة تعليمية.\r\n\r\n\r\nوفاز في الفئة الأولى للأفراد المتميزين، القائد التربوي المتميز: أميرة آل محمد، بالمركز الأول، ومريم اللوغاني، بالمركز الثاني. وفي فئة المعلم المتميز، فازت سها شعشاعة، بالمركز الأول، ومؤمن يونس، بالمركز الثاني، وعنود الحمادي، بالمركز الثالث، وخفية حمودة الكتبي، بالمركز الرابع.\r\n\r\n\r\nوفي فئة الوظائف الداعمة المتميزة، فازت خولة البلوشي، بالمركز الأول، وإكرامي سيد، بالمركز الثاني. وفي فئة ولي الأمر المتميّز، فاز أحمد مصبح النيادي.\r\n\r\n\r\nوفي فئة الطالب المتميّز في الصفوف من الثالث إلى الثاني عشر، فاز: ناكشاترا انطوني، وكانشيكا مانيكاندان، وشريماد سريراج، من الصف الثالث. وسليمان السيد، وهند النقبي، ومريم البدري، من الرابع. ونيلينا جونيش، وبريانكا جوبينات، وشمّا المرزوقي، من الخامس. وعلي حميد آل علي، وشهد السويدان، وسيلينا حامد، وسانفي راو، من السادس. وأنانيا أماني، ومير أظهار، وشهد المزروعي، من السابع. ومحمد النقبي، وهيام الحساني، من الثامن، وديتي غاندي، وسامفورد توماس، وجاش سانديب، من التاسع. وموزة الشامسي، ومريم الشحّي، وأنوباما بادينشاريتيل، من العاشر. وأديتيا غاندي، من الحادي عشر.\r\n\r\n\r\nوفاز في فئة الطالب المتميز من الفئات الخاصة: مريم المرزوقي، وشوق الشامسي، ومحمد العبدولي، وخميس العبدولي.\r\n\r\n\r\nوفي فئة المؤسسات المتميزة، فازت «مدرسة جيمس ميلينيوم»، الخاصة بفئة المؤسسات التعليمية المتميزة. وفي فرق العمل المتميزة، فاز مجلس طلبة المدرسة الثانوية النموذجية للبنين في فئة المجلس المتميّز.\r\n\r\n\r\nحضر الحفل بجانب سموّ نائب حاكم الشارقة: الشيخ المهندس محمد بن عبدالله بن ماجد القاسمي، مدير دائرة شؤون البلديات، والشيخ عبدالله بن محمد القاسمي، مدير هيئة الشؤون الإسلامية والأوقاف، وحميد محمد القطامي، رئيس مجلس أمناء مؤسسة حمدان بن راشد آل مكتوم للعلوم الطبية والتربوية، وجمال الطريفي، رئيس الجامعة القاسمية، والدكتورة محدّثة الهاشمي رئيسة هيئة الشارقة للتعليم الخاص، وعيسى الحزامي، رئيس مجلس الشارقة الرياضي، وعدد من المسؤولين والمديرين العامين، ومديري الدوائر المحلية، والتربويين ومديري المدارس والمعلمين.\r\n\r\n \r\n\r\nالمصدر: الخليج",
                    EnglishTitle = "Sultan bin Ahmed honors the winners of the “Sharjah Award for Educational Excellence”",
                    EnglishDescription = "His Highness Sheikh Sultan bin Ahmed bin Sultan Al Qasimi, Deputy Ruler of the Emirate of Sharjah, on Tuesday morning, honored the winners of the Sharjah Award for Educational Excellence and Excellence in its twenty-ninth session, at Al Jawaher Center for Events and Conferences.\r\n\r\n\r\nThe ceremony began with the national anthem of the UAE, followed by the recitation of clear verses from the Holy Quran, after which Dr. Muhadditha Al Hashemi, President of the Sharjah Private Education Authority, delivered a speech in which she extended thanks and gratitude to His Highness Sheikh Dr. Sultan bin Muhammad Al Qasimi, Member of the Supreme Council, Ruler of Sharjah, for His absolute support for everything that enhances the educational and cultural reality in the emirate.\r\n\r\n\r\nShe also extended thanks and gratitude to His Highness Sheikh Sultan bin Ahmed Al Qasimi, for honoring the ceremony and honoring the winners.\r\n\r\n \r\n\r\nShe pointed out that the award, which is the first in history to celebrate students, is not only a symbol of excellence and inspiration, but also a platform from which bridges of creativity and building in the future of the educational system will be launched.\r\n\r\n\r\nShe praised the level of student participation in this course, which reached 64%, which reflects the success of the award in achieving its most important goals of encouraging students and motivating them to develop, create and innovate.\r\n\r\n\r\nAl-Hashemi concluded her speech by congratulating the winners who made great efforts, worked with dedication to achieve excellence, and became good examples of the spirit of inspiring giving in education. Pointing to the importance of the award in stimulating minds, spreading the culture of excellence, and supporting distinguished people in the educational field in all its segments and categories, and the local community. She also thanked the jury.\r\n\r\n\r\nThe audience watched a presentation about the award’s progress over the past years, its development, and its roles in promoting educational excellence in the Emirate of Sharjah.\r\n\r\n\r\nAt the end of the ceremony, His Highness the Deputy Ruler of Sharjah honored the winners, as the Emirates School Education Foundation won the Best Educational Institution award.\r\n\r\n\r\nIn the first category of distinguished individuals, the distinguished educational leader: Amira Al Muhammad, won first place, and Maryam Al-Loughani, won second place. In the Distinguished Teacher category, Suha Shasha’a won first place, Moamen Younis won second place, Anoud Al Hammadi won third place, and Khafiya Hamouda Al Ketbi won fourth place.\r\n\r\n\r\nIn the Outstanding Support Jobs category, Khawla Al Balushi won first place, and Ekrami Sayed won second place. In the Distinguished Parent category, Ahmed Musabih Al Neyadi won.\r\n\r\n\r\nIn the Outstanding Student category in grades three to twelve, Nakshatra Anthony, Kanshika Manikandan, and Shrimad Sriraj, from third grade, won. Suleiman Al-Sayyed, Hind Al-Naqbi, and Maryam Al-Badri, from the fourth. And Nelina Gunesh, Priyanka Gobinath, and Shamma Al Marzouqi, from the fifth. Ali Hamid Al Ali, Shahad Al-Suwaidan, Selina Hamed, and Saanvi Rao, from the sixth. Ananya Amani, Mir Azhar, and Shahad Al Mazrouei, from the seventh. Muhammad Al-Naqbi and Hiyam Al-Hassani, from the eighth, and Diti Gandhi, Samford Thomas, and Jash Sandeep, from the ninth. Moza Al Shamsi, Maryam Al Shehhi, and Anupama Badincharitil, from the 10th. and Aditya Gandhi, from the 11th.\r\n\r\n\r\nThe winners in the Outstanding Student category from the special categories were: Mariam Al Marzouqi, Shouq Al Shamsi, Muhammad Al Abdouli, and Khamis Al Abdouli.\r\n\r\n\r\nIn the Distinguished Institutions category, GEMS Millennium Private School won the Distinguished Educational Institutions category. In the distinguished work teams, the Student Council of the Model Secondary School for Boys won in the Distinguished Council category.\r\n\r\n\r\nThe ceremony was attended, alongside His Highness the Deputy Ruler of Sharjah: Sheikh Engineer Mohammed bin Abdullah bin Majid Al Qasimi, Director of the Department of Municipalities Affairs, Sheikh Abdullah bin Mohammed Al Qasimi, Director of the Islamic Affairs and Endowments Authority, and Humaid Mohammed Al Qatami, Chairman of the Board of Trustees of the Hamdan Bin Rashid Al Maktoum Foundation for Medical and Educational Sciences. Jamal Al-Tarifi, President of Al Qasimia University, Dr. Muhaddith Al-Hashimi, President of the Sharjah Private Education Authority, Issa Al-Hazami, Chairman of the Sharjah Sports Council, and a number of officials, general directors, directors of local departments, educators, school principals, and teachers.\r\n\r\n \r\n\r\nSource: Al Khaleej",
                    Image = "https://award-shj.ae/media/n1lb4exq/screenshot-2024-03-07-121511.png?anchor=center&mode=crop&width=593&height=338&rnd=133542874516370000",
                    CycleId = 1
                }, new News()
                {
                    Id = 2,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicTitle = "إطلاق «جائزة الشارقة للتفوق والتميز التربوي» الدورة 29",
                    ArabicDescription = "الشارقة: أمير السني\r\n\r\nأعلنت لجنة «جائزة الشارقة للتفوق والتميز التربوي» و«مجالس أولياء أمور الطلبة والطالبات»، إطلاق الدورة 29 للجائزة، خلال مؤتمر صحفي عقدته في «بيت الحكمة».\r\n\r\nحضر المؤتمر محمد الملّا، الأمين العام للجنة، وعلياء الحوسني، رئيسة لجنة الجائزة، وعدد من الشخصيات من المؤسسات ذات الصلة، والشركاء، ومنسقو الجائزة، وأعضاء اللجان التطويرية، وعدد من الإعلاميين.\r\n\r\nوقال الملّا إن إطلاق الدورة 29 هذا العام، جاء استمراراً لمسيرة الجائزة التربوية المتميزة، منذ إنشائها عام 1994 برعاية صاحب السموّ الشيخ الدكتور سلطان بن محمد القاسمي، عضو المجلس الأعلى حاكم الشارقة، ولدورها الكبير في إبراز الكفايات التعليمية المعطاءة التي قدمت مساهمات كبيرة في حقل التعليم، ولها بصمات واضحة، في النهوض به.\r\n\r\nوأضاف أن الجائزة، تستهدف رسالتها مهمّة الارتقاء بالعمل التربوي، في مراحله كافة، بتكريم المتميزين والمبدعين من المجالات التعليمية والتربوية المختلفة، إلى جانب نشر ثقافة التّميّز والابتكار، وتهيئة مناخ فكريّ نموذجيّ للميدان التّربوي بكلّ فئاته المبدعة المتميزة بطرحها لرؤية طموحة جديدة، تتكامل مع إستراتيجيتها وأهدافها المستقبلية الرائدة.\r\n\r\nوأوضح أن الفئات المستهدفة في الجائزة ثلاث: الأفراد المتميزون وضمت «المعلم المتميز»، و«القائد التربوي المتميز» (بفرعيه القيادة العليا والقيادة الوسطى)، و«الطالب المتميز» و«الطالب المتميز من الفئات الخاصة»، و«الوظائف الداعمة المتميزة» و«ولي الأمرالمتميز».\r\n\r\nوتضم الثانية المؤسسات المتميزة «المدرسة المتميزة»، و«الحضانات المتميزة»، و«المؤسسات والشراكات الداعمة للتعليم». وتضمّ الثالثة فرق العمل وشمل «فرق العمل المؤسسية المتميزة»، و«مجلس الطلبة المتميز»، و«فرق العمل المشتركة»، و«مجلس أولياء الأمور المتميز».\r\n\r\nوكشف الأمين العام، جائزة جديدة لهذا العام وهي «جوهرة اللغة العربية»، لأهمية اللغة العربية، وضرورة تربية النشء على إتقانها والمحافظة عليها، وتجسيداً للاهتمام الكبير الذي يوليه صاحب السموّ حاكم الشارقة باللغة العربية، بدعمه وتسخير كل الإمكانات للحفاظ عليها.\r\n\r\nوقالت علياء الحوسني: إن الجائزة تواصل أهدافها الطموحة لاستشراف المستقبل، والمساهمة في تطوير الميدان التربوي دورة إثر دورة، وبناء كوادر تربوية متميزة متخذة من الإبداع والابتكار والتّميّز والمنهج العلمي نهجاً، لتنمية هذا الميدان، وإعداده الإعداد المتميز الذي يؤهله للمساهمة في إنجازات الدولة.\r\n\r\nوأضافت أن لجنة الجائزة، تسعى إلى تطويرها وفق خطّة ممنهجة وأهداف ورؤى واضحة، تستقطب الخبرات المتميزة لتطوّر معاييرها ومنهجياتها وأنظمتها التي تصنع الفرق في عوالم التميز و الإبداع.\r\n\r\n \r\n\r\nالمصدر: الخليج",
                    EnglishTitle = "Launching of the “Sharjah Award for Excellence and Educational Excellence”, the 29th session",
                    EnglishDescription = "Sharjah: Amir Al Sunni\r\n\r\nThe Sharjah Award for Educational Excellence and Distinction Committee and the Parents’ Councils of male and female students announced the launch of the 29th session of the award, during a press conference held at the House of Wisdom.\r\n\r\nThe conference was attended by Mohammed Al Mulla, Secretary General of the Committee, Alia Al Hosani, Chair of the Award Committee, and a number of personalities from relevant institutions, partners, award coordinators, members of development committees, and a number of media professionals.\r\n\r\nAl Mulla said that the launch of the 29th session this year was a continuation of the distinguished educational award’s journey, since its establishment in 1994 under the patronage of His Highness Sheikh Dr. Sultan bin Muhammad Al Qasimi, Member of the Supreme Council and Ruler of Sharjah, and its great role in highlighting the generous educational competencies that have made great contributions in the field of education. And it has clear fingerprints in its advancement.\r\n\r\nHe added that the award’s mission aims to advance educational work, in all its stages, by honoring distinguished and creative people from various educational and pedagogical fields, in addition to spreading the culture of excellence and innovation, and creating an exemplary intellectual climate for the educational field with all its distinguished creative categories by presenting a new ambitious vision, integrated with its strategy and goals. Leading future.\r\n\r\nHe explained that the target categories for the award are three: distinguished individuals, which include the “distinguished teacher,” the “distinguished educational leader” (in both the senior leadership and middle leadership branches), the “distinguished student,” the “distinguished student from special categories,” and the “distinguished supporting jobs.” And “the distinguished guardian.”\r\n\r\nThe second includes the distinguished institutions “Distinguished School,” “Distinguished Nurseries,” and “Institutions and Partnerships that Support Education.” The third includes work teams and includes “Distinguished Institutional Work Teams,” “Distinguished Student Council,” “Joint Work Teams,” and “Distinguished Parents Council.”\r\n\r\nThe Secretary-General revealed a new award for this year, which is “The Jewel of the Arabic Language,” in recognition of the importance of the Arabic language and the necessity of educating young people to master and preserve it, and as an embodiment of the great interest that His Highness the Ruler of Sharjah attaches to the Arabic language, with his support and harnessing all capabilities to preserve it.\r\n\r\nAlia Al Hosani said: The award continues its ambitious goals of anticipating the future, contributing to the development of the educational field, cycle after cycle, and building distinguished educational cadres that adopt creativity, innovation, excellence, and the scientific method as an approach, to develop this field, and prepare it with distinguished preparation that qualifies it to contribute to the state’s achievements.\r\n\r\nShe added that the award committee seeks to develop it according to a systematic plan with clear goals and visions, attracting distinguished expertise to develop its standards, methodologies and systems that make the difference in the worlds of excellence and creativity.\r\n\r\n \r\n\r\nSource: Al Khaleej",
                    Image = "https://award-shj.ae/media/bx4famcb/5106559.jpeg?anchor=center&mode=crop&width=593&height=338&rnd=133280978690230000",
                    CycleId = 1
                }, new News()
                {
                    Id = 3,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicTitle = "عبدالله بن سالم يكرم الفائزين بجائزة الشارقة للتميز التربوي",
                    ArabicDescription = "كرم سمو الشيخ عبدالله بن سالم بن سلطان القاسمي نائب حاكم الشارقة، صباح اليوم الأربعاء، في مركز الجواهر للمناسبات والمؤتمرات، الفائزين بجائزة الشارقة للتميز التربوي في دورتها الـ 28، والتي ينظمها مجلس الشارقة للتعليم.\r\n\r\nاستهل حفل التكريم بالسلام الوطني لدولة الإمارات العربية المتحدة، عقبه تلاوة آيات بينات من الذكر الحكيم، ألقى بعدها الدكتور سعيد مصبح الكعبي رئيس مجلس الشارقة للتعليم كلمة قال فيها: \"عُدت إلى أرشيف الجائزة، ذلك الأرشيف الجميل، واستوقفتني بعض الصور والمشاهد الحّية، وأكثر ما شد انتباهي لقاء متلفز لصاحب السمو حاكم الشارقة وهو يتحدث عن أهمية الجائزة ودورها في تعزيز التميز والتفوق، ومشهد للطلبة المتفوقين وهم يستلمون شهاداتهم من سموه فرحين بما أتاهم الله من فضله، تعرفت على بعض من هذه الشخصيات وهم الآن يتقلدون مناصب عدة يقودون نهضة التطور والعمران لهذا البلد الجميل\".\r\n\r\nوأضاف الدكتور سعيد مصبح الكعبي: \"تمر السنوات ويأتي جيل بعد جيل، تتطور المعايير والخطط، سعياً لتحقيق الرؤية السامية التي وضعها صاحب السمو حاكم الشارقة، فالجائزة تاريخ عميق، بمفاهيم راسخة في الأذهان وميادين مليئة بالأمثلة المشرفة، ونحن على يقين أن هذا الجيل سيكون له شأن كبير في المستقبل وسيكملون مسيرة النهضة، فالذي يسير على طريق التميز لا يتوقف، والحقيقة أن هذه هي الاستدامة التي رسمها سلطان مبكراً، نقطف اليوم ثمرةً بتكريم كوكبة جديدة من المتميزين\".\r\n\r\nوعن الجائزة في دورتها الحالية، أشار رئيس مجلس التعليم إلى أنها شهدت إطلاق فئة جديدة وهي \"جائزة الجوهرة\"، قائلاً: \"شهدت الجائزة في هذه الدورة اطلاق جائزة الجوهرة ضمن فئاتها، وهو تكريم استثنائي لشخصية متميزة لها انجازات ومبادرات فرديّة ذات أثر فعّال في المجال التربوي، وساهمت في الارتقاء بالتعليم وتطويره لتحقيق الأهداف المرجوة، وهي قدوة لغيرها في التميز والبذل والعطاء، كما شهدت إقبالاً ملحوظاً، فقد بلغ عدد المشاركين في الدورة الحالية 1328 مشاركاً بنسبة ارتفاع 40% عن العام الماضي، فاز منهم 38 مشاركاً، ومن جانب آخر، تم تدشين مبادرات التحول الرقمي، حيث أطلقت الجائزة تطبيق الهاتف الذكي، واستحدثت آليات جديدة لبوابة المشترك الإلكتروني ابتداء من استلام الطلبات مروراً بعمليات التقييم والتحكيم، بالإضافة إلى الدورات الافتراضية وتسجيل جميع الأدلة التفسيريّة للفئات صوتياً\".\r\n\r\nوفي ختام حديثه، وجه الدكتور سعيد مصبح الكعبي، رسالة للفائزين بالجوائز جاء فيها: \"حبانا الله بوطن وقادة يعشقون التميز والابداع والعطاء، ويدعون للعلم والمعرفة، ويسعون دائماً للقاء وتقدير المتميزين في كل المحافل، وما الجائزة إلا خير دليل على ذلك، وأدعوكم لحفظ الأمانة وحمل راية العطاء معاً لخدمة هذا الوطن الغالي، وأشكر سمو الشيخ عبد الله بن سالم القاسمي نائب حاكم الشارقة، على حضوره وتشريفه الحفل، كما أوجه الشكر لجميع الحضور متمنياً لهم التوفيق والنجاح\".\r\n\r\nبعدها شاهد الحضور مادة فلمية بعنوان \"جائزة الشارقة للتميز التربوي مسيرة تميز، تطور، إبداع\"، تناولت خلالها مسيرة الجائزة منذ نشأتها والخطط التي تبنتها وساهمت في تطور مراحلها على مر الأعوام، بالإضافة إلى تعدد فئات الجائزة وتوظيف التكنولوجيا من خلال أتمتة التقديم والمشاركة، وذلك لضمان سهولة الوصول لجميع شرائح المجتمع المشاركين في الجائزة.\r\n\r\nكما شاهد الحضور عرضاً ثلاثي الأبعاد ومادة مرئية حملت عنوان \"صنّاع التميز\"، تطرقت فيها للجهود المبذولة من قبل المرشحين المشاركين في الجائزة ودعم أولياء الأمور لأبنائهم الطلبة.\r\n\r\nوتفضل سمو نائب حاكم الشارقة بتكريم الفائز بالجائزة الاستثنائية \"جائزة الجوهرة\" والتي فاز بها عبد الله عوض الهمامي اختصاصي إعاقة بصرية في وزارة التربية والتعليم، ومدرب معتمد من البورد الأميركي الكندي، كما يحمل الهمامي الإجازة بسند متصل إلى \"النبي صل الله عليه وسلم\" في ترتيل وتجويد القرآن الكريم برواية حفص عن عاصم، كما أسس الهمامي نادي لذوي الإعاقة في جامعة العين ويعتبر أحد الرواد المؤثرين على مستوى الوطن العربي وحاز على العديد من الجوائز على المستوى المحلي والخارجي.\r\n\r\nكما كرم سموه هيئة الشارقة للتعليم الخاص الحاصلة على المركز الأول كأفضل جهة تعليمية، فيما حلت مؤسسة الإمارات للتعليم المدرسي في المركز الثاني، ونالت القيادة العامة لشرطة الشارقة جائزة المركز الأول لفئة المؤسسات والشراكات الداعمة للتعليم المتميز.\r\n\r\nوفي فئة الطالب المتميز كرم سمو نائب حاكم الشارقة عن الصف الثالث كل من نوال علي جواس وفايش فيك، فيما نال جائزة الصف الرابع كل من كريستينا راكان ونصر عبد المجيد، وحازتا نورة المشتغل النقبي ومريم الناعور النقبي على جائزة الصف الخامس، فيما نال عائشة حميد الخيال وغاية سعيد الأحبابي وموزة محمد الهوتي جائزة الصف السادس، وفاز فيشناف سانتوش وريقاف كريشنا بجائزة الصف السابع، وعن الصف الثامن حصد كل من ساشني مانيكاندان ويوفام تاكار الجائزة، ونال سيف حسن كرم وبيسان محمد فراس جائزة الصف التاسع، وحصد راشد عمر الهارش ومريم حمد الغفلي جائزة الصف العاشر، فيما ذهبت جائزة الصف الحادي عشر لعبد الله محمد رمضان وميشال فراز الهاشمي، كما نالت جائزة الصف الثاني عشر مريم حسن الشامسي، وفي فئة الطالب المتميز – الفئات الخاصة تم تكريم كل من ميثه محمد الحمودي، ونورة محمد الحمادي، وتاله أحمد الأعمر، وحمدان حميد الزحمي، ورضا إسماعيل ثابت.\r\n\r\nوكرم سموه فضيلة عبد الله الخوري بجائزة المركز الأول عن فئة ولي الأمر المتميز، فيما حلت في المركز الثاني أمل عبد الله المهيري، وفازت سمر خالد الشبلي بجائزة القائد التربوي المتميز، فيما توّجت نورة مبارك الحمادي بالمركز الأول، وهدى محمد ربيع بالمركز الثاني، وإيمان مصطفى محمد في المركز الثالث وعائشة خليفة الغفلي بالمركز الرابع لفئة المعلم المتميز.\r\n\r\nكما كرم سمو نائب حاكم الشارقة كل من مروة خميس اليماحي الفائزة بالمركز الأول، ومحمد محمد مخلوف في المركز الثاني، عن فئة الوظائف الداعمة المتميزة.\r\n\r\nوحصدت روضة ومدرسة أسماء للتعليم الأساسي جائزة المركز الأول لفئة المؤسسات التعليمية المتميزة، وذهبت جائزة المركز الأول عن فئة فرق العمل المؤسسية المتميزة لفريق عيادة ابتسامة الضاد اللغوية.\r\n\r\nومع نهاية الحفل، كرّم سمو الشيخ عبد الله بن سالم القاسمي قادة ومؤسسي الجائزة التي انطلقت في عام 1994، مثمناً جهودهم التي أرست القواعد للجائزة وساهمت في استمرارها حتى يومنا هذا، ملتقطين مع سموه والمكرمين الصورة التذكارية، كما التقط سموه صورة جماعية مع لجنة التحكيم وفرق العمل القائمة على الجائزة الذين ساهموا في دعم الطلبة والعاملين في القطاع التعليمي.\r\n\r\nشهد حفل التكريم بجانب سمو نائب حاكم الشارقة كل من الشيخ سالم بن عبد الرحمن القاسمي رئيس مكتب سمو الحاكم، وسيف الزري الشامسي قائد عام شرطة الشارقة، وسليمان بن سرحان الزعابي رئيس دائرة شؤون البلديات، وخالد بطي الهاجري مدير عام المدينة الجامعية، وعدد من كبار المسؤولين في القطاع التعليمي ورؤساء مجالس أولياء الأمور والمعلمين وطلبة المدارس.\r\n\r\nالمصدر: الشارقة 24 - محمد الحمادي",
                    EnglishTitle = "Abdullah bin Salem honors the winners of the Sharjah Award for Educational Excellence",
                    EnglishDescription = "His Highness Sheikh Abdullah bin Salem bin Sultan Al Qasimi, Deputy Ruler of Sharjah, this Wednesday morning, at Al Jawaher Center for Events and Conferences, honored the winners of the Sharjah Award for Educational Excellence in its 28th session, which is organized by the Sharjah Education Council.\r\n\r\nThe honoring ceremony began with the national anthem of the United Arab Emirates, followed by the recitation of clear verses from the Holy Quran, after which Dr. Saeed Musabah Al Kaabi, Chairman of the Sharjah Education Council, gave a speech in which he said: “I returned to the award archive, that beautiful archive, and I was struck by some pictures and live scenes, and most of all.” My attention was caught by a televised interview of His Highness the Ruler of Sharjah, as he spoke about the importance of the award and its role in promoting distinction and superiority, and a scene of outstanding students receiving their diplomas from His Highness, rejoicing in what God has given them of His bounty. I got to know some of these figures and they now hold several positions leading the renaissance of development and urbanization for this reason. The beautiful country\".\r\n\r\nDr. Saeed Musabah Al Kaabi added: “Years pass and generation after generation comes, standards and plans develop, in an effort to achieve the lofty vision set by His Highness the Ruler of Sharjah. The award has a deep history, with concepts firmly established in the minds and fields full of honorable examples, and we are certain that this generation will have It is a great matter in the future and they will continue the path of renaissance, for those who walk on the path of excellence do not stop, and the truth is that this is the sustainability that Sultan envisioned early on. Today we are reaping the fruit by honoring a new group of distinguished people.”\r\n\r\nRegarding the award in its current session, the Chairman of the Education Council indicated that it witnessed the launch of a new category, which is the “Jawhara Award,” saying: “The award in this session witnessed the launch of the Al-Jawhara Award within its categories, which is an exceptional honor for a distinguished personality with individual achievements and initiatives that have an effective impact in the field.” Educational, and contributed to the advancement and development of education to achieve the desired goals, and it is a role model for others in excellence, effort, and giving. It also witnessed a remarkable turnout, as the number of participants in the current session reached 1,328 participants, an increase of 40% over last year, of whom 38 participants won. On the other hand, Digital transformation initiatives were launched, as the award launched the smartphone application, and created new mechanisms for the electronic participant portal, starting from receiving applications through evaluation and arbitration processes, in addition to virtual courses and audio recording of all interpretive evidence for the categories.”\r\n\r\nAt the conclusion of his speech, Dr. Saeed Musabah Al Kaabi sent a message to the award winners in which he said: “May God grant us a nation and leaders who love excellence, creativity, and giving, who call for science and knowledge, and who always strive to meet and appreciate the distinguished in all forums, and the award is nothing but the best evidence of that, and I invite you to preserve the trust.” Carrying the banner of giving together to serve this dear country, I thank His Highness Sheikh Abdullah bin Salem Al Qasimi, Deputy Ruler of Sharjah, for his presence and honoring the ceremony. I also thank all attendees, wishing them good luck and success.”\r\n\r\nThe audience then watched a film titled “Sharjah Award for Educational Excellence: A Journey of Excellence, Development, and Creativity,” during which it discussed the award’s journey since its inception and the plans it adopted and contributed to the development of its stages over the years, in addition to the multiple categories of the award and the use of technology through the automation of submission and participation. To ensure easy access to all segments of society participating in the award.\r\n\r\nThe audience also watched a 3D presentation and a visual material titled “Makers of Excellence,” in which it touched on the efforts made by the candidates participating in the award and the support parents have for their students.\r\n\r\nHis Highness the Deputy Ruler of Sharjah kindly honored the winner of the exceptional award, “The Jewel Award,” which was won by Abdullah Awad Al Hamami, a visual impairment specialist at the Ministry of Education, and a certified trainer from the American Canadian Board. Al Hamami also holds a license with a chain of transmission connected to “the Prophet, may God bless him and grant him peace.” Reciting and reciting the Holy Qur’an with the narration of Hafs on the authority of Asim. Al-Hammami also founded a club for people with disabilities at Al Ain University and is considered one of the influential pioneers in the Arab world and has won many awards at the local and international levels.\r\n\r\nHis Highness also honored the Sharjah Private Education Authority, which won first place as the best educational body, while the Emirates Foundation for School Education came in second place, and the Sharjah Police General Command won the first place award for the category of institutions and partnerships that support distinguished education.\r\n\r\nIn the Outstanding Student category, His Highness the Deputy Ruler of Sharjah honored Nawal Ali Jawas and Vaish Feek for the third grade, while Christina Rakan and Nasr Abdul Majeed won the fourth grade award, and Noura Al Mushtagal Al Naqbi and Mariam Al Naour Al Naqbi won the fifth grade award, while Aisha Hamid Al Khayal won. Ghaya Saeed Al-Ahbabi and Moza Muhammad Al-Hooti won the sixth grade award, Vaishnav Santosh and Rikaf Krishna won the seventh grade award, Sashni Manikandan and Yuvam Thakkar won the eighth grade award, Saif Hassan Karam and Bisan Muhammad Firas won the ninth grade award, and Rashid Omar Al-Harsh and Maryam Hamad Al-Ghafli won the award. The tenth grade award, while the eleventh grade award went to Abdullah Muhammad Ramadan and Michel Faraz Al Hashemi, and the twelfth grade award went to Maryam Hassan Al Shamsi, and in the Outstanding Student category - Special Categories, Maitha Muhammad Al Hamoudi, Noura Muhammad Al Hammadi, and Talah Ahmed Al Ammar were honored. Hamdan Hamid Al-Zahmi, and Reda Ismail Thabet.\r\n\r\nHis Highness honored His Eminence Abdullah Al Khouri with the first place award for the Distinguished Parent category, while Amal Abdullah Al Muhairi came in second place, and Samar Khaled Al Shibli won the Distinguished Educational Leader Award, while Noura Mubarak Al Hammadi was crowned in first place, Hoda Muhammad Rabie in second place, and Iman Mustafa. Muhammad is in third place and Aisha Khalifa Al-Ghafli is in fourth place for the Distinguished Teacher category.\r\n\r\nHis Highness the Deputy Ruler of Sharjah also honored Marwa Khamis Al Yamahi, winner of first place, and Mohammed Mohammed Makhlouf in second place, in the Outstanding Support Jobs category.\r\n\r\nAsmaa Kindergarten and Basic Education School won the first place award for the Distinguished Educational Institutions category, and the first place award for the Distinguished Institutional Work Teams category went to the Smile Al-Dhad Language Clinic team.\r\n\r\nAt the end of the ceremony, His Highness Sheikh Abdullah bin Salem Al Qasimi honored the leaders and founders of the award that was launched in 1994, praising their efforts that laid the foundations for the award and contributed to its continuation to this day, taking a memorial photo with His Highness and the honorees. His Highness also took a group photo with the jury and teams. Award-based work who have contributed to supporting students and workers in the educational sector.\r\n\r\nThe honoring ceremony was witnessed alongside His Highness the Deputy Ruler of Sharjah, Sheikh Salem bin Abdul Rahman Al Qasimi, Head of the Office of His Highness the Ruler, Saif Al Zari Al Shamsi, Commander-in-Chief of Sharjah Police, Sulaiman bin Sarhan Al Zaabi, Head of the Municipalities Affairs Department, Khalid Butti Al Hajri, Director General of the University City, and a number of senior officials. In the educational sector and heads of parents’, teachers’ and school students’ councils.\r\n\r\nSource: Sharjah 24 - Muhammad Al Hammadi",
                    Image = "https://award-shj.ae/media/n1lb4exq/screenshot-2024-03-07-121511.png?anchor=center&mode=crop&width=593&height=338&rnd=133542874516370000",
                    CycleId = 1
                });
            #endregion
            #region CategoryFAQ
            modelBuilder.Entity<CategoryFAQ>()
                .HasData(new CategoryFAQ()
                {
                    Id = 1,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    EnglishFile = "https://award-shj.ae/media/ffgjcmvp/the-gem-of-the-arabic-language-award-30.pdf",
                    ArabicFile = "https://award-shj.ae/media/jnkg2b5u/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%AC%D9%88%D9%87%D8%B1%D8%A9-%D8%A7%D9%84%D9%84%D8%BA%D8%A9-%D8%A7%D9%84%D8%B9%D8%B1%D8%A8%D9%8A%D8%A9-30.pdf",
                    CategoryId = 2
                }, new CategoryFAQ()
                {
                    Id = 2,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    EnglishFile = "https://award-shj.ae/media/tlrb5gxb/distinguished-educational-leader-category-senior-leadership-30.pdf",
                    ArabicFile = "https://award-shj.ae/media/i2flqxw5/%D9%81%D8%A6%D8%A9-%D8%A7%D9%84%D9%82%D8%A7%D8%A6%D8%AF-%D8%A7%D9%84%D8%AA%D8%B1%D8%A8%D9%88%D9%8A-%D8%A7%D9%84%D9%85%D8%AA%D9%85%D9%8A%D8%B2-%D8%A7%D9%84%D9%82%D9%8A%D8%A7%D8%AF%D8%A9-%D8%A7%D9%84%D8%B9%D9%84%D9%8A%D8%A7-30.pdf",
                    CategoryId = 4
                }, new CategoryFAQ()
                {
                    Id = 3,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    EnglishFile = "https://award-shj.ae/media/1n5b35ld/distinguished-teacher-category-30.pdf",
                    ArabicFile = "https://award-shj.ae/media/kovhdfgh/%D9%81%D8%A6%D8%A9-%D8%A7%D9%84%D9%85%D8%B9%D9%84%D9%85-%D8%A7%D9%84%D9%85%D8%AA%D9%85%D9%8A%D8%B2-30.pdf",
                    CategoryId = 5
                });
            #endregion
            #region ExplanatoryGuide
            modelBuilder.Entity<ExplanatoryGuide>()
                .HasData(new ExplanatoryGuide()
                {
                    Id = 1,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicTitle = "الدليل التفسيري",
                    EnglishTitle = "Explanatory Guide",
                    EnglishFilePath = "https://award-shj.ae/media/ffgjcmvp/the-gem-of-the-arabic-language-award-30.pdf",
                    ArabicFilePath = "https://award-shj.ae/media/jnkg2b5u/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%AC%D9%88%D9%87%D8%B1%D8%A9-%D8%A7%D9%84%D9%84%D8%BA%D8%A9-%D8%A7%D9%84%D8%B9%D8%B1%D8%A8%D9%8A%D8%A9-30.pdf",
                    CategoryId = 2
                }, new ExplanatoryGuide()
                {
                    Id = 2,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicTitle = "الدليل التفسيري",
                    EnglishTitle = "Explanatory Guide",
                    EnglishFilePath = "https://award-shj.ae/media/tlrb5gxb/distinguished-educational-leader-category-senior-leadership-30.pdf",
                    ArabicFilePath = "https://award-shj.ae/media/i2flqxw5/%D9%81%D8%A6%D8%A9-%D8%A7%D9%84%D9%82%D8%A7%D8%A6%D8%AF-%D8%A7%D9%84%D8%AA%D8%B1%D8%A8%D9%88%D9%8A-%D8%A7%D9%84%D9%85%D8%AA%D9%85%D9%8A%D8%B2-%D8%A7%D9%84%D9%82%D9%8A%D8%A7%D8%AF%D8%A9-%D8%A7%D9%84%D8%B9%D9%84%D9%8A%D8%A7-30.pdf",
                    CategoryId = 4
                }, new ExplanatoryGuide()
                {
                    Id = 3,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicTitle = "الدليل التفسيري",
                    EnglishTitle = "Explanatory Guide",
                    EnglishFilePath = "https://award-shj.ae/media/1n5b35ld/distinguished-teacher-category-30.pdf",
                    ArabicFilePath = "https://award-shj.ae/media/kovhdfgh/%D9%81%D8%A6%D8%A9-%D8%A7%D9%84%D9%85%D8%B9%D9%84%D9%85-%D8%A7%D9%84%D9%85%D8%AA%D9%85%D9%8A%D8%B2-30.pdf",
                    CategoryId = 5
                });
            #endregion
            #region FrequentlyAskedQuestion
            modelBuilder.Entity<FrequentlyAskedQuestion>()
                .HasData(new FrequentlyAskedQuestion()
                {
                    Id = 1,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    CategoryId = 2,
                    ArabicQuestion = "كيف يمكنني المشاركة في جائزة الشارقة للتفوق والتميز التربوي؟",
                    ArabicAnswer = "يمكنك المشاركة في الجائزة من خلال اتباع الخطوات التالية:\r\n\r\nالنقر على \"بوابة المشتركين\" في القائمة الرئيسية للموقع.\r\nإذا لم يكن لديك حساب في البوابة، يرجى إنشاء حساب مستخدم جديد بالنقر على خيار \"سجل الآن\"، وقم بتعبئة البيانات المطلوبة.\r\nإذا كان لديك حساب مسبق في البوابة، يرجى النقر على خيار \"لقد قمت بالتسجيل مسبقاً\"، وقم بتسجيل الدخول بإدخال اسم المستخدم وكلمة المرور.\r\nبعد الدخول إلى البوابة، يمكنك التسجيل في الفئة التي ترغب بها ورفع المستندات المطلوبة.\r\nيمكنك رفع الأدلة بجانب كل معيار من معايير الفئة.",
                    EnglishQuestion = "How can I participate in the Sharjah Award for Educational Excellence and Excellence?",
                    EnglishAnswer = "You can participate in the award by following the following steps:\r\n\r\nClick on “Subscribers Portal” in the main menu of the site.\r\nIf you do not have an account on the portal, please create a new user account by clicking on the “Register Now” option and filling out the required data.\r\nIf you already have an account on the portal, please click on the “I have already registered” option and log in by entering your username and password.\r\nAfter entering the portal, you can register in the category you desire and upload the required documents.\r\nYou can upload evidence next to each category criteria."
                }, new FrequentlyAskedQuestion()
                {
                    Id = 2,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    CategoryId = 4,
                    ArabicQuestion = "كيف يمكنني المشاركة في جائزة الشارقة للتفوق والتميز التربوي؟",
                    ArabicAnswer = "يمكنك المشاركة في الجائزة من خلال اتباع الخطوات التالية:\r\n\r\nالنقر على \"بوابة المشتركين\" في القائمة الرئيسية للموقع.\r\nإذا لم يكن لديك حساب في البوابة، يرجى إنشاء حساب مستخدم جديد بالنقر على خيار \"سجل الآن\"، وقم بتعبئة البيانات المطلوبة.\r\nإذا كان لديك حساب مسبق في البوابة، يرجى النقر على خيار \"لقد قمت بالتسجيل مسبقاً\"، وقم بتسجيل الدخول بإدخال اسم المستخدم وكلمة المرور.\r\nبعد الدخول إلى البوابة، يمكنك التسجيل في الفئة التي ترغب بها ورفع المستندات المطلوبة.\r\nيمكنك رفع الأدلة بجانب كل معيار من معايير الفئة.",
                    EnglishQuestion = "How can I participate in the Sharjah Award for Educational Excellence and Excellence?",
                    EnglishAnswer = "You can participate in the award by following the following steps:\r\n\r\nClick on “Subscribers Portal” in the main menu of the site.\r\nIf you do not have an account on the portal, please create a new user account by clicking on the “Register Now” option and filling out the required data.\r\nIf you already have an account on the portal, please click on the “I have already registered” option and log in by entering your username and password.\r\nAfter entering the portal, you can register in the category you desire and upload the required documents.\r\nYou can upload evidence next to each category criteria."
                }, new FrequentlyAskedQuestion()
                {
                    Id = 3,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    CategoryId = 5,
                    ArabicQuestion = "كيف يمكنني المشاركة في جائزة الشارقة للتفوق والتميز التربوي؟",
                    ArabicAnswer = "يمكنك المشاركة في الجائزة من خلال اتباع الخطوات التالية:\r\n\r\nالنقر على \"بوابة المشتركين\" في القائمة الرئيسية للموقع.\r\nإذا لم يكن لديك حساب في البوابة، يرجى إنشاء حساب مستخدم جديد بالنقر على خيار \"سجل الآن\"، وقم بتعبئة البيانات المطلوبة.\r\nإذا كان لديك حساب مسبق في البوابة، يرجى النقر على خيار \"لقد قمت بالتسجيل مسبقاً\"، وقم بتسجيل الدخول بإدخال اسم المستخدم وكلمة المرور.\r\nبعد الدخول إلى البوابة، يمكنك التسجيل في الفئة التي ترغب بها ورفع المستندات المطلوبة.\r\nيمكنك رفع الأدلة بجانب كل معيار من معايير الفئة.",
                    EnglishQuestion = "How can I participate in the Sharjah Award for Educational Excellence and Excellence?",
                    EnglishAnswer = "You can participate in the award by following the following steps:\r\n\r\nClick on “Subscribers Portal” in the main menu of the site.\r\nIf you do not have an account on the portal, please create a new user account by clicking on the “Register Now” option and filling out the required data.\r\nIf you already have an account on the portal, please click on the “I have already registered” option and log in by entering your username and password.\r\nAfter entering the portal, you can register in the category you desire and upload the required documents.\r\nYou can upload evidence next to each category criteria."
                }, new FrequentlyAskedQuestion()
                {
                    Id = 4,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    CategoryId = 2,
                    ArabicQuestion = "ما هي شروط المشاركة في جائزة الشارقة للتفوق والتميز التربوي؟",
                    ArabicAnswer = "تنقسم شروط المشاركة في جائزة الشارقة للتفوق والتميز التربوي إلى قسمين:\r\n\r\nالشروط العامة: وهي شروط تنطبق على جميع فئات الجائزة.\r\nالشروط الخاصة: وهي شروط محددة لفئة معينة من فئات الجائزة.\r\n\r\nللاطلاع على الشروط العامة والخاصة لفئات الجائزة، الرجاء اتباع الخطوات التالية:\r\n\r\nالدخول إلى صفحة فئات الجائزة من القائمة الرئيسية للموقع.\r\nالنقر على \"تحميل الدليل التفسيري للفئة\" وذلك للفئة التي ترغب بالاطلاع عليها.\r\nمن خلال الدليل التفسيري يمكنك الاطلاع على الشروط العامة والخاصة للفئة.",
                    EnglishQuestion = "What are the conditions for participation in the Sharjah Award for Excellence and Educational Excellence?",
                    EnglishAnswer = "The conditions for participation in the Sharjah Award for Excellence and Educational Excellence are divided into two parts:\r\n\r\nGeneral conditions: These are conditions that apply to all categories of the award.\r\nSpecial Conditions: These are specific conditions for a specific award category.\r\n\r\nTo view the general and specific conditions for the award categories, please follow the following steps:\r\n\r\nAccess the award categories page from the main menu of the website.\r\nClick on “Download the category interpretive guide” for the category you wish to view.\r\nThrough the interpretive guide you can view the general and special conditions of the category."
                }, new FrequentlyAskedQuestion()
                {
                    Id = 5,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    CategoryId = 4,
                    ArabicQuestion = "ما هي شروط المشاركة في جائزة الشارقة للتفوق والتميز التربوي؟",
                    ArabicAnswer = "تنقسم شروط المشاركة في جائزة الشارقة للتفوق والتميز التربوي إلى قسمين:\r\n\r\nالشروط العامة: وهي شروط تنطبق على جميع فئات الجائزة.\r\nالشروط الخاصة: وهي شروط محددة لفئة معينة من فئات الجائزة.\r\n\r\nللاطلاع على الشروط العامة والخاصة لفئات الجائزة، الرجاء اتباع الخطوات التالية:\r\n\r\nالدخول إلى صفحة فئات الجائزة من القائمة الرئيسية للموقع.\r\nالنقر على \"تحميل الدليل التفسيري للفئة\" وذلك للفئة التي ترغب بالاطلاع عليها.\r\nمن خلال الدليل التفسيري يمكنك الاطلاع على الشروط العامة والخاصة للفئة.",
                    EnglishQuestion = "What are the conditions for participation in the Sharjah Award for Excellence and Educational Excellence?",
                    EnglishAnswer = "The conditions for participation in the Sharjah Award for Excellence and Educational Excellence are divided into two parts:\r\n\r\nGeneral conditions: These are conditions that apply to all categories of the award.\r\nSpecial Conditions: These are specific conditions for a specific award category.\r\n\r\nTo view the general and specific conditions for the award categories, please follow the following steps:\r\n\r\nAccess the award categories page from the main menu of the website.\r\nClick on “Download the category interpretive guide” for the category you wish to view.\r\nThrough the interpretive guide you can view the general and special conditions of the category."
                }, new FrequentlyAskedQuestion()
                {
                    Id = 6,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    CategoryId = 5,
                    ArabicQuestion = "ما هي شروط المشاركة في جائزة الشارقة للتفوق والتميز التربوي؟",
                    ArabicAnswer = "تنقسم شروط المشاركة في جائزة الشارقة للتفوق والتميز التربوي إلى قسمين:\r\n\r\nالشروط العامة: وهي شروط تنطبق على جميع فئات الجائزة.\r\nالشروط الخاصة: وهي شروط محددة لفئة معينة من فئات الجائزة.\r\n\r\nللاطلاع على الشروط العامة والخاصة لفئات الجائزة، الرجاء اتباع الخطوات التالية:\r\n\r\nالدخول إلى صفحة فئات الجائزة من القائمة الرئيسية للموقع.\r\nالنقر على \"تحميل الدليل التفسيري للفئة\" وذلك للفئة التي ترغب بالاطلاع عليها.\r\nمن خلال الدليل التفسيري يمكنك الاطلاع على الشروط العامة والخاصة للفئة.",
                    EnglishQuestion = "What are the conditions for participation in the Sharjah Award for Excellence and Educational Excellence?",
                    EnglishAnswer = "The conditions for participation in the Sharjah Award for Excellence and Educational Excellence are divided into two parts:\r\n\r\nGeneral conditions: These are conditions that apply to all categories of the award.\r\nSpecial Conditions: These are specific conditions for a specific award category.\r\n\r\nTo view the general and specific conditions for the award categories, please follow the following steps:\r\n\r\nAccess the award categories page from the main menu of the website.\r\nClick on “Download the category interpretive guide” for the category you wish to view.\r\nThrough the interpretive guide you can view the general and special conditions of the category."
                });
            #endregion
            #region TermAndCondition
            modelBuilder.Entity<TermAndCondition>()
                .HasData(new TermAndCondition()
                {
                    Id = 1,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicTitle = "الشروط العامة للمشاركة",
                    ArabicDescription = "يحق لجميع المدارس الحكومية والخاصة في الميدان التربوي في دولة الإمارات العربية المتحدة التقدم للمشاركة في الجائزة.\r\n- إرفاق أدلة توضح جهود المدرسة في رعاية اللغة العربية لثلاثة أعوام سابقة لعام الترشح, ويلغى طلب الترشح أو الفوز في حال ثبوت عدم صحة أحد الأدلة أو الوثائق المقدمة.\r\n- المشاركات جماعية وباسم المدرسة ولا تقبل المشاركات الفردية.\r\n- تقدم المدرسة رسالة مصدقة من الجهة المختصة بعدم وجود مخالفات إدارية ومالية عن اخر 3 سنوات سابقة لعام الترشح.\r\n- ترفق نسخة الهيكل التنظيمي للمدرسة و التوصيف الوظيفي لجميع الوظائف فيها.",
                    EnglishTitle = "General conditions for participation",
                    EnglishDescription = "All public and private schools in the educational field in the United Arab Emirates are eligible to apply to participate in the award.\r\n- Attach evidence explaining the school’s efforts in sponsoring the Arabic language for three years prior to the year of candidacy. The application for candidacy or winning will be canceled if any of the evidence or documents submitted is proven incorrect.\r\n- Participations are group and in the name of the school. Individual entries are not accepted.\r\n- The school submits a certified letter from the competent authority stating that there are no administrative and financial violations for the last 3 years preceding the year of candidacy.\r\nA copy of the school’s organizational structure and job descriptions for all positions are attached.",
                    NeedAttachment = false,
                    RequiredAttachmentNumber = null,
                    AttachmentType = null,
                    SizeOfAttachmentInKB = null,
                    IsAgree = false,
                    CategoryId = 2
                }, new TermAndCondition()
                {
                    Id = 2,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicTitle = "الشروط العامة للمشاركة",
                    ArabicDescription = "يحق لجميع المدارس الحكومية والخاصة في الميدان التربوي في دولة الإمارات العربية المتحدة التقدم للمشاركة في الجائزة.\r\n- إرفاق أدلة توضح جهود المدرسة في رعاية اللغة العربية لثلاثة أعوام سابقة لعام الترشح, ويلغى طلب الترشح أو الفوز في حال ثبوت عدم صحة أحد الأدلة أو الوثائق المقدمة.\r\n- المشاركات جماعية وباسم المدرسة ولا تقبل المشاركات الفردية.\r\n- تقدم المدرسة رسالة مصدقة من الجهة المختصة بعدم وجود مخالفات إدارية ومالية عن اخر 3 سنوات سابقة لعام الترشح.\r\n- ترفق نسخة الهيكل التنظيمي للمدرسة و التوصيف الوظيفي لجميع الوظائف فيها.",
                    EnglishTitle = "General conditions for participation",
                    EnglishDescription = "All public and private schools in the educational field in the United Arab Emirates are eligible to apply to participate in the award.\r\n- Attach evidence explaining the school’s efforts in sponsoring the Arabic language for three years prior to the year of candidacy. The application for candidacy or winning will be canceled if any of the evidence or documents submitted is proven incorrect.\r\n- Participations are group and in the name of the school. Individual entries are not accepted.\r\n- The school submits a certified letter from the competent authority stating that there are no administrative and financial violations for the last 3 years preceding the year of candidacy.\r\nA copy of the school’s organizational structure and job descriptions for all positions are attached.",
                    NeedAttachment = false,
                    RequiredAttachmentNumber = null,
                    AttachmentType = null,
                    SizeOfAttachmentInKB = null,
                    IsAgree = false,
                    CategoryId = 4
                }, new TermAndCondition()
                {
                    Id = 3,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicTitle = "الشروط العامة للمشاركة",
                    ArabicDescription = "يحق لجميع المدارس الحكومية والخاصة في الميدان التربوي في دولة الإمارات العربية المتحدة التقدم للمشاركة في الجائزة.\r\n- إرفاق أدلة توضح جهود المدرسة في رعاية اللغة العربية لثلاثة أعوام سابقة لعام الترشح, ويلغى طلب الترشح أو الفوز في حال ثبوت عدم صحة أحد الأدلة أو الوثائق المقدمة.\r\n- المشاركات جماعية وباسم المدرسة ولا تقبل المشاركات الفردية.\r\n- تقدم المدرسة رسالة مصدقة من الجهة المختصة بعدم وجود مخالفات إدارية ومالية عن اخر 3 سنوات سابقة لعام الترشح.\r\n- ترفق نسخة الهيكل التنظيمي للمدرسة و التوصيف الوظيفي لجميع الوظائف فيها.",
                    EnglishTitle = "General conditions for participation",
                    EnglishDescription = "All public and private schools in the educational field in the United Arab Emirates are eligible to apply to participate in the award.\r\n- Attach evidence explaining the school’s efforts in sponsoring the Arabic language for three years prior to the year of candidacy. The application for candidacy or winning will be canceled if any of the evidence or documents submitted is proven incorrect.\r\n- Participations are group and in the name of the school. Individual entries are not accepted.\r\n- The school submits a certified letter from the competent authority stating that there are no administrative and financial violations for the last 3 years preceding the year of candidacy.\r\nA copy of the school’s organizational structure and job descriptions for all positions are attached.",
                    NeedAttachment = false,
                    RequiredAttachmentNumber = null,
                    AttachmentType = null,
                    SizeOfAttachmentInKB = null,
                    IsAgree = false,
                    CategoryId = 5
                });
            #endregion
            #region Criterion
            modelBuilder.Entity<Criterion>()
                .HasData(new Criterion()
                {
                    Id = 1,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    OrderId = 1,
                    ArabicTitle = "الأداء والإنجازات المؤثرة",
                    EnglishTitle = "Influential performance and achievements",
                    Score = 500,
                    SizeOfAttachmentInKB = 0,
                    ParentId = null,
                    CategoryId = 2
                }, new Criterion()
                {
                    Id = 2,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    OrderId = 1,
                    ArabicTitle = "جودة الأداء والإنجازات والمبادرات المؤثرة التي تبنتها المدرسة",
                    EnglishTitle = "The quality of performance, achievements and influential initiatives adopted by the school",
                    Score = 300,
                    SizeOfAttachmentInKB = 5000,
                    ParentId = 1,
                    CategoryId = 2
                }, new Criterion()
                {
                    Id = 3,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    OrderId = 2,
                    ArabicTitle = "أثر الإنجازات والمبادرات في المجتمع المدرسي والمحلي، والقيمة المضافة لها",
                    EnglishTitle = "The impact of achievements and initiatives in the school and local community, and their added value",
                    Score = 200,
                    SizeOfAttachmentInKB = 5000,
                    ParentId = 1,
                    CategoryId = 2
                });
            #endregion
            #region CriterionItem
            modelBuilder.Entity<CriterionItem>()
                .HasData(new CriterionItem()
                {
                    Id = 1,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    CriterionId = 2,
                    OrderId = 1,
                    ArabicName = "التخطيط الاستراتيجي للمشاريع والمبادرات التي تخدم اللغة العربية",
                    EnglishName = "Strategic planning for projects and initiatives that serve the Arabic language",
                    Score = 40,
                    ActualScore = 40,
                    SizeOfAttachmentInKB = 5000
                }, new CriterionItem()
                {
                    Id = 2,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    CriterionId = 2,
                    OrderId = 2,
                    ArabicName = "دعم المهارات اللغوية لدى جميع فئات الطلاب",
                    EnglishName = "Supporting language skills for all categories of students",
                    Score = 120,
                    ActualScore = 120,
                    SizeOfAttachmentInKB = 5000
                }, new CriterionItem()
                {
                    Id = 3,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    CriterionId = 2,
                    OrderId = 3,
                    ArabicName = "قيادة تنمية الكفايات اللغوية للمجتمع المدرسي",
                    EnglishName = "Leading the development of the language competencies of the school community",
                    Score = 60,
                    ActualScore = 60,
                    SizeOfAttachmentInKB = 5000
                }, new CriterionItem()
                {
                    Id = 4,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    CriterionId = 2,
                    OrderId = 4,
                    ArabicName = "إدارة رأس المال البشري والموارد بما يخدم اللغة العربية",
                    EnglishName = "Managing human capital and resources to serve the Arabic language",
                    Score = 60,
                    ActualScore = 60,
                    SizeOfAttachmentInKB = 5000
                }, new CriterionItem()
                {
                    Id = 5,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    CriterionId = 2,
                    OrderId = 5,
                    ArabicName = "قيادة الأداء المؤسسي بما يثري المدرسة بنتاجات أدبية",
                    EnglishName = "Leading institutional performance to enrich the school with literary productions",
                    Score = 40,
                    ActualScore = 40,
                    SizeOfAttachmentInKB = 5000
                }, new CriterionItem()
                {
                    Id = 6,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    CriterionId = 3,
                    OrderId = 1,
                    ArabicName = "إتقان المجتمع المدرسي لمهارات اللغة العربية تواصلاً وقراءةً وإبداعاً",
                    EnglishName = "The school community masters the Arabic language skills in communication, reading, and creativity",
                    Score = 150,
                    ActualScore = 150,
                    SizeOfAttachmentInKB = 5000
                }, new CriterionItem()
                {
                    Id = 7,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    CriterionId = 3,
                    OrderId = 2,
                    ArabicName = "نشر ثقافة الاعتزاز باللغة العربية في المجتمع المدرسي والمحلي",
                    EnglishName = "Spreading a culture of pride in the Arabic language in the school and local community",
                    Score = 50,
                    ActualScore = 50,
                    SizeOfAttachmentInKB = 5000
                });
            #endregion
            #region ArbitrationScale
            modelBuilder.Entity<ArbitrationScale>()
                .HasData(new ArbitrationScale()
                {
                    Id = 1,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    CategoryId = 2,
                    ArabicTitle = "النماذج والأدلة",
                    EnglishTitle = "Forms and evidence",
                    DegreeScale = "0 - 100"
                });
            #endregion
            #region ArbitrationScalesCriterion
            modelBuilder.Entity<ArbitrationScalesCriterion>()
               .HasData(new ArbitrationScalesCriterion()
               {
                   Id = 1,
                   isDeleted = false,
                   DeletedAt = null,
                   LastModifiedAt = null,
                   LastModifiedBy = null,
                   CreatedAt = DateTime.UtcNow,
                   CreatedBy = null,
                   ArabicDescription = "نماذج للخطط المتعلقة بالمشاريع والمبادرات التي تخطط لها مكتملة العناصر عناصر الخطة لكل مشروع ومبادرة ونشاط يخدم اللغة العربية)، مع مراعاة أن تتضمن خطة المدرسة التشغيلية خطط مشاريع ومبادرات رعاية اللغة العربية.",
                   EnglishDescription = "Models of plans related to the projects and initiatives that you are planning, with complete elements (plan elements for each project, initiative, and activity that serves the Arabic language), taking into account that the school’s operational plan includes plans for projects and initiatives to support the Arabic language.",
                   CriterionId = 2,
                   CriterionItemId = 1,
                   ArbitrationScaleId = 1
               }, new ArbitrationScalesCriterion()
               {
                   Id = 2,
                   isDeleted = false,
                   DeletedAt = null,
                   LastModifiedAt = null,
                   LastModifiedBy = null,
                   CreatedAt = DateTime.UtcNow,
                   CreatedBy = null,
                   ArabicDescription = "إرفاق أدلة مختلفة على ما تقوم به من خطط، أو أنشطة، أو برامج ، أو مشروعات مختلفة تمكن الطلاب من مهارات اللغة المختلفة.\r\nمدى تقدم الطلاب في المهارات وتمكنهم منها.\r\n- تحديد أدوات المتابعة والقياس التي تم توظيفها، مع مراعاة أن تشمل جميع فئات الطلاب الموهوبين، الفائقون، أصحاب الهمم،\r\nطلاب متدنو المستوى الطلاب كافة . بجميع المستويات).",
                   EnglishDescription = "Attach various evidence of the different plans, activities, programs, or projects you are undertaking that enable students with different language skills.\r\nThe extent of students’ progress in skills and their mastery of them.\r\n- Determine the monitoring and measurement tools that have been employed, taking into account that they include all categories of gifted students, exceptional students, people of determination,\r\nLow level students All students. at all levels).",
                   CriterionId = 2,
                   CriterionItemId = 2,
                   ArbitrationScaleId = 1
               }, new ArbitrationScalesCriterion()
               {
                   Id = 3,
                   isDeleted = false,
                   DeletedAt = null,
                   LastModifiedAt = null,
                   LastModifiedBy = null,
                   CreatedAt = DateTime.UtcNow,
                   CreatedBy = null,
                   ArabicDescription = "- الخطط والبرامج والمشروعات والأنشطة التي نفذتها المدرسة وأثرها في رفع الكفايات اللغوية للمجتمع المدرسي المعلم سواء معلم\r\nاللغة العربية أو المواد المختلفة ، الوظائف المختلفة في المدرسة مثل مصادر التعلم والوظائف الداعمة ، الإداريون بمختلف أدوارهم، ولي\r\nالأمر).\r\n- الإحصائيات والأرقام و\r\nالمقارنات التي تبين التطور في الكفايات اللغوية للمجتمع المدرسي",
                   EnglishDescription = "- The plans, programmes, projects and activities implemented by the school and their impact in raising the linguistic competencies of the school community, whether teachers\r\nThe Arabic language or various subjects, various functions in the school such as learning resources and supporting functions, administrators in their various roles, and...\r\ncommand).\r\n- Statistics, numbers and\r\nComparisons that show the development in the linguistic competencies of the school community",
                   CriterionId = 2,
                   CriterionItemId = 3,
                   ArbitrationScaleId = 1
               }, new ArbitrationScalesCriterion()
               {
                   Id = 4,
                   isDeleted = false,
                   DeletedAt = null,
                   LastModifiedAt = null,
                   LastModifiedBy = null,
                   CreatedAt = DateTime.UtcNow,
                   CreatedBy = null,
                   ArabicDescription = ". جودة توظيف الكوادر البشرية والموارد المختلفة في رعاية اللغة العربية وتمكين المجتمع المدرسي منها.\r\nخطط المدرسة والمنفذة مع معلمو اللغة العربية معلمو المواد الأخرى الطلاب ولي الأمر بما يخدم اللغة العربية.\r\n- توظيف الموارد المختلفة مثل مصادر التعلم والمختبرات والنوادي والمرافق المختلفة في خدمة اللغة العربية.",
                   EnglishDescription = ". The quality of employing human cadres and various resources in nurturing the Arabic language and empowering the school community with it.\r\nSchool plans implemented with Arabic language teachers, teachers of other subjects, students, and guardians to serve the Arabic language.\r\n- Employing various resources such as learning resources, laboratories, clubs and various facilities in serving the Arabic language.",
                   CriterionId = 2,
                   CriterionItemId = 4,
                   ArbitrationScaleId = 1
               }, new ArbitrationScalesCriterion()
               {
                   Id = 5,
                   isDeleted = false,
                   DeletedAt = null,
                   LastModifiedAt = null,
                   LastModifiedBy = null,
                   CreatedAt = DateTime.UtcNow,
                   CreatedBy = null,
                   ArabicDescription = "المشاركة في عضويات ولجان أدبية، أو مؤسسات وروابط أدبية مثل اتحاد كتاب وأدباء الإمارات أو جمعية حماية اللغة العربية  أو مجمع اللغة العربية والتي تنعكس إيجابيا في رفع مستوى الكفايات اللغوية للطلاب والمعلمين وغيرهم في المجتمع المدرسي",
                   EnglishDescription = "Participation in memberships and literary committees, or literary institutions and associations such as the Emirates Writers and Writers Union, the Society for the Protection of the Arabic Language, or the Arabic Language Academy, which is reflected positively in raising the level of linguistic competencies of students, teachers, and others in the school community.",
                   CriterionId = 2,
                   CriterionItemId = 5,
                   ArbitrationScaleId = 1
               }, new ArbitrationScalesCriterion()
               {
                   Id = 6,
                   isDeleted = false,
                   DeletedAt = null,
                   LastModifiedAt = null,
                   LastModifiedBy = null,
                   CreatedAt = DateTime.UtcNow,
                   CreatedBy = null,
                   ArabicDescription = "- نتائج الطلاب في الاختبارات المختلفة (المركزية الوطنية، الدولية).\r\n- تقارير لجان الجودة والرقابة والمتابعة ولجان الدعم الأكاديمي.\r\n- مشاركة المجتمع المدرسي في الفعاليات والمسابقات والمبادرات والأنشطة اللغوية والأدبية المختلفة وعلى جميع المستويات\r\nوحصولهم على مراكز متقدمة.",
                   EnglishDescription = "- Students’ results in various tests (central, national, international).\r\n- Reports of the quality, oversight and follow-up committees and academic support committees.\r\n- Participation of the school community in various events, competitions, initiatives, and linguistic and literary activities at all levels\r\nAnd they achieved advanced positions.",
                   CriterionId = 3,
                   CriterionItemId = 6,
                   ArbitrationScaleId = 1
               }, new ArbitrationScalesCriterion()
               {
                   Id = 7,
                   isDeleted = false,
                   DeletedAt = null,
                   LastModifiedAt = null,
                   LastModifiedBy = null,
                   CreatedAt = DateTime.UtcNow,
                   CreatedBy = null,
                   ArabicDescription = "رصد الممارسات والانشطة التي تدل على نشر وتأصيل اعتزاز المجتمع المدرسي بلغته العربية على مستوى المدرسة، والمجتمع المحلي\r\nوالدولي، والعالمي.\r\n- رصد الممارسات والبرامج والفعاليات والأنشطة التي تتبناها لأجل تأصيل حب اللغة العربية في المجتمع المدرسي تواصلاً وإبداعاً.",
                   EnglishDescription = "Monitoring practices and activities that demonstrate the dissemination and consolidation of the school community’s pride in its Arabic language at the school and local community levels\r\nInternational, and global.\r\n- Monitoring the practices, programmes, events and activities it adopts in order to establish the love of the Arabic language in the school community through communication and creativity.",
                   CriterionId = 3,
                   CriterionItemId = 7,
                   ArbitrationScaleId = 1
               });
            #endregion
            #region AwardStatistic
            modelBuilder.Entity<AwardStatistic>()
                .HasData(new AwardStatistic()
                {
                    Id = 1,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    EnglishTitle = "Award winners during training courses V1",
                    ArabicTitle = "المشتركين بالجائزة خلال الدورات 1",
                    StatisticValue = 1000,
                    CycleId = 1
                }, new AwardStatistic()
                {
                    Id = 2,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    EnglishTitle = "Award winners during training courses V2",
                    ArabicTitle = "المشتركين بالجائزة خلال الدورات 2",
                    StatisticValue = 2000,
                    CycleId = 1
                }, new AwardStatistic()
                {
                    Id = 3,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    EnglishTitle = "Award winners during training courses V3",
                    ArabicTitle = "المشتركين بالجائزة خلال الدورات 3",
                    StatisticValue = 3000,
                    CycleId = 1
                }, new AwardStatistic()
                {
                    Id = 4,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    EnglishTitle = "Award winners during training courses V4",
                    ArabicTitle = "المشتركين بالجائزة خلال الدورات 4",
                    StatisticValue = 4000,
                    CycleId = 1
                }, new AwardStatistic()
                {
                    Id = 5,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    EnglishTitle = "Award winners during training courses V5",
                    ArabicTitle = "المشتركين بالجائزة خلال الدورات 5",
                    StatisticValue = 5000,
                    CycleId = 1
                });
            #endregion
            #region ReferenceSource
            modelBuilder.Entity<ReferenceSource>()
                .HasData(new ReferenceSource()
                {
                    Id = 1,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicTitle = "الدليل التفسيري لجائزة جوهرة اللغة العربية",
                    EnglishTitle = "Interpretive guide for the Jewel of the Arabic Language Award",
                    ArabicSources = "https://award-shj.ae/media/jnkg2b5u/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%AC%D9%88%D9%87%D8%B1%D8%A9-%D8%A7%D9%84%D9%84%D8%BA%D8%A9-%D8%A7%D9%84%D8%B9%D8%B1%D8%A8%D9%8A%D8%A9-30.pdf",
                    EnglishSources = "https://award-shj.ae/media/jnkg2b5u/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%AC%D9%88%D9%87%D8%B1%D8%A9-%D8%A7%D9%84%D9%84%D8%BA%D8%A9-%D8%A7%D9%84%D8%B9%D8%B1%D8%A8%D9%8A%D8%A9-30.pdf",
                    ImageUrl = "https://award-shj.ae/media/hk2fyzfv/%D8%A7%D9%84%D8%B4%D9%8A%D8%AE-%D8%B3%D9%84%D8%B7%D8%A7%D9%86.jpg?anchor=center&mode=crop&width=420&height=232&rnd=133099679521200000",
                }, new ReferenceSource()
                {
                    Id = 2,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicTitle = "الأدلة التفسيرية لفئة الأفراد المتميزين",
                    ArabicSources = "https://award-shj.ae/media/jnkg2b5u/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%AC%D9%88%D9%87%D8%B1%D8%A9-%D8%A7%D9%84%D9%84%D8%BA%D8%A9-%D8%A7%D9%84%D8%B9%D8%B1%D8%A8%D9%8A%D8%A9-30.pdf",
                    EnglishSources = "https://award-shj.ae/media/jnkg2b5u/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%AC%D9%88%D9%87%D8%B1%D8%A9-%D8%A7%D9%84%D9%84%D8%BA%D8%A9-%D8%A7%D9%84%D8%B9%D8%B1%D8%A8%D9%8A%D8%A9-30.pdf",
                    ImageUrl = "https://award-shj.ae/media/hk2fyzfv/%D8%A7%D9%84%D8%B4%D9%8A%D8%AE-%D8%B3%D9%84%D8%B7%D8%A7%D9%86.jpg?anchor=center&mode=crop&width=420&height=232&rnd=133099679521200000",
                }, new ReferenceSource()
                {
                    Id = 3,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicTitle = "الأدلة التفسيرية لفئة المؤسسات المتميزة",
                    ArabicSources = "https://award-shj.ae/media/jnkg2b5u/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%AC%D9%88%D9%87%D8%B1%D8%A9-%D8%A7%D9%84%D9%84%D8%BA%D8%A9-%D8%A7%D9%84%D8%B9%D8%B1%D8%A8%D9%8A%D8%A9-30.pdf",
                    EnglishSources = "https://award-shj.ae/media/jnkg2b5u/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%AC%D9%88%D9%87%D8%B1%D8%A9-%D8%A7%D9%84%D9%84%D8%BA%D8%A9-%D8%A7%D9%84%D8%B9%D8%B1%D8%A8%D9%8A%D8%A9-30.pdf",
                    ImageUrl = "https://award-shj.ae/media/hk2fyzfv/%D8%A7%D9%84%D8%B4%D9%8A%D8%AE-%D8%B3%D9%84%D8%B7%D8%A7%D9%86.jpg?anchor=center&mode=crop&width=420&height=232&rnd=133099679521200000",
                }, new ReferenceSource()
                {
                    Id = 4,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicTitle = "الأدلة التفسيرية لفئة فرق العمل  المتميزة",
                    ArabicSources = "https://award-shj.ae/media/jnkg2b5u/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%AC%D9%88%D9%87%D8%B1%D8%A9-%D8%A7%D9%84%D9%84%D8%BA%D8%A9-%D8%A7%D9%84%D8%B9%D8%B1%D8%A8%D9%8A%D8%A9-30.pdf",
                    EnglishSources = "https://award-shj.ae/media/jnkg2b5u/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%AC%D9%88%D9%87%D8%B1%D8%A9-%D8%A7%D9%84%D9%84%D8%BA%D8%A9-%D8%A7%D9%84%D8%B9%D8%B1%D8%A8%D9%8A%D8%A9-30.pdf",
                    ImageUrl = "https://award-shj.ae/media/hk2fyzfv/%D8%A7%D9%84%D8%B4%D9%8A%D8%AE-%D8%B3%D9%84%D8%B7%D8%A7%D9%86.jpg?anchor=center&mode=crop&width=420&height=232&rnd=133099679521200000",
                }, new ReferenceSource()
                {
                    Id = 5,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicTitle = "المصادر التوضيحية لجميع الفئات",
                    ArabicSources = "https://award-shj.ae/media/jnkg2b5u/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%AC%D9%88%D9%87%D8%B1%D8%A9-%D8%A7%D9%84%D9%84%D8%BA%D8%A9-%D8%A7%D9%84%D8%B9%D8%B1%D8%A8%D9%8A%D8%A9-30.pdf",
                    EnglishSources = "https://award-shj.ae/media/jnkg2b5u/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%AC%D9%88%D9%87%D8%B1%D8%A9-%D8%A7%D9%84%D9%84%D8%BA%D8%A9-%D8%A7%D9%84%D8%B9%D8%B1%D8%A8%D9%8A%D8%A9-30.pdf",
                    ImageUrl = "https://award-shj.ae/media/hk2fyzfv/%D8%A7%D9%84%D8%B4%D9%8A%D8%AE-%D8%B3%D9%84%D8%B7%D8%A7%D9%86.jpg?anchor=center&mode=crop&width=420&height=232&rnd=133099679521200000",
                });
            #endregion
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries <AuditableEntity> ())
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
