using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Categories.Queries.GetAllCategoriesWithCycleNumber
{
    public class GetAllCategoriesWithCycleNumberQuery : IRequest<BaseResponse<List<GetAllCategoriesWithCycleNumberListVM>>>
    {
        public string lang { get; set; } = string.Empty;
    }
}