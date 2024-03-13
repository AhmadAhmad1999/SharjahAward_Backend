using MediatR;
using SharijhaAward.Application.Features.FAQs.Queries.GetAllFAQs;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.GeneralFAQs.Queries.GetAllGeneralFAQs
{
    public class GetAllGeneralFAQQuery : IRequest<BaseResponse<List<GetAllGeneralFAQListVM>>>
    {
        public string? lang { get; set; }
        public int page { get; set; }
        public int pageSize { get; set; }
    }
}
