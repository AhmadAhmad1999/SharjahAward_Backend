﻿using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Arbitrators.Commands.DeleteArbitratorClass
{
    public class DeleteArbitratorClassCommand : IRequest<BaseResponse<object>>
    {
        public int ArbitratorId { get; set; }
        public int CategoryEducationalClassId { get; set; }
        public string? lang { get; set; }
    }
}
