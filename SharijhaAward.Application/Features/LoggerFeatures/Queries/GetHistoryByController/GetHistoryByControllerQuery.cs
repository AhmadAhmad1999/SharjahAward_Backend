﻿using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;

namespace SharijhaAward.Application.Features.LoggerFeatures.Queries.GetHistoryByController
{
    public class GetHistoryByControllerQuery : IRequest<BaseResponse<List<GetHistoryByControllerListVM>>>
    {
        public string? ControllerName { get; set; } = null!;
        public string? lang { get; set; }
        public string? Token { get; set; }
        public string? UserName { get; set; } 
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
        public List<Filter>? filters { get; set; }
    }
}
