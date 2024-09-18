using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SharijhaAward.Application.Contract.Persistence;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence.Seeders
{
    public class SeedDatabase : ISeedDatabase
    {
        public void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SharijhaAwardDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<SharijhaAwardDbContext>>()))
            {
                var cycleSeeder = new CycleSeeder(context);
                cycleSeeder.Seed();

                var permissionHeaderSeeder = new PermissionHeaderSeeder(context);
                permissionHeaderSeeder.Seed();
                
                var permissionSeeder = new PermissionSeeder(context);
                permissionSeeder.Seed();
                
                var userSeeder = new UserSeeder(context);
                userSeeder.Seed();

                var coordinatorSeeder = new CoordinatorSeeder(context);
                coordinatorSeeder.Seed();

                var roleSeeder = new RoleSeeder(context);
                roleSeeder.Seed();

                var userRoleSeeder = new UserRoleSeeder(context);
                userRoleSeeder.Seed();

                var categorySeeder = new CategorySeeder(context);
                categorySeeder.Seed(); 
                
                var categoryFAQSeeder = new CategoryFAQSeeder(context);
                categoryFAQSeeder.Seed();
                
                var FrequentlyAskedQuestionSeeder = new FrequentlyAskedQuestionSeeder(context);
                FrequentlyAskedQuestionSeeder.Seed();

                var agendaSeeder = new AgendaSeeder(context);
                agendaSeeder.Seed();

                var aboutAwardPageSeeder = new AboutAwardPageSeeder(context);
                aboutAwardPageSeeder.Seed();

                var CriterionSeeder = new CriterionSeeder(context);
                CriterionSeeder.Seed();

                var CriterionItemSeeder = new CriterionItemSeeder(context);
                CriterionItemSeeder.Seed();

                var ArbitrationScaleSeeder = new ArbitrationScaleSeeder(context);
                ArbitrationScaleSeeder.Seed();

                var ArbitrationScalesCriterionSeeder = new ArbitrationScalesCriterionSeeder(context);
                ArbitrationScalesCriterionSeeder.Seed();

                
                var AttributeDataTypeSeeder = new AttributeDataTypeSeeder(context);
                AttributeDataTypeSeeder.Seed();
                
                var AttributeOperationSeeder = new AttributeOperationSeeder(context);
                AttributeOperationSeeder.Seed(); 
                
                var AttributeTableNameSeeder = new AttributeTableNameSeeder(context);
                AttributeTableNameSeeder.Seed();
                
                var AwardSponsorSeeder = new AwardSponsorSeeder(context);
                AwardSponsorSeeder.Seed();
                
                var AwardStatisticSeeder = new AwardStatisticSeeder(context);
                AwardStatisticSeeder.Seed();
                
                var CategoryFAQSeeder = new CategoryFAQSeeder(context);
                CategoryFAQSeeder.Seed();
                
                var CategorySeeder = new CategorySeeder(context);
                CategorySeeder.Seed();


                var DynamicAttributeSectionSeeder = new DynamicAttributeSectionSeeder(context);
                DynamicAttributeSectionSeeder.Seed();

                var DynamicAttributeSeeder = new DynamicAttributeSeeder(context);
                DynamicAttributeSeeder.Seed();


                var DynamicAttributeListValueSeeder = new DynamicAttributeListValueSeeder(context);
                DynamicAttributeListValueSeeder.Seed();
                
                
                var EducationalClassSeeder = new EducationalClassSeeder(context);
                EducationalClassSeeder.Seed();

                var EducationalEntitySeeder = new EducationalEntitySeeder(context);
                EducationalEntitySeeder.Seed();            
                
                var EducationalInstitutionSeeder = new EducationalInstitutionSeeder(context);
                EducationalInstitutionSeeder.Seed(); 
                
                var EventSeeder = new EventSeeder(context);
                EventSeeder.Seed();
                
                var ExplanatoryGuideSeeder = new ExplanatoryGuideSeeder(context);
                ExplanatoryGuideSeeder.Seed();
                
                var ExplanatoryMessageSeeder = new ExplanatoryMessageSeeder(context);
                ExplanatoryMessageSeeder.Seed();
                
                var GeneralFAQCategorySeeder = new GeneralFAQCategorySeeder(context);
                GeneralFAQCategorySeeder.Seed();
                
                var GeneralFAQSeeder = new GeneralFAQSeeder(context);
                GeneralFAQSeeder.Seed();
                
                var GeneralWorkshopSeeder = new GeneralWorkshopSeeder(context);
                GeneralWorkshopSeeder.Seed();
                
                var InstructionSeeder = new InstructionSeeder(context);
                InstructionSeeder.Seed();
                
                var NewsSeeder = new NewsSeeder(context);
                NewsSeeder.Seed();
                
                var OnePageTextSeeder = new OnePageTextSeeder(context);
                OnePageTextSeeder.Seed();
                
                var OurGoalSeeder = new OurGoalSeeder(context);
                OurGoalSeeder.Seed();
                
                var ReferenceSourceSeeder = new ReferenceSourceSeeder(context);
                ReferenceSourceSeeder.Seed();
                
                var RelatedAccountRequestSeeder = new RelatedAccountRequestSeeder(context);
                RelatedAccountRequestSeeder.Seed();
                
                var RelatedAccountSeeder = new RelatedAccountSeeder(context);
                RelatedAccountSeeder.Seed();
                
                var TermAndConditionSeeder = new TermAndConditionSeeder(context);
                TermAndConditionSeeder.Seed();
                
                var TrainingWorkshopSeeder = new TrainingWorkshopSeeder(context);
                TrainingWorkshopSeeder.Seed();
            }
        }

        //public void MakeMigration(IServiceProvider serviceProvider)
        //{

        //    Database.SetInitializer();
        //    using (var context = new SharijhaAwardDbContext(
        //         serviceProvider.GetRequiredService<DbContextOptions<SharijhaAwardDbContext>>()))
        //    {
                     
        //    }

            

        //}
    }
}
