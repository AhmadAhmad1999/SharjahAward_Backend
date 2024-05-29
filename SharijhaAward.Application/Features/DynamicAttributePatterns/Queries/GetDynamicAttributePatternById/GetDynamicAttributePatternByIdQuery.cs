using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.DynamicAttributePatterns.Queries.GetDynamicAttributePatternById
{
    public class GetDynamicAttributePatternByIdQuery : IRequest<BaseResponse<GetDynamicAttributePatternByIdDto>>
    {
        public int Id { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
