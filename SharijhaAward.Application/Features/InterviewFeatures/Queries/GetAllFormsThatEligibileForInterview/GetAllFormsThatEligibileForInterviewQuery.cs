using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.InterviewFeatures.Queries.GetAllFormsThatEligibileForInterview
{
    public class GetAllFormsThatEligibileForInterviewQuery : IRequest<BaseResponse<List<GetAllFormsThatEligibileForInterviewListVM>>>
    {
        public int page { get; set; }
        public int perPage { get; set; }
        public string? lang { get; set; }
    }
}
