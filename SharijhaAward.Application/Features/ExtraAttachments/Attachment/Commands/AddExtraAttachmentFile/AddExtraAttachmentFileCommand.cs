using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ExtraAttachments.Attachment.Commands.AddExtraAttachmentFile
{
    public class AddExtraAttachmentFileCommand : IRequest<BaseResponse<object>>
    {
        public string FileName { get; set; } = string.Empty;
        public string FileDescription { get; set; } = string.Empty;
        public int ExtraAttachmentId { get; set; }
        public IFormFile File { get; set; } = null!;
        public string lang { get; set; } = string.Empty;
    }
}
