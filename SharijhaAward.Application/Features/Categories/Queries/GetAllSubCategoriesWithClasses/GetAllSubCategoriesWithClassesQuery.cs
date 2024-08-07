using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Categories.Queries.GetAllSubCategoriesWithClasses
{
    public class GetAllSubCategoriesWithClassesQuery : IRequest<BaseResponse<List<GetAllSubCategoriesWithClassesListVM>>>
    {
        public string? CategoryName { get; set; }
        public string? lang { get; set; }
    }
}
