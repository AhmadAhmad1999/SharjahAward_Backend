using Microsoft.AspNetCore.Http;

namespace SharijhaAward.Application.Features.InterviewFeatures.Commands.ImplementInterviewInvitee
{
    public class ImplementInterviewInviteeCommand 
    {
        public string? Description { get; set; }
        public IFormFile AttachmentFile { get; set; } = null!;
    }
}
