using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.InterviewFeatures.Commands.ImplementInterviewInvitee
{
    public class ImplementInterviewInviteeMainCommand : IRequest<BaseResponse<object>>
    {
        public string? lang { get; set; }
        public string? WWWRootFilePath { get; set; }
        public int InterviewInviteeId { get; set; }
        public List<ImplementInterviewInviteeCommand> ImplementInterviewInviteeCommand { get; set; } = new List<ImplementInterviewInviteeCommand>();
    }
}
