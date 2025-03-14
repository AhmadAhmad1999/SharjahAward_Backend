﻿using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.CriterionFeatures.Queries.GetMainCriterionById
{
    public class GetMainCriterionByIdQuery : IRequest<BaseResponse<GetMainCriterionByIdDto>>
    {
        public int Id { get; set; }
        public string? lang { get; set; }
    }
}
