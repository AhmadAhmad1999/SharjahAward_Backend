using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ExtraAttachments.Commands.UpdateExtraAttachment
{
    public class UpdateExtraAttachmentQuery : IRequest<BaseResponse<object>>
    {
        public Guid Id { get; set; }
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public string ArabicDescription { get; set; } = string.Empty;
        public string EnglishDescription { get; set; } = string.Empty;
        public int RequiredAttachmentNumber { get; set; }
        public AttachmentType AttachmentType { get; set; }
        public int SizeOfAttachmentInKB { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
