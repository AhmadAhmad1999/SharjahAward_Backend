using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Classes.Queries.GetClassById
{
    public class GetClassByIdQuery : IRequest<BaseResponse<GetClassByIdDto>>
    {
        public int Id { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
