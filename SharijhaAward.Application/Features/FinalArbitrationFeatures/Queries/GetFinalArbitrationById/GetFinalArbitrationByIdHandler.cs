using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.InitialArbitrationFeatures.Queries.GetInitialArbitrationByArbitrationId;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.CriterionItemModel;
using SharijhaAward.Domain.Entities.CriterionModel;
using SharijhaAward.Domain.Entities.FinalArbitrationModel;

namespace SharijhaAward.Application.Features.FinalArbitrationFeatures.Queries.GetFinalArbitrationById
{
    public class GetFinalArbitrationByIdHandler
        : IRequestHandler<GetFinalArbitrationByIdQuery, BaseResponse<List<MainCriterionForFinalArbitrationScoreDto>>>
    {
        private readonly IAsyncRepository<Criterion> _CriterionRepository;
        private readonly IAsyncRepository<CriterionAttachment> _CriterionAttachmentRepository;
        private readonly IAsyncRepository<FinalArbitrationScore> _FinalArbitrationScoreRepository;
        private readonly IAsyncRepository<FinalArbitration> _FinalArbitrationRepository;
        private readonly IAsyncRepository<CriterionItem> _CriterionItemRepository;
        private readonly IAsyncRepository<CriterionItemAttachment> _CriterionItemAttachmentRepository;
        private readonly IAsyncRepository<ChairmanNotesOnFinalArbitrationScore> _ChairmanNotesOnFinalArbitrationScoreRepository;
        private readonly IAsyncRepository<ChairmanNotesOnInitialArbitration> _ChairmanNotesOnInitialArbitrationRepository;

        public GetFinalArbitrationByIdHandler(IAsyncRepository<Criterion> CriterionRepository,
            IAsyncRepository<CriterionAttachment> CriterionAttachmentRepository,
            IAsyncRepository<FinalArbitrationScore> FinalArbitrationScoreRepository,
            IAsyncRepository<FinalArbitration> FinalArbitrationRepository,
            IAsyncRepository<CriterionItem> CriterionItemRepository,
            IAsyncRepository<CriterionItemAttachment> CriterionItemAttachmentRepository,
            IAsyncRepository<ChairmanNotesOnFinalArbitrationScore> ChairmanNotesOnFinalArbitrationScoreRepository,
            IAsyncRepository<ChairmanNotesOnInitialArbitration> ChairmanNotesOnInitialArbitrationRepository)
        {
            _CriterionRepository = CriterionRepository;
            _CriterionAttachmentRepository = CriterionAttachmentRepository;
            _FinalArbitrationScoreRepository = FinalArbitrationScoreRepository;
            _FinalArbitrationRepository = FinalArbitrationRepository;
            _CriterionItemRepository = CriterionItemRepository;
            _CriterionItemAttachmentRepository = CriterionItemAttachmentRepository;
            _ChairmanNotesOnFinalArbitrationScoreRepository = ChairmanNotesOnFinalArbitrationScoreRepository;
            _ChairmanNotesOnInitialArbitrationRepository = ChairmanNotesOnInitialArbitrationRepository;
        }
        public async Task<BaseResponse<List<MainCriterionForFinalArbitrationScoreDto>>> 
            Handle(GetFinalArbitrationByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            FinalArbitration? FinalArbitrationEntity = await _FinalArbitrationRepository
                .Include(x => x.ProvidedForm!)
                .FirstOrDefaultAsync(x => x.Id == Request.FormId);

            if (FinalArbitrationEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Final arbitration is not Found"
                    : "التحكيم النهائي غير موجود";

                return new BaseResponse<List<MainCriterionForFinalArbitrationScoreDto>>(ResponseMessage, false, 404);
            }

            int CategoryId = FinalArbitrationEntity.ProvidedForm!.categoryId;

            List<Criterion> AllCriterionEntities = await _CriterionRepository
                .Where(x => x.CategoryId == CategoryId)
                .ToListAsync();

            List<Criterion> MainCriterionEntities = AllCriterionEntities
                .Where(x => x.ParentId == null)
                .ToList();

            List<Criterion> SubCriterionEntities = AllCriterionEntities
                .Where(x => x.ParentId != null)
                .ToList();

            List<CriterionAttachment> CriterionAttachmentEntities = await _CriterionAttachmentRepository
                .Where(x => SubCriterionEntities.Select(y => y.Id).Contains(x.CriterionId))
                .ToListAsync();

            List<CriterionItem> CriterionItemEntities = await _CriterionItemRepository
                .Where(x => SubCriterionEntities.Select(y => y.Id).Contains(x.CriterionId))
                .ToListAsync();

            List<CriterionItemAttachment> CriterionItemAttachmentEntities = await _CriterionItemAttachmentRepository
                .Where(x => CriterionItemEntities.Select(y => y.Id).Any(y => y == x.CriterionItemId))
                .ToListAsync();

            List<FinalArbitrationScore> FinalArbitrationScoreEntities = await _FinalArbitrationScoreRepository
                .Where(x => x.FinalArbitrationId == FinalArbitrationEntity.Id)
                .ToListAsync();

            List<ChairmanNotesOnFinalArbitrationScore> ChairmanNotesOnFinalArbitrationScoreEntities = await _ChairmanNotesOnFinalArbitrationScoreRepository
                .Where(x => FinalArbitrationScoreEntities.Select(y => y.Id).Any(y => y == x.FinalArbitrationScoreId))
                .ToListAsync();

            var ChairmanNotesOnInitialArbitrationEnttities = await _ChairmanNotesOnInitialArbitrationRepository
                .Include(x => x.InitialArbitration!)
                .Include(x => x.InitialArbitration!.Arbitration!)
                .Where(x => x.InitialArbitration!.Arbitration!.ProvidedFormId == Request.FormId)
                .Select(x => new
                {
                    x.Id,
                    x.Note,
                    x.InitialArbitration!.CriterionId,
                    x.InitialArbitration!.CriterionItemId
                }).ToListAsync();

            List<MainCriterionForFinalArbitrationScoreDto> FullResponse = new List<MainCriterionForFinalArbitrationScoreDto>();

            foreach (Criterion MainCriterionEntity in MainCriterionEntities)
            {
                MainCriterionForFinalArbitrationScoreDto MainCriterionForFinalArbitrationScoreDto = new MainCriterionForFinalArbitrationScoreDto()
                {
                    Title = Request.lang == "en"
                        ? MainCriterionEntity.EnglishTitle
                        : MainCriterionEntity.ArabicTitle
                };

                List<Criterion> SubCriterionEntitiesForThisMainCriterion = SubCriterionEntities
                    .Where(x => x.ParentId == MainCriterionEntity.Id)
                    .ToList();

                foreach (Criterion SubCriterionEntityForThisMainCriterion in SubCriterionEntitiesForThisMainCriterion)
                {
                    SubCriterionForFinalArbitrationScoreDto SubCriterionDto = new SubCriterionForFinalArbitrationScoreDto()
                    {
                        SubCriterionId = SubCriterionEntityForThisMainCriterion.Id,
                        Title = Request.lang == "en"
                            ? SubCriterionEntityForThisMainCriterion.EnglishTitle
                            : SubCriterionEntityForThisMainCriterion.ArabicTitle,
                        SubCriterionScore = SubCriterionEntityForThisMainCriterion.Score
                    };

                    List<CriterionItem> CriterionItemEntitiesForThisSubCriterion = CriterionItemEntities
                        .Where(x => x.CriterionId == SubCriterionEntityForThisMainCriterion.Id)
                        .ToList();

                    if (!CriterionItemEntitiesForThisSubCriterion.Any())
                    {
                        FinalArbitrationScore? FinalArbitrationScoreEntitiesForThisSubCriterion = FinalArbitrationScoreEntities
                            .FirstOrDefault(x => x.CriterionId == SubCriterionEntityForThisMainCriterion.Id && x.CriterionItemId == null);

                        if (FinalArbitrationScoreEntitiesForThisSubCriterion is null)
                        {
                            SubCriterionDto.StrengthPoint = null;
                            SubCriterionDto.ImprovementAreas = null;
                            SubCriterionDto.ArbitrationScore = 0;

                            SubCriterionDto.SubCriterionAttachmanetsDto = CriterionAttachmentEntities
                                .Where(x => x.CriterionId == SubCriterionEntityForThisMainCriterion.Id &&
                                    x.ProvidedFormId == FinalArbitrationEntity.ProvidedFormId)
                                .Select(x => new AttachmanetsDto()
                                {
                                    Id = x.Id,
                                    Name = x.Name,
                                    Description = x.Description,
                                    AttachementPath = x.AttachementPath
                                }).ToList();
                        }
                        else
                        {
                            SubCriterionDto.StrengthPoint = FinalArbitrationScoreEntitiesForThisSubCriterion.StrengthPoint;
                            SubCriterionDto.ImprovementAreas = FinalArbitrationScoreEntitiesForThisSubCriterion.ImprovementAreas;
                            SubCriterionDto.ArbitrationScore = FinalArbitrationScoreEntitiesForThisSubCriterion.ArbitrationScore;

                            SubCriterionDto.ChairmanNotesOnFinalArbitrationScoreDto = ChairmanNotesOnFinalArbitrationScoreEntities
                                .Where(x => x.FinalArbitrationScoreId == FinalArbitrationScoreEntitiesForThisSubCriterion.Id)
                                .Select(x => new ChairmanNotesOnFinalArbitrationScoreDto()
                                {
                                    Id = x.Id,
                                    Note = x.Note,
                                    isFromArbitrationAudit = false
                                }).Concat(ChairmanNotesOnInitialArbitrationEnttities
                                    .Where(x => x.CriterionId == SubCriterionEntityForThisMainCriterion.Id)
                                    .Select(x => new ChairmanNotesOnFinalArbitrationScoreDto()
                                    {
                                        Id = x.Id,
                                        Note = x.Note,
                                        isFromArbitrationAudit = true
                                    })).ToList();

                            SubCriterionDto.SubCriterionAttachmanetsDto = CriterionAttachmentEntities
                                .Where(x => x.CriterionId == SubCriterionEntityForThisMainCriterion.Id &&
                                    x.ProvidedFormId == FinalArbitrationEntity.ProvidedFormId)
                                .Select(x => new AttachmanetsDto()
                                {
                                    Id = x.Id,
                                    Name = x.Name,
                                    Description = x.Description,
                                    AttachementPath = x.AttachementPath
                                }).ToList();
                        }

                        MainCriterionForFinalArbitrationScoreDto.SubCriterionForFinalArbitrationScoreDtos.Add(SubCriterionDto);
                    }
                    else
                    {
                        SubCriterionDto.SubCriterionItemForFinalArbitrationScoreDtos = new List<CriterionItemForFinalArbitrationScoreDto>();

                        SubCriterionDto.StrengthPoint = null;
                        SubCriterionDto.ImprovementAreas = null;
                        SubCriterionDto.ArbitrationScore = 0;

                        foreach (CriterionItem CriterionItemEntityForThisSubCriterion in CriterionItemEntitiesForThisSubCriterion)
                        {
                            CriterionItemForFinalArbitrationScoreDto CriterionItemDto = new CriterionItemForFinalArbitrationScoreDto()
                            {
                                CriterionItemId = CriterionItemEntityForThisSubCriterion.Id,
                                Name = Request.lang == "en"
                                    ? CriterionItemEntityForThisSubCriterion.EnglishName
                                    : CriterionItemEntityForThisSubCriterion.ArabicName,
                                CriterionItemScore = CriterionItemEntityForThisSubCriterion.Score
                            };

                            FinalArbitrationScore? FinalArbitrationScoreEntitiesForThisCriterionItem = FinalArbitrationScoreEntities
                                .FirstOrDefault(x => x.CriterionItemId == CriterionItemEntityForThisSubCriterion.Id && x.CriterionId == null);

                            if (FinalArbitrationScoreEntitiesForThisCriterionItem is null)
                            {
                                CriterionItemDto.StrengthPoint = null;
                                CriterionItemDto.ImprovementAreas = null;
                                CriterionItemDto.ArbitrationScore = 0;
                                CriterionItemDto.ChairmanNotesOnFinalArbitrationScoreDtos = new List<ChairmanNotesOnFinalArbitrationScoreDto>();

                                CriterionItemDto.CriterionItemAttachmanetsDto = CriterionItemAttachmentEntities
                                    .Where(x => x.CriterionItemId == CriterionItemEntityForThisSubCriterion.Id &&
                                        x.ProvidedFormId == FinalArbitrationEntity.ProvidedFormId)
                                    .Select(x => new AttachmanetsDto()
                                    {
                                        Id = x.Id,
                                        Name = x.Name,
                                        Description = x.Description,
                                        AttachementPath = x.AttachementPath
                                    }).ToList();
                            }
                            else
                            {
                                CriterionItemDto.StrengthPoint = FinalArbitrationScoreEntitiesForThisCriterionItem.StrengthPoint;
                                CriterionItemDto.ImprovementAreas = FinalArbitrationScoreEntitiesForThisCriterionItem.ImprovementAreas;
                                CriterionItemDto.ArbitrationScore = FinalArbitrationScoreEntitiesForThisCriterionItem.ArbitrationScore;

                                CriterionItemDto.CriterionItemAttachmanetsDto = CriterionItemAttachmentEntities
                                    .Where(x => x.CriterionItemId == CriterionItemEntityForThisSubCriterion.Id &&
                                        x.ProvidedFormId == FinalArbitrationEntity.ProvidedFormId)
                                    .Select(x => new AttachmanetsDto()
                                    {
                                        Id = x.Id,
                                        Name = x.Name,
                                        Description = x.Description,
                                        AttachementPath = x.AttachementPath
                                    }).ToList();

                                CriterionItemDto.ChairmanNotesOnFinalArbitrationScoreDtos = ChairmanNotesOnFinalArbitrationScoreEntities
                                    .Where(x => x.FinalArbitrationScoreId == FinalArbitrationScoreEntitiesForThisCriterionItem.Id)
                                    .Select(x => new ChairmanNotesOnFinalArbitrationScoreDto()
                                    {
                                        Id = x.Id,
                                        Note = x.Note,
                                        isFromArbitrationAudit = false
                                    }).Concat(ChairmanNotesOnInitialArbitrationEnttities
                                        .Where(x => x.CriterionItemId == CriterionItemEntityForThisSubCriterion.Id)
                                        .Select(x => new ChairmanNotesOnFinalArbitrationScoreDto()
                                        {
                                            Id = x.Id,
                                            Note = x.Note,
                                            isFromArbitrationAudit = true
                                        })).ToList();
                            }

                            SubCriterionDto.SubCriterionItemForFinalArbitrationScoreDtos!.Add(CriterionItemDto);
                        }

                        MainCriterionForFinalArbitrationScoreDto.SubCriterionForFinalArbitrationScoreDtos.Add(SubCriterionDto);
                    }
                }

                FullResponse.Add(MainCriterionForFinalArbitrationScoreDto);
            }

            return new BaseResponse<List<MainCriterionForFinalArbitrationScoreDto>>(ResponseMessage, true, 200, FullResponse);
        }
    }
}
