﻿using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TermsAndConditions.Attacments.Queries.AcceptOnSpecialConditionAttachments
{
    public class AcceptOnSpecialConditionAttachmentsQuery : IRequest<BaseResponse<object>>
    {
        public int AttachmentId { get; set; }
        public bool IsAccept { get; set; }
        public string? ReasonOfReject { get; set; }
        public string? lang { get; set; }
    }
}
