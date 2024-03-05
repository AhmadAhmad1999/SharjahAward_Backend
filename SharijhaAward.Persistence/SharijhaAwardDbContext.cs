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
using SharijhaAward.Domain.Entities.AttachmentModel;
using System.Net.Mail;
using SharijhaAward.Domain.Entities.CategoryFAQ;
using SharijhaAward.Domain.Entities.ExplanatoryGuideModel;

namespace SharijhaAward.Persistence
{
    public class SharijhaAwardDbContext : DbContext
    {
        public SharijhaAwardDbContext(DbContextOptions<SharijhaAwardDbContext> options)
        : base(options) 
        {
      
        }
        
        public DbSet<FrequentlyAskedQuestion> frequentlyAskedQuestions { get; set; }
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
        public DbSet<EducationType> EducationTypes { get; set; }
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
        public DbSet<ConditionsAttachment> Attachments { get; set; }
        public DbSet<DynamicAttributePattern> DynamicAttributePatterns {  get; set; }
        public DbSet<DynamicAttributePatternValue> DynamicAttributePatternValues {  get; set; }
        public DbSet<CategoryFAQ> categoryFAQs { get; set; }
        public DbSet<ExplanatoryGuide> explanatoryGuides { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Filter for Deleted items
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
            modelBuilder.Entity<ConditionsAttachment>().HasQueryFilter(p => !p.isDeleted);
            modelBuilder.Entity<DynamicAttributePattern>().HasQueryFilter(p => !p.isDeleted);
            modelBuilder.Entity<DynamicAttributePatternValue>().HasQueryFilter(p => !p.isDeleted);
            modelBuilder.Entity<ProvidedForm>().HasQueryFilter(p => !p.isDeleted);
            modelBuilder.Entity<CategoryFAQ>().HasQueryFilter(p => !p.isDeleted);
            modelBuilder.Entity<ExplanatoryGuide>().HasQueryFilter(p => !p.isDeleted);

            modelBuilder.Entity<AttributeTableName>()
                .HasData(new AttributeTableName()
                {
                    Id = 1,
                    Name = "Category",
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
