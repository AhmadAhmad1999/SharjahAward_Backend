using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1.Crmf;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.EventModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.InvitationModels;
using SharijhaAward.Domain.Entities.CategoryCommitteeModel;
using SharijhaAward.Domain.Entities.CriterionItemScaleModel;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.SubscriberModel;
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

namespace SharijhaAward.Persistence
{
    public class SharijhaAwardDbContext : DbContext
    {
        public SharijhaAwardDbContext(DbContextOptions<SharijhaAwardDbContext> options)
        : base(options) 
        {
      
        }
        
        public DbSet<RelatedAccountRequest> RelatedAccountRequests { get; set; }
        public DbSet<FrequentlyAskedQuestion> frequentlyAskedQuestions { get; set; }
        public DbSet<GeneralFrequentlyAskedQuestion> GeneralFrequentlyAskedQuestions { get; set; }
        public DbSet<GeneralFrequentlyAskedQuestionCategory> GeneralFrequentlyAskedQuestionCategories { get; set; }
        public DbSet<TrainingWorkshop> trainingWorkshops { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<PersonalInvitee> Personalnvitees { get; set; }
        public DbSet<GroupInvitee> GroupInvitees { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CategoryCommittee> categoryCommittees { get; set; }
        public DbSet<CriterionItemScale> criterionItemScales { get; set; }
        public DbSet<TrainingWorkshopSubscriber> trainingWorkshopSubscribers { get; set; }
        public DbSet<Cycle> cycles { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }
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
        public DbSet<CategoryFAQ> categoryFAQs { get; set; }
        public DbSet<ExplanatoryGuide> explanatoryGuides { get; set; }
        public DbSet<CycleCondition> CycleCondition { get; set; }
        public DbSet<TrainingWrokshopeAttachment> TrainingWrokshopeAttachment { get; set; }
        public DbSet<ConditionAttachment> ConditionAttachments { get; set; }
        public DbSet<Coordinator> Coordinators { get; set; }
        public DbSet<EducationalEntity> EducationalEntities { get; set; }
        public DbSet<EduEntitiesCoordinator> EducationCoordinators { get; set; }
        public DbSet<EducationalInstitution> EducationalInstitutions { get; set; }
        public DbSet<EduInstitutionCoordinator> InstitutionCoordinators { get; set; }
        public DbSet<ConditionAttachment> conditionAttachments { get; set; }
        public DbSet<CriterionAttachment> CriterionAttachments { get; set; }
        public DbSet<Criterion> Criterions { get; set; }
        public DbSet<CriterionItem> CriterionItems { get; set; }
        public DbSet<CriterionItemAttachment> CriterionItemAttachments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Filter for Deleted items
            modelBuilder.Entity<CriterionAttachment>().HasQueryFilter(p => !p.isDeleted);
            modelBuilder.Entity<RelatedAccountRequest>().HasQueryFilter(p => !p.isDeleted);
            modelBuilder.Entity<Criterion>().HasQueryFilter(p => !p.isDeleted);
            modelBuilder.Entity<CriterionItem>().HasQueryFilter(p => !p.isDeleted);
            modelBuilder.Entity<CriterionItemAttachment>().HasQueryFilter(p => !p.isDeleted);
            modelBuilder.Entity<GeneralFrequentlyAskedQuestion>().HasQueryFilter(p => !p.isDeleted);
            modelBuilder.Entity<GeneralFrequentlyAskedQuestionCategory>().HasQueryFilter(p => !p.isDeleted);

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
            modelBuilder.Entity<GeneralFrequentlyAskedQuestionCategory>()
                .HasData(new GeneralFrequentlyAskedQuestionCategory()
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
                }, new GeneralFrequentlyAskedQuestionCategory()
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
            modelBuilder.Entity<GeneralFrequentlyAskedQuestion>()
                .HasData(new GeneralFrequentlyAskedQuestion()
                {
                    Id = new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
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
                }, new GeneralFrequentlyAskedQuestion()
                {
                    Id = new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
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
                }, new GeneralFrequentlyAskedQuestion()
                {
                    Id = new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
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
                }, new GeneralFrequentlyAskedQuestion()
                {
                    Id = new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
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

            modelBuilder.Entity<User>().ToTable("users");
            modelBuilder.Entity<Subscriber>().ToTable("subscribers");
            modelBuilder.Entity<Subscriber>().HasBaseType<User>();

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SharijhaAwardDbContext).Assembly);

            modelBuilder.Entity<Criterion>()
                .HasData(new Criterion()
                {
                    Id = new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    ArabicTitle = "معيار رئيسي 1",
                    CategoryId = new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                    EnglishTitle = "Main Criterion 1",
                    ParentId = null,
                    Score = 100
                }, new Criterion()
                {
                    Id = new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    ArabicTitle = "معيار فرعي 1",
                    CategoryId = new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                    EnglishTitle = "Sub Criterion 1",
                    ParentId = new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                    Score = 50,
                    SizeOfAttachmentInKB = 5000
                }, new Criterion()
                {
                    Id = new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    ArabicTitle = "معيار فرعي 2",
                    CategoryId = new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                    EnglishTitle = "Sub Criterion 2",
                    ParentId = new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                    Score = 50,
                    SizeOfAttachmentInKB = 5000
                });
            modelBuilder.Entity<CriterionItem>()
                .HasData(new CriterionItem()
                {
                    Id = new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    ActualScore = 0,
                    Score = 50,
                    ArabicName = "بند معيار فرعي 11",
                    CriterionId = new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                    EnglishName = "Sub Criterion Item 11",
                    SizeOfAttachmentInKB = 5000
                }, new CriterionItem()
                {
                    Id = new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"),
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    ActualScore = 0,
                    Score = 50,
                    ArabicName = "بند معيار فرعي 12",
                    CriterionId = new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                    EnglishName = "Sub Criterion Item 12",
                    SizeOfAttachmentInKB = 5000
                }, new CriterionItem()
                {
                    Id = new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    ActualScore = 0,
                    Score = 50,
                    ArabicName = "بند معيار فرعي 21",
                    CriterionId = new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                    EnglishName = "Sub Criterion Item 21",
                    SizeOfAttachmentInKB = 5000
                }, new CriterionItem()
                {
                    Id = new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"),
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    isDeleted = false,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    ActualScore = 0,
                    Score = 50,
                    ArabicName = "بند معيار فرعي 22",
                    CriterionId = new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
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
                 Id = new Guid("784454bd-2d6c-49ae-9e8a-1932bd15aac1"),
                 EnglishName = "SharijhaAward",
                 ArabicName ="جائزة الشارقة",    
                 Year = "2023-2024",
            });
            modelBuilder.Entity<Category>()
                .HasData(new Category()
                {
                    CreatedAt = DateTime.UtcNow,
                    CycleId = new Guid("784454bd-2d6c-49ae-9e8a-1932bd15aac1"),
                    DeletedAt = null,
                    EnglishDescription = "Test Description 1",
                    EnglishName = "Test Name 1",
                    ExpectedNumberOfWinners = 1,
                    FinalArbitrationEndDate = DateTime.UtcNow,
                    ArabicDescription = "اختبار وصف 1",
                    ArabicName = "اختبار اسم 1",
                    CategoryClassification = Domain.Constants.CategoryConstants.CategoryClassification.Individual,
                    CreatedBy = null,
                    FinalArbitrationQualificationMark = 0,
                    Icon = "string",
                    FinalArbitrationStartDate = DateTime.UtcNow,
                    InitialArbitrationEndDate = null,
                    isDeleted = false,
                    InitialArbitrationStartDate = DateTime.UtcNow,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    ParentId = null,
                    RelatedToClasses = false,
                    WinningScore = 0,
                    SubscriberPortalClosingDate = DateTime.UtcNow,
                    Status = Domain.Constants.Common.Status.Active,
                    Id = new Guid("81a2c75e-c71c-4213-a372-7626db57e79d")
                }, new Category()
                {
                    CreatedAt = DateTime.UtcNow,
                    CycleId = new Guid("784454bd-2d6c-49ae-9e8a-1932bd15aac1"),
                    DeletedAt = null,
                    EnglishDescription = "Test Description 2",
                    EnglishName = "Test Name 2",
                    ExpectedNumberOfWinners = 1,
                    FinalArbitrationEndDate = DateTime.UtcNow,
                    ArabicDescription = "اختبار وصف 2",
                    ArabicName = "اختبار اسم 2",
                    CategoryClassification = Domain.Constants.CategoryConstants.CategoryClassification.Individual,
                    CreatedBy = null,
                    FinalArbitrationQualificationMark = 0,
                    Icon = "string",
                    FinalArbitrationStartDate = DateTime.UtcNow,
                    InitialArbitrationEndDate = null,
                    isDeleted = false,
                    InitialArbitrationStartDate = DateTime.UtcNow,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    RelatedToClasses = false,
                    WinningScore = 0,
                    SubscriberPortalClosingDate = DateTime.UtcNow,
                    Status = Domain.Constants.Common.Status.Active,
                    Id = new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                    ParentId = new Guid("81a2c75e-c71c-4213-a372-7626db57e79d")
                });
            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    RoleId = new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                    RoleName = "Admin"
                });
                modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    RoleId = new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                    RoleName = "Subscriber"
                });
                modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    RoleId = new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                    RoleName = "Manager"

                });
                modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    RoleId = new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                    RoleName = "User"

                });
            modelBuilder.Entity<Role>().HasData(
                new Role 
                {
                    RoleId = new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                    RoleName = "Coordinator"
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
                    EnglishName = "Admin 123",
                    Gender = Gender.Male,
                    Password = "vO2sa5VimvnqRAqRbqHARyr9kG2rrXN6brfIXLU4ikM=",
                    RoleId = new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                    Id = new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                    ConfirmationCode = null,
                    PhoneNumber = "093517413"
                });
            modelBuilder.Entity<ProvidedForm>()
                .HasData(new ProvidedForm()
                {
                    isDeleted = false,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    categoryId = new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    CurrentStep = 1,
                    CycleYear = "2023-2024",
                    CycleNumber = 1,
                    PercentCompletion = 1,
                    Status = Domain.Constants.ProvidedFromConstants.ProvidedFormStatus.Active,
                    Type = Domain.Constants.ProvidedFromConstants.ProvidedFormType.Current,
                    userId = new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
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
                    RecordIdOnRelation = new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
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
                    IsRequired = false,
                    IsUnique = false,
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
                    IsRequired = false,
                    IsUnique = false,
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
            modelBuilder.Entity<Permission>().HasData
                (
                new Permission
                {
                    Id = new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                    Name = "AccessUsers"
                   

                },
                new Permission
                {
                    Id = new Guid("f00b7eb9-c7b9-4f35-8085-cdc97b8a0b47"),
                    Name = "ViewUsers"
                   

                },
                new Permission
                {
                    Id = new Guid("2df81130-cd8f-4d2e-823b-f3e6b353dba0"),
                    Name = "ShowUser"
                   
                },
                new Permission
                {
                    Id = new Guid("2df81130-cd8f-4d2e-823b-f3e6b353dba1"),
                    Name = "CreateUser"
                    
                },
                new Permission
                {
                    Id = new Guid("2df81130-cd8f-4d2e-823b-f3e6b353dba2"),
                    Name = "EditUser"
                   
                },
                new Permission
                {
                    Id = new Guid("2df81130-cd8f-4d2e-823b-f3e6b353dba3"),
                    Name = "RemoveUser"
                    
                },
                 new Permission
                 {
                     Id = new Guid("2df81130-cd8f-4d2e-823b-f3e6b353dba4"),
                     Name = "AccessRoles"
                     
                 },
                new Permission
                {
                    Id = new Guid("2df81130-cd8f-4d2e-823b-f3e6b353dba5"),
                    Name = "ViewRoles"
                },
                new Permission
                {
                    Id = new Guid("2df81130-cd8f-4d2e-823b-f3e6b353dba6"),
                    Name = "ViewRole"
                },
                new Permission
                {
                    Id = new Guid("2df81130-cd8f-4d2e-823b-f3e6b353dba7"),
                    Name = "EditRole"
                },
                new Permission
                {
                    Id = new Guid("2df81130-cd8f-4d2e-823b-f3e6b353dba8"),
                    Name = "RemoveRole"
                },
                new Permission
                {
                    Id = new Guid("2df81130-cd8f-4d2e-823b-f3e6b353dba9"),
                    Name = "AssignRole"
                }, new Permission
                {
                    Id = new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db10"),
                    Name = "AccessPermissions"
                },
                new Permission
                {
                    Id = new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db11"),
                    Name = "ViewPermissions"
                },
                new Permission
                {
                    Id = new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db12"),
                    Name = "ShowPermission"
                },
                new Permission
                {
                    Id = new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db13"),
                    Name = "CreatePermission"
                },
                new Permission
                {
                    Id = new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db14"),
                    Name = "EditPermission"
                },
                new Permission
                {
                    Id = new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db15"),
                    Name = "RemovePermission"
                },
                new Permission
                {
                    Id = new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db16"),
                    Name = "All"
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
