using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ExtraAttachments.Attachment.Commands.AddExtraAttachmentFile
{
    public class AddExtraAttachmentFileCommand : IRequest<BaseResponse<object>>
    {
        public string lang { get; set; } = string.Empty;
        public int ExtraAttachmentId { get; set; }
        public IFormFile File { get; set; } = null!;
    }
}
