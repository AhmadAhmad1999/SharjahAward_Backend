using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.CriterionFeatures.Commands.CheckIfAllCritrionsHaveAttachment
{
    public class CheckIfAllCritrionsHaveAttachmentCommand : IRequest<BaseResponse<object>>
    {
        public int CategoryId { get; set; }
        public int ProvidedFormId { get; set; }
        public string? lang { get; set; }
    }
}
