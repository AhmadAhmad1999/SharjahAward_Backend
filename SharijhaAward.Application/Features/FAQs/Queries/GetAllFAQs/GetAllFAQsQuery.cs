using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.FAQs.Queries.GetAllFAQs
{
    public class GetAllFAQsQuery : IRequest<BaseResponse<List<FAQListVm>>>
    {
        public string lang { get; set; } = string.Empty;
        public int page {  get; set; }
        public int pageSize { get; set; }
    }
}
