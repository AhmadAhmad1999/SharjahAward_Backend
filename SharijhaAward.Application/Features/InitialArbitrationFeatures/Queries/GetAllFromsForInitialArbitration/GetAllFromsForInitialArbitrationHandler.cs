using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.ComitteeArbitratorModel;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Application.Features.InitialArbitrationFeatures.Queries.GetAllFromsForInitialArbitration
{
    public class GetAllFromsForInitialArbitrationHandler
        : IRequestHandler<GetAllFromsForInitialArbitrationQuery, BaseResponse<GetAllFromsForInitialArbitrationFullResponse>>
    {
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        private readonly IAsyncRepository<Arbitrator> _ArbitratorRepository;
        private readonly IAsyncRepository<UserRole> _UserRoleRepository;
        private readonly IAsyncRepository<ComitteeArbitrator> _ComitteeArbitratorRepository;
        private readonly IAsyncRepository<ComitteeOfficer> _ComitteeOfficerRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IAsyncRepository<InitialArbitration> _InitialArbitrationRepository;
        private readonly IAsyncRepository<Cycle> _CycleRepository;
        private readonly IAsyncRepository<Domain.Entities.IdentityModels.User> _UserRepository;
        private readonly IAsyncRepository<UserCategory> _UserCategoryRepository;
        private readonly IJwtProvider _JWTProvider;

        public GetAllFromsForInitialArbitrationHandler(IAsyncRepository<Arbitration> ArbitrationRepository,
            IAsyncRepository<Arbitrator> _ArbitratorRepository,
            IAsyncRepository<UserRole> _UserRoleRepository,
            IAsyncRepository<ComitteeArbitrator> _ComitteeArbitratorRepository,
            IAsyncRepository<ComitteeOfficer> _ComitteeOfficerRepository,
            IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository,
            IAsyncRepository<InitialArbitration> _InitialArbitrationRepository,
            IAsyncRepository<Cycle> _CycleRepository,
            IJwtProvider _JWTProvider,
            IAsyncRepository<Domain.Entities.IdentityModels.User> _UserRepository,
            IAsyncRepository<UserCategory> _UserCategoryRepository)
        {
            _ArbitrationRepository = ArbitrationRepository;
            this._ArbitratorRepository = _ArbitratorRepository;
            this._UserRoleRepository = _UserRoleRepository;
            this._ComitteeArbitratorRepository = _ComitteeArbitratorRepository;
            this._ComitteeOfficerRepository = _ComitteeOfficerRepository;
            this._DynamicAttributeValueRepository = _DynamicAttributeValueRepository;
            this._InitialArbitrationRepository = _InitialArbitrationRepository;
            this._CycleRepository = _CycleRepository;
            this._JWTProvider = _JWTProvider;
            this._UserRepository = _UserRepository;
            this._UserCategoryRepository = _UserCategoryRepository;
        }
        public async Task<BaseResponse<GetAllFromsForInitialArbitrationFullResponse>> 
            Handle(GetAllFromsForInitialArbitrationQuery Request, CancellationToken cancellationToken)
        {
            if (Request.filter != null
                ? Request.filter.ArbitrationStartDate > Request.filter.ArbitrationEndDate
                : false)
            {
                DateTime? DateSwapper = Request.filter.ArbitrationStartDate;
                Request.filter.ArbitrationStartDate = Request.filter.ArbitrationEndDate;
                Request.filter.ArbitrationEndDate = DateSwapper;
            }

            FilterObject filterObject = new FilterObject() { Filters = Request.filters };

            string ResponseMessage = string.Empty;

            int UserId = int.Parse(_JWTProvider.GetUserIdFromToken(Request.Token!));

            List<UserRole> CheckIfThisUserHasFullAccessOrArbitratorRole = await _UserRoleRepository
                .Where(x => x.UserId == UserId)
                .ToListAsync();

            if ((CheckIfThisUserHasFullAccessOrArbitratorRole is not null
                ? CheckIfThisUserHasFullAccessOrArbitratorRole.Any(x => x.Role!.HaveFullAccess)
                : false) && Request.AsFullAccess)
            {
                List<Arbitration> ArbitrationEntities = await _ArbitrationRepository
                    .Where(x => (Request.ArbitrationType != null
                        ? x.Type == Request.ArbitrationType
                        : true) &&
                        (Request.filter != null
                            ? ((!string.IsNullOrEmpty(Request.filter.ArbitratorName)
                                ? (Request.lang == "en"
                                    ? x.Arbitrator!.EnglishName.ToLower().StartsWith(Request.filter.ArbitratorName.ToLower())
                                    : x.Arbitrator!.ArabicName.ToLower().StartsWith(Request.filter.ArbitratorName.ToLower()))
                                : true) &&
                                (Request.filter.ArbitrationStartDate != null
                                    ? (x.DateOfArbitration != null
                                        ? (x.DateOfArbitration >= Request.filter.ArbitrationStartDate)
                                        : false)
                                    : true) &&
                                (Request.filter.ArbitrationEndDate != null
                                    ? (x.DateOfArbitration != null
                                        ? (x.DateOfArbitration <= Request.filter.ArbitrationEndDate)
                                        : false)
                                    : true) &&
                                (Request.filter.isAccepted != null
                                    ? x.isAcceptedFromChairman == Request.filter.isAccepted.Value
                                    : true))
                            : true))
                    .OrderByDescending(x => x.CreatedAt)
                    .ToListAsync();

                List<DynamicAttributeValue> SubscribersNamesCopy = new List<DynamicAttributeValue>();

                if (Request.filter != null
                    ? !string.IsNullOrEmpty(Request.filter.SubscriberName)
                    : false)
                {
                    SubscribersNamesCopy = await _DynamicAttributeValueRepository
                        .Where(x => ArbitrationEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) && 
                            x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                            x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower() &&
                            x.Value.ToLower().StartsWith(Request.filter.SubscriberName.ToLower()))
                        .ToListAsync();

                    if (SubscribersNamesCopy.Any())
                    {
                        if (Request.page != 0 &&
                            Request.perPage != -1)
                        {
                            ArbitrationEntities = ArbitrationEntities
                                .Where(x => SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                                .Skip((Request.page - 1) * Request.perPage)
                                .Take(Request.perPage)
                                .ToList();
                        }
                        else
                        {
                            ArbitrationEntities = ArbitrationEntities
                                .Where(x => SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                                .ToList();
                        }
                    }
                    else
                    {
                        ArbitrationEntities = new List<Arbitration>();
                    }
                }
                else
                {
                    SubscribersNamesCopy = await _DynamicAttributeValueRepository
                        .Where(x => ArbitrationEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) && 
                            x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                            x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower())
                        .ToListAsync();
                }

                var SubscribersNames = SubscribersNamesCopy
                    .Select(x => new
                    {
                        x.RecordId,
                        x.Value
                    }).ToList();

                List<InitialArbitration> InitialArbitrationEntities = await _InitialArbitrationRepository
                    .Where(x => ArbitrationEntities.Select(y => y.Id).Contains(x.ArbitrationId))
                    .ToListAsync();

                List<GetAllFromsForInitialArbitrationListVM> Response = ArbitrationEntities
                    .Select(x => new GetAllFromsForInitialArbitrationListVM()
                    {
                        Id = x.Id,
                        FormId = x.ProvidedFormId,
                        ArbitrationType = x.Type,
                        CategoryId = x.ProvidedForm!.categoryId,
                        CategoryName = Request.lang == "en"
                            ? x.ProvidedForm!.Category!.EnglishName
                            : x.ProvidedForm!.Category!.ArabicName,
                        DateOfArbitration = x.DateOfArbitration,
                        Name = SubscribersNames.FirstOrDefault(y => y.RecordId == x.ProvidedFormId) ? .Value ?? "",
                        FullArbitrationScore = InitialArbitrationEntities
                            .Where(y => y.ArbitrationId == x.Id)
                            .Sum(y => y.ArbitrationScore),
                        isAcceptedFromChairman = x.isAcceptedFromChairman,
                        ArbitratorName = Request.lang == "en"
                            ? x.Arbitrator!.EnglishName
                            : x.Arbitrator!.ArabicName
                    }).ToList();

                var FullTotalCount = await _ArbitrationRepository
                    .Where(x => (Request.filter != null
                        ? ((!string.IsNullOrEmpty(Request.filter.ArbitratorName)
                            ? (Request.lang == "en"
                                ? x.Arbitrator!.EnglishName.ToLower().StartsWith(Request.filter.ArbitratorName.ToLower())
                                : x.Arbitrator!.ArabicName.ToLower().StartsWith(Request.filter.ArbitratorName.ToLower()))
                            : true) &&
                            (Request.filter.ArbitrationStartDate != null
                                ? (x.DateOfArbitration != null
                                    ? (x.DateOfArbitration >= Request.filter.ArbitrationStartDate)
                                    : false)
                                : true) &&
                            (Request.filter.ArbitrationEndDate != null
                                ? (x.DateOfArbitration != null
                                    ? (x.DateOfArbitration <= Request.filter.ArbitrationEndDate)
                                    : false)
                                : true) &&
                            (Request.filter.isAccepted != null
                                ? x.isAcceptedFromChairman == Request.filter.isAccepted.Value
                                : true))
                        : true) &&
                        SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                    .Select(x => x.Type)
                    .GroupBy(x => x)
                    .Select(g => new { Type = g.Key, Count = g.Count() })
                    .ToListAsync();

                GetAllFromsForInitialArbitrationFullResponse FullResponse = new GetAllFromsForInitialArbitrationFullResponse()
                {
                    GetAllFromsForInitialArbitrationListVM = Response,
                    NumberOfNotBeenArbitratedForms = FullTotalCount.FirstOrDefault(x => x.Type == ArbitrationType.NotBeenArbitrated) != null
                        ? FullTotalCount.FirstOrDefault(x => x.Type == ArbitrationType.NotBeenArbitrated)!.Count : 0,
                    NumberOfBeingReviewedForms = FullTotalCount.FirstOrDefault(x => x.Type == ArbitrationType.BeingReviewed) != null
                        ? FullTotalCount.FirstOrDefault(x => x.Type == ArbitrationType.BeingReviewed)!.Count : 0,
                    NumberOfDoneArbitratodForms = FullTotalCount.FirstOrDefault(x => x.Type == ArbitrationType.DoneArbitratod) != null
                        ? FullTotalCount.FirstOrDefault(x => x.Type == ArbitrationType.DoneArbitratod)!.Count : 0,
                };

                if (Request.ArbitrationType != null)
                {
                    int TotalCount = FullTotalCount.FirstOrDefault(x => x.Type == Request.ArbitrationType) != null
                        ? FullTotalCount.FirstOrDefault(x => x.Type == Request.ArbitrationType)!.Count
                        : FullTotalCount.Sum(x => x.Count);

                    Pagination PaginationParameter = new Pagination(Request.page,
                        Request.perPage, TotalCount);

                    return new BaseResponse<GetAllFromsForInitialArbitrationFullResponse>(ResponseMessage, true, 200, FullResponse, PaginationParameter);
                }
                else
                {
                    int TotalCount = FullTotalCount.Sum(x => x.Count);

                    Pagination PaginationParameter = new Pagination(Request.page,
                        Request.perPage, TotalCount);

                    return new BaseResponse<GetAllFromsForInitialArbitrationFullResponse>(ResponseMessage, true, 200, FullResponse, PaginationParameter);
                }
            }
            else if (CheckIfThisUserHasFullAccessOrArbitratorRole is not null
                ? (CheckIfThisUserHasFullAccessOrArbitratorRole.Any(x => x.Role!.EnglishName.ToLower() == "arbitrator" &&
                    x.Role!.ArabicName == "محكم") && 
                    (Request.asNormalArbitrator || (Request.asChairman != null ? Request.asChairman.Value : false) ||
                     Request.asSubcommitteeOfficer))
                : false)
            {
                Cycle? CheckIfThereIsActiveCycle = await _CycleRepository
                    .FirstOrDefaultAsync(x => x.Status == Domain.Constants.Common.Status.Active);

                if (CheckIfThereIsActiveCycle is null)
                    return new BaseResponse<GetAllFromsForInitialArbitrationFullResponse>(ResponseMessage, false, 200);

                int ActiveCycleId = CheckIfThereIsActiveCycle.Id;

                Arbitrator? ArbitratorEntity = await _ArbitratorRepository
                    .FirstOrDefaultAsync(x => x.Id == UserId);

                if (ArbitratorEntity is null)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "Arbitrator is not Found"
                        : "المحكم غير موجود";

                    return new BaseResponse<GetAllFromsForInitialArbitrationFullResponse>(ResponseMessage, false, 404);
                }

                if (ArbitratorEntity.isChairman &&
                    (Request.asChairman != null ? Request.asChairman.Value : false))
                {
                    List<int> ArbitratorsIdsInCommittee = await _ComitteeArbitratorRepository
                        .Where(x => x.Committee!.ChairmanId == ArbitratorEntity.Id)
                        .Select(x => x.ArbitratorId)
                        .Distinct()
                        .ToListAsync();

                    List<Arbitration> ArbitrationEntities = new List<Arbitration>();

                    if (Request.ArbitrationType != null)
                    {
                        ArbitrationEntities = await _ArbitrationRepository
                            .Where(x => ArbitratorsIdsInCommittee.Contains(x.ArbitratorId) &&
                                x.Type == Request.ArbitrationType &&
                                x.ProvidedForm!.Category!.CycleId == ActiveCycleId &&
                                (Request.filter != null
                                    ? ((!string.IsNullOrEmpty(Request.filter.ArbitratorName)
                                        ? (Request.lang == "en"
                                            ? x.Arbitrator!.EnglishName.ToLower().StartsWith(Request.filter.ArbitratorName.ToLower())
                                            : x.Arbitrator!.ArabicName.ToLower().StartsWith(Request.filter.ArbitratorName.ToLower()))
                                        : true) &&
                                        (Request.filter.ArbitrationStartDate != null
                                            ? (x.DateOfArbitration != null
                                                ? (x.DateOfArbitration >= Request.filter.ArbitrationStartDate)
                                                : false)
                                            : true) &&
                                        (Request.filter.ArbitrationEndDate != null
                                            ? (x.DateOfArbitration != null
                                                ? (x.DateOfArbitration <= Request.filter.ArbitrationEndDate)
                                                : false)
                                            : true) &&
                                        (Request.filter.isAccepted != null
                                            ? x.isAcceptedFromChairman == Request.filter.isAccepted.Value
                                            : true))
                                    : true))
                            .OrderByDescending(x => x.CreatedAt)
                            .ToListAsync();
                    }
                    else
                    {
                        ArbitrationEntities = await _ArbitrationRepository
                            .Where(x => ArbitratorsIdsInCommittee.Contains(x.ArbitratorId) &&
                                x.ProvidedForm!.Category!.CycleId == ActiveCycleId &&
                                (Request.filter != null
                                    ? ((!string.IsNullOrEmpty(Request.filter.ArbitratorName)
                                        ? (Request.lang == "en"
                                            ? x.Arbitrator!.EnglishName.ToLower().StartsWith(Request.filter.ArbitratorName.ToLower())
                                            : x.Arbitrator!.ArabicName.ToLower().StartsWith(Request.filter.ArbitratorName.ToLower()))
                                        : true) &&
                                        (Request.filter.ArbitrationStartDate != null
                                            ? (x.DateOfArbitration != null
                                                ? (x.DateOfArbitration >= Request.filter.ArbitrationStartDate)
                                                : false)
                                            : true) &&
                                        (Request.filter.ArbitrationEndDate != null
                                            ? (x.DateOfArbitration != null
                                                ? (x.DateOfArbitration <= Request.filter.ArbitrationEndDate)
                                                : false)
                                            : true) &&
                                        (Request.filter.isAccepted != null
                                            ? x.isAcceptedFromChairman == Request.filter.isAccepted.Value
                                            : true))
                                    : true))
                            .OrderByDescending(x => x.CreatedAt)
                            .ToListAsync();
                    }

                    List<DynamicAttributeValue> SubscribersNamesCopy = new List<DynamicAttributeValue>();

                    if (Request.filter != null
                        ? !string.IsNullOrEmpty(Request.filter.SubscriberName)
                        : false)
                    {
                        SubscribersNamesCopy = await _DynamicAttributeValueRepository
                            .Where(x => ArbitrationEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) && 
                                x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                                x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower() &&
                                x.Value.ToLower().StartsWith(Request.filter.SubscriberName.ToLower()))
                            .ToListAsync();

                        if (SubscribersNamesCopy.Any())
                        {
                            if (Request.page != 0 &&
                                Request.perPage != -1)
                            {
                                ArbitrationEntities = ArbitrationEntities
                                    .Where(x => SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                                    .Skip((Request.page - 1) * Request.perPage)
                                    .Take(Request.perPage)
                                    .ToList();
                            }
                            else
                            {
                                ArbitrationEntities = ArbitrationEntities
                                    .Where(x => SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                                    .ToList();
                            }
                        }
                        else
                        {
                            ArbitrationEntities = new List<Arbitration>();
                        }
                    }
                    else
                    {
                        SubscribersNamesCopy = await _DynamicAttributeValueRepository
                            .Where(x => ArbitrationEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) && 
                                x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                                x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower())
                            .ToListAsync();
                    }

                    var SubscribersNames = SubscribersNamesCopy
                        .Select(x => new
                        {
                            x.RecordId,
                            x.Value
                        }).ToList();

                    List<InitialArbitration> InitialArbitrationEntities = await _InitialArbitrationRepository
                        .Where(x => ArbitrationEntities.Select(y => y.Id).Contains(x.ArbitrationId))
                        .ToListAsync();

                    List<GetAllFromsForInitialArbitrationListVM> Response = ArbitrationEntities
                        .Select(x => new GetAllFromsForInitialArbitrationListVM()
                        {
                            Id = x.Id,
                            FormId = x.ProvidedFormId,
                            ArbitrationType = x.Type,
                            CategoryId = x.ProvidedForm!.categoryId,
                            CategoryName = Request.lang == "en"
                                ? x.ProvidedForm!.Category!.EnglishName
                                : x.ProvidedForm!.Category!.ArabicName,
                            DateOfArbitration = x.DateOfArbitration,
                            Name = SubscribersNames.FirstOrDefault(y => y.RecordId == x.ProvidedFormId) ? .Value ?? "",
                            FullArbitrationScore = InitialArbitrationEntities
                                .Where(y => y.ArbitrationId == x.Id)
                                .Sum(y => y.ArbitrationScore),
                            isAcceptedFromChairman = x.isAcceptedFromChairman,
                            ArbitratorName = Request.lang == "en"
                                ? x.Arbitrator!.EnglishName
                                : x.Arbitrator!.ArabicName
                        }).ToList();

                    var FullTotalCount = await _ArbitrationRepository
                        .Where(x => ArbitratorsIdsInCommittee.Contains(x.ArbitratorId) &&
                            x.ProvidedForm!.Category!.CycleId == ActiveCycleId &&
                            (Request.filter != null
                                ? ((!string.IsNullOrEmpty(Request.filter.ArbitratorName)
                                    ? (Request.lang == "en"
                                        ? x.Arbitrator!.EnglishName.ToLower().StartsWith(Request.filter.ArbitratorName.ToLower())
                                        : x.Arbitrator!.ArabicName.ToLower().StartsWith(Request.filter.ArbitratorName.ToLower()))
                                    : true) &&
                                    (Request.filter.ArbitrationStartDate != null
                                        ? (x.DateOfArbitration != null
                                            ? (x.DateOfArbitration >= Request.filter.ArbitrationStartDate)
                                            : false)
                                        : true) &&
                                    (Request.filter.ArbitrationEndDate != null
                                        ? (x.DateOfArbitration != null
                                            ? (x.DateOfArbitration <= Request.filter.ArbitrationEndDate)
                                            : false)
                                        : true) &&
                                    (Request.filter.isAccepted != null
                                        ? x.isAcceptedFromChairman == Request.filter.isAccepted.Value
                                        : true))
                                : true) &&
                            SubscribersNames.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                        .Select(x => x.Type)
                        .GroupBy(x => x)
                        .Select(g => new { Type = g.Key, Count = g.Count() })
                        .ToListAsync();

                    GetAllFromsForInitialArbitrationFullResponse FullResponse = new GetAllFromsForInitialArbitrationFullResponse()
                    {
                        GetAllFromsForInitialArbitrationListVM = Response,
                        NumberOfNotBeenArbitratedForms = FullTotalCount.FirstOrDefault(x => x.Type == ArbitrationType.NotBeenArbitrated) != null
                            ? FullTotalCount.FirstOrDefault(x => x.Type == ArbitrationType.NotBeenArbitrated)!.Count : 0,
                        NumberOfBeingReviewedForms = FullTotalCount.FirstOrDefault(x => x.Type == ArbitrationType.BeingReviewed) != null
                            ? FullTotalCount.FirstOrDefault(x => x.Type == ArbitrationType.BeingReviewed)!.Count : 0,
                        NumberOfDoneArbitratodForms = FullTotalCount.FirstOrDefault(x => x.Type == ArbitrationType.DoneArbitratod) != null
                            ? FullTotalCount.FirstOrDefault(x => x.Type == ArbitrationType.DoneArbitratod)!.Count : 0,
                    };

                    int TotalCount = await _ArbitrationRepository.GetCountAsync(x => ArbitratorsIdsInCommittee.Contains(x.ArbitratorId) &&
                        (Request.ArbitrationType != null
                            ? x.Type == Request.ArbitrationType
                            : true) &&
                        x.ProvidedForm!.Category!.CycleId == ActiveCycleId &&
                        (Request.filter != null
                            ? ((!string.IsNullOrEmpty(Request.filter.ArbitratorName)
                                ? (Request.lang == "en"
                                    ? x.Arbitrator!.EnglishName.ToLower().StartsWith(Request.filter.ArbitratorName.ToLower())
                                    : x.Arbitrator!.ArabicName.ToLower().StartsWith(Request.filter.ArbitratorName.ToLower()))
                                : true) &&
                                (Request.filter.ArbitrationStartDate != null
                                    ? (x.DateOfArbitration != null
                                        ? (x.DateOfArbitration >= Request.filter.ArbitrationStartDate)
                                        : false)
                                    : true) &&
                                (Request.filter.ArbitrationEndDate != null
                                    ? (x.DateOfArbitration != null
                                        ? (x.DateOfArbitration <= Request.filter.ArbitrationEndDate)
                                        : false)
                                    : true) &&
                                (Request.filter.isAccepted != null
                                    ? x.isAcceptedFromChairman == Request.filter.isAccepted.Value
                                    : true))
                            : true) &&
                        SubscribersNames.Select(y => y.RecordId).Contains(x.ProvidedFormId));

                    Pagination PaginationParameter = new Pagination(Request.page,
                        Request.perPage, TotalCount);

                    return new BaseResponse<GetAllFromsForInitialArbitrationFullResponse>(ResponseMessage, true, 200, FullResponse, PaginationParameter);
                }
                else if (ArbitratorEntity.isSubcommitteeOfficer &&
                    Request.asSubcommitteeOfficer)
                {
                    List<int> ComitteesIds = await _ComitteeOfficerRepository
                        .Where(x => x.ArbitratorId == ArbitratorEntity.Id)
                        .Select(x => x.CommitteeId)
                        .Distinct()
                        .ToListAsync();

                    List<int> ArbitratorsIdsInCommittee = await _ComitteeArbitratorRepository
                        .Where(x => ComitteesIds.Contains(x.CommitteeId))
                        .Select(x => x.ArbitratorId)
                        .Distinct()
                        .ToListAsync();

                    List<Arbitration> ArbitrationEntities = new List<Arbitration>();

                    if (Request.ArbitrationType != null)
                    {
                        ArbitrationEntities = await _ArbitrationRepository
                            .Where(x => ArbitratorsIdsInCommittee.Contains(x.ArbitratorId) &&
                                x.Type == Request.ArbitrationType &&
                                x.ProvidedForm!.Category!.CycleId == ActiveCycleId &&
                                (Request.filter != null
                                    ? ((!string.IsNullOrEmpty(Request.filter.ArbitratorName)
                                        ? (Request.lang == "en"
                                            ? x.Arbitrator!.EnglishName.ToLower().StartsWith(Request.filter.ArbitratorName.ToLower())
                                            : x.Arbitrator!.ArabicName.ToLower().StartsWith(Request.filter.ArbitratorName.ToLower()))
                                        : true) &&
                                        (Request.filter.ArbitrationStartDate != null
                                            ? (x.DateOfArbitration != null
                                                ? (x.DateOfArbitration >= Request.filter.ArbitrationStartDate)
                                                : false)
                                            : true) &&
                                        (Request.filter.ArbitrationEndDate != null
                                            ? (x.DateOfArbitration != null
                                                ? (x.DateOfArbitration <= Request.filter.ArbitrationEndDate)
                                                : false)
                                            : true) &&
                                        (Request.filter.isAccepted != null
                                            ? x.isAcceptedFromChairman == Request.filter.isAccepted.Value
                                            : true))
                                    : true))
                            .OrderByDescending(x => x.CreatedAt)
                            .ToListAsync();
                    }
                    else
                    {
                        ArbitrationEntities = await _ArbitrationRepository
                            .Where(x => ArbitratorsIdsInCommittee.Contains(x.ArbitratorId) &&
                                x.ProvidedForm!.Category!.CycleId == ActiveCycleId &&
                                (Request.filter != null
                                    ? ((!string.IsNullOrEmpty(Request.filter.ArbitratorName)
                                        ? (Request.lang == "en"
                                            ? x.Arbitrator!.EnglishName.ToLower().StartsWith(Request.filter.ArbitratorName.ToLower())
                                            : x.Arbitrator!.ArabicName.ToLower().StartsWith(Request.filter.ArbitratorName.ToLower()))
                                        : true) &&
                                        (Request.filter.ArbitrationStartDate != null
                                            ? (x.DateOfArbitration != null
                                                ? (x.DateOfArbitration >= Request.filter.ArbitrationStartDate)
                                                : false)
                                            : true) &&
                                        (Request.filter.ArbitrationEndDate != null
                                            ? (x.DateOfArbitration != null
                                                ? (x.DateOfArbitration <= Request.filter.ArbitrationEndDate)
                                                : false)
                                            : true) &&
                                        (Request.filter.isAccepted != null
                                            ? x.isAcceptedFromChairman == Request.filter.isAccepted.Value
                                            : true))
                                    : true))
                            .OrderByDescending(x => x.CreatedAt)
                            .ToListAsync();
                    }

                    List<DynamicAttributeValue> SubscribersNamesCopy = new List<DynamicAttributeValue>();

                    if (Request.filter != null
                        ? !string.IsNullOrEmpty(Request.filter.SubscriberName)
                        : false)
                    {
                        SubscribersNamesCopy = await _DynamicAttributeValueRepository
                            .Where(x => ArbitrationEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                                x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                                x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower() &&
                                x.Value.ToLower().StartsWith(Request.filter.SubscriberName.ToLower()))
                            .ToListAsync();

                        if (SubscribersNamesCopy.Any())
                        {
                            if (Request.page != 0 &&
                                Request.perPage != -1)
                            {
                                ArbitrationEntities = ArbitrationEntities
                                    .Where(x => SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                                    .Skip((Request.page - 1) * Request.perPage)
                                    .Take(Request.perPage)
                                    .ToList();
                            }
                            else
                            {
                                ArbitrationEntities = ArbitrationEntities
                                    .Where(x => SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                                    .ToList();
                            }
                        }
                        else
                        {
                            ArbitrationEntities = new List<Arbitration>();
                        }
                    }
                    else
                    {
                        SubscribersNamesCopy = await _DynamicAttributeValueRepository
                            .Where(x => ArbitrationEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                                x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                                x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower())
                            .ToListAsync();
                    }

                    var SubscribersNames = SubscribersNamesCopy
                        .Select(x => new
                        {
                            x.RecordId,
                            x.Value
                        }).ToList();

                    List<InitialArbitration> InitialArbitrationEntities = await _InitialArbitrationRepository
                        .Where(x => ArbitrationEntities.Select(y => y.Id).Contains(x.ArbitrationId))
                        .ToListAsync();

                    List<GetAllFromsForInitialArbitrationListVM> Response = ArbitrationEntities
                        .Select(x => new GetAllFromsForInitialArbitrationListVM()
                        {
                            Id = x.Id,
                            FormId = x.ProvidedFormId,
                            ArbitrationType = x.Type,
                            CategoryId = x.ProvidedForm!.categoryId,
                            CategoryName = Request.lang == "en"
                                ? x.ProvidedForm!.Category!.EnglishName
                                : x.ProvidedForm!.Category!.ArabicName,
                            DateOfArbitration = x.DateOfArbitration,
                            Name = SubscribersNames.FirstOrDefault(y => y.RecordId == x.ProvidedFormId)?.Value ?? "",
                            FullArbitrationScore = InitialArbitrationEntities
                                .Where(y => y.ArbitrationId == x.Id)
                                .Sum(y => y.ArbitrationScore),
                            isAcceptedFromChairman = x.isAcceptedFromChairman,
                            ArbitratorName = Request.lang == "en"
                                ? x.Arbitrator!.EnglishName
                                : x.Arbitrator!.ArabicName
                        }).ToList();

                    var FullTotalCount = await _ArbitrationRepository
                        .Where(x => ArbitratorsIdsInCommittee.Contains(x.ArbitratorId) &&
                            x.ProvidedForm!.Category!.CycleId == ActiveCycleId &&
                            (Request.filter != null
                                ? ((!string.IsNullOrEmpty(Request.filter.ArbitratorName)
                                    ? (Request.lang == "en"
                                        ? x.Arbitrator!.EnglishName.ToLower().StartsWith(Request.filter.ArbitratorName.ToLower())
                                        : x.Arbitrator!.ArabicName.ToLower().StartsWith(Request.filter.ArbitratorName.ToLower()))
                                    : true) &&
                                    (Request.filter.ArbitrationStartDate != null
                                        ? (x.DateOfArbitration != null
                                            ? (x.DateOfArbitration >= Request.filter.ArbitrationStartDate)
                                            : false)
                                        : true) &&
                                    (Request.filter.ArbitrationEndDate != null
                                        ? (x.DateOfArbitration != null
                                            ? (x.DateOfArbitration <= Request.filter.ArbitrationEndDate)
                                            : false)
                                        : true) &&
                                    (Request.filter.isAccepted != null
                                        ? x.isAcceptedFromChairman == Request.filter.isAccepted.Value
                                        : true))
                                : true) &&
                            SubscribersNames.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                        .Select(x => x.Type)
                        .GroupBy(x => x)
                        .Select(g => new { Type = g.Key, Count = g.Count() })
                        .ToListAsync();

                    GetAllFromsForInitialArbitrationFullResponse FullResponse = new GetAllFromsForInitialArbitrationFullResponse()
                    {
                        GetAllFromsForInitialArbitrationListVM = Response,
                        NumberOfNotBeenArbitratedForms = FullTotalCount.FirstOrDefault(x => x.Type == ArbitrationType.NotBeenArbitrated) != null
                            ? FullTotalCount.FirstOrDefault(x => x.Type == ArbitrationType.NotBeenArbitrated)!.Count : 0,
                        NumberOfBeingReviewedForms = FullTotalCount.FirstOrDefault(x => x.Type == ArbitrationType.BeingReviewed) != null
                            ? FullTotalCount.FirstOrDefault(x => x.Type == ArbitrationType.BeingReviewed)!.Count : 0,
                        NumberOfDoneArbitratodForms = FullTotalCount.FirstOrDefault(x => x.Type == ArbitrationType.DoneArbitratod) != null
                            ? FullTotalCount.FirstOrDefault(x => x.Type == ArbitrationType.DoneArbitratod)!.Count : 0,
                    };

                    int TotalCount = await _ArbitrationRepository.GetCountAsync(x => ArbitratorsIdsInCommittee.Contains(x.ArbitratorId) &&
                        (Request.ArbitrationType != null
                            ? x.Type == Request.ArbitrationType
                            : true) &&
                        x.ProvidedForm!.Category!.CycleId == ActiveCycleId &&
                        (Request.filter != null
                            ? ((!string.IsNullOrEmpty(Request.filter.ArbitratorName)
                                ? (Request.lang == "en"
                                    ? x.Arbitrator!.EnglishName.ToLower().StartsWith(Request.filter.ArbitratorName.ToLower())
                                    : x.Arbitrator!.ArabicName.ToLower().StartsWith(Request.filter.ArbitratorName.ToLower()))
                                : true) &&
                                (Request.filter.ArbitrationStartDate != null
                                    ? (x.DateOfArbitration != null
                                        ? (x.DateOfArbitration >= Request.filter.ArbitrationStartDate)
                                        : false)
                                    : true) &&
                                (Request.filter.ArbitrationEndDate != null
                                    ? (x.DateOfArbitration != null
                                        ? (x.DateOfArbitration <= Request.filter.ArbitrationEndDate)
                                        : false)
                                    : true) &&
                                (Request.filter.isAccepted != null
                                    ? x.isAcceptedFromChairman == Request.filter.isAccepted.Value
                                    : true))
                            : true) &&
                        SubscribersNames.Select(y => y.RecordId).Contains(x.ProvidedFormId));

                    Pagination PaginationParameter = new Pagination(Request.page,
                        Request.perPage, TotalCount);

                    return new BaseResponse<GetAllFromsForInitialArbitrationFullResponse>(ResponseMessage, true, 200, FullResponse, PaginationParameter);
                }
                else
                {
                    List<Arbitration> ArbitrationEntities = await _ArbitrationRepository
                        .Where(x => UserId == x.ArbitratorId &&
                            x.ProvidedForm!.Category!.CycleId == ActiveCycleId &&
                            (Request.ArbitrationType != null
                                ? x.Type == Request.ArbitrationType
                                : true) &&
                            (Request.filter != null
                                ? ((!string.IsNullOrEmpty(Request.filter.ArbitratorName)
                                    ? (Request.lang == "en"
                                        ? x.Arbitrator!.EnglishName.ToLower().StartsWith(Request.filter.ArbitratorName.ToLower())
                                        : x.Arbitrator!.ArabicName.ToLower().StartsWith(Request.filter.ArbitratorName.ToLower()))
                                    : true) &&
                                    (Request.filter.ArbitrationStartDate != null
                                        ? (x.DateOfArbitration != null
                                            ? (x.DateOfArbitration >= Request.filter.ArbitrationStartDate)
                                            : false)
                                        : true) &&
                                    (Request.filter.ArbitrationEndDate != null
                                        ? (x.DateOfArbitration != null
                                            ? (x.DateOfArbitration <= Request.filter.ArbitrationEndDate)
                                            : false)
                                        : true) &&
                                    (Request.filter.isAccepted != null
                                        ? x.isAcceptedFromChairman == Request.filter.isAccepted.Value
                                        : true))
                                : true))
                        .OrderByDescending(x => x.CreatedAt)
                        .ToListAsync();

                    List<DynamicAttributeValue> SubscribersNamesCopy = new List<DynamicAttributeValue>();

                    if (Request.filter != null
                        ? !string.IsNullOrEmpty(Request.filter.SubscriberName)
                        : false)
                    {
                        SubscribersNamesCopy = await _DynamicAttributeValueRepository
                            .Where(x => ArbitrationEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) && 
                                x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                                x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower() &&
                                x.Value.ToLower().StartsWith(Request.filter.SubscriberName.ToLower()))
                            .ToListAsync();

                        if (SubscribersNamesCopy.Any())
                        {
                            if (Request.page != 0 &&
                                Request.perPage != -1)
                            {
                                ArbitrationEntities = ArbitrationEntities
                                    .Where(x => SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                                    .Skip((Request.page - 1) * Request.perPage)
                                    .Take(Request.perPage)
                                    .ToList();
                            }
                            else
                            {
                                ArbitrationEntities = ArbitrationEntities
                                    .Where(x => SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                                    .ToList();
                            }
                        }
                        else
                        {
                            ArbitrationEntities = new List<Arbitration>();
                        }
                    }
                    else
                    {
                        SubscribersNamesCopy = await _DynamicAttributeValueRepository
                            .Where(x => ArbitrationEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) && 
                                x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                                x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower())
                            .ToListAsync();
                    }

                    var SubscribersNames = SubscribersNamesCopy
                        .Select(x => new
                        {
                            x.RecordId,
                            x.Value
                        }).ToList();

                    List<InitialArbitration> InitialArbitrationEntities = await _InitialArbitrationRepository
                        .Where(x => ArbitrationEntities.Select(y => y.Id).Contains(x.ArbitrationId))
                        .ToListAsync();

                    List<GetAllFromsForInitialArbitrationListVM> Response = ArbitrationEntities
                        .Select(x => new GetAllFromsForInitialArbitrationListVM()
                        {
                            Id = x.Id,
                            FormId = x.ProvidedFormId,
                            ArbitrationType = x.Type,
                            CategoryId = x.ProvidedForm!.categoryId,
                            CategoryName = Request.lang == "en"
                                ? x.ProvidedForm!.Category!.EnglishName
                                : x.ProvidedForm!.Category!.ArabicName,
                            DateOfArbitration = x.DateOfArbitration,
                            Name = SubscribersNames.FirstOrDefault(y => y.RecordId == x.ProvidedFormId) ? .Value ?? "",
                            FullArbitrationScore = InitialArbitrationEntities
                                .Where(y => y.ArbitrationId == x.Id)
                                .Sum(y => y.ArbitrationScore),
                            isAcceptedFromChairman = x.isAcceptedFromChairman,
                            ArbitratorName = Request.lang == "en"
                                ? x.Arbitrator!.EnglishName
                                : x.Arbitrator!.ArabicName
                        }).ToList();

                    var FullTotalCount = await _ArbitrationRepository
                        .Where(x => x.ArbitratorId == UserId &&
                            x.ProvidedForm!.Category!.CycleId == ActiveCycleId &&
                            (Request.filter != null
                                ? ((!string.IsNullOrEmpty(Request.filter.ArbitratorName)
                                    ? (Request.lang == "en"
                                        ? x.Arbitrator!.EnglishName.ToLower().StartsWith(Request.filter.ArbitratorName.ToLower())
                                        : x.Arbitrator!.ArabicName.ToLower().StartsWith(Request.filter.ArbitratorName.ToLower()))
                                    : true) &&
                                    (Request.filter.ArbitrationStartDate != null
                                        ? (x.DateOfArbitration != null
                                            ? (x.DateOfArbitration >= Request.filter.ArbitrationStartDate)
                                            : false)
                                        : true) &&
                                    (Request.filter.ArbitrationEndDate != null
                                        ? (x.DateOfArbitration != null
                                            ? (x.DateOfArbitration <= Request.filter.ArbitrationEndDate)
                                            : false)
                                        : true) &&
                                    (Request.filter.isAccepted != null
                                        ? x.isAcceptedFromChairman == Request.filter.isAccepted.Value
                                        : true))
                                : true) &&
                            SubscribersNames.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                        .Select(x => x.Type)
                        .GroupBy(x => x)
                        .Select(g => new { Type = g.Key, Count = g.Count() })
                        .ToListAsync();

                    GetAllFromsForInitialArbitrationFullResponse FullResponse = new GetAllFromsForInitialArbitrationFullResponse()
                    {
                        GetAllFromsForInitialArbitrationListVM = Response,
                        NumberOfNotBeenArbitratedForms = FullTotalCount.FirstOrDefault(x => x.Type == ArbitrationType.NotBeenArbitrated) != null
                            ? FullTotalCount.FirstOrDefault(x => x.Type == ArbitrationType.NotBeenArbitrated)!.Count : 0,
                        NumberOfBeingReviewedForms = FullTotalCount.FirstOrDefault(x => x.Type == ArbitrationType.BeingReviewed) != null
                            ? FullTotalCount.FirstOrDefault(x => x.Type == ArbitrationType.BeingReviewed)!.Count : 0,
                        NumberOfDoneArbitratodForms = FullTotalCount.FirstOrDefault(x => x.Type == ArbitrationType.DoneArbitratod) != null
                            ? FullTotalCount.FirstOrDefault(x => x.Type == ArbitrationType.DoneArbitratod)!.Count : 0,
                    };

                    int TotalCount = await _ArbitrationRepository.GetCountAsync(x => UserId == x.ArbitratorId &&
                        (Request.ArbitrationType != null
                            ? x.Type == Request.ArbitrationType
                            : true) &&
                        x.ProvidedForm!.Category!.CycleId == ActiveCycleId &&
                        (Request.filter != null
                            ? ((!string.IsNullOrEmpty(Request.filter.ArbitratorName)
                                ? (Request.lang == "en"
                                    ? x.Arbitrator!.EnglishName.ToLower().StartsWith(Request.filter.ArbitratorName.ToLower())
                                    : x.Arbitrator!.ArabicName.ToLower().StartsWith(Request.filter.ArbitratorName.ToLower()))
                                : true) &&
                                (Request.filter.ArbitrationStartDate != null
                                    ? (x.DateOfArbitration != null
                                        ? (x.DateOfArbitration >= Request.filter.ArbitrationStartDate)
                                        : false)
                                    : true) &&
                                (Request.filter.ArbitrationEndDate != null
                                    ? (x.DateOfArbitration != null
                                        ? (x.DateOfArbitration <= Request.filter.ArbitrationEndDate)
                                        : false)
                                    : true) &&
                                (Request.filter.isAccepted != null
                                    ? x.isAcceptedFromChairman == Request.filter.isAccepted.Value
                                    : true))
                            : true) &&
                        SubscribersNames.Select(y => y.RecordId).Contains(x.ProvidedFormId));

                    Pagination PaginationParameter = new Pagination(Request.page,
                        Request.perPage, TotalCount);

                    return new BaseResponse<GetAllFromsForInitialArbitrationFullResponse>(ResponseMessage, true, 200, FullResponse, PaginationParameter);
                }
            }
            else
            {
                Cycle? CheckIfThereIsActiveCycle = await _CycleRepository
                    .FirstOrDefaultAsync(x => x.Status == Domain.Constants.Common.Status.Active);

                if (CheckIfThereIsActiveCycle is null)
                    return new BaseResponse<GetAllFromsForInitialArbitrationFullResponse>(ResponseMessage, false, 200);

                int ActiveCycleId = CheckIfThereIsActiveCycle.Id;

                Domain.Entities.IdentityModels.User? UserEntity = await _UserRepository
                    .FirstOrDefaultAsync(x => x.Id == UserId);

                if (UserEntity is null)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "User is not found"
                        : "المستخدم غير موجود";

                    return new BaseResponse<GetAllFromsForInitialArbitrationFullResponse>(ResponseMessage, false, 404);
                }

                List<int> CategoriesIds = new List<int>();

                if (Request.asChairmanOfCommittees &&
                    (CheckIfThisUserHasFullAccessOrArbitratorRole != null
                        ? CheckIfThisUserHasFullAccessOrArbitratorRole!.Any(x => x.Role!.EnglishName.ToLower() == "Chairman of Committees".ToLower() &&
                            x.Role!.ArabicName == "رئيس اللجان")
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
                    return new BaseResponse<GetAllFromsForInitialArbitrationFullResponse>(ResponseMessage, true, 200, new GetAllFromsForInitialArbitrationFullResponse());

                List<Arbitration> ArbitrationEntities = await _ArbitrationRepository
                    .Where(x => CategoriesIds.Contains(x.ProvidedForm!.categoryId) &&
                        (Request.ArbitrationType != null
                            ? x.Type == Request.ArbitrationType
                            : true) &&
                        (Request.filter != null
                            ? ((!string.IsNullOrEmpty(Request.filter.ArbitratorName)
                                ? (Request.lang == "en"
                                    ? x.Arbitrator!.EnglishName.ToLower().StartsWith(Request.filter.ArbitratorName.ToLower())
                                    : x.Arbitrator!.ArabicName.ToLower().StartsWith(Request.filter.ArbitratorName.ToLower()))
                                : true) &&
                                (Request.filter.ArbitrationStartDate != null
                                    ? (x.DateOfArbitration != null
                                        ? (x.DateOfArbitration >= Request.filter.ArbitrationStartDate)
                                        : false)
                                    : true) &&
                                (Request.filter.ArbitrationEndDate != null
                                    ? (x.DateOfArbitration != null
                                        ? (x.DateOfArbitration <= Request.filter.ArbitrationEndDate)
                                        : false)
                                    : true) &&
                                (Request.filter.isAccepted != null
                                    ? x.isAcceptedFromChairman == Request.filter.isAccepted.Value
                                    : true))
                            : true))
                    .OrderByDescending(x => x.CreatedAt)
                    .ToListAsync();

                List<DynamicAttributeValue> SubscribersNamesCopy = new List<DynamicAttributeValue>();

                if (Request.filter != null
                    ? !string.IsNullOrEmpty(Request.filter.SubscriberName)
                    : false)
                {
                    SubscribersNamesCopy = await _DynamicAttributeValueRepository
                        .Where(x => ArbitrationEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                            x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                            x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower() &&
                            x.Value.ToLower().StartsWith(Request.filter.SubscriberName.ToLower()))
                        .ToListAsync();

                    if (SubscribersNamesCopy.Any())
                    {
                        if (Request.page != 0 &&
                            Request.perPage != -1)
                        {
                            ArbitrationEntities = ArbitrationEntities
                                .Where(x => SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                                .Skip((Request.page - 1) * Request.perPage)
                                .Take(Request.perPage)
                                .ToList();
                        }
                        else
                        {
                            ArbitrationEntities = ArbitrationEntities
                                .Where(x => SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                                .ToList();
                        }
                    }
                    else
                    {
                        ArbitrationEntities = new List<Arbitration>();
                    }
                }
                else
                {
                    SubscribersNamesCopy = await _DynamicAttributeValueRepository
                        .Where(x => ArbitrationEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                            x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                            x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower())
                        .ToListAsync();
                }

                var SubscribersNames = SubscribersNamesCopy
                    .Select(x => new
                    {
                        x.RecordId,
                        x.Value
                    }).ToList();

                List<InitialArbitration> InitialArbitrationEntities = await _InitialArbitrationRepository
                    .Where(x => ArbitrationEntities.Select(y => y.Id).Contains(x.ArbitrationId))
                    .ToListAsync();

                List<GetAllFromsForInitialArbitrationListVM> Response = ArbitrationEntities
                    .Select(x => new GetAllFromsForInitialArbitrationListVM()
                    {
                        Id = x.Id,
                        FormId = x.ProvidedFormId,
                        ArbitrationType = x.Type,
                        CategoryId = x.ProvidedForm!.categoryId,
                        CategoryName = Request.lang == "en"
                            ? x.ProvidedForm!.Category!.EnglishName
                            : x.ProvidedForm!.Category!.ArabicName,
                        DateOfArbitration = x.DateOfArbitration,
                        Name = SubscribersNames.FirstOrDefault(y => y.RecordId == x.ProvidedFormId)?.Value ?? "",
                        FullArbitrationScore = InitialArbitrationEntities
                            .Where(y => y.ArbitrationId == x.Id)
                            .Sum(y => y.ArbitrationScore),
                        isAcceptedFromChairman = x.isAcceptedFromChairman,
                        ArbitratorName = Request.lang == "en"
                            ? x.Arbitrator!.EnglishName
                            : x.Arbitrator!.ArabicName
                    }).ToList();

                var FullTotalCount = await _ArbitrationRepository
                    .Where(x => CategoriesIds.Contains(x.ProvidedForm!.categoryId) &&
                        (Request.filter != null
                            ? ((!string.IsNullOrEmpty(Request.filter.ArbitratorName)
                                ? (Request.lang == "en"
                                    ? x.Arbitrator!.EnglishName.ToLower().StartsWith(Request.filter.ArbitratorName.ToLower())
                                    : x.Arbitrator!.ArabicName.ToLower().StartsWith(Request.filter.ArbitratorName.ToLower()))
                                : true) &&
                                (Request.filter.ArbitrationStartDate != null
                                    ? (x.DateOfArbitration != null
                                        ? (x.DateOfArbitration >= Request.filter.ArbitrationStartDate)
                                        : false)
                                    : true) &&
                                (Request.filter.ArbitrationEndDate != null
                                    ? (x.DateOfArbitration != null
                                        ? (x.DateOfArbitration <= Request.filter.ArbitrationEndDate)
                                        : false)
                                    : true) &&
                                (Request.filter.isAccepted != null
                                    ? x.isAcceptedFromChairman == Request.filter.isAccepted.Value
                                    : true))
                            : true) &&
                        SubscribersNames.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                    .Select(x => x.Type)
                    .GroupBy(x => x)
                    .Select(g => new { Type = g.Key, Count = g.Count() })
                    .ToListAsync();

                GetAllFromsForInitialArbitrationFullResponse FullResponse = new GetAllFromsForInitialArbitrationFullResponse()
                {
                    GetAllFromsForInitialArbitrationListVM = Response,
                    NumberOfNotBeenArbitratedForms = FullTotalCount.FirstOrDefault(x => x.Type == ArbitrationType.NotBeenArbitrated) != null
                        ? FullTotalCount.FirstOrDefault(x => x.Type == ArbitrationType.NotBeenArbitrated)!.Count : 0,
                    NumberOfBeingReviewedForms = FullTotalCount.FirstOrDefault(x => x.Type == ArbitrationType.BeingReviewed) != null
                        ? FullTotalCount.FirstOrDefault(x => x.Type == ArbitrationType.BeingReviewed)!.Count : 0,
                    NumberOfDoneArbitratodForms = FullTotalCount.FirstOrDefault(x => x.Type == ArbitrationType.DoneArbitratod) != null
                        ? FullTotalCount.FirstOrDefault(x => x.Type == ArbitrationType.DoneArbitratod)!.Count : 0,
                };

                int TotalCount = await _ArbitrationRepository
                    .GetCountAsync(x => CategoriesIds.Contains(x.ProvidedForm!.categoryId) &&
                        (Request.ArbitrationType != null
                            ? x.Type == Request.ArbitrationType
                            : true) &&
                        x.ProvidedForm!.Category!.CycleId == ActiveCycleId &&
                        (Request.filter != null
                            ? ((!string.IsNullOrEmpty(Request.filter.ArbitratorName)
                                ? (Request.lang == "en"
                                    ? x.Arbitrator!.EnglishName.ToLower().StartsWith(Request.filter.ArbitratorName.ToLower())
                                    : x.Arbitrator!.ArabicName.ToLower().StartsWith(Request.filter.ArbitratorName.ToLower()))
                                : true) &&
                                (Request.filter.ArbitrationStartDate != null
                                    ? (x.DateOfArbitration != null
                                        ? (x.DateOfArbitration >= Request.filter.ArbitrationStartDate)
                                        : false)
                                    : true) &&
                                (Request.filter.ArbitrationEndDate != null
                                    ? (x.DateOfArbitration != null
                                        ? (x.DateOfArbitration <= Request.filter.ArbitrationEndDate)
                                        : false)
                                    : true) &&
                                (Request.filter.isAccepted != null
                                    ? x.isAcceptedFromChairman == Request.filter.isAccepted.Value
                                    : true))
                            : true) &&
                        SubscribersNames.Select(y => y.RecordId).Contains(x.ProvidedFormId));

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.perPage, TotalCount);

                return new BaseResponse<GetAllFromsForInitialArbitrationFullResponse>(ResponseMessage, true, 200, FullResponse, PaginationParameter);
            }
        }
    }
}
