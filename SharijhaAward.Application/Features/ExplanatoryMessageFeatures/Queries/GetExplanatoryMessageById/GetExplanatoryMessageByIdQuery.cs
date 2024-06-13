using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ExplanatoryMessageModel;

namespace SharijhaAward.Application.Features.ExplanatoryMessageFeatures.Queries.GetExplanatoryMessageById
{
    public class GetExplanatoryMessageByIdQuery : IRequest<BaseResponse<GetExplanatoryMessageByIdDto>>
    {
        public int? Id { get; set; }
        public TypeOfExplantoryMessage? Type { get; set; }
        public string? lang { get; set; }
    }
}
