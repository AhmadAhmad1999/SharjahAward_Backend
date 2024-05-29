using MediatR;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.CreateDynamicAttribute;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Commands.CreateAdvancedFormBuilder
{
    public class CreateAdvancedFormBuilderCommand : IRequest<BaseResponse<object>>
    {
        public string ArabicLabel { get; set; } = null!;
        public string EnglishLabel { get; set; } = null!;
        public string ArabicPlaceHolder { get; set; } = null!;
        public string EnglishPlaceHolder { get; set; } = null!;
        public bool IsRequired { get; set; } = false;
        public bool IsUnique { get; set; } = false;
        public bool LinkedToAnotherAttribute { get; set; } = false;
        public int AttributeDataTypeId { get; set; }
        public int AdvancedFormBuilderSectionId { get; set; }
        public int? MaxSizeInKB { get; set; }
        public List<string>? Values { get; set; }
        public CreateGeneralValidation? GeneralValidationObject { get; set; }
        public List<CreateDependencyValidation>? DependencyValidations { get; set; }
        public string? lang { get; set; }
    }
}
