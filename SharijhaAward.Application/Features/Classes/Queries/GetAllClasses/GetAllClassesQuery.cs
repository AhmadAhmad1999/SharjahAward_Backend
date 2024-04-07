using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Classes.Queries.GetAllClasses
{
    public class GetAllClassesQuery : IRequest<BaseResponse<List<GetAllClassesListVM>>>
    {
        public Guid? CycleId { get; set; }
        public string? lang { get; set; }
        public int page { get; set; }
        public int pageSize { get; set; }
    }
}
