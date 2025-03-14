﻿using MediatR;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.CreateDynamicAttribute;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.UpdateDynamicAttribute
{
    public class UpdateDynamicAttributeCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
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
        public List<UpdateDynamicAttributeValueDto>? Values { get; set; }
        public CreateGeneralValidation? GeneralValidationObject { get; set; }
        public List<CreateDependencyValidation>? DependencyValidations { get; set; }
        public List<ViewWhenDto>? ViewWhenDtos { get; set; }
        public string? lang { get; set; }
    }
}
