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

        public GetWinnersByLevelHandler(IAsyncRepository<Arbitration> ArbitrationRepository,
            IAsyncRepository<FinalArbitration> FinalArbitrationRepository,
            IAsyncRepository<ArbitrationResult> ArbitrationResultRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository,
            IAsyncRepository<Category> CategoryRepository)
        {
            _ArbitrationRepository = ArbitrationRepository;
            _FinalArbitrationRepository = FinalArbitrationRepository;
            _ArbitrationResultRepository = ArbitrationResultRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
            _CategoryRepository = CategoryRepository;
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
                    x.Winner && x.EligibleToWin)
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
                })
                .ToList();

            List<Arbitration> ArbitrationEntities = _ArbitrationRepository
                .AsEnumerable()
                .Where(x => ArbitrationResultEntities
                    .SelectMany(y => y.Select(z => z.ProvidedFormId))
                    .Contains(x.ProvidedFormId))
                .ToList();

            List<IGrouping<float, ArbitrationResult>> RequestedWinnersList = ArbitrationResultEntities
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
                        ArbitrationAuditScore = (ArbitrationEntities.Any() && ArbitrationEntities.Count(y => y.ProvidedFormId == x.ProvidedFormId) != 0)
                            ? ArbitrationEntities
                                .Where(y => y.ProvidedFormId == x.ProvidedFormId)
                                .Select(y => y.FullScore)
                                .Sum() / ArbitrationEntities.Count(y => y.ProvidedFormId == x.ProvidedFormId)
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
                        WinningLevel = x.WinningLevel!.Value
                    }).ToList());
            }

            int TotalCount = await _ArbitrationResultRepository
                .GetCountAsync(x => !RequestedWinners.Select(y => y.FormId).Contains(x.ProvidedFormId));

            List<GetWinnersByLevelListVM> RemainingWinners = _ArbitrationResultRepository
                .Where(x => !RequestedWinners.AsEnumerable().Select(y => y.FormId).Contains(x.ProvidedFormId))
                .AsEnumerable()
                .Skip((Request.page != 0 && Request.PerPage != -1)
                    ? (Request.page - 1) * Request.PerPage
                    : 0)
                .Take((Request.page != 0 && Request.PerPage != -1)
                    ? Request.PerPage
                    : TotalCount)
                .Select(x => new GetWinnersByLevelListVM()
                {
                    FormId = x.ProvidedFormId,
                    FinalArbitrationScore = x.FinalArbitration!.FinalScore,
                    SubscriberName = DynamicAttributeValueEntities
                        .FirstOrDefault(y => y.FormId == x.ProvidedFormId)!.SubscriberName,
                    CategoryId = x.ProvidedForm!.categoryId,
                    CategoryName = Request.lang == "en"
                            ? x.ProvidedForm!.Category!.EnglishName
                            : x.ProvidedForm!.Category!.ArabicName,
                    InitialArbitrationScore = (ArbitrationEntities.Any() && ArbitrationEntities.Count(y => y.ProvidedFormId == x.ProvidedFormId) != 0)
                        ? (ArbitrationEntities
                            .Where(y => y.ProvidedFormId == x.ProvidedFormId)
                            .Select(y => y.FullScore)
                            .AsEnumerable()
                            .Sum() / ArbitrationEntities.Count(y => y.ProvidedFormId == x.ProvidedFormId))
                        : 0,
                    ArbitrationAuditScore = (ArbitrationEntities.Any() && ArbitrationEntities.Count(y => y.ProvidedFormId == x.ProvidedFormId) != 0)
                        ? (ArbitrationEntities
                            .Where(y => y.ProvidedFormId == x.ProvidedFormId)
                            .Select(y => y.FullScore)
                            .AsEnumerable()
                            .Sum() / ArbitrationEntities.Count(y => y.ProvidedFormId == x.ProvidedFormId))
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
                    WinningLevel = x.WinningLevel!.Value
                }).ToList();

            GetWinnersByLevelMainResponse Response = new GetWinnersByLevelMainResponse()
            {
                RequestedWinners = RequestedWinners.Any()
                    ? RequestedWinners
                        .GroupBy(x => x.WinningLevel)
                        .Select(x => new GetWinnersByLevelGroupByLevelListVM()
                        {
                            WinningLevel = x.Key,
                            GetWinnersByLevelListVM = x.ToList()
                        }).ToList()
                    : new List<GetWinnersByLevelGroupByLevelListVM>(),
                RemainingWinners = RemainingWinners.Any()
                    ? RemainingWinners
                        .GroupBy(x => x.WinningLevel)
                        .Select(x => new GetWinnersByLevelGroupByLevelListVM()
                        {
                            WinningLevel = x.Key,
                            GetWinnersByLevelListVM = x.ToList()
                        }).ToList()
                    : new List<GetWinnersByLevelGroupByLevelListVM>()
            };

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.PerPage, TotalCount);

            return new BaseResponse<GetWinnersByLevelMainResponse>(ResponseMessage, true, 200, Response, PaginationParameter);
        }
    }
}
