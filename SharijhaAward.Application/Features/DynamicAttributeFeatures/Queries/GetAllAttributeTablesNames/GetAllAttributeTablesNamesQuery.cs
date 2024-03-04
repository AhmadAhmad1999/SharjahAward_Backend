using MediatR;
using SharijhaAward.Application.Responses;
namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetAllAttributeTablesNames
{
    public class GetAllAttributeTablesNamesQuery : IRequest<BaseResponse<List<GetAllAttributeTablesNamesListVM>>>
    {
        public string lang { get; set; } = string.Empty;
        public int page { get; set; }
        public int pageSize { get; set; }
    }
}
