﻿using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ExplanatoryGuides.Commands.DeleteExplanatoryGuide
{
    public class DeleteExplanatoryGuideCommand : IRequest<BaseResponse<object>>
    {
        public int GuideId { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
