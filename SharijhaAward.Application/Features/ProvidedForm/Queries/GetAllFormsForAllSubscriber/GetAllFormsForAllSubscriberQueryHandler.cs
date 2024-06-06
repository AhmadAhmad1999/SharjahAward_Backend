using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllProvidedForms;
using SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllProvidedFormsForAllSubscriber;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.FinalArbitrationModel;

namespace SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllFormsForAllSubscriber
{
    public class GetAllFormsForAllSubscriberQueryHandler
        : IRequestHandler<GetAllFormsForAllSubscriberQuery, BaseResponse<List<FormListVm>>>
    {
        private readonly IUserRepository _UserRepository;
        private readonly IAsyncRepository<Category> _CategoryRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _FormRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IAsyncRepository<FinalArbitration> _FinalArbitrationRepository;

        public GetAllFormsForAllSubscriberQueryHandler(IUserRepository UserRepository,
            IAsyncRepository<Category> CategoryRepository,
            IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> FormRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository,
            IAsyncRepository<FinalArbitration> FinalArbitrationRepository)
        {
            _UserRepository = UserRepository;
            _CategoryRepository = CategoryRepository;
            _FormRepository = FormRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
            _FinalArbitrationRepository = FinalArbitrationRepository;
        }

        public async Task<BaseResponse<List<FormListVm>>> Handle(GetAllFormsForAllSubscriberQuery request, CancellationToken cancellationToken)
        {
            var forms = await _FormRepository.GetPagedReponseAsync(request.page, request.pageSize);
            var Subscribers = await _UserRepository.Where(s => s.SubscriberId != null).ToListAsync();
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
                    .Select(x => new
                    {
                        x.RecordId,
                        x.Value
                    }).ToListAsync();

                var Categories = await _CategoryRepository
                    .Where(x => forms.Select(y => y.categoryId).Contains(x.Id))
                    .Include(x => x.Parent!).ToListAsync();

                var data = forms.Select(x => new FormListVm()
                {
                    Id = x.Id,
                    SubscriberName = SubscribersNames.FirstOrDefault(y => y.RecordId == x.Id) != null
                        ? SubscribersNames.FirstOrDefault(y => y.RecordId == x.Id)!.Value
                        : null,
                    subscriberCode = Subscribers.FirstOrDefault(s => s.Id == x.userId)!.SubscriberId,
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
                        .Any(y => y.ProvidedFormId == x.Id)
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
}
