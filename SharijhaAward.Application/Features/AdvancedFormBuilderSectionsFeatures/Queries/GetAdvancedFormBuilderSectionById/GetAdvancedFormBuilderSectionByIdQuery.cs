using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderSectionsFeatures.Queries.GetAdvancedFormBuilderSectionById
{
    public class GetAdvancedFormBuilderSectionByIdQuery : IRequest<BaseResponse<GetAdvancedFormBuilderSectionByIdDto>>
    {
        public int Id { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
