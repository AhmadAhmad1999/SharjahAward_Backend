using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.GeneralFAQs.Commands.CreateGeneralFAQ
{
    public class CreateGeneralFAQCommand : IRequest<BaseResponse<object>>
    {
        public string ArabicQuestion { get; set; } = null!;
        public string EnglishQuestion { get; set; } = null!;
        public string ArabicAnswer { get; set; } = null!;
        public string EnglishAnswer { get; set; } = null!;
        public int GeneralFrequentlyAskedQuestionCategoryId { get; set; }
        public string? lang { get; set; }
    }
}
