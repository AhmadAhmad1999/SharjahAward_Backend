﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.ArbitrationAuditFeatures.Queries.GetArbitrationAuditByArbitrationId;
using SharijhaAward.Application.Features.InitialArbitrationFeatures.Queries.GetInitialArbitrationByArbitrationId;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.CriterionItemModel;
using SharijhaAward.Domain.Entities.CriterionModel;
using SharijhaAward.Domain.Entities.FinalArbitrationModel;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Application.Features.FinalArbitrationFeatures.Queries.GetFinalArbitrationById
{
    public class GetFinalArbitrationByIdHandler
        : IRequestHandler<GetFinalArbitrationByIdQuery, BaseResponse<GetFinalArbitrationByIdMainDto>>
    {
        private readonly IAsyncRepository<Criterion> _CriterionRepository;
        private readonly IAsyncRepository<CriterionAttachment> _CriterionAttachmentRepository;
        private readonly IAsyncRepository<FinalArbitrationScore> _FinalArbitrationScoreRepository;
        private readonly IAsyncRepository<FinalArbitration> _FinalArbitrationRepository;
        private readonly IAsyncRepository<CriterionItem> _CriterionItemRepository;
        private readonly IAsyncRepository<CriterionItemAttachment> _CriterionItemAttachmentRepository;
        private readonly IAsyncRepository<ChairmanNotesOnFinalArbitrationScore> _ChairmanNotesOnFinalArbitrationScoreRepository;
        private readonly IAsyncRepository<ChairmanNotesOnInitialArbitration> _ChairmanNotesOnInitialArbitrationRepository;
        private readonly IAsyncRepository<Arbitrator> _ArbitratorRepository;
        private readonly IAsyncRepository<UserRole> _UserRoleRepository;
        private readonly IJwtProvider _JwtProvider;

        public GetFinalArbitrationByIdHandler(IAsyncRepository<Criterion> CriterionRepository,
            IAsyncRepository<CriterionAttachment> CriterionAttachmentRepository,
            IAsyncRepository<FinalArbitrationScore> FinalArbitrationScoreRepository,
            IAsyncRepository<FinalArbitration> FinalArbitrationRepository,
            IAsyncRepository<CriterionItem> CriterionItemRepository,
            IAsyncRepository<CriterionItemAttachment> CriterionItemAttachmentRepository,
            IAsyncRepository<ChairmanNotesOnFinalArbitrationScore> ChairmanNotesOnFinalArbitrationScoreRepository,
            IAsyncRepository<ChairmanNotesOnInitialArbitration> ChairmanNotesOnInitialArbitrationRepository,
            IAsyncRepository<Arbitrator> ArbitratorRepository,
            IAsyncRepository<UserRole> UserRoleRepository,
            IJwtProvider JwtProvider)
        {
            _CriterionRepository = CriterionRepository;
            _CriterionAttachmentRepository = CriterionAttachmentRepository;
            _FinalArbitrationScoreRepository = FinalArbitrationScoreRepository;
            _FinalArbitrationRepository = FinalArbitrationRepository;
            _CriterionItemRepository = CriterionItemRepository;
            _CriterionItemAttachmentRepository = CriterionItemAttachmentRepository;
            _ChairmanNotesOnFinalArbitrationScoreRepository = ChairmanNotesOnFinalArbitrationScoreRepository;
            _ChairmanNotesOnInitialArbitrationRepository = ChairmanNotesOnInitialArbitrationRepository;
            _ArbitratorRepository = ArbitratorRepository;
            _UserRoleRepository = UserRoleRepository;
            _JwtProvider = JwtProvider;
        }
        public async Task<BaseResponse<GetFinalArbitrationByIdMainDto>> 
            Handle(GetFinalArbitrationByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            int UserId = int.Parse(_JwtProvider.GetUserIdFromToken(Request.Token!));

            FinalArbitration? FinalArbitrationEntity = await _FinalArbitrationRepository
                .FirstOrDefaultAsync(x => x.ProvidedFormId == Request.FormId);

            if (FinalArbitrationEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Final arbitration is not Found"
                    : "التحكيم النهائي غير موجود";

                return new BaseResponse<GetFinalArbitrationByIdMainDto>(ResponseMessage, false, 404);
            }

            Arbitrator? ArbitratorEntity = await _ArbitratorRepository
                .FirstOrDefaultAsync(x => x.Id == UserId);

            if (ArbitratorEntity is null)
            {
                UserRole? CheckIfThisUserHasFullAccess = await _UserRoleRepository
                    .FirstOrDefaultAsync(x => x.Id == UserId);

                if (CheckIfThisUserHasFullAccess is null)
                {
                    return new BaseResponse<GetFinalArbitrationByIdMainDto>(ResponseMessage, false, 200);
                }
            }

            int CategoryId = FinalArbitrationEntity.ProvidedForm!.categoryId;

            List<Criterion> AllCriterionEntities = await _CriterionRepository
                .Where(x => x.CategoryId == CategoryId)
                .Include(x => x.Parent!)
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
                .Where(x => x.InitialArbitration!.Arbitration!.ProvidedFormId == Request.FormId)
                .Select(x => new
                {
                    x.Id,
                    x.Note,
                    x.InitialArbitration!.CriterionId,
                    x.InitialArbitration!.CriterionItemId,
                    x.CreatedAt,
                    x.Chairman,
                    x.ChairmanId
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
                        SubCriterionScore = SubCriterionEntityForThisMainCriterion.Score,
                        AttachFilesOnSubCriterion = SubCriterionEntityForThisMainCriterion.AttachFilesOnSubCriterion != null
                            ? SubCriterionEntityForThisMainCriterion.AttachFilesOnSubCriterion.Value
                            : false
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
                            SubCriterionDto.FinalArbitrationScoreId = 0;

                            SubCriterionDto.ChairmanNotesOnFinalArbitrationScoreDtos = ChairmanNotesOnInitialArbitrationEnttities
                                .Where(x => x.CriterionId == SubCriterionEntityForThisMainCriterion.Id)
                                .Select(x => new ChairmanNotesOnFinalArbitrationScoreDto()
                                {
                                    Id = x.Id,
                                    Note = x.Note,
                                    isFromArbitrationAudit = true,
                                    CreatedAt = x.CreatedAt,
                                    ChairmanId = x.ChairmanId,
                                    ChairmanName = Request.lang == "en"
                                        ? x.Chairman!.EnglishName
                                        : x.Chairman!.ArabicName,
                                    ChairmanEmail = x.Chairman!.Email
                                }).ToList();

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
                            SubCriterionDto.FinalArbitrationScoreId = FinalArbitrationScoreEntitiesForThisSubCriterion.Id;

                            SubCriterionDto.ChairmanNotesOnFinalArbitrationScoreDtos = ChairmanNotesOnFinalArbitrationScoreEntities
                                .Where(x => x.FinalArbitrationScoreId == FinalArbitrationScoreEntitiesForThisSubCriterion.Id)
                                .Select(x => new ChairmanNotesOnFinalArbitrationScoreDto()
                                {
                                    Id = x.Id,
                                    Note = x.Note,
                                    isFromArbitrationAudit = false,
                                    CreatedAt = x.CreatedAt,
                                    ChairmanId = x.ChairmanId,
                                    ChairmanName = Request.lang == "en"
                                        ? x.Chairman!.EnglishName
                                        : x.Chairman!.ArabicName,
                                    ChairmanEmail = x.Chairman!.Email
                                }).Concat(ChairmanNotesOnInitialArbitrationEnttities
                                    .Where(x => x.CriterionId == SubCriterionEntityForThisMainCriterion.Id)
                                    .Select(x => new ChairmanNotesOnFinalArbitrationScoreDto()
                                    {
                                        Id = x.Id,
                                        Note = x.Note,
                                        isFromArbitrationAudit = true,
                                        CreatedAt = x.CreatedAt,
                                        ChairmanId = x.ChairmanId,
                                        ChairmanName = Request.lang == "en"
                                        ? x.Chairman!.EnglishName
                                        : x.Chairman!.ArabicName,
                                        ChairmanEmail = x.Chairman!.Email
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
                                CriterionItemDto.FinalArbitrationScoreId = 0;

                                CriterionItemDto.ChairmanNotesOnFinalArbitrationScoreDtos = ChairmanNotesOnInitialArbitrationEnttities
                                    .Where(x => x.CriterionItemId == CriterionItemEntityForThisSubCriterion.Id)
                                    .Select(x => new ChairmanNotesOnFinalArbitrationScoreDto()
                                    {
                                        Id = x.Id,
                                        Note = x.Note,
                                        isFromArbitrationAudit = true,
                                        CreatedAt = x.CreatedAt,
                                        ChairmanId = x.ChairmanId,
                                        ChairmanName = Request.lang == "en"
                                            ? x.Chairman!.EnglishName
                                            : x.Chairman!.ArabicName,
                                        ChairmanEmail = x.Chairman!.Email
                                    }).ToList();

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
                                CriterionItemDto.FinalArbitrationScoreId = FinalArbitrationScoreEntitiesForThisCriterionItem.Id;

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
                                        isFromArbitrationAudit = false,
                                        CreatedAt = x.CreatedAt,
                                        ChairmanId = x.ChairmanId,
                                        ChairmanName = Request.lang == "en"
                                            ? x.Chairman!.EnglishName
                                            : x.Chairman!.ArabicName,
                                        ChairmanEmail = x.Chairman!.Email
                                    }).Concat(ChairmanNotesOnInitialArbitrationEnttities
                                        .Where(x => x.CriterionItemId == CriterionItemEntityForThisSubCriterion.Id)
                                        .Select(x => new ChairmanNotesOnFinalArbitrationScoreDto()
                                        {
                                            Id = x.Id,
                                            Note = x.Note,
                                            isFromArbitrationAudit = true,
                                            CreatedAt = x.CreatedAt,
                                            ChairmanId = x.ChairmanId,
                                            ChairmanName = Request.lang == "en"
                                                ? x.Chairman!.EnglishName
                                                : x.Chairman!.ArabicName,
                                            ChairmanEmail = x.Chairman!.Email
                                        })).ToList();
                            }

                            SubCriterionDto.SubCriterionItemForFinalArbitrationScoreDtos!.Add(CriterionItemDto);
                        }

                        MainCriterionForFinalArbitrationScoreDto.SubCriterionForFinalArbitrationScoreDtos.Add(SubCriterionDto);
                    }
                }

                FullResponse.Add(MainCriterionForFinalArbitrationScoreDto);
            }

            GetFinalArbitrationByIdMainDto FinalResponse = new GetFinalArbitrationByIdMainDto()
            {
                MainCriterions = FullResponse,
                FinalArbitrationId = FinalArbitrationEntity.Id,
                isChairman = ArbitratorEntity ? .isChairman ?? false,
                isDoneArbitration = (FinalArbitrationEntity.Type == ArbitrationType.DoneArbitratod ? true : false),
                isAcceptedFromChairman = FinalArbitrationEntity.isAcceptedFromChairman,
                ReasonForRejecting = FinalArbitrationEntity.ReasonForRejecting,
                DoneArbitrationUserId = FinalArbitrationEntity.DoneArbitrationUserId,
                DoneArbitrationUserName = FinalArbitrationEntity.DoneArbitrationUser != null
                    ? (Request.lang == "en"
                        ? FinalArbitrationEntity.DoneArbitrationUser!.EnglishName
                        : FinalArbitrationEntity.DoneArbitrationUser!.ArabicName)
                    : null
            };

            return new BaseResponse<GetFinalArbitrationByIdMainDto>(ResponseMessage, true, 200, FinalResponse);
        }
    }
}
