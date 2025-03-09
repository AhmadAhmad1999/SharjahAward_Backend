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
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Application.Features.ArbitrationAuditFeatures.Queries.GetAllFormsForArbitrationAudit
{
    public class GetAllFormsForArbitrationAuditHandler
        : IRequestHandler<GetAllFormsForArbitrationAuditQuery, BaseResponse<List<GetAllFormsForArbitrationAuditListVM>>>
    {
        private readonly IAsyncRepository<Arbitrator> _ArbitratorRepository;
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        private readonly IAsyncRepository<InitialArbitration> _InitialArbitrationRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IAsyncRepository<ArbitrationAudit> _ArbitrationAuditRepository;
        private readonly IAsyncRepository<UserRole> _UserRoleRepository;
        private readonly IAsyncRepository<ComitteeArbitrator> _ComitteeArbitratorRepository;
        private readonly IAsyncRepository<Cycle> _CycleRepository;
        private readonly IAsyncRepository<ComitteeOfficer> _ComitteeOfficerRepository;
        private readonly IAsyncRepository<UserCategory> _UserCategoryRepository;
        private readonly IUserRepository _UserRepository;
        private readonly IJwtProvider _JWTProvider;

        public GetAllFormsForArbitrationAuditHandler(IAsyncRepository<Arbitrator> _ArbitratorRepository,
            IAsyncRepository<Arbitration> _ArbitrationRepository,
            IAsyncRepository<InitialArbitration> _InitialArbitrationRepository,
            IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository,
            IAsyncRepository<ArbitrationAudit> _ArbitrationAuditRepository,
            IAsyncRepository<UserRole> _UserRoleRepository,
            IAsyncRepository<ComitteeArbitrator> _ComitteeArbitratorRepository,
            IAsyncRepository<Cycle> _CycleRepository,
            IAsyncRepository<ComitteeOfficer> _ComitteeOfficerRepository,
            IAsyncRepository<UserCategory> _UserCategoryRepository,
            IUserRepository _UserRepository,
            IJwtProvider _JWTProvider)
        {
            this._ArbitratorRepository = _ArbitratorRepository;
            this._ArbitrationRepository = _ArbitrationRepository;
            this._InitialArbitrationRepository = _InitialArbitrationRepository;
            this._DynamicAttributeValueRepository = _DynamicAttributeValueRepository;
            this._ArbitrationAuditRepository = _ArbitrationAuditRepository;
            this._UserRoleRepository = _UserRoleRepository;
            this._ComitteeArbitratorRepository = _ComitteeArbitratorRepository;
            this._CycleRepository = _CycleRepository;
            this._ComitteeOfficerRepository = _ComitteeOfficerRepository;
            this._UserCategoryRepository = _UserCategoryRepository;
            this._UserRepository = _UserRepository;
            this._JWTProvider = _JWTProvider;
        }

        public async Task<BaseResponse<List<GetAllFormsForArbitrationAuditListVM>>> Handle(GetAllFormsForArbitrationAuditQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            int UserId = int.Parse(_JWTProvider.GetUserIdFromToken(Request.Token!));

            List<UserRole> CheckIfThisUserHasFullAccessOrArbitratorRole = await _UserRoleRepository
                .Where(x => x.UserId == UserId)
                .ToListAsync();

            if ((CheckIfThisUserHasFullAccessOrArbitratorRole is not null
                ? CheckIfThisUserHasFullAccessOrArbitratorRole.Any(x => x.Role!.HaveFullAccess)
                : false) && Request.AsFullAccess)
            {
                List<IGrouping<int, Arbitration>> GroupOfArbitrationEntities = new List<IGrouping<int, Arbitration>>();
                List<IGrouping<int, Arbitration>> GroupOfArbitrationEntitiesForAverage = new List<IGrouping<int, Arbitration>>();

                List<Arbitration> ArbitrationEntities = new List<Arbitration>();
                List<DynamicAttributeValue> SubscribersNamesCopy = new List<DynamicAttributeValue>();

                if (Request.ArbitrationType is not null)
                {
                    ArbitrationEntities = await _ArbitrationRepository
                        .Where(x => x.ArbitrationAuditType == Request.ArbitrationType)
                        .ToListAsync();

                    if (!string.IsNullOrEmpty(Request.SubscriberName))
                    {
                        SubscribersNamesCopy = await _DynamicAttributeValueRepository
                            .Where(x => ArbitrationEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                                x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                                x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower() &&
                                x.Value.ToLower().StartsWith(Request.SubscriberName.ToLower()))
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
                                x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower())
                            .ToListAsync();
                    }

                    GroupOfArbitrationEntities = ArbitrationEntities
                        .GroupBy(x => x.ProvidedFormId)
                        .ToList();

                    GroupOfArbitrationEntitiesForAverage = await _ArbitrationRepository
                        .Where(x => x.isAcceptedFromChairman == FormStatus.Accepted)
                        .GroupBy(x => x.ProvidedFormId)
                        .ToListAsync();
                }
                else
                {
                    ArbitrationEntities = await _ArbitrationRepository
                        .Where(x => true)
                        .ToListAsync();

                    if (!string.IsNullOrEmpty(Request.SubscriberName))
                    {
                        SubscribersNamesCopy = await _DynamicAttributeValueRepository
                            .Where(x => ArbitrationEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                                x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                                x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower() &&
                                x.Value.ToLower().StartsWith(Request.SubscriberName.ToLower()))
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
                                x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower())
                            .ToListAsync();
                    }

                    GroupOfArbitrationEntities = ArbitrationEntities
                        .GroupBy(x => x.ProvidedFormId)
                        .ToList();

                    GroupOfArbitrationEntitiesForAverage = await _ArbitrationRepository
                        .Where(x => x.isAcceptedFromChairman == FormStatus.Accepted)
                        .GroupBy(x => x.ProvidedFormId)
                        .ToListAsync();
                }

                var SubscribersNames = SubscribersNamesCopy
                    .Select(x => new
                    {
                        x.RecordId,
                        x.Value
                    }).ToList();

                List<int> ArbitrationIdsForAverage = GroupOfArbitrationEntitiesForAverage
                    .SelectMany(group => group.Select(arbitration => arbitration.Id))
                    .ToList();

                List<InitialArbitration> InitialArbitrationEntitiesForAverage = await _InitialArbitrationRepository
                    .Where(x => ArbitrationIdsForAverage.Contains(x.ArbitrationId))
                    .ToListAsync();

                List<int> ArbitrationIds = GroupOfArbitrationEntities
                    .SelectMany(group => group.Select(arbitration => arbitration.Id))
                    .ToList();

                List<InitialArbitration> InitialArbitrationEntities = await _InitialArbitrationRepository
                    .Where(x => ArbitrationIds.Contains(x.ArbitrationId))
                    .ToListAsync();
                
                List<int> FormsIds = GroupOfArbitrationEntities
                    .SelectMany(group => group.Select(arbitration => arbitration.ProvidedFormId))
                    .Distinct()
                    .ToList();

                List<ArbitrationAudit> ArbitrationAuditEntities = await _ArbitrationAuditRepository
                    .Where(x => FormsIds.Contains(x.ProvidedFormId))
                    .ToListAsync();

                int MarginOfDifferenceBetweenArbitrators = await _ArbitrationRepository
                    .Select(x => x.ProvidedForm!.Category!.MarginOfDifferenceBetweenArbitrators)
                    .FirstOrDefaultAsync();

                List<GetAllFormsForArbitrationAuditListVM> Response = new List<GetAllFormsForArbitrationAuditListVM>();

                foreach (IGrouping<int, Arbitration> GroupOfArbitrationEntity in GroupOfArbitrationEntities)
                {
                    var GroupOfArbitrationEntityForAverage = GroupOfArbitrationEntitiesForAverage
                        .FirstOrDefault(x => x.Key == GroupOfArbitrationEntity.Key);

                    if (GroupOfArbitrationEntityForAverage is null)
                        continue;

                    if (GroupOfArbitrationEntity.All(x => x.Type == ArbitrationType.DoneArbitratod))
                    {
                        if (Request.ItExceededTheMarginOfDifferenceInArbitrationScores != null)
                        {
                            List<Arbitration> DoneArbitratodGroupOfArbitrationEntity = GroupOfArbitrationEntityForAverage
                                .Where(x => x.Type == ArbitrationType.DoneArbitratod)
                                .ToList();

                            bool ItExceededTheMarginOfDifferenceInArbitrationScores = false;

                            foreach (Arbitration ArbitrationEntity in DoneArbitratodGroupOfArbitrationEntity)
                            {
                                foreach (Arbitration ArbitrationEntity2 in DoneArbitratodGroupOfArbitrationEntity)
                                {
                                    if (Math.Abs(ArbitrationEntity.FullScore - ArbitrationEntity2.FullScore) > MarginOfDifferenceBetweenArbitrators)
                                    {
                                        ItExceededTheMarginOfDifferenceInArbitrationScores = true;
                                        break;
                                    }
                                }
                            }

                            if (Request.ItExceededTheMarginOfDifferenceInArbitrationScores.Value)
                            {
                                if (!ItExceededTheMarginOfDifferenceInArbitrationScores)
                                    continue;
                            }
                            else
                            {
                                if (ItExceededTheMarginOfDifferenceInArbitrationScores)
                                    continue;
                            }

                            GetAllFormsForArbitrationAuditListVM GetAllFormsForArbitrationAuditListVM = new GetAllFormsForArbitrationAuditListVM()
                            {
                                FormId = GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedFormId,
                                Name = SubscribersNames.FirstOrDefault(x => x.RecordId == GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedFormId)?.Value ?? "",
                                CategoryId = GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedForm!.categoryId,
                                CategoryName = Request.lang == "en"
                                        ? GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedForm!.Category.EnglishName
                                        : GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedForm!.Category.ArabicName,
                                ItExceededTheMarginOfDifferenceInArbitrationScores = ItExceededTheMarginOfDifferenceInArbitrationScores,
                                FullScore = 0,
                                DoneArbitrationAudit = false,
                                DoneArbitrationUserId = GroupOfArbitrationEntity.FirstOrDefault()!.DoneArbitrationUserId,
                                DoneArbitrationUserName = (GroupOfArbitrationEntity.FirstOrDefault()!.DoneArbitrationUser != null
                                        ? (Request.lang == "en"
                                            ? GroupOfArbitrationEntity.FirstOrDefault()!.DoneArbitrationUser!.EnglishName
                                            : GroupOfArbitrationEntity.FirstOrDefault()!.DoneArbitrationUser!.ArabicName)
                                        : null),
                                isAcceptedFromChairmanFromArbitrationAudit = GroupOfArbitrationEntity.FirstOrDefault()!.isAcceptedFromChairmanFromArbitrationAudit,
                                ReasonForRejectingFromArbitrationAudit = GroupOfArbitrationEntity.FirstOrDefault()!.ReasonForRejectingFromArbitrationAudit,
                            };

                            List<InitialArbitration> InitialArbitrationEntitiesForThisArbitrations = InitialArbitrationEntitiesForAverage
                                .Where(x => GroupOfArbitrationEntityForAverage!.Select(y => new
                                {
                                    y.Id,
                                    y.Type
                                }).Any(y => y.Id == x.ArbitrationId && y.Type == ArbitrationType.DoneArbitratod)).ToList();

                            int NumberOfArbitrationEntitiesForThisAudit = InitialArbitrationEntitiesForThisArbitrations
                                .DistinctBy(x => x.ArbitrationId)
                                .Count();

                            if (NumberOfArbitrationEntitiesForThisAudit != 0)
                                GetAllFormsForArbitrationAuditListVM.Average = InitialArbitrationEntitiesForThisArbitrations
                                    .Sum(x => x.ArbitrationScore) / NumberOfArbitrationEntitiesForThisAudit;

                            List<ArbitrationAudit> ArbitrationAuditEntitiesForThisArbitrations = ArbitrationAuditEntities
                                .Where(x => GroupOfArbitrationEntity.Key == x.ProvidedFormId)
                                .ToList();

                            if (ArbitrationAuditEntitiesForThisArbitrations.Any())
                            {
                                GetAllFormsForArbitrationAuditListVM.FullScore = ArbitrationAuditEntitiesForThisArbitrations
                                    .Sum(x => x.ArbitrationScore);

                                if (DoneArbitratodGroupOfArbitrationEntity.Any()
                                        ? DoneArbitratodGroupOfArbitrationEntity.FirstOrDefault()!.ArbitrationAuditType == ArbitrationType.DoneArbitratod
                                        : false)
                                    GetAllFormsForArbitrationAuditListVM.DoneArbitrationAudit = true;
                            }

                            Response.Add(GetAllFormsForArbitrationAuditListVM);
                        }
                        // Done
                        else
                        {
                            GetAllFormsForArbitrationAuditListVM GetAllFormsForArbitrationAuditListVM = new GetAllFormsForArbitrationAuditListVM()
                            {
                                FormId = GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedFormId,
                                Name = SubscribersNames.FirstOrDefault(x => x.RecordId == GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedFormId) ? .Value ?? "",
                                CategoryId = GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedForm!.categoryId,
                                CategoryName = Request.lang == "en"
                                    ? GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedForm!.Category.EnglishName
                                    : GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedForm!.Category.ArabicName,
                                DoneArbitrationUserId = GroupOfArbitrationEntity.FirstOrDefault()!.DoneArbitrationUserId,
                                DoneArbitrationUserName = (GroupOfArbitrationEntity.FirstOrDefault()!.DoneArbitrationUser != null
                                    ? (Request.lang == "en"
                                        ? GroupOfArbitrationEntity.FirstOrDefault()!.DoneArbitrationUser!.EnglishName
                                        : GroupOfArbitrationEntity.FirstOrDefault()!.DoneArbitrationUser!.ArabicName)
                                    : null),
                                isAcceptedFromChairmanFromArbitrationAudit = GroupOfArbitrationEntity.FirstOrDefault()!.isAcceptedFromChairmanFromArbitrationAudit,
                                ReasonForRejectingFromArbitrationAudit = GroupOfArbitrationEntity.FirstOrDefault()!.ReasonForRejectingFromArbitrationAudit
                            };

                            foreach (Arbitration ArbitrationEntity in GroupOfArbitrationEntity)
                            {
                                foreach (Arbitration ArbitrationEntity2 in GroupOfArbitrationEntity)
                                {
                                    if (Math.Abs(ArbitrationEntity.FullScore - ArbitrationEntity2.FullScore) > MarginOfDifferenceBetweenArbitrators)
                                    {
                                        GetAllFormsForArbitrationAuditListVM.ItExceededTheMarginOfDifferenceInArbitrationScores = true;
                                        break;
                                    }
                                }
                            }

                            List<InitialArbitration> InitialArbitrationEntitiesForThisArbitrations = InitialArbitrationEntities
                                .Where(x => GroupOfArbitrationEntity.Select(y => y.Id).Contains(x.ArbitrationId))
                                .ToList();

                            int NumberOfArbitrationEntitiesForThisAudit = InitialArbitrationEntitiesForThisArbitrations
                                .DistinctBy(x => x.ArbitrationId)
                                .Count();

                            if (NumberOfArbitrationEntitiesForThisAudit != 0)
                                GetAllFormsForArbitrationAuditListVM.Average = InitialArbitrationEntitiesForThisArbitrations
                                    .Sum(x => x.ArbitrationScore) / NumberOfArbitrationEntitiesForThisAudit;

                            List<ArbitrationAudit> ArbitrationAuditEntitiesForThisArbitrations = ArbitrationAuditEntities
                                .Where(x => GroupOfArbitrationEntity.Key == x.ProvidedFormId)
                                .ToList();

                            if (ArbitrationAuditEntitiesForThisArbitrations.Any())
                            {
                                GetAllFormsForArbitrationAuditListVM.FullScore = ArbitrationAuditEntitiesForThisArbitrations
                                    .Sum(x => x.ArbitrationScore);

                                GetAllFormsForArbitrationAuditListVM.DoneArbitrationAudit = true;
                            }


                            Response.Add(GetAllFormsForArbitrationAuditListVM);
                        }
                    }
                }

                int TotalCount = Response.Count();

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.perPage, TotalCount);

                if (Request.page != 0 && Request.perPage != -1)
                {
                    Response = Response.Skip((Request.page - 1) * Request.perPage)
                        .Take(Request.perPage)
                        .ToList();
                }

                return new BaseResponse<List<GetAllFormsForArbitrationAuditListVM>>(ResponseMessage, true, 200, Response, PaginationParameter);
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
                    return new BaseResponse<List<GetAllFormsForArbitrationAuditListVM>>(ResponseMessage, false, 200);

                int ActiveCycleId = CheckIfThereIsActiveCycle.Id;

                Arbitrator? CheckIfUserIsNormalArbitrator = await _ArbitratorRepository
                    .FirstOrDefaultAsync(x => x.Id == UserId);

                if (CheckIfUserIsNormalArbitrator is null)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "Arbitrator is not Found"
                        : "المحكم غير موجود";

                    return new BaseResponse<List<GetAllFormsForArbitrationAuditListVM>>(ResponseMessage, false, 404);
                }

                List<IGrouping<int, Arbitration>> GroupOfArbitrationEntities = new List<IGrouping<int, Arbitration>>();
                List<IGrouping<int, Arbitration>> GroupOfArbitrationEntitiesForAverage = new List<IGrouping<int, Arbitration>>();

                List<Arbitration> ArbitrationEntities = new List<Arbitration>();
                List<DynamicAttributeValue> SubscribersNamesCopy = new List<DynamicAttributeValue>();

                if (CheckIfUserIsNormalArbitrator is not null
                    ? (!CheckIfUserIsNormalArbitrator.isChairman ||
                        (Request.AsChairman != null ? !Request.AsChairman.Value : false))
                    : false)
                {
                    if (Request.ArbitrationType is null)
                    {
                        ArbitrationEntities = await _ArbitrationRepository
                            .Where(x => x.ArbitratorId == UserId &&
                                x.isAcceptedFromChairman == FormStatus.Accepted &&
                                x.ProvidedForm!.Category!.CycleId == ActiveCycleId)
                            .ToListAsync();
                    }
                    else
                    {
                        ArbitrationEntities = await _ArbitrationRepository
                            .Where(x => x.ArbitratorId == UserId &&
                                x.isAcceptedFromChairman == FormStatus.Accepted &&
                                x.ProvidedForm!.Category!.CycleId == ActiveCycleId &&
                                x.ArbitrationAuditType == Request.ArbitrationType)
                            .ToListAsync();
                    }

                    if (!string.IsNullOrEmpty(Request.SubscriberName))
                    {
                        SubscribersNamesCopy = await _DynamicAttributeValueRepository
                            .Where(x => ArbitrationEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                                x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                                x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower() &&
                                x.Value.ToLower().StartsWith(Request.SubscriberName.ToLower()))
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
                                x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower())
                            .ToListAsync();
                    }

                    GroupOfArbitrationEntities = ArbitrationEntities
                        .GroupBy(x => x.ProvidedFormId)
                        .ToList();

                    GroupOfArbitrationEntitiesForAverage = await _ArbitrationRepository
                        .Where(x => x.isAcceptedFromChairman == FormStatus.Accepted &&
                            x.ProvidedForm!.Category!.CycleId == ActiveCycleId)
                        .GroupBy(x => x.ProvidedFormId)
                        .ToListAsync();
                }
                else if (CheckIfUserIsNormalArbitrator is not null
                    ? (CheckIfUserIsNormalArbitrator.isSubcommitteeOfficer ||
                        Request.asSubcommitteeOfficer)
                    : false)
                {
                    List<int> ComitteesIds = await _ComitteeOfficerRepository
                        .Where(x => x.ArbitratorId == CheckIfUserIsNormalArbitrator.Id)
                        .Select(x => x.CommitteeId)
                        .Distinct()
                        .ToListAsync();

                    List<int> ComitteeArbitratorIds = await _ComitteeArbitratorRepository
                        .Where(x => ComitteesIds.Contains(x.CommitteeId))
                        .Select(x => x.ArbitratorId)
                        .Distinct()
                        .ToListAsync();

                    if (Request.ArbitrationType is null)
                    {
                        ArbitrationEntities = await _ArbitrationRepository
                            .Where(x => ComitteeArbitratorIds.Contains(x.ArbitratorId) &&
                                x.isAcceptedFromChairman == FormStatus.Accepted &&
                                // x.ArbitrationAuditType == ArbitrationType.DoneArbitratod &&
                                x.ProvidedForm!.Category!.CycleId == ActiveCycleId)
                            .ToListAsync();
                    }
                    else
                    {
                        ArbitrationEntities = await _ArbitrationRepository
                            .Where(x => ComitteeArbitratorIds.Contains(x.ArbitratorId) &&
                                x.isAcceptedFromChairman == FormStatus.Accepted &&
                                 x.ArbitrationAuditType == Request.ArbitrationType &&
                                x.ProvidedForm!.Category!.CycleId == ActiveCycleId)
                            .ToListAsync();
                    }

                    if (!string.IsNullOrEmpty(Request.SubscriberName))
                    {
                        SubscribersNamesCopy = await _DynamicAttributeValueRepository
                            .Where(x => ArbitrationEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                                x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                                x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower() &&
                                x.Value.ToLower().StartsWith(Request.SubscriberName.ToLower()))
                            .ToListAsync();

                        if (SubscribersNamesCopy.Any())
                        {
                            ArbitrationEntities = ArbitrationEntities
                                .Where(x => SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                                .ToList();
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
                                x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower())
                            .ToListAsync();
                    }

                    GroupOfArbitrationEntities = ArbitrationEntities
                        .GroupBy(x => x.ProvidedFormId)
                        .ToList();

                    GroupOfArbitrationEntitiesForAverage = await _ArbitrationRepository
                        .Where(x => x.isAcceptedFromChairman == FormStatus.Accepted &&
                            // x.ArbitrationAuditType == ArbitrationType.DoneArbitratod &&
                            x.ProvidedForm!.Category!.CycleId == ActiveCycleId)
                        .GroupBy(x => x.ProvidedFormId)
                        .ToListAsync();
                }
                else
                {
                    List<int> ComitteeArbitratorIds = await _ComitteeArbitratorRepository
                        .Where(x => x.Committee!.ChairmanId == UserId)
                        .Select(x => x.ArbitratorId)
                        .Distinct()
                        .ToListAsync();

                    if (Request.ArbitrationType is null)
                    {
                        ArbitrationEntities = await _ArbitrationRepository
                            .Where(x => ComitteeArbitratorIds.Contains(x.ArbitratorId) &&
                                x.isAcceptedFromChairman == FormStatus.Accepted &&
                                // x.ArbitrationAuditType == ArbitrationType.DoneArbitratod &&
                                x.ProvidedForm!.Category!.CycleId == ActiveCycleId)
                            .ToListAsync();
                    }
                    else
                    {
                        ArbitrationEntities = await _ArbitrationRepository
                            .Where(x => ComitteeArbitratorIds.Contains(x.ArbitratorId) &&
                                x.isAcceptedFromChairman == FormStatus.Accepted &&
                                 x.ArbitrationAuditType == Request.ArbitrationType &&
                                x.ProvidedForm!.Category!.CycleId == ActiveCycleId)
                            .ToListAsync();
                    }

                    if (!string.IsNullOrEmpty(Request.SubscriberName))
                    {
                        SubscribersNamesCopy = await _DynamicAttributeValueRepository
                            .Where(x => ArbitrationEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) && 
                                x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                                x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower() &&
                                x.Value.ToLower().StartsWith(Request.SubscriberName.ToLower()))
                            .ToListAsync();

                        if (SubscribersNamesCopy.Any())
                        {
                            ArbitrationEntities = ArbitrationEntities
                                .Where(x => SubscribersNamesCopy.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                                .ToList();
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
                                x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower())
                            .ToListAsync();
                    }

                    GroupOfArbitrationEntities = ArbitrationEntities
                        .GroupBy(x => x.ProvidedFormId)
                        .ToList();

                    GroupOfArbitrationEntitiesForAverage = await _ArbitrationRepository
                        .Where(x => x.isAcceptedFromChairman == FormStatus.Accepted &&
                            // x.ArbitrationAuditType == ArbitrationType.DoneArbitratod &&
                            x.ProvidedForm!.Category!.CycleId == ActiveCycleId)
                        .GroupBy(x => x.ProvidedFormId)
                        .ToListAsync();
                }

                var SubscribersNames = SubscribersNamesCopy
                    .Select(x => new
                    {
                        x.RecordId,
                        x.Value
                    }).ToList();

                List<int> ArbitrationIdsForAverage = GroupOfArbitrationEntitiesForAverage
                    .SelectMany(group => group.Select(arbitration => arbitration.Id))
                    .ToList();

                List<InitialArbitration> InitialArbitrationEntitiesForAverage = await _InitialArbitrationRepository
                    .Where(x => ArbitrationIdsForAverage.Contains(x.ArbitrationId))
                    .ToListAsync();

                List<int> ArbitrationIds = GroupOfArbitrationEntities
                    .SelectMany(group => group.Select(arbitration => arbitration.Id))
                    .ToList();

                List<InitialArbitration> InitialArbitrationEntities = await _InitialArbitrationRepository
                    .Where(x => ArbitrationIds.Contains(x.ArbitrationId))
                    .ToListAsync();

                List<int> FormsIds = GroupOfArbitrationEntities
                    .SelectMany(group => group.Select(arbitration => arbitration.ProvidedFormId))
                    .Distinct()
                    .ToList();

                List<ArbitrationAudit> ArbitrationAuditEntities = await _ArbitrationAuditRepository
                    .Where(x => FormsIds.Contains(x.ProvidedFormId))
                    .ToListAsync();

                int MarginOfDifferenceBetweenArbitrators = await _ArbitrationRepository
                    .Select(x => x.ProvidedForm!.Category!.MarginOfDifferenceBetweenArbitrators)
                    .FirstOrDefaultAsync();

                List<GetAllFormsForArbitrationAuditListVM> Response = new List<GetAllFormsForArbitrationAuditListVM>();

                foreach (IGrouping<int, Arbitration> GroupOfArbitrationEntity in GroupOfArbitrationEntities)
                {
                    var GroupOfArbitrationEntityForAverage = GroupOfArbitrationEntitiesForAverage
                        .FirstOrDefault(x => x.Key == GroupOfArbitrationEntity.Key);

                    if (GroupOfArbitrationEntityForAverage is null)
                        continue;

                    if (GroupOfArbitrationEntity.All(x => x.Type == ArbitrationType.DoneArbitratod &&
                        x.isAcceptedFromChairman == FormStatus.Accepted))
                    {
                        if (Request.ItExceededTheMarginOfDifferenceInArbitrationScores != null)
                        {
                            bool ItExceededTheMarginOfDifferenceInArbitrationScores = false;

                            List<Arbitration> DoneArbitratodGroupOfArbitrationEntity = GroupOfArbitrationEntityForAverage
                                .Where(x => x.Type == ArbitrationType.DoneArbitratod)
                                .ToList();

                            foreach (Arbitration ArbitrationEntity in DoneArbitratodGroupOfArbitrationEntity)
                            {
                                foreach (Arbitration ArbitrationEntity2 in DoneArbitratodGroupOfArbitrationEntity)
                                {
                                    if (Math.Abs(ArbitrationEntity.FullScore - ArbitrationEntity2.FullScore) > MarginOfDifferenceBetweenArbitrators)
                                    {
                                        ItExceededTheMarginOfDifferenceInArbitrationScores = true;
                                        break;
                                    }
                                }
                            }

                            if (Request.ItExceededTheMarginOfDifferenceInArbitrationScores.Value)
                            {
                                if (!ItExceededTheMarginOfDifferenceInArbitrationScores)
                                    continue;
                            }
                            else
                            {
                                if (ItExceededTheMarginOfDifferenceInArbitrationScores)
                                    continue;
                            }

                            GetAllFormsForArbitrationAuditListVM GetAllFormsForArbitrationAuditListVM = new GetAllFormsForArbitrationAuditListVM()
                            {
                                FormId = GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedFormId,
                                Name = SubscribersNames.FirstOrDefault(x => x.RecordId == GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedFormId)?.Value ?? "",
                                CategoryId = GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedForm!.categoryId,
                                CategoryName = Request.lang == "en"
                                        ? GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedForm!.Category.EnglishName
                                        : GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedForm!.Category.ArabicName,
                                ItExceededTheMarginOfDifferenceInArbitrationScores = ItExceededTheMarginOfDifferenceInArbitrationScores,
                                isAcceptedFromChairmanFromArbitrationAudit = GroupOfArbitrationEntity.FirstOrDefault()!.isAcceptedFromChairmanFromArbitrationAudit,
                                ReasonForRejectingFromArbitrationAudit = GroupOfArbitrationEntity.FirstOrDefault()!.ReasonForRejectingFromArbitrationAudit,
                                DoneArbitrationUserId = GroupOfArbitrationEntity.FirstOrDefault()!.DoneArbitrationUserId,
                                DoneArbitrationUserName = (GroupOfArbitrationEntity.FirstOrDefault()!.DoneArbitrationUser != null
                                        ? (Request.lang == "en"
                                            ? GroupOfArbitrationEntity.FirstOrDefault()!.DoneArbitrationUser!.EnglishName
                                            : GroupOfArbitrationEntity.FirstOrDefault()!.DoneArbitrationUser!.ArabicName)
                                        : null)
                            };

                            List<InitialArbitration> InitialArbitrationEntitiesForThisArbitrations = InitialArbitrationEntitiesForAverage
                                .Where(x => GroupOfArbitrationEntityForAverage!.Select(y => new
                                {
                                    y.Id,
                                    y.Type
                                }).Any(y => y.Id == x.ArbitrationId && y.Type == ArbitrationType.DoneArbitratod)).ToList();

                            int NumberOfArbitrationEntitiesForThisAudit = InitialArbitrationEntitiesForThisArbitrations
                                .DistinctBy(x => x.ArbitrationId)
                                .Count();

                            if (NumberOfArbitrationEntitiesForThisAudit != 0)
                                GetAllFormsForArbitrationAuditListVM.Average = InitialArbitrationEntitiesForThisArbitrations
                                    .Sum(x => x.ArbitrationScore) / NumberOfArbitrationEntitiesForThisAudit;

                            List<ArbitrationAudit> ArbitrationAuditEntitiesForThisArbitrations = ArbitrationAuditEntities
                                .Where(x => GroupOfArbitrationEntity.Key == x.ProvidedFormId)
                                .ToList();

                            if (ArbitrationAuditEntitiesForThisArbitrations.Any())
                            {
                                GetAllFormsForArbitrationAuditListVM.FullScore = ArbitrationAuditEntitiesForThisArbitrations
                                    .Sum(x => x.ArbitrationScore);

                                if (DoneArbitratodGroupOfArbitrationEntity.Any()
                                    ? DoneArbitratodGroupOfArbitrationEntity.FirstOrDefault()!.ArbitrationAuditType == ArbitrationType.DoneArbitratod
                                    : false)
                                    GetAllFormsForArbitrationAuditListVM.DoneArbitrationAudit = true;
                            }

                            Response.Add(GetAllFormsForArbitrationAuditListVM);
                        }
                        else
                        {
                            GetAllFormsForArbitrationAuditListVM GetAllFormsForArbitrationAuditListVM = new GetAllFormsForArbitrationAuditListVM()
                            {
                                FormId = GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedFormId,
                                Name = SubscribersNames.FirstOrDefault(x => x.RecordId == GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedFormId) ? .Value ?? "",
                                CategoryId = GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedForm!.categoryId,
                                CategoryName = Request.lang == "en"
                                    ? GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedForm!.Category.EnglishName
                                    : GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedForm!.Category.ArabicName,
                                isAcceptedFromChairmanFromArbitrationAudit = GroupOfArbitrationEntity.FirstOrDefault()!.isAcceptedFromChairmanFromArbitrationAudit,
                                ReasonForRejectingFromArbitrationAudit = GroupOfArbitrationEntity.FirstOrDefault()!.ReasonForRejectingFromArbitrationAudit,
                                DoneArbitrationUserId = GroupOfArbitrationEntity.FirstOrDefault()!.DoneArbitrationUserId,
                                DoneArbitrationUserName = (GroupOfArbitrationEntity.FirstOrDefault()!.DoneArbitrationUser != null
                                    ? (Request.lang == "en"
                                        ? GroupOfArbitrationEntity.FirstOrDefault()!.DoneArbitrationUser!.EnglishName
                                        : GroupOfArbitrationEntity.FirstOrDefault()!.DoneArbitrationUser!.ArabicName)
                                    : null)
                            };

                            if (GroupOfArbitrationEntityForAverage is null)
                                continue;

                            List<Arbitration> DoneArbitratodGroupOfArbitrationEntity = GroupOfArbitrationEntityForAverage
                                .Where(x => x.Type == ArbitrationType.DoneArbitratod)
                                .ToList();

                            foreach (Arbitration ArbitrationEntity in DoneArbitratodGroupOfArbitrationEntity)
                            {
                                foreach (Arbitration ArbitrationEntity2 in DoneArbitratodGroupOfArbitrationEntity)
                                {
                                    if (Math.Abs(ArbitrationEntity.FullScore - ArbitrationEntity2.FullScore) > MarginOfDifferenceBetweenArbitrators)
                                    {
                                        GetAllFormsForArbitrationAuditListVM.ItExceededTheMarginOfDifferenceInArbitrationScores = true;
                                        break;
                                    }
                                }
                            }

                            List<InitialArbitration> InitialArbitrationEntitiesForThisArbitrations = InitialArbitrationEntitiesForAverage
                                .Where(x => GroupOfArbitrationEntityForAverage!.Select(y => new
                                {
                                    y.Id,
                                    y.Type
                                }).Any(y => y.Id == x.ArbitrationId && y.Type == ArbitrationType.DoneArbitratod)).ToList();

                            int NumberOfArbitrationEntitiesForThisAudit = InitialArbitrationEntitiesForThisArbitrations
                                .DistinctBy(x => x.ArbitrationId)
                                .Count();

                            if (NumberOfArbitrationEntitiesForThisAudit != 0)
                                GetAllFormsForArbitrationAuditListVM.Average = InitialArbitrationEntitiesForThisArbitrations
                                    .Sum(x => x.ArbitrationScore) / NumberOfArbitrationEntitiesForThisAudit;

                            List<ArbitrationAudit> ArbitrationAuditEntitiesForThisArbitrations = ArbitrationAuditEntities
                                .Where(x => GroupOfArbitrationEntity.Key == x.ProvidedFormId)
                                .ToList();

                            if (ArbitrationAuditEntitiesForThisArbitrations.Any())
                            {
                                GetAllFormsForArbitrationAuditListVM.FullScore = ArbitrationAuditEntitiesForThisArbitrations
                                    .Sum(x => x.ArbitrationScore);

                                if (DoneArbitratodGroupOfArbitrationEntity.Any()
                                    ? DoneArbitratodGroupOfArbitrationEntity.FirstOrDefault()!.ArbitrationAuditType == ArbitrationType.DoneArbitratod
                                    : false)
                                    GetAllFormsForArbitrationAuditListVM.DoneArbitrationAudit = true;
                            }

                            Response.Add(GetAllFormsForArbitrationAuditListVM);
                        }
                    }
                }

                int TotalCount = Response.Count();

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.perPage, TotalCount);

                if (Request.page != 0 && Request.perPage != -1)
                {
                    Response = Response.Skip((Request.page - 1) * Request.perPage)
                        .Take(Request.perPage)
                        .ToList();
                }

                return new BaseResponse<List<GetAllFormsForArbitrationAuditListVM>>(ResponseMessage, true, 200, Response, PaginationParameter);
            }
            else
            {
                Cycle? CheckIfThereIsActiveCycle = await _CycleRepository
                    .FirstOrDefaultAsync(x => x.Status == Domain.Constants.Common.Status.Active);

                if (CheckIfThereIsActiveCycle is null)
                    return new BaseResponse<List<GetAllFormsForArbitrationAuditListVM>>(ResponseMessage, false, 200);

                int ActiveCycleId = CheckIfThereIsActiveCycle.Id;

                Domain.Entities.IdentityModels.User? UserEntity = await _UserRepository
                    .FirstOrDefaultAsync(x => x.Id == UserId);

                if (UserEntity is null)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "User is not found"
                        : "المستخدم غير موجود";

                    return new BaseResponse<List<GetAllFormsForArbitrationAuditListVM>>(ResponseMessage, false, 404);
                }

                List<IGrouping<int, Arbitration>> GroupOfArbitrationEntities = new List<IGrouping<int, Arbitration>>();
                List<IGrouping<int, Arbitration>> GroupOfArbitrationEntitiesForAverage = new List<IGrouping<int, Arbitration>>();

                List<Arbitration> ArbitrationEntities = new List<Arbitration>();
                List<DynamicAttributeValue> SubscribersNamesCopy = new List<DynamicAttributeValue>();

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
                    return new BaseResponse<List<GetAllFormsForArbitrationAuditListVM>>(ResponseMessage, true, 200, new List<GetAllFormsForArbitrationAuditListVM>());

                if (Request.ArbitrationType is null)
                {
                    ArbitrationEntities = await _ArbitrationRepository
                        .Where(x => CategoriesIds.Contains(x.ProvidedForm!.categoryId) &&
                            x.isAcceptedFromChairman == FormStatus.Accepted &&
                            x.ProvidedForm!.Category!.CycleId == ActiveCycleId)
                        .ToListAsync();
                }
                else
                {
                    ArbitrationEntities = await _ArbitrationRepository
                        .Where(x => CategoriesIds.Contains(x.ProvidedForm!.categoryId) &&
                            x.isAcceptedFromChairman == FormStatus.Accepted &&
                            x.ProvidedForm!.Category!.CycleId == ActiveCycleId &&
                            x.ArbitrationAuditType == Request.ArbitrationType)
                        .ToListAsync();
                }

                if (!string.IsNullOrEmpty(Request.SubscriberName))
                {
                    SubscribersNamesCopy = await _DynamicAttributeValueRepository
                        .Where(x => ArbitrationEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId) &&
                            x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                            x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower() &&
                            x.Value.ToLower().StartsWith(Request.SubscriberName.ToLower()))
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
                            x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower())
                        .ToListAsync();
                }

                GroupOfArbitrationEntities = ArbitrationEntities
                    .GroupBy(x => x.ProvidedFormId)
                    .ToList();

                GroupOfArbitrationEntitiesForAverage = await _ArbitrationRepository
                    .Where(x => x.isAcceptedFromChairman == FormStatus.Accepted &&
                        x.ProvidedForm!.Category!.CycleId == ActiveCycleId)
                    .GroupBy(x => x.ProvidedFormId)
                    .ToListAsync();

                var SubscribersNames = SubscribersNamesCopy
                    .Select(x => new
                    {
                        x.RecordId,
                        x.Value
                    }).ToList();

                List<int> ArbitrationIdsForAverage = GroupOfArbitrationEntitiesForAverage
                    .SelectMany(group => group.Select(arbitration => arbitration.Id))
                    .ToList();

                List<InitialArbitration> InitialArbitrationEntitiesForAverage = await _InitialArbitrationRepository
                    .Where(x => ArbitrationIdsForAverage.Contains(x.ArbitrationId))
                    .ToListAsync();

                List<int> ArbitrationIds = GroupOfArbitrationEntities
                    .SelectMany(group => group.Select(arbitration => arbitration.Id))
                    .ToList();

                List<InitialArbitration> InitialArbitrationEntities = await _InitialArbitrationRepository
                    .Where(x => ArbitrationIds.Contains(x.ArbitrationId))
                    .ToListAsync();

                List<int> FormsIds = GroupOfArbitrationEntities
                    .SelectMany(group => group.Select(arbitration => arbitration.ProvidedFormId))
                    .Distinct()
                    .ToList();

                List<ArbitrationAudit> ArbitrationAuditEntities = await _ArbitrationAuditRepository
                    .Where(x => FormsIds.Contains(x.ProvidedFormId))
                    .ToListAsync();

                int MarginOfDifferenceBetweenArbitrators = await _ArbitrationRepository
                    .Select(x => x.ProvidedForm!.Category!.MarginOfDifferenceBetweenArbitrators)
                    .FirstOrDefaultAsync();

                List<GetAllFormsForArbitrationAuditListVM> Response = new List<GetAllFormsForArbitrationAuditListVM>();

                foreach (IGrouping<int, Arbitration> GroupOfArbitrationEntity in GroupOfArbitrationEntities)
                {
                    var GroupOfArbitrationEntityForAverage = GroupOfArbitrationEntitiesForAverage
                        .FirstOrDefault(x => x.Key == GroupOfArbitrationEntity.Key);

                    if (GroupOfArbitrationEntityForAverage is null)
                        continue;

                    if (GroupOfArbitrationEntity.All(x => x.Type == ArbitrationType.DoneArbitratod &&
                        x.isAcceptedFromChairman == FormStatus.Accepted))
                    {
                        if (Request.ItExceededTheMarginOfDifferenceInArbitrationScores != null)
                        {
                            bool ItExceededTheMarginOfDifferenceInArbitrationScores = false;

                            List<Arbitration> DoneArbitratodGroupOfArbitrationEntity = GroupOfArbitrationEntityForAverage
                                .Where(x => x.Type == ArbitrationType.DoneArbitratod)
                                .ToList();

                            foreach (Arbitration ArbitrationEntity in DoneArbitratodGroupOfArbitrationEntity)
                            {
                                foreach (Arbitration ArbitrationEntity2 in DoneArbitratodGroupOfArbitrationEntity)
                                {
                                    if (Math.Abs(ArbitrationEntity.FullScore - ArbitrationEntity2.FullScore) > MarginOfDifferenceBetweenArbitrators)
                                    {
                                        ItExceededTheMarginOfDifferenceInArbitrationScores = true;
                                        break;
                                    }
                                }
                            }

                            if (Request.ItExceededTheMarginOfDifferenceInArbitrationScores.Value)
                            {
                                if (!ItExceededTheMarginOfDifferenceInArbitrationScores)
                                    continue;
                            }
                            else
                            {
                                if (ItExceededTheMarginOfDifferenceInArbitrationScores)
                                    continue;
                            }

                            GetAllFormsForArbitrationAuditListVM GetAllFormsForArbitrationAuditListVM = new GetAllFormsForArbitrationAuditListVM()
                            {
                                FormId = GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedFormId,
                                Name = SubscribersNames.FirstOrDefault(x => x.RecordId == GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedFormId)?.Value ?? "",
                                CategoryId = GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedForm!.categoryId,
                                CategoryName = Request.lang == "en"
                                        ? GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedForm!.Category.EnglishName
                                        : GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedForm!.Category.ArabicName,
                                ItExceededTheMarginOfDifferenceInArbitrationScores = ItExceededTheMarginOfDifferenceInArbitrationScores,
                                isAcceptedFromChairmanFromArbitrationAudit = GroupOfArbitrationEntity.FirstOrDefault()!.isAcceptedFromChairmanFromArbitrationAudit,
                                ReasonForRejectingFromArbitrationAudit = GroupOfArbitrationEntity.FirstOrDefault()!.ReasonForRejectingFromArbitrationAudit,
                                DoneArbitrationUserId = GroupOfArbitrationEntity.FirstOrDefault()!.DoneArbitrationUserId,
                                DoneArbitrationUserName = (GroupOfArbitrationEntity.FirstOrDefault()!.DoneArbitrationUser != null
                                        ? (Request.lang == "en"
                                            ? GroupOfArbitrationEntity.FirstOrDefault()!.DoneArbitrationUser!.EnglishName
                                            : GroupOfArbitrationEntity.FirstOrDefault()!.DoneArbitrationUser!.ArabicName)
                                        : null)
                            };

                            List<InitialArbitration> InitialArbitrationEntitiesForThisArbitrations = InitialArbitrationEntitiesForAverage
                                .Where(x => GroupOfArbitrationEntityForAverage!.Select(y => new
                                {
                                    y.Id,
                                    y.Type
                                }).Any(y => y.Id == x.ArbitrationId && y.Type == ArbitrationType.DoneArbitratod)).ToList();

                            int NumberOfArbitrationEntitiesForThisAudit = InitialArbitrationEntitiesForThisArbitrations
                                .DistinctBy(x => x.ArbitrationId)
                                .Count();

                            if (NumberOfArbitrationEntitiesForThisAudit != 0)
                                GetAllFormsForArbitrationAuditListVM.Average = InitialArbitrationEntitiesForThisArbitrations
                                    .Sum(x => x.ArbitrationScore) / NumberOfArbitrationEntitiesForThisAudit;

                            List<ArbitrationAudit> ArbitrationAuditEntitiesForThisArbitrations = ArbitrationAuditEntities
                                .Where(x => GroupOfArbitrationEntity.Key == x.ProvidedFormId)
                                .ToList();

                            if (ArbitrationAuditEntitiesForThisArbitrations.Any())
                            {
                                GetAllFormsForArbitrationAuditListVM.FullScore = ArbitrationAuditEntitiesForThisArbitrations
                                    .Sum(x => x.ArbitrationScore);

                                if (DoneArbitratodGroupOfArbitrationEntity.Any()
                                    ? DoneArbitratodGroupOfArbitrationEntity.FirstOrDefault()!.ArbitrationAuditType == ArbitrationType.DoneArbitratod
                                    : false)
                                    GetAllFormsForArbitrationAuditListVM.DoneArbitrationAudit = true;
                            }

                            Response.Add(GetAllFormsForArbitrationAuditListVM);
                        }
                        else
                        {
                            GetAllFormsForArbitrationAuditListVM GetAllFormsForArbitrationAuditListVM = new GetAllFormsForArbitrationAuditListVM()
                            {
                                FormId = GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedFormId,
                                Name = SubscribersNames.FirstOrDefault(x => x.RecordId == GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedFormId)?.Value ?? "",
                                CategoryId = GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedForm!.categoryId,
                                CategoryName = Request.lang == "en"
                                    ? GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedForm!.Category.EnglishName
                                    : GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedForm!.Category.ArabicName,
                                isAcceptedFromChairmanFromArbitrationAudit = GroupOfArbitrationEntity.FirstOrDefault()!.isAcceptedFromChairmanFromArbitrationAudit,
                                ReasonForRejectingFromArbitrationAudit = GroupOfArbitrationEntity.FirstOrDefault()!.ReasonForRejectingFromArbitrationAudit,
                                DoneArbitrationUserId = GroupOfArbitrationEntity.FirstOrDefault()!.DoneArbitrationUserId,
                                DoneArbitrationUserName = (GroupOfArbitrationEntity.FirstOrDefault()!.DoneArbitrationUser != null
                                    ? (Request.lang == "en"
                                        ? GroupOfArbitrationEntity.FirstOrDefault()!.DoneArbitrationUser!.EnglishName
                                        : GroupOfArbitrationEntity.FirstOrDefault()!.DoneArbitrationUser!.ArabicName)
                                    : null)
                            };

                            if (GroupOfArbitrationEntityForAverage is null)
                                continue;

                            List<Arbitration> DoneArbitratodGroupOfArbitrationEntity = GroupOfArbitrationEntityForAverage
                                .Where(x => x.Type == ArbitrationType.DoneArbitratod)
                                .ToList();

                            foreach (Arbitration ArbitrationEntity in DoneArbitratodGroupOfArbitrationEntity)
                            {
                                foreach (Arbitration ArbitrationEntity2 in DoneArbitratodGroupOfArbitrationEntity)
                                {
                                    if (Math.Abs(ArbitrationEntity.FullScore - ArbitrationEntity2.FullScore) > MarginOfDifferenceBetweenArbitrators)
                                    {
                                        GetAllFormsForArbitrationAuditListVM.ItExceededTheMarginOfDifferenceInArbitrationScores = true;
                                        break;
                                    }
                                }
                            }

                            List<InitialArbitration> InitialArbitrationEntitiesForThisArbitrations = InitialArbitrationEntitiesForAverage
                                .Where(x => GroupOfArbitrationEntityForAverage!.Select(y => new
                                {
                                    y.Id,
                                    y.Type
                                }).Any(y => y.Id == x.ArbitrationId && y.Type == ArbitrationType.DoneArbitratod)).ToList();

                            int NumberOfArbitrationEntitiesForThisAudit = InitialArbitrationEntitiesForThisArbitrations
                                .DistinctBy(x => x.ArbitrationId)
                                .Count();

                            if (NumberOfArbitrationEntitiesForThisAudit != 0)
                                GetAllFormsForArbitrationAuditListVM.Average = InitialArbitrationEntitiesForThisArbitrations
                                    .Sum(x => x.ArbitrationScore) / NumberOfArbitrationEntitiesForThisAudit;

                            List<ArbitrationAudit> ArbitrationAuditEntitiesForThisArbitrations = ArbitrationAuditEntities
                                .Where(x => GroupOfArbitrationEntity.Key == x.ProvidedFormId)
                                .ToList();

                            if (ArbitrationAuditEntitiesForThisArbitrations.Any())
                            {
                                GetAllFormsForArbitrationAuditListVM.FullScore = ArbitrationAuditEntitiesForThisArbitrations
                                    .Sum(x => x.ArbitrationScore);

                                if (DoneArbitratodGroupOfArbitrationEntity.Any()
                                    ? DoneArbitratodGroupOfArbitrationEntity.FirstOrDefault()!.ArbitrationAuditType == ArbitrationType.DoneArbitratod
                                    : false)
                                    GetAllFormsForArbitrationAuditListVM.DoneArbitrationAudit = true;
                            }

                            Response.Add(GetAllFormsForArbitrationAuditListVM);
                        }
                    }
                }

                int TotalCount = Response.Count();

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.perPage, TotalCount);

                if (Request.page != 0 && Request.perPage != -1)
                {
                    Response = Response.Skip((Request.page - 1) * Request.perPage)
                        .Take(Request.perPage)
                        .ToList();
                }

                return new BaseResponse<List<GetAllFormsForArbitrationAuditListVM>>(ResponseMessage, true, 200, Response, PaginationParameter);
            }
        }
    }
}
