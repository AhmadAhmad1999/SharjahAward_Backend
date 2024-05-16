using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;

namespace SharijhaAward.Application.Features.InterviewFeatures.Queries.GetAllFormsForInterviewStep
{
    public class GetAllFormsForInterviewStepQuery : IRequest<BaseResponse<List<GetAllFormsForInterviewStepListVM>>>
    {
        public bool? isCanceled { get; set; }
        public bool? isImplemented { get; set; }
        public string? lang { get; set; }
        public int page { get; set; }
        public int pageSize { get; set; }
        public List<Filter>? filters { get; set; }
    }
}
