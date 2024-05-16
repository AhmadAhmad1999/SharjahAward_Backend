﻿using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ArbitrationAuditFeatures.Commands.RejectInitialArbiitrationFromArbitrationAudit
{
    public class RejectInitialArbiitrationFromArbitrationAuditCommand : IRequest<BaseResponse<object>>
    {
        public int FormId { get; set; }
        public string? lang { get; set; }
    }
}
