using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllProvidedForms;
using SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllProvidedFormsForAllSubscriber;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.AttachmentModel;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.ConditionsProvidedFormsModel;
using SharijhaAward.Domain.Entities.CoordinatorModel;
using SharijhaAward.Domain.Entities.CriterionItemModel;
using SharijhaAward.Domain.Entities.CriterionModel;
using SharijhaAward.Domain.Entities.CycleConditionsProvidedFormModel;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.EducationalEntityModel;
using SharijhaAward.Domain.Entities.EducationCoordinatorModel;
using SharijhaAward.Domain.Entities.ExtraAttachmentModel;
using SharijhaAward.Domain.Entities.ExtraAttachmentProvidedFormModel;
using SharijhaAward.Domain.Entities.FinalArbitrationModel;
using SharijhaAward.Domain.Entities.SystemAttachmentModel;

namespace SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllFormsForAllSubscriber
{
    public class GetAllFormsForAllSubscriberQueryHandler
        : IRequestHandler<GetAllFormsForAllSubscriberQuery, BaseResponse<List<FormListVm>>>
    {
        private readonly IUserRepository _UserRepository;
        private readonly IAsyncRepository<Category> _CategoryRepository;
        private readonly IAsyncRepository<Cycle> _CycleRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _FormRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IAsyncRepository<FinalArbitration> _FinalArbitrationRepository;
        private readonly IAsyncRepository<Coordinator> _CoordinatorRepository;
        private readonly IAsyncRepository<EduEntitiesCoordinator> _EduEntitiesCoordinatorRepository;
        private readonly IAsyncRepository<DynamicAttributeListValue> _DynamicAttributeListValueRepository;
        private readonly IAsyncRepository<EducationalEntity> _EducationalEntityRepository;
        private readonly IAsyncRepository<CriterionAttachment> _CriterionAttachmentRepository;
        private readonly IAsyncRepository<CriterionItemAttachment> _CriterionItemAttachmentRepository;
        private readonly IAsyncRepository<CycleConditionsProvidedForm> _cycleConditionsProvidedFormRepository;
        private readonly IAsyncRepository<ConditionsProvidedForms> _conditionsProvidedFormsRepository;
        private readonly IAsyncRepository<ExtraAttachment> _extraAttachmentRepository;
        private readonly IAsyncRepository<CycleConditionAttachment> _CycleConditionAttachmentRepository;
        private readonly IAsyncRepository<ConditionAttachment> _ConditionAttachmentRepository;
        private readonly IAsyncRepository<ExtraAttachmentFile> _ExtraAttachmentFileRepository;
        private readonly IJwtProvider _JwtProvider;

        public GetAllFormsForAllSubscriberQueryHandler(IAsyncRepository<Cycle> CycleRepository, IUserRepository UserRepository,
            IAsyncRepository<Category> CategoryRepository,
            IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> FormRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository,
            IAsyncRepository<FinalArbitration> FinalArbitrationRepository,
            IAsyncRepository<Coordinator> CoordinatorRepository,
            IAsyncRepository<EduEntitiesCoordinator> EduEntitiesCoordinatorRepository,
            IAsyncRepository<DynamicAttributeListValue> DynamicAttributeListValueRepository,
            IAsyncRepository<EducationalEntity> EducationalEntityRepository,
            IAsyncRepository<ExtraAttachment> extraAttachmentRepository,
            IJwtProvider JwtProvider,
            IAsyncRepository<CriterionAttachment> CriterionAttachmentRepository,
            IAsyncRepository<CriterionItemAttachment> CriterionItemAttachmentRepository,
            IAsyncRepository<ConditionsProvidedForms> conditionsProvidedFormsRepository,
            IAsyncRepository<CycleConditionsProvidedForm> cycleConditionsProvidedFormRepository,
            IAsyncRepository<CycleConditionAttachment> CycleConditionAttachmentRepository,
            IAsyncRepository<ConditionAttachment> ConditionAttachmentRepository,
            IAsyncRepository<ExtraAttachmentFile> ExtraAttachmentFileRepository)
        {
            _UserRepository = UserRepository;
            _CategoryRepository = CategoryRepository;
            _CycleRepository = CycleRepository;
            _FormRepository = FormRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
            _FinalArbitrationRepository = FinalArbitrationRepository;
            _CoordinatorRepository = CoordinatorRepository;
            _EduEntitiesCoordinatorRepository = EduEntitiesCoordinatorRepository;
            _DynamicAttributeListValueRepository = DynamicAttributeListValueRepository;
            _EducationalEntityRepository = EducationalEntityRepository;
            _JwtProvider = JwtProvider;
            _CriterionAttachmentRepository = CriterionAttachmentRepository;
            _CriterionItemAttachmentRepository = CriterionItemAttachmentRepository;
            _cycleConditionsProvidedFormRepository = cycleConditionsProvidedFormRepository;
            _conditionsProvidedFormsRepository = conditionsProvidedFormsRepository;
            _extraAttachmentRepository = extraAttachmentRepository;
            _CycleConditionAttachmentRepository = CycleConditionAttachmentRepository;
            _ConditionAttachmentRepository = ConditionAttachmentRepository;
            _ExtraAttachmentFileRepository = ExtraAttachmentFileRepository;
        }

        public async Task<BaseResponse<List<FormListVm>>> Handle(GetAllFormsForAllSubscriberQuery request, CancellationToken cancellationToken)
        {
            FilterObject filterObject = new FilterObject() { Filters = request.filters };

            var cycle = await _CycleRepository.FirstOrDefaultAsync(c => c.Status == Domain.Constants.Common.Status.Active);

            if (cycle != null)
            {
                int UserId = int.Parse(_JwtProvider.GetUserIdFromToken(request.Token!));

                Coordinator? CoordinatorEntity = await _CoordinatorRepository
                    .FirstOrDefaultAsync(x => x.Id == UserId);

                if (CoordinatorEntity is null)
                {
                    var SubCategories = await _CategoryRepository
                        .Where(c => c.CycleId == cycle!.Id && c.ParentId != null)
                        .Select(c => c.Id)
                        .ToListAsync();

                    var forms = await _FormRepository
                        .Where(f => f.Category.CycleId == cycle.Id)
                        .ToListAsync();

                    var Subscribers = await _UserRepository
                        .Where(s => s.SubscriberId != null)
                        .ToListAsync();

                    if (forms.Any())
                    {
                        List<FinalArbitration> GetAllFromsInFinalArbitration = await _FinalArbitrationRepository
                            .Where(x => forms.Select(y => y.Id).Contains(x.ProvidedFormId))
                            .ToListAsync();

                        var SubscribersNames = await _DynamicAttributeValueRepository
                            .Where(x => forms.Select(y => y.Id).Any(y => y == x.RecordId) &&
                                x.DynamicAttribute!.DynamicAttributeSection!.EnglishName == "Main Information" &&
                                x.DynamicAttribute!.EnglishTitle == "Full name (identical to Emirates ID)")
                            .ToListAsync();

                        var CategoriesIds = forms.Select(y => y.categoryId).AsEnumerable();

                        var Categories = _CategoryRepository
                            .Where(x => CategoriesIds.Contains(x.Id))
                            .Include(x => x.Parent!)
                            .AsEnumerable();


                        var data = request.SubscriberName == null
                            ? forms.AsEnumerable().Select(x => new FormListVm()
                            {
                                Id = x.Id,
                                SubscriberName = (SubscribersNames.Select(y => y.RecordId).Contains(x.Id) && SubscribersNames.Any())
                                ? SubscribersNames.FirstOrDefault(y => y.RecordId == x.Id)!.Value
                                : null,
                                subscriberCode = (Subscribers.Select(s => s.Id).Contains(x.userId) && Subscribers.Any())
                                ? Subscribers.FirstOrDefault(s => s.Id == x.userId)!.SubscriberId
                                : null,
                                PercentCompletion = x.PercentCompletion,
                                CycleNumber = x.CycleNumber,
                                CycleYear = x.CycleYear,
                                Type = x.Type,
                                Status = x.Status,
                                SubscriberType = x.SubscriberType,
                                CurrentStep = x.CurrentStep,
                                TotalStep = x.TotalStep,
                                FinalScore = x.FinalScore,
                                IsAccepted = x.IsAccepted,
                                ReasonOfRejection = x.ReasonOfRejection!,
                                categoryId = x.categoryId,
                                CreatedAt = x.CreatedAt,
                                CategoryName = request.lang == "en"
                                ? Categories.FirstOrDefault(y => y.Id == x.categoryId)!.Parent!.EnglishName
                                : Categories.FirstOrDefault(y => y.Id == x.categoryId)!.Parent!.ArabicName,
                                SubCategoryName = request.lang == "en"
                                ? Categories.FirstOrDefault(y => y.Id == x.categoryId)!.EnglishName
                                : Categories.FirstOrDefault(y => y.Id == x.categoryId)!.ArabicName,
                                SucceedToFinalArbitration = GetAllFromsInFinalArbitration
                                .AsEnumerable()
                                .Select(y => y.ProvidedFormId)
                                .Contains(x.Id)
                            }).ToList()
                          : forms.AsEnumerable().Select(x => new FormListVm()
                          {
                              Id = x.Id,
                              SubscriberName = (SubscribersNames.Select(y => y.RecordId).Contains(x.Id) && SubscribersNames.Any())
                                ? SubscribersNames.FirstOrDefault(y => y.RecordId == x.Id)!.Value
                                : null,
                              subscriberCode = (Subscribers.Select(s => s.Id).Contains(x.userId) && Subscribers.Any())
                                ? Subscribers.FirstOrDefault(s => s.Id == x.userId)!.SubscriberId
                                : null,
                              PercentCompletion = x.PercentCompletion,
                              CycleNumber = x.CycleNumber,
                              CycleYear = x.CycleYear,
                              Type = x.Type,
                              Status = x.Status,
                              SubscriberType = x.SubscriberType,
                              CurrentStep = x.CurrentStep,
                              TotalStep = x.TotalStep,
                              FinalScore = x.FinalScore,
                              IsAccepted = x.IsAccepted,
                              ReasonOfRejection = x.ReasonOfRejection!,
                              categoryId = x.categoryId,
                              CreatedAt = x.CreatedAt,
                              CategoryName = request.lang == "en"
                                ? Categories.FirstOrDefault(y => y.Id == x.categoryId)!.Parent!.EnglishName
                                : Categories.FirstOrDefault(y => y.Id == x.categoryId)!.Parent!.ArabicName,
                              SubCategoryName = request.lang == "en"
                                ? Categories.FirstOrDefault(y => y.Id == x.categoryId)!.EnglishName
                                : Categories.FirstOrDefault(y => y.Id == x.categoryId)!.ArabicName,
                              SucceedToFinalArbitration = GetAllFromsInFinalArbitration
                                .AsEnumerable()
                                .Select(y => y.ProvidedFormId)
                                .Contains(x.Id)
                          })
                          .Where(x => x.SubscriberName!.Contains(request.SubscriberName))
                          .ToList();

                        List<CycleConditionAttachment> AllCycleConditionAttachmentEntities = await _CycleConditionAttachmentRepository
                            .Where(x => forms.Select(y => y.Id).Contains(x.CycleConditionsProvidedForm!.ProvidedFormId) &&
                                x.CycleConditionsProvidedForm!.CycleCondition!.NeedAttachment &&
                                (x.IsAccept != null ? !x.IsAccept.Value : false))
                            .ToListAsync();

                        List<ConditionAttachment> AllConditionAttachmentEntities = await _ConditionAttachmentRepository
                            .Where(x => forms.Select(y => y.Id).Contains(x.ConditionsProvidedForms!.ProvidedFormId) &&
                                x.ConditionsProvidedForms.TermAndCondition.NeedAttachment &&
                                (x.IsAccept != null ? !x.IsAccept.Value : false))
                            .ToListAsync();

                        List<ExtraAttachmentFile> AllExtraAttachmentFileEntities = await _ExtraAttachmentFileRepository
                            .Where(x => forms.Select(y => y.Id).Contains(x.ExtraAttachment!.ProvidedFormId) &&
                                (x.IsAccept != null ? !x.IsAccept.Value : false))
                            .ToListAsync();

                        List<DynamicAttributeValue> AllDynamicAttributeValueEntities = await _DynamicAttributeValueRepository
                            .Where(x => (x.isAccepted != null ? !x.isAccepted.Value : false) &&
                                data.Select(y => y.Id).Any(y => y == x.RecordId) &&
                                x.DynamicAttribute!.DynamicAttributeSection!.AttributeTableNameId == 1)
                            .ToListAsync();

                        List<CriterionAttachment> AllCriterionAttachmentEntities = await _CriterionAttachmentRepository
                            .Where(x => data.Select(y => y.Id).Contains(x.ProvidedFormId) &&
                                (x.IsAccepted != null ? !x.IsAccepted.Value : false))
                            .ToListAsync();

                        List<CriterionItemAttachment> AllCriterionItemAttachmentEntities = await _CriterionItemAttachmentRepository
                            .Where(x => data.Select(y => y.Id).Contains(x.ProvidedFormId) &&
                                (x.IsAccepted != null ? !x.IsAccepted.Value : false))
                            .ToListAsync();

                        for (int i = 0; i < data.Count(); i++)
                        {
                            data[i].RejectedSteps = new List<int>();

                            var cycleConditions = AllCycleConditionAttachmentEntities
                                .Where(c => c.CycleConditionsProvidedForm.ProvidedFormId == forms[i].Id)
                                .ToList();

                            if (cycleConditions.Any())
                                data[i].RejectedSteps!.Add(1);

                            var TermAndConditions = AllConditionAttachmentEntities
                                .Where(c => c.ConditionsProvidedForms!.ProvidedFormId == forms[i].Id)
                                .ToList();

                            if (TermAndConditions.Any())
                                data[i].RejectedSteps!.Add(3);

                            var ExtraAttachments = AllExtraAttachmentFileEntities
                                .Where(e => e.ExtraAttachment!.ProvidedFormId == forms[i].Id)
                                .ToList();

                            if (ExtraAttachments.Any())
                                data[i].RejectedSteps!.Add(6);

                            bool CheckIfThereIsRejectedDynamicFields = AllDynamicAttributeValueEntities
                                .Any(x => x.RecordId == data[i].Id);

                            if (CheckIfThereIsRejectedDynamicFields)
                                data[i].RejectedSteps!.Add(4);

                            bool CriterionAttachment = AllCriterionAttachmentEntities
                                .Any(x => x.ProvidedFormId == data[i].Id);

                            if (CriterionAttachment)
                                data[i].RejectedSteps!.Add(5);

                            bool CriterionItemAttachment = AllCriterionItemAttachmentEntities
                                .Any(x => x.ProvidedFormId == data[i].Id);

                            if (CriterionItemAttachment)
                                data[i].RejectedSteps!.Add(5);

                            if (data[i].RejectedSteps!.Count() > 0)
                            {
                                forms[i].needSing = true;

                                await _FormRepository.UpdateAsync(forms[i]);
                            }
                        }

                        int count = _FormRepository.GetCount(f => !f.isDeleted);

                        Pagination pagination = new Pagination(request.page, request.perPage, count);

                        return new BaseResponse<List<FormListVm>>("", true, 200, data, pagination);
                    }
                    else
                    {
                        return new BaseResponse<List<FormListVm>>("", true, 200, new List<FormListVm>());
                    }
                }
                else
                {
                    var SubCategories = await _CategoryRepository
                        .Where(c => c.CycleId == cycle!.Id && c.ParentId != null)
                        .Select(c => c.Id)
                        .ToListAsync();

                    var forms = await _FormRepository
                        .Where(f => f.Category.CycleId == cycle.Id)
                        .ToListAsync();

                    List<int> EduEntitiesIds = await _EduEntitiesCoordinatorRepository
                        .Where(x => x.CoordinatorId == UserId)
                        .Select(x => x.EducationalEntityId)
                        .ToListAsync();

                    List<DynamicAttributeValue> DynamicAttributeValueEtities = await _DynamicAttributeValueRepository
                        .Where(x => forms.Select(y => y.Id).Any(y => y == x.RecordId) &&
                            x.DynamicAttribute!.EnglishTitle.ToLower() == "Educational Entity".ToLower())
                        .ToListAsync();

                    List<DynamicAttributeListValue> DynamicAttributeListValueEntities = await _DynamicAttributeListValueRepository
                        .Where(x => DynamicAttributeValueEtities.Select(y => int.Parse(y.Value))
                            .Contains(x.Id))
                        .ToListAsync();

                    var EducationalEntities = _EducationalEntityRepository
                        .AsEnumerable() // Switch to client-side evaluation
                        .Where(x => DynamicAttributeListValueEntities
                            .Any(y => y.EnglishValue.ToLower() == x.EnglishName.ToLower() &&
                                      y.ArabicValue.ToLower() == x.ArabicName.ToLower()))
                        .Select(x => new
                        {
                            DynamicAttributeListValueEntities
                                .FirstOrDefault(y => y.EnglishValue.ToLower() == x.EnglishName.ToLower() &&
                                    y.ArabicValue.ToLower() == x.ArabicName.ToLower())!.Id,
                            EducationalEntityObject = x
                        }).ToList();

                    forms = forms
                        .Where(x => DynamicAttributeValueEtities.Select(y => y.RecordId).Contains(x.Id))
                        .ToList();

                    var Subscribers = await _UserRepository
                        .Where(s => s.SubscriberId != null)
                        .ToListAsync();

                    if (forms.Any())
                    {
                        List<FinalArbitration> GetAllFromsInFinalArbitration = await _FinalArbitrationRepository
                            .Where(x => forms.Select(y => y.Id).Contains(x.ProvidedFormId))
                            .ToListAsync();

                        var SubscribersNames = await _DynamicAttributeValueRepository
                            .Where(x => forms.Select(y => y.Id).Any(y => y == x.RecordId) &&
                                x.DynamicAttribute!.DynamicAttributeSection!.EnglishName == "Main Information" &&
                                x.DynamicAttribute!.EnglishTitle == "Full name (identical to Emirates ID)")
                            .ToListAsync();

                        var CategoriesIds = forms.Select(y => y.categoryId).AsEnumerable();

                        var Categories = _CategoryRepository
                            .Where(x => CategoriesIds.Contains(x.Id))
                            .Include(x => x.Parent!)
                            .AsEnumerable();

                        var data = forms.AsEnumerable().Select(x => new FormListVm()
                        {
                            Id = x.Id,
                            SubscriberName = (SubscribersNames.Select(y => y.RecordId).Contains(x.Id) && SubscribersNames.Any())
                                ? SubscribersNames.FirstOrDefault(y => y.RecordId == x.Id)!.Value
                                : null,
                            subscriberCode = (Subscribers.Select(s => s.Id).Contains(x.userId) && Subscribers.Any())
                                ? Subscribers.FirstOrDefault(s => s.Id == x.userId)!.SubscriberId
                                : null,
                            PercentCompletion = x.PercentCompletion,
                            CycleNumber = x.CycleNumber,
                            CycleYear = x.CycleYear,
                            Type = x.Type,
                            Status = x.Status,
                            SubscriberType = x.SubscriberType,
                            CurrentStep = x.CurrentStep,
                            TotalStep = x.TotalStep,
                            FinalScore = x.FinalScore,
                            IsAccepted = x.IsAccepted,
                            ReasonOfRejection = x.ReasonOfRejection!,
                            categoryId = x.categoryId,
                            CreatedAt = x.CreatedAt,
                            CategoryName = request.lang == "en"
                                ? Categories.FirstOrDefault(y => y.Id == x.categoryId)!.Parent!.EnglishName
                                : Categories.FirstOrDefault(y => y.Id == x.categoryId)!.Parent!.ArabicName,
                            SubCategoryName = request.lang == "en"
                                ? Categories.FirstOrDefault(y => y.Id == x.categoryId)!.EnglishName
                                : Categories.FirstOrDefault(y => y.Id == x.categoryId)!.ArabicName,
                            SucceedToFinalArbitration = GetAllFromsInFinalArbitration
                                .AsEnumerable()
                                .Select(y => y.ProvidedFormId)
                                .Contains(x.Id)
                        }).ToList();

                        List<CycleConditionAttachment> AllCycleConditionAttachmentEntities = await _CycleConditionAttachmentRepository
                            .Where(x => forms.Select(y => y.Id).Contains(x.CycleConditionsProvidedForm!.ProvidedFormId) &&
                                x.CycleConditionsProvidedForm!.CycleCondition!.NeedAttachment &&
                                (x.IsAccept != null ? !x.IsAccept.Value : false))
                            .ToListAsync();

                        List<ConditionAttachment> AllConditionAttachmentEntities = await _ConditionAttachmentRepository
                            .Where(x => forms.Select(y => y.Id).Contains(x.ConditionsProvidedForms!.ProvidedFormId) &&
                                x.ConditionsProvidedForms.TermAndCondition.NeedAttachment &&
                                (x.IsAccept != null ? !x.IsAccept.Value : false))
                            .ToListAsync();

                        List<ExtraAttachmentFile> AllExtraAttachmentFileEntities = await _ExtraAttachmentFileRepository
                            .Where(x => forms.Select(y => y.Id).Contains(x.ExtraAttachment!.ProvidedFormId) &&
                                (x.IsAccept != null ? !x.IsAccept.Value : false))
                            .ToListAsync();

                        List<DynamicAttributeValue> AllDynamicAttributeValueEntities = await _DynamicAttributeValueRepository
                            .Where(x => (x.isAccepted != null ? !x.isAccepted.Value : false) &&
                                data.Select(y => y.Id).Any(y => y == x.RecordId) &&
                                x.DynamicAttribute!.DynamicAttributeSection!.AttributeTableNameId == 1)
                            .ToListAsync();

                        List<CriterionAttachment> AllCriterionAttachmentEntities = await _CriterionAttachmentRepository
                            .Where(x => data.Select(y => y.Id).Contains(x.ProvidedFormId) &&
                                (x.IsAccepted != null ? !x.IsAccepted.Value : false))
                            .ToListAsync();

                        List<CriterionItemAttachment> AllCriterionItemAttachmentEntities = await _CriterionItemAttachmentRepository
                            .Where(x => data.Select(y => y.Id).Contains(x.ProvidedFormId) &&
                                (x.IsAccepted != null ? !x.IsAccepted.Value : false))
                            .ToListAsync();

                        for (int i = 0; i < data.Count(); i++)
                        {
                            data[i].RejectedSteps = new List<int>();

                            var cycleConditions = AllCycleConditionAttachmentEntities
                                .Where(c => c.CycleConditionsProvidedForm.ProvidedFormId == forms[i].Id)
                                .ToList();

                            if (cycleConditions.Any())
                                data[i].RejectedSteps!.Add(1);

                            var TermAndConditions = AllConditionAttachmentEntities
                                .Where(c => c.ConditionsProvidedForms!.ProvidedFormId == forms[i].Id)
                                .ToList();

                            if (TermAndConditions.Any())
                                data[i].RejectedSteps!.Add(3);

                            var ExtraAttachments = AllExtraAttachmentFileEntities
                                .Where(e => e.ExtraAttachment!.ProvidedFormId == forms[i].Id)
                                .ToList();

                            if (ExtraAttachments.Any())
                                data[i].RejectedSteps!.Add(6);

                            bool CheckIfThereIsRejectedDynamicFields = AllDynamicAttributeValueEntities
                                .Any(x => x.RecordId == data[i].Id);

                            if (CheckIfThereIsRejectedDynamicFields)
                                data[i].RejectedSteps!.Add(4);

                            bool CriterionAttachment = AllCriterionAttachmentEntities
                                .Any(x => x.ProvidedFormId == data[i].Id);

                            if (CriterionAttachment)
                                data[i].RejectedSteps!.Add(5);

                            bool CriterionItemAttachment = AllCriterionItemAttachmentEntities
                                .Any(x => x.ProvidedFormId == data[i].Id);

                            if (CriterionItemAttachment)
                                data[i].RejectedSteps!.Add(5);

                            if (data[i].RejectedSteps!.Count() > 0)
                            {
                                forms[i].needSing = true;

                                await _FormRepository.UpdateAsync(forms[i]);
                            }
                        }

                        int count = _FormRepository.GetCount(f => !f.isDeleted);

                        Pagination pagination = new Pagination(request.page, request.perPage, count);

                        return new BaseResponse<List<FormListVm>>("", true, 200, data, pagination);
                    }
                    else
                    {
                        return new BaseResponse<List<FormListVm>>("", true, 200, new List<FormListVm>());
                    }
                }
            }
            else
            {
                return new BaseResponse<List<FormListVm>>("", true, 200, new List<FormListVm>());
            }
        }
    }
}
