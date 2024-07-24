﻿using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ExtraAttachments.Queries.CheckAllExtraAttachment
{
    public class CheckAllExtraAttachmentQuery : IRequest<BaseResponse<object>>
    {
        public string lang { get; set; } = string.Empty;
        public string token { get; set; } = string.Empty;
        public int formId { get; set; }
    }
}
