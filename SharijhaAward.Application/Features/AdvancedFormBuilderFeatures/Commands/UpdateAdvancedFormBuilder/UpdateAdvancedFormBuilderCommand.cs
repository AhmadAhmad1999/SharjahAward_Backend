using MediatR;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.CreateDynamicAttribute;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Commands.UpdateAdvancedFormBuilder
{
    public class UpdateAdvancedFormBuilderCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string ArabicLabel { get; set; } = null!;
        public string EnglishLabel { get; set; } = null!;
        public string ArabicPlaceHolder { get; set; } = null!;
        public string EnglishPlaceHolder { get; set; } = null!;
        public bool IsRequired { get; set; }
        public List<UpdateAdvancedFormBuilderValueDto>? Values { get; set; }
        public int? MaxSizeInKB { get; set; }
        public string? lang { get; set; }
        public bool IsUnique { get; set; } = false;
        public bool LinkedToAnotherAttribute { get; set; } = false;
        public int AttributeDataTypeId { get; set; }
        public CreateGeneralValidation? GeneralValidationObject { get; set; }
        public List<CreateDependencyValidation>? DependencyValidations { get; set; }
        public List<ViewWhenDto>? ViewWhenDtos { get; set; }
    }
}
