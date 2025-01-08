using MediatR;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.CreateDynamicAttribute;
using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Commands.CreateAdvancedFormBuilder
{
    public class CreateAdvancedFormBuilderCommand : IRequest<BaseResponse<object>>
    {
        [ArabicNameValidation]
        public string ArabicLabel { get; set; } = null!;
        [EnglishNameValidation]
        public string EnglishLabel { get; set; } = null!;
        [ArabicNameValidation]
        public string ArabicPlaceHolder { get; set; } = null!;
        [EnglishNameValidation]
        public string EnglishPlaceHolder { get; set; } = null!;
        public bool IsRequired { get; set; } = false;
        public bool IsUnique { get; set; } = false;
        public bool LinkedToAnotherAttribute { get; set; } = false;
        public int AttributeDataTypeId { get; set; }
        public int AdvancedFormBuilderSectionId { get; set; }
        public int? MaxSizeInKB { get; set; }
        public bool ViewInTable { get; set; }
        public List<DynamicAttrbiuteValuesDto>? Values { get; set; }
        public CreateGeneralValidation? GeneralValidationObject { get; set; }
        public List<CreateDependencyValidation>? DependencyValidations { get; set; }
        public List<ViewWhenDto>? ViewWhenDtos { get; set; }
        public string? lang { get; set; }
    }
}
