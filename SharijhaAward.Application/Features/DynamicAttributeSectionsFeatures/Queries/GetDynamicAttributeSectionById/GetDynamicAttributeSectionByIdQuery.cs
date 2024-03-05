using MediatR;
using SharijhaAward.Application.Responses;
namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetDynamicAttributeSectionById
{
    public class GetDynamicAttributeSectionByIdQuery : IRequest<BaseResponse<GetDynamicAttributeSectionByIdDto>>
    {
        public int Id { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
