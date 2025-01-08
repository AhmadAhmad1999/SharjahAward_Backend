using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Queries.GetAllInputedAdvancedFormsByVirtualTableForSectionId
{
    public class GetAllInputedAdvancedFormsByVirtualTableForSectionIdQuery 
        : IRequest<BaseResponse<GetAllInputedAdvancedFormsByVirtualTableForSectionIdListVM>>
    {
        public string? lang { get; set; }
        public List<Filter>? filters { get; set; }
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
        public int VirtualTableForSectionId { get; set; }
        public bool ExportToExcel { get; set; }
    }
}