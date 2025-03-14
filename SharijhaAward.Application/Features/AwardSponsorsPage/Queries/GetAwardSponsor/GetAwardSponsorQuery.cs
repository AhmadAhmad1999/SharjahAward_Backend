﻿using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.AwardSponsorsPage.Queries.GetAwardSponsor
{
    public class GetAwardSponsorQuery : IRequest<BaseResponse<AwardSponsorListVM>>
    {
        public string? lang { get; set; }
    }
}
