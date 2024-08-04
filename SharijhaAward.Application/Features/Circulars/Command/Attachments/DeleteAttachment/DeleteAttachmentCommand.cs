using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Circulars.Command.Attachments.DeleteAttachment
{
    public class DeleteAttachmentCommand : IRequest<BaseResponse<object>>
    {
        public int CircularFileId {  get; set; }
        public string? lang { get; set; }
    }
}
