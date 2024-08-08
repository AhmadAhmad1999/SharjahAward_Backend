using MediatR;
using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Commands.CreateDynamicAttributeSection
{
    public class CreateDynamicAttributeSectionCommand : IRequest<BaseResponse<CreateDynamicAttributeSectionResponse>>
    {
        [ArabicNameValidation(ErrorMessage = "Arabic name must only contain Arabic characters.")]
        public string ArabicName { get; set; } = null!;
        [EnglishNameValidation(ErrorMessage = "English name must only contain English characters.")]
        public string EnglishName { get; set; } = null!;
        public int AttributeTableNameId { get; set; }
        public int? RecordIdOnRelation { get; set; }
        public bool TableTypeSection { get; set; }
        public int? MinNumberOfRows { get; set; }
        public int? MaxNumberOfRows { get; set; }
        public string? lang { get; set; }
    }
}
