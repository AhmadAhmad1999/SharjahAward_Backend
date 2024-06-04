using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ExplanatoryMessageFeatures.Queries.GetExplanatoryMessageById
{
    public class GetExplanatoryMessageByIdQuery : IRequest<BaseResponse<GetExplanatoryMessageByIdDto>>
    {
        public int Id { get; set; }
        public string? lang { get; set; }
    }
}
