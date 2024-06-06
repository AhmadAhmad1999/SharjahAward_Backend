﻿using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;

namespace SharijhaAward.Application.Features.InterviewFeatures.Queries.GetAllInterviewsForInterviewStep
{
    public class GetAllInterviewsForInterviewStepQuery : IRequest<BaseResponse<List<GetAllInterviewsForInterviewStepListVM>>>
    {
        public bool? isCanceled { get; set; }
        public bool? isImplemented { get; set; }
        public string? lang { get; set; }
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
        public List<Filter>? filters { get; set; }
    }
}
