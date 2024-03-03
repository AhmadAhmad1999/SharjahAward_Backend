using MediatR;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Commands.CreateDynamicAttributeSection;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.DynamicAttributeListValues.Commands.CreateDynamicAttributeListValue
{
    public class CreateDynamicAttributeListValueCommand : IRequest<BaseResponse<CreateDynamicAttributeListValueResponse>>
    {
        public string Value { get; set; } = null!;
        public int DynamicAttributeId { get; set; }
        public string? lang { get; set; }
    }
}
