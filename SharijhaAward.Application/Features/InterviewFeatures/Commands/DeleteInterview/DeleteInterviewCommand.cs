using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.InterviewFeatures.Commands.DeleteInterview
{
    public class DeleteInterviewCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string? lang { get; set; }
    }
}
