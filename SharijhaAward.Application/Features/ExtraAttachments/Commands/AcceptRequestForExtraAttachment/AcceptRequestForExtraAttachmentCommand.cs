using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ExtraAttachments.Commands.AcceptRequestForExtraAttachment
{
    public class AcceptRequestForExtraAttachmentCommand : IRequest<BaseResponse<object>>
    {
        public int ExtraAttachmentId { get; set; }
        public string? lang { get; set; }
    }
}
