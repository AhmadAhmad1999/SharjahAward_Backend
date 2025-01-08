using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllFilesByFormId
{
    public class GetAllFilesByFormIdQuery : IRequest<BaseResponse<List<GetAllFilesByFormIdMainResponse>>>
    {
        public int Id { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
