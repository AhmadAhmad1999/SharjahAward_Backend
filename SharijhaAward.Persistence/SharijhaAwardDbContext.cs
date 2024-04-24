using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1.Crmf;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.EventModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.InvitationModels;
using SharijhaAward.Domain.Entities.CategoryCommitteeModel;
using SharijhaAward.Domain.Entities.CriterionItemScaleModel;
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

namespace SharijhaAward.Persistence
{
    public class SharijhaAwardDbContext : DbContext
    {
        public SharijhaAwardDbContext(DbContextOptions<SharijhaAwardDbContext> options)
        : base(options) 
        {
      
        }
        
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
        public DbSet<CriterionItemScale> CriterionItemScales { get; set; }
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
        public DbSet<TermAndCondition> TermsAndConditions {  get; set; }
        public DbSet<ConditionsProvidedForms> Attachments { get; set; }
        public DbSet<DynamicAttributePattern> DynamicAttributePatterns {  get; set; }
        public DbSet<DynamicAttributePatternValue> DynamicAttributePatternValues {  get; set; }
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
        public DbSet<Achievement> Achievements {  get; set; }
        public DbSet<CycleConditionsProvidedForm> CycleConditionsProvidedForms { get; set; }
        public DbSet<CycleConditionAttachment> CycleConditionAttachments { get; set; }
        public DbSet<ExtraAttachment> ExtraAttachments { get; set; }
        public DbSet<ExtraAttachmentFile> ExtraAttachmentsProvidedForms { get; set; }
        public DbSet<EmailMessage> EmailMessages { get; set; }
        public DbSet<EmailAttachment> EmailAttachments { get; set; }
        public DbSet<RoleMessageType> RoleMessageTypes {  get; set; }
        public DbSet<MessageType> MessageTypes { get; set; }
        public DbSet<Circular> Circulars { get; set; }
        public DbSet<AwardPublication> AwardPublications {  get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
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

            modelBuilder.Entity<Instruction>()
                .HasData(new Instruction()
                {
                    Id = 1,
                    Content = "Content 1",
                    Slug = "Slug 1",
                    Title = "Title 1",
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                }, new Instruction()
                {
                    Id = 2,
                    Content = "Content 2",
                    Slug = "Slug 2",
                    Title = "Title 2",
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null
                });

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

            modelBuilder.Entity<AboutAwardPage>()
                .HasData(new AboutAwardPage()
                {
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Id = 1,
                    AboutImage = "https://backend.stg.award-shj.ae/UploadedFiles/02ef2561-b108-4b12-8a3f-6734b4e0345f.jpg",
                    ArabicAboutDescription = "تأسست جائزة الشارقة للتفوق والتميز التربوي عام 1994-1995 برعاية كريمة من صاحب السمو الشيخ الدكتور سلطان بن محمد القاسمي عضو المجلس الاعلى حاكم إمارة الشارقة حفظه الله ورعاه... وتعتبر أول جائزة تربوية على مستوى الدولة",
                    ArabicAboutTitle = "نبذة عن الجائزة",
                    ArabicOurVisionDescription = "تأسست جائزة الشارقة للتفوق والتميز التربوي عام 1994-1995 برعاية كريمة من صاحب السمو الشيخ الدكتور سلطان بن محمد القاسمي عضو المجلس الاعلى حاكم إمارة الشارقة حفظه الله ورعاه... وتعتبر أول جائزة تربوية على مستوى الدولة",
                    ArabicOurVisionTitle = "رؤيتنا",
                    EnglishAboutDescription = "The Sharjah Award for Educational Excellence and Excellence was established in 1994-1995 under the generous patronage of His Highness Sheikh Dr. Sultan bin Muhammad Al Qasimi, Member of the Supreme Council and Ruler of the Emirate of Sharjah, may God protect and preserve him... It is considered the first educational award at the state level.",
                    EnglishAboutTitle = "About the award",
                    EnglishOurVisionDescription = "The Sharjah Award for Educational Excellence and Excellence was established in 1994-1995 under the generous patronage of His Highness Sheikh Dr. Sultan bin Muhammad Al Qasimi, Member of the Supreme Council and Ruler of the Emirate of Sharjah, may God protect and preserve him... It is considered the first educational award at the state level.",
                    EnglishOurVisionTitle = "Our Vision",
                    OurVisionImage = "https://backend.stg.award-shj.ae/UploadedFiles/02ef2561-b108-4b12-8a3f-6734b4e0345f.jpg"
                });

            modelBuilder.Entity<OurGoal>()
                .HasData(new OurGoal()
                {
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Id = 1,
                    AboutAwardPageId = 1,
                    ArabicGoal = "تطوير القطاع التربوي من خلال بث روح التنافس بينهم؛ لتحقيق أفضل الممارسات التربوية.",
                    EnglishGoal = "Developing the educational sector by spreading the spirit of competition among them; To achieve best educational practices."
                }, new OurGoal()
                {
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Id = 2,
                    AboutAwardPageId = 1,
                    ArabicGoal = "طوير أعمال الجائزة ومنهجياتها، ورفع الكفايات المهنية للعاملين بها.",
                    EnglishGoal = "Developing the Award’s work and methodologies, and raising the professional competencies of its employees."
                });

            modelBuilder.Entity<OnePageText>()
                .HasData(new OnePageText()
                {
                    Id = 1,
                    ArabicText = "سياسة الخصوصية",
                    EnglishText = "Privacy Policy",
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Type = Domain.Constants.OnePageText.OnePageTextType.PrivacyPolicy
                }, new OnePageText()
                {
                    Id = 2,
                    ArabicText = "شروط الاستخدام",
                    EnglishText = "Terms Of Use",
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Type = Domain.Constants.OnePageText.OnePageTextType.TermsOfUse
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

            modelBuilder.Entity<Criterion>()
                .HasData(new Criterion()
                {
                    Id = 1,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    ArabicTitle = "معيار رئيسي 1",
                    CategoryId = 2,
                    EnglishTitle = "Main Criterion 1",
                    ParentId = null,
                    Score = 100
                }, new Criterion()
                {
                    Id = 2,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    ArabicTitle = "معيار فرعي 1",
                    CategoryId = 2,
                    EnglishTitle = "Sub Criterion 1",
                    ParentId = 1,
                    Score = 50,
                    SizeOfAttachmentInKB = 5000
                }, new Criterion()
                {
                    Id = 3,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    ArabicTitle = "معيار فرعي 2",
                    CategoryId = 2,
                    EnglishTitle = "Sub Criterion 2",
                    ParentId = 1,
                    Score = 50,
                    SizeOfAttachmentInKB = 5000
                });

            modelBuilder.Entity<CriterionItem>()
                .HasData(new CriterionItem()
                {
                    Id = 1,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    ActualScore = 0,
                    Score = 50,
                    ArabicName = "بند معيار فرعي 11",
                    CriterionId = 2,
                    EnglishName = "Sub Criterion Item 11",
                    SizeOfAttachmentInKB = 5000
                }, new CriterionItem()
                {
                    Id = 2,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    ActualScore = 0,
                    Score = 50,
                    ArabicName = "بند معيار فرعي 12",
                    CriterionId = 2,
                    EnglishName = "Sub Criterion Item 12",
                    SizeOfAttachmentInKB = 5000
                }, new CriterionItem()
                {
                    Id = 3,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    ActualScore = 0,
                    Score = 50,
                    ArabicName = "بند معيار فرعي 21",
                    CriterionId = 3,
                    EnglishName = "Sub Criterion Item 21",
                    SizeOfAttachmentInKB = 5000
                }, new CriterionItem()
                {
                    Id = 4,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    ActualScore = 0,
                    Score = 50,
                    ArabicName = "بند معيار فرعي 22",
                    CriterionId = 3,
                    EnglishName = "Sub Criterion Item 22",
                    SizeOfAttachmentInKB = 5000
                });

            modelBuilder.Entity<PersonalInvitee>()
                .HasIndex(p => new { p.Email, p.isDeleted })
                .HasFilter("[isDeleted] = 0")
                .IsUnique();

            modelBuilder.Entity<GroupInvitee>()
                .HasIndex(p => new { p.Email, p.isDeleted })
                .HasFilter("[isDeleted] = 0")
                .IsUnique();

            modelBuilder.Entity<ProvidedForm>()
                .HasIndex(p => new { p.Id})
                .HasFilter("[isDeleted] = 0")
                .IsUnique();

            modelBuilder.Entity<Cycle>().HasData(
            new Cycle
            {
                 Id = 1,
                 EnglishName = "SharijhaAward",
                 ArabicName ="جائزة الشارقة",    
                 Year = "2023-2024",
                 Status = Domain.Constants.Common.Status.Active,
                 IndividualCategoryNumber = 10,
                 GroupCategoryNumber = 10
            });

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

            modelBuilder.Entity<News>()
                .HasData(new News()
                {
                    CycleId = 1,
                    Id = 1,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    ArabicDescription = "اختبار وصف أخبار 1",
                    ArabicTitle = "اختبار عنوان أخبار 1",
                    EnglishDescription = "Test News Description 1",
                    EnglishTitle = "Test News Title 1",
                    Image = "https://backend.stg.award-shj.ae/UploadedFiles/02ef2561-b108-4b12-8a3f-6734b4e0345f.jpg"
                }, new News()
                {
                    CycleId = 1,
                    Id = 2,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    ArabicDescription = "اختبار وصف أخبار 2",
                    ArabicTitle = "اختبار عنوان أخبار 2",
                    EnglishDescription = "Test News Description 2",
                    EnglishTitle = "Test News Title 2",
                    Image = "https://backend.stg.award-shj.ae/UploadedFiles/1dd2958e-d80c-48d0-9a28-899d66fded8d.jpg"
                });

            modelBuilder.Entity<Category>()
                .HasData(new Category()
                {
                    CreatedAt = DateTime.UtcNow,
                    CycleId = 1,
                    DeletedAt = null,
                    EnglishDescription = "Test Description 1",
                    EnglishName = "Test Name 1",
                    ExpectedNumberOfWinners = 1,
                    ArabicDescription = "اختبار وصف 1",
                    ArabicName = "اختبار اسم 1",
                    CategoryClassification = Domain.Constants.CategoryConstants.CategoryClassification.Individual,
                    CreatedBy = null,
                    FinalArbitrationQualificationMark = 0,
                    Icon = "string",
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    ParentId = null,
                    RelatedToClasses = false,
                    WinningScore = 0,
                    Id = 1
                }, new Category()
                {
                    CreatedAt = DateTime.UtcNow,
                    CycleId = 1,
                    DeletedAt = null,
                    EnglishDescription = "Test Description 2",
                    EnglishName = "Test Name 2",
                    ExpectedNumberOfWinners = 1,
                    ArabicDescription = "اختبار وصف 2",
                    ArabicName = "اختبار اسم 2",
                    CategoryClassification = Domain.Constants.CategoryConstants.CategoryClassification.Individual,
                    CreatedBy = null,
                    FinalArbitrationQualificationMark = 0,
                    Icon = "string",
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    RelatedToClasses = false,
                    WinningScore = 0,
                    Id = 2,
                    ParentId = 1
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

            modelBuilder.Entity<FrequentlyAskedQuestion>()
                .HasData(new FrequentlyAskedQuestion()
                {
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Id = 1,
                    ArabicQuestion = "كيف يمكنني الاشتراك بجائزة الشارقة للتفوق والتميز التربوي",
                    ArabicAnswer = "يمكنك المشاركة في الجائزة من خلال اتباع الخطوات التالية:\r\nالنقر على \"بوابة المشتركين\" في القائمة الرئيسية للموقع.\r\nإذا لم يكن لديك حساب في البوابة، يرجى إنشاء حساب مستخدم جديد بالنقر على خيار \"سجل الآن\"، وقم بتعبئة البيانات المطلوبة.\r\nإذا كان لديك حساب مسبق في البوابة، يرجى النقر على خيار \"لقد قمت بالتسجيل مسبقاً\"، وقم بتسجيل الدخول بإدخال اسم المستخدم وكلمة المرور.\r\nبعد الدخول إلى البوابة، يمكنك التسجيل في الفئة التي ترغب بها ورفع المستندات المطلوبة.\r\nيمكنك رفع الأدلة بجانب كل معيار من معايير الفئة.",
                    CategoryId = 2,
                    EnglishQuestion = "How can I participate in the Sharjah Award for Excellence and Educational Excellence?",
                    EnglishAnswer = "You can participate in the award by following the following steps:\r\nClick on “Subscribers Portal” in the main menu of the site.\r\nIf you do not have an account on the portal, please create a new user account by clicking on the “Register Now” option and filling out the required data.\r\nIf you already have an account on the portal, please click on the “I have already registered” option and log in by entering your username and password.\r\nAfter entering the portal, you can register in the category you desire and upload the required documents.\r\nYou can upload evidence next to each category criteria."
                }, new FrequentlyAskedQuestion()
                {
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    Id = 2,
                    ArabicQuestion = "كيف يمكنني الاشتراك بجائزة الشارقة للتفوق والتميز التربوي 2",
                    ArabicAnswer = "يمكنك المشاركة في الجائزة من خلال اتباع الخطوات التالية:\r\nالنقر على \"بوابة المشتركين\" في القائمة الرئيسية للموقع.\r\nإذا لم يكن لديك حساب في البوابة، يرجى إنشاء حساب مستخدم جديد بالنقر على خيار \"سجل الآن\"، وقم بتعبئة البيانات المطلوبة.\r\nإذا كان لديك حساب مسبق في البوابة، يرجى النقر على خيار \"لقد قمت بالتسجيل مسبقاً\"، وقم بتسجيل الدخول بإدخال اسم المستخدم وكلمة المرور.\r\nبعد الدخول إلى البوابة، يمكنك التسجيل في الفئة التي ترغب بها ورفع المستندات المطلوبة.\r\nيمكنك رفع الأدلة بجانب كل معيار من معايير الفئة. 2",
                    CategoryId = 2,
                    EnglishQuestion = "How can I participate in the Sharjah Award for Excellence and Educational Excellence? 2",
                    EnglishAnswer = "You can participate in the award by following the following steps:\r\nClick on “Subscribers Portal” in the main menu of the site.\r\nIf you do not have an account on the portal, please create a new user account by clicking on the “Register Now” option and filling out the required data.\r\nIf you already have an account on the portal, please click on the “I have already registered” option and log in by entering your username and password.\r\nAfter entering the portal, you can register in the category you desire and upload the required documents.\r\nYou can upload evidence next to each category criteria 2."
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

            modelBuilder.Entity<TermAndCondition>()
                .HasData(new TermAndCondition()
                {
                    Id = 1,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    ArabicDescription = "الموافقة على سياسة الخصوصية لهذه الفئة",
                    ArabicTitle = "الموافقة على سياسة الخصوصة",
                    AttachmentType = Domain.Constants.AttachmentConstant.AttachmentType.Pic,
                    CategoryId = 2,
                    EnglishDescription = "Accept on Privacy Term",
                    EnglishTitle = "Accept on Privacy Term",
                    IsAgree = false,
                    IsSpecial = true,
                    NeedAttachment = false,
                    RequiredAttachmentNumber = 0,
                    SizeOfAttachmentInKB = 0
                }, new TermAndCondition()
                {
                    Id = 2,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    ArabicDescription = "الموافقة على سياسة الخصوصية لهذه الفئة",
                    ArabicTitle = "الموافقة على سياسة الخصوصة",
                    AttachmentType = Domain.Constants.AttachmentConstant.AttachmentType.Pic,
                    CategoryId = 2,
                    EnglishDescription = "Accept on Privacy Term",
                    EnglishTitle = "Accept on Privacy Term",
                    IsAgree = false,
                    IsSpecial = false,
                    NeedAttachment = false,
                    RequiredAttachmentNumber = 0,
                    SizeOfAttachmentInKB = 0
                }, new TermAndCondition()
                {
                    Id = 3,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    ArabicDescription = "الهوية الشخصية",
                    ArabicTitle = "رفع صورة الهوية الشخصية (الامامي و الخلفي)",
                    AttachmentType = Domain.Constants.AttachmentConstant.AttachmentType.Pic,
                    CategoryId = 2,
                    EnglishDescription = "Id Card",
                    EnglishTitle = "Upload Photos of Id Card (Front and Back)",
                    IsAgree = false,
                    IsSpecial = false,
                    NeedAttachment = true,
                    RequiredAttachmentNumber = 2,
                    SizeOfAttachmentInKB = 1000
                }, new TermAndCondition()
                {
                    Id = 4,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    ArabicDescription = "الهوية الشخصية",
                    ArabicTitle = "رفع صورة الهوية الشخصية (الامامي و الخلفي)",
                    AttachmentType = Domain.Constants.AttachmentConstant.AttachmentType.Pic,
                    CategoryId = 2,
                    EnglishDescription = "Id Card",
                    EnglishTitle = "Upload Photos of Id Card (Front and Back)",
                    IsAgree = false,
                    IsSpecial = true,
                    NeedAttachment = true,
                    RequiredAttachmentNumber = 2,
                    SizeOfAttachmentInKB = 1000
                }, new TermAndCondition()
                {
                    Id = 5,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    ArabicDescription = "رفع الاثباتات العلمية",
                    ArabicTitle = "رفع الاثباتات العلمية",
                    AttachmentType = Domain.Constants.AttachmentConstant.AttachmentType.PDF,
                    CategoryId = 2,
                    EnglishDescription = "Upload Confirmation Documents",
                    EnglishTitle = "Upload Confirmation Documents",
                    IsAgree = false,
                    IsSpecial = true,
                    NeedAttachment = true,
                    RequiredAttachmentNumber = 0,
                    SizeOfAttachmentInKB = 1000
                }, new TermAndCondition()
                {
                    Id = 6,
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    ArabicDescription = "رفع الاثباتات العلمية",
                    ArabicTitle = "رفع الاثباتات العلمية",
                    AttachmentType = Domain.Constants.AttachmentConstant.AttachmentType.PDF,
                    CategoryId = 2,
                    EnglishDescription = "Upload Confirmation Documents",
                    EnglishTitle = "Upload Confirmation Documents",
                    IsAgree = false,
                    IsSpecial = false,
                    NeedAttachment = true,
                    RequiredAttachmentNumber = 0,
                    SizeOfAttachmentInKB = 1000
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
                    PhoneNumber="0993521579",
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

            modelBuilder.Entity<ProvidedForm>()
                .HasData(new ProvidedForm()
                {
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    categoryId = 2,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    CurrentStep = 1,
                    CycleYear = "2023-2024",
                    CycleNumber = 1,
                    PercentCompletion = 1,
                    Status = Domain.Constants.ProvidedFromConstants.ProvidedFormStatus.Active,
                    Type = Domain.Constants.ProvidedFromConstants.ProvidedFormType.Current,
                    userId = 1,
                    Id = 1
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
                    Id = 1
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
                    ArabicLabel = "اختبار نص 1",
                    ArabicPlaceHolder = "اختبار نص 1",
                    AttributeDataTypeId = 1,
                    DynamicAttributeSectionId = 1,
                    EnglishLabel = "Test Text 1",
                    EnglishPlaceHolder = "Test Text 1",
                    IsRequired = true,
                    IsUnique = true,
                    MaxSizeInKB = null,
                    Status = Domain.Constants.DynamicAttribute.DynamicAttributeStatus.Active,
                    LinkedToAnotherAttribute = false
                }, new DynamicAttribute()
                {
                    Id = 2,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicLabel = "اختبار ايميل 1",
                    ArabicPlaceHolder = "اختبار ايميل 1",
                    AttributeDataTypeId = 2,
                    DynamicAttributeSectionId = 1,
                    EnglishLabel = "Test Email 1",
                    EnglishPlaceHolder = "Test Email 1",
                    IsRequired = true,
                    IsUnique = true,
                    MaxSizeInKB = null,
                    Status = Domain.Constants.DynamicAttribute.DynamicAttributeStatus.Active,
                    LinkedToAnotherAttribute = false
                }, new DynamicAttribute()
                {
                    Id = 3,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicLabel = "اختبار صورة 1",
                    ArabicPlaceHolder = "اختبار صورة 1",
                    AttributeDataTypeId = 3,
                    DynamicAttributeSectionId = 1,
                    EnglishLabel = "Test Image 1",
                    EnglishPlaceHolder = "Test Image 1",
                    IsRequired = false,
                    IsUnique = false,
                    MaxSizeInKB = 1028,
                    Status = Domain.Constants.DynamicAttribute.DynamicAttributeStatus.Active,
                    LinkedToAnotherAttribute = false
                }, new DynamicAttribute()
                {
                    Id = 4,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicLabel = "اختبار ملف 1",
                    ArabicPlaceHolder = "اختبار ملف 1",
                    AttributeDataTypeId = 4,
                    DynamicAttributeSectionId = 1,
                    EnglishLabel = "Test File 1",
                    EnglishPlaceHolder = "Test File 1",
                    IsRequired = false,
                    IsUnique = false,
                    MaxSizeInKB = 4112,
                    Status = Domain.Constants.DynamicAttribute.DynamicAttributeStatus.Active,
                    LinkedToAnotherAttribute = false
                }, new DynamicAttribute()
                {
                    Id = 5,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicLabel = "اختبار رقم متحرك 1",
                    ArabicPlaceHolder = "اختبار رقم متحرك 1",
                    AttributeDataTypeId = 5,
                    DynamicAttributeSectionId = 1,
                    EnglishLabel = "Test Phone Number 1",
                    EnglishPlaceHolder = "Test Phone Number 1",
                    IsRequired = false,
                    IsUnique = false,
                    MaxSizeInKB = null,
                    Status = Domain.Constants.DynamicAttribute.DynamicAttributeStatus.Active,
                    LinkedToAnotherAttribute = false
                }, new DynamicAttribute()
                {
                    Id = 6,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicLabel = "اختبار رقم 1",
                    ArabicPlaceHolder = "اختبار رقم 1",
                    AttributeDataTypeId = 6,
                    DynamicAttributeSectionId = 1,
                    EnglishLabel = "Test Number 1",
                    EnglishPlaceHolder = "Test Number 1",
                    IsRequired = false,
                    IsUnique = false,
                    MaxSizeInKB = null,
                    Status = Domain.Constants.DynamicAttribute.DynamicAttributeStatus.Active,
                    LinkedToAnotherAttribute = false
                }, new DynamicAttribute()
                {
                    Id = 7,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicLabel = "اختبار تاريخ 1",
                    ArabicPlaceHolder = "اختبار تاريخ 1",
                    AttributeDataTypeId = 7,
                    DynamicAttributeSectionId = 1,
                    EnglishLabel = "Test Date 1",
                    EnglishPlaceHolder = "Test Date 1",
                    IsRequired = false,
                    IsUnique = false,
                    MaxSizeInKB = null,
                    Status = Domain.Constants.DynamicAttribute.DynamicAttributeStatus.Active,
                    LinkedToAnotherAttribute = false
                }, new DynamicAttribute()
                {
                    Id = 8,
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    ArabicLabel = "اختبار قائمة 1",
                    ArabicPlaceHolder = "اختبار قائمة 1",
                    AttributeDataTypeId = 8,
                    DynamicAttributeSectionId = 1,
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
