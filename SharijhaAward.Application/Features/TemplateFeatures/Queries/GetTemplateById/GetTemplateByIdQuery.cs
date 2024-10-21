using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.TemplateFeatures.Queries.GetTemplateById
{
    public class GetTemplateByIdQuery : IRequest<BaseResponse<GetTemplateByIdDto>>
    {
        public int Id { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
