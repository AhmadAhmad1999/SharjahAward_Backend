﻿using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.CriterionFeatures.Commands.CheckIfAllCritrionsHaveAttachment
{
    public class CheckIfAllCritrionsHaveAttachmentCommand : IRequest<BaseResponse<object>>
    {
        public int CategoryId { get; set; }
        public int ProvidedFormId { get; set; }
        public string? lang { get; set; }
    }
}
