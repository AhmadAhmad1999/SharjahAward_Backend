using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ContactUsPages.Commands.ResponseForWebsite
{
    public class ResponseForWebsiteCommand : IRequest<BaseResponse<int>>
    {
        public int MessageId { get; set; }
        public string Title { get; set; } = null!;
        public string Body { get; set; } = null!;
        public List<IFormFile> Attachments { get; set; } = new List<IFormFile>();
        public string? token { get; set; }
        public string? lang { get; set; }
        public string EmailToSendLanguage { get; set; } = null!;
        public string? WWWRootFilePath { get; set; }
    }
}
