using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Classes.Queries.GetAllCategoryClassesByCategoryId
{
    public class GetAllCategoryClassesByCategoryIdQuery : IRequest<BaseResponse<List<GetAllCategoryClassesByCategoryIdDto>>>
    {
        public Guid CategoryId { get; set; }
        public string? lang { get; set; }
    }
}
