﻿using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TermsAndConditions.Attacments.Commands.DeleteAttachment
{
    public class DeleteAttachmentCommand : IRequest<BaseResponse<object>>
    {
        public Guid AttachmentId { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
