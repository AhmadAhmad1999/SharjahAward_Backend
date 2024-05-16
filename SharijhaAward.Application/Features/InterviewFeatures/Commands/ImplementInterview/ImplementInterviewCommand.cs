using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.InterviewFeatures.Commands.ImplementInterview
{
    public class ImplementInterviewCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string? lang { get; set; }
        public IFormFile AttachmentFile { get; set; } = null!;
        public string? WWWRootFilePath { get; set; }
    }
}
