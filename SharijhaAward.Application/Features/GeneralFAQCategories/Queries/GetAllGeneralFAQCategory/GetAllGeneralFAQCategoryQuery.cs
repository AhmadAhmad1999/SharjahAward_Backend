using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using System.Drawing;

namespace SharijhaAward.Application.Features.GeneralFAQCategories.Queries.GetAllGeneralFAQCategory
{
    public class GetAllGeneralFAQCategoryQuery : IRequest<BaseResponse<List<GetAllGeneralFAQCategoryListVM>>>
    {
        public string? lang { get; set; }
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
        public string? searchQuery {  get; set; }
        public List<Filter>? filters { get; set; }
    }
}
