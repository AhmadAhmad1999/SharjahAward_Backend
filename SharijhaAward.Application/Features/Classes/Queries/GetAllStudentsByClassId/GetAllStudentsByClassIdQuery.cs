using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Classes.Queries.GetAllStudentsByClassId
{
    public class GetAllStudentsByClassIdQuery : IRequest<BaseResponse<List<GetAllStudentsByClassIdListVM>>>
    {
        public int EducationalClassId { get; set; }
        public int page { get; set; }
        public int pageSize { get; set; }
        public string? lang { get; set; }
    }
}
