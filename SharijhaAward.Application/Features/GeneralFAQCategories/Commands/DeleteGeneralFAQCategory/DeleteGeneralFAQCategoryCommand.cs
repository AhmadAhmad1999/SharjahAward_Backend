using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.GeneralFAQCategories.Commands.DeleteGeneralFAQCategory
{
    public class DeleteGeneralFAQCategoryCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string? lang { get; set; }
    }
}
