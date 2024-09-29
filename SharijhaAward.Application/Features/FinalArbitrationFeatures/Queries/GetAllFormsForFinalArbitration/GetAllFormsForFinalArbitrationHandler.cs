using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.ArbitrationAuditFeatures.Queries.GetAllFormsForArbitrationAudit;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.ComitteeArbitratorModel;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.FinalArbitrationModel;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Application.Features.FinalArbitrationFeatures.Queries.GetAllFormsForFinalArbitration
{
    public class GetAllFormsForFinalArbitrationHandler
        : IRequestHandler<GetAllFormsForFinalArbitrationQuery, BaseResponse<GetAllFormsForFinalArbitrationMainListVM>>
    {
        private readonly IAsyncRepository<FinalArbitration> _FinalArbitrationRepository;
        private readonly IAsyncRepository<FinalArbitrationScore> _FinalArbitrationScoreRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IAsyncRepository<Arbitrator> _ArbitratorRepository;
        private readonly IAsyncRepository<UserRole> _UserRoleRepository;
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        private readonly IAsyncRepository<ComitteeArbitrator> _ComitteeArbitratorRepository;
        private readonly IAsyncRepository<Cycle> _CycleRepository;
        private readonly IJwtProvider _JwtProvider;

        public GetAllFormsForFinalArbitrationHandler(IAsyncRepository<FinalArbitration> FinalArbitrationRepository,
            IAsyncRepository<FinalArbitrationScore> FinalArbitrationScoreRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository,
            IAsyncRepository<Arbitrator> ArbitratorRepository,
            IAsyncRepository<UserRole> UserRoleRepository,
            IAsyncRepository<Arbitration> ArbitrationRepository,
            IAsyncRepository<ComitteeArbitrator> ComitteeArbitratorRepository,
            IAsyncRepository<Cycle> CycleRepository,
            IJwtProvider JwtProvider)
        {
            _FinalArbitrationRepository = FinalArbitrationRepository;
            _FinalArbitrationScoreRepository = FinalArbitrationScoreRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
            _ArbitratorRepository = ArbitratorRepository;
            _UserRoleRepository = UserRoleRepository;
            _ArbitrationRepository = ArbitrationRepository;
            _ComitteeArbitratorRepository = ComitteeArbitratorRepository;
            _CycleRepository = CycleRepository;
            _JwtProvider = JwtProvider;
        }
        public async Task<BaseResponse<GetAllFormsForFinalArbitrationMainListVM>>
            Handle(GetAllFormsForFinalArbitrationQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            int UserId = int.Parse(_JwtProvider.GetUserIdFromToken(Request.Token!));

            List<UserRole> CheckIfThisUserHasFullAccessOrArbitratorRole = await _UserRoleRepository
                .Where(x => x.UserId == UserId)
                .ToListAsync();

            if ((CheckIfThisUserHasFullAccessOrArbitratorRole is not null
                ? CheckIfThisUserHasFullAccessOrArbitratorRole.Any(x => x.Role!.HaveFullAccess)
                : false) && Request.AsFullAccess)
            {
                List<FinalArbitration> FinalArbitrationEntities = new List<FinalArbitration>();

                int TotalCount = 0;

                Dictionary<ArbitrationType, int> TypeCounts = new Dictionary<ArbitrationType, int>();

                if (Request.ArbitrationType is not null)
                {
                    FinalArbitrationEntities = await _FinalArbitrationRepository
                        .Where(x => x.Type == Request.ArbitrationType)
                        .OrderByDescending(x => x.CreatedAt)
                        .Skip((Request.page - 1) * Request.perPage)
                        .Take(Request.perPage)
                        .ToListAsync();

                    TotalCount = await _FinalArbitrationRepository
                        .GetCountAsync(x => x.Type == Request.ArbitrationType);

                    TypeCounts = FinalArbitrationEntities
                        .Where(x => x.Type == Request.ArbitrationType)
                        .GroupBy(x => x.Type)
                        .Select(x => new { Type = x.Key, Count = x.Count() })
                        .ToDictionary(x => x.Type, x => x.Count);
                }
                else
                {
                    FinalArbitrationEntities = await _FinalArbitrationRepository
                        .OrderByDescending(x => x.CreatedAt, Request.page, Request.perPage)
                        .ToListAsync();

                    TotalCount = await _FinalArbitrationRepository
                        .GetCountAsync(null);

                    TypeCounts = FinalArbitrationEntities
                        .Where(x => true)
                        .GroupBy(x => x.Type)
                        .Select(x => new { Type = x.Key, Count = x.Count() })
                        .ToDictionary(x => x.Type, x => x.Count);
                }

                var Names = await _DynamicAttributeValueRepository
                    .Where(x => FinalArbitrationEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId))
                    .Select(x => new
                    {
                        x.RecordId,
                        x.Value
                    }).ToListAsync();

                List<FinalArbitrationScore> FinalArbitrationScoreEntities = await _FinalArbitrationScoreRepository
                    .Where(x => FinalArbitrationEntities.Select(y => y.Id).Contains(x.FinalArbitrationId))
                    .ToListAsync();

                List<GetAllFormsForFinalArbitrationListVM> GetAllFormsForFinalArbitrationListVM = FinalArbitrationEntities
                    .Select(x => new GetAllFormsForFinalArbitrationListVM()
                    {
                        FormId = x.ProvidedFormId,
                        Name = Names.FirstOrDefault(y => y.RecordId == x.ProvidedFormId)!.Value,
                        CategoryId = x.ProvidedForm!.categoryId,
                        CategoryName = Request.lang == "en"
                            ? x.ProvidedForm!.Category!.EnglishName
                            : x.ProvidedForm!.Category!.ArabicName,
                        FinalScore = FinalArbitrationScoreEntities.Sum(y => y.ArbitrationScore),
                        DateOfArbitration = x.DateOfArbitration,
                        isAcceptedFromChairman = x.isAcceptedFromChairman,
                        Type = x.Type,
                        DoneArbitrationUserId = x.DoneArbitrationUserId,
                        DoneArbitrationUserName = x.DoneArbitrationUser != null
                            ? (Request.lang == "en"
                                ? x.DoneArbitrationUser!.EnglishName
                                : x.DoneArbitrationUser!.ArabicName)
                            : null
                    }).ToList();

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.perPage, TotalCount);

                GetAllFormsForFinalArbitrationMainListVM Response = new GetAllFormsForFinalArbitrationMainListVM()
                {
                    GetAllFormsForFinalArbitrationListVM = GetAllFormsForFinalArbitrationListVM,
                    CountOfNotBeenArbitrated = TypeCounts.GetValueOrDefault(ArbitrationType.NotBeenArbitrated),
                    CountOfBeingReviewed = TypeCounts.GetValueOrDefault(ArbitrationType.BeingReviewed),
                    CountOfDoneArbitratod = TypeCounts.GetValueOrDefault(ArbitrationType.DoneArbitratod)
                };

                return new BaseResponse<GetAllFormsForFinalArbitrationMainListVM>(ResponseMessage, true, 200,
                    Response, PaginationParameter);
            }
            else if (CheckIfThisUserHasFullAccessOrArbitratorRole is not null
                ? CheckIfThisUserHasFullAccessOrArbitratorRole.Any(x => x.Role!.EnglishName.ToLower() == "arbitrator" &&
                    x.Role!.ArabicName == "محكم")
                : false)
            {
                Cycle? CheckIfThereIsActiveCycle = await _CycleRepository
                    .FirstOrDefaultAsync(x => x.Status == Domain.Constants.Common.Status.Active);

                if (CheckIfThereIsActiveCycle is null)
                    return new BaseResponse<GetAllFormsForFinalArbitrationMainListVM>(ResponseMessage, false, 200);

                int ActiveCycleId = CheckIfThereIsActiveCycle.Id;

                Arbitrator? ArbitratorEntity = await _ArbitratorRepository
                    .FirstOrDefaultAsync(x => x.Id == UserId);

                if (ArbitratorEntity is null)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "Arbitrator is not Found"
                        : "المحكم غير موجود";

                    return new BaseResponse<GetAllFormsForFinalArbitrationMainListVM>(ResponseMessage, false, 404);
                }

                if (ArbitratorEntity.isChairman &&
                    (Request.AsChairman != null ? Request.AsChairman.Value : false))
                {
                    List<int> ArbitratorIdsInCommitee = await _ComitteeArbitratorRepository
                        .Where(x => x.Committee!.ChairmanId == UserId)
                        .Select(x => x.ArbitratorId)
                        .Distinct()
                        .ToListAsync();

                    List<int> ArbitratorFormsIds = await _ArbitrationRepository
                        .Where(x => ArbitratorIdsInCommitee.Contains(x.ArbitratorId) &&
                            x.ProvidedForm!.Category!.CycleId == ActiveCycleId)
                        .Select(x => x.ProvidedFormId)
                        .Distinct()
                        .ToListAsync();

                    List<FinalArbitration> FinalArbitrationEntities = new List<FinalArbitration>();

                    int TotalCount = 0;

                    Dictionary<ArbitrationType, int> TypeCounts = new Dictionary<ArbitrationType, int>();

                    if (Request.ArbitrationType is not null)
                    {
                        FinalArbitrationEntities = await _FinalArbitrationRepository
                            .Where(x => x.Type == Request.ArbitrationType &&
                                ArbitratorFormsIds.Contains(x.ProvidedFormId) &&
                                x.ProvidedForm!.Category!.CycleId == ActiveCycleId)
                            .OrderByDescending(x => x.CreatedAt)
                            .Skip((Request.page - 1) * Request.perPage)
                            .Take(Request.perPage)
                            .ToListAsync();

                        TotalCount = await _FinalArbitrationRepository
                            .GetCountAsync(x => x.Type == Request.ArbitrationType &&
                                ArbitratorFormsIds.Contains(x.ProvidedFormId) &&
                                x.ProvidedForm!.Category!.CycleId == ActiveCycleId);

                        TypeCounts = await _FinalArbitrationRepository
                            .Where(x => x.Type == Request.ArbitrationType &&
                                ArbitratorFormsIds.Contains(x.ProvidedFormId) &&
                                x.ProvidedForm!.Category!.CycleId == ActiveCycleId)
                            .GroupBy(x => x.Type)
                            .Select(x => new { Type = x.Key, Count = x.Count() })
                            .ToDictionaryAsync(x => x.Type, x => x.Count);
                    }
                    else
                    {
                        FinalArbitrationEntities = await _FinalArbitrationRepository
                            .Where(x => ArbitratorFormsIds.Contains(x.ProvidedFormId) &&
                                x.ProvidedForm!.Category!.CycleId == ActiveCycleId)
                            .OrderByDescending(x => x.CreatedAt)
                            .Skip((Request.page - 1) * Request.perPage)
                            .Take(Request.perPage)
                            .ToListAsync();

                        TotalCount = await _FinalArbitrationRepository
                            .GetCountAsync(x => ArbitratorFormsIds.Contains(x.ProvidedFormId) &&
                                x.ProvidedForm!.Category!.CycleId == ActiveCycleId);

                        TypeCounts = await _FinalArbitrationRepository
                            .Where(x => ArbitratorFormsIds.Contains(x.ProvidedFormId) &&
                                x.ProvidedForm!.Category!.CycleId == ActiveCycleId)
                            .GroupBy(x => x.Type)
                            .Select(x => new { Type = x.Key, Count = x.Count() })
                            .ToDictionaryAsync(x => x.Type, x => x.Count);
                    }

                    var Names = await _DynamicAttributeValueRepository
                        .Where(x => FinalArbitrationEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId))
                        .Select(x => new
                        {
                            x.RecordId,
                            x.Value
                        }).ToListAsync();

                    List<FinalArbitrationScore> FinalArbitrationScoreEntities = await _FinalArbitrationScoreRepository
                        .Where(x => FinalArbitrationEntities.Select(y => y.Id).Contains(x.FinalArbitrationId))
                        .ToListAsync();

                    List<GetAllFormsForFinalArbitrationListVM> GetAllFormsForFinalArbitrationListVM = FinalArbitrationEntities
                        .Select(x => new GetAllFormsForFinalArbitrationListVM()
                        {
                            FormId = x.ProvidedFormId,
                            Name = Names.FirstOrDefault(y => y.RecordId == x.ProvidedFormId)!.Value,
                            CategoryId = x.ProvidedForm!.categoryId,
                            CategoryName = Request.lang == "en"
                                ? x.ProvidedForm!.Category!.EnglishName
                                : x.ProvidedForm!.Category!.ArabicName,
                            FinalScore = FinalArbitrationScoreEntities.Sum(y => y.ArbitrationScore),
                            DateOfArbitration = x.DateOfArbitration,
                            isAcceptedFromChairman = x.isAcceptedFromChairman,
                            Type = x.Type,
                            DoneArbitrationUserId = x.DoneArbitrationUserId,
                            DoneArbitrationUserName = x.DoneArbitrationUser != null
                            ? (Request.lang == "en"
                                ? x.DoneArbitrationUser!.EnglishName
                                : x.DoneArbitrationUser!.ArabicName)
                            : null
                        }).ToList();

                    Pagination PaginationParameter = new Pagination(Request.page,
                        Request.perPage, TotalCount);

                    GetAllFormsForFinalArbitrationMainListVM Response = new GetAllFormsForFinalArbitrationMainListVM()
                    {
                        GetAllFormsForFinalArbitrationListVM = GetAllFormsForFinalArbitrationListVM,
                        CountOfNotBeenArbitrated = TypeCounts.GetValueOrDefault(ArbitrationType.NotBeenArbitrated),
                        CountOfBeingReviewed = TypeCounts.GetValueOrDefault(ArbitrationType.BeingReviewed),
                        CountOfDoneArbitratod = TypeCounts.GetValueOrDefault(ArbitrationType.DoneArbitratod)
                    };

                    return new BaseResponse<GetAllFormsForFinalArbitrationMainListVM>(ResponseMessage, true, 200,
                        Response, PaginationParameter);
                }
                else
                {
                    List<int> ArbitratorFormsIds = await _ArbitrationRepository
                        .Where(x => x.ArbitratorId == ArbitratorEntity.Id &&
                            x.ProvidedForm!.Category!.CycleId == ActiveCycleId)
                        .Select(x => x.ProvidedFormId)
                        .ToListAsync();

                    List<FinalArbitration> FinalArbitrationEntities = new List<FinalArbitration>();

                    int TotalCount = 0;

                    if (Request.ArbitrationType is not null)
                    {
                        FinalArbitrationEntities = await _FinalArbitrationRepository
                            .Where(x => x.Type == Request.ArbitrationType &&
                                ArbitratorFormsIds.Contains(x.ProvidedFormId) &&
                                x.ProvidedForm!.Category!.CycleId == ActiveCycleId)
                            .OrderByDescending(x => x.CreatedAt)
                            .Skip((Request.page - 1) * Request.perPage)
                            .Take(Request.perPage)
                            .ToListAsync();

                        TotalCount = await _FinalArbitrationRepository
                            .GetCountAsync(x => x.Type == Request.ArbitrationType &&
                                ArbitratorFormsIds.Contains(x.ProvidedFormId) &&
                                x.ProvidedForm!.Category!.CycleId == ActiveCycleId);
                    }
                    else
                    {
                        FinalArbitrationEntities = await _FinalArbitrationRepository
                            .Where(x => ArbitratorFormsIds.Contains(x.ProvidedFormId) &&
                                x.ProvidedForm!.Category!.CycleId == ActiveCycleId)
                            .OrderByDescending(x => x.CreatedAt)
                            .Skip((Request.page - 1) * Request.perPage)
                            .Take(Request.perPage)
                            .ToListAsync();

                        TotalCount = await _FinalArbitrationRepository
                            .GetCountAsync(x => ArbitratorFormsIds.Contains(x.ProvidedFormId) &&
                                x.ProvidedForm!.Category!.CycleId == ActiveCycleId);
                    }

                    var Names = await _DynamicAttributeValueRepository
                        .Where(x => FinalArbitrationEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId))
                        .Select(x => new
                        {
                            x.RecordId,
                            x.Value
                        }).ToListAsync();

                    List<FinalArbitrationScore> FinalArbitrationScoreEntities = await _FinalArbitrationScoreRepository
                        .Where(x => FinalArbitrationEntities.Select(y => y.Id).Contains(x.FinalArbitrationId))
                        .ToListAsync();

                    List<GetAllFormsForFinalArbitrationListVM> GetAllFormsForFinalArbitrationListVM = FinalArbitrationEntities
                        .Select(x => new GetAllFormsForFinalArbitrationListVM()
                        {
                            FormId = x.ProvidedFormId,
                            Name = Names.FirstOrDefault(y => y.RecordId == x.ProvidedFormId)!.Value,
                            CategoryId = x.ProvidedForm!.categoryId,
                            CategoryName = Request.lang == "en"
                                ? x.ProvidedForm!.Category!.EnglishName
                                : x.ProvidedForm!.Category!.ArabicName,
                            FinalScore = FinalArbitrationScoreEntities.Sum(y => y.ArbitrationScore),
                            DateOfArbitration = x.DateOfArbitration,
                            isAcceptedFromChairman = x.isAcceptedFromChairman,
                            Type = x.Type,
                            DoneArbitrationUserId = x.DoneArbitrationUserId,
                            DoneArbitrationUserName = x.DoneArbitrationUser != null
                                ? (Request.lang == "en"
                                    ? x.DoneArbitrationUser!.EnglishName
                                    : x.DoneArbitrationUser!.ArabicName)
                                : null
                        }).ToList();

                    Dictionary<ArbitrationType, int> TypeCounts = await _FinalArbitrationRepository
                        .Where(x => ArbitratorFormsIds.Contains(x.ProvidedFormId) &&
                            x.ProvidedForm!.Category!.CycleId == ActiveCycleId)
                        .GroupBy(x => x.Type)
                        .Select(x => new { Type = x.Key, Count = x.Count() })
                        .ToDictionaryAsync(x => x.Type, x => x.Count);

                    Pagination PaginationParameter = new Pagination(Request.page,
                        Request.perPage, TotalCount);

                    GetAllFormsForFinalArbitrationMainListVM Response = new GetAllFormsForFinalArbitrationMainListVM()
                    {
                        GetAllFormsForFinalArbitrationListVM = GetAllFormsForFinalArbitrationListVM,
                        CountOfNotBeenArbitrated = TypeCounts.GetValueOrDefault(ArbitrationType.NotBeenArbitrated),
                        CountOfBeingReviewed = TypeCounts.GetValueOrDefault(ArbitrationType.BeingReviewed),
                        CountOfDoneArbitratod = TypeCounts.GetValueOrDefault(ArbitrationType.DoneArbitratod)
                    };

                    return new BaseResponse<GetAllFormsForFinalArbitrationMainListVM>(ResponseMessage, true, 200,
                        Response, PaginationParameter);
                }
            }
            else
            {
                return new BaseResponse<GetAllFormsForFinalArbitrationMainListVM>(ResponseMessage, true, 200);
            }
        }
    }
}
