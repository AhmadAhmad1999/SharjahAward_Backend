using SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.CreateDynamicAttribute;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Commands.CreateDynamicAttributeSection
{
    public class CreateDynamicAttributeSectionCommandResponse : BaseResponse
    {
        public CreateDynamicAttributeSectionCommandResponse() : base() { }
        public CreateDynamicAttributeSectionDto CreateDynamicAttributeSectionDto { get; set; }
    }
}
