using MediatR;
using SharijhaAward.Application.Features.FAQs.Queries.GetAllFAQs;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;

namespace SharijhaAward.Application.Features.GeneralFAQs.Queries.GetAllGeneralFAQs
{
    public class GetAllGeneralFAQQuery : IRequest<BaseResponse<List<GetAllGeneralFAQListVM>>>
    {
        public int? CategoryId { get; set; }
        public string? lang { get; set; }
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
        public List<Filter>? filters { get; set; }
    }
}
