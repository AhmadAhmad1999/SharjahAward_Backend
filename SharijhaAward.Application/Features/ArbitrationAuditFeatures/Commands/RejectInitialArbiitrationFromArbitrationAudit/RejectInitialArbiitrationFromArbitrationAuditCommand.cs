﻿using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;

namespace SharijhaAward.Application.Features.ArbitrationAuditFeatures.Commands.RejectInitialArbiitrationFromArbitrationAudit
{
    public class RejectInitialArbiitrationFromArbitrationAuditCommand : IRequest<BaseResponse<object>>
    {
        public int FormId { get; set; }
        public FormStatus IsAccepted { get; set; }
        public string? ReasonForRejecting { get; set; }
        public string? Token { get; set; }
        public string? lang { get; set; }
    }
}
