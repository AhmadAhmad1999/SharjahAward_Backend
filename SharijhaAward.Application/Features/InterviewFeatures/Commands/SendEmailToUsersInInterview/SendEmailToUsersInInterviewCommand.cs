using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.InterviewFeatures.Commands.SendEmailToUsersInInterview
{
    public class SendEmailToUsersInInterviewCommand : IRequest<BaseResponse<object>>
    {
        public int? InterviewId { get; set; }
        public int? InterviewInviteeId { get; set; }
        public string? lang { get; set; }
        public string? WWWRootFilePath { get; set; }
    }
}
