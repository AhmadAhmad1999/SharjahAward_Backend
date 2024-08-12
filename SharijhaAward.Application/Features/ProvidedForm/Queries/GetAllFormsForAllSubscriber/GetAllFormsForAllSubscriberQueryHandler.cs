using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllProvidedForms;
using SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllProvidedFormsForAllSubscriber;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.CoordinatorModel;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.EducationalEntityModel;
using SharijhaAward.Domain.Entities.EducationCoordinatorModel;
using SharijhaAward.Domain.Entities.FinalArbitrationModel;

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
            IJwtProvider JwtProvider)
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
        }

        public async Task<BaseResponse<List<FormListVm>>> Handle(GetAllFormsForAllSubscriberQuery request, CancellationToken cancellationToken)
        {
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
                        .Include(f => f.Category)
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
                            .Include(x => x.DynamicAttribute!)
                            .Include(x => x.DynamicAttribute!.DynamicAttributeSection!)
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
                        .Include(f => f.Category)
                        .Where(f => f.Category.CycleId == cycle.Id)
                        .ToListAsync();

                    List<int> EduEntitiesIds = await _EduEntitiesCoordinatorRepository
                            .Where(x => x.CoordinatorId == UserId)
                            .Include(x => x.EducationalEntity!)
                            .Select(x => x.EducationalEntityId)
                            .ToListAsync();

                    List<DynamicAttributeValue> DynamicAttributeValueEtities = await _DynamicAttributeValueRepository
                        .Include(x => x.DynamicAttribute!)
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
                            .Include(x => x.DynamicAttribute!)
                            .Include(x => x.DynamicAttribute!.DynamicAttributeSection!)
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
