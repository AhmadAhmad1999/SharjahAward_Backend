﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.ArbitrationResultModel;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.CategoryArbitratorModel;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.FinalArbitrationModel;

namespace SharijhaAward.Application.Features.ArbitrationFeatures.Queries.GetArbitratrionDataByArbitratorId
{
    public class GetArbitratrionDataByArbitratorIdHandler
        : IRequestHandler<GetArbitratrionDataByArbitratorIdQuery, BaseResponse<GetArbitratrionDataByArbitratorIdDto>>
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
        private readonly IAsyncRepository<Cycle> _CycleRepository;
        public GetArbitratrionDataByArbitratorIdHandler(IAsyncRepository<Arbitration> ArbitrationRepository,
            IAsyncRepository<Arbitrator> ArbitratorRepository,
            IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> ProvidedFormRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository,
            IAsyncRepository<CategoryArbitrator> CategoryArbitratorRepository,
            IAsyncRepository<ArbitrationResult> ArbitrationResultRepository,
            IAsyncRepository<FinalArbitration> FinalArbitrationRepository,
            IAsyncRepository<ArbitrationAudit> ArbitrationAuditRepository,
            IAsyncRepository<InitialArbitration> InitialArbitrationRepository,
            IAsyncRepository<Cycle> CycleRepository)
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
            _CycleRepository = CycleRepository;
        }

        public async Task<BaseResponse<GetArbitratrionDataByArbitratorIdDto>> 
            Handle(GetArbitratrionDataByArbitratorIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Arbitrator? ArbitratorEntity = await _ArbitratorRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (ArbitratorEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Arbitrator is not Found"
                    : "المحكم غير موجود";

                return new BaseResponse<GetArbitratrionDataByArbitratorIdDto>(ResponseMessage, false, 404);
            }

            Cycle? CheckIfThereIsActiveCycle = await _CycleRepository
                .FirstOrDefaultAsync(x => x.Status == Domain.Constants.Common.Status.Active);

            if (CheckIfThereIsActiveCycle is null)
                return new BaseResponse<GetArbitratrionDataByArbitratorIdDto>(ResponseMessage, true, 200);

            int ActiveCycleId = CheckIfThereIsActiveCycle.Id;

            List<int> ArbitratorCategoriesIds = await _CategoryArbitratorRepository
                .Where(x => x.ArbitratorId == Request.Id &&
                    x.Category!.CycleId == ActiveCycleId &&
                    (Request.CategoryId != null
                        ? x.CategoryId == Request.CategoryId
                        : true))
                .Select(x => x.CategoryId)
                .ToListAsync();

            List<Arbitration> AllArbitrationEntities = await _ArbitrationRepository
                .Where(x => ArbitratorCategoriesIds.Contains(x.ProvidedForm!.categoryId) &&
                    x.ProvidedForm!.Category!.CycleId == ActiveCycleId &&
                    (Request.ProvidedFormId != null
                        ? x.ProvidedFormId == Request.ProvidedFormId
                        : true) &&
                    (Request.isAccepted != null
                        ? x.ProvidedForm!.IsAccepted == Request.isAccepted
                        : true) &&
                    (!string.IsNullOrEmpty(Request.ProvidedFormLanguage)
                        ? x.ProvidedForm!.Formlanguage.ToLower() == Request.ProvidedFormLanguage.ToLower()
                        : true))
                .ToListAsync();

            List<DynamicAttributeValue> SubscribersNames = await _DynamicAttributeValueRepository
                .Where(x => x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                    x.DynamicAttribute!.DynamicAttributeSection!.AttributeTableNameId == 1 &&
                    x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower() &&
                    (!string.IsNullOrEmpty(Request.SubscriberName)
                        ? x.Value.ToLower().StartsWith(Request.SubscriberName.ToLower())
                        : true) &&
                    (AllArbitrationEntities.Select(y => y.ProvidedFormId).Any(y => y == x.RecordId)) &&
                    (Request.ProvidedFormId != null
                        ? x.RecordId == Request.ProvidedFormId
                        : true))
                .ToListAsync();

            AllArbitrationEntities = AllArbitrationEntities
                .Where(x => SubscribersNames.Select(y => y.RecordId).Contains(x.ProvidedFormId))
                .ToList();

            List<Arbitration> AllArbitratorAssingedForms = AllArbitrationEntities
                .Where(x => x.ArbitratorId == Request.Id)
                .OrderByDescending(x => x.CreatedAt)
                .ToList();

            IEnumerable<Arbitration> AllArbitratorsAssigned = AllArbitrationEntities
                .AsEnumerable();

            List<int> ProvidedFormsInArbitrationResult = await _ArbitrationResultRepository
                .Where(x => AllArbitrationEntities.Select(y => y.ProvidedFormId).Contains(x.ProvidedFormId))
                .Select(x => x.ProvidedFormId)
                .Distinct()
                .ToListAsync();

            List<int> ProvidedFormsInFinalArbitration = await _FinalArbitrationRepository
                .Where(x => !ProvidedFormsInArbitrationResult.Contains(x.ProvidedFormId) &&
                    AllArbitrationEntities.Select(y => y.ProvidedFormId).Contains(x.ProvidedFormId))
                .Select(x => x.ProvidedFormId)
                .Distinct()
                .ToListAsync();

            List<int> ProvidedFormsInArbitrationAudit = await _ArbitrationAuditRepository
                .Where(x => !ProvidedFormsInFinalArbitration.Contains(x.ProvidedFormId) &&
                    AllArbitrationEntities.Select(y => y.ProvidedFormId).Contains(x.ProvidedFormId))
                .Select(x => x.ProvidedFormId)
                .Distinct()
                .ToListAsync();

            List<int> ProvidedFormsInInitialArbitration = await _InitialArbitrationRepository
                .Where(x => !ProvidedFormsInArbitrationAudit.Contains(x.Arbitration!.ProvidedFormId) &&
                    AllArbitrationEntities.Select(y => y.ProvidedFormId).Contains(x.Arbitration!.ProvidedFormId))
                .Select(x => x.Arbitration!.ProvidedFormId)
                .Distinct()
                .ToListAsync();

            if (Request.GetRemainigForms)
            {
                int TotalCount = await _ProvidedFormRepository
                    .GetCountAsync(x => !AllArbitratorAssingedForms.Select(y => y.ProvidedFormId).Contains(x.Id));

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.perPage, TotalCount);

                if (Request.page != 0 && Request.perPage != -1)
                {
                    GetArbitratrionDataByArbitratorIdDto Response = new GetArbitratrionDataByArbitratorIdDto()
                    {
                        ArbitratorName = Request.lang == "en"
                            ? ArbitratorEntity.EnglishName
                            : ArbitratorEntity.ArabicName,
                        NumberOfAssignedForms = AllArbitratorAssingedForms.Count(),
                        RemainingForms = _ProvidedFormRepository
                            .Where(x => !AllArbitratorAssingedForms.Select(y => y.ProvidedFormId).Contains(x.Id) &&
                                x.IsAccepted != null &&
                                ArbitratorCategoriesIds.Contains(x.categoryId) &&
                                (Request.ProvidedFormId != null
                                    ? x.Id == Request.ProvidedFormId
                                    : true) &&
                                (Request.isAccepted != null
                                    ? x.IsAccepted == Request.isAccepted
                                    : true) &&
                                (!string.IsNullOrEmpty(Request.ProvidedFormLanguage)
                                    ? x.Formlanguage.ToLower() == Request.ProvidedFormLanguage.ToLower()
                                    : true))
                            .OrderByDescending(x => x.CreatedAt)
                            .Skip((Request.page - 1) * Request.perPage)
                            .Take(Request.perPage)
                            .AsEnumerable()
                            .Select(x => Request.lang == "en"
                                ? new FormsListVMForArbitrationDto()
                                {
                                    Id = x.Id,
                                    CategoryName = x.Category!.EnglishName,
                                    SubscriberName = SubscribersNames.FirstOrDefault(y => y.RecordId == x.Id)?.Value,
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
                                : new FormsListVMForArbitrationDto()
                                {
                                    Id = x.Id,
                                    CategoryName = x.Category!.ArabicName,
                                    SubscriberName = SubscribersNames.FirstOrDefault(y => y.RecordId == x.Id)?.Value,
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
                                }).ToList()
                    };

                    return new BaseResponse<GetArbitratrionDataByArbitratorIdDto>(ResponseMessage, true, 200, Response, PaginationParameter);
                }
                else
                {
                    GetArbitratrionDataByArbitratorIdDto Response = new GetArbitratrionDataByArbitratorIdDto()
                    {
                        ArbitratorName = Request.lang == "en"
                            ? ArbitratorEntity.EnglishName
                            : ArbitratorEntity.ArabicName,
                        NumberOfAssignedForms = AllArbitratorAssingedForms.Count(),

                        RemainingForms = _ProvidedFormRepository
                            .Where(x => !AllArbitratorAssingedForms.Select(y => y.ProvidedFormId).Contains(x.Id) &&
                                x.IsAccepted != null &&
                                ArbitratorCategoriesIds.Contains(x.categoryId) &&
                                (Request.ProvidedFormId != null
                                    ? x.Id == Request.ProvidedFormId
                                    : true) &&
                                (Request.isAccepted != null
                                    ? x.IsAccepted == Request.isAccepted
                                    : true) &&
                                (!string.IsNullOrEmpty(Request.ProvidedFormLanguage)
                                    ? x.Formlanguage.ToLower() == Request.ProvidedFormLanguage.ToLower()
                                    : true))
                            .OrderByDescending(x => x.CreatedAt)
                            .AsEnumerable()
                            .Select(x => Request.lang == "en"
                                ? new FormsListVMForArbitrationDto()
                                {
                                    Id = x.Id,
                                    CategoryName = x.Category!.EnglishName,
                                    SubscriberName = SubscribersNames.FirstOrDefault(y => y.RecordId == x.Id) != null
                                        ? SubscribersNames.FirstOrDefault(y => y.RecordId == x.Id)!.Value
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
                                : new FormsListVMForArbitrationDto()
                                {
                                    Id = x.Id,
                                    CategoryName = x.Category!.ArabicName,
                                    SubscriberName = SubscribersNames.FirstOrDefault(y => y.RecordId == x.Id) != null
                                        ? SubscribersNames.FirstOrDefault(y => y.RecordId == x.Id)!.Value : null,
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
                                }).ToList()
                    };

                    return new BaseResponse<GetArbitratrionDataByArbitratorIdDto>(ResponseMessage, true, 200, Response, PaginationParameter);
                }
            }
            else
            {
                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.perPage, AllArbitratorAssingedForms.Count());

                if (Request.page != 0 && Request.perPage != -1)
                {
                    GetArbitratrionDataByArbitratorIdDto Response = new GetArbitratrionDataByArbitratorIdDto()
                    {
                        ArbitratorName = Request.lang == "en"
                            ? ArbitratorEntity.EnglishName
                            : ArbitratorEntity.ArabicName,
                        NumberOfAssignedForms = AllArbitratorAssingedForms.Count(),

                        AssignedForms = AllArbitratorAssingedForms
                            .Skip((Request.page - 1) * Request.perPage)
                            .Take(Request.perPage)
                            .Select(x => Request.lang == "en"
                                ? new FormsListVMForArbitrationDto()
                                {
                                    Id = x.ProvidedFormId,
                                    CategoryName = x.ProvidedForm!.Category!.EnglishName,
                                    SubscriberName = SubscribersNames.FirstOrDefault(y => y.RecordId == x.ProvidedFormId)?.Value,
                                    EducationalClassName = x.ProvidedForm!.CategoryEducationalClass?.EducationalClass!.EnglishName,
                                    IsAccepted = x.ProvidedForm!.IsAccepted!,
                                    PercentCompletion = x.ProvidedForm!.PercentCompletion,
                                    ArbitrationLevelForThisForm = ProvidedFormsInArbitrationResult.Contains(x.ProvidedFormId)
                                        ? ArbitrationLevelForForm.ArbitrationResult
                                        : (ProvidedFormsInFinalArbitration.Contains(x.ProvidedFormId)
                                            ? ArbitrationLevelForForm.FinalArbitration
                                            : (ProvidedFormsInArbitrationAudit.Contains(x.ProvidedFormId)
                                                ? ArbitrationLevelForForm.ArbitrationAudit
                                                : (ProvidedFormsInInitialArbitration.Contains(x.ProvidedFormId)
                                                    ? ArbitrationLevelForForm.InitialArbitration
                                                    : ArbitrationLevelForForm.ArbitrationSorting))),
                                    ArbitratorsForThisForm = AllArbitratorsAssigned
                                        .Where(y => y.ProvidedFormId == x.ProvidedFormId)
                                        .AsEnumerable()
                                        .Select(y => new ArbitratorsForForm()
                                        {
                                            ArbitratorId = y.ArbitratorId,
                                            ArbitratorName = Request.lang == "en"
                                                ? y.Arbitrator!.EnglishName
                                                : y.Arbitrator!.ArabicName
                                        }).ToList()
                                }
                                : new FormsListVMForArbitrationDto()
                                {
                                    Id = x.ProvidedFormId,
                                    CategoryName = x.ProvidedForm!.Category!.ArabicName,
                                    SubscriberName = SubscribersNames.FirstOrDefault(y => y.RecordId == x.ProvidedFormId)?.Value,
                                    EducationalClassName = x.ProvidedForm!.CategoryEducationalClass?.EducationalClass!.ArabicName,
                                    IsAccepted = x.ProvidedForm!.IsAccepted!,
                                    PercentCompletion = x.ProvidedForm!.PercentCompletion,
                                    ArbitrationLevelForThisForm = ProvidedFormsInArbitrationResult.Contains(x.ProvidedFormId)
                                        ? ArbitrationLevelForForm.ArbitrationResult
                                        : (ProvidedFormsInFinalArbitration.Contains(x.ProvidedFormId)
                                            ? ArbitrationLevelForForm.FinalArbitration
                                            : (ProvidedFormsInArbitrationAudit.Contains(x.ProvidedFormId)
                                                ? ArbitrationLevelForForm.ArbitrationAudit
                                                : (ProvidedFormsInInitialArbitration.Contains(x.ProvidedFormId)
                                                    ? ArbitrationLevelForForm.InitialArbitration
                                                    : ArbitrationLevelForForm.ArbitrationSorting))),
                                    ArbitratorsForThisForm = AllArbitratorsAssigned
                                        .Where(y => y.ProvidedFormId == x.ProvidedFormId)
                                        .AsEnumerable()
                                        .Select(y => new ArbitratorsForForm()
                                        {
                                            ArbitratorId = y.ArbitratorId,
                                            ArbitratorName = Request.lang == "en"
                                                ? y.Arbitrator!.EnglishName
                                                : y.Arbitrator!.ArabicName
                                        }).ToList()
                                }).ToList()
                    };

                    return new BaseResponse<GetArbitratrionDataByArbitratorIdDto>(ResponseMessage, true, 200, Response, PaginationParameter);
                }
                else
                {
                    GetArbitratrionDataByArbitratorIdDto Response = new GetArbitratrionDataByArbitratorIdDto()
                    {
                        ArbitratorName = Request.lang == "en"
                            ? ArbitratorEntity.EnglishName
                            : ArbitratorEntity.ArabicName,
                        NumberOfAssignedForms = AllArbitratorAssingedForms.Count(),

                        AssignedForms = AllArbitratorAssingedForms
                            .Select(x => Request.lang == "en"
                                ? new FormsListVMForArbitrationDto()
                                {
                                    Id = x.ProvidedFormId,
                                    CategoryName = x.ProvidedForm!.Category!.EnglishName,
                                    SubscriberName = SubscribersNames.FirstOrDefault(y => y.RecordId == x.ProvidedFormId)?.Value,
                                    EducationalClassName = x.ProvidedForm!.CategoryEducationalClass?.EducationalClass!.EnglishName,
                                    IsAccepted = x.ProvidedForm!.IsAccepted!,
                                    PercentCompletion = x.ProvidedForm!.PercentCompletion,
                                    ArbitrationLevelForThisForm = ProvidedFormsInArbitrationResult.Contains(x.ProvidedFormId)
                                        ? ArbitrationLevelForForm.ArbitrationResult
                                        : (ProvidedFormsInFinalArbitration.Contains(x.ProvidedFormId)
                                            ? ArbitrationLevelForForm.FinalArbitration
                                            : (ProvidedFormsInArbitrationAudit.Contains(x.ProvidedFormId)
                                                ? ArbitrationLevelForForm.ArbitrationAudit
                                                : (ProvidedFormsInInitialArbitration.Contains(x.ProvidedFormId)
                                                    ? ArbitrationLevelForForm.InitialArbitration
                                                    : ArbitrationLevelForForm.ArbitrationSorting))),
                                    ArbitratorsForThisForm = AllArbitratorsAssigned
                                        .Where(y => y.ProvidedFormId == x.ProvidedFormId)
                                        .AsEnumerable()
                                        .Select(y => new ArbitratorsForForm()
                                        {
                                            ArbitratorId = y.ArbitratorId,
                                            ArbitratorName = Request.lang == "en"
                                                ? y.Arbitrator!.EnglishName
                                                : y.Arbitrator!.ArabicName
                                        }).ToList()
                                }
                                : new FormsListVMForArbitrationDto()
                                {
                                    Id = x.ProvidedFormId,
                                    CategoryName = x.ProvidedForm!.Category!.ArabicName,
                                    SubscriberName = SubscribersNames.FirstOrDefault(y => y.RecordId == x.ProvidedFormId)?.Value,
                                    EducationalClassName = x.ProvidedForm!.CategoryEducationalClass?.EducationalClass!.ArabicName,
                                    IsAccepted = x.ProvidedForm!.IsAccepted!,
                                    PercentCompletion = x.ProvidedForm!.PercentCompletion,
                                    ArbitrationLevelForThisForm = ProvidedFormsInArbitrationResult.Contains(x.ProvidedFormId)
                                        ? ArbitrationLevelForForm.ArbitrationResult
                                        : (ProvidedFormsInFinalArbitration.Contains(x.ProvidedFormId)
                                            ? ArbitrationLevelForForm.FinalArbitration
                                            : (ProvidedFormsInArbitrationAudit.Contains(x.ProvidedFormId)
                                                ? ArbitrationLevelForForm.ArbitrationAudit
                                                : (ProvidedFormsInInitialArbitration.Contains(x.ProvidedFormId)
                                                    ? ArbitrationLevelForForm.InitialArbitration
                                                    : ArbitrationLevelForForm.ArbitrationSorting))),
                                    ArbitratorsForThisForm = AllArbitratorsAssigned
                                        .Where(y => y.ProvidedFormId == x.ProvidedFormId)
                                        .AsEnumerable()
                                        .Select(y => new ArbitratorsForForm()
                                        {
                                            ArbitratorId = y.ArbitratorId,
                                            ArbitratorName = Request.lang == "en"
                                                ? y.Arbitrator!.EnglishName
                                                : y.Arbitrator!.ArabicName
                                        }).ToList()
                                }).ToList()
                    };

                    return new BaseResponse<GetArbitratrionDataByArbitratorIdDto>(ResponseMessage, true, 200, Response, PaginationParameter);
                }
            }
        }
    }
}
