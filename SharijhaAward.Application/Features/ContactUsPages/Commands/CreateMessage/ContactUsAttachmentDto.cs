using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ContactUsPages.Commands.CreateMessage
{
    public class ContactUsAttachmentDto
    {
        public IFormFile? Attachment { get; set; } = null!;
        public string? AttachmentName { get; set; } = null!;
    }
}
