using MediatR;
using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.EducationalEntities.Queries.GetAllEducationalEntities
{
    public class GetAllEducationalEntitiesCommand :IRequest<BaseResponse<List<EducationalEntitiesListVm>>>
    {
        [ArabicNameValidation]
        public string? ArabicName { get; set; } = string.Empty;
        [EnglishNameValidation]
        public string? EnglishName { get; set; } = string.Empty;
        public string? lang { get; set; }
    }
}
