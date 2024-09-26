using MediatR;
using SharijhaAward.Application.Features.Classes.Queries.GetAllClasses;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Queries.GetAllVirtualTables
{
    public class GetAllVirtualTablesQuery : IRequest<BaseResponse<List<GetAllVirtualTablesListVM>>>
    {
        public string? lang { get; set; }
        public List<Filter>? filters { get; set; }
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
    }
}
