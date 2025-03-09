using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.InitialArbitrationFeatures.Queries.GetInitialArbitrationByArbitrationId;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.ComitteeArbitratorModel;
using SharijhaAward.Domain.Entities.CriterionItemModel;
using SharijhaAward.Domain.Entities.CriterionModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
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
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IAsyncRepository<UserNoteOnFormForArbitration> _UserNoteOnFormForArbitrationRepository;
        private readonly IAsyncRepository<ComitteeArbitrator> _ComitteeArbitratorRepository;
        private readonly IAsyncRepository<ComitteeOfficer> _ComitteeOfficerRepository;
        private readonly IAsyncRepository<UserCategory> _UserCategoryRepository;
        private readonly IJwtProvider _JwtProvider;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public GetFinalArbitrationByIdHandler(IAsyncRepository<Criterion> _CriterionRepository,
            IAsyncRepository<CriterionAttachment> _CriterionAttachmentRepository,
            IAsyncRepository<FinalArbitrationScore> _FinalArbitrationScoreRepository,
            IAsyncRepository<FinalArbitration> _FinalArbitrationRepository,
            IAsyncRepository<CriterionItem> _CriterionItemRepository,
            IAsyncRepository<CriterionItemAttachment> _CriterionItemAttachmentRepository,
            IAsyncRepository<ChairmanNotesOnFinalArbitrationScore> _ChairmanNotesOnFinalArbitrationScoreRepository,
            IAsyncRepository<ChairmanNotesOnInitialArbitration> _ChairmanNotesOnInitialArbitrationRepository,
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
            this._FinalArbitrationScoreRepository = _FinalArbitrationScoreRepository;
            this._FinalArbitrationRepository = _FinalArbitrationRepository;
            this._CriterionItemRepository = _CriterionItemRepository;
            this._CriterionItemAttachmentRepository = _CriterionItemAttachmentRepository;
            this._ChairmanNotesOnFinalArbitrationScoreRepository = _ChairmanNotesOnFinalArbitrationScoreRepository;
            this._ChairmanNotesOnInitialArbitrationRepository = _ChairmanNotesOnInitialArbitrationRepository;
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
        public async Task<BaseResponse<GetFinalArbitrationByIdMainDto>> 
            Handle(GetFinalArbitrationByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

            string WWWRootFilePath = isHttps
                ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

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

                    if (!CriterionItemEntitiesForThisSubCriterion.Any() ||
                        (SubCriterionEntityForThisMainCriterion.AttachFilesOnSubCriterion is not null
                            ? SubCriterionEntityForThisMainCriterion.AttachFilesOnSubCriterion.Value
                            : false))
                    {
                        FinalArbitrationScore? FinalArbitrationScoreEntitiesForThisSubCriterion = FinalArbitrationScoreEntities
                            .FirstOrDefault(x => x.CriterionId == SubCriterionEntityForThisMainCriterion.Id && x.CriterionItemId == null);

                        if (FinalArbitrationScoreEntitiesForThisSubCriterion is null)
                        {
                            SubCriterionDto.StrengthPoint = null;
                            SubCriterionDto.ImprovementAreas = null;
                            SubCriterionDto.ArbitrationScore = 0;
                            SubCriterionDto.FinalArbitrationScoreId = 0;

                            if (Request.asNormalArbitrator &&
                                ArbitratorCommitteesIds.Any())
                            {
                                if (ComitteeOfficerEntities.Any())
                                {
                                    SubCriterionDto.ChairmanNotesOnFinalArbitrationScoreDtos = ChairmanNotesOnInitialArbitrationEnttities
                                        .Where(x => x.CriterionId == SubCriterionEntityForThisMainCriterion.Id &&
                                            ComitteeOfficerEntities.Contains(x.ChairmanId))
                                        .Select(x => new ChairmanNotesOnFinalArbitrationScoreDto()
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

                                    SubCriterionDto.ChairmanNotesOnFinalArbitrationScoreDtos = ChairmanNotesOnInitialArbitrationEnttities
                                        .Where(x => x.CriterionId == SubCriterionEntityForThisMainCriterion.Id &&
                                            ChairmanIdsForArbitratorCommittees.Contains(x.ChairmanId))
                                        .Select(x => new ChairmanNotesOnFinalArbitrationScoreDto()
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
                                SubCriterionDto.ChairmanNotesOnFinalArbitrationScoreDtos = ChairmanNotesOnInitialArbitrationEnttities
                                    .Where(x => x.CriterionId == SubCriterionEntityForThisMainCriterion.Id &&
                                        (ComitteeOfficerEntities.Contains(x.ChairmanId) ||
                                        x.ChairmanId == ArbitratorEntity!.Id))
                                    .Select(x => new ChairmanNotesOnFinalArbitrationScoreDto()
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
                                SubCriterionDto.ChairmanNotesOnFinalArbitrationScoreDtos = ChairmanNotesOnInitialArbitrationEnttities
                                    .Where(x => x.CriterionId == SubCriterionEntityForThisMainCriterion.Id)
                                    .Select(x => new ChairmanNotesOnFinalArbitrationScoreDto()
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
                                    x.ProvidedFormId == FinalArbitrationEntity.ProvidedFormId)
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
                            SubCriterionDto.StrengthPoint = FinalArbitrationScoreEntitiesForThisSubCriterion.StrengthPoint;
                            SubCriterionDto.ImprovementAreas = FinalArbitrationScoreEntitiesForThisSubCriterion.ImprovementAreas;
                            SubCriterionDto.ArbitrationScore = FinalArbitrationScoreEntitiesForThisSubCriterion.ArbitrationScore;
                            SubCriterionDto.FinalArbitrationScoreId = FinalArbitrationScoreEntitiesForThisSubCriterion.Id;

                            if (Request.asNormalArbitrator &&
                                ArbitratorCommitteesIds.Any())
                            {
                                if (ComitteeOfficerEntities.Any())
                                {
                                    SubCriterionDto.ChairmanNotesOnFinalArbitrationScoreDtos = ChairmanNotesOnInitialArbitrationEnttities
                                        .Where(x => x.CriterionId == SubCriterionEntityForThisMainCriterion.Id &&
                                            ComitteeOfficerEntities.Contains(x.ChairmanId))
                                        .Select(x => new ChairmanNotesOnFinalArbitrationScoreDto()
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
                                        .Concat(ChairmanNotesOnInitialArbitrationEnttities
                                            .Where(x => x.CriterionId == SubCriterionEntityForThisMainCriterion.Id &&
                                                ComitteeOfficerEntities.Contains(x.ChairmanId))
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
                                            })).OrderBy(x => x.Id)
                                        .ToList();
                                }
                                else
                                {
                                    List<int> ChairmanIdsForArbitratorCommittees = ArbitratorCommitteesIds
                                        .Select(x => x.Committee!.ChairmanId)
                                        .ToList();

                                    SubCriterionDto.ChairmanNotesOnFinalArbitrationScoreDtos = ChairmanNotesOnInitialArbitrationEnttities
                                        .Where(x => x.CriterionId == SubCriterionEntityForThisMainCriterion.Id &&
                                            ChairmanIdsForArbitratorCommittees.Contains(x.ChairmanId))
                                        .Select(x => new ChairmanNotesOnFinalArbitrationScoreDto()
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
                                        .Concat(ChairmanNotesOnInitialArbitrationEnttities
                                            .Where(x => x.CriterionId == SubCriterionEntityForThisMainCriterion.Id &&
                                                ChairmanIdsForArbitratorCommittees.Contains(x.ChairmanId))
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
                                            })).OrderBy(x => x.Id)
                                        .ToList();
                                }
                            }
                            else if (Request.asSubcommitteeOfficer &&
                                ComitteeOfficerEntities.Any())
                            {
                                SubCriterionDto.ChairmanNotesOnFinalArbitrationScoreDtos = ChairmanNotesOnInitialArbitrationEnttities
                                    .Where(x => x.CriterionId == SubCriterionEntityForThisMainCriterion.Id &&
                                        (ComitteeOfficerEntities.Contains(x.ChairmanId) ||
                                        x.ChairmanId == ArbitratorEntity!.Id))
                                    .Select(x => new ChairmanNotesOnFinalArbitrationScoreDto()
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
                                    .Concat(ChairmanNotesOnInitialArbitrationEnttities
                                        .Where(x => x.CriterionId == SubCriterionEntityForThisMainCriterion.Id &&
                                            (ComitteeOfficerEntities.Contains(x.ChairmanId) ||
                                            x.ChairmanId == ArbitratorEntity!.Id))
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
                                        })).OrderBy(x => x.Id)
                                    .ToList();
                            }
                            else if (Request.asChairman != null
                                ? Request.asChairman.Value
                                : false)
                            {
                                SubCriterionDto.ChairmanNotesOnFinalArbitrationScoreDtos = ChairmanNotesOnInitialArbitrationEnttities
                                    .Where(x => x.CriterionId == SubCriterionEntityForThisMainCriterion.Id)
                                    .Select(x => new ChairmanNotesOnFinalArbitrationScoreDto()
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
                                    .Concat(ChairmanNotesOnInitialArbitrationEnttities
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
                                        })).OrderBy(x => x.Id)
                                    .ToList();
                            }
                            
                            SubCriterionDto.SubCriterionAttachmanetsDto = CriterionAttachmentEntities
                                .Where(x => x.CriterionId == SubCriterionEntityForThisMainCriterion.Id &&
                                    x.ProvidedFormId == FinalArbitrationEntity.ProvidedFormId)
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

                                if (Request.asNormalArbitrator &&
                                    ArbitratorCommitteesIds.Any())
                                {
                                    if (ComitteeOfficerEntities.Any())
                                    {
                                        CriterionItemDto.ChairmanNotesOnFinalArbitrationScoreDtos = ChairmanNotesOnInitialArbitrationEnttities
                                            .Where(x => x.CriterionItemId == CriterionItemEntityForThisSubCriterion.Id &&
                                                ComitteeOfficerEntities.Contains(x.ChairmanId))
                                            .Select(x => new ChairmanNotesOnFinalArbitrationScoreDto()
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

                                        CriterionItemDto.ChairmanNotesOnFinalArbitrationScoreDtos = ChairmanNotesOnInitialArbitrationEnttities
                                            .Where(x => x.CriterionItemId == CriterionItemEntityForThisSubCriterion.Id &&
                                                ChairmanIdsForArbitratorCommittees.Contains(x.ChairmanId))
                                            .Select(x => new ChairmanNotesOnFinalArbitrationScoreDto()
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
                                    CriterionItemDto.ChairmanNotesOnFinalArbitrationScoreDtos = ChairmanNotesOnInitialArbitrationEnttities
                                        .Where(x => x.CriterionItemId == CriterionItemEntityForThisSubCriterion.Id &&
                                            ComitteeOfficerEntities.Contains(x.ChairmanId))
                                        .Select(x => new ChairmanNotesOnFinalArbitrationScoreDto()
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
                                    CriterionItemDto.ChairmanNotesOnFinalArbitrationScoreDtos = ChairmanNotesOnInitialArbitrationEnttities
                                        .Where(x => x.CriterionItemId == CriterionItemEntityForThisSubCriterion.Id)
                                        .Select(x => new ChairmanNotesOnFinalArbitrationScoreDto()
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

                                CriterionItemDto.CriterionItemAttachmanetsDto = CriterionItemAttachmentEntities
                                    .Where(x => x.CriterionItemId == CriterionItemEntityForThisSubCriterion.Id &&
                                        x.ProvidedFormId == FinalArbitrationEntity.ProvidedFormId)
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
                                        AttachementPath = x.AttachementPath.Contains("wwwroot")
                                            ? (WWWRootFilePath + x.AttachementPath.Split("wwwroot")[1]).Replace("\\", "/")
                                            : x.AttachementPath.Replace("\\", "/")
                                    }).ToList();

                                if (Request.asNormalArbitrator &&
                                    ArbitratorCommitteesIds.Any())
                                {
                                    if (ComitteeOfficerEntities.Any())
                                    {
                                        CriterionItemDto.ChairmanNotesOnFinalArbitrationScoreDtos = ChairmanNotesOnFinalArbitrationScoreEntities
                                            .Where(x => x.FinalArbitrationScoreId == FinalArbitrationScoreEntitiesForThisCriterionItem.Id &&
                                                ComitteeOfficerEntities.Contains(x.ChairmanId))
                                            .Select(x => new ChairmanNotesOnFinalArbitrationScoreDto()
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
                                            .Concat(ChairmanNotesOnInitialArbitrationEnttities
                                                .Where(x => x.CriterionItemId == CriterionItemEntityForThisSubCriterion.Id &&
                                                    ComitteeOfficerEntities.Contains(x.ChairmanId))
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
                                                })).OrderBy(x => x.Id)
                                            .ToList();
                                    }
                                    else
                                    {
                                        List<int> ChairmanIdsForArbitratorCommittees = ArbitratorCommitteesIds
                                            .Select(x => x.Committee!.ChairmanId)
                                            .ToList();

                                        CriterionItemDto.ChairmanNotesOnFinalArbitrationScoreDtos = ChairmanNotesOnFinalArbitrationScoreEntities
                                            .Where(x => x.FinalArbitrationScoreId == FinalArbitrationScoreEntitiesForThisCriterionItem.Id &&
                                                ChairmanIdsForArbitratorCommittees.Contains(x.ChairmanId))
                                            .Select(x => new ChairmanNotesOnFinalArbitrationScoreDto()
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
                                            .Concat(ChairmanNotesOnInitialArbitrationEnttities
                                                .Where(x => x.CriterionItemId == CriterionItemEntityForThisSubCriterion.Id &&
                                                    ChairmanIdsForArbitratorCommittees.Contains(x.ChairmanId))
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
                                                })).OrderBy(x => x.Id)
                                            .ToList();
                                    }
                                }
                                else if (Request.asSubcommitteeOfficer)
                                {
                                    CriterionItemDto.ChairmanNotesOnFinalArbitrationScoreDtos = ChairmanNotesOnFinalArbitrationScoreEntities
                                        .Where(x => x.FinalArbitrationScoreId == FinalArbitrationScoreEntitiesForThisCriterionItem.Id &&
                                            ComitteeOfficerEntities.Contains(x.ChairmanId))
                                        .Select(x => new ChairmanNotesOnFinalArbitrationScoreDto()
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
                                        .Concat(ChairmanNotesOnInitialArbitrationEnttities
                                            .Where(x => x.CriterionItemId == CriterionItemEntityForThisSubCriterion.Id &&
                                                ComitteeOfficerEntities.Contains(x.ChairmanId))
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
                                            })).OrderBy(x => x.Id)
                                        .ToList();
                                }
                                else if (Request.asChairman != null
                                    ? Request.asChairman.Value
                                    : false)
                                {
                                    CriterionItemDto.ChairmanNotesOnFinalArbitrationScoreDtos = ChairmanNotesOnFinalArbitrationScoreEntities
                                        .Where(x => x.FinalArbitrationScoreId == FinalArbitrationScoreEntitiesForThisCriterionItem.Id)
                                        .Select(x => new ChairmanNotesOnFinalArbitrationScoreDto()
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
                                        .Concat(ChairmanNotesOnInitialArbitrationEnttities
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
                                            })).OrderBy(x => x.Id)
                                        .ToList();
                                }
                            }

                            SubCriterionDto.SubCriterionItemForFinalArbitrationScoreDtos!.Add(CriterionItemDto);
                        }

                        MainCriterionForFinalArbitrationScoreDto.SubCriterionForFinalArbitrationScoreDtos.Add(SubCriterionDto);
                    }
                }

                FullResponse.Add(MainCriterionForFinalArbitrationScoreDto);
            }

            DynamicAttributeValue? SubscriberName = await _DynamicAttributeValueRepository
                .FirstOrDefaultAsync(x => x.RecordId == FinalArbitrationEntity.ProvidedFormId &&
                    x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                    x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower() &&
                    x.DynamicAttribute!.DynamicAttributeSection!.AttributeTableNameId == 1);

            List<ChairmanNotesOnFinalArbitrationScoreDto> ChairmanNotesOnFinalArbitrationScoreDtos = new List<ChairmanNotesOnFinalArbitrationScoreDto>();

            if (Request.asChairman != null
                ? Request.asChairman.Value
                : false)
            {
                List<int> ChairmanOfCommitteesIds = await _UserCategoryRepository
                    .Where(x => x.CategoryId == FinalArbitrationEntity.ProvidedForm!.categoryId &&
                        x.UserRole!.Role!.EnglishName.ToLower() == "Chairman of Committees".ToLower() &&
                        x.UserRole!.Role!.ArabicName == "رئيس اللجان")
                    .Select(x => x.UserRole!.UserId)
                    .ToListAsync();

                if (ChairmanOfCommitteesIds.Any())
                {
                    ChairmanNotesOnFinalArbitrationScoreDtos = await _UserNoteOnFormForArbitrationRepository
                        .Where(x => x.ArbitrationStep == ArbitrationStep.FinalArbitration &&
                            x.ProvidedFormId == FinalArbitrationEntity.ProvidedFormId &&
                            (ChairmanOfCommitteesIds.Contains(x.ChairmanId) ||
                                x.ChairmanId == ArbitratorEntity!.Id))
                        .Select(x => new ChairmanNotesOnFinalArbitrationScoreDto()
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
                    .Where(x => x.CategoryId == FinalArbitrationEntity.ProvidedForm!.categoryId &&
                        x.UserRole!.Role!.EnglishName.ToLower() == "Expert".ToLower() &&
                        x.UserRole!.Role!.ArabicName == "خبير")
                    .Select(x => x.UserRole!.UserId)
                    .ToListAsync();

                if (ChairmanOfCommitteesIds.Any())
                {
                    ChairmanNotesOnFinalArbitrationScoreDtos = await _UserNoteOnFormForArbitrationRepository
                        .Where(x => x.ArbitrationStep == ArbitrationStep.FinalArbitration &&
                            x.ProvidedFormId == FinalArbitrationEntity.ProvidedFormId &&
                            (ChairmanOfCommitteesIds.Contains(x.ChairmanId) ||
                                x.ChairmanId == ArbitratorEntity!.Id))
                        .Select(x => new ChairmanNotesOnFinalArbitrationScoreDto()
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
                ChairmanNotesOnFinalArbitrationScoreDtos = await _UserNoteOnFormForArbitrationRepository
                    .Where(x => x.ArbitrationStep == ArbitrationStep.FinalArbitration &&
                        x.ProvidedFormId == FinalArbitrationEntity.ProvidedFormId &&
                        x.ChairmanId == ArbitratorEntity!.Id)
                    .Select(x => new ChairmanNotesOnFinalArbitrationScoreDto()
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
                    : null,
                SubscriberName = SubscriberName ? .Value ?? string.Empty,
                ChairmanNotesOnFinalArbitrationScoreDtos = ChairmanNotesOnFinalArbitrationScoreDtos
            };

            return new BaseResponse<GetFinalArbitrationByIdMainDto>(ResponseMessage, true, 200, FinalResponse);
        }
    }
}
