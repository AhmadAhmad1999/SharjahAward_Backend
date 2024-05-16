using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.InterviewFeatures.Queries.GetInterviewById
{
    public class GetInterviewByIdQuery : IRequest<BaseResponse<GetInterviewByIdDto>>
    {
        public int Id { get; set; }
        public string? lang { get; set; }
    }
}
