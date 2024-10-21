using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.TemplateFeatures.Commands.ActivateTemplate
{
    public class ActivateTemplateCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string? lang { get; set; }
    }
}
