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
        public async Task Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SharijhaAwardDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<SharijhaAwardDbContext>>()))
            {
                var cycleSeeder = new CycleSeeder(context);
                await cycleSeeder.Seed();

                var permissionHeaderSeeder = new PermissionHeaderSeeder(context);
                await permissionHeaderSeeder.Seed();
                
                var permissionSeeder = new PermissionSeeder(context);
                await permissionSeeder.Seed();
                
                var userSeeder = new UserSeeder(context);
                await userSeeder.Seed();

                var coordinatorSeeder = new CoordinatorSeeder(context);
                await coordinatorSeeder.Seed();

                var roleSeeder = new RoleSeeder(context);
                await roleSeeder.Seed();

                var userRoleSeeder = new UserRoleSeeder(context);
                await userRoleSeeder.Seed();

                var categorySeeder = new CategorySeeder(context);
                await categorySeeder.Seed(); 
                
                var categoryFAQSeeder = new CategoryFAQSeeder(context);
                await categoryFAQSeeder.Seed();
                
                var FrequentlyAskedQuestionSeeder = new FrequentlyAskedQuestionSeeder(context);
                await FrequentlyAskedQuestionSeeder.Seed();

                var agendaSeeder = new AgendaSeeder(context);
                await agendaSeeder.Seed();

                var aboutAwardPageSeeder = new AboutAwardPageSeeder(context);
                await aboutAwardPageSeeder.Seed();

                var CriterionSeeder = new CriterionSeeder(context);
                await CriterionSeeder.Seed();

                var CriterionItemSeeder = new CriterionItemSeeder(context);
                await CriterionItemSeeder.Seed();

                var ArbitrationScaleSeeder = new ArbitrationScaleSeeder(context);
                await ArbitrationScaleSeeder.Seed();

                var ArbitrationScalesCriterionSeeder = new ArbitrationScalesCriterionSeeder(context);
                await ArbitrationScalesCriterionSeeder.Seed();

                
                var AttributeDataTypeSeeder = new AttributeDataTypeSeeder(context);
                await AttributeDataTypeSeeder.Seed();
                
                var AttributeOperationSeeder = new AttributeOperationSeeder(context);
                await AttributeOperationSeeder.Seed(); 
                
                var AttributeTableNameSeeder = new AttributeTableNameSeeder(context);
                await AttributeTableNameSeeder.Seed();
                
                var AwardSponsorSeeder = new AwardSponsorSeeder(context);
                await AwardSponsorSeeder.Seed();
                
                var AwardStatisticSeeder = new AwardStatisticSeeder(context);
                await AwardStatisticSeeder.Seed();

                var DynamicAttributeSectionSeeder = new DynamicAttributeSectionSeeder(context);
                await DynamicAttributeSectionSeeder.Seed();

                var DynamicAttributeSeeder = new DynamicAttributeSeeder(context);
                await DynamicAttributeSeeder.Seed();


                var DynamicAttributeListValueSeeder = new DynamicAttributeListValueSeeder(context);
                await DynamicAttributeListValueSeeder.Seed();
                
                
                var EducationalClassSeeder = new EducationalClassSeeder(context);
                await EducationalClassSeeder.Seed();

                var EducationalEntitySeeder = new EducationalEntitySeeder(context);
                await EducationalEntitySeeder.Seed();            
                
                var EducationalInstitutionSeeder = new EducationalInstitutionSeeder(context);
                await EducationalInstitutionSeeder.Seed(); 
                
                var EventSeeder = new EventSeeder(context);
                await EventSeeder.Seed();
                
                var ExplanatoryGuideSeeder = new ExplanatoryGuideSeeder(context);
                await ExplanatoryGuideSeeder.Seed();
                
                var ExplanatoryMessageSeeder = new ExplanatoryMessageSeeder(context);
                await ExplanatoryMessageSeeder.Seed();
                
                var GeneralFAQCategorySeeder = new GeneralFAQCategorySeeder(context);
                await GeneralFAQCategorySeeder.Seed();
                
                var GeneralFAQSeeder = new GeneralFAQSeeder(context);
                await GeneralFAQSeeder.Seed();
                
                var GeneralWorkshopSeeder = new GeneralWorkshopSeeder(context);
                await GeneralWorkshopSeeder.Seed();
                
                var InstructionSeeder = new InstructionSeeder(context);
                await InstructionSeeder.Seed();
                
                var NewsSeeder = new NewsSeeder(context);
                await NewsSeeder.Seed();
                
                var OnePageTextSeeder = new OnePageTextSeeder(context);
                await OnePageTextSeeder.Seed();
                
                var OurGoalSeeder = new OurGoalSeeder(context);
                await OurGoalSeeder.Seed();
                
                var ReferenceSourceSeeder = new ReferenceSourceSeeder(context);
                await ReferenceSourceSeeder.Seed();
                
                var RelatedAccountRequestSeeder = new RelatedAccountRequestSeeder(context);
                await RelatedAccountRequestSeeder.Seed();
                
                var RelatedAccountSeeder = new RelatedAccountSeeder(context);
                await RelatedAccountSeeder.Seed();
                
                var TermAndConditionSeeder = new TermAndConditionSeeder(context);
                await TermAndConditionSeeder.Seed();
                
                var TrainingWorkshopSeeder = new TrainingWorkshopSeeder(context);
                await TrainingWorkshopSeeder.Seed();

                var CustomPageSeerer = new CustomPageSeeder(context);
                await CustomPageSeerer.Seed();

                var RolePermissionSeeder = new RolePermissionSeeder(context);
                await RolePermissionSeeder.Seed();
            }
        }

        //public Task MakeMigration(IServiceProvider serviceProvider)
        //{

        //    Database.SetInitializer();
        //    using (var context = new SharijhaAwardDbContext(
        //         serviceProvider.GetRequiredService<DbContextOptions<SharijhaAwardDbContext>>()))
        //    {
                     
        //    }

            

        //}
    }
}
