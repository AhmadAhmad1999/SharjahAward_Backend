using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderPatterns.Queries.GetAdvancedFormBuilderPatternById
{
    public class GetAdvancedFormBuilderPatternByIdQuery : IRequest<BaseResponse<GetAdvancedFormBuilderPatternByIdDto>>
    {
        public int Id { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
