using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.CriterionItemModel;
using SharijhaAward.Domain.Entities.CriterionModel;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.ExplanatoryGuideModel;
using SharijhaAward.Domain.Entities.FAQModel;
using SharijhaAward.Domain.Entities.RewardModel;
using SharijhaAward.Domain.Entities.TermsAndConditionsModel;
using SharijhaAward.Domain.Entities.TrainingWorkshopModel;

namespace SharijhaAward.Application.Features.Cycles.Queries.GetAllCategoriesWithAllItsData
{
    public class GetAllCategoriesWithAllItsDataHandler 
        : IRequestHandler<GetAllCategoriesWithAllItsDataQuery, BaseResponse<List<MainCategoryDataDto>>>
    {
        private readonly IAsyncRepository<Cycle> _CycleRepository;
        private readonly IAsyncRepository<Category> _CategoryRepository;
        private readonly IAsyncRepository<TermAndCondition> _TermAndConditionRepository;
        private readonly IAsyncRepository<ExplanatoryGuide> _ExplanatoryGuideRepository;
        private readonly IAsyncRepository<TrainingWorkshop> _TrainingWorkshopRepository;
        private readonly IAsyncRepository<FrequentlyAskedQuestion> _FrequentlyAskedQuestionRepository;
        private readonly IAsyncRepository<Reward> _RewardRepository;
        private readonly IAsyncRepository<Criterion> _CriterionRepository;
        private readonly IAsyncRepository<CriterionItem> _CriterionItemRepository;

        public GetAllCategoriesWithAllItsDataHandler(IAsyncRepository<Cycle> _CycleRepository,
            IAsyncRepository<Category> _CategoryRepository,
            IAsyncRepository<TermAndCondition> _TermAndConditionRepository,
            IAsyncRepository<ExplanatoryGuide> _ExplanatoryGuideRepository,
            IAsyncRepository<TrainingWorkshop> _TrainingWorkshopRepository,
            IAsyncRepository<FrequentlyAskedQuestion> _FrequentlyAskedQuestionRepository,
            IAsyncRepository<Reward> _RewardRepository,
            IAsyncRepository<Criterion> _CriterionRepository,
            IAsyncRepository<CriterionItem> _CriterionItemRepository)
        {
            this._CycleRepository = _CycleRepository;
            this._CategoryRepository = _CategoryRepository;
            this._TermAndConditionRepository = _TermAndConditionRepository;
            this._ExplanatoryGuideRepository = _ExplanatoryGuideRepository;
            this._TrainingWorkshopRepository = _TrainingWorkshopRepository;
            this._FrequentlyAskedQuestionRepository = _FrequentlyAskedQuestionRepository;
            this._RewardRepository = _RewardRepository;
            this._CriterionRepository = _CriterionRepository;
            this._CriterionItemRepository = _CriterionItemRepository;
        }

        public async Task<BaseResponse<List<MainCategoryDataDto>>>
            Handle(GetAllCategoriesWithAllItsDataQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Cycle? CheckCycle = await _CycleRepository
                .FirstOrDefaultAsync(x => x.Id == Request.CycleId);

            if (CheckCycle is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Cycle is not found"
                    : "الدورة غير موجودة";

                return new BaseResponse<List<MainCategoryDataDto>>(ResponseMessage, false, 404);
            }

            List<Category> AllCategoriesInCycle = await _CategoryRepository
                .Where(x => x.CycleId == Request.CycleId)
                .Include(x => x.Parent!)
                .ToListAsync();

            IEnumerable<Category> MainCategories = AllCategoriesInCycle
                .Where(x => x.ParentId == null);

            IEnumerable<Category> SubCategories = AllCategoriesInCycle
                .Where(x => x.ParentId != null);

            IEnumerable<InsertedDataDto> TermAndConditionEntities = await _TermAndConditionRepository
                .Where(x => SubCategories.Select(y => y.Id).Contains(x.CategoryId))
                .Select(x => new InsertedDataDto()
                {
                    Id = x.Id,
                    Name = Request.lang == "en"
                        ? x.EnglishTitle
                        : x.ArabicTitle,
                    ParentId = x.CategoryId
                }).ToListAsync();

            IEnumerable<InsertedDataDto> ExplanatoryGuideEntities = await _ExplanatoryGuideRepository
                .Where(x => SubCategories.Select(y => y.Id).Contains(x.CategoryId))
                .Select(x => new InsertedDataDto()
                {
                    Id = x.Id,
                    Name = Request.lang == "en"
                        ? x.EnglishTitle
                        : x.ArabicTitle,
                    ParentId = x.CategoryId
                }).ToListAsync();

            IEnumerable<InsertedDataDto> TrainingWorkshopEntities = await _TrainingWorkshopRepository
                .Where(x => SubCategories.Select(y => y.Id).Contains(x.CategoryId))
                .Select(x => new InsertedDataDto()
                {
                    Id = x.Id,
                    Name = Request.lang == "en"
                        ? x.EnglishTitle
                        : x.ArabicTitle,
                    ParentId = x.CategoryId
                }).ToListAsync();

            IEnumerable<InsertedDataDto> FrequentlyAskedQuestionEnitities = await _FrequentlyAskedQuestionRepository
                .Where(x => SubCategories.Select(y => y.Id).Contains(x.CategoryId))
                .Select(x => new InsertedDataDto()
                {
                    Id = x.Id,
                    Name = Request.lang == "en"
                        ? x.EnglishQuestion
                        : x.ArabicQuestion,
                    ParentId = x.CategoryId
                }).ToListAsync();

            IEnumerable<InsertedDataDto> RewardEntities = await _RewardRepository
                .Where(x => SubCategories.Select(y => y.Id).Contains(x.CategoryId))
                .Select(x => new InsertedDataDto()
                {
                    Id = x.Id,
                    Name = Request.lang == "en"
                        ? x.EnglishRank
                        : x.ArabicRank,
                    ParentId = x.CategoryId
                }).ToListAsync();

            List<Criterion> AllCriterionsEntities = await _CriterionRepository
                .Where(x => SubCategories.Select(y => y.Id).Contains(x.CategoryId))
                .ToListAsync();

            IEnumerable<Criterion> MainCriterionEntities = AllCriterionsEntities
                .Where(x => x.ParentId == null);

            IEnumerable<Criterion> SubCriterionEntities = AllCriterionsEntities
                .Where(x => x.ParentId != null);

            IEnumerable<InsertedDataDto> CriterionItemEntities = await _CriterionItemRepository
                .Where(x => SubCriterionEntities.Select(y => y.Id).Contains(x.CriterionId))
                .Select(x => new InsertedDataDto()
                {
                    Id = x.Id,
                    Name = Request.lang == "en"
                        ? x.EnglishName
                        : x.ArabicName,
                    ParentId = x.CriterionId
                }).ToListAsync();

            List<MainCategoryDataDto> MainCategoryDataDto = MainCategories
                .Select(x => new MainCategoryDataDto()
                {
                    Id = x.Id,
                    Name = Request.lang == "en"
                        ? x.EnglishName
                        : x.ArabicName,
                    SubCriterionDataDto = SubCategories
                        .Where(y => y.ParentId == x.Id)
                        .Select(y => new SubCategoryDataDto()
                        {
                            Id = y.Id,
                            Name = Request.lang == "en"
                                ? y.EnglishName
                                : y.ArabicName,
                            TermAndConditionsIds = TermAndConditionEntities
                                .Where(z => z.ParentId == y.Id)
                                .ToList(),
                            TakeTheExplanatoryGuide = ExplanatoryGuideEntities.Any(z => z.ParentId == y.Id)
                                ? new List<InsertedDataDto>()
                                {
                                    ExplanatoryGuideEntities.FirstOrDefault(z => z.ParentId == y.Id)!
                                } : new List<InsertedDataDto>(),
                            TrainingWorkshopsIds = TrainingWorkshopEntities
                                .Where(z => z.ParentId == y.Id)
                                .ToList(),
                            FrequentlyAskedQuestionsIds = FrequentlyAskedQuestionEnitities
                                .Where(z => z.ParentId == y.Id)
                                .ToList(),
                            RewardsIds = RewardEntities
                                .Where(z => z.ParentId == y.Id)
                                .ToList(),
                            MainCriterionImport = MainCriterionEntities
                                .Where(z => z.CategoryId ==  y.Id)
                                .Select(z => new MainCriterionDataDto()
                                {
                                    Id = z.Id,
                                    Name = Request.lang == "en"
                                        ? z.EnglishTitle
                                        : z.ArabicTitle,
                                    SubCriterionDataDto = SubCriterionEntities
                                        .Where(w => w.ParentId == z.Id)
                                        .Select(w => new SubCriterionDataDto()
                                        {
                                            Id = w.Id,
                                            Name = Request.lang == "en"
                                                ? w.EnglishTitle
                                                : w.ArabicTitle,
                                            SubCriterionItemDataDto = CriterionItemEntities
                                                .Where(u => u.ParentId == w.Id)
                                                .ToList()
                                        }).ToList()
                                }).ToList()
                        }).ToList()
                }).ToList();

            return new BaseResponse<List<MainCategoryDataDto>>(ResponseMessage, true, 200, MainCategoryDataDto);
        }
    }
}