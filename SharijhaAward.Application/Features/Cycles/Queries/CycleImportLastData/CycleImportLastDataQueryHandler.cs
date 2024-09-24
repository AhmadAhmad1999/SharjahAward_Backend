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
            
            var newCycle = await _cycleRepository.GetByIdAsync(request.newCycleId);
            if(newCycle == null)
            {
                msg = request.lang == "en"
                ? "Cycle not found"
                : "الدورة غير موجودة";

                return new BaseResponse<object>(msg, false, 404);
            }

            // Import Cycle Conditions (public conditions)
            if (request.ImportCycleConditions != null && request.ImportCycleConditions == true)
            {
                var cycleConditions = request.CycleConditionIds!.Count() > 0 
                    ? _cycleConditionRepository.Where(c => c.CycleId == cycle.Id && request.CycleConditionIds!.Contains(c.Id)).ToList()
                    : _cycleConditionRepository.Where(c => c.CycleId == cycle.Id).ToList();
                
                if (request.ReplaceCycleConditions != null && request.ReplaceCycleConditions == true)
                {
                    // Replce All Cycle Conditions
                    var cycleConditionsForNewCycle = _cycleConditionRepository.Where(c => c.CycleId == request.newCycleId).ToList();
                    await _cycleConditionRepository.DeleteListAsync(cycleConditionsForNewCycle); 
                }

                foreach(var cycleCondition in cycleConditions)
                {
                    cycleCondition.Cycle = newCycle;
                    cycleCondition.CycleId = request.newCycleId;
                    cycleCondition.Id = 0;
                }
                await _cycleConditionRepository.AddRangeAsync(cycleConditions);
            }
            // Import Categories
            if (request.ImportCategories != null && request.ImportCategories == true)
            {
                if (request.ReplaceCategories != null && request.ReplaceCategories == true)
                {
                    // Replace All Categories
                    var categoriesForNewCycle = _categoryRepository.IncludeThenWhere(x => x.Parent!, c => c.CycleId == request.newCycleId);
                    await _categoryRepository.DeleteListAsync(categoriesForNewCycle);
                }
                // get All Main Categories
                //var MainCategories = _categoryRepository.Where(c => c.CycleId == cycle.Id && c.ParentId == null);
               
                var MainCategories = request.CategoryIds!.Count() > 0
                   ? _categoryRepository
                        .Where(c => c.CycleId == cycle.Id && c.ParentId == null && request.CategoryIds!.Contains(c.Id)).ToList()
                   : _categoryRepository.Where(c => c.CycleId == cycle.Id && c.ParentId == null).ToList();

                foreach (var mainCategory in MainCategories)
                {
                    //get All Sub Categories
                    //var SubCategories = _categoryRepository.Where(c => c.ParentId == mainCategory.Id && c.CycleId == cycle.Id).ToList();

                    var SubCategories = request.SubCategoryIds!.Count() > 0
                   ? _categoryRepository
                        .IncludeThenWhere(x => x.Parent!, c => c.ParentId == mainCategory.Id && c.CycleId == cycle.Id && request.SubCategoryIds!.Contains(c.Id))
                        .ToList()
                   : _categoryRepository.IncludeThenWhere(x => x.Parent!, c => c.ParentId == mainCategory.Id && c.CycleId == cycle.Id).ToList();

                    ExplanatoryGuide explanatoryGuide = null!;
                    List<FrequentlyAskedQuestion> faqs = null!;
                    List<TermAndCondition> termAndConditions = null!;
                    List<Criterion> criterions = null!;
                    List<Reward> rewards = null!;
                    List<TrainingWorkshop> trainingWorkshops = null!;
                    Category SubCategory = null!;

                    mainCategory.Id = 0;
                    mainCategory.Cycle = newCycle!;
                    mainCategory.CycleId = request.newCycleId;
                    var main = await _categoryRepository.AddAsync(mainCategory);

                    foreach (var subCategory in SubCategories)
                    {
                        SubCategory = subCategory;

                        if (request.ImportExplanatoryGuide == true)
                        {
                            explanatoryGuide = _explanatoryGuideRepository.FirstOrDefault(e => e.CategoryId == subCategory.Id)!;
                        }
                        if(request.ImportFAQs == true)
                        {
                            faqs = request.FAQIds!.Count() > 0
                                 ? _faqRepository.Where(f => f.CategoryId == subCategory.Id &&  request.FAQIds!.Contains(f.Id)).ToList()
                                 : _faqRepository.Where(f => f.CategoryId == subCategory.Id).ToList();

                            //faqs = _faqRepository.Where(f => f.CategoryId == subCategory.Id).ToList();
                        }
                        if(request.ImportSpecialConditions == true)
                        {
                            termAndConditions = request.SpecialConditionIds!.Count() > 0
                                 ? _termAndConditionRepository.Where(t => t.CategoryId == subCategory.Id && request.SpecialConditionIds!.Contains(t.Id)).ToList()
                                 : _termAndConditionRepository.Where(t => t.CategoryId == subCategory.Id).ToList();

                            //termAndConditions = _termAndConditionRepository.Where(t => t.CategoryId == subCategory.Id).ToList();
                        }
                        if(request.ImportCriterions == true)
                        {
                            criterions = request.CriterionIds!.Count() > 0
                                 ? _criterionRepository
                                    .IncludeThenWhere(x => x.Parent!, c => c.CategoryId == subCategory.Id && request.CriterionIds!.Contains(c.Id)).ToList()
                                 : _criterionRepository.IncludeThenWhere(x => x.Parent!, c => c.CategoryId == subCategory.Id).ToList();
                            
                            //criterions = _criterionRepository.Where(c => c.CategoryId == subCategory.Id).ToList();
                        }
                        if(request.ImportRewards == true)
                        {
                            rewards = request.RewardIds!.Count() > 0
                                 ? _rewardRepository.Where(r => r.CategoryId == subCategory.Id && request.RewardIds!.Contains(r.Id)).ToList()
                                 : _rewardRepository.Where(r => r.CategoryId == subCategory.Id).ToList();

                            //rewards = _rewardRepository.Where(r => r.CategoryId == subCategory.Id).ToList();
                        }
                        if(request.ImportTrainingWorkshop == true)
                        {
                            trainingWorkshops = request.TrainingWorkshopIds!.Count() > 0
                                 ? _trainingWorkshopRepository.Where(t => t.CategoryId == subCategory.Id && request.TrainingWorkshopIds!.Contains(t.Id)).ToList()
                                 : _trainingWorkshopRepository.Where(t => t.CategoryId == subCategory.Id).ToList();

                            //trainingWorkshops = _trainingWorkshopRepository.Where(t => t.CategoryId == subCategory.Id).ToList();
                        }
                    


                        SubCategory.Id = 0;
                        SubCategory.Parent = main;
                        SubCategory.ParentId = main.Id;
                        SubCategory.Cycle = newCycle;
                        SubCategory.CycleId = request.newCycleId;
                        var sub = await _categoryRepository.AddAsync(SubCategory);

                        if (request.ImportExplanatoryGuide == true && explanatoryGuide != null)
                        {
                            explanatoryGuide.Id = 0;
                            explanatoryGuide.Category = sub;
                            explanatoryGuide.CategoryId = sub.Id;
                            await _explanatoryGuideRepository.AddAsync(explanatoryGuide);
                        }
                    
                        if(request.ImportFAQs == true)
                        {
                            foreach (var faq in faqs)
                            {
                                faq.Id = 0;
                                faq.Category = sub;
                                faq.CategoryId = sub.Id;
                            }
                            await _faqRepository.AddRangeAsync(faqs);
                        }

                        if(request.ImportSpecialConditions == true)
                        {
                            foreach (var term in termAndConditions)
                            {
                                term.Id = 0;
                                term.Category = sub;
                                term.CategoryId = sub.Id;
                            }
                            await _termAndConditionRepository.AddRangeAsync(termAndConditions);
                        }
                    
                   

                        if (request.ImportCriterions == true)
                        {
                            foreach (var criterion in criterions)
                            {
                                criterion.Id = 0;
                                criterion.Category = sub;
                                criterion.CategoryId = sub.Id;
                            }
                            await _criterionRepository.AddRangeAsync(criterions);
                        }


                        if (request.ImportRewards == true)
                        {
                            foreach (var reward in rewards)
                            {
                                reward.Id = 0;
                                reward.Category = sub;
                                reward.CategoryId = sub.Id;
                            }

                            await _rewardRepository.AddRangeAsync(rewards);
                        }
                    

                        if (request.ImportTrainingWorkshop == true)
                        {
                            foreach (var trainingWorkshop in trainingWorkshops)
                            {
                                trainingWorkshop.Id = 0;
                                trainingWorkshop.Category = sub;
                                trainingWorkshop.CategoryId = sub.Id;
                            }
                            await _trainingWorkshopRepository.AddRangeAsync(trainingWorkshops);

                        }
                    }
                }
             
            }
            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
