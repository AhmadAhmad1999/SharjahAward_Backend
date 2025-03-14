﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.WinnersFeatures.Queries.GetWinnersByLevel;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.ArbitrationResultModel;
using SharijhaAward.Domain.Entities.CategoryEducationalClassModel;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.EducationalClassModel;
using SharijhaAward.Domain.Entities.FinalArbitrationModel;

namespace SharijhaAward.Application.Features.WinnersFeatures.Queries.GetWinnersByLevelGroupedByClasses
{
    public class GetWinnersByLevelGroupedByClassesHandler
        : IRequestHandler<GetWinnersByLevelGroupedByClassesQuery, BaseResponse<List<GetWinnersByLevelGroupedByClassesListVM>>>
    {
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        private readonly IAsyncRepository<FinalArbitration> _FinalArbitrationRepository;
        private readonly IAsyncRepository<ArbitrationResult> _ArbitrationResultRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IAsyncRepository<Category> _CategoryRepository;
        private readonly IAsyncRepository<ArbitrationAudit> _ArbitrationAuditRepository;
        private readonly IAsyncRepository<CategoryEducationalClass> _CategoryEducationalClassRepository;

        public GetWinnersByLevelGroupedByClassesHandler(IAsyncRepository<Arbitration> ArbitrationRepository,
            IAsyncRepository<FinalArbitration> FinalArbitrationRepository,
            IAsyncRepository<ArbitrationResult> ArbitrationResultRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository,
            IAsyncRepository<Category> CategoryRepository,
            IAsyncRepository<ArbitrationAudit> ArbitrationAuditRepository,
            IAsyncRepository<CategoryEducationalClass> CategoryEducationalClassRepository)
        {
            _ArbitrationRepository = ArbitrationRepository;
            _FinalArbitrationRepository = FinalArbitrationRepository;
            _ArbitrationResultRepository = ArbitrationResultRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
            _CategoryRepository = CategoryRepository;
            _ArbitrationAuditRepository = ArbitrationAuditRepository;
            _CategoryEducationalClassRepository = CategoryEducationalClassRepository;
        }

        public async Task<BaseResponse<List<GetWinnersByLevelGroupedByClassesListVM>>>
            Handle(GetWinnersByLevelGroupedByClassesQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Category? CategoryEntity = await _CategoryRepository
                .IncludeThenFirstOrDefaultAsync(x => x.Parent!, x => x.Id == Request.CategoryId);

            if (CategoryEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Category is not found"
                    : "ألفئة غير موجود";

                return new BaseResponse<List<GetWinnersByLevelGroupedByClassesListVM>>(ResponseMessage, false, 404);
            }

            if (Request.MaxLevelOfWinners == 0 && CategoryEntity.ExpectedNumberOfWinners != null)
                Request.MaxLevelOfWinners = CategoryEntity.ExpectedNumberOfWinners.Value;

            List<CategoryEducationalClass> CategoryEducationalClassEntities = await _CategoryEducationalClassRepository
                .Where(x => x.CategoryId == Request.CategoryId)
                .ToListAsync();

            List<IGrouping<EducationalClass, ArbitrationResult>> ArbitrationResultEntitiesForAllClasses = _ArbitrationResultRepository
                .Where(x => CategoryEducationalClassEntities.Select(y => y.CategoryId).Contains(x.ProvidedForm!.categoryId) &&
                    x.EligibleToWin && x.ProvidedForm!.CategoryEducationalClassId != null && x.FinalArbitrationId != null)
                .OrderByDescending(x => x.FinalArbitration!.FinalScore)
                .AsEnumerable()
                .GroupBy(x => x.ProvidedForm!.CategoryEducationalClass!.EducationalClass!)
                .ToList();

            List<DynamicAttributeValue> DynamicAttributeValueEntitiesToAllClasses = _DynamicAttributeValueRepository
                .AsEnumerable()
                .Where(x => ArbitrationResultEntitiesForAllClasses
                    .SelectMany(y => y.Select(z => z.ProvidedFormId)).Any(y => y == x.RecordId) &&
                        x.DynamicAttribute!.EnglishTitle == "Full name (identical to Emirates ID)")
                .ToList();

            List<Arbitration> ArbitrationEntitiesForAllClasses = _ArbitrationRepository
                .AsEnumerable()
                .Where(x => ArbitrationResultEntitiesForAllClasses
                    .SelectMany(y => y.Select(z => z.ProvidedFormId))
                    .Contains(x.ProvidedFormId))
                .ToList();

            List<ArbitrationAudit> ArbitrationAuditEntitiesForAllClasses = _ArbitrationAuditRepository
                .AsEnumerable()
                .Where(x => ArbitrationResultEntitiesForAllClasses
                    .SelectMany(y => y.Select(z => z.ProvidedFormId))
                    .Contains(x.ProvidedFormId))
                .ToList();

            List<GetWinnersByLevelGroupedByClassesListVM> Response = new List<GetWinnersByLevelGroupedByClassesListVM>();

            foreach (IGrouping<EducationalClass, ArbitrationResult> ArbitrationResultEntitiesForEachClass in ArbitrationResultEntitiesForAllClasses)
            {
                int ClassId = ArbitrationResultEntitiesForEachClass.Key.Id;
                string ClassName = Request.lang == "en"
                    ? ArbitrationResultEntitiesForEachClass.Key.EnglishName
                    : ArbitrationResultEntitiesForEachClass.Key.ArabicName;

                List<IGrouping<float, ArbitrationResult>> ArbitrationResultEntities = ArbitrationResultEntitiesForEachClass
                    .ToList()
                    .GroupBy(x => x.FinalArbitration!.FinalScore)
                    .ToList();

                var DynamicAttributeValueEntities = DynamicAttributeValueEntitiesToAllClasses
                    .Where(x => ArbitrationResultEntities
                        .SelectMany(y => y.Select(z => z.ProvidedFormId)).Any(y => y == x.RecordId) &&
                            x.DynamicAttribute!.EnglishTitle == "Full name (identical to Emirates ID)")
                    .Select(x => new
                    {
                        FormId = x.RecordId,
                        SubscriberName = x.Value
                    }).ToList();

                List<Arbitration> ArbitrationEntities = ArbitrationEntitiesForAllClasses
                    .Where(x => ArbitrationResultEntities
                    .SelectMany(y => y.Select(z => z.ProvidedFormId))
                    .Contains(x.ProvidedFormId))
                    .ToList();

                List<ArbitrationAudit> ArbitrationAuditEntities = ArbitrationAuditEntitiesForAllClasses
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
                                    .Sum()
                                : 0,
                            CycleNumber = x.ProvidedForm!.CycleNumber,
                            CycleYear = x.ProvidedForm!.CycleYear,
                            EducationalClassName = Request.lang == "en"
                                ? x.ProvidedForm!.CategoryEducationalClass?.EducationalClass!.EnglishName ?? null
                                : x.ProvidedForm!.CategoryEducationalClass?.EducationalClass!.ArabicName ?? null,
                            EducationalEntityName = x.ProvidedForm.EducationalEntityId != null
                                ? (Request.lang == "en"
                                    ? x.ProvidedForm!.EducationalEntity!.EnglishName ?? null
                                    : x.ProvidedForm!.EducationalEntity!.ArabicName ?? null)
                                : null,
                            ProfilePhoto = x.ProvidedForm!.User.ImageURL,
                            Gender = x.ProvidedForm!.User.Gender,
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
                                    .Sum()
                                : 0,
                            CycleNumber = x.ProvidedForm!.CycleNumber,
                            CycleYear = x.ProvidedForm!.CycleYear,
                            EducationalClassName = Request.lang == "en"
                                ? x.ProvidedForm!.CategoryEducationalClass?.EducationalClass!.EnglishName ?? null
                                : x.ProvidedForm!.CategoryEducationalClass?.EducationalClass!.ArabicName ?? null,
                            EducationalEntityName = x.ProvidedForm.EducationalEntityId != null
                                ? (Request.lang == "en"
                                    ? x.ProvidedForm!.EducationalEntity!.EnglishName ?? null
                                    : x.ProvidedForm!.EducationalEntity!.ArabicName ?? null)
                                : null,
                            ProfilePhoto = x.ProvidedForm!.User.ImageURL,
                            Gender = x.ProvidedForm!.User.Gender,
                            NotifiedAsWinner = x.NotifiedAsWinner
                        }).ToList());
                }

                int TotalCount = await _ArbitrationResultRepository
                    .GetCountAsync(x => !RequestedWinners.Select(y => y.FormId).Contains(x.ProvidedFormId) &&
                        x.FinalArbitrationId != null);

                List<ArbitrationResult> RemainingWinnersQuery = await _ArbitrationResultRepository
                    .Where(x => !RequestedWinners.Select(y => y.FormId).Contains(x.ProvidedFormId) &&
                        !SelectedWinners.Select(y => y.FormId).Contains(x.ProvidedFormId) &&
                        x.FinalArbitrationId != null)
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
                                .Sum())
                            : 0,
                        CycleNumber = x.ProvidedForm!.CycleNumber,
                        CycleYear = x.ProvidedForm!.CycleYear,
                        EducationalClassName = x.ProvidedForm!.CategoryEducationalClass != null
                            ? (Request.lang == "en"
                                ? x.ProvidedForm!.CategoryEducationalClass!.EducationalClass!.EnglishName ?? null
                                : x.ProvidedForm!.CategoryEducationalClass!.EducationalClass!.ArabicName ?? null)
                            : null,
                        EducationalEntityName = x.ProvidedForm.EducationalEntityId != null
                            ? (Request.lang == "en"
                                ? x.ProvidedForm!.EducationalEntity!.EnglishName ?? null
                                : x.ProvidedForm!.EducationalEntity!.ArabicName ?? null)
                            : null,
                        ProfilePhoto = x.ProvidedForm!.User.ImageURL,
                        Gender = x.ProvidedForm!.User.Gender,
                        NotifiedAsWinner = x.NotifiedAsWinner
                    }).ToList();

                List<GetWinnersByLevelGroupByLevelListVM> RequestedWinnersResponse = new List<GetWinnersByLevelGroupByLevelListVM>();

                if (RequestedWinners.Any())
                {
                    var RequestedWinnersGroupedAndOrderd = RequestedWinners
                        .GroupBy(x => x.FinalArbitrationScore)
                        .OrderByDescending(x => x.Key)
                        .ToList();

                    RequestedWinnersResponse = RequestedWinnersGroupedAndOrderd
                        .Select(x => new GetWinnersByLevelGroupByLevelListVM()
                        {
                            WinningLevel = RequestedWinnersGroupedAndOrderd.IndexOf(x) + 1,
                            GetWinnersByLevelListVM = x.ToList()
                        }).ToList();
                }

                List<GetWinnersByLevelGroupByLevelListVM> RemainingWinnersResponse = new List<GetWinnersByLevelGroupByLevelListVM>();

                if (RemainingWinners.Any())
                {
                    var RemainingWinnersGroupedAndOrderd = RemainingWinners
                        .GroupBy(x => x.FinalArbitrationScore)
                        .OrderByDescending(x => x.Key)
                        .ToList();

                    RemainingWinnersResponse = RemainingWinnersGroupedAndOrderd
                        .Select(x => new GetWinnersByLevelGroupByLevelListVM()
                        {
                            WinningLevel = RemainingWinnersGroupedAndOrderd.IndexOf(x) + 1,
                            GetWinnersByLevelListVM = x.ToList()
                        }).ToList();
                }

                List<GetWinnersByLevelGroupByLevelListVM> SelectedWinnersResponse = new List<GetWinnersByLevelGroupByLevelListVM>();

                if (SelectedWinners.Any())
                {
                    var SelectedWinnersGroupedAndOrderd = SelectedWinners
                        .GroupBy(x => x.FinalArbitrationScore)
                        .OrderByDescending(x => x.Key)
                        .ToList();

                    SelectedWinnersResponse = SelectedWinnersGroupedAndOrderd
                        .Select(x => new GetWinnersByLevelGroupByLevelListVM()
                        {
                            WinningLevel = SelectedWinnersGroupedAndOrderd.IndexOf(x) + 1,
                            GetWinnersByLevelListVM = x.ToList()
                        }).ToList();
                }

                Response.Add(new GetWinnersByLevelGroupedByClassesListVM()
                {
                    ClassId = ClassId,
                    ClassName = ClassName,
                    GetWinnersByLevelMainResponse = new GetWinnersByLevelMainResponse()
                    {
                        RequestedWinners = RequestedWinnersResponse,
                        RemainingWinners = RemainingWinnersResponse,
                        SelectedWinners = SelectedWinnersResponse
                    }
                });
            }

            List<CategoryEducationalClass> RemainigClassWithNoWinners = CategoryEducationalClassEntities
                .Where(x => !Response.Select(y => y.ClassId).Contains(x.EducationalClassId))
                .ToList();

            Response.AddRange(RemainigClassWithNoWinners
                .Select(x => new GetWinnersByLevelGroupedByClassesListVM()
                {
                    ClassId = x.EducationalClassId,
                    ClassName = Request.lang == "en"
                        ? x.EducationalClass!.EnglishName
                        : x.EducationalClass!.ArabicName,
                    GetWinnersByLevelMainResponse = new GetWinnersByLevelMainResponse()
                }));

            Response = Response
                .DistinctBy(x => x.ClassId)
                .ToList();

            return new BaseResponse<List<GetWinnersByLevelGroupedByClassesListVM>>(ResponseMessage, true, 200, Response);
        }
    }
}
