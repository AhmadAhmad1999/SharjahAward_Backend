﻿using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Arbitrators.Queries.GetArbitratorById
{
    public class GetArbitratorByIdQuery : IRequest<BaseResponse<GetArbitratorByIdResponse>>
    {
        public int ArbitratorId { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
