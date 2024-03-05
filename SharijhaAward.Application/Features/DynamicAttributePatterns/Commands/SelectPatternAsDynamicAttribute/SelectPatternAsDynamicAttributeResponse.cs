using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Commands.CreateDynamicAttributeSection;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.DynamicAttributePatterns.Commands.SelectPatternAsDynamicAttribute
{
    public class SelectPatternAsDynamicAttributeResponse : BaseResponse<object>
    {
        public SelectPatternAsDynamicAttributeResponse() : base() { }
        public SelectPatternAsDynamicAttributeDto DynamicAttributePatternDto { get; set; }
    }
}
