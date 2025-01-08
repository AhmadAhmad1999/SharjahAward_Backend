using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.TemplateModel;

namespace SharijhaAward.Application.Features.TemplateFeatures.Commands.CreateTemplate
{
    public class CreateTemplateCommand : IRequest<BaseResponse<object>>
    {
        public IFormFile? BackgroundImageFile { get; set; }
        public string? BackgroundImageColor { get; set; }
        public string FontColor { get; set; } = null!;
        public string TemplateVersion { get; set; } = null!;
        public TemplateTypes TemplateType { get; set; }
        public bool isActive { get; set; }
        public string? lang { get; set; }
        public string? WWWRootFilePath { get; set; }
    }
}
