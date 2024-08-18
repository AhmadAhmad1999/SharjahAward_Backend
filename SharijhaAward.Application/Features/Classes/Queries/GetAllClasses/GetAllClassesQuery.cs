using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;

namespace SharijhaAward.Application.Features.Classes.Queries.GetAllClasses
{
    public class GetAllClassesQuery : IRequest<BaseResponse<List<GetAllClassesListVM>>>
    {
        public string? lang { get; set; }
        public List<Filter>? filters { get; set; }
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
    }
}
