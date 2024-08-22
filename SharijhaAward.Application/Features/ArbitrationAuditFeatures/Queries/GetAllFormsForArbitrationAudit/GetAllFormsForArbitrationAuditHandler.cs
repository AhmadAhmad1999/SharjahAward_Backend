using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.ComitteeArbitratorModel;
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
        private readonly IJwtProvider _JWTProvider;

        public GetAllFormsForArbitrationAuditHandler(IAsyncRepository<Arbitrator> ArbitratorRepository,
            IAsyncRepository<Arbitration> ArbitrationRepository,
            IAsyncRepository<InitialArbitration> InitialArbitrationRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository,
            IAsyncRepository<ArbitrationAudit> ArbitrationAuditRepository,
            IAsyncRepository<UserRole> UserRoleRepository,
            IAsyncRepository<ComitteeArbitrator> ComitteeArbitratorRepository,
            IJwtProvider JWTProvider)
        {
            _ArbitratorRepository = ArbitratorRepository;
            _ArbitrationRepository = ArbitrationRepository;
            _InitialArbitrationRepository = InitialArbitrationRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
            _ArbitrationAuditRepository = ArbitrationAuditRepository;
            _UserRoleRepository = UserRoleRepository;
            _ComitteeArbitratorRepository = ComitteeArbitratorRepository;
            _JWTProvider = JWTProvider;
        }

        public async Task<BaseResponse<List<GetAllFormsForArbitrationAuditListVM>>> Handle(GetAllFormsForArbitrationAuditQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            int UserId = int.Parse(_JWTProvider.GetUserIdFromToken(Request.Token!));

            UserRole? CheckIfThisUserHasFullAccessOrArbitratorRole = await _UserRoleRepository
                .Include(x => x.Role!)
                .FirstOrDefaultAsync(x => x.UserId == UserId &&
                    x.Role!.EnglishName.ToLower() == "arbitrator");

            if (CheckIfThisUserHasFullAccessOrArbitratorRole is null)
            {
                List<IGrouping<int, Arbitration>> GroupOfArbitrationEntities = new List<IGrouping<int, Arbitration>>();

                if (Request.ArbitrationType is not null)
                {
                    GroupOfArbitrationEntities = await _ArbitrationRepository
                        .Where(x => x.Type == Request.ArbitrationType)
                        .Include(x => x.DoneArbitrationUser!)
                        .Include(x => x.ProvidedForm!)
                        .Include(x => x.ProvidedForm!.Category!)
                        .GroupBy(x => x.ProvidedFormId)
                        .ToListAsync();
                }
                else
                {
                    GroupOfArbitrationEntities = await _ArbitrationRepository
                        .Include(x => x.DoneArbitrationUser!)
                        .Include(x => x.ProvidedForm!)
                        .Include(x => x.ProvidedForm!.Category!)
                        .GroupBy(x => x.ProvidedFormId)
                        .ToListAsync();
                }

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
                    .Include(x => x.ProvidedForm!)
                    .Include(x => x.ProvidedForm!.Category!.Cycle!)
                    .Select(x => x.ProvidedForm!.Category!.Cycle!.MarginOfDifferenceBetweenArbitrators)
                    .FirstOrDefaultAsync();

                var Names = await _DynamicAttributeValueRepository
                    .Include(x => x.DynamicAttribute!)
                    .Where(x => GroupOfArbitrationEntities.Select(y => y.Key).Any(y => y == x.RecordId) &&
                        x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower())
                    .Select(x => new
                    {
                        x.RecordId,
                        x.Value
                    }).ToListAsync();

                List<GetAllFormsForArbitrationAuditListVM> Response = new List<GetAllFormsForArbitrationAuditListVM>();

                foreach (IGrouping<int, Arbitration> GroupOfArbitrationEntity in GroupOfArbitrationEntities)
                {
                    if (GroupOfArbitrationEntity.All(x => x.Type == ArbitrationType.DoneArbitratod))
                    {
                        if (Request.ItExceededTheMarginOfDifferenceInArbitrationScores != null)
                        {
                            if (Request.ItExceededTheMarginOfDifferenceInArbitrationScores.Value)
                            {
                                foreach (Arbitration ArbitrationEntity in GroupOfArbitrationEntity)
                                {
                                    bool BreakOuterLoop = false;

                                    foreach (Arbitration ArbitrationEntity2 in GroupOfArbitrationEntity)
                                    {
                                        if (Math.Abs(ArbitrationEntity.FullScore - ArbitrationEntity2.FullScore) > MarginOfDifferenceBetweenArbitrators)
                                        {
                                            GetAllFormsForArbitrationAuditListVM GetAllFormsForArbitrationAuditListVM = new GetAllFormsForArbitrationAuditListVM()
                                            {
                                                FormId = ArbitrationEntity.ProvidedFormId,
                                                Name = Names.FirstOrDefault(x => x.RecordId == ArbitrationEntity.ProvidedFormId)!.Value,
                                                CategoryId = ArbitrationEntity.ProvidedForm!.categoryId,
                                                CategoryName = Request.lang == "en"
                                                    ? ArbitrationEntity.ProvidedForm!.Category.EnglishName
                                                    : ArbitrationEntity.ProvidedForm!.Category.ArabicName,
                                                ItExceededTheMarginOfDifferenceInArbitrationScores = true,
                                                FullScore = 0,
                                                DoneArbitrationAudit = false,
                                                DoneArbitrationUserId = ArbitrationEntity.DoneArbitrationUserId,
                                                DoneArbitrationUserName = (GroupOfArbitrationEntity.FirstOrDefault()!.DoneArbitrationUser != null
                                                    ? (Request.lang == "en"
                                                        ? ArbitrationEntity.DoneArbitrationUser!.EnglishName
                                                        : ArbitrationEntity.DoneArbitrationUser!.ArabicName)
                                                    : null),
                                                isAcceptedFromChairmanFromArbitrationAudit = ArbitrationEntity.isAcceptedFromChairmanFromArbitrationAudit,
                                                ReasonForRejectingFromArbitrationAudit = ArbitrationEntity.ReasonForRejectingFromArbitrationAudit,
                                            };

                                            Response.Add(GetAllFormsForArbitrationAuditListVM);

                                            BreakOuterLoop = true;
                                            break;
                                        }
                                    }

                                    if (BreakOuterLoop)
                                        break;
                                }
                            }
                            else
                            {
                                bool BreakOuterLoop = false;

                                GetAllFormsForArbitrationAuditListVM GetAllFormsForArbitrationAuditListVM = new GetAllFormsForArbitrationAuditListVM()
                                {
                                    FormId = GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedFormId,
                                    Name = Names.FirstOrDefault(x => x.RecordId == GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedFormId)!.Value,
                                    CategoryId = GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedForm!.categoryId,
                                    CategoryName = Request.lang == "en"
                                        ? GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedForm!.Category.EnglishName
                                        : GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedForm!.Category.ArabicName,
                                    ItExceededTheMarginOfDifferenceInArbitrationScores = false,
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
                                            BreakOuterLoop = true;
                                            break;
                                        }
                                    }
                                }

                                if (!BreakOuterLoop)
                                {
                                    List<InitialArbitration> InitialArbitrationEntitiesForThisArbitrations = InitialArbitrationEntities
                                        .Where(x => GroupOfArbitrationEntity.Select(y => y.Id).Contains(x.ArbitrationId))
                                        .ToList();

                                    GetAllFormsForArbitrationAuditListVM.Average = InitialArbitrationEntitiesForThisArbitrations
                                        .Sum(x => x.ArbitrationScore) / ArbitrationIds.Count();

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
                        else
                        {
                            bool BreakOuterLoop = false;

                            GetAllFormsForArbitrationAuditListVM GetAllFormsForArbitrationAuditListVM = new GetAllFormsForArbitrationAuditListVM()
                            {
                                FormId = GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedFormId,
                                Name = Names.FirstOrDefault(x => x.RecordId == GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedFormId)!.Value,
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

                                        Response.Add(GetAllFormsForArbitrationAuditListVM);

                                        BreakOuterLoop = true;
                                        break;
                                    }
                                }

                                if (BreakOuterLoop)
                                    break;
                            }

                            if (!BreakOuterLoop)
                            {
                                List<InitialArbitration> InitialArbitrationEntitiesForThisArbitrations = InitialArbitrationEntities
                                    .Where(x => GroupOfArbitrationEntity.Select(y => y.Id).Contains(x.ArbitrationId))
                                    .ToList();

                                GetAllFormsForArbitrationAuditListVM.Average = InitialArbitrationEntitiesForThisArbitrations
                                    .Sum(x => x.ArbitrationScore) / ArbitrationIds.Count();

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

                if (CheckIfUserIsNormalArbitrator is not null
                    ? (!CheckIfUserIsNormalArbitrator.isChairman ||
                        (Request.AsChairman != null ? !Request.AsChairman.Value : false))
                    : false)
                {
                    GroupOfArbitrationEntities = await _ArbitrationRepository
                        .Where(x => x.ArbitratorId == UserId &&
                            x.isAccepted == FormStatus.Accepted && x.isAcceptedFromChairman == FormStatus.Accepted)
                        .Include(x => x.DoneArbitrationUser!)
                        .Include(x => x.ProvidedForm!)
                        .Include(x => x.ProvidedForm!.Category!)
                        .GroupBy(x => x.ProvidedFormId)
                        .ToListAsync();
                }
                else
                {
                    List<int> ComitteeArbitratorIds = await _ComitteeArbitratorRepository
                        .Include(x => x.Committee!)
                        .Where(x => x.Committee!.ChairmanId == UserId)
                        .Select(x => x.ArbitratorId)
                        .Distinct()
                        .ToListAsync();

                    GroupOfArbitrationEntities = await _ArbitrationRepository
                        .Where(x => ComitteeArbitratorIds.Contains(x.ArbitratorId) &&
                            x.isAccepted == FormStatus.Accepted && x.isAcceptedFromChairman == FormStatus.Accepted &&
                            x.ArbitrationAuditType == ArbitrationType.DoneArbitratod)
                        .Include(x => x.DoneArbitrationUser!)
                        .Include(x => x.ProvidedForm!)
                        .Include(x => x.ProvidedForm!.Category!)
                        .GroupBy(x => x.ProvidedFormId)
                        .ToListAsync();
                }

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
                    .Include(x => x.ProvidedForm!)
                    .Include(x => x.ProvidedForm!.Category!.Cycle!)
                    .Select(x => x.ProvidedForm!.Category!.Cycle!.MarginOfDifferenceBetweenArbitrators)
                    .FirstOrDefaultAsync();

                var Names = await _DynamicAttributeValueRepository
                    .Include(x => x.DynamicAttribute!)
                    .Where(x => GroupOfArbitrationEntities.Select(y => y.Key).Any(y => y == x.RecordId) &&
                        x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower())
                    .Select(x => new
                    {
                        x.RecordId,
                        x.Value
                    }).ToListAsync();

                List<GetAllFormsForArbitrationAuditListVM> Response = new List<GetAllFormsForArbitrationAuditListVM>();

                foreach (IGrouping<int, Arbitration> GroupOfArbitrationEntity in GroupOfArbitrationEntities)
                {
                    if (GroupOfArbitrationEntity.All(x => x.Type == ArbitrationType.DoneArbitratod &&
                        x.isAccepted == FormStatus.Accepted && x.isAcceptedFromChairman == FormStatus.Accepted))
                    {
                        if (Request.ItExceededTheMarginOfDifferenceInArbitrationScores != null)
                        {
                            if (Request.ItExceededTheMarginOfDifferenceInArbitrationScores.Value)
                            {
                                List<Arbitration> DoneArbitratodGroupOfArbitrationEntity = GroupOfArbitrationEntity
                                    .ToList();

                                foreach (Arbitration ArbitrationEntity in DoneArbitratodGroupOfArbitrationEntity)
                                {
                                    bool BreakOuterLoop = false;

                                    foreach (Arbitration ArbitrationEntity2 in DoneArbitratodGroupOfArbitrationEntity)
                                    {
                                        if (Math.Abs(ArbitrationEntity.FullScore - ArbitrationEntity2.FullScore) > MarginOfDifferenceBetweenArbitrators)
                                        {
                                            GetAllFormsForArbitrationAuditListVM GetAllFormsForArbitrationAuditListVM = new GetAllFormsForArbitrationAuditListVM()
                                            {
                                                FormId = ArbitrationEntity.ProvidedFormId,
                                                Name = Names.FirstOrDefault(x => x.RecordId == ArbitrationEntity.ProvidedFormId)!.Value,
                                                CategoryId = ArbitrationEntity.ProvidedForm!.categoryId,
                                                CategoryName = Request.lang == "en"
                                                    ? ArbitrationEntity.ProvidedForm!.Category.EnglishName
                                                    : ArbitrationEntity.ProvidedForm!.Category.ArabicName,
                                                ItExceededTheMarginOfDifferenceInArbitrationScores = true,
                                                FullScore = 0,
                                                DoneArbitrationAudit = false,
                                                isAcceptedFromChairmanFromArbitrationAudit = ArbitrationEntity.isAcceptedFromChairmanFromArbitrationAudit,
                                                ReasonForRejectingFromArbitrationAudit = ArbitrationEntity.ReasonForRejectingFromArbitrationAudit,
                                                DoneArbitrationUserId = ArbitrationEntity.DoneArbitrationUserId,
                                                DoneArbitrationUserName = (ArbitrationEntity.DoneArbitrationUser != null
                                                    ? (Request.lang == "en"
                                                        ? ArbitrationEntity.DoneArbitrationUser!.EnglishName
                                                        : ArbitrationEntity.DoneArbitrationUser!.ArabicName)
                                                    : null)
                                            };

                                            List<ArbitrationAudit> ArbitrationAuditEntitiesForThisArbitrations = ArbitrationAuditEntities
                                                .Where(x => GroupOfArbitrationEntity.Key == x.ProvidedFormId)
                                                .ToList();

                                            if (ArbitrationAuditEntitiesForThisArbitrations.Any())
                                            {
                                                GetAllFormsForArbitrationAuditListVM.FullScore = ArbitrationAuditEntitiesForThisArbitrations
                                                    .Sum(x => x.ArbitrationScore);

                                                if (ArbitrationEntity.ArbitrationAuditType == ArbitrationType.DoneArbitratod)
                                                    GetAllFormsForArbitrationAuditListVM.DoneArbitrationAudit = true;
                                            }

                                            Response.Add(GetAllFormsForArbitrationAuditListVM);

                                            BreakOuterLoop = true;
                                            break;
                                        }
                                    }

                                    if (BreakOuterLoop)
                                        break;
                                }
                            }
                            else
                            {
                                bool BreakOuterLoop = false;

                                GetAllFormsForArbitrationAuditListVM GetAllFormsForArbitrationAuditListVM = new GetAllFormsForArbitrationAuditListVM()
                                {
                                    FormId = GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedFormId,
                                    Name = Names.FirstOrDefault(x => x.RecordId == GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedFormId)!.Value,
                                    CategoryId = GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedForm!.categoryId,
                                    CategoryName = Request.lang == "en"
                                        ? GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedForm!.Category.EnglishName
                                        : GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedForm!.Category.ArabicName,
                                    ItExceededTheMarginOfDifferenceInArbitrationScores = false,
                                    isAcceptedFromChairmanFromArbitrationAudit = GroupOfArbitrationEntity.FirstOrDefault()!.isAcceptedFromChairmanFromArbitrationAudit,
                                    ReasonForRejectingFromArbitrationAudit = GroupOfArbitrationEntity.FirstOrDefault()!.ReasonForRejectingFromArbitrationAudit,
                                    DoneArbitrationUserId = GroupOfArbitrationEntity.FirstOrDefault()!.DoneArbitrationUserId,
                                    DoneArbitrationUserName = (GroupOfArbitrationEntity.FirstOrDefault()!.DoneArbitrationUser != null
                                        ? (Request.lang == "en"
                                            ? GroupOfArbitrationEntity.FirstOrDefault()!.DoneArbitrationUser!.EnglishName
                                            : GroupOfArbitrationEntity.FirstOrDefault()!.DoneArbitrationUser!.ArabicName)
                                        : null)
                                };

                                List<Arbitration> DoneArbitratodGroupOfArbitrationEntity = GroupOfArbitrationEntity
                                    .Where(x => x.Type == ArbitrationType.DoneArbitratod)
                                    .ToList();

                                foreach (Arbitration ArbitrationEntity in DoneArbitratodGroupOfArbitrationEntity)
                                {
                                    foreach (Arbitration ArbitrationEntity2 in DoneArbitratodGroupOfArbitrationEntity)
                                    {
                                        if (Math.Abs(ArbitrationEntity.FullScore - ArbitrationEntity2.FullScore) > MarginOfDifferenceBetweenArbitrators)
                                        {
                                            BreakOuterLoop = true;
                                            break;
                                        }
                                    }
                                }

                                if (!BreakOuterLoop)
                                {
                                    List<InitialArbitration> InitialArbitrationEntitiesForThisArbitrations = InitialArbitrationEntities
                                        .Where(x => GroupOfArbitrationEntity.Select(y => new
                                        {
                                            y.Id,
                                            y.Type
                                        }).Any(y => y.Id == x.ArbitrationId && y.Type == ArbitrationType.DoneArbitratod)).ToList();

                                    GetAllFormsForArbitrationAuditListVM.Average = InitialArbitrationEntitiesForThisArbitrations
                                        .Sum(x => x.ArbitrationScore) / ArbitrationIds.Count();

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
                        else
                        {
                            bool BreakOuterLoop = false;

                            GetAllFormsForArbitrationAuditListVM GetAllFormsForArbitrationAuditListVM = new GetAllFormsForArbitrationAuditListVM()
                            {
                                FormId = GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedFormId,
                                Name = Names.FirstOrDefault(x => x.RecordId == GroupOfArbitrationEntity.FirstOrDefault()!.ProvidedFormId)!.Value,
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

                            List<Arbitration> DoneArbitratodGroupOfArbitrationEntity = GroupOfArbitrationEntity
                                .Where(x => x.Type == ArbitrationType.DoneArbitratod)
                                .ToList();

                            foreach (Arbitration ArbitrationEntity in DoneArbitratodGroupOfArbitrationEntity)
                            {
                                foreach (Arbitration ArbitrationEntity2 in DoneArbitratodGroupOfArbitrationEntity)
                                {
                                    if (Math.Abs(ArbitrationEntity.FullScore - ArbitrationEntity2.FullScore) > MarginOfDifferenceBetweenArbitrators)
                                    {
                                        GetAllFormsForArbitrationAuditListVM.ItExceededTheMarginOfDifferenceInArbitrationScores = true;

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

                                        BreakOuterLoop = true;
                                        break;
                                    }
                                }

                                if (BreakOuterLoop)
                                    break;
                            }

                            if (!BreakOuterLoop)
                            {
                                List<InitialArbitration> InitialArbitrationEntitiesForThisArbitrations = InitialArbitrationEntities
                                    .Where(x => GroupOfArbitrationEntity.Select(y => new
                                    {
                                        y.Id,
                                        y.Type
                                    }).Any(y => y.Id == x.ArbitrationId && y.Type == ArbitrationType.DoneArbitratod)).ToList();

                                GetAllFormsForArbitrationAuditListVM.Average = InitialArbitrationEntitiesForThisArbitrations
                                    .Sum(x => x.ArbitrationScore) / ArbitrationIds.Count();

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
