using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.InterviewFeatures.Queries.GetAllFormsByItsEligibleStatus
{
    public class GetAllFormsByItsEligibleStatusQuery : IRequest<BaseResponse<List<GetAllFormsByItsEligibleStatusListVM>>>
    {
        public StatusFilter StatusFilter { get; set; }
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
        public string? lang { get; set; }
    }
}
