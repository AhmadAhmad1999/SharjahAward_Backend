using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.RelatedAccountFeatures.Commands.CancelRelating
{
    public class CancelRelatingCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string? Token { get; set; }
        public string? lang { get; set; }
    }
}
