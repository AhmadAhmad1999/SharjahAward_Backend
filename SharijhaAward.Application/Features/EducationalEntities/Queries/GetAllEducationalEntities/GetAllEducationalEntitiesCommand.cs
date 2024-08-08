using MediatR;
using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.EducationalEntities.Queries.GetAllEducationalEntities
{
    public class GetAllEducationalEntitiesCommand :IRequest<BaseResponse<List<EducationalEntitiesListVm>>>
    {
        [ArabicNameValidation(ErrorMessage = "Arabic name must only contain Arabic characters.")]
        public string? ArabicName { get; set; } = string.Empty;
        [EnglishNameValidation(ErrorMessage = "English name must only contain English characters.")]
        public string? EnglishName { get; set; } = string.Empty;
        public string? lang { get; set; }
    }
}
