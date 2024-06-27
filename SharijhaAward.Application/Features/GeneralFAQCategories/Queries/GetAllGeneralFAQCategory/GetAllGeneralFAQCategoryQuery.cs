using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.GeneralFAQCategories.Queries.GetAllGeneralFAQCategory
{
    public class GetAllGeneralFAQCategoryQuery : IRequest<BaseResponse<List<GetAllGeneralFAQCategoryListVM>>>
    {
        public string? lang { get; set; }
        public int page { get; set; }
        public int perPage { get; set; }
    }
}
