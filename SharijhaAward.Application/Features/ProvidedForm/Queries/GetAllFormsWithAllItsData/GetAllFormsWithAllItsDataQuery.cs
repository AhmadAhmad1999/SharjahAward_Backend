using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;

namespace SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllFormsWithAllItsData
{
    public class GetAllFormsWithAllItsDataQuery : IRequest<BaseResponse<List<GetAllFormsWithAllItsDataListVM>>>
    {
        public List<Filter>? filters { get; set; }
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
        public string? lang { get; set; }
    }
}
