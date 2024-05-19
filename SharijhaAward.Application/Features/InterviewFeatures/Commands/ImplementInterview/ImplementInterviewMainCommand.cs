using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.InterviewFeatures.Commands.ImplementInterview
{
    public class ImplementInterviewMainCommand : IRequest<BaseResponse<object>>
    {
        public string? lang { get; set; }
        public string? WWWRootFilePath { get; set; }
        public int InterviewId { get; set; }
        public List<ImplementInterviewCommand> ImplementInterviewCommand { get; set; } = new List<ImplementInterviewCommand>();
    }
}
