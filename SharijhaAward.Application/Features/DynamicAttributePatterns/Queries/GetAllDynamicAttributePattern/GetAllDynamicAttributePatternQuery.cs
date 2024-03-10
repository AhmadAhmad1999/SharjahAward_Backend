using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.DynamicAttributePatterns.Queries.GetAllDynamicAttributePattern
{
    public class GetAllDynamicAttributePatternQuery : IRequest<BaseResponse<List<GetAllDynamicAttributePatternListVM>>>
    {
        public string lang { get; set; } = string.Empty;
        public int page { get; set; }
        public int pageSize { get; set; }
    }
}
