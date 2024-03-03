using SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.CreateDynamicAttribute;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Commands.CreateDynamicAttributeSection
{
    public class CreateDynamicAttributeSectionResponse : BaseResponse<object>
    {
        public CreateDynamicAttributeSectionResponse() : base() { }
        public CreateDynamicAttributeSectionDto CreateDynamicAttributeSectionDto { get; set; }
    }
}
