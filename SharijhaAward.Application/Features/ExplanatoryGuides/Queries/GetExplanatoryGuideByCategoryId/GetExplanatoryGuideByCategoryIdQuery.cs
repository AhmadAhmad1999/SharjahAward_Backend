﻿using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ExplanatoryGuides.Queries.GetExplanatoryGuideByCategoryId
{
    public class GetExplanatoryGuideByCategoryIdQuery : IRequest<BaseResponse<ExplanatoryGuideDto>>
    {
        public int CategoryId { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
