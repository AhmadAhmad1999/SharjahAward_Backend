using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.ArbitrationFeatures.Queries.GetArbitratrionDataByArbitratorId;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;

namespace SharijhaAward.Application.Features.ArbitrationFeatures.Queries.GetRemainingFormsWithFilters
{
    public class GetRemainingFormsWithFiltersHandler
        : IRequestHandler<GetRemainingFormsWithFiltersQuery, BaseResponse<List<FormsListVMForArbitrationDto>>>
    {
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        public GetRemainingFormsWithFiltersHandler(IAsyncRepository<Arbitration> ArbitrationRepository,
            IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> ProvidedFormRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository)
        {
            _ArbitrationRepository = ArbitrationRepository;
            _ProvidedFormRepository = ProvidedFormRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
        }
        public async Task<BaseResponse<List<FormsListVMForArbitrationDto>>> 
            Handle(GetRemainingFormsWithFiltersQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<Arbitration> AllArbitratorAssingedForms = await _ArbitrationRepository
                .Where(x => x.ArbitratorId == Request.ArbitratorId)
                .OrderByDescending(x => x.CreatedAt)
                .ToListAsync();

            List<DynamicAttributeValue> SubscribersNames = await _DynamicAttributeValueRepository
                .Where(x => x.DynamicAttribute!.DynamicAttributeSection!.EnglishName.ToLower() == "Main Information".ToLower() &&
                    x.DynamicAttribute!.DynamicAttributeSection!.AttributeTableNameId == 1 &&
                    AllArbitratorAssingedForms.Select(y => y.ProvidedFormId)
                        .Any(y => y == x.RecordId) &&
                    x.DynamicAttribute!.EnglishTitle.ToLower() == "Full name (identical to Emirates ID)".ToLower())
                .ToListAsync();

            List<FormsListVMForArbitrationDto> RemainingForms = await _ProvidedFormRepository
                .Where(x => x.PercentCompletion == 100 &&
                    !AllArbitratorAssingedForms.Select(y => y.ProvidedFormId).Contains(x.Id) &&
                    (!string.IsNullOrEmpty(Request.SubscriberName)
                        ? SubscribersNames.FirstOrDefault(y => y.RecordId == x.Id)!.Value.ToLower()
                            .StartsWith(Request.SubscriberName.ToLower())
                        : true) &&
                    (Request.ClassesIds.Count() > 0
                        ? (x.CategoryEducationalClassId != null
                            ? Request.ClassesIds.Any(y => y == x.CategoryEducationalClass!.EducationalClassId)
                            : false)
                        : true) &&
                    (Request.CategoriesIds.Count() > 0
                        ? Request.CategoriesIds.Any(y => y == x.categoryId)
                        : true) &&
                    (Request.FormId != null
                        ? x.Id == Request.FormId
                        : true))
                .OrderByDescending(x => x.CreatedAt)
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
                            : null
                    }
                    : new FormsListVMForArbitrationDto()
                    {
                        Id = x.Id,
                        CategoryName = x.Category!.ArabicName,
                        SubscriberName = SubscribersNames.FirstOrDefault(y => y.RecordId == x.Id) != null
                            ? SubscribersNames.FirstOrDefault(y => y.RecordId == x.Id)!.Value : null,
                        EducationalClassName = x.CategoryEducationalClass != null
                            ? x.CategoryEducationalClass!.EducationalClass!.ArabicName : null
                    }).ToListAsync();

            return new BaseResponse<List<FormsListVMForArbitrationDto>>(ResponseMessage, true, 200, RemainingForms);
        }
    }
}
