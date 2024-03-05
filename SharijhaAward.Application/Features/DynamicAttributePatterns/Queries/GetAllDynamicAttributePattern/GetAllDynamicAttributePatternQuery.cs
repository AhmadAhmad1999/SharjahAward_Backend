using MediatR;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSections;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.DynamicAttributePatterns.Queries.GetAllDynamicAttributePattern
{
    public class GetAllDynamicAttributePatternQuery : IRequest<BaseResponse<List<GetAllDynamicAttributePatternListVM>>>
    {
        public string lang { get; set; } = string.Empty;
        public int page { get; set; }
        public int pageSize { get; set; }
    }
}
