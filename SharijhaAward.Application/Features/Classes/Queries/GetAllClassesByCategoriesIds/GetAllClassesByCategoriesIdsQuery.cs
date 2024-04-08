using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Classes.Queries.GetAllClassesByCategoriesIds
{
    public class GetAllClassesByCategoriesIdsQuery : IRequest<BaseResponse<List<GetAllClassesByCategoriesIdsListVM>>>
    {
        public List<Guid> CategoriesIds { get; set; } = new List<Guid>();
        public string? lang { get; set; }
        public int page { get; set; }
        public int pageSize { get; set; }
    }
}
