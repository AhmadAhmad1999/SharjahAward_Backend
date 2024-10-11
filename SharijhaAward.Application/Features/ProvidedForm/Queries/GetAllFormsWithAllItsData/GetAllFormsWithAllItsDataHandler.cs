using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.ArbitrationFeatures.Queries.GetArbitratrionDataByArbitratorId;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.ArbitrationResultModel;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.CategoryArbitratorModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.FinalArbitrationModel;

namespace SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllFormsWithAllItsData
{
    public class GetAllFormsWithAllItsDataHandler
        : IRequestHandler<GetAllFormsWithAllItsDataQuery, BaseResponse<List<GetAllFormsWithAllItsDataListVM>>>
    {
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        private readonly IAsyncRepository<Arbitrator> _ArbitratorRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IAsyncRepository<CategoryArbitrator> _CategoryArbitratorRepository;
        private readonly IAsyncRepository<ArbitrationResult> _ArbitrationResultRepository;
        private readonly IAsyncRepository<FinalArbitration> _FinalArbitrationRepository;
        private readonly IAsyncRepository<ArbitrationAudit> _ArbitrationAuditRepository;
        private readonly IAsyncRepository<InitialArbitration> _InitialArbitrationRepository;
        public GetAllFormsWithAllItsDataHandler(IAsyncRepository<Arbitration> ArbitrationRepository,
            IAsyncRepository<Arbitrator> ArbitratorRepository,
            IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> ProvidedFormRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository,
            IAsyncRepository<CategoryArbitrator> CategoryArbitratorRepository,
            IAsyncRepository<ArbitrationResult> ArbitrationResultRepository,
            IAsyncRepository<FinalArbitration> FinalArbitrationRepository,
            IAsyncRepository<ArbitrationAudit> ArbitrationAuditRepository,
            IAsyncRepository<InitialArbitration> InitialArbitrationRepository)
        {
            _ArbitrationRepository = ArbitrationRepository;
            _ArbitratorRepository = ArbitratorRepository;
            _ProvidedFormRepository = ProvidedFormRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
            _CategoryArbitratorRepository = CategoryArbitratorRepository;
            _ArbitrationResultRepository = ArbitrationResultRepository;
            _FinalArbitrationRepository = FinalArbitrationRepository;
            _ArbitrationAuditRepository = ArbitrationAuditRepository;
            _InitialArbitrationRepository = InitialArbitrationRepository;
        }

        public async Task<BaseResponse<List<GetAllFormsWithAllItsDataListVM>>> 
            Handle(GetAllFormsWithAllItsDataQuery Request, CancellationToken cancellationToken)
        {
            FilterObject FilterObject = new FilterObject() { Filters = Request.filters };

            string ResponseMessage = string.Empty;

            List<Arbitration> AllArbitrationEntities = await _ArbitrationRepository
                .Where(x => x.ProvidedForm!.PercentCompletion == 100)
                .ToListAsync();

            IEnumerable<Arbitration> AllArbitratorsAssigned = AllArbitrationEntities
                .Where(x => x.ProvidedForm!.PercentCompletion == 100)
                .AsEnumerable();
            
            List<DynamicAttributeValue> SubscribersNames = new List<DynamicAttributeValue>();

            if (FilterObject.Filters != null)
            {
                Filter? CheckSubscriberNameFilteration = FilterObject.Filters.FirstOrDefault(x => x.Key!.ToLower() == "SubscriberName".ToLower());

                if (CheckSubscriberNameFilteration != null)
                {
                    SubscribersNames = await _DynamicAttributeValueRepository
                        .Where(x => x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                            x.DynamicAttribute!.DynamicAttributeSection!.AttributeTableNameId == 1 &&
                            x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower() &&
                            x.Value.ToLower().StartsWith(CheckSubscriberNameFilteration!.Value!.ToLower()))
                        .ToListAsync();
                }
                else
                {
                    SubscribersNames = await _DynamicAttributeValueRepository
                        .Where(x => x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                            x.DynamicAttribute!.DynamicAttributeSection!.AttributeTableNameId == 1 &&
                            x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower())
                        .ToListAsync();
                }
            }
            else
            {
                SubscribersNames = await _DynamicAttributeValueRepository
                    .Where(x => x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                        x.DynamicAttribute!.DynamicAttributeSection!.AttributeTableNameId == 1 &&
                        x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower())
                    .ToListAsync();
            }

            List<int> ProvidedFormsInArbitrationResult = await _ArbitrationResultRepository
                .Select(x => x.ProvidedFormId)
                .Distinct()
                .ToListAsync();

            List<int> ProvidedFormsInFinalArbitration = await _FinalArbitrationRepository
                .Where(x => !ProvidedFormsInArbitrationResult.Contains(x.ProvidedFormId))
                .Select(x => x.ProvidedFormId)
                .Distinct()
                .ToListAsync();

            List<int> ProvidedFormsInArbitrationAudit = await _ArbitrationAuditRepository
                .Where(x => !ProvidedFormsInFinalArbitration.Contains(x.ProvidedFormId))
                .Select(x => x.ProvidedFormId)
                .Distinct()
                .ToListAsync();

            List<int> ProvidedFormsInInitialArbitration = await _InitialArbitrationRepository
                .Where(x => !ProvidedFormsInArbitrationAudit.Contains(x.Arbitration!.ProvidedFormId))
                .Select(x => x.Arbitration!.ProvidedFormId)
                .Distinct()
                .ToListAsync();

            int TotalCount = 0;
            
            if (Request.page != 0 && Request.perPage != -1)
            {
                List<GetAllFormsWithAllItsDataListVM> Response = _ProvidedFormRepository
                    .WhereThenFilter(x => x.PercentCompletion == 100 &&
                        x.IsAccepted != null &&
                        SubscribersNames.Select(y => y.RecordId).Contains(x.Id), FilterObject)
                    .OrderByDescending(x => x.CreatedAt)
                    .Skip((Request.page - 1) * Request.perPage)
                    .Take(Request.perPage)
                    .AsEnumerable()
                    .Select(x => Request.lang == "en"
                        ? new GetAllFormsWithAllItsDataListVM()
                        {
                            Id = x.Id,
                            CategoryName = x.Category!.EnglishName,
                            SubscriberName = SubscribersNames.FirstOrDefault(y => y.RecordId == x.Id) ? .Value ?? "",
                            EducationalClassName = x.CategoryEducationalClass != null
                                ? x.CategoryEducationalClass!.EducationalClass!.EnglishName
                                : null,
                            IsAccepted = x.IsAccepted!,
                            PercentCompletion = x.PercentCompletion,
                            ArbitrationLevelForThisForm = ProvidedFormsInArbitrationResult.Contains(x.Id)
                                ? ArbitrationLevelForForm.ArbitrationResult
                                : (ProvidedFormsInFinalArbitration.Contains(x.Id)
                                    ? ArbitrationLevelForForm.FinalArbitration
                                    : (ProvidedFormsInArbitrationAudit.Contains(x.Id)
                                        ? ArbitrationLevelForForm.ArbitrationAudit
                                        : (ProvidedFormsInInitialArbitration.Contains(x.Id)
                                            ? ArbitrationLevelForForm.InitialArbitration
                                            : ArbitrationLevelForForm.ArbitrationSorting))),
                            ArbitratorsForThisForm = AllArbitratorsAssigned
                                .Where(y => y.ProvidedFormId == x.Id)
                                .AsEnumerable()
                                .Select(y => new ArbitratorsForForm()
                                {
                                    ArbitratorId = y.ArbitratorId,
                                    ArbitratorName = Request.lang == "en"
                                        ? y.Arbitrator!.EnglishName
                                        : y.Arbitrator!.ArabicName
                                }).ToList()
                        }
                        : new GetAllFormsWithAllItsDataListVM()
                        {
                            Id = x.Id,
                            CategoryName = x.Category!.ArabicName,
                            SubscriberName = SubscribersNames.FirstOrDefault(y => y.RecordId == x.Id) ? .Value ?? "",
                            EducationalClassName = x.CategoryEducationalClass != null
                                ? x.CategoryEducationalClass!.EducationalClass!.ArabicName : null,
                            IsAccepted = x.IsAccepted!,
                            PercentCompletion = x.PercentCompletion,
                            ArbitrationLevelForThisForm = ProvidedFormsInArbitrationResult.Contains(x.Id)
                                ? ArbitrationLevelForForm.ArbitrationResult
                                : (ProvidedFormsInFinalArbitration.Contains(x.Id)
                                    ? ArbitrationLevelForForm.FinalArbitration
                                    : (ProvidedFormsInArbitrationAudit.Contains(x.Id)
                                        ? ArbitrationLevelForForm.ArbitrationAudit
                                        : (ProvidedFormsInInitialArbitration.Contains(x.Id)
                                            ? ArbitrationLevelForForm.InitialArbitration
                                            : ArbitrationLevelForForm.ArbitrationSorting))),
                            ArbitratorsForThisForm = AllArbitratorsAssigned
                                .Where(y => y.ProvidedFormId == x.Id)
                                .AsEnumerable()
                                .Select(y => new ArbitratorsForForm()
                                {
                                    ArbitratorId = y.ArbitratorId,
                                    ArbitratorName = Request.lang == "en"
                                        ? y.Arbitrator!.EnglishName
                                        : y.Arbitrator!.ArabicName
                                }).ToList()
                        }).ToList();

                TotalCount = await _ProvidedFormRepository
                    .WhereThenFilter(x => x.PercentCompletion == 100 &&
                        x.IsAccepted != null &&
                        SubscribersNames.Select(y => y.RecordId).Contains(x.Id), FilterObject)
                    .CountAsync();

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.perPage, TotalCount);

                return new BaseResponse<List<GetAllFormsWithAllItsDataListVM>>(ResponseMessage, true, 200, Response, PaginationParameter);
            }
            else
            {
                List<GetAllFormsWithAllItsDataListVM> Response = _ProvidedFormRepository
                    .WhereThenFilter(x => x.PercentCompletion == 100 &&
                        x.IsAccepted != null &&
                        SubscribersNames.Select(y => y.RecordId).Contains(x.Id), FilterObject)
                    .OrderByDescending(x => x.CreatedAt)
                    .AsEnumerable()
                    .Select(x => Request.lang == "en"
                        ? new GetAllFormsWithAllItsDataListVM()
                        {
                            Id = x.Id,
                            CategoryName = x.Category!.EnglishName,
                            SubscriberName = SubscribersNames.FirstOrDefault(y => y.RecordId == x.Id) != null
                                ? SubscribersNames.FirstOrDefault(y => y.RecordId == x.Id) ? .Value ?? ""
                                : null,
                            EducationalClassName = x.CategoryEducationalClass != null
                                ? x.CategoryEducationalClass!.EducationalClass!.EnglishName
                                : null,
                            IsAccepted = x.IsAccepted!,
                            PercentCompletion = x.PercentCompletion,
                            ArbitrationLevelForThisForm = ProvidedFormsInArbitrationResult.Contains(x.Id)
                                ? ArbitrationLevelForForm.ArbitrationResult
                                : (ProvidedFormsInFinalArbitration.Contains(x.Id)
                                    ? ArbitrationLevelForForm.FinalArbitration
                                    : (ProvidedFormsInArbitrationAudit.Contains(x.Id)
                                        ? ArbitrationLevelForForm.ArbitrationAudit
                                        : (ProvidedFormsInInitialArbitration.Contains(x.Id)
                                            ? ArbitrationLevelForForm.InitialArbitration
                                            : ArbitrationLevelForForm.ArbitrationSorting))),
                            ArbitratorsForThisForm = AllArbitratorsAssigned
                                .Where(y => y.ProvidedFormId == x.Id)
                                .AsEnumerable()
                                .Select(y => new ArbitratorsForForm()
                                {
                                    ArbitratorId = y.ArbitratorId,
                                    ArbitratorName = Request.lang == "en"
                                        ? y.Arbitrator!.EnglishName
                                        : y.Arbitrator!.ArabicName
                                }).ToList()
                        }
                        : new GetAllFormsWithAllItsDataListVM()
                        {
                            Id = x.Id,
                            CategoryName = x.Category!.ArabicName,
                            SubscriberName = SubscribersNames.FirstOrDefault(y => y.RecordId == x.Id) != null
                                ? SubscribersNames.FirstOrDefault(y => y.RecordId == x.Id)?.Value ?? "" : null,
                            EducationalClassName = x.CategoryEducationalClass != null
                                ? x.CategoryEducationalClass!.EducationalClass!.ArabicName : null,
                            IsAccepted = x.IsAccepted!,
                            PercentCompletion = x.PercentCompletion,
                            ArbitrationLevelForThisForm = ProvidedFormsInArbitrationResult.Contains(x.Id)
                                ? ArbitrationLevelForForm.ArbitrationResult
                                : (ProvidedFormsInFinalArbitration.Contains(x.Id)
                                    ? ArbitrationLevelForForm.FinalArbitration
                                    : (ProvidedFormsInArbitrationAudit.Contains(x.Id)
                                        ? ArbitrationLevelForForm.ArbitrationAudit
                                        : (ProvidedFormsInInitialArbitration.Contains(x.Id)
                                            ? ArbitrationLevelForForm.InitialArbitration
                                            : ArbitrationLevelForForm.ArbitrationSorting))),
                            ArbitratorsForThisForm = AllArbitratorsAssigned
                                .Where(y => y.ProvidedFormId == x.Id)
                                .AsEnumerable()
                                .Select(y => new ArbitratorsForForm()
                                {
                                    ArbitratorId = y.ArbitratorId,
                                    ArbitratorName = Request.lang == "en"
                                        ? y.Arbitrator!.EnglishName
                                        : y.Arbitrator!.ArabicName
                                }).ToList()
                        }).ToList();

                TotalCount = await _ProvidedFormRepository
                    .WhereThenFilter(x => x.PercentCompletion == 100 &&
                        x.IsAccepted != null &&
                        SubscribersNames.Select(y => y.RecordId).Contains(x.Id), FilterObject)
                    .CountAsync();

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.perPage, TotalCount);

                return new BaseResponse<List<GetAllFormsWithAllItsDataListVM>>(ResponseMessage, true, 200, Response, PaginationParameter);
            }
        }
    }
}
