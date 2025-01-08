using MediatR;
using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.NewsTickerFeatures.Commands.UpdateNewsTicker
{
    public class UpdateNewsTickerCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        [ArabicNameValidation]
        public string ArabicText { get; set; } = null!;
        [EnglishNameValidation]
        public string EnglishText { get; set; } = null!;
        public bool isActive { get; set; }
        public string? lang { get; set; }
    }
}
