using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderSectionsFeatures.Queries.GetAllAdvancedFormBuilderSectionsForView
{
    public class GetAllAdvancedFormBuilderSectionsForViewQuery : IRequest<BaseResponse<List<AdvancedFormBuilderSectionListVM>>>
    {
        public int VirtualTableForSectionId { get; set; }
        public string? lang { get; set; }
        public int page { get; set; }
        public int perPage { get; set; }
    }
}
