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
using SharijhaAward.Domain.Entities.IdentityModels;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.ComitteeArbitratorModel;

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
        private readonly IAsyncRepository<UserRole> _UserRoleRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IAsyncRepository<UserNoteOnFormForArbitration> _UserNoteOnFormForArbitrationRepository;
        private readonly IAsyncRepository<ComitteeArbitrator> _ComitteeArbitratorRepository;
        private readonly IAsyncRepository<ComitteeOfficer> _ComitteeOfficerRepository;
        private readonly IAsyncRepository<UserCategory> _UserCategoryRepository;
        private readonly IJwtProvider _JwtProvider;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public GetArbitrationAuditByArbitrationIdHandler(IAsyncRepository<Criterion> _CriterionRepository,
            IAsyncRepository<CriterionAttachment> _CriterionAttachmentRepository,
            IAsyncRepository<ArbitrationAudit> _ArbitrationAuditRepository,
            IAsyncRepository<Arbitration> _ArbitrationRepository,
            IAsyncRepository<CriterionItem> _CriterionItemRepository,
            IAsyncRepository<CriterionItemAttachment> _CriterionItemAttachmentRepository,
            IAsyncRepository<ChairmanNotesOnArbitrationAudit> _ChairmanNotesOnArbitrationAuditRepository,
            IAsyncRepository<Arbitrator> _ArbitratorRepository,
            IAsyncRepository<UserRole> _UserRoleRepository,
            IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository,
            IAsyncRepository<UserNoteOnFormForArbitration> _UserNoteOnFormForArbitrationRepository,
            IAsyncRepository<ComitteeArbitrator> _ComitteeArbitratorRepository,
            IAsyncRepository<ComitteeOfficer> _ComitteeOfficerRepository,
            IAsyncRepository<UserCategory> _UserCategoryRepository,
            IJwtProvider _JwtProvider,
            IHttpContextAccessor _HttpContextAccessor)
        {
            this._CriterionRepository = _CriterionRepository;
            this._CriterionAttachmentRepository = _CriterionAttachmentRepository;
            this._ArbitrationAuditRepository = _ArbitrationAuditRepository;
            this._ArbitrationRepository = _ArbitrationRepository;
            this._CriterionItemRepository = _CriterionItemRepository;
            this._CriterionItemAttachmentRepository = _CriterionItemAttachmentRepository;
            this._ChairmanNotesOnArbitrationAuditRepository = _ChairmanNotesOnArbitrationAuditRepository;
            this._ArbitratorRepository = _ArbitratorRepository;
            this._UserRoleRepository = _UserRoleRepository;
            this._DynamicAttributeValueRepository = _DynamicAttributeValueRepository;
            this._UserNoteOnFormForArbitrationRepository = _UserNoteOnFormForArbitrationRepository;
            this._ComitteeArbitratorRepository = _ComitteeArbitratorRepository;
            this._ComitteeOfficerRepository = _ComitteeOfficerRepository;
            this._UserCategoryRepository = _UserCategoryRepository;
            this._JwtProvider = _JwtProvider;
            this._HttpContextAccessor = _HttpContextAccessor;
        }
        public async Task<BaseResponse<GetArbitrationAuditByArbitrationIdResponse>> 
            Handle(GetArbitrationAuditByArbitrationIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

            string WWWRootFilePath = isHttps
                ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

            int UserId = int.Parse(_JwtProvider.GetUserIdFromToken(Request.Token!));

            Arbitrator? ArbitratorEntity = await _ArbitratorRepository
                .FirstOrDefaultAsync(x => x.Id == UserId);

            if (ArbitratorEntity is null)
            {
                UserRole? CheckIfThisUserHasFullAccess = await _UserRoleRepository
                    .FirstOrDefaultAsync(x => x.Id == UserId);

                if (CheckIfThisUserHasFullAccess is null)
                {
                    return new BaseResponse<GetArbitrationAuditByArbitrationIdResponse>(ResponseMessage, false, 200);
                }
            }

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

            List<ArbitrationAudit> ArbitrationAuditEntities = await _ArbitrationAuditRepository
                .Where(x => x.ProvidedFormId == ArbitrationEntity.ProvidedFormId)
                .ToListAsync();

            List<ChairmanNotesOnArbitrationAudit> ChairmanNotesOnArbitrationAuditEntities = await _ChairmanNotesOnArbitrationAuditRepository
                .Where(x => ArbitrationAuditEntities.Select(y => y.Id).Any(y => y == x.ArbitrationAuditId))
                .ToListAsync();

            List<ArbitrationAuditMainCriterionDto> FullResponse = new List<ArbitrationAuditMainCriterionDto>();

            List<ComitteeArbitrator> ArbitratorCommitteesIds = new List<ComitteeArbitrator>();
            List<int> ComitteeOfficerEntities = new List<int>();

            if (Request.asNormalArbitrator)
            {
                ArbitratorCommitteesIds = await _ComitteeArbitratorRepository
                    .Where(x => x.ArbitratorId == ArbitratorEntity!.Id)
                    .ToListAsync();

                ComitteeOfficerEntities = await _ComitteeOfficerRepository
                    .Where(x => ArbitratorCommitteesIds.Select(y => y.CommitteeId).Contains(x.CommitteeId))
                    .Select(x => x.ArbitratorId)
                    .ToListAsync();
            }
            else if (Request.asSubcommitteeOfficer)
            {
                ComitteeOfficerEntities = await _ComitteeOfficerRepository
                    .Where(x => x.ArbitratorId == ArbitratorEntity!.Id)
                    .Select(x => x.Committee!.ChairmanId)
                    .ToListAsync();
            }

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
                                    AttachementPath = x.AttachementPath.Contains("wwwroot")
                                        ? (WWWRootFilePath + x.AttachementPath.Split("wwwroot")[1]).Replace("\\", "/")
                                        : x.AttachementPath.Replace("\\", "/")
                                }).ToList();
                        }
                        else
                        {
                            SubCriterionDto.StrengthPoint = ArbitrationAuditEntitiesForThisSubCriterion.StrengthPoint;
                            SubCriterionDto.ImprovementAreas = ArbitrationAuditEntitiesForThisSubCriterion.ImprovementAreas;
                            SubCriterionDto.ArbitrationScore = ArbitrationAuditEntitiesForThisSubCriterion.ArbitrationScore;
                            SubCriterionDto.ArbitrationAuditId = ArbitrationAuditEntitiesForThisSubCriterion.Id;

                            if (Request.asNormalArbitrator &&
                                ArbitratorCommitteesIds.Any())
                            {
                                if (ComitteeOfficerEntities.Any())
                                {
                                    SubCriterionDto.ChairmanNotesOnArbitrationAuditDtos = ChairmanNotesOnArbitrationAuditEntities
                                        .Where(x => x.ArbitrationAuditId == ArbitrationAuditEntitiesForThisSubCriterion.Id &&
                                            ComitteeOfficerEntities.Contains(x.ChairmanId))
                                        .Select(x => new ChairmanNotesOnInitialArbitrationDto()
                                        {
                                            Id = x.Id,
                                            Note = x.Note,
                                            CreatedAt = x.CreatedAt,
                                            ChairmanId = x.ChairmanId,
                                            ChairmanName = Request.lang == "en"
                                                ? x.Chairman!.EnglishName
                                                : x.Chairman!.ArabicName,
                                            ChairmanEmail = x.Chairman!.Email
                                        })
                                        .OrderBy(x => x.Id)
                                        .ToList();
                                }
                                else
                                {
                                    List<int> ChairmanIdsForArbitratorCommittees = ArbitratorCommitteesIds
                                        .Select(x => x.Committee!.ChairmanId)
                                        .ToList();

                                    SubCriterionDto.ChairmanNotesOnArbitrationAuditDtos = ChairmanNotesOnArbitrationAuditEntities
                                        .Where(x => x.ArbitrationAuditId == ArbitrationAuditEntitiesForThisSubCriterion.Id &&
                                            ChairmanIdsForArbitratorCommittees.Contains(x.ChairmanId))
                                        .Select(x => new ChairmanNotesOnInitialArbitrationDto()
                                        {
                                            Id = x.Id,
                                            Note = x.Note,
                                            CreatedAt = x.CreatedAt,
                                            ChairmanId = x.ChairmanId,
                                            ChairmanName = Request.lang == "en"
                                                ? x.Chairman!.EnglishName
                                                : x.Chairman!.ArabicName,
                                            ChairmanEmail = x.Chairman!.Email
                                        })
                                        .OrderBy(x => x.Id)
                                        .ToList();
                                }
                            }
                            else if (Request.asSubcommitteeOfficer &&
                                ComitteeOfficerEntities.Any())
                            {
                                SubCriterionDto.ChairmanNotesOnArbitrationAuditDtos = ChairmanNotesOnArbitrationAuditEntities
                                    .Where(x => x.ArbitrationAuditId == ArbitrationAuditEntitiesForThisSubCriterion.Id &&
                                        (ComitteeOfficerEntities.Contains(x.ChairmanId) ||
                                        x.ChairmanId == ArbitratorEntity!.Id))
                                    .Select(x => new ChairmanNotesOnInitialArbitrationDto()
                                    {
                                        Id = x.Id,
                                        Note = x.Note,
                                        CreatedAt = x.CreatedAt,
                                        ChairmanId = x.ChairmanId,
                                        ChairmanName = Request.lang == "en"
                                            ? x.Chairman!.EnglishName
                                            : x.Chairman!.ArabicName,
                                        ChairmanEmail = x.Chairman!.Email
                                    })
                                    .OrderBy(x => x.Id)
                                    .ToList();
                            }
                            else if (Request.asChairman != null
                                ? Request.asChairman.Value
                                : false)
                            {
                                SubCriterionDto.ChairmanNotesOnArbitrationAuditDtos = ChairmanNotesOnArbitrationAuditEntities
                                    .Where(x => x.ArbitrationAuditId == ArbitrationAuditEntitiesForThisSubCriterion.Id)
                                    .Select(x => new ChairmanNotesOnInitialArbitrationDto()
                                    {
                                        Id = x.Id,
                                        Note = x.Note,
                                        CreatedAt = x.CreatedAt,
                                        ChairmanId = x.ChairmanId,
                                        ChairmanName = Request.lang == "en"
                                            ? x.Chairman!.EnglishName
                                            : x.Chairman!.ArabicName,
                                        ChairmanEmail = x.Chairman!.Email
                                    })
                                    .OrderBy(x => x.Id)
                                    .ToList();
                            }

                            SubCriterionDto.SubCriterionAttachmanetsDto = CriterionAttachmentEntities
                                .Where(x => x.CriterionId == SubCriterionEntityForThisMainCriterion.Id &&
                                    x.ProvidedFormId == ArbitrationEntity.ProvidedFormId)
                                .Select(x => new AttachmanetsDto()
                                {
                                    Id = x.Id,
                                    Name = x.Name,
                                    Description = x.Description,
                                    AttachementPath = x.AttachementPath.Contains("wwwroot")
                                        ? (WWWRootFilePath + x.AttachementPath.Split("wwwroot")[1]).Replace("\\", "/")
                                        : x.AttachementPath.Replace("\\", "/")
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
                                        AttachementPath = x.AttachementPath.Contains("wwwroot")
                                            ? (WWWRootFilePath + x.AttachementPath.Split("wwwroot")[1]).Replace("\\", "/")
                                            : x.AttachementPath.Replace("\\", "/")
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
                                        AttachementPath = x.AttachementPath.Contains("wwwroot")
                                            ? (WWWRootFilePath + x.AttachementPath.Split("wwwroot")[1]).Replace("\\", "/")
                                            : x.AttachementPath.Replace("\\", "/")
                                    }).ToList();

                                if (Request.asNormalArbitrator &&
                                    ArbitratorCommitteesIds.Any())
                                {
                                    if (ComitteeOfficerEntities.Any())
                                    {
                                        CriterionItemDto.ChairmanNotesOnArbitrationAuditDtos = ChairmanNotesOnArbitrationAuditEntities
                                            .Where(x => x.ArbitrationAuditId == ArbitrationAuditEntitiesForThisCriterionItem.Id &&
                                                ComitteeOfficerEntities.Contains(x.ChairmanId))
                                            .Select(x => new ChairmanNotesOnInitialArbitrationDto()
                                            {
                                                Id = x.Id,
                                                Note = x.Note,
                                                CreatedAt = x.CreatedAt,
                                                ChairmanId = x.ChairmanId,
                                                ChairmanName = Request.lang == "en"
                                                    ? x.Chairman!.EnglishName
                                                    : x.Chairman!.ArabicName,
                                                ChairmanEmail = x.Chairman!.Email
                                            })
                                            .OrderBy(x => x.Id)
                                            .ToList();
                                    }
                                    else
                                    {
                                        List<int> ChairmanIdsForArbitratorCommittees = ArbitratorCommitteesIds
                                            .Select(x => x.Committee!.ChairmanId)
                                            .ToList();

                                        CriterionItemDto.ChairmanNotesOnArbitrationAuditDtos = ChairmanNotesOnArbitrationAuditEntities
                                            .Where(x => x.ArbitrationAuditId == ArbitrationAuditEntitiesForThisCriterionItem.Id &&
                                                ChairmanIdsForArbitratorCommittees.Contains(x.ChairmanId))
                                            .Select(x => new ChairmanNotesOnInitialArbitrationDto()
                                            {
                                                Id = x.Id,
                                                Note = x.Note,
                                                CreatedAt = x.CreatedAt,
                                                ChairmanId = x.ChairmanId,
                                                ChairmanName = Request.lang == "en"
                                                    ? x.Chairman!.EnglishName
                                                    : x.Chairman!.ArabicName,
                                                ChairmanEmail = x.Chairman!.Email
                                            })
                                            .OrderBy(x => x.Id)
                                            .ToList();
                                    }
                                }
                                else if (Request.asSubcommitteeOfficer)
                                {
                                    CriterionItemDto.ChairmanNotesOnArbitrationAuditDtos = ChairmanNotesOnArbitrationAuditEntities
                                        .Where(x => x.ArbitrationAuditId == ArbitrationAuditEntitiesForThisCriterionItem.Id &&
                                            ComitteeOfficerEntities.Contains(x.ChairmanId))
                                        .Select(x => new ChairmanNotesOnInitialArbitrationDto()
                                        {
                                            Id = x.Id,
                                            Note = x.Note,
                                            CreatedAt = x.CreatedAt,
                                            ChairmanId = x.ChairmanId,
                                            ChairmanName = Request.lang == "en"
                                                ? x.Chairman!.EnglishName
                                                : x.Chairman!.ArabicName,
                                            ChairmanEmail = x.Chairman!.Email
                                        })
                                        .OrderBy(x => x.Id)
                                        .ToList();
                                }
                                else if (Request.asChairman != null
                                    ? Request.asChairman.Value
                                    : false)
                                {
                                    CriterionItemDto.ChairmanNotesOnArbitrationAuditDtos = ChairmanNotesOnArbitrationAuditEntities
                                        .Where(x => x.ArbitrationAuditId == ArbitrationAuditEntitiesForThisCriterionItem.Id)
                                        .Select(x => new ChairmanNotesOnInitialArbitrationDto()
                                        {
                                            Id = x.Id,
                                            Note = x.Note,
                                            CreatedAt = x.CreatedAt,
                                            ChairmanId = x.ChairmanId,
                                            ChairmanName = Request.lang == "en"
                                                ? x.Chairman!.EnglishName
                                                : x.Chairman!.ArabicName,
                                            ChairmanEmail = x.Chairman!.Email
                                        })
                                        .OrderBy(x => x.Id)
                                        .ToList();
                                }
                            }

                            SubCriterionDto.SubCriterionItemDtos!.Add(CriterionItemDto);
                        }

                        MainCriterionDto.SubCriterionDtos.Add(SubCriterionDto);
                    }
                }

                FullResponse.Add(MainCriterionDto);
            }

            DynamicAttributeValue? SubscriberName = await _DynamicAttributeValueRepository
                .FirstOrDefaultAsync(x => x.RecordId == ArbitrationEntity.ProvidedFormId &&
                    x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                    x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower() &&
                    x.DynamicAttribute!.DynamicAttributeSection!.AttributeTableNameId == 1);

            List<ChairmanNotesOnInitialArbitrationDto> ChairmanNotesOnArbitrationAuditDtos = new List<ChairmanNotesOnInitialArbitrationDto>();

            if (Request.asChairman != null
                ? Request.asChairman.Value
                : false)
            {
                List<int> ChairmanOfCommitteesIds = await _UserCategoryRepository
                    .Where(x => x.CategoryId == ArbitrationEntity.ProvidedForm!.categoryId &&
                        x.UserRole!.Role!.EnglishName.ToLower() == "Chairman of Committees".ToLower() &&
                        x.UserRole!.Role!.ArabicName == "رئيس اللجان")
                    .Select(x => x.UserRole!.UserId)
                    .ToListAsync();

                if (ChairmanOfCommitteesIds.Any())
                {
                    ChairmanNotesOnArbitrationAuditDtos = await _UserNoteOnFormForArbitrationRepository
                        .Where(x => x.ArbitrationStep == ArbitrationStep.ArbitrationAudit &&
                            x.ProvidedFormId == ArbitrationEntity.ProvidedFormId &&
                            (ChairmanOfCommitteesIds.Contains(x.ChairmanId) ||
                                x.ChairmanId == ArbitratorEntity!.Id))
                        .Select(x => new ChairmanNotesOnInitialArbitrationDto()
                        {
                            Id = x.Id,
                            Note = x.Note,
                            ChairmanId = x.ChairmanId,
                            CreatedAt = x.CreatedAt,
                            ChairmanEmail = x.Chairman!.Email,
                            ChairmanName = Request.lang == "en"
                                ? x.Chairman!.EnglishName
                                : x.Chairman!.ArabicName
                        }).ToListAsync();
                }
            }
            else if (Request.asChairmanOfCommittees)
            {
                List<int> ChairmanOfCommitteesIds = await _UserCategoryRepository
                    .Where(x => x.CategoryId == ArbitrationEntity.ProvidedForm!.categoryId &&
                        x.UserRole!.Role!.EnglishName.ToLower() == "Expert".ToLower() &&
                        x.UserRole!.Role!.ArabicName == "خبير")
                    .Select(x => x.UserRole!.UserId)
                    .ToListAsync();

                if (ChairmanOfCommitteesIds.Any())
                {
                    ChairmanNotesOnArbitrationAuditDtos = await _UserNoteOnFormForArbitrationRepository
                        .Where(x => x.ArbitrationStep == ArbitrationStep.ArbitrationAudit &&
                            x.ProvidedFormId == ArbitrationEntity.ProvidedFormId &&
                            (ChairmanOfCommitteesIds.Contains(x.ChairmanId) ||
                                x.ChairmanId == ArbitratorEntity!.Id))
                        .Select(x => new ChairmanNotesOnInitialArbitrationDto()
                        {
                            Id = x.Id,
                            Note = x.Note,
                            ChairmanId = x.ChairmanId,
                            CreatedAt = x.CreatedAt,
                            ChairmanEmail = x.Chairman!.Email,
                            ChairmanName = Request.lang == "en"
                                ? x.Chairman!.EnglishName
                                : x.Chairman!.ArabicName
                        }).ToListAsync();
                }
            }
            else if (Request.asExpert)
            {
                ChairmanNotesOnArbitrationAuditDtos = await _UserNoteOnFormForArbitrationRepository
                    .Where(x => x.ArbitrationStep == ArbitrationStep.ArbitrationAudit &&
                        x.ProvidedFormId == ArbitrationEntity.ProvidedFormId &&
                        x.ChairmanId == ArbitratorEntity!.Id)
                    .Select(x => new ChairmanNotesOnInitialArbitrationDto()
                    {
                        Id = x.Id,
                        Note = x.Note,
                        ChairmanId = x.ChairmanId,
                        CreatedAt = x.CreatedAt,
                        ChairmanEmail = x.Chairman!.Email,
                        ChairmanName = Request.lang == "en"
                            ? x.Chairman!.EnglishName
                            : x.Chairman!.ArabicName
                    }).ToListAsync();
            }

            GetArbitrationAuditByArbitrationIdResponse FinalResponse = new GetArbitrationAuditByArbitrationIdResponse()
            {
                isChairman = ArbitratorEntity ? .isChairman ?? false,
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
                    : null),
                SubscriberName = SubscriberName ? .Value ?? string.Empty,
                ChairmanNotesOnArbitrationAuditDtos = ChairmanNotesOnArbitrationAuditDtos
            };

            return new BaseResponse<GetArbitrationAuditByArbitrationIdResponse>(ResponseMessage, true, 200, FinalResponse);
        }
    }
}
