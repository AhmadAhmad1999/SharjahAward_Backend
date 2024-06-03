using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetAllListDynamicAttributes
{
    public class GetAllListDynamicAttributesQuery : IRequest<BaseResponse<List<GetAllListDynamicAttributesListVM>>>
    {
        public int SectionId { get; set; }
        public string? lang { get; set; }
    }
}
