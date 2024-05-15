using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.InitialArbitrationFeatures.Commands.DeleteChairmanNotesOnInitialArbitration
{
    public class DeleteChairmanNotesOnInitialArbitrationCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string? lang { get; set; }
    }
}
