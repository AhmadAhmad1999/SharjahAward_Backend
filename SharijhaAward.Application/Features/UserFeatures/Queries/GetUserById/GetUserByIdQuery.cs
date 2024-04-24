using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.UserFeatures.Queries.GetUserById
{
    public class GetUserByIdQuery : IRequest<BaseResponse<GetUserByIdDto>>
    {
        public int Id { get; set; }
        public string? lang { get; set; }
    }
}
