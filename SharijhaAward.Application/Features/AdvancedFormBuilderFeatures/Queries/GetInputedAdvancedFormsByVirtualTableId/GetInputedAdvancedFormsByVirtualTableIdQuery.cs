using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Queries.GetInputedAdvancedFormsByVirtualTableId
{
    public class GetInputedAdvancedFormsByVirtualTableIdQuery 
        : IRequest<BaseResponse<GetInputedAdvancedFormsByVirtualTableIdDto>>
    {
        public string? lang { get; set; }
        public int VirtualTableForSectionId { get; set; }
        public int VirtualTableId { get; set; }
    }
}