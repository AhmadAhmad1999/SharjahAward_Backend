using MediatR;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetDynamicAttributeSectionById;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.DynamicAttributePatterns.Queries.GetDynamicAttributePatternById
{
    public class GetDynamicAttributePatternByIdQuery : IRequest<BaseResponse<GetDynamicAttributePatternByIdDto>>
    {
        public int Id { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
