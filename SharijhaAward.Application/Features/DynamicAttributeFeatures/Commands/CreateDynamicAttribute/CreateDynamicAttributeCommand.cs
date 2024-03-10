using MediatR;
using SharijhaAward.Application.Features.Event.Commands.CreateEvent;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.DynamicAttribute;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.CreateDynamicAttribute
{
    public class CreateDynamicAttributeCommand : IRequest<BaseResponse<CreateDynamicAttributeResponse>>
    {
        public string Key { get; set; } = null!;
        public string ArabicLabel { get; set; } = null!;
        public string EnglishLabel { get; set; } = null!;
        public string ArabicPlaceHolder { get; set; } = null!;
        public string EnglishPlaceHolder { get; set; } = null!;
        public bool IsRequired { get; set; } = false;
        public bool IsUnique { get; set; } = false;
        public bool LinkedToAnotherAttribute { get; set; } = false;
        public int AttributeDataTypeId { get; set; }
        public int DynamicAttributeSectionId { get; set; }
        public int? MaxSizeInKB { get; set; }
        public List<string>? Values { get; set; }
        public CreateGeneralValidation? GeneralValidationObject { get; set; }
        public List<CreateDependencyValidation>? DependencyValidations { get; set; }
        public string? lang { get; set; }
    }
}
