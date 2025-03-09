using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
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
        private readonly IAsyncRepository<ComitteeOfficer> _ComitteeOfficerRepository;
        private readonly IAsyncRepository<UserCategory> _UserCategoryRepository;
        private readonly IUserRepository _UserRepository;
        private readonly IJwtProvider _JwtProvider;

        public GetAllFormsForFinalArbitrationHandler(IAsyncRepository<FinalArbitration> _FinalArbitrationRepository,
            IAsyncRepository<FinalArbitrationScore> _FinalArbitrationScoreRepository,
            IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository,
            IAsyncRepository<Arbitrator> _ArbitratorRepository,
            IAsyncRepository<UserRole> _UserRoleRepository,
            IAsyncRepository<Arbitration> _ArbitrationRepository,
            IAsyncRepository<ComitteeArbitrator> _ComitteeArbitratorRepository,
            IAsyncRepository<Cycle> _CycleRepository,
            IAsyncRepository<ComitteeOfficer> _ComitteeOfficerRepository,
            IAsyncRepository<UserCategory> _UserCategoryRepository,
            IUserRepository _UserRepository,
            IJwtProvider _JwtProvider)
        {
            this._FinalArbitrationRepository = _FinalArbitrationRepository;
            this._FinalArbitrationScoreRepository = _FinalArbitrationScoreRepository;
            this._DynamicAttributeValueRepository = _DynamicAttributeValueRepository;
            this._ArbitratorRepository = _ArbitratorRepository;
            this._UserRoleRepository = _UserRoleRepository;
            this._ArbitrationRepository = _ArbitrationRepository;
            this._ComitteeArbitratorRepository = _ComitteeArbitratorRepository;
            this._CycleRepository = _CycleRepository;
            this._ComitteeOfficerRepository = _ComitteeOfficerRepository;
            this._UserCategoryRepository = _UserCategoryRepository;
            this._UserRepository = _UserRepository;
            this._JwtProvider = _JwtProvider;
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
                List<DynamicAttributeValue> SubscribersNamesCopy = new List<DynamicAttributeValue>();

                if (Request.ArbitrationType is not null)
                {
                    FinalArbitrationEntities = await _FinalArbitrationRepository
                        .Where(x => x.Type == Request.ArbitrationType)
                        .ToListAsync();

                    if (!string.IsNullOrEmpty(Request.SubscriberName))
                    {
                        SubscribersNamesCopy = await _DynamicAttributeValueRepository
                            .Where(x => FinalArbitrationEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                                x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                                x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower() &&
                                x.Value.ToLower().StartsWith(Request.SubscriberName.ToLower()))
                            .ToListAsync();

                        if (SubscribersNamesCopy.Any())
                        {
                            if (Request.page != 0 &&
                                Request.perPage != -1)
                            {
                                FinalArbitrationEntities = FinalArbitrationEntities
                                    .Where(x => SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                                    .OrderByDescending(x => x.ProvidedFormId)
                                    .Skip((Request.page - 1) * Request.perPage)
                                    .Take(Request.perPage)
                                    .ToList();
                            }
                            else
                            {
                                FinalArbitrationEntities = FinalArbitrationEntities
                                    .Where(x => SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                                    .OrderByDescending(x => x.ProvidedFormId)
                                    .ToList();
                            }
                        }
                        else
                        {
                            FinalArbitrationEntities = new List<FinalArbitration>();
                        }
                    }
                    else
                    {
                        SubscribersNamesCopy = await _DynamicAttributeValueRepository
                            .Where(x => FinalArbitrationEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                                x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                                x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower())
                            .ToListAsync();
                    }

                    TotalCount = await _FinalArbitrationRepository
                        .GetCountAsync(x => x.Type == Request.ArbitrationType &&
                            SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId));

                    TypeCounts = FinalArbitrationEntities
                        .Where(x => x.Type == Request.ArbitrationType &&
                            SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                        .GroupBy(x => x.Type)
                        .Select(x => new { Type = x.Key, Count = x.Count() })
                        .ToDictionary(x => x.Type, x => x.Count);
                }
                else
                {
                    FinalArbitrationEntities = await _FinalArbitrationRepository
                        .Where(x => true)
                        .ToListAsync();

                    if (!string.IsNullOrEmpty(Request.SubscriberName))
                    {
                        SubscribersNamesCopy = await _DynamicAttributeValueRepository
                            .Where(x => FinalArbitrationEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                                x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                                x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower() &&
                                x.Value.ToLower().StartsWith(Request.SubscriberName.ToLower()))
                            .ToListAsync();

                        if (SubscribersNamesCopy.Any())
                        {
                            if (Request.page != 0 &&
                                Request.perPage != -1)
                            {
                                FinalArbitrationEntities = FinalArbitrationEntities
                                    .Where(x => SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                                    .OrderByDescending(x => x.ProvidedFormId)
                                    .Skip((Request.page - 1) * Request.perPage)
                                    .Take(Request.perPage)
                                    .ToList();
                            }
                            else
                            {
                                FinalArbitrationEntities = FinalArbitrationEntities
                                    .Where(x => SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                                    .OrderByDescending(x => x.ProvidedFormId)
                                    .ToList();
                            }
                        }
                        else
                        {
                            FinalArbitrationEntities = new List<FinalArbitration>();
                        }
                    }
                    else
                    {
                        SubscribersNamesCopy = await _DynamicAttributeValueRepository
                            .Where(x => FinalArbitrationEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                                x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                                x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower())
                            .ToListAsync();
                    }

                    TotalCount = await _FinalArbitrationRepository
                        .GetCountAsync(x => SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId));

                    TypeCounts = FinalArbitrationEntities
                        .Where(x => SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                        .GroupBy(x => x.Type)
                        .Select(x => new { Type = x.Key, Count = x.Count() })
                        .ToDictionary(x => x.Type, x => x.Count);
                }

                var SubscribersNames = SubscribersNamesCopy
                    .Select(x => new
                    {
                        x.RecordId,
                        x.Value
                    }).ToList();

                List<FinalArbitrationScore> FinalArbitrationScoreEntities = await _FinalArbitrationScoreRepository
                    .Where(x => FinalArbitrationEntities.Select(y => y.Id).Contains(x.FinalArbitrationId))
                    .ToListAsync();

                List<GetAllFormsForFinalArbitrationListVM> GetAllFormsForFinalArbitrationListVM = FinalArbitrationEntities
                    .Select(x => new GetAllFormsForFinalArbitrationListVM()
                    {
                        FormId = x.ProvidedFormId,
                        Name = SubscribersNames.FirstOrDefault(y => y.RecordId == x.ProvidedFormId)?.Value ?? "",
                        CategoryId = x.ProvidedForm!.categoryId,
                        CategoryName = Request.lang == "en"
                            ? x.ProvidedForm!.Category!.EnglishName
                            : x.ProvidedForm!.Category!.ArabicName,
                        FinalScore = FinalArbitrationScoreEntities
                            .Where(y => y.FinalArbitrationId == x.Id)
                            .Sum(y => y.ArbitrationScore),
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
                ? (CheckIfThisUserHasFullAccessOrArbitratorRole.Any(x => x.Role!.EnglishName.ToLower() == "arbitrator" &&
                    x.Role!.ArabicName == "محكم") &&
                    (Request.asNormalArbitrator || (Request.AsChairman != null ? Request.AsChairman.Value : false) ||
                     Request.asSubcommitteeOfficer))
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
                    List<DynamicAttributeValue> SubscribersNamesCopy = new List<DynamicAttributeValue>();

                    if (Request.ArbitrationType is not null)
                    {
                        FinalArbitrationEntities = await _FinalArbitrationRepository
                            .Where(x => x.Type == Request.ArbitrationType &&
                                ArbitratorFormsIds.Contains(x.ProvidedFormId) &&
                                x.ProvidedForm!.Category!.CycleId == ActiveCycleId)
                            .ToListAsync();

                        if (!string.IsNullOrEmpty(Request.SubscriberName))
                        {
                            SubscribersNamesCopy = await _DynamicAttributeValueRepository
                                .Where(x => FinalArbitrationEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                                    x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                                    x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower() &&
                                    x.Value.ToLower().StartsWith(Request.SubscriberName.ToLower()))
                                .ToListAsync();

                            if (SubscribersNamesCopy.Any())
                            {
                                if (Request.page != 0 &&
                                    Request.perPage != -1)
                                {
                                    FinalArbitrationEntities = FinalArbitrationEntities
                                        .Where(x => SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                                        .OrderByDescending(x => x.ProvidedFormId)
                                        .Skip((Request.page - 1) * Request.perPage)
                                        .Take(Request.perPage)
                                        .ToList();
                                }
                                else
                                {
                                    FinalArbitrationEntities = FinalArbitrationEntities
                                        .Where(x => SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                                        .OrderByDescending(x => x.ProvidedFormId)
                                        .ToList();
                                }
                            }
                            else
                            {
                                FinalArbitrationEntities = new List<FinalArbitration>();
                            }
                        }
                        else
                        {
                            SubscribersNamesCopy = await _DynamicAttributeValueRepository
                                .Where(x => FinalArbitrationEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                                    x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                                    x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower())
                                .ToListAsync();
                        }

                        TotalCount = await _FinalArbitrationRepository
                            .GetCountAsync(x => x.Type == Request.ArbitrationType &&
                                ArbitratorFormsIds.Contains(x.ProvidedFormId) &&
                                x.ProvidedForm!.Category!.CycleId == ActiveCycleId &&
                                SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId));

                        TypeCounts = await _FinalArbitrationRepository
                            .Where(x => x.Type == Request.ArbitrationType &&
                                ArbitratorFormsIds.Contains(x.ProvidedFormId) &&
                                x.ProvidedForm!.Category!.CycleId == ActiveCycleId &&
                                SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                            .GroupBy(x => x.Type)
                            .Select(x => new { Type = x.Key, Count = x.Count() })
                            .ToDictionaryAsync(x => x.Type, x => x.Count);
                    }
                    else
                    {
                        FinalArbitrationEntities = await _FinalArbitrationRepository
                            .Where(x => ArbitratorFormsIds.Contains(x.ProvidedFormId) &&
                                x.ProvidedForm!.Category!.CycleId == ActiveCycleId)
                            .ToListAsync();

                        if (!string.IsNullOrEmpty(Request.SubscriberName))
                        {
                            SubscribersNamesCopy = await _DynamicAttributeValueRepository
                                .Where(x => FinalArbitrationEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                                    x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                                    x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower() &&
                                    x.Value.ToLower().StartsWith(Request.SubscriberName.ToLower()))
                                .ToListAsync();

                            if (SubscribersNamesCopy.Any())
                            {
                                if (Request.page != 0 &&
                                    Request.perPage != -1)
                                {
                                    FinalArbitrationEntities = FinalArbitrationEntities
                                        .Where(x => SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                                        .OrderByDescending(x => x.ProvidedFormId)
                                        .Skip((Request.page - 1) * Request.perPage)
                                        .Take(Request.perPage)
                                        .ToList();
                                }
                                else
                                {
                                    FinalArbitrationEntities = FinalArbitrationEntities
                                        .Where(x => SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                                        .OrderByDescending(x => x.ProvidedFormId)
                                        .ToList();
                                }
                            }
                            else
                            {
                                FinalArbitrationEntities = new List<FinalArbitration>();
                            }
                        }
                        else
                        {
                            SubscribersNamesCopy = await _DynamicAttributeValueRepository
                                .Where(x => FinalArbitrationEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                                    x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                                    x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower())
                                .ToListAsync();
                        }

                        TotalCount = await _FinalArbitrationRepository
                            .GetCountAsync(x => ArbitratorFormsIds.Contains(x.ProvidedFormId) &&
                                x.ProvidedForm!.Category!.CycleId == ActiveCycleId &&
                                SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId));

                        TypeCounts = await _FinalArbitrationRepository
                            .Where(x => ArbitratorFormsIds.Contains(x.ProvidedFormId) &&
                                x.ProvidedForm!.Category!.CycleId == ActiveCycleId &&
                                SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                            .GroupBy(x => x.Type)
                            .Select(x => new { Type = x.Key, Count = x.Count() })
                            .ToDictionaryAsync(x => x.Type, x => x.Count);
                    }

                    var SubscribersNames = SubscribersNamesCopy
                        .Select(x => new
                        {
                            x.RecordId,
                            x.Value
                        }).ToList();

                    List<FinalArbitrationScore> FinalArbitrationScoreEntities = await _FinalArbitrationScoreRepository
                        .Where(x => FinalArbitrationEntities.Select(y => y.Id).Contains(x.FinalArbitrationId))
                        .ToListAsync();

                    List<GetAllFormsForFinalArbitrationListVM> GetAllFormsForFinalArbitrationListVM = FinalArbitrationEntities
                        .Select(x => new GetAllFormsForFinalArbitrationListVM()
                        {
                            FormId = x.ProvidedFormId,
                            Name = SubscribersNames.FirstOrDefault(y => y.RecordId == x.ProvidedFormId)?.Value ?? "",
                            CategoryId = x.ProvidedForm!.categoryId,
                            CategoryName = Request.lang == "en"
                                ? x.ProvidedForm!.Category!.EnglishName
                                : x.ProvidedForm!.Category!.ArabicName,
                            FinalScore = FinalArbitrationScoreEntities
                                .Where(y => y.FinalArbitrationId == x.Id)
                                .Sum(y => y.ArbitrationScore),
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
                else if (ArbitratorEntity.isSubcommitteeOfficer &&
                    Request.asSubcommitteeOfficer)
                {
                    List<int> ComitteesIds = await _ComitteeOfficerRepository
                        .Where(x => x.ArbitratorId == ArbitratorEntity.Id)
                        .Select(x => x.CommitteeId)
                        .Distinct()
                        .ToListAsync();

                    List<int> ArbitratorIdsInCommitee = await _ComitteeArbitratorRepository
                        .Where(x => ComitteesIds.Contains(x.CommitteeId))
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
                    List<DynamicAttributeValue> SubscribersNamesCopy = new List<DynamicAttributeValue>();

                    if (Request.ArbitrationType is not null)
                    {
                        FinalArbitrationEntities = await _FinalArbitrationRepository
                            .Where(x => x.Type == Request.ArbitrationType &&
                                ArbitratorFormsIds.Contains(x.ProvidedFormId) &&
                                x.ProvidedForm!.Category!.CycleId == ActiveCycleId)
                            .ToListAsync();

                        if (!string.IsNullOrEmpty(Request.SubscriberName))
                        {
                            SubscribersNamesCopy = await _DynamicAttributeValueRepository
                                .Where(x => FinalArbitrationEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                                    x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                                    x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower() &&
                                    x.Value.ToLower().StartsWith(Request.SubscriberName.ToLower()))
                                .ToListAsync();

                            if (SubscribersNamesCopy.Any())
                            {
                                if (Request.page != 0 &&
                                    Request.perPage != -1)
                                {
                                    FinalArbitrationEntities = FinalArbitrationEntities
                                        .Where(x => SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                                        .OrderByDescending(x => x.ProvidedFormId)
                                        .Skip((Request.page - 1) * Request.perPage)
                                        .Take(Request.perPage)
                                        .ToList();
                                }
                                else
                                {
                                    FinalArbitrationEntities = FinalArbitrationEntities
                                        .Where(x => SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                                        .OrderByDescending(x => x.ProvidedFormId)
                                        .ToList();
                                }
                            }
                            else
                            {
                                FinalArbitrationEntities = new List<FinalArbitration>();
                            }
                        }
                        else
                        {
                            SubscribersNamesCopy = await _DynamicAttributeValueRepository
                                .Where(x => FinalArbitrationEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                                    x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                                    x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower())
                                .ToListAsync();
                        }

                        TotalCount = await _FinalArbitrationRepository
                            .GetCountAsync(x => x.Type == Request.ArbitrationType &&
                                ArbitratorFormsIds.Contains(x.ProvidedFormId) &&
                                x.ProvidedForm!.Category!.CycleId == ActiveCycleId &&
                                SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId));

                        TypeCounts = await _FinalArbitrationRepository
                            .Where(x => x.Type == Request.ArbitrationType &&
                                ArbitratorFormsIds.Contains(x.ProvidedFormId) &&
                                x.ProvidedForm!.Category!.CycleId == ActiveCycleId &&
                                SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                            .GroupBy(x => x.Type)
                            .Select(x => new { Type = x.Key, Count = x.Count() })
                            .ToDictionaryAsync(x => x.Type, x => x.Count);
                    }
                    else
                    {
                        FinalArbitrationEntities = await _FinalArbitrationRepository
                            .Where(x => ArbitratorFormsIds.Contains(x.ProvidedFormId) &&
                                x.ProvidedForm!.Category!.CycleId == ActiveCycleId)
                            .ToListAsync();

                        if (!string.IsNullOrEmpty(Request.SubscriberName))
                        {
                            SubscribersNamesCopy = await _DynamicAttributeValueRepository
                                .Where(x => FinalArbitrationEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                                    x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                                    x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower() &&
                                    x.Value.ToLower().StartsWith(Request.SubscriberName.ToLower()))
                                .ToListAsync();

                            if (SubscribersNamesCopy.Any())
                            {
                                if (Request.page != 0 &&
                                    Request.perPage != -1)
                                {
                                    FinalArbitrationEntities = FinalArbitrationEntities
                                        .Where(x => SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                                        .OrderByDescending(x => x.ProvidedFormId)
                                        .Skip((Request.page - 1) * Request.perPage)
                                        .Take(Request.perPage)
                                        .ToList();
                                }
                                else
                                {
                                    FinalArbitrationEntities = FinalArbitrationEntities
                                        .Where(x => SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                                        .OrderByDescending(x => x.ProvidedFormId)
                                        .ToList();
                                }
                            }
                            else
                            {
                                FinalArbitrationEntities = new List<FinalArbitration>();
                            }
                        }
                        else
                        {
                            SubscribersNamesCopy = await _DynamicAttributeValueRepository
                                .Where(x => FinalArbitrationEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                                    x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                                    x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower())
                                .ToListAsync();
                        }

                        TotalCount = await _FinalArbitrationRepository
                            .GetCountAsync(x => ArbitratorFormsIds.Contains(x.ProvidedFormId) &&
                                x.ProvidedForm!.Category!.CycleId == ActiveCycleId &&
                                SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId));

                        TypeCounts = await _FinalArbitrationRepository
                            .Where(x => ArbitratorFormsIds.Contains(x.ProvidedFormId) &&
                                x.ProvidedForm!.Category!.CycleId == ActiveCycleId &&
                                SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                            .GroupBy(x => x.Type)
                            .Select(x => new { Type = x.Key, Count = x.Count() })
                            .ToDictionaryAsync(x => x.Type, x => x.Count);
                    }

                    var SubscribersNames = SubscribersNamesCopy
                        .Select(x => new
                        {
                            x.RecordId,
                            x.Value
                        }).ToList();

                    List<FinalArbitrationScore> FinalArbitrationScoreEntities = await _FinalArbitrationScoreRepository
                        .Where(x => FinalArbitrationEntities.Select(y => y.Id).Contains(x.FinalArbitrationId))
                        .ToListAsync();

                    List<GetAllFormsForFinalArbitrationListVM> GetAllFormsForFinalArbitrationListVM = FinalArbitrationEntities
                        .Select(x => new GetAllFormsForFinalArbitrationListVM()
                        {
                            FormId = x.ProvidedFormId,
                            Name = SubscribersNames.FirstOrDefault(y => y.RecordId == x.ProvidedFormId)?.Value ?? "",
                            CategoryId = x.ProvidedForm!.categoryId,
                            CategoryName = Request.lang == "en"
                                ? x.ProvidedForm!.Category!.EnglishName
                                : x.ProvidedForm!.Category!.ArabicName,
                            FinalScore = FinalArbitrationScoreEntities
                                .Where(y => y.FinalArbitrationId == x.Id)
                                .Sum(y => y.ArbitrationScore),
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
                    List<DynamicAttributeValue> SubscribersNamesCopy = new List<DynamicAttributeValue>();

                    int TotalCount = 0;

                    if (Request.ArbitrationType is not null)
                    {
                        FinalArbitrationEntities = await _FinalArbitrationRepository
                            .Where(x => x.Type == Request.ArbitrationType &&
                                ArbitratorFormsIds.Contains(x.ProvidedFormId) &&
                                x.ProvidedForm!.Category!.CycleId == ActiveCycleId)
                            .ToListAsync();

                        if (!string.IsNullOrEmpty(Request.SubscriberName))
                        {
                            SubscribersNamesCopy = await _DynamicAttributeValueRepository
                                .Where(x => FinalArbitrationEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                                    x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                                    x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower() &&
                                    x.Value.ToLower().StartsWith(Request.SubscriberName.ToLower()))
                                .ToListAsync();

                            if (SubscribersNamesCopy.Any())
                            {
                                if (Request.page != 0 &&
                                    Request.perPage != -1)
                                {
                                    FinalArbitrationEntities = FinalArbitrationEntities
                                        .Where(x => SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                                        .OrderByDescending(x => x.ProvidedFormId)
                                        .Skip((Request.page - 1) * Request.perPage)
                                        .Take(Request.perPage)
                                        .ToList();
                                }
                                else
                                {
                                    FinalArbitrationEntities = FinalArbitrationEntities
                                        .Where(x => SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                                        .OrderByDescending(x => x.ProvidedFormId)
                                        .ToList();
                                }
                            }
                            else
                            {
                                FinalArbitrationEntities = new List<FinalArbitration>();
                            }
                        }
                        else
                        {
                            SubscribersNamesCopy = await _DynamicAttributeValueRepository
                                .Where(x => FinalArbitrationEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                                    x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                                    x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower())
                                .ToListAsync();
                        }

                        TotalCount = await _FinalArbitrationRepository
                            .GetCountAsync(x => x.Type == Request.ArbitrationType &&
                                ArbitratorFormsIds.Contains(x.ProvidedFormId) &&
                                x.ProvidedForm!.Category!.CycleId == ActiveCycleId &&
                                SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId));
                    }
                    else
                    {
                        FinalArbitrationEntities = await _FinalArbitrationRepository
                            .Where(x => ArbitratorFormsIds.Contains(x.ProvidedFormId) &&
                                x.ProvidedForm!.Category!.CycleId == ActiveCycleId)
                            .ToListAsync();

                        if (!string.IsNullOrEmpty(Request.SubscriberName))
                        {
                            SubscribersNamesCopy = await _DynamicAttributeValueRepository
                                .Where(x => FinalArbitrationEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                                    x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                                    x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower() &&
                                    x.Value.ToLower().StartsWith(Request.SubscriberName.ToLower()))
                                .ToListAsync();

                            if (SubscribersNamesCopy.Any())
                            {
                                if (Request.page != 0 &&
                                    Request.perPage != -1)
                                {
                                    FinalArbitrationEntities = FinalArbitrationEntities
                                        .Where(x => SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                                        .OrderByDescending(x => x.ProvidedFormId)
                                        .Skip((Request.page - 1) * Request.perPage)
                                        .Take(Request.perPage)
                                        .ToList();
                                }
                                else
                                {
                                    FinalArbitrationEntities = FinalArbitrationEntities
                                        .Where(x => SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                                        .OrderByDescending(x => x.ProvidedFormId)
                                        .ToList();
                                }
                            }
                            else
                            {
                                FinalArbitrationEntities = new List<FinalArbitration>();
                            }
                        }
                        else
                        {
                            SubscribersNamesCopy = await _DynamicAttributeValueRepository
                                .Where(x => FinalArbitrationEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                                    x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                                    x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower())
                                .ToListAsync();
                        }

                        TotalCount = await _FinalArbitrationRepository
                            .GetCountAsync(x => ArbitratorFormsIds.Contains(x.ProvidedFormId) &&
                                x.ProvidedForm!.Category!.CycleId == ActiveCycleId &&
                                SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId));
                    }

                    var SubscribersNames = SubscribersNamesCopy
                        .Select(x => new
                        {
                            x.RecordId,
                            x.Value
                        }).ToList();

                    List<FinalArbitrationScore> FinalArbitrationScoreEntities = await _FinalArbitrationScoreRepository
                        .Where(x => FinalArbitrationEntities.Select(y => y.Id).Contains(x.FinalArbitrationId))
                        .ToListAsync();

                    List<GetAllFormsForFinalArbitrationListVM> GetAllFormsForFinalArbitrationListVM = FinalArbitrationEntities
                        .Select(x => new GetAllFormsForFinalArbitrationListVM()
                        {
                            FormId = x.ProvidedFormId,
                            Name = SubscribersNames.FirstOrDefault(y => y.RecordId == x.ProvidedFormId)?.Value ?? "",
                            CategoryId = x.ProvidedForm!.categoryId,
                            CategoryName = Request.lang == "en"
                                ? x.ProvidedForm!.Category!.EnglishName
                                : x.ProvidedForm!.Category!.ArabicName,
                            FinalScore = FinalArbitrationScoreEntities
                                .Where(y => y.FinalArbitrationId == x.Id)
                                .Sum(y => y.ArbitrationScore),
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
                            SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId))
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
                Cycle? CheckIfThereIsActiveCycle = await _CycleRepository
                    .FirstOrDefaultAsync(x => x.Status == Domain.Constants.Common.Status.Active);

                if (CheckIfThereIsActiveCycle is null)
                    return new BaseResponse<GetAllFormsForFinalArbitrationMainListVM>(ResponseMessage, false, 200);

                int ActiveCycleId = CheckIfThereIsActiveCycle.Id;

                Domain.Entities.IdentityModels.User? UserEntity = await _UserRepository
                    .FirstOrDefaultAsync(x => x.Id == UserId);

                if (UserEntity is null)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "User is not found"
                        : "المستخدم غير موجود";

                    return new BaseResponse<GetAllFormsForFinalArbitrationMainListVM>(ResponseMessage, false, 404);
                }

                List<int> CategoriesIds = new List<int>();

                if (Request.asChairmanOfCommittees &&
                    (CheckIfThisUserHasFullAccessOrArbitratorRole != null
                        ? CheckIfThisUserHasFullAccessOrArbitratorRole!.Any(x => x.Role!.EnglishName.ToLower() == "Chairman of Committees".ToLower() &&
                            x.Role!.ArabicName == "رئيس المحكمين")
                        : false))
                {
                    CategoriesIds = await _UserCategoryRepository
                        .Where(x => x.UserRole!.Role!.EnglishName.ToLower() == "Chairman of Committees".ToLower() &&
                            x.UserRole!.Role!.ArabicName == "رئيس اللجان" &&
                            x.Category!.CycleId == ActiveCycleId &&
                            x.UserRole!.UserId == UserEntity.Id)
                        .Select(x => x.CategoryId)
                        .ToListAsync();
                }
                else if (Request.asExpert &&
                    (CheckIfThisUserHasFullAccessOrArbitratorRole != null
                        ? CheckIfThisUserHasFullAccessOrArbitratorRole!.Any(x => x.Role!.EnglishName.ToLower() == "Expert".ToLower() &&
                            x.Role!.ArabicName == "خبير")
                        : false))
                {
                    CategoriesIds = await _UserCategoryRepository
                        .Where(x => x.UserRole!.Role!.EnglishName.ToLower() == "Expert".ToLower() &&
                            x.UserRole!.Role!.ArabicName == "خبير" &&
                            x.Category!.CycleId == ActiveCycleId &&
                            x.UserRole!.UserId == UserEntity.Id)
                        .Select(x => x.CategoryId)
                        .ToListAsync();
                }
                else if (Request.asQuality &&
                    (CheckIfThisUserHasFullAccessOrArbitratorRole != null
                        ? CheckIfThisUserHasFullAccessOrArbitratorRole!.Any(x => x.Role!.EnglishName.ToLower() == "Quality".ToLower() &&
                            x.Role!.ArabicName == "الجودة")
                        : false))
                {
                    CategoriesIds = await _UserCategoryRepository
                        .Where(x => x.UserRole!.Role!.EnglishName.ToLower() == "Quality".ToLower() &&
                            x.UserRole!.Role!.ArabicName == "الجودة" &&
                            x.Category!.CycleId == ActiveCycleId &&
                            x.UserRole!.UserId == UserEntity.Id)
                        .Select(x => x.CategoryId)
                        .ToListAsync();
                }

                if (!CategoriesIds.Any())
                    return new BaseResponse<GetAllFormsForFinalArbitrationMainListVM>(ResponseMessage, true, 200, new GetAllFormsForFinalArbitrationMainListVM());

                List<int> ArbitratorFormsIds = await _ArbitrationRepository
                    .Where(x => CategoriesIds.Contains(x.ProvidedForm!.categoryId))
                    .Select(x => x.ProvidedFormId)
                    .ToListAsync();

                List<FinalArbitration> FinalArbitrationEntities = new List<FinalArbitration>();
                List<DynamicAttributeValue> SubscribersNamesCopy = new List<DynamicAttributeValue>();

                int TotalCount = 0;

                if (Request.ArbitrationType is not null)
                {
                    FinalArbitrationEntities = await _FinalArbitrationRepository
                        .Where(x => x.Type == Request.ArbitrationType &&
                            ArbitratorFormsIds.Contains(x.ProvidedFormId) &&
                            x.ProvidedForm!.Category!.CycleId == ActiveCycleId)
                        .ToListAsync();

                    if (!string.IsNullOrEmpty(Request.SubscriberName))
                    {
                        SubscribersNamesCopy = await _DynamicAttributeValueRepository
                            .Where(x => FinalArbitrationEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                                x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                                x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower() &&
                                x.Value.ToLower().StartsWith(Request.SubscriberName.ToLower()))
                            .ToListAsync();

                        if (SubscribersNamesCopy.Any())
                        {
                            if (Request.page != 0 &&
                                Request.perPage != -1)
                            {
                                FinalArbitrationEntities = FinalArbitrationEntities
                                    .Where(x => SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                                    .OrderByDescending(x => x.ProvidedFormId)
                                    .Skip((Request.page - 1) * Request.perPage)
                                    .Take(Request.perPage)
                                    .ToList();
                            }
                            else
                            {
                                FinalArbitrationEntities = FinalArbitrationEntities
                                    .Where(x => SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                                    .OrderByDescending(x => x.ProvidedFormId)
                                    .ToList();
                            }
                        }
                        else
                        {
                            FinalArbitrationEntities = new List<FinalArbitration>();
                        }
                    }
                    else
                    {
                        SubscribersNamesCopy = await _DynamicAttributeValueRepository
                            .Where(x => FinalArbitrationEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                                x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                                x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower())
                            .ToListAsync();
                    }

                    TotalCount = await _FinalArbitrationRepository
                        .GetCountAsync(x => x.Type == Request.ArbitrationType &&
                            ArbitratorFormsIds.Contains(x.ProvidedFormId) &&
                            x.ProvidedForm!.Category!.CycleId == ActiveCycleId &&
                            SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId));
                }
                else
                {
                    FinalArbitrationEntities = await _FinalArbitrationRepository
                        .Where(x => ArbitratorFormsIds.Contains(x.ProvidedFormId) &&
                            x.ProvidedForm!.Category!.CycleId == ActiveCycleId)
                        .ToListAsync();

                    if (!string.IsNullOrEmpty(Request.SubscriberName))
                    {
                        SubscribersNamesCopy = await _DynamicAttributeValueRepository
                            .Where(x => FinalArbitrationEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                                x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                                x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower() &&
                                x.Value.ToLower().StartsWith(Request.SubscriberName.ToLower()))
                            .ToListAsync();

                        if (SubscribersNamesCopy.Any())
                        {
                            if (Request.page != 0 &&
                                Request.perPage != -1)
                            {
                                FinalArbitrationEntities = FinalArbitrationEntities
                                    .Where(x => SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                                    .OrderByDescending(x => x.ProvidedFormId)
                                    .Skip((Request.page - 1) * Request.perPage)
                                    .Take(Request.perPage)
                                    .ToList();
                            }
                            else
                            {
                                FinalArbitrationEntities = FinalArbitrationEntities
                                    .Where(x => SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                                    .OrderByDescending(x => x.ProvidedFormId)
                                    .ToList();
                            }
                        }
                        else
                        {
                            FinalArbitrationEntities = new List<FinalArbitration>();
                        }
                    }
                    else
                    {
                        SubscribersNamesCopy = await _DynamicAttributeValueRepository
                            .Where(x => FinalArbitrationEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                                x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                                x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower())
                            .ToListAsync();
                    }

                    TotalCount = await _FinalArbitrationRepository
                        .GetCountAsync(x => ArbitratorFormsIds.Contains(x.ProvidedFormId) &&
                            x.ProvidedForm!.Category!.CycleId == ActiveCycleId &&
                            SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId));
                }

                var SubscribersNames = SubscribersNamesCopy
                    .Select(x => new
                    {
                        x.RecordId,
                        x.Value
                    }).ToList();

                List<FinalArbitrationScore> FinalArbitrationScoreEntities = await _FinalArbitrationScoreRepository
                    .Where(x => FinalArbitrationEntities.Select(y => y.Id).Contains(x.FinalArbitrationId))
                    .ToListAsync();

                List<GetAllFormsForFinalArbitrationListVM> GetAllFormsForFinalArbitrationListVM = FinalArbitrationEntities
                    .Select(x => new GetAllFormsForFinalArbitrationListVM()
                    {
                        FormId = x.ProvidedFormId,
                        Name = SubscribersNames.FirstOrDefault(y => y.RecordId == x.ProvidedFormId)?.Value ?? "",
                        CategoryId = x.ProvidedForm!.categoryId,
                        CategoryName = Request.lang == "en"
                            ? x.ProvidedForm!.Category!.EnglishName
                            : x.ProvidedForm!.Category!.ArabicName,
                        FinalScore = FinalArbitrationScoreEntities
                            .Where(y => y.FinalArbitrationId == x.Id)
                            .Sum(y => y.ArbitrationScore),
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
                        SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId))
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
    }
}
