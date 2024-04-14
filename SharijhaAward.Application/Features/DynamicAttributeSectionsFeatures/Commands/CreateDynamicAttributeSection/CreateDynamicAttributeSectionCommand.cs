using MediatR;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.CreateDynamicAttribute;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Commands.CreateDynamicAttributeSection
{
    public class CreateDynamicAttributeSectionCommand : IRequest<BaseResponse<CreateDynamicAttributeSectionResponse>>
    {
        public string ArabicName { get; set; } = null!;
        public string EnglishName { get; set; } = null!;
        public int AttributeTableNameId { get; set; }
        public int? RecordIdOnRelation { get; set; }
        public string? lang { get; set; }
    }
}
