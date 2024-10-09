using AutoMapper;
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

namespace SharijhaAward.Application.Features.Cycles.Commands.ImportFromOldCycle
{
    public class ImportFromOldCycleHandler
        : IRequestHandler<ImportFromOldCycleCommand, BaseResponse<object>>
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
        private readonly IMapper _Mapper;
        public ImportFromOldCycleHandler(IAsyncRepository<Cycle> _CycleRepository,
            IAsyncRepository<Category> _CategoryRepository,
            IAsyncRepository<TermAndCondition> _TermAndConditionRepository,
            IAsyncRepository<ExplanatoryGuide> _ExplanatoryGuideRepository,
            IAsyncRepository<TrainingWorkshop> _TrainingWorkshopRepository,
            IAsyncRepository<FrequentlyAskedQuestion> _FrequentlyAskedQuestionRepository,
            IAsyncRepository<Reward> _RewardRepository,
            IAsyncRepository<Criterion> _CriterionRepository,
            IAsyncRepository<CriterionItem> _CriterionItemRepository,
            IMapper _Mapper)
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
            this._Mapper = _Mapper;
        }
        public async Task<BaseResponse<object>> Handle(ImportFromOldCycleCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Cycle? CheckCycleId = await _CycleRepository
                .FirstOrDefaultAsync(x => x.Id == Request.NewCycleId);

            if (CheckCycleId is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Cycle is not found"
                    : "الدورة غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            IEnumerable<int> MainCategoryImportIds = Request.MainCategoryImport
                .Select(x => x.Id);

            IEnumerable<int> SubCategoryImportIds = Request.MainCategoryImport
                .SelectMany(x => x.SubCategoryImport)
                .Select(x => x.Id);
            
            List<Category> CategoryEntities = new List<Category>();
            List<Criterion> CriterionEntitites = new List<Criterion>();
            List<CriterionItem> CriterionItemEntitites = new List<CriterionItem>();

            if (MainCategoryImportIds.Any() ||
                SubCategoryImportIds.Any())
            {
                CategoryEntities = await _CategoryRepository
                    .Where(x => (MainCategoryImportIds.Contains(x.Id) && x.ParentId == null) ||
                        (SubCategoryImportIds.Contains(x.Id) && x.ParentId != null))
                    .ToListAsync();

                IEnumerable<MainCriterionImport> MainCriterionImport = Request.MainCategoryImport
                    .SelectMany(x => x.SubCategoryImport)
                    .SelectMany(x => x.MainCriterionImport);

                IEnumerable<SubCriterionImport> SubCriterionImport = MainCriterionImport
                    .SelectMany(x => x.SubCriterionImport);

                if (MainCriterionImport.Any() ||
                    SubCriterionImport.Any())
                {
                    CriterionEntitites = await _CriterionRepository
                        .Where(x => (MainCriterionImport.Select(y => y.Id).Contains(x.Id) && x.ParentId == null) ||
                            (SubCriterionImport.Select(y => y.Id).Contains(x.Id) && x.ParentId != null))
                        .ToListAsync();

                    IEnumerable<int> SubCriterionItemsIds = SubCriterionImport
                        .SelectMany(x => x.SubCriterionItemsIds);

                    if (SubCriterionItemsIds.Any())
                    {
                        CriterionItemEntitites = await _CriterionItemRepository
                            .Where(x => SubCriterionItemsIds.Contains(x.Id))
                            .ToListAsync();
                    }
                }
            }

            // MainCategoryImport
            foreach (MainCategoryImport MainCategoryRequest in Request.MainCategoryImport)
            {
                int MainCategoryId = 0;

                if (MainCategoryRequest.TakeThisLevel && MainCategoryRequest.NewMainCategoryId is null)
                {
                    Category NewMainCategoryEntity = _Mapper.Map<Category>(CategoryEntities
                        .FirstOrDefault(x => x.Id == MainCategoryRequest.Id));

                    NewMainCategoryEntity.Id = 0;
                    NewMainCategoryEntity.CycleId = Request.NewCycleId;

                    await _CategoryRepository.AddAsync(NewMainCategoryEntity);

                    MainCategoryId = NewMainCategoryEntity.Id;

                    // SubCategoryImport
                    foreach (SubCategoryImport SubCategoryRequest in MainCategoryRequest.SubCategoryImport)
                    {
                        int SubCategoryId = 0;

                        if (SubCategoryRequest.TakeThisLevel && SubCategoryRequest.NewSubCategoryId is null)
                        {
                            Category NewSubCategoryEntity = _Mapper.Map<Category>(CategoryEntities
                                .FirstOrDefault(x => x.Id == SubCategoryRequest.Id));

                            NewSubCategoryEntity.Id = 0;
                            NewSubCategoryEntity.ParentId = MainCategoryId;

                            await _CategoryRepository.AddAsync(NewSubCategoryEntity);

                            SubCategoryId = NewSubCategoryEntity.Id;
                        }
                        else if (!SubCategoryRequest.TakeThisLevel && SubCategoryRequest.NewSubCategoryId is not null)
                        {
                            SubCategoryId = SubCategoryRequest.NewSubCategoryId.Value;
                        }

                        // TermAndConditionsIds
                        if (SubCategoryRequest.TermAndConditionsIds.Any())
                            await CopyTermAndConditions(SubCategoryRequest.TermAndConditionsIds, SubCategoryId);

                        // TakeTheExplanatoryGuide
                        if (SubCategoryRequest.TakeTheExplanatoryGuide)
                            await CopyExplanatoryGuide(SubCategoryRequest.Id, SubCategoryId);

                        // TrainingWorkshopsIds
                        if (SubCategoryRequest.TrainingWorkshopsIds.Any())
                            await CopyTrainingWorkshops(SubCategoryRequest.TrainingWorkshopsIds, SubCategoryId);

                        // FrequentlyAskedQuestionsIds
                        if (SubCategoryRequest.FrequentlyAskedQuestionsIds.Any())
                            await CopyFrequentlyAskedQuestions(SubCategoryRequest.FrequentlyAskedQuestionsIds, SubCategoryId);

                        // RewardsIds
                        if (SubCategoryRequest.RewardsIds.Any())
                            await CopyRewardsIds(SubCategoryRequest.RewardsIds, SubCategoryId);

                        // MainCriterionImport + SubCriterionImport
                        if (SubCategoryRequest.MainCriterionImport.Any())
                        {
                            IEnumerable<int> MainCriterionImportIds = SubCategoryRequest.MainCriterionImport.Select(x => x.Id);

                            IEnumerable<SubCriterionImport> SubCriterionImportRequest = SubCategoryRequest.MainCriterionImport
                                .SelectMany(x => x.SubCriterionImport);

                            IEnumerable<int> SubCriterionImportIds = SubCriterionImportRequest
                                .Select(x => x.Id);

                            if (MainCriterionImportIds.Any() ||
                                SubCriterionImportIds.Any())
                            {
                                IEnumerable<Criterion> NewCriterionEntities = CriterionEntitites
                                    .Where(x => (MainCriterionImportIds.Contains(x.Id) && x.ParentId == null) ||
                                        (SubCriterionImportIds.Contains(x.Id) && x.ParentId != null))
                                    .Select(x => new Criterion()
                                    {
                                        Id = 0,
                                        CategoryId = SubCategoryId,
                                        OrderId = x.OrderId,
                                        ArabicTitle = x.ArabicTitle,
                                        EnglishTitle = x.EnglishTitle,
                                        Score = x.Score,
                                        SizeOfAttachmentInKB = x.SizeOfAttachmentInKB,
                                        ParentId = x.ParentId,
                                        MaxAttachmentNumber = x.MaxAttachmentNumber,
                                        AttachmentType = x.AttachmentType,
                                        AttachFilesOnSubCriterion = x.AttachFilesOnSubCriterion
                                    });

                                await _CriterionRepository.AddRangeAsync(NewCriterionEntities);

                                // SubCriterionItemsIds
                                foreach (SubCriterionImport SubCriterionImport in SubCriterionImportRequest)
                                {
                                    IEnumerable<int> SubCriterionItemsIds = SubCategoryRequest.MainCriterionImport
                                        .SelectMany(x => x.SubCriterionImport)
                                        .SelectMany(x => x.SubCriterionItemsIds);

                                    if (SubCriterionItemsIds.Any())
                                    {
                                        IEnumerable<CriterionItem> NewCriterionItemEntities = CriterionItemEntitites
                                            .Where(x => SubCriterionItemsIds.Contains(x.Id))
                                            .Select(x => new CriterionItem()
                                            {
                                                Id = 0,
                                                CriterionId = SubCriterionImport.Id,
                                                OrderId = x.OrderId,
                                                ArabicName = x.ArabicName,
                                                EnglishName = x.EnglishName,
                                                Score = x.Score,
                                                SizeOfAttachmentInKB = x.SizeOfAttachmentInKB,
                                                ActualScore = x.ActualScore,
                                                MaxAttachmentNumber = x.MaxAttachmentNumber,
                                                AttachmentType = x.AttachmentType
                                            });

                                        await _CriterionItemRepository.AddRangeAsync(NewCriterionItemEntities);
                                    }
                                }
                            }
                        }
                    }
                }
                else if (!MainCategoryRequest.TakeThisLevel && MainCategoryRequest.NewMainCategoryId is not null)
                {
                    MainCategoryId = MainCategoryRequest.NewMainCategoryId.Value;

                    // SubCategoryImport
                    foreach (SubCategoryImport SubCategoryRequest in MainCategoryRequest.SubCategoryImport)
                    {
                        int SubCategoryId = 0;

                        if (SubCategoryRequest.TakeThisLevel && SubCategoryRequest.NewSubCategoryId is null)
                        {
                            Category NewSubCategoryEntity = _Mapper.Map<Category>(CategoryEntities
                                .FirstOrDefault(x => x.Id == SubCategoryRequest.Id));

                            NewSubCategoryEntity.Id = 0;
                            NewSubCategoryEntity.ParentId = MainCategoryId;

                            await _CategoryRepository.AddAsync(NewSubCategoryEntity);

                            SubCategoryId = NewSubCategoryEntity.Id;
                        }
                        else if (!SubCategoryRequest.TakeThisLevel && SubCategoryRequest.NewSubCategoryId is not null)
                        {
                            SubCategoryId = SubCategoryRequest.NewSubCategoryId.Value;
                        }

                        // TermAndConditionsIds
                        if (SubCategoryRequest.TermAndConditionsIds.Any())
                            await CopyTermAndConditions(SubCategoryRequest.TermAndConditionsIds, SubCategoryId);

                        // TakeTheExplanatoryGuide
                        if (SubCategoryRequest.TakeTheExplanatoryGuide)
                            await CopyExplanatoryGuide(SubCategoryRequest.Id, SubCategoryId);

                        // TrainingWorkshopsIds
                        if (SubCategoryRequest.TrainingWorkshopsIds.Any())
                            await CopyTrainingWorkshops(SubCategoryRequest.TrainingWorkshopsIds, SubCategoryId);

                        // FrequentlyAskedQuestionsIds
                        if (SubCategoryRequest.FrequentlyAskedQuestionsIds.Any())
                            await CopyFrequentlyAskedQuestions(SubCategoryRequest.FrequentlyAskedQuestionsIds, SubCategoryId);

                        // RewardsIds
                        if (SubCategoryRequest.RewardsIds.Any())
                            await CopyRewardsIds(SubCategoryRequest.RewardsIds, SubCategoryId);

                        // MainCriterionImport + SubCriterionImport
                        if (SubCategoryRequest.MainCriterionImport.Any())
                        {
                            IEnumerable<int> MainCriterionImportIds = SubCategoryRequest.MainCriterionImport.Select(x => x.Id);

                            IEnumerable<SubCriterionImport> SubCriterionImportRequest = SubCategoryRequest.MainCriterionImport
                                .SelectMany(x => x.SubCriterionImport);

                            IEnumerable<int> SubCriterionImportIds = SubCriterionImportRequest
                                .Select(x => x.Id);

                            if (MainCriterionImportIds.Any() ||
                                SubCriterionImportIds.Any())
                            {
                                IEnumerable<Criterion> NewCriterionEntities = CriterionEntitites
                                    .Where(x => (MainCriterionImportIds.Contains(x.Id) && x.ParentId == null) ||
                                        (SubCriterionImportIds.Contains(x.Id) && x.ParentId != null))
                                    .Select(x => new Criterion()
                                    {
                                        Id = 0,
                                        CategoryId = SubCategoryId,
                                        OrderId = x.OrderId,
                                        ArabicTitle = x.ArabicTitle,
                                        EnglishTitle = x.EnglishTitle,
                                        Score = x.Score,
                                        SizeOfAttachmentInKB = x.SizeOfAttachmentInKB,
                                        ParentId = x.ParentId,
                                        MaxAttachmentNumber = x.MaxAttachmentNumber,
                                        AttachmentType = x.AttachmentType,
                                        AttachFilesOnSubCriterion = x.AttachFilesOnSubCriterion
                                    });

                                await _CriterionRepository.AddRangeAsync(NewCriterionEntities);

                                // SubCriterionItemsIds
                                foreach (SubCriterionImport SubCriterionImport in SubCriterionImportRequest)
                                {
                                    IEnumerable<int> SubCriterionItemsIds = SubCategoryRequest.MainCriterionImport
                                        .SelectMany(x => x.SubCriterionImport)
                                        .SelectMany(x => x.SubCriterionItemsIds);

                                    if (SubCriterionItemsIds.Any())
                                    {
                                        IEnumerable<CriterionItem> NewCriterionItemEntities = CriterionItemEntitites
                                            .Where(x => SubCriterionItemsIds.Contains(x.Id))
                                            .Select(x => new CriterionItem()
                                            {
                                                Id = 0,
                                                CriterionId = SubCriterionImport.Id,
                                                OrderId = x.OrderId,
                                                ArabicName = x.ArabicName,
                                                EnglishName = x.EnglishName,
                                                Score = x.Score,
                                                SizeOfAttachmentInKB = x.SizeOfAttachmentInKB,
                                                ActualScore = x.ActualScore,
                                                MaxAttachmentNumber = x.MaxAttachmentNumber,
                                                AttachmentType = x.AttachmentType
                                            });

                                        await _CriterionItemRepository.AddRangeAsync(NewCriterionItemEntities);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            throw new NotImplementedException();
        }
        public async Task CopyTermAndConditions(List<int> TermAndConditionsIds, int SubCategoryId)
        {
            List<TermAndCondition> NewTermAndConditionEntities = await _TermAndConditionRepository
                .Where(x => TermAndConditionsIds.Contains(x.Id))
                .Select(x => new TermAndCondition()
                {
                    Id = 0,
                    CategoryId = SubCategoryId,
                    ArabicTitle = x.ArabicTitle,
                    EnglishTitle = x.EnglishTitle,
                    ArabicDescription = x.ArabicDescription,
                    EnglishDescription = x.EnglishDescription,
                    NeedAttachment = x.NeedAttachment,
                    RequiredAttachmentNumber = x.RequiredAttachmentNumber,
                    AttachmentType = x.AttachmentType,
                    SizeOfAttachmentInKB = x.SizeOfAttachmentInKB,
                    IsAgree = x.IsAgree
                }).ToListAsync();

            await _TermAndConditionRepository.AddRangeAsync(NewTermAndConditionEntities);
        }
        public async Task CopyExplanatoryGuide(int SubCategoryRequestId, int SubCategoryId)
        {
            ExplanatoryGuide? OldExplanatoryGuideEntity = await _ExplanatoryGuideRepository
                .FirstOrDefaultAsync(x => x.CategoryId == SubCategoryRequestId);

            if (OldExplanatoryGuideEntity is not null)
            {
                ExplanatoryGuide? CheckNewExplanatoryGuideEntity = await _ExplanatoryGuideRepository
                    .FirstOrDefaultAsync(x => x.CategoryId == SubCategoryId);

                if (CheckNewExplanatoryGuideEntity is not null)
                {
                    if (File.Exists(CheckNewExplanatoryGuideEntity.EnglishFilePath) &&
                        File.Exists(CheckNewExplanatoryGuideEntity.ArabicFilePath))
                    {
                        File.Delete(CheckNewExplanatoryGuideEntity.EnglishFilePath);
                        File.Delete(CheckNewExplanatoryGuideEntity.ArabicFilePath);

                        await _ExplanatoryGuideRepository.DeleteAsync(CheckNewExplanatoryGuideEntity);
                    }
                }

                ExplanatoryGuide NewExplanatoryGuideEntity = _Mapper.Map<ExplanatoryGuide>(OldExplanatoryGuideEntity);

                NewExplanatoryGuideEntity.Id = 0;
                NewExplanatoryGuideEntity.CategoryId = SubCategoryId;

                await _ExplanatoryGuideRepository.AddAsync(NewExplanatoryGuideEntity);
            }
        }
        public async Task CopyTrainingWorkshops(List<int> TrainingWorkshopsIds, int SubCategoryId)
        {
            List<TrainingWorkshop> NewTrainingWorkshopEntities = await _TrainingWorkshopRepository
                .Where(x => TrainingWorkshopsIds.Contains(x.Id))
                .Select(x => new TrainingWorkshop()
                {
                    Id = 0,
                    CategoryId = SubCategoryId,
                    ArabicTitle = x.ArabicTitle,
                    EnglishTitle = x.EnglishTitle,
                    ArabicDescription = x.ArabicDescription,
                    EnglishDescription = x.EnglishDescription,
                    Thumbnail = x.Thumbnail
                }).ToListAsync();

            await _TrainingWorkshopRepository.AddRangeAsync(NewTrainingWorkshopEntities);
        }
        public async Task CopyFrequentlyAskedQuestions(List<int> FrequentlyAskedQuestionsIds, int SubCategoryId)
        {
            List<FrequentlyAskedQuestion> NewFrequentlyAskedQuestionEntities = await _FrequentlyAskedQuestionRepository
                .Where(x => FrequentlyAskedQuestionsIds.Contains(x.Id))
                .Select(x => new FrequentlyAskedQuestion()
                {
                    Id = 0,
                    CategoryId = SubCategoryId,
                    ArabicQuestion = x.ArabicQuestion,
                    EnglishQuestion = x.EnglishQuestion,
                    ArabicAnswer = x.ArabicAnswer,
                    EnglishAnswer = x.EnglishAnswer
                }).ToListAsync();

            await _FrequentlyAskedQuestionRepository.AddRangeAsync(NewFrequentlyAskedQuestionEntities);
        }
        public async Task CopyRewardsIds(List<int> RewardsIds, int SubCategoryId)
        {
            List<Reward> NewRewardEntities = await _RewardRepository
                .Where(x => RewardsIds.Contains(x.Id))
                .Select(x => new Reward()
                {
                    Id = 0,
                    CategoryId = SubCategoryId,
                    RewardValue = x.RewardValue,
                    ArabicRank = x.ArabicRank,
                    EnglishRank = x.EnglishRank
                }).ToListAsync();

            await _RewardRepository.AddRangeAsync(NewRewardEntities);
        }
    }
}
