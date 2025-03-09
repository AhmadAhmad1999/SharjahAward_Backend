using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;

namespace SharijhaAward.Application.Features.PageStructures.Pages.Queries.GetMainPagesWithSubPages
{
    public class GetMainPagesWithSubPagesQuery : IRequest<BaseResponse<GetMainPagesWithSubPagesResponse>>
    {
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
        public string? lang { get; set; }
        public List<Filter>? filters { get; set; }
        public bool? intoWebsite { get; set; }
    }
}
