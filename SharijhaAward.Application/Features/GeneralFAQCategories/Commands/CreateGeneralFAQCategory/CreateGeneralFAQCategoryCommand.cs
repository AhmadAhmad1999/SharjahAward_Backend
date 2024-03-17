using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.GeneralFAQCategories.Commands.CreateGeneralFAQCategory
{
    public class CreateGeneralFAQCategoryCommand : IRequest<BaseResponse<object>>
    {
        public string ArabicName { get; set; } = null!;
        public string EnglishName { get; set; } = null!;
        public string? lang { get; set; }
    }
}
