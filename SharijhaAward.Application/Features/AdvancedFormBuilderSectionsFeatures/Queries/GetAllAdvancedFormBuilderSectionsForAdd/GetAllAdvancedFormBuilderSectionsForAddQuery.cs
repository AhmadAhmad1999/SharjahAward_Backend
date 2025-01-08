using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderSectionsFeatures.Queries.GetAllAdvancedFormBuilderSectionsForAdd
{
    public class GetAllAdvancedFormBuilderSectionsForAddQuery : IRequest<BaseResponse<List<GetAllAdvancedFormBuilderSectionsForAddListVM>>>
    {
        public string PrivateHashKey { get; set; } = null!;
        public int? VirtualTableId { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
