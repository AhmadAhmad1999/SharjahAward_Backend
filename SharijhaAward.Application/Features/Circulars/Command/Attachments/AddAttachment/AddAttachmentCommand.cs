using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Circulars.Command.Attachments.AddAttachment
{
    public class AddAttachmentCommand : IRequest<BaseResponse<object>>
    {
        public IFormFile CircularFile { get; set; } = null!;
        public string FileName { get; set; } = null!;
        public int CircularId { get; set; }
        public string? lang { get; set; }
    }
}
