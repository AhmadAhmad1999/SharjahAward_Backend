using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.ComitteeArbitratorModel;
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
        private readonly IJwtProvider _JwtProvider;

        public GetAllFormsForFinalArbitrationHandler(IAsyncRepository<FinalArbitration> FinalArbitrationRepository,
            IAsyncRepository<FinalArbitrationScore> FinalArbitrationScoreRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository,
            IAsyncRepository<Arbitrator> ArbitratorRepository,
            IAsyncRepository<UserRole> UserRoleRepository,
            IAsyncRepository<Arbitration> ArbitrationRepository,
            IAsyncRepository<ComitteeArbitrator> ComitteeArbitratorRepository,
            IJwtProvider JwtProvider)
        {
            _FinalArbitrationRepository = FinalArbitrationRepository;
            _FinalArbitrationScoreRepository = FinalArbitrationScoreRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
            _ArbitratorRepository = ArbitratorRepository;
            _UserRoleRepository = UserRoleRepository;
            _ArbitrationRepository = ArbitrationRepository;
            _ComitteeArbitratorRepository = ComitteeArbitratorRepository;
            _JwtProvider = JwtProvider;
        }
        public async Task<BaseResponse<GetAllFormsForFinalArbitrationMainListVM>>
            Handle(GetAllFormsForFinalArbitrationQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            int UserId = int.Parse(_JwtProvider.GetUserIdFromToken(Request.Token!));

            UserRole? CheckIfThisUserHasFullAccessOrArbitratorRole = await _UserRoleRepository
                .Include(x => x.Role!)
                .FirstOrDefaultAsync(x => x.UserId == UserId &&
                    x.Role!.EnglishName.ToLower() == "arbitrator");

            if (CheckIfThisUserHasFullAccessOrArbitratorRole is null)
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
                        .Include(x => x.DoneArbitrationUser!)
                        .Include(x => x.ProvidedForm!)
                        .Include(x => x.ProvidedForm!.Category!)
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
                        .Include(x => x.DoneArbitrationUser!)
                        .Include(x => x.ProvidedForm!)
                        .Include(x => x.ProvidedForm!.Category!)
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
                        FinalScore = x.FinalScore,
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
                Arbitrator? ArbitratorEntity = await _ArbitratorRepository
                    .FirstOrDefaultAsync(x => x.Id == UserId);

                if (ArbitratorEntity is null)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "Arbitrator is not Found"
                        : "المحكم غير موجود";

                    return new BaseResponse<GetAllFormsForFinalArbitrationMainListVM>(ResponseMessage, false, 404);
                }

                if (!ArbitratorEntity.isChairman ||
                    (Request.AsChairman != null ? !Request.AsChairman.Value : false))
                {
                    List<int> ArbitratorFormsIds = await _ArbitrationRepository
                        .Where(x => x.ArbitratorId == ArbitratorEntity.Id)
                        .Select(x => x.ProvidedFormId)
                        .ToListAsync();

                    List<FinalArbitration> FinalArbitrationEntities = new List<FinalArbitration>();

                    int TotalCount = 0;

                    if (Request.ArbitrationType is not null)
                    {
                        FinalArbitrationEntities = await _FinalArbitrationRepository
                            .Where(x => x.Type == Request.ArbitrationType &&
                                ArbitratorFormsIds.Contains(x.ProvidedFormId))
                            .OrderByDescending(x => x.CreatedAt)
                            .Skip((Request.page - 1) * Request.perPage)
                            .Take(Request.perPage)
                            .Include(x => x.DoneArbitrationUser!)
                            .Include(x => x.ProvidedForm!)
                            .Include(x => x.ProvidedForm!.Category!)
                            .ToListAsync();

                        TotalCount = await _FinalArbitrationRepository
                            .GetCountAsync(x => x.Type == Request.ArbitrationType &&
                                ArbitratorFormsIds.Contains(x.ProvidedFormId));
                    }
                    else
                    {
                        FinalArbitrationEntities = await _FinalArbitrationRepository
                            .Where(x => ArbitratorFormsIds.Contains(x.ProvidedFormId))
                            .OrderByDescending(x => x.CreatedAt)
                            .Skip((Request.page - 1) * Request.perPage)
                            .Take(Request.perPage)
                            .Include(x => x.DoneArbitrationUser!)
                            .Include(x => x.ProvidedForm!)
                            .Include(x => x.ProvidedForm!.Category!)
                            .ToListAsync();

                        TotalCount = await _FinalArbitrationRepository
                            .GetCountAsync(x => ArbitratorFormsIds.Contains(x.ProvidedFormId));
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
                            FinalScore = x.FinalScore,
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
                        .Where(x => true)
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
                else
                {
                    List<int> ArbitratorIdsInCommitee = await _ComitteeArbitratorRepository
                        .Include(x => x.Committee!)
                        .Where(x => x.Committee!.ChairmanId == UserId)
                        .Select(x => x.ArbitratorId)
                        .Distinct()
                        .ToListAsync();

                    List<int> ArbitratorFormsIds = await _ArbitrationRepository
                        .Where(x => ArbitratorIdsInCommitee.Contains(x.ArbitratorId))
                        .Select(x => x.ProvidedFormId)
                        .Distinct()
                        .ToListAsync();

                    List<FinalArbitration> FinalArbitrationEntities = new List<FinalArbitration>();

                    int TotalCount = 0;

                    if (Request.ArbitrationType is not null)
                    {
                        FinalArbitrationEntities = await _FinalArbitrationRepository
                            .Where(x => x.Type == Request.ArbitrationType &&
                                ArbitratorFormsIds.Contains(x.ProvidedFormId))
                            .OrderByDescending(x => x.CreatedAt)
                            .Skip((Request.page - 1) * Request.perPage)
                            .Take(Request.perPage)
                            .Include(x => x.DoneArbitrationUser!)
                            .Include(x => x.ProvidedForm!)
                            .Include(x => x.ProvidedForm!.Category!)
                            .ToListAsync();

                        TotalCount = await _FinalArbitrationRepository
                            .GetCountAsync(x => x.Type == Request.ArbitrationType &&
                                ArbitratorFormsIds.Contains(x.ProvidedFormId));
                    }
                    else
                    {
                        FinalArbitrationEntities = await _FinalArbitrationRepository
                            .Where(x => ArbitratorFormsIds.Contains(x.ProvidedFormId))
                            .OrderByDescending(x => x.CreatedAt)
                            .Skip((Request.page - 1) * Request.perPage)
                            .Take(Request.perPage)
                            .Include(x => x.DoneArbitrationUser!)
                            .Include(x => x.ProvidedForm!)
                            .Include(x => x.ProvidedForm!.Category!)
                            .ToListAsync();

                        TotalCount = await _FinalArbitrationRepository
                            .GetCountAsync(x => ArbitratorFormsIds.Contains(x.ProvidedFormId));
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
                            FinalScore = x.FinalScore,
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
                        .Where(x => true)
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
}
