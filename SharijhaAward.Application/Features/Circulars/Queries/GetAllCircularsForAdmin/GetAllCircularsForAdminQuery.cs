using MediatR;
using SharijhaAward.Application.Features.Circulars.Queries.GetAllCirculars;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;

namespace SharijhaAward.Application.Features.Circulars.Queries.GetAllCircularsForAdmin
{
    public class GetAllCircularsForAdminQuery : IRequest<BaseResponse<CircularListVm>>
    {
        public List<Filter>? filters { get; set; }
        public string? lang { get; set; }
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
    }
}
