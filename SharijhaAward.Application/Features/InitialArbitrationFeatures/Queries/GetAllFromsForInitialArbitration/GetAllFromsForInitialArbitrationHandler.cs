using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.ArbitrationAuditFeatures.Queries.GetAllFormsForArbitrationAudit;
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
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IAsyncRepository<InitialArbitration> _InitialArbitrationRepository;
        private readonly IAsyncRepository<Cycle> _CycleRepository;
        private readonly IJwtProvider _JWTProvider;

        public GetAllFromsForInitialArbitrationHandler(IAsyncRepository<Arbitration> ArbitrationRepository,
            IAsyncRepository<Arbitrator> ArbitratorRepository,
            IAsyncRepository<UserRole> UserRoleRepository,
            IAsyncRepository<ComitteeArbitrator> ComitteeArbitratorRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository,
            IAsyncRepository<InitialArbitration> InitialArbitrationRepository,
            IAsyncRepository<Cycle> CycleRepository,
            IJwtProvider JWTProvider)
        {
            _ArbitrationRepository = ArbitrationRepository;
            _ArbitratorRepository = ArbitratorRepository;
            _UserRoleRepository = UserRoleRepository;
            _ComitteeArbitratorRepository = ComitteeArbitratorRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
            _InitialArbitrationRepository = InitialArbitrationRepository;
            _CycleRepository = CycleRepository;
            _JWTProvider = JWTProvider;
        }
        public async Task<BaseResponse<GetAllFromsForInitialArbitrationFullResponse>> 
            Handle(GetAllFromsForInitialArbitrationQuery Request, CancellationToken cancellationToken)
        {
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
                        : true))
                    .OrderByDescending(x => x.CreatedAt)
                    .Skip((Request.page - 1) * Request.perPage)
                    .Take(Request.perPage)
                    .ToListAsync();

                var SubscribersNames = await _DynamicAttributeValueRepository
                    .Where(x => ArbitrationEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                        x.DynamicAttribute!.DynamicAttributeSection!.AttributeTableName!.Name.ToLower() == "ProvidedForm".ToLower() &&
                        x.DynamicAttribute.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower())
                    .Select(x => new
                    {
                        x.RecordId,
                        x.Value
                    }).ToListAsync();

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
                        Name = SubscribersNames.FirstOrDefault(y => y.RecordId == x.ProvidedFormId)!.Value,
                        FullArbitrationScore = InitialArbitrationEntities
                            .Where(y => y.ArbitrationId == x.Id)
                            .Sum(y => y.ArbitrationScore),
                        isAcceptedFromChairman = x.isAcceptedFromChairman,
                        ArbitratorName = Request.lang == "en"
                            ? x.Arbitrator!.EnglishName
                            : x.Arbitrator!.ArabicName
                    }).ToList();

                var FullTotalCount = await _ArbitrationRepository
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
                ? CheckIfThisUserHasFullAccessOrArbitratorRole.Any(x => x.Role!.EnglishName.ToLower() == "arbitrator" &&
                    x.Role!.ArabicName == "محكم")
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
                                x.ProvidedForm!.Category!.CycleId == ActiveCycleId)
                            .OrderByDescending(x => x.CreatedAt)
                            .Skip((Request.page - 1) * Request.perPage)
                            .Take(Request.perPage)
                            .ToListAsync();
                    }
                    else
                    {
                        ArbitrationEntities = await _ArbitrationRepository
                            .Where(x => ArbitratorsIdsInCommittee.Contains(x.ArbitratorId) &&
                                x.ProvidedForm!.Category!.CycleId == ActiveCycleId)
                            .OrderByDescending(x => x.CreatedAt)
                            .Skip((Request.page - 1) * Request.perPage)
                            .Take(Request.perPage)
                            .ToListAsync();
                    }

                    var SubscribersNames = await _DynamicAttributeValueRepository
                        .Where(x => ArbitrationEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                            x.DynamicAttribute!.DynamicAttributeSection!.AttributeTableName!.Name.ToLower() == "ProvidedForm".ToLower() &&
                            x.DynamicAttribute.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower())
                        .Select(x => new
                        {
                            x.RecordId,
                            x.Value
                        }).ToListAsync();

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
                            Name = SubscribersNames.FirstOrDefault(y => y.RecordId == x.ProvidedFormId)!.Value,
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
                            x.ProvidedForm!.Category!.CycleId == ActiveCycleId)
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
                        x.ProvidedForm!.Category!.CycleId == ActiveCycleId);

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
                                : true))
                        .OrderByDescending(x => x.CreatedAt)
                        .Skip((Request.page - 1) * Request.perPage)
                        .Take(Request.perPage)
                        .ToListAsync();

                    var SubscribersNames = await _DynamicAttributeValueRepository
                        .Where(x => ArbitrationEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                            x.DynamicAttribute!.DynamicAttributeSection!.AttributeTableName!.Name.ToLower() == "ProvidedForm".ToLower() &&
                            x.DynamicAttribute.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower())
                        .Select(x => new
                        {
                            x.RecordId,
                            x.Value
                        }).ToListAsync();

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
                            Name = SubscribersNames.FirstOrDefault(y => y.RecordId == x.ProvidedFormId)!.Value,
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
                            x.ProvidedForm!.Category!.CycleId == ActiveCycleId)
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
                        x.ProvidedForm!.Category!.CycleId == ActiveCycleId);

                    Pagination PaginationParameter = new Pagination(Request.page,
                        Request.perPage, TotalCount);

                    return new BaseResponse<GetAllFromsForInitialArbitrationFullResponse>(ResponseMessage, true, 200, FullResponse, PaginationParameter);
                }
            }
            else
            {
                return new BaseResponse<GetAllFromsForInitialArbitrationFullResponse>(ResponseMessage, true, 200);
            }
        }
    }
}
