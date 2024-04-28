using MediatR;
using SharijhaAward.Application.Features.Categories.Queries.GetAllCategoriesWithCycleNumber;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Categories.Queries.GetAllSubCategories
{
    public class GetAllSubCategoriesQuery : IRequest<BaseResponse<List<GetAllSubCategoriesListVM>>>
    {
        public string lang { get; set; } = string.Empty;
    }
}