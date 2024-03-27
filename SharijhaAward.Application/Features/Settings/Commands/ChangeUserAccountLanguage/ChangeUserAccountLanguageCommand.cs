using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Settings.Commands.ChangeUserAccountLanguage
{
    public class ChangeUserAccountLanguageCommand : IRequest<BaseResponse<object>>
    {
        public string? Token { get; set; }
        public string? lang { get; set; }
        public string NewLanguage { get; set; } = null!;
    }
}
