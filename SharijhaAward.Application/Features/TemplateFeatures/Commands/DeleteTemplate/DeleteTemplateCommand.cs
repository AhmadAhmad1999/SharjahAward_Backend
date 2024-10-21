using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.TemplateFeatures.Commands.DeleteTemplate
{
    public class DeleteTemplateCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string? lang { get; set; }
    }
}
