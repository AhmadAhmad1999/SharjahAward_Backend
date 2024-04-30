using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.RelatedAccountFeatures.Commands.CreateDirectRelating
{
    public class CreateDirectRelatingCommand : IRequest<BaseResponse<object>>
    {
        public int SenderId { get; set; }
        public string ReceiverEmail { get; set; } = null!;
        public string? lang { get; set; }
    }
}
