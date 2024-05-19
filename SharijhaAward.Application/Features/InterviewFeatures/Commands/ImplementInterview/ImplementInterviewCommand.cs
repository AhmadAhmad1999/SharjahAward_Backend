using Microsoft.AspNetCore.Http;

namespace SharijhaAward.Application.Features.InterviewFeatures.Commands.ImplementInterview
{
    public class ImplementInterviewCommand 
    {
        public string? Description { get; set; }
        public IFormFile AttachmentFile { get; set; } = null!;
    }
}
