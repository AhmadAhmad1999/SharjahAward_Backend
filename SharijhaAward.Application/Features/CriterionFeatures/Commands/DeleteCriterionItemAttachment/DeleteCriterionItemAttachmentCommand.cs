﻿using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.CriterionFeatures.Commands.DeleteCriterionItemAttachment
{
    public class DeleteCriterionItemAttachmentCommand : IRequest<BaseResponse<object>>
    {
        public int CriterionItemAttachmentId { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
