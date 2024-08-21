using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.ArbitrationResultModel;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.FinalArbitrationModel;

namespace SharijhaAward.Application.Features.WinnersFeatures.Queries.GetWinnersByLevel
{
    public class GetWinnersByLevelHandler 
        : IRequestHandler<GetWinnersByLevelQuery, BaseResponse<GetWinnersByLevelMainResponse>>
    {
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        private readonly IAsyncRepository<FinalArbitration> _FinalArbitrationRepository;
        private readonly IAsyncRepository<ArbitrationResult> _ArbitrationResultRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IAsyncRepository<Category> _CategoryRepository;
        private readonly IAsyncRepository<ArbitrationAudit> _ArbitrationAuditRepository;

        public GetWinnersByLevelHandler(IAsyncRepository<Arbitration> ArbitrationRepository,
            IAsyncRepository<FinalArbitration> FinalArbitrationRepository,
            IAsyncRepository<ArbitrationResult> ArbitrationResultRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository,
            IAsyncRepository<Category> CategoryRepository,
            IAsyncRepository<ArbitrationAudit> ArbitrationAuditRepository)
        {
            _ArbitrationRepository = ArbitrationRepository;
            _FinalArbitrationRepository = FinalArbitrationRepository;
            _ArbitrationResultRepository = ArbitrationResultRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
            _CategoryRepository = CategoryRepository;
            _ArbitrationAuditRepository = ArbitrationAuditRepository;
        }

        public async Task<BaseResponse<GetWinnersByLevelMainResponse>> 
            Handle(GetWinnersByLevelQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Category? CategoryEntity = await _CategoryRepository
                .FirstOrDefaultAsync(x => x.Id == Request.CategoryId);

            if (CategoryEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Category is not found"
                    : "ألفئة غير موجود";

                return new BaseResponse<GetWinnersByLevelMainResponse>(ResponseMessage, false, 404);
            }

            if (Request.MaxLevelOfWinners == 0 && CategoryEntity.ExpectedNumberOfWinners != null)
                Request.MaxLevelOfWinners = CategoryEntity.ExpectedNumberOfWinners.Value;

            List<IGrouping<float, ArbitrationResult>> ArbitrationResultEntities = _ArbitrationResultRepository
                .Include(x => x.ProvidedForm!)
                .Where(x => x.ProvidedForm!.categoryId == Request.CategoryId &&
                    x.EligibleToWin)
                .OrderByDescending(x => x.FinalArbitration!.FinalScore)
                .Include(x => x.FinalArbitration!)
                .Include(x => x.ProvidedForm!.Category!)
                .Include(x => x.ProvidedForm!.CategoryEducationalClass!)
                .Include(x => x.ProvidedForm!.CategoryEducationalClass!.EducationalClass!)
                .Include(x => x.ProvidedForm!.CategoryEducationalEntity!)
                .Include(x => x.ProvidedForm!.CategoryEducationalEntity!.EducationalEntity!)
                .Include(x => x.ProvidedForm!.User!)
                .AsEnumerable() 
                .GroupBy(x => x.FinalArbitration!.FinalScore)
                .ToList();
            
            var DynamicAttributeValueEntities = _DynamicAttributeValueRepository
                .Include(x => x.DynamicAttribute!)
                .AsEnumerable()
                .Where(x => ArbitrationResultEntities.SelectMany(y => y.Select(z => z.ProvidedFormId)).Any(y => y == x.RecordId) &&
                    x.DynamicAttribute!.EnglishTitle == "Full name (identical to Emirates ID)")
                .Select(x => new
                {
                    FormId = x.RecordId,
                    SubscriberName = x.Value
                }).ToList();

            List<Arbitration> ArbitrationEntities = _ArbitrationRepository
                .AsEnumerable()
                .Where(x => ArbitrationResultEntities
                    .SelectMany(y => y.Select(z => z.ProvidedFormId))
                    .Contains(x.ProvidedFormId))
                .ToList();

            List<ArbitrationAudit> ArbitrationAuditEntities = _ArbitrationAuditRepository
                .AsEnumerable()
                .Where(x => ArbitrationResultEntities
                    .SelectMany(y => y.Select(z => z.ProvidedFormId))
                    .Contains(x.ProvidedFormId))
                .ToList();

            List<IGrouping<float, ArbitrationResult>> AlreadySelectedToWinList = ArbitrationResultEntities
                .Where(x => x.Any(y => y.SelectedToWin))
                .ToList();

            List<GetWinnersByLevelListVM> SelectedWinners = new List<GetWinnersByLevelListVM>();

            foreach (List<ArbitrationResult> SelectedWinner in AlreadySelectedToWinList.Select(x => x.ToList()))
            {
                SelectedWinners.AddRange(SelectedWinner
                    .Select(x => new GetWinnersByLevelListVM()
                    {
                        FormId = x.ProvidedFormId,
                        FinalArbitrationScore = x.FinalArbitration!.FinalScore,
                        SubscriberName = DynamicAttributeValueEntities
                            .FirstOrDefault(y => y.FormId == x.ProvidedFormId)
                            ?.SubscriberName ?? string.Empty,
                        CategoryId = x.ProvidedForm!.categoryId,
                        CategoryName = Request.lang == "en"
                            ? x.ProvidedForm!.Category!.EnglishName
                            : x.ProvidedForm!.Category!.ArabicName,
                        InitialArbitrationScore = (ArbitrationEntities.Any() && ArbitrationEntities.Count(y => y.ProvidedFormId == x.ProvidedFormId) != 0)
                            ? ArbitrationEntities
                                .Where(y => y.ProvidedFormId == x.ProvidedFormId)
                                .Select(y => y.FullScore)
                                .Sum() / ArbitrationEntities.Count(y => y.ProvidedFormId == x.ProvidedFormId)
                            : 0,
                        ArbitrationAuditScore = (ArbitrationAuditEntities.Any() && ArbitrationAuditEntities.Count(y => y.ProvidedFormId == x.ProvidedFormId) != 0)
                            ? ArbitrationAuditEntities
                                .Where(y => y.ProvidedFormId == x.ProvidedFormId)
                                .Select(y => y.ArbitrationScore)
                                .Sum() / ArbitrationAuditEntities.Count(y => y.ProvidedFormId == x.ProvidedFormId)
                            : 0,
                        CycleNumber = x.ProvidedForm!.CycleNumber,
                        CycleYear = x.ProvidedForm!.CycleYear,
                        EducationalClassName = Request.lang == "en"
                            ? x.ProvidedForm!.CategoryEducationalClass?.EducationalClass!.EnglishName ?? null
                            : x.ProvidedForm!.CategoryEducationalClass?.EducationalClass!.ArabicName ?? null,
                        EducationalEntityName = Request.lang == "en"
                            ? x.ProvidedForm!.CategoryEducationalEntity?.EducationalEntity!.EnglishName ?? null
                            : x.ProvidedForm!.CategoryEducationalEntity?.EducationalEntity!.ArabicName ?? null,
                        ProfilePhoto = x.ProvidedForm!.User.ImageURL,
                        Gender = x.ProvidedForm!.User.Gender,
                        WinningLevel = x.WinningLevel,
                        NotifiedAsWinner = x.NotifiedAsWinner
                    }).ToList());
            }

            List<IGrouping<float, ArbitrationResult>> RequestedWinnersList = ArbitrationResultEntities
                .Where(x => !x.Any(y => y.SelectedToWin))
                .Take(Request.MaxLevelOfWinners)
                .ToList();

            List<GetWinnersByLevelListVM> RequestedWinners = new List<GetWinnersByLevelListVM>();

            foreach (List<ArbitrationResult> RequestedWinner in RequestedWinnersList.Select(x => x.ToList()))
            {
                RequestedWinners.AddRange(RequestedWinner
                    .Select(x => new GetWinnersByLevelListVM()
                    {
                        FormId = x.ProvidedFormId,
                        FinalArbitrationScore = x.FinalArbitration!.FinalScore,
                        SubscriberName = DynamicAttributeValueEntities
                            .FirstOrDefault(y => y.FormId == x.ProvidedFormId)
                            ? .SubscriberName ?? string.Empty,
                        CategoryId = x.ProvidedForm!.categoryId,
                        CategoryName = Request.lang == "en"
                            ? x.ProvidedForm!.Category!.EnglishName
                            : x.ProvidedForm!.Category!.ArabicName,
                        InitialArbitrationScore = (ArbitrationEntities.Any() && ArbitrationEntities.Count(y => y.ProvidedFormId == x.ProvidedFormId) != 0)
                            ? ArbitrationEntities
                                .Where(y => y.ProvidedFormId == x.ProvidedFormId)
                                .Select(y => y.FullScore)
                                .Sum() / ArbitrationEntities.Count(y => y.ProvidedFormId == x.ProvidedFormId)
                            : 0,
                        ArbitrationAuditScore = (ArbitrationAuditEntities.Any() && ArbitrationAuditEntities.Count(y => y.ProvidedFormId == x.ProvidedFormId) != 0)
                            ? ArbitrationAuditEntities
                                .Where(y => y.ProvidedFormId == x.ProvidedFormId)
                                .Select(y => y.ArbitrationScore)
                                .Sum() / ArbitrationAuditEntities.Count(y => y.ProvidedFormId == x.ProvidedFormId)
                            : 0,
                        CycleNumber = x.ProvidedForm!.CycleNumber,
                        CycleYear = x.ProvidedForm!.CycleYear,
                        EducationalClassName = Request.lang == "en"
                            ? x.ProvidedForm!.CategoryEducationalClass?.EducationalClass!.EnglishName ?? null
                            : x.ProvidedForm!.CategoryEducationalClass?.EducationalClass!.ArabicName ?? null,
                        EducationalEntityName = Request.lang == "en"
                            ? x.ProvidedForm!.CategoryEducationalEntity?.EducationalEntity!.EnglishName ?? null
                            : x.ProvidedForm!.CategoryEducationalEntity?.EducationalEntity!.ArabicName ?? null,
                        ProfilePhoto = x.ProvidedForm!.User.ImageURL,
                        Gender = x.ProvidedForm!.User.Gender,
                        WinningLevel = x.WinningLevel,
                        NotifiedAsWinner = x.NotifiedAsWinner
                    }).ToList());
            }

            int TotalCount = await _ArbitrationResultRepository
                .GetCountAsync(x => !RequestedWinners.Select(y => y.FormId).Contains(x.ProvidedFormId));

            List<ArbitrationResult> RemainingWinnersQuery = await _ArbitrationResultRepository
                .Where(x => !RequestedWinners.Select(y => y.FormId).Contains(x.ProvidedFormId) &&
                    !SelectedWinners.Select(y => y.FormId).Contains(x.ProvidedFormId))
                .Include(x => x.FinalArbitration!)
                .Include(x => x.ProvidedForm!)
                .Include(x => x.ProvidedForm!.User!)
                .Include(x => x.ProvidedForm!.Category!)
                .Include(x => x.ProvidedForm!.CategoryEducationalClass!)
                .Include(x => x.ProvidedForm!.CategoryEducationalClass!.EducationalClass!)
                .Include(x => x.ProvidedForm!.CategoryEducationalEntity!)
                .Include(x => x.ProvidedForm!.CategoryEducationalEntity!.EducationalEntity!)
                .ToListAsync();

            List<ArbitrationResult> FilteredWinners = RemainingWinnersQuery
                .Where(x => ArbitrationResultEntities.SelectMany(y => y.Select(z => z.Id)).Contains(x.Id))
                .ToList();

            List<GetWinnersByLevelListVM> RemainingWinners = FilteredWinners
                .Select(x => new GetWinnersByLevelListVM()
                {
                    FormId = x.ProvidedFormId,
                    FinalArbitrationScore = x.FinalArbitration!.FinalScore,
                    SubscriberName = DynamicAttributeValueEntities
                        .FirstOrDefault(y => y.FormId == x.ProvidedFormId)?.SubscriberName ?? string.Empty,
                    CategoryId = x.ProvidedForm!.categoryId,
                    CategoryName = Request.lang == "en"
                        ? x.ProvidedForm!.Category!.EnglishName
                        : x.ProvidedForm!.Category!.ArabicName,
                    InitialArbitrationScore = (ArbitrationEntities.Any() && ArbitrationEntities.Count(y => y.ProvidedFormId == x.ProvidedFormId) != 0)
                        ? (ArbitrationEntities
                            .Where(y => y.ProvidedFormId == x.ProvidedFormId)
                            .Select(y => y.FullScore)
                            .Sum() / ArbitrationEntities.Count(y => y.ProvidedFormId == x.ProvidedFormId))
                        : 0,
                    ArbitrationAuditScore = (ArbitrationAuditEntities.Any() && ArbitrationAuditEntities.Count(y => y.ProvidedFormId == x.ProvidedFormId) != 0)
                        ? (ArbitrationAuditEntities
                            .Where(y => y.ProvidedFormId == x.ProvidedFormId)
                            .Select(y => y.ArbitrationScore)
                            .Sum() / ArbitrationAuditEntities.Count(y => y.ProvidedFormId == x.ProvidedFormId))
                        : 0,
                    CycleNumber = x.ProvidedForm!.CycleNumber,
                    CycleYear = x.ProvidedForm!.CycleYear,
                    EducationalClassName = x.ProvidedForm!.CategoryEducationalClass != null
                        ? (Request.lang == "en"
                            ? x.ProvidedForm!.CategoryEducationalClass!.EducationalClass!.EnglishName ?? null
                            : x.ProvidedForm!.CategoryEducationalClass!.EducationalClass!.ArabicName ?? null)
                        : null,
                    EducationalEntityName = x.ProvidedForm!.CategoryEducationalEntity != null
                        ? (Request.lang == "en"
                            ? x.ProvidedForm!.CategoryEducationalEntity!.EducationalEntity!.EnglishName ?? null
                            : x.ProvidedForm!.CategoryEducationalEntity!.EducationalEntity!.ArabicName ?? null)
                        : null,
                    ProfilePhoto = x.ProvidedForm!.User.ImageURL,
                    Gender = x.ProvidedForm!.User.Gender,
                    WinningLevel = x.WinningLevel,
                    NotifiedAsWinner = x.NotifiedAsWinner
                }).ToList();

            GetWinnersByLevelMainResponse Response = new GetWinnersByLevelMainResponse()
            {
                RequestedWinners = RequestedWinners.Any()
                    ? RequestedWinners
                        .Where(x => x.WinningLevel != null)
                        .GroupBy(x => x.WinningLevel)
                        .Select(x => new GetWinnersByLevelGroupByLevelListVM()
                        {
                            WinningLevel = x.Key!.Value,
                            GetWinnersByLevelListVM = x.ToList()
                        }).ToList()
                    : new List<GetWinnersByLevelGroupByLevelListVM>(),
                RemainingWinners = RemainingWinners.Any()
                    ? RemainingWinners
                        .Where(x => x.WinningLevel != null)
                        .GroupBy(x => x.WinningLevel)
                        .Select(x => new GetWinnersByLevelGroupByLevelListVM()
                        {
                            WinningLevel = x.Key!.Value,
                            GetWinnersByLevelListVM = x.ToList()
                        }).ToList()
                    : new List<GetWinnersByLevelGroupByLevelListVM>(),
                SelectedWinners = SelectedWinners.Any()
                    ? SelectedWinners
                        .Where(x => x.WinningLevel != null)
                        .GroupBy(x => x.WinningLevel)
                        .Select(x => new GetWinnersByLevelGroupByLevelListVM()
                        {
                            WinningLevel = x.Key!.Value,
                            GetWinnersByLevelListVM = x.ToList()
                        }).ToList()
                    : new List<GetWinnersByLevelGroupByLevelListVM>()
            };

            return new BaseResponse<GetWinnersByLevelMainResponse>(ResponseMessage, true, 200, Response);
        }
    }
}
