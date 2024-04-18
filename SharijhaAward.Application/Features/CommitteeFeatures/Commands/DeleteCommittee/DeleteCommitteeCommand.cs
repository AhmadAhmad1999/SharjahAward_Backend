using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.CommitteeFeatures.Commands.DeleteCommittee
{
    public class DeleteCommitteeCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string? lang { get; set; }
    }
}
