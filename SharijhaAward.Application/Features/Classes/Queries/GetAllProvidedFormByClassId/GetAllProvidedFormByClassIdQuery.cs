using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Classes.Queries.GetAllProvidedFormByClassId
{
    public class GetAllProvidedFormByClassIdQuery : IRequest<BaseResponse<List<GetAllProvidedFormByClassIdListVM>>>
    {
        public Guid EducationallassId { get; set; }
        public int page { get; set; }
        public int pageSize { get; set; }
        public string? lang { get; set; }
    }
}
