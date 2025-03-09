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
using System.Net.Http;
using System.Transactions;

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

                IEnumerable<int> MainCriterionImport = Request.MainCategoryImport
                    .SelectMany(x => x.SubCategoryImport)
                    .SelectMany(x => x.MainCriterionImport);

                if (MainCriterionImport.Any())
                {
                    CriterionEntitites = await _CriterionRepository
                        .Where(x => (MainCriterionImport.Contains(x.Id) && x.ParentId == null) ||
                            (MainCriterionImport.Any(y => y == x.ParentId) && x.ParentId != null))
                        .ToListAsync();

                    CriterionItemEntitites = await _CriterionItemRepository
                        .Where(x => CriterionEntitites.Select(y => y.Id).Contains(x.CriterionId) && 
                            x.Criterion!.ParentId != null)
                        .ToListAsync();
                }
            }

            TransactionOptions TransactionOptions = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadCommitted,
                Timeout = TimeSpan.FromMinutes(5)
            };

            using (TransactionScope Transaction = new TransactionScope(TransactionScopeOption.Required,
                TransactionOptions, TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    // MainCategoryImport
                    foreach (MainCategoryImport MainCategoryRequest in Request.MainCategoryImport)
                    {
                        int MainCategoryId = 0;

                        if (MainCategoryRequest.TakeThisLevel && MainCategoryRequest.NewMainCategoryId is null)
                        {
                            Category MainCategoryInCategoryEntities = CategoryEntities
                                .FirstOrDefault(x => x.Id == MainCategoryRequest.Id)!;

                            Category NewMainCategoryEntity = new Category()
                            {
                                Id = 0,
                                CycleId = Request.NewCycleId,
                                ArabicName = MainCategoryInCategoryEntities.ArabicName,
                                EnglishName = MainCategoryInCategoryEntities.EnglishName,
                                ArabicDescription = MainCategoryInCategoryEntities.ArabicDescription,
                                EnglishDescription = MainCategoryInCategoryEntities.EnglishDescription,
                                Icon = MainCategoryInCategoryEntities.Icon,
                                CategoryClassification = MainCategoryInCategoryEntities.CategoryClassification,
                                FinalArbitrationQualificationMark = MainCategoryInCategoryEntities.FinalArbitrationQualificationMark,
                                ExpectedNumberOfWinners = MainCategoryInCategoryEntities.ExpectedNumberOfWinners,
                                MinimumAmountToObtainAStatement2 = MainCategoryInCategoryEntities.MinimumAmountToObtainAStatement2,
                                MaximumAmountToObtainAStatement2 = MainCategoryInCategoryEntities.MaximumAmountToObtainAStatement2,
                                MinimumRequirementToObtainACertificate = MainCategoryInCategoryEntities.MinimumRequirementToObtainACertificate,
                                MaximumRequirementToObtainACertificate = MainCategoryInCategoryEntities.MaximumRequirementToObtainACertificate,
                                MinimumWinningScore = MainCategoryInCategoryEntities.MinimumWinningScore,
                                RelatedToClasses = MainCategoryInCategoryEntities.RelatedToClasses,
                                RelatedToEducationalEntities = MainCategoryInCategoryEntities.RelatedToEducationalEntities,
                                ArbitrationAuditEndDate = MainCategoryInCategoryEntities.ArbitrationAuditEndDate,
                                ArbitrationAuditStartDate = MainCategoryInCategoryEntities.ArbitrationAuditStartDate,
                                ContainStatment1 = MainCategoryInCategoryEntities.ContainStatment1,
                                FinalArbitrationEndDate = MainCategoryInCategoryEntities.FinalArbitrationEndDate,
                                FinalArbitrationStartDate = MainCategoryInCategoryEntities.FinalArbitrationStartDate,
                                InitialArbitrationEndDate = MainCategoryInCategoryEntities.InitialArbitrationEndDate,
                                InitialArbitrationStartDate = MainCategoryInCategoryEntities.InitialArbitrationStartDate,
                                SortingFormsEndDate = MainCategoryInCategoryEntities.SortingFormsEndDate,
                                SortingFormsStartDate = MainCategoryInCategoryEntities.SortingFormsStartDate
                            };

                            await _CategoryRepository.AddAsync(NewMainCategoryEntity);

                            MainCategoryId = NewMainCategoryEntity.Id;

                            // SubCategoryImport
                            foreach (SubCategoryImport SubCategoryRequest in MainCategoryRequest.SubCategoryImport)
                            {
                                int SubCategoryId = 0;

                                if (SubCategoryRequest.TakeThisLevel && SubCategoryRequest.NewSubCategoryId is null)
                                {
                                    Category SubCategoryInCategoryEntities = CategoryEntities
                                        .FirstOrDefault(x => x.Id == SubCategoryRequest.Id)!;

                                    Category NewSubCategoryEntity = new Category()
                                    {
                                        Id = 0,
                                        CycleId = Request.NewCycleId,
                                        ArabicName = SubCategoryInCategoryEntities.ArabicName,
                                        EnglishName = SubCategoryInCategoryEntities.EnglishName,
                                        ArabicDescription = SubCategoryInCategoryEntities.ArabicDescription,
                                        EnglishDescription = SubCategoryInCategoryEntities.EnglishDescription,
                                        Icon = SubCategoryInCategoryEntities.Icon,
                                        CategoryClassification = SubCategoryInCategoryEntities.CategoryClassification,
                                        FinalArbitrationQualificationMark = SubCategoryInCategoryEntities.FinalArbitrationQualificationMark,
                                        ExpectedNumberOfWinners = SubCategoryInCategoryEntities.ExpectedNumberOfWinners,
                                        MinimumAmountToObtainAStatement2 = SubCategoryInCategoryEntities.MinimumAmountToObtainAStatement2,
                                        MaximumAmountToObtainAStatement2 = SubCategoryInCategoryEntities.MaximumAmountToObtainAStatement2,
                                        MinimumRequirementToObtainACertificate = SubCategoryInCategoryEntities.MinimumRequirementToObtainACertificate,
                                        MaximumRequirementToObtainACertificate = SubCategoryInCategoryEntities.MaximumRequirementToObtainACertificate,
                                        MinimumWinningScore = SubCategoryInCategoryEntities.MinimumWinningScore,
                                        RelatedToClasses = SubCategoryInCategoryEntities.RelatedToClasses,
                                        RelatedToEducationalEntities = SubCategoryInCategoryEntities.RelatedToEducationalEntities,
                                        ParentId = MainCategoryId,
                                        ArbitrationAuditEndDate = SubCategoryInCategoryEntities.ArbitrationAuditEndDate,
                                        ArbitrationAuditStartDate = SubCategoryInCategoryEntities.ArbitrationAuditStartDate,
                                        ContainStatment1 = SubCategoryInCategoryEntities.ContainStatment1,
                                        FinalArbitrationEndDate = SubCategoryInCategoryEntities.FinalArbitrationEndDate,
                                        FinalArbitrationStartDate = SubCategoryInCategoryEntities.FinalArbitrationStartDate,
                                        InitialArbitrationEndDate = SubCategoryInCategoryEntities.InitialArbitrationEndDate,
                                        InitialArbitrationStartDate = SubCategoryInCategoryEntities.InitialArbitrationStartDate,
                                        SortingFormsEndDate = SubCategoryInCategoryEntities.SortingFormsEndDate,
                                        SortingFormsStartDate = SubCategoryInCategoryEntities.SortingFormsStartDate
                                    };

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
                                    IEnumerable<Criterion> MainCriterionImports = CriterionEntitites
                                        .Where(x => SubCategoryRequest.MainCriterionImport.Contains(x.Id) &&
                                            x.ParentId == null);

                                    foreach (Criterion MainCriterionImport in MainCriterionImports)
                                    {
                                        Criterion NewMainCriterionImport = new Criterion()
                                        {
                                            Id = 0,
                                            OrderId = MainCriterionImport.OrderId,
                                            ArabicTitle = MainCriterionImport.ArabicTitle,
                                            EnglishTitle = MainCriterionImport.EnglishTitle,
                                            Score = MainCriterionImport.Score,
                                            SizeOfAttachmentInKB = MainCriterionImport.SizeOfAttachmentInKB,
                                            CategoryId = SubCategoryId,
                                            MaxAttachmentNumber = MainCriterionImport.MaxAttachmentNumber,
                                            AttachFilesOnSubCriterion = MainCriterionImport.AttachFilesOnSubCriterion
                                        };

                                        await _CriterionRepository.AddAsync(NewMainCriterionImport);

                                        IEnumerable<Criterion> SubCriterionImportRequests = CriterionEntitites
                                            .Where(x => x.ParentId == MainCriterionImport.Id);

                                        foreach (Criterion SubCriterionImport in SubCriterionImportRequests)
                                        {
                                            Criterion NewSubCriterionImport = new Criterion()
                                            {
                                                Id = 0,
                                                CategoryId = SubCategoryId,
                                                ParentId = NewMainCriterionImport.Id,
                                                OrderId = SubCriterionImport.OrderId,
                                                ArabicTitle = SubCriterionImport.ArabicTitle,
                                                EnglishTitle = SubCriterionImport.EnglishTitle,
                                                Score = SubCriterionImport.Score,
                                                SizeOfAttachmentInKB = SubCriterionImport.SizeOfAttachmentInKB,
                                                MaxAttachmentNumber = SubCriterionImport.MaxAttachmentNumber,
                                                AttachFilesOnSubCriterion = SubCriterionImport.AttachFilesOnSubCriterion
                                            };

                                            await _CriterionRepository.AddAsync(NewSubCriterionImport);

                                            IEnumerable<CriterionItem> SubCriterionItemImportRequests = CriterionItemEntitites
                                                .Where(x => x.CriterionId == SubCriterionImport.Id)
                                                .Select(x => new CriterionItem()
                                                {
                                                    Id = 0,
                                                    CriterionId = NewSubCriterionImport.Id,
                                                    OrderId = x.OrderId,
                                                    ArabicName = x.ArabicName,
                                                    EnglishName = x.EnglishName,
                                                    Score = x.Score,
                                                    ActualScore = x.ActualScore,
                                                    SizeOfAttachmentInKB = x.SizeOfAttachmentInKB,
                                                    MaxAttachmentNumber = x.MaxAttachmentNumber,
                                                });

                                            await _CriterionItemRepository.AddRangeAsync(SubCriterionItemImportRequests);
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
                                    Category SubCategoryInCategoryEntities = CategoryEntities
                                        .FirstOrDefault(x => x.Id == SubCategoryRequest.Id)!;

                                    Category NewSubCategoryEntity = new Category()
                                    {
                                        Id = 0,
                                        CycleId = Request.NewCycleId,
                                        ArabicName = SubCategoryInCategoryEntities.ArabicName,
                                        EnglishName = SubCategoryInCategoryEntities.EnglishName,
                                        ArabicDescription = SubCategoryInCategoryEntities.ArabicDescription,
                                        EnglishDescription = SubCategoryInCategoryEntities.EnglishDescription,
                                        Icon = SubCategoryInCategoryEntities.Icon,
                                        CategoryClassification = SubCategoryInCategoryEntities.CategoryClassification,
                                        FinalArbitrationQualificationMark = SubCategoryInCategoryEntities.FinalArbitrationQualificationMark,
                                        ExpectedNumberOfWinners = SubCategoryInCategoryEntities.ExpectedNumberOfWinners,
                                        MinimumAmountToObtainAStatement2 = SubCategoryInCategoryEntities.MinimumAmountToObtainAStatement2,
                                        MaximumAmountToObtainAStatement2 = SubCategoryInCategoryEntities.MaximumAmountToObtainAStatement2,
                                        MinimumRequirementToObtainACertificate = SubCategoryInCategoryEntities.MinimumRequirementToObtainACertificate,
                                        MaximumRequirementToObtainACertificate = SubCategoryInCategoryEntities.MaximumRequirementToObtainACertificate,
                                        MinimumWinningScore = SubCategoryInCategoryEntities.MinimumWinningScore,
                                        RelatedToClasses = SubCategoryInCategoryEntities.RelatedToClasses,
                                        RelatedToEducationalEntities = SubCategoryInCategoryEntities.RelatedToEducationalEntities,
                                        ParentId = MainCategoryId,
                                        ArbitrationAuditEndDate = SubCategoryInCategoryEntities.ArbitrationAuditEndDate,
                                        ArbitrationAuditStartDate = SubCategoryInCategoryEntities.ArbitrationAuditStartDate,
                                        ContainStatment1 = SubCategoryInCategoryEntities.ContainStatment1,
                                        FinalArbitrationEndDate = SubCategoryInCategoryEntities.FinalArbitrationEndDate,
                                        FinalArbitrationStartDate = SubCategoryInCategoryEntities.FinalArbitrationStartDate,
                                        InitialArbitrationEndDate = SubCategoryInCategoryEntities.InitialArbitrationEndDate,
                                        InitialArbitrationStartDate = SubCategoryInCategoryEntities.InitialArbitrationStartDate,
                                        SortingFormsEndDate = SubCategoryInCategoryEntities.SortingFormsEndDate,
                                        SortingFormsStartDate = SubCategoryInCategoryEntities.SortingFormsStartDate
                                    };

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
                                    IEnumerable<Criterion> MainCriterionImports = CriterionEntitites
                                        .Where(x => SubCategoryRequest.MainCriterionImport.Contains(x.Id) &&
                                            x.ParentId == null);

                                    foreach (Criterion MainCriterionImport in MainCriterionImports)
                                    {
                                        Criterion NewMainCriterionImport = new Criterion()
                                        {
                                            Id = 0,
                                            OrderId = MainCriterionImport.OrderId,
                                            ArabicTitle = MainCriterionImport.ArabicTitle,
                                            EnglishTitle = MainCriterionImport.EnglishTitle,
                                            Score = MainCriterionImport.Score,
                                            SizeOfAttachmentInKB = MainCriterionImport.SizeOfAttachmentInKB,
                                            CategoryId = SubCategoryId,
                                            MaxAttachmentNumber = MainCriterionImport.MaxAttachmentNumber,
                                            AttachFilesOnSubCriterion = MainCriterionImport.AttachFilesOnSubCriterion,
                                        };

                                        await _CriterionRepository.AddAsync(NewMainCriterionImport);

                                        IEnumerable<Criterion> SubCriterionImportRequests = CriterionEntitites
                                            .Where(x => x.ParentId == MainCriterionImport.Id);

                                        foreach (Criterion SubCriterionImport in SubCriterionImportRequests)
                                        {
                                            Criterion NewSubCriterionImport = new Criterion()
                                            {
                                                Id = 0,
                                                CategoryId = SubCategoryId,
                                                ParentId = NewMainCriterionImport.Id,
                                                OrderId = SubCriterionImport.OrderId,
                                                ArabicTitle = SubCriterionImport.ArabicTitle,
                                                EnglishTitle = SubCriterionImport.EnglishTitle,
                                                Score = SubCriterionImport.Score,
                                                SizeOfAttachmentInKB = SubCriterionImport.SizeOfAttachmentInKB,
                                                MaxAttachmentNumber = SubCriterionImport.MaxAttachmentNumber,
                                                AttachFilesOnSubCriterion = SubCriterionImport.AttachFilesOnSubCriterion
                                            };

                                            await _CriterionRepository.AddAsync(NewSubCriterionImport);

                                            IEnumerable<CriterionItem> SubCriterionItemImportRequests = CriterionItemEntitites
                                                .Where(x => x.CriterionId == SubCriterionImport.Id)
                                                .Select(x => new CriterionItem()
                                                {
                                                    Id = 0,
                                                    CriterionId = NewSubCriterionImport.Id,
                                                    OrderId = x.OrderId,
                                                    ArabicName = x.ArabicName,
                                                    EnglishName = x.EnglishName,
                                                    Score = x.Score,
                                                    ActualScore = x.ActualScore,
                                                    SizeOfAttachmentInKB = x.SizeOfAttachmentInKB,
                                                    MaxAttachmentNumber = x.MaxAttachmentNumber,
                                                });

                                            await _CriterionItemRepository.AddRangeAsync(SubCriterionItemImportRequests);
                                        }
                                    }
                                }
                            }
                        }
                    }

                    Transaction.Complete();
                }
                catch (Exception)
                {
                    Transaction.Dispose();
                    throw;
                }
            }

            ResponseMessage = Request.lang == "en"
                ? "Import succeeded"
                : "تم استيراد المعلومات بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
        public async Task CopyTermAndConditions(List<int> TermAndConditionsIds, int SubCategoryId)
        {
            List<TermAndCondition> NewTermAndConditionEntities = await _TermAndConditionRepository
                .Where(x => TermAndConditionsIds.Contains(x.Id))
                .Select(x => new TermAndCondition()
                {
                    Id = 0,
                    CategoryId = SubCategoryId,
                    ArabicDescription = x.ArabicDescription,
                    EnglishDescription = x.EnglishDescription,
                    NeedAttachment = x.NeedAttachment,
                    RequiredAttachmentNumber = x.RequiredAttachmentNumber,
                    //AttachmentType = x.AttachmentType,
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
                    File.Delete(CheckNewExplanatoryGuideEntity.EnglishFilePath);

                    File.Delete(CheckNewExplanatoryGuideEntity.ArabicFilePath);

                    await _ExplanatoryGuideRepository.DeleteAsync(CheckNewExplanatoryGuideEntity);
                }

                ExplanatoryGuide NewExplanatoryGuideEntity = new ExplanatoryGuide()
                {
                    EnglishTitle = OldExplanatoryGuideEntity.EnglishTitle,
                    ArabicTitle = OldExplanatoryGuideEntity.ArabicTitle,
                    EnglishFilePath = OldExplanatoryGuideEntity.EnglishFilePath,
                    ArabicFilePath = OldExplanatoryGuideEntity.ArabicFilePath,
                    CategoryId = SubCategoryId
                };

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
