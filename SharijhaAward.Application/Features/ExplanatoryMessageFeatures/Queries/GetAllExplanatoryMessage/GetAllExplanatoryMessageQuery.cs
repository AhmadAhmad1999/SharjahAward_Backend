﻿using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;

namespace SharijhaAward.Application.Features.ExplanatoryMessageFeatures.Queries.GetAllExplanatoryMessage
{
    public class GetAllExplanatoryMessageQuery : IRequest<BaseResponse<List<GetAllExplanatoryMessageListVM>>>
    {
        public string? lang { get; set; }
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
        public List<Filter>? filters { get; set; }
    }
}
