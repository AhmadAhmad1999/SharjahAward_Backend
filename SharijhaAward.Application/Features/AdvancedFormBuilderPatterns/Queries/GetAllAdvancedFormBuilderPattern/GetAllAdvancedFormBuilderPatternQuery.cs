using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderPatterns.Queries.GetAllAdvancedFormBuilderPattern
{
    public class GetAllAdvancedFormBuilderPatternQuery : IRequest<BaseResponse<List<GetAllAdvancedFormBuilderPatternListVM>>>
    {
        public string lang { get; set; } = string.Empty;
        public int page { get; set; }
        public int pageSize { get; set; }
    }
}
