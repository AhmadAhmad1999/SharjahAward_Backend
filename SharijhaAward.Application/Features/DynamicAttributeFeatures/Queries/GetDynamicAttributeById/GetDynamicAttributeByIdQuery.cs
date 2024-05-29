using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetDynamicAttributeById
{
    public class GetDynamicAttributeByIdQuery : IRequest<BaseResponse<GetDynamicAttributeByIdDto>>
    {
        public int Id { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
