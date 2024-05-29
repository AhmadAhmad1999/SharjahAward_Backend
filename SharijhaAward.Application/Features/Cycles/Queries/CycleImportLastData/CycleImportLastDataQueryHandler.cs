using MediatR;
using Microsoft.EntityFrameworkCore;
using NPOI.SS.Formula.Functions;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.CriterionModel;
using SharijhaAward.Domain.Entities.CycleConditionModel;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.ExplanatoryGuideModel;
using SharijhaAward.Domain.Entities.FAQModel;
using SharijhaAward.Domain.Entities.RewardModel;
using SharijhaAward.Domain.Entities.TermsAndConditionsModel;
using SharijhaAward.Domain.Entities.TrainingWorkshopModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Cycles.Queries.CycleImportLastData
{
    public class CycleImportLastDataQueryHandler
        : IRequestHandler<CycleImportLastDataQuery, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Cycle> _cycleRepository;
        private readonly IAsyncRepository<CycleCondition> _cycleConditionRepository;
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IAsyncRepository<ExplanatoryGuide> _explanatoryGuideRepository;
        private readonly IAsyncRepository<FrequentlyAskedQuestion> _faqRepository;
        private readonly IAsyncRepository<TermAndCondition> _termAndConditionRepository;
        private readonly IAsyncRepository<Criterion> _criterionRepository;
        private readonly IAsyncRepository<Reward> _rewardRepository;
        private readonly IAsyncRepository<TrainingWorkshop> _trainingWorkshopRepository;

        public CycleImportLastDataQueryHandler(IAsyncRepository<TrainingWorkshop> trainingWorkshopRepository,IAsyncRepository<Reward> rewardRepository,IAsyncRepository<Criterion> criterionRepository,IAsyncRepository<TermAndCondition> termAndConditionRepository,IAsyncRepository<FrequentlyAskedQuestion> faqRepository,IAsyncRepository<ExplanatoryGuide> explanatoryGuideRepository,IAsyncRepository<Category> categoryRepository,IAsyncRepository<Cycle> cycleRepository, IAsyncRepository<CycleCondition> cycleConditionRepository)
        {
            _rewardRepository = rewardRepository;
            _criterionRepository = criterionRepository;
            _faqRepository = faqRepository;
            _categoryRepository = categoryRepository;
            _cycleRepository = cycleRepository;
            _cycleConditionRepository = cycleConditionRepository;
            _termAndConditionRepository = termAndConditionRepository;
            _trainingWorkshopRepository = trainingWorkshopRepository;
            _explanatoryGuideRepository = explanatoryGuideRepository;
        }
        
        public async Task<BaseResponse<object>> Handle(CycleImportLastDataQuery request, CancellationToken cancellationToken)
        {
            var msg = request.lang == "en"
                ? "Cycle Data has been Imported"
                : "تم تعبئة بيانات الدورة";

            var cycle = await _cycleRepository.GetByIdAsync(request.CycleId);
            if(cycle == null)
            {
                msg = request.lang == "en"
                ? "Cycle not found"
                : "الدورة غير موجودة";

                return new BaseResponse<object>(msg, false, 404);
            }

            // Import Cycle Conditions (public conditions)
            if (request.ImportCycleConditions)
            {
                var cycleConditions = _cycleConditionRepository.Where(c => c.CycleId == cycle.Id).ToList();
                
                if (request.ReplaceCycleConditions)
                {
                    // Replce All Cycle Conditions
                    var cycleConditionsForNewCycle = _cycleConditionRepository.Where(c => c.CycleId == request.newCycleId).ToList();
                    await _cycleConditionRepository.DeleteListAsync(cycleConditionsForNewCycle); 
                }

                foreach(var cycleCondition in cycleConditions)
                {
                    cycleCondition.CycleId = request.newCycleId;
                    cycleCondition.Id = 0;
                }
                await _cycleConditionRepository.AddRangeAsync(cycleConditions);
            }
            // Import Categories
            if (request.ImportCategories)
            {
                if (request.ReplaceCategories)
                {
                    // Replace All Categories
                    var categoriesForNewCycle = _categoryRepository.Where(c => c.CycleId == request.newCycleId);
                    await _categoryRepository.DeleteListAsync(categoriesForNewCycle);
                }
                // get All Main Categories
                var MainCategories = _categoryRepository.Where(c => c.CycleId == cycle.Id && c.ParentId == null);
                
                
                foreach(var mainCategory in MainCategories)
                {
                    //get All Sub Categories
                    var SubCategories = _categoryRepository.Where(c => c.ParentId == mainCategory.Id && c.CycleId == cycle.Id).ToList();
                    
                    ExplanatoryGuide explanatoryGuide = null!;
                    List<FrequentlyAskedQuestion> faqs = null!;
                    List<TermAndCondition> termAndConditions = null!;
                    List<Criterion> criterions = null!;
                    List<Reward> rewards = null!;
                    List<TrainingWorkshop> trainingWorkshops = null!;
                    Category SubCategory = null!;

                    foreach (var subCategory in SubCategories)
                    {
                        SubCategory = subCategory;

                        if (request.ImportExplanatoryGuide == true)
                        {
                            explanatoryGuide = _explanatoryGuideRepository.FirstOrDefault(e => e.CategoryId == subCategory.Id)!;
                        }
                        if(request.ImportFAQs == true)
                        {
                            faqs = _faqRepository.Where(f => f.CategoryId == subCategory.Id).ToList();
                        }
                        if(request.ImportSpecialConditions == true)
                        {
                            termAndConditions = _termAndConditionRepository.Where(t => t.CategoryId == subCategory.Id).ToList();
                        }
                        if(request.ImportCriterions == true)
                        {
                            criterions = _criterionRepository.Where(c => c.CategoryId == subCategory.Id).ToList();
                        }
                        if(request.ImportRewards == true)
                        {
                            rewards = _rewardRepository.Where(r => r.CategoryId == subCategory.Id).ToList();
                        }
                        if(request.ImportTrainingWorkshop == true)
                        {
                            trainingWorkshops = _trainingWorkshopRepository.Where(t => t.CategoryId == subCategory.Id).ToList();
                        }
                    }
                    mainCategory.Id = 0;
                    mainCategory.CycleId = request.newCycleId;
                    var main = await _categoryRepository.AddAsync(mainCategory);

                    SubCategory.Id = 0;
                    SubCategory.ParentId = main.Id;
                    SubCategory.CycleId = request.newCycleId;
                    var sub = await _categoryRepository.AddAsync(SubCategory);

                    explanatoryGuide.Id = 0;
                    explanatoryGuide.CategoryId = sub.Id;
                    await _explanatoryGuideRepository.AddAsync(explanatoryGuide);

                    foreach(var faq in faqs)
                    {
                        faq.Id = 0;
                        faq.CategoryId = sub.Id;
                    }
                    foreach (var term in termAndConditions)
                    {
                        term.Id = 0;
                        term.CategoryId = sub.Id;
                    }
                    foreach (var criterion in criterions)
                    {
                        criterion.Id = 0;
                        criterion.CategoryId = sub.Id;
                    }
                    foreach (var reward in rewards)
                    {
                        reward.Id = 0;
                        reward.CategoryId = sub.Id;
                    }
                    foreach (var trainingWorkshop in trainingWorkshops)
                    {
                        trainingWorkshop.Id = 0;
                        trainingWorkshop.CategoryId = sub.Id;
                    }

                    await _faqRepository.AddRangeAsync(faqs);
                    await _termAndConditionRepository.AddRangeAsync(termAndConditions);
                    await _criterionRepository.AddRangeAsync(criterions);
                    await _rewardRepository.AddRangeAsync(rewards);
                    await _trainingWorkshopRepository.AddRangeAsync(trainingWorkshops);
                }
             
            }
            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
