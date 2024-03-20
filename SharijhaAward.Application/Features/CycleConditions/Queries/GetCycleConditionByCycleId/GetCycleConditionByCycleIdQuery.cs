﻿using MediatR;
using SharijhaAward.Application.Features.CycleConditions.Queries.GetCycleConditionById;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.CycleConditions.Queries.GetCycleConditionByCycleId
{
    public class GetCycleConditionByCycleIdQuery : IRequest<BaseResponse<List<CycleConditionDto>>>
    {
        public Guid CycleId { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
