using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.CriterionItemModel;
using SharijhaAward.Domain.Entities.CriterionModel;
using SharijhaAward.Application.Features.InitialArbitrationFeatures.Queries.GetInitialArbitrationByArbitrationId;

namespace SharijhaAward.Application.Features.ArbitrationAuditFeatures.Queries.GetArbitrationAuditByArbitrationId
{
    public class GetArbitrationAuditByArbitrationIdHandler 
        : IRequestHandler<GetArbitrationAuditByArbitrationIdQuery, BaseResponse<GetArbitrationAuditByArbitrationIdResponse>>
    {
        private readonly IAsyncRepository<Criterion> _CriterionRepository;
        private readonly IAsyncRepository<CriterionAttachment> _CriterionAttachmentRepository;
        private readonly IAsyncRepository<ArbitrationAudit> _ArbitrationAuditRepository;
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        private readonly IAsyncRepository<CriterionItem> _CriterionItemRepository;
        private readonly IAsyncRepository<CriterionItemAttachment> _CriterionItemAttachmentRepository;
        private readonly IAsyncRepository<ChairmanNotesOnArbitrationAudit> _ChairmanNotesOnArbitrationAuditRepository;
        private readonly IAsyncRepository<Arbitrator> _ArbitratorRepository;
        private readonly IJwtProvider _JwtProvider;

        public GetArbitrationAuditByArbitrationIdHandler(IAsyncRepository<Criterion> CriterionRepository,
            IAsyncRepository<CriterionAttachment> CriterionAttachmentRepository,
            IAsyncRepository<ArbitrationAudit> ArbitrationAuditRepository,
            IAsyncRepository<Arbitration> ArbitrationRepository,
            IAsyncRepository<CriterionItem> CriterionItemRepository,
            IAsyncRepository<CriterionItemAttachment> CriterionItemAttachmentRepository,
            IAsyncRepository<ChairmanNotesOnArbitrationAudit> ChairmanNotesOnArbitrationAuditRepository,
            IAsyncRepository<Arbitrator> ArbitratorRepository,
            IJwtProvider JwtProvider)
        {
            _CriterionRepository = CriterionRepository;
            _CriterionAttachmentRepository = CriterionAttachmentRepository;
            _ArbitrationAuditRepository = ArbitrationAuditRepository;
            _ArbitrationRepository = ArbitrationRepository;
            _CriterionItemRepository = CriterionItemRepository;
            _CriterionItemAttachmentRepository = CriterionItemAttachmentRepository;
            _ChairmanNotesOnArbitrationAuditRepository = ChairmanNotesOnArbitrationAuditRepository;
            _ArbitratorRepository = ArbitratorRepository;
            _JwtProvider = JwtProvider;
        }
        public async Task<BaseResponse<GetArbitrationAuditByArbitrationIdResponse>> 
            Handle(GetArbitrationAuditByArbitrationIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            int UserId = int.Parse(_JwtProvider.GetUserIdFromToken(Request.Token!));

            Arbitrator? ArbitraorEntity = await _ArbitratorRepository
                .FirstOrDefaultAsync(x => x.Id == UserId);

            Arbitration? ArbitrationEntity = await _ArbitrationRepository
                .FirstOrDefaultAsync(x => x.ProvidedFormId == Request.FormId);

            if (ArbitrationEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Arbitration is not Found"
                    : "التحكيم غير موجود";

                return new BaseResponse<GetArbitrationAuditByArbitrationIdResponse>(ResponseMessage, false, 404);
            }

            bool isItHisForm = false;

            if (ArbitrationEntity.ArbitratorId == UserId)
                isItHisForm = true;

            int CategoryId = ArbitrationEntity.ProvidedForm!.categoryId;

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

            List<ArbitrationAudit> ArbitrationAuditEntities = await _ArbitrationAuditRepository
                .Where(x => x.ProvidedFormId == ArbitrationEntity.ProvidedFormId)
                .ToListAsync();

            List<ChairmanNotesOnArbitrationAudit> ChairmanNotesOnArbitrationAuditEntities = await _ChairmanNotesOnArbitrationAuditRepository
                .Where(x => ArbitrationAuditEntities.Select(y => y.Id).Any(y => y == x.ArbitrationAuditId))
                .ToListAsync();

            List<ArbitrationAuditMainCriterionDto> FullResponse = new List<ArbitrationAuditMainCriterionDto>();

            foreach (Criterion MainCriterionEntity in MainCriterionEntities)
            {
                ArbitrationAuditMainCriterionDto MainCriterionDto = new ArbitrationAuditMainCriterionDto()
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
                    ArbitrationAuditSubCriterionDto SubCriterionDto = new ArbitrationAuditSubCriterionDto()
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
                        ArbitrationAudit? ArbitrationAuditEntitiesForThisSubCriterion = ArbitrationAuditEntities
                            .FirstOrDefault(x => x.CriterionId == SubCriterionEntityForThisMainCriterion.Id && x.CriterionItemId == null);

                        if (ArbitrationAuditEntitiesForThisSubCriterion is null)
                        {
                            SubCriterionDto.StrengthPoint = null;
                            SubCriterionDto.ImprovementAreas = null;
                            SubCriterionDto.ArbitrationScore = 0;

                            SubCriterionDto.SubCriterionAttachmanetsDto = CriterionAttachmentEntities
                                .Where(x => x.CriterionId == SubCriterionEntityForThisMainCriterion.Id &&
                                    x.ProvidedFormId == ArbitrationEntity.ProvidedFormId)
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
                            SubCriterionDto.StrengthPoint = ArbitrationAuditEntitiesForThisSubCriterion.StrengthPoint;
                            SubCriterionDto.ImprovementAreas = ArbitrationAuditEntitiesForThisSubCriterion.ImprovementAreas;
                            SubCriterionDto.ArbitrationScore = ArbitrationAuditEntitiesForThisSubCriterion.ArbitrationScore;
                            SubCriterionDto.ArbitrationAuditId = ArbitrationAuditEntitiesForThisSubCriterion.Id;

                            SubCriterionDto.ChairmanNotesOnArbitrationAuditDtos = ChairmanNotesOnArbitrationAuditEntities
                                .Where(x => x.ArbitrationAuditId == ArbitrationAuditEntitiesForThisSubCriterion.Id)
                                .Select(x => new ChairmanNotesOnInitialArbitrationDto()
                                {
                                    Id = x.Id,
                                    Note = x.Note,
                                    CreatedAt = x.CreatedAt
                                })
                                .OrderBy(x => x.Id)
                                .ToList();

                            SubCriterionDto.SubCriterionAttachmanetsDto = CriterionAttachmentEntities
                                .Where(x => x.CriterionId == SubCriterionEntityForThisMainCriterion.Id &&
                                    x.ProvidedFormId == ArbitrationEntity.ProvidedFormId)
                                .Select(x => new AttachmanetsDto()
                                {
                                    Id = x.Id,
                                    Name = x.Name,
                                    Description = x.Description,
                                    AttachementPath = x.AttachementPath
                                }).ToList();
                        }

                        MainCriterionDto.SubCriterionDtos.Add(SubCriterionDto);
                    }
                    else
                    {
                        SubCriterionDto.SubCriterionItemDtos = new List<ArbitrationAuditCriterionItemDto>();

                        SubCriterionDto.StrengthPoint = null;
                        SubCriterionDto.ImprovementAreas = null;
                        SubCriterionDto.ArbitrationScore = 0;

                        foreach (CriterionItem CriterionItemEntityForThisSubCriterion in CriterionItemEntitiesForThisSubCriterion)
                        {
                            ArbitrationAuditCriterionItemDto CriterionItemDto = new ArbitrationAuditCriterionItemDto()
                            {
                                CriterionItemId = CriterionItemEntityForThisSubCriterion.Id,
                                Name = Request.lang == "en"
                                    ? CriterionItemEntityForThisSubCriterion.EnglishName
                                    : CriterionItemEntityForThisSubCriterion.ArabicName,
                                CriterionItemScore = CriterionItemEntityForThisSubCriterion.Score
                            };

                            ArbitrationAudit? ArbitrationAuditEntitiesForThisCriterionItem = ArbitrationAuditEntities
                                .FirstOrDefault(x => x.CriterionItemId == CriterionItemEntityForThisSubCriterion.Id && x.CriterionId == null);

                            if (ArbitrationAuditEntitiesForThisCriterionItem is null)
                            {
                                CriterionItemDto.StrengthPoint = null;
                                CriterionItemDto.ImprovementAreas = null;
                                CriterionItemDto.ArbitrationScore = 0;
                                CriterionItemDto.ChairmanNotesOnArbitrationAuditDtos = new List<ChairmanNotesOnInitialArbitrationDto>();

                                CriterionItemDto.CriterionItemAttachmanetsDto = CriterionItemAttachmentEntities
                                    .Where(x => x.CriterionItemId == CriterionItemEntityForThisSubCriterion.Id &&
                                        x.ProvidedFormId == ArbitrationEntity.ProvidedFormId)
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
                                CriterionItemDto.StrengthPoint = ArbitrationAuditEntitiesForThisCriterionItem.StrengthPoint;
                                CriterionItemDto.ImprovementAreas = ArbitrationAuditEntitiesForThisCriterionItem.ImprovementAreas;
                                CriterionItemDto.ArbitrationScore = ArbitrationAuditEntitiesForThisCriterionItem.ArbitrationScore;
                                CriterionItemDto.ArbitrationAuditId = ArbitrationAuditEntitiesForThisCriterionItem.Id;

                                CriterionItemDto.CriterionItemAttachmanetsDto = CriterionItemAttachmentEntities
                                    .Where(x => x.CriterionItemId == CriterionItemEntityForThisSubCriterion.Id &&
                                        x.ProvidedFormId == ArbitrationEntity.ProvidedFormId)
                                    .Select(x => new AttachmanetsDto()
                                    {
                                        Id = x.Id,
                                        Name = x.Name,
                                        Description = x.Description,
                                        AttachementPath = x.AttachementPath
                                    }).ToList();

                                CriterionItemDto.ChairmanNotesOnArbitrationAuditDtos = ChairmanNotesOnArbitrationAuditEntities
                                    .Where(x => x.ArbitrationAuditId == ArbitrationAuditEntitiesForThisCriterionItem.Id)
                                    .Select(x => new ChairmanNotesOnInitialArbitrationDto()
                                    {
                                        Id = x.Id,
                                        Note = x.Note,
                                        CreatedAt = x.CreatedAt
                                    })
                                    .OrderBy(x => x.Id)
                                    .ToList();
                            }

                            SubCriterionDto.SubCriterionItemDtos!.Add(CriterionItemDto);
                        }

                        MainCriterionDto.SubCriterionDtos.Add(SubCriterionDto);
                    }
                }

                FullResponse.Add(MainCriterionDto);
            }

            GetArbitrationAuditByArbitrationIdResponse FinalResponse = new GetArbitrationAuditByArbitrationIdResponse()
            {
                isChairman = ArbitraorEntity ? .isChairman ?? false,
                MainCriterionDtos = FullResponse,
                isItHisForm = isItHisForm,
                ReasonForRejectingFromArbitrationAudit = ArbitrationEntity.ReasonForRejectingFromArbitrationAudit,
                isAcceptedFromChairmanFromArbitrationAudit = ArbitrationEntity.isAcceptedFromChairmanFromArbitrationAudit,
                isDoneArbitration = (ArbitrationEntity.ArbitrationAuditType == ArbitrationType.DoneArbitratod ? true : false),
                DoneArbitrationUserId = ArbitrationEntity.DoneArbitrationUserId,
                DoneArbitrationUserName = (ArbitrationEntity.DoneArbitrationUser != null
                    ? (Request.lang == "en"
                        ? ArbitrationEntity.DoneArbitrationUser!.EnglishName
                        : ArbitrationEntity.DoneArbitrationUser!.ArabicName)
                    : null)
            };

            return new BaseResponse<GetArbitrationAuditByArbitrationIdResponse>(ResponseMessage, true, 200, FinalResponse);
        }
    }
}
