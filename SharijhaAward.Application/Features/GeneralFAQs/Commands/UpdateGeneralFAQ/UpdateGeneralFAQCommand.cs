using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.GeneralFAQs.Commands.UpdateGeneralFAQ
{
    public class UpdateGeneralFAQCommand : IRequest<BaseResponse<object>>
    {
        public Guid Id { get; set; }
        public string ArabicQuestion { get; set; } = null!;
        public string EnglishQuestion { get; set; } = null!;
        public string ArabicAnswer { get; set; } = null!;
        public string EnglishAnswer { get; set; } = null!;
        public string? lang { get; set; }
    }
}
